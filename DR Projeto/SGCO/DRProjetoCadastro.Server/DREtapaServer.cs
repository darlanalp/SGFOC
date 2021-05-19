using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Utils;
using DR.Lib.Winform;
using System.Data;
using DRProjetoCadastro.BLL.Properties;

namespace DRProjetoCadastro.BLL
{
    public class DREtapaServer : DRData
    {        
        public CronogramaParam ParamServer
        {
            get { if (_ParamServer == null) _ParamServer = new CronogramaParam(); return _ParamServer; }
            set { _ParamServer = value; }
        } private CronogramaParam _ParamServer;

       
        protected override void DoAlteraRegistro(System.Data.DataRow row)
        {

        }

        protected override void DoCancelaRegistro(System.Data.DataRow row)
        {
           
        }

        protected override void DoCriaDataSet(out System.Data.DataSet dataSet)
        {
            dataSet = new DSCadastro();
        }

        protected override void DoExecutaAposSalvar()
        {
        }

        protected override void DoNovoRegistro(System.Data.DataRow row)
        {
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRETAPA (NOLOCK) WHERE  CODIGOPRJ =@1 AND CodEtapa = @2";
            DBCon.Fill(dataSet.Tables["DRETAPA"], sql, pk);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "CODETAPA", ColProps.DisplayWidth, 50);
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "DESCRICAO", ColProps.DisplayWidth, 350);

            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "DATAINI", ColProps.Caption, "Data Ínicio");
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "DATATERMINO", ColProps.Caption, "Data Término");
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "TOTALMATERIAL", ColProps.Caption, "Material", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "TOTALMAOOBRA", ColProps.Caption, "Mão de Obra", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "TOTALGERAL", ColProps.Caption, "Valor Total Previsto", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "PERCENTUAL", ColProps.Caption, "% Equivalente na Obra", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "VALORDESPESA", ColProps.Caption, "Valor Total Despesas", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "MostrarGrafico", ColProps.Visible, false);  
                              
            base.ConfiguraDataSetVisao(_dataSet);           
        }

        /// <summary>
        /// SQL Complementar - Identifica o percentual da Etapa em relação ao valor 
        /// total orçado ate o momento 
        /// </summary>
        /// <returns></returns>
        private string GetSQLPercentualEtapaObra()
        {
            return @"(
                       (
                         (SELECT ISNULL( SUM(TOTALGERAL),0) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                          AND CODETAPA LIKE DRETAPA.CODETAPA +'%')*100
                       ) / (SELECT ISNULL( SUM(TOTALGERAL),1)  FROM DRATIVIDADE WHERE CODIGOPRJ = DRETAPA.CODIGOPRJ)
                     )AS PERCENTUAL ";
        }
        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            if (!ParamServer.VisualizacaoTotalizadoresAtivado)
                sql = @"SELECT * FROM DRETAPA (NOLOCK) WHERE CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            else
            {
                sql = @"SELECT *,
                  (SELECT MIN(DATAINI) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ  
                   AND CODETAPA LIKE DRETAPA.CODETAPA +'%') DATAINI,
                  (SELECT MAX(DATATERMINO) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ 
                   AND CODETAPA LIKE DRETAPA.CODETAPA +'%') DATATERMINO,
                   (SELECT ISNULL( SUM( ISNULL(PrecoUnitarioMaterial,0) * ISNULL(QTD,0) ),0) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ AND QTD > 0 
                   AND CODETAPA LIKE DRETAPA.CODETAPA +'%') TOTALMATERIAL,
                   (SELECT ISNULL( SUM(ISNULL(PrecoUnitarioMaoObra,0) * ISNULL(QTD,0) ),0) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ AND QTD > 0 
                   AND CODETAPA LIKE DRETAPA.CODETAPA +'%') TOTALMAOOBRA,
                   (SELECT ISNULL( SUM(TOTALGERAL),0) FROM DRATIVIDADE WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ AND QTD > 0 
                   AND CODETAPA LIKE DRETAPA.CODETAPA +'%') TOTALGERAL,
                   (SELECT ISNULL( SUM(VALOR),0) FROM DRDESPESA WHERE CODIGOPRJ= DRETAPA.CODIGOPRJ AND STATUS='A'
                   AND CODETAPA LIKE DRETAPA.CODETAPA +'%') VALORDESPESA,
                   {0}                
                   FROM DRETAPA (NOLOCK)WHERE CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
                sql = string.Format(sql, GetSQLPercentualEtapaObra());
            }
            nomeTableVisao = "DRETAPA";
        }


        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
           
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            if (DBCon.QueryFind("SELECT 1 FROM DRATIVIDADE WHERE CODIGOPRJ=@1 AND CODETAPA=@2",
                                row["CodigoPrj"], row["CodEtapa"]))
            {
                throw new Exception(Resources.ValidaExclusaoEtapa);
            }           
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
            
          
        }
    }

    public class CronogramaParam 
    {
        public bool VisualizacaoTotalizadoresAtivado = false;
    }
}
