using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using System.Data;
using DR.Lib.Winform;
using DR.Utils;

namespace DRPatrimonio.Server
{
    public class DRPatrimonioServer : DRData
    {
        protected override void DoAlteraRegistro(System.Data.DataRow row)
        {
            
        }

        protected override void DoCancelaRegistro(System.Data.DataRow row)
        {
            
        }

        protected override void DoCriaDataSet(out System.Data.DataSet dataSet)
        {
            dataSet = new DSPatrimonio();   
        }

        protected override void DoExecutaAposSalvar()
        {
            
        }

        protected override void DoNovoRegistro(System.Data.DataRow row)
        {
            row["IDPATRIMONIO"] = GeraNovoID.NovoCodigo(row.Table.TableName);
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRPATRIMONIO WHERE CODIGOPRJ = @1 AND IDPATRIMONIO = @2";
            DBCon.Fill(dataSet.Tables["DRPATRIMONIO"], sql, pk);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DataTable table = _dataSet.Tables["DRPATRIMONIO"];
            DRProps.SetInfoColuna(table, "CodFornecedor", ColProps.Visible, false);
            DRProps.SetInfoColuna(table, "CODIGOPRJ", ColProps.Visible, false);
            DRProps.SetInfoColuna(table, "VALORAQUISICAO", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(table, "VALORTOTAL", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(table, "DATAAQUISICAO", ColProps.DisplayWidth, 67);
            DRProps.SetInfoColuna(table, "PATRIMONIO", ColProps.DisplayWidth, 383);
            DRProps.SetInfoColuna(table, "CODETAPA", ColProps.DisplayWidth, 76);
            DRProps.SetInfoColuna(table, "ATIVIDADE", ColProps.DisplayWidth, 76);
            DRProps.SetInfoColuna(table, "IDPATRIMONIO", ColProps.DisplayWidth, 66);

        }
        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            sql = @"SELECT * FROM DRPATRIMONIO WHERE CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData); ;
            nomeTableVisao = "DRPATRIMONIO";
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
