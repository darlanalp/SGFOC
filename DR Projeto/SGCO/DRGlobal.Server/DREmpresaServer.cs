using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using System.Data;
using DR.Lib.Winform;

namespace DRGlobal.BLL
{
    public class DREmpresaServer : DRData
    {
        protected override void DoAlteraRegistro(System.Data.DataRow row)
        {
            
        }

        protected override void DoCancelaRegistro(System.Data.DataRow row)
        {
            
        }

        protected override void DoCriaDataSet(out System.Data.DataSet dataSet)
        {
            dataSet = new DSEmpresa();
            
        }

        protected override void DoExecutaAposSalvar()
        {
            
        }
        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DataTable table = _dataSet.Tables["DREMPRESA"];

            DRProps.SetInfoColuna(table, "NOME", ColProps.DisplayWidth, 395);
           
        }

        protected override void DoNovoRegistro(System.Data.DataRow row)
        {

            row["IDEMPRESA"] = GeraNovoID.NovoCodigo(row.Table.TableName);

        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DREMPRESA(NOLOCK) WHERE IDEMPRESA =@1";
            DBCon.Fill(dataSet.Tables["DREMPRESA"], sql, pk);
        }

        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            sql = @"SELECT * FROM DREMPRESA ";
            nomeTableVisao = "DREMPRESA";
        }

        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
            
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
            
        }
    }
}
