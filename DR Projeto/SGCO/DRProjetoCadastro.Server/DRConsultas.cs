using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using System.Data;

namespace DRProjetoCadastro.BLL
{
    public class DRConsultas : DRDataBase
    {
        public void GetPercentualEtapaObra(DataSet ds,int codigoPrj)
        {
            string sql = @"SELECT CodigoPrj,Nome,
            (
              (
                (SELECT ISNULL( SUM(PercentualCompletude),0) FROM DRATIVIDADE(NOLOCK)  WHERE CODIGOPRJ= DRPROJETO.CODIGOPRJ 
                 AND TotalGeral > 0 )  
               )
               /
               (SELECT COUNT(*) FROM DRATIVIDADE(NOLOCK)  WHERE CODIGOPRJ= DRPROJETO.CODIGOPRJ AND TotalGeral > 0)
            )PERCENTUALCOMPLETUDE
             FROM DRPROJETO (NOLOCK) 
             WHERE  
             CODIGOPRJ = @1  AND 
             (SELECT COUNT(*) FROM DRATIVIDADE(NOLOCK)  WHERE DRATIVIDADE.CODIGOPRJ = DRPROJETO.CODIGOPRJ )>0";
            DBCon.Fill(ds.Tables["DRProjetoPercentualCompletude"], sql, codigoPrj);

            if (ds.Tables["DRProjetoPercentualCompletude"].Rows.Count > 0)
            {
                int percentRestante = 100 - Convert.ToInt32(ds.Tables["DRProjetoPercentualCompletude"].Rows[0]["PERCENTUALCOMPLETUDE"]);
                if (percentRestante > 0)
                {
                    DataRow Row = ds.Tables["DRProjetoPercentualCompletude"].NewRow();
                    Row["CodigoPrj"] = 0000;
                    Row["Nome"] = "Restante";
                    Row["PERCENTUALCOMPLETUDE"] = percentRestante;
                    ds.Tables["DRProjetoPercentualCompletude"].Rows.Add(Row);
                }
            }
        }
        public void GetEtapaOrcadoRealizado(DataSet ds, int codigoPrj) 
        {
            string sql = @"SELECT CodEtapa,DESCRICAO,
            (SELECT ISNULL( SUM(TOTALGERAL),0) FROM DRATIVIDADE(NOLOCK) WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
            AND CODETAPA LIKE DRETAPA.CODETAPA +'%') ORCADO,
            (SELECT ISNULL( SUM(VALOR),0) FROM DRDESPESA(NOLOCK) WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ AND STATUS='A'
            AND CODETAPA LIKE DRETAPA.CODETAPA +'%') EXECUTADO             
            FROM DRETAPA (NOLOCK) WHERE MostrarGrafico = 1 AND CODIGOPRJ =@1";
            DBCon.Fill(ds.Tables["DRETAPAORCADOREALIZADO"], sql, codigoPrj);
        }
        public void GetPercentualCompletudeEtapa(DataSet ds, int codigoPrj) 
        {
            string sql = @"SELECT CodEtapa,DESCRICAO,
                           (
                             (
                               (SELECT ISNULL( SUM(PercentualCompletude),0) FROM DRATIVIDADE(NOLOCK)  WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                                AND TotalGeral > 0 AND CODETAPA LIKE DRETAPA.CODETAPA +'%')  
                              )
                              /
                               (SELECT COUNT(*) FROM DRATIVIDADE(NOLOCK)  WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ AND TotalGeral > 0
                                AND CODETAPA LIKE DRETAPA.CODETAPA +'%')
                           )PERCENTUALCOMPLETUDE
                            FROM DRETAPA (NOLOCK) 
                            WHERE  CODIGOPRJ =@1 AND MostrarGrafico = 1 AND 
                                 (SELECT COUNT(*) FROM DRATIVIDADE(NOLOCK)  WHERE DRATIVIDADE.CODIGOPRJ = DRETAPA.CODIGOPRJ AND
                                  DRATIVIDADE.CODETAPA =  DRETAPA.CODETAPA)>0";
            DBCon.Fill(ds.Tables["DRETAPAPERCENTUALCOMPLETUDE"], sql, codigoPrj);
        }
    }
}
