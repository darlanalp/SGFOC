using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Utils;
using DR.Lib.Winform;

namespace DRProjetoCadastro.BLL
{
    public class DRInvestidorLanServer : DRData
    {
        protected override void DoAlteraRegistro(System.Data.DataRow row)
        {
          
        }

        protected override void DoCancelaRegistro(System.Data.DataRow row)
        {
          
        }

        protected override void DoCriaDataSet(out System.Data.DataSet dataSet)
        {
            dataSet = new DSInvestidor();
        }

        protected override void DoExecutaAposSalvar()
        {
          
        }

        protected override void DoNovoRegistro(System.Data.DataRow row)
        {
            row["IDPagamento"] = GeraNovoID.NovoCodigo(row.Table.TableName);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DRProps.SetInfoColuna(_dataSet.Tables["DRPAGAMENTOINVESTIDOR"], "CodInvestidor", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DRPAGAMENTOINVESTIDOR"], "CodigoPrj", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DRPAGAMENTOINVESTIDOR"], "Obs", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DRPAGAMENTOINVESTIDOR"], "VALOR", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRPAGAMENTOINVESTIDOR"], "UsuarioAprov", ColProps.Caption, "Usuário Aprovou");
            DRProps.SetInfoColuna(_dataSet.Tables["DRPAGAMENTOINVESTIDOR"], "DataAprovacao", ColProps.Caption, "Data Aprovação");


        }
        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRPAGAMENTOINVESTIDOR WHERE IDPagamento = @1 AND CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            DBCon.Fill(dataSet.Tables["DRPAGAMENTOINVESTIDOR"], sql, pk);
        }

        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            sql = @"SELECT * FROM DRPAGAMENTOINVESTIDOR WHERE CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            nomeTableVisao = "DRPAGAMENTOINVESTIDOR";
        }

        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
          
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            if (row["STATUS"].ToString() == "A" && !DRContex.Sistema.User.Supervisor)
            {
                throw new Exception("Lançamentos financeiros aprovados somente poderão ser excluídos por usuários supervisor.");
            }
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
            //Valida se o investidor está associado a obra selecionada ou logada
            if (!DBCon.QueryFind(@"SELECT 1 FROM DROBRAINVESTIDOR WHERE 
                              CODINVESTIDOR =@1 AND CODIGOPRJ=@2", row["CODINVESTIDOR"], row["CODIGOPRJ"])) 
            {
                abortaOperacao = true;

                throw new Exception(Properties.Resources.ValidaObraRelacionadaInvestidor);

            }
          
        }
    }
}
