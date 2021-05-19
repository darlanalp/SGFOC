using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using System.Data;

namespace DRProjetoCadastro.BLL
{
    public class DRAcompServer : DRDataBase
    {
        public void ReadEtapas_Atividades(DataSet ds, int codProjeto) 
        {
            DBCon.Fill(ds.Tables["DRETAPA"], @"SELECT * FROM DRETAPA WHERE CODIGOPRJ=@1", codProjeto);
            DBCon.Fill(ds.Tables["DRAtividade"], @"SELECT * FROM DRATIVIDADE WHERE CODIGOPRJ=@1", codProjeto);
        }

        public void DeletaEtapa(object[] pk) 
        {
            DBCon.ExecSQL("DELETE FROM DRETAPA WHERE CODIGOPRJ = @1 AND CODETAPA =@2", pk);
        }

        public void DeletaAtividade(object[] pk) 
        {
            DBCon.ExecSQL("DELETE FROM DRATIVIDADE WHERE CODIGOPRJ = @1 AND CodigoAtividade =@2", pk);
        }

        /// <summary>
        /// Recupera o custo toral da atividade que é o somatório das despesas
        /// </summary>
        public decimal GetCustoTotalRealizadoAtividade(int codProjeto, int codEtapa, int codAtividade) 
        {
            string sql = @"SELECT ISNULL(SUM(CUSTOFINAL),0) FROM DRDESPESA WHERE
                          CODIGOPRJ=@1 AND CODETAPA =@2 AND CODIGOATIVIDADE=@3 AND
                          STATUS = 'R'";
            return Convert.ToDecimal( DBCon.QueryValue(sql, codProjeto, codEtapa, codAtividade));
        }

        public void GetInformacaoPDF(DSCadastro ds, int codProjeto) 
        {
            DBCon.Fill(ds.Tables["DREtapa"], "SELECT * FROM DRETAPA WHERE CODIGOPRJ = @1", codProjeto);
            DBCon.Fill(ds.Tables["DRATIVIDADE"], "SELECT * FROM DRATIVIDADE WHERE CODIGOPRJ = @1", codProjeto);
            DBCon.Fill(ds.Tables["DRDESPESA"], "SELECT * FROM DRDESPESA WHERE CODIGOPRJ = @1", codProjeto);
        } 

    }
}
