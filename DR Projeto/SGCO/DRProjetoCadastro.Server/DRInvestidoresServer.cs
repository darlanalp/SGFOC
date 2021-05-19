using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Utils;
using DR.Lib.Winform;
using DRProjetoCadastro.BLL.Properties;


namespace DRProjetoCadastro.BLL
{
    public class DRInvestidoresServer : DRData
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

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DRProps.SetInfoColuna(_dataSet.Tables["DROBRAINVESTIDOR"], "CodInvestidor", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DROBRAINVESTIDOR"], "Apartamento", ColProps.DisplayWidth,150);
            DRProps.SetInfoColuna(_dataSet.Tables["DROBRAINVESTIDOR"], "CodigoPrj", ColProps.DisplayWidth, 45);
            DRProps.SetInfoColuna(_dataSet.Tables["DROBRAINVESTIDOR"], "ValorPrevistoInvesti", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DROBRAINVESTIDOR"], "IDCOTA", ColProps.Visible,false);
            DRProps.SetInfoColuna(_dataSet.Tables["DROBRAINVESTIDOR"], "COTA", ColProps.Caption, "Cota");   

            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "CodInvestidor", ColProps.DisplayWidth, 62);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Nome", ColProps.DisplayWidth, 346);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "CPF",ColProps.Visible,false, ColProps.DisplayWidth, 79);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "RG", ColProps.Visible, false, ColProps.DisplayWidth, 89);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Cep", ColProps.Visible, false, ColProps.DisplayWidth, 75);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Endereco", ColProps.Visible, false, ColProps.DisplayWidth, 201);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Numero", ColProps.Visible, false, ColProps.DisplayWidth, 46);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Estado", ColProps.Visible, false, ColProps.DisplayWidth, 53);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Telefone", ColProps.Visible, false, ColProps.DisplayWidth, 72);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Celular", ColProps.Visible, false, ColProps.DisplayWidth, 72);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Fax", ColProps.Visible, false, ColProps.DisplayWidth, 72);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "DataNascimento", ColProps.Visible, false, ColProps.DisplayWidth, 68);

            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Obs", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Complemento", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Bairro", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Cidade", ColProps.Visible, false);
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Email", ColProps.Visible, false);

            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "VLRPREVISTO", ColProps.Caption, "Investimento Previsto", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "TOTALPAGO", ColProps.Caption, "Total Pago", ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "APTO", ColProps.Caption, "Apartamento");
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "PercentAdquirido", ColProps.Caption, "%");
            DRProps.SetInfoColuna(_dataSet.Tables["DRInvestidores"], "Fracao", ColProps.Caption, "Fração do Lote");
            
            

        }

        protected override void DoNovoRegistro(System.Data.DataRow row)
        {
            row["CodInvestidor"] = GeraNovoID.NovoCodigo(row.Table.TableName);
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
         
            string sql = @"SELECT * FROM DRInvestidores (NOLOCK) WHERE  CodInvestidor =@1";
            DBCon.Fill(dataSet.Tables["DRInvestidores"], sql, pk);


            string sql_ = @"SELECT DROBRAINVESTIDOR.*,DRCOTAS.DESCRICAO AS COTA  FROM DROBRAINVESTIDOR 
                            LEFT JOIN DRCOTAS ON
                                 DRCOTAS.CODIGOPRJ = DROBRAINVESTIDOR.CODIGOPRJ AND
                                 DRCOTAS.IDCOTA = DROBRAINVESTIDOR.IDCOTA 
                            WHERE CODINVESTIDOR=@1";
            DBCon.Fill(dataSet.Tables["DROBRAINVESTIDOR"], sql_, pk);

            //somente para update
            dataSet.Tables["DROBRAINVESTIDOR"].ExtendedProperties["@SQL"] =
            @"SELECT * FROM DROBRAINVESTIDOR WHERE CODINVESTIDOR=@1"; 
            

            DRProps.SetInfoColuna(dataSet.Tables["DROBRAINVESTIDOR"], "IDCOTA", ColProps.Visible, false);
            DRProps.SetInfoColuna(dataSet.Tables["DROBRAINVESTIDOR"], "COTA", ColProps.Caption, "Cota");   

           
        }

        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            string sqlTotalGasto = @"SELECT SUM(VALOR) FROM DRPAGAMENTOINVESTIDOR (NOLOCK) WHERE 
                                            CodInvestidor = DRINVESTIDORES.CodInvestidor AND STATUS = 'A' AND CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            string slqPrevisto = @"SELECT SUM(ValorPrevistoInvesti) FROM DROBRAINVESTIDOR  (NOLOCK) WHERE 
                                   CodInvestidor = DRINVESTIDORES.CodInvestidor AND CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            string slqApartamento = @"SELECT Apartamento FROM DROBRAINVESTIDOR  (NOLOCK) WHERE 
                                      CodInvestidor = DRINVESTIDORES.CodInvestidor AND CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            string slqPercentAdquirido = @"SELECT PercentAdquirido FROM DROBRAINVESTIDOR  (NOLOCK) 
                                           WHERE CodInvestidor = DRINVESTIDORES.CodInvestidor AND CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            string slqFracao = @"SELECT FRACAOOBRA FROM DROBRAINVESTIDOR  (NOLOCK) 
                                 WHERE CodInvestidor = DRINVESTIDORES.CodInvestidor AND CODIGOPRJ = " + Convert.ToInt32(DRContex.Sistema.OwnerData);



            sql = @"SELECT *,({0}) AS VLRPREVISTO,({1}) AS TOTALPAGO ,
                             ({2}) AS APTO,
                             ({3}) AS PercentAdquirido,
                             ({4}) AS Fracao FROM DRINVESTIDORES (NOLOCK) /*WHERE/*";
            sql = string.Format(sql, slqPrevisto, sqlTotalGasto, slqApartamento, slqPercentAdquirido, slqFracao);
            nomeTableVisao = "DRINVESTIDORES";
        }

        public override void SalvaDetalhe(System.Data.DataSet dataSet, object[] pk)
        {
            if (pk != null)
            {
                DBCon.Update(dataSet.Tables["DROBRAINVESTIDOR"], pk[0], Convert.ToInt32(DRContex.Sistema.OwnerData));
                base.SalvaDetalhe(dataSet, pk);
            }
        }

        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
                    
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            if (DBCon.QueryFind("SELECT 1 FROM DRPAGAMENTOINVESTIDOR WHERE CODINVESTIDOR=@1", row["CODINVESTIDOR"])) 
            {
                throw new Exception(Resources.ValidaExclusaoInvestidor);
            }

            DBCon.ExecSQL("DELETE FROM DROBRAINVESTIDOR WHERE CodInvestidor=@1", row["CodInvestidor"]);
            
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
             
        }
        public bool ExisteLanFinanceiroObra(int CodInvestidor, int CodigoPrj) 
        {
            return
            DBCon.QueryFind("SELECT 1 FROM DRPAGAMENTOINVESTIDOR WHERE CODINVESTIDOR=@1 AND CodigoPrj=@2",
            CodInvestidor, CodigoPrj);
        }
    }
}
