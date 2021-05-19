using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Utils;
using System.Data;
using DR.Lib.Winform;
using DRProjetoCadastro.BLL.Properties;


namespace DRProjetoCadastro.BLL
{
    public class DRAtividadeServer : DRData
    {
        public CronogramaParam ParamServer
        {
            get { if (_ParamServer == null) _ParamServer = new CronogramaParam(); return _ParamServer; }
            set { _ParamServer = value; }
        } private CronogramaParam _ParamServer;

        public string GetNextCodigoAtividade(int codigoPrj, string codEtapa) 
        {
            string result = string.Empty;
            object lastCod = DBCon.QueryValue(@"SELECT MAX(CODATIVIDADE) FROM DRATIVIDADE WHERE CODIGOPRJ=@1 AND
                                              CODETAPA =@2",codigoPrj,codEtapa);
            if (lastCod != null)
            {
               string[] quebra = lastCod.ToString().Split('.');
               if (quebra.Length == 0)
               {
                   try
                   {
                       lastCod = Convert.ToInt32(quebra) + 1;
                   }
                   catch
                   {
                       result = "1";
                   }
               }
               else
               {
                   try
                   {
                       result = Convert.ToString( Convert.ToInt32(quebra[quebra.Length-1]) + 1);
                   }
                   catch
                   {
                       result = "1";
                   }
               }
               return string.Concat(codEtapa,".", result);
            }
            else
                return string.Concat(codEtapa, ".1");

            
        }
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
            string sql = @"SELECT * FROM DRAtividade(NOLOCK) WHERE  CODIGOPRJ =@1 AND CodAtividade =@2 AND CodEtapa =@3";
            DBCon.Fill(dataSet.Tables["DRAtividade"], sql, pk);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            //if (ParamServer.VisualizacaoTotalizadoresAtivado)
            //{
            //    if (_dataSet.Tables["DRATIVIDADE"].Columns["VALORDESPESA"]!= null)
            //        _dataSet.Tables["DRATIVIDADE"].Columns["VALORDESPESA"].Caption = "Valor Total Despesas";

            //    base.ConfiguraDataSetVisao(_dataSet);
            //}

            DataTable table = _dataSet.Tables["DRATIVIDADE"];

            DRProps.SetInfoColuna(table, "CODATIVIDADE", ColProps.DisplayWidth, 70,ColProps.DisplayIndex,1);
            DRProps.SetInfoColuna(table, "DESCRICAO", ColProps.DisplayWidth, 350,ColProps.DisplayIndex,2);
            DRProps.SetInfoColuna(table, "DataIni", ColProps.DisplayWidth, 66, ColProps.DisplayIndex, 3);
            DRProps.SetInfoColuna(table, "DataTermino",ColProps.Caption,"Data Término" ,ColProps.DisplayWidth, 66,ColProps.DisplayIndex,4);
            DRProps.SetInfoColuna(table, "Unidade",ColProps.Caption,"Un", ColProps.DisplayWidth, 26,ColProps.DisplayIndex,5);
            DRProps.SetInfoColuna(table, "Qtd", ColProps.Caption, "Quant.", ColProps.DisplayWidth, 66,ColProps.DisplayIndex,6);
            DRProps.SetInfoColuna(table, "PrecoUnitarioMaoObra", ColProps.DisplayIndex, 7, ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(table, "PrecoUnitarioMaterial", ColProps.DisplayIndex, 8, ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(table, "Total", ColProps.DisplayIndex, 9, ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(table, "TotalGeral", ColProps.Visible, true, ColProps.DisplayIndex, 10, ColProps.Format, DRProps.Fomat2Decimal());
            if (ParamServer.VisualizacaoTotalizadoresAtivado)     
                DRProps.SetInfoColuna(table, "VALORDESPESA", ColProps.Caption, "Valor Total Despesas",ColProps.DisplayIndex,11);
            DRProps.SetInfoColuna(table, "PercentualCompletude", ColProps.Caption, "% Completude", ColProps.DisplayWidth, 66,ColProps.DisplayIndex,12);         
            DRProps.SetInfoColuna(table, "Status",  ColProps.DisplayWidth, 49,ColProps.DisplayIndex,13);

            base.ConfiguraDataSetVisao(_dataSet);
        }
     

        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            if (ParamServer.VisualizacaoTotalizadoresAtivado)
            {
                sql = @"SELECT *,
                            (SELECT ISNULL( SUM(VALOR),0) FROM DRDESPESA WHERE CODIGOPRJ = DRATIVIDADE.CODIGOPRJ 
                             AND CODATIVIDADE = DRATIVIDADE.CODATIVIDADE AND STATUS='A') VALORDESPESA
                    FROM DRATIVIDADE (NOLOCK) WHERE CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            }
            else 
            {
                sql = @"SELECT * FROM DRATIVIDADE (NOLOCK) WHERE CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            }

            nomeTableVisao = "DRATIVIDADE";
        }

        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
           
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            if (DBCon.QueryFind("SELECT 1 FROM DRDESPESA WHERE CodigoPrj=@1 AND CODATIVIDADE=@2",
                                row["CodigoPrj"], row["CODATIVIDADE"]))
            {
                throw new Exception(Resources.ValidaExclusaoAtividade);
            }
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
            if (row["PercentualCompletude"] != DBNull.Value)
            {
                if (Convert.ToInt16(row["PercentualCompletude"]) < 0 || Convert.ToInt16(row["PercentualCompletude"]) > 100)
                {
                    abortaOperacao = true;
                    throw new Exception("O percentual de completude não pode ser menor que 0 ou maior que 100");

                }
            }
           
        }
    }
}
