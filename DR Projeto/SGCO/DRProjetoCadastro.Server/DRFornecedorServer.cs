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
    public class DRFornecedorServer : DRData
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
            row["CodFornecedor"] = GeraNovoID.NovoCodigo(row.Table.TableName);
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRFORNECEDOR WHERE CODFORNECEDOR = @1";
            DBCon.Fill(dataSet.Tables["DRFORNECEDOR"], sql, pk);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DataTable table = _dataSet.Tables["DRFORNECEDOR"];

            DRProps.SetInfoColuna(table, "CodFornecedor", ColProps.DisplayWidth, 47);
            DRProps.SetInfoColuna(table, "NomeFantasia", ColProps.DisplayWidth, 383);
            DRProps.SetInfoColuna(table, "Categoria", ColProps.DisplayWidth, 80);

        }
        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            sql = @"SELECT * FROM DRFORNECEDOR ";
            nomeTableVisao = "DRFORNECEDOR";
        }

        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
            
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {

            if (DBCon.QueryFind("SELECT 1 FROM DRDESPESA WHERE CODFORNECEDOR = @1", row["CODFORNECEDOR"])) 
            {
                throw new Exception(Resources.ValidaExclusaoFornecedor);
            }

        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
            
        }
    }
}
