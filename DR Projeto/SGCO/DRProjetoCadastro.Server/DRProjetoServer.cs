using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using System.Data;
using DR.Lib.Winform;
using DRProjetoCadastro.BLL.Properties;

namespace DRProjetoCadastro.BLL
{
    public class DRProjetoServer : DRData
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
            //row["CodigoPrj"] = GeraNovoID.NovoCodigo(row.Table.TableName);   
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRPROJETO WHERE CODIGOPRJ =@1";
            DBCon.Fill(dataSet.Tables["DRPROJETO"], sql, pk);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DataTable table = _dataSet.Tables["DRPROJETO"];

            DRProps.SetInfoColuna(table, "CodigoPrj", ColProps.DisplayWidth, 57);
            DRProps.SetInfoColuna(table, "Nome", ColProps.DisplayWidth, 410);
            DRProps.SetInfoColuna(table, "DataInicio", ColProps.DisplayWidth, 85);
            DRProps.SetInfoColuna(table, "DataFin", ColProps.DisplayWidth, 98);

        }

        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            sql = @"SELECT * FROM DRPROJETO ";
            nomeTableVisao = "DRPROJETO";
        }


        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
            
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {

            if (DBCon.QueryFind("SELECT 1 FROM DRETAPA WHERE CODIGOPRJ=@1",
                                row["CodigoPrj"]))
            {
                throw new Exception(Resources.ValidaExclusaoObra);
            }

        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
          
        }
    }
}
