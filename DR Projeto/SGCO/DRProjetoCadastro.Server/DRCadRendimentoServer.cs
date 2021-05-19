using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Lib.Winform;
using System.Data;

namespace DRProjetoCadastro.BLL
{
    public class DRCadRendimentoServer : DRData
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
            row["IDRENDIMENTO"] = GeraNovoID.NovoCodigo(row.Table.TableName);
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRRENDIMENTO (NOLOCK) WHERE  CODIGOPRJ =@1 AND IDRENDIMENTO=@2";
            DBCon.Fill(dataSet.Tables["DRRENDIMENTO"], sql, pk);
           
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DataTable table = _dataSet.Tables["DRRENDIMENTO"];

            DRProps.SetInfoColuna(table, "CODIGOPRJ", ColProps.Visible, false);
            DRProps.SetInfoColuna(table, "IDRENDIMENTO", ColProps.DisplayIndex, 1);
            DRProps.SetInfoColuna(table, "MES", ColProps.DisplayIndex, 2);
            DRProps.SetInfoColuna(table, "DATAAPURACAO", ColProps.DisplayIndex, 3);
            DRProps.SetInfoColuna(table, "VALORRENDIMENTO", ColProps.DisplayIndex, 4, ColProps.Format, DRProps.Fomat2Decimal());
        }
        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            sql = @"SELECT * FROM DRRENDIMENTO";
            nomeTableVisao = "DRRENDIMENTO";
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
