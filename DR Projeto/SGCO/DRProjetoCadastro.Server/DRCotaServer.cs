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
    public class DRCotaServer : DRData
    {        
          
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
            row["IDCOTA"] = GeraNovoID.NovoCodigo(row.Table.TableName);
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRCOTAS (NOLOCK) WHERE  CODIGOPRJ =@1 AND IDCOTA = @2";
            DBCon.Fill(dataSet.Tables["DRCOTAS"], sql, pk);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "CODETAPA", ColProps.DisplayWidth, 50);
            DRProps.SetInfoColuna(_dataSet.Tables["DRCOTAS"], "DESCRICAO", ColProps.DisplayWidth, 350);
            DRProps.SetInfoColuna(_dataSet.Tables["DRCOTAS"], "VALORPREVISTO", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRCOTAS"], "PERCENTUAPROJETO", ColProps.Format, DRProps.Fomat2Decimal());

            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "DATAINI", ColProps.Caption, "Data Ínicio");
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "DATATERMINO", ColProps.Caption, "Data Término");
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "TOTALMATERIAL", ColProps.Caption, "Material", ColProps.Format, DRProps.Fomat2Decimal());
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "TOTALMAOOBRA", ColProps.Caption, "Mão de Obra", ColProps.Format, DRProps.Fomat2Decimal());
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "TOTALGERAL", ColProps.Caption, "Valor Total Previsto", ColProps.Format, DRProps.Fomat2Decimal());
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "PERCENTUAL", ColProps.Caption, "% Equivalente na Obra", ColProps.Format, DRProps.Fomat2Decimal());
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "VALORDESPESA", ColProps.Caption, "Valor Total Despesas", ColProps.Format, DRProps.Fomat2Decimal());
            //DRProps.SetInfoColuna(_dataSet.Tables["DRETAPA"], "MostrarGrafico", ColProps.Visible, false);  
                              
            base.ConfiguraDataSetVisao(_dataSet);           
        }

      
        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {

            sql = @"SELECT * FROM DRCOTAS (NOLOCK) WHERE CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);

            nomeTableVisao = "DRCOTAS";
        }


        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
           
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            //if (DBCon.QueryFind("SELECT 1 FROM DRATIVIDADE WHERE CODIGOPRJ=@1 AND CODETAPA=@2",
            //                    row["CodigoPrj"], row["CodEtapa"]))
            //{
            //    throw new Exception(Resources.ValidaExclusaoEtapa);
            //}           
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
            
          
        }
    }

   
}
