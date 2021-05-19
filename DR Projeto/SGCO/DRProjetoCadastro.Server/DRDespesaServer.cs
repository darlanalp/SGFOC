using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Utils;
using System.Data;
using DR.Lib.Winform;

namespace DRProjetoCadastro.BLL
{
    public class DRDespesaServer : DRData
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
            row["IdDespesa"] = GeraNovoID.NovoCodigo(row.Table.TableName);
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            string sql = @"SELECT * FROM DRDESPESA(NOLOCK) WHERE CodigoPrj=@1 AND IdDespesa =@2";
            DBCon.Fill(dataSet.Tables["DRDESPESA"], sql, pk);
        }

        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DataTable table = _dataSet.Tables["DRDESPESA"];

            DRProps.SetInfoColuna(table,"CodigoPrj",ColProps.Visible,false);
            DRProps.SetInfoColuna(table, "IdDespesa",ColProps.Caption,"Id.", ColProps.DisplayWidth, 48,ColProps.DisplayIndex,1);
            DRProps.SetInfoColuna(table, "CODETAPA", ColProps.DisplayWidth, 42, ColProps.DisplayIndex, 2);
            DRProps.SetInfoColuna(table, "CODATIVIDADE", ColProps.DisplayWidth,56,ColProps.DisplayIndex,3);
            DRProps.SetInfoColuna(table, "DESCRICAO", ColProps.DisplayWidth, 357,ColProps.DisplayIndex,4);
            DRProps.SetInfoColuna(table,"Observacao",ColProps.Visible,false);
            DRProps.SetInfoColuna(table, "DataInclusao", ColProps.DisplayWidth, 66,ColProps.DisplayIndex,5);
            DRProps.SetInfoColuna(table, "DataPag", ColProps.DisplayWidth, 78,ColProps.DisplayIndex,6);
            DRProps.SetInfoColuna(table, "Valor", ColProps.DisplayIndex, 7, ColProps.Format, DRProps.Fomat2Decimal());
            DRProps.SetInfoColuna(table, "NumeroNota", ColProps.DisplayIndex,8);
            DRProps.SetInfoColuna(table, "TIPODESPESA", ColProps.Visible, false);
            
            DRProps.SetInfoColuna(table, "DESCTIPODESPESA", ColProps.Caption, "Tipo Despesa", ColProps.DisplayIndex, 9);
            DRProps.SetInfoColuna(table, "TIPODESPESA", ColProps.Visible,false);
            DRProps.SetInfoColuna(table, "STATUS", ColProps.DisplayWidth, 41,ColProps.DisplayIndex,10);
            DRProps.SetInfoColuna(table, "CodFornecedor",ColProps.Visible,false);
            DRProps.SetInfoColuna(table, "NOMEFANTASIA", ColProps.Caption, "Fornecedor", ColProps.DisplayIndex, 11);            

            DRProps.SetInfoColuna(table, "USUARIOINCLU", ColProps.Visible, false);
            DRProps.SetInfoColuna(table, "USUARIOAPROVACAO", ColProps.Visible, false);
        }


        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {

            sql = @"SELECT
                     CodigoPrj,        
                     IdDespesa,        
                     CodEtapa,
                     CODATIVIDADE,                                 
                     Descricao,        
                     Observacao,                  
                     DataInclusao,     
                     DataPag,          
                     Valor,            
                     NumeroNota,
                     TIPODESPESA,
                     CASE WHEN (TIPODESPESA =0) THEN 'INSUMO'
                          WHEN (TIPODESPESA =1) THEN 'MÃO DE OBRA'
                          WHEN (TIPODESPESA =2) THEN 'PATRIMÔNIO'      
                          WHEN (TIPODESPESA =3) THEN 'OUTRAS'                  
                     ELSE 
                         ''
                     END DESCTIPODESPESA, 
                     Status,
                     DRDESPESA.CodFornecedor,
                     DRFORNECEDOR.NOMEFANTASIA,                                                 
                     USUARIOINCLU,     
                     USUARIOAPROVACAO                     
                     FROM DRDESPESA (NOLOCK) 
                     LEFT JOIN DRFORNECEDOR(NOLOCK)  ON
                              DRFORNECEDOR.CodFornecedor = DRDESPESA.CodFornecedor 
                     WHERE CODIGOPRJ= " + Convert.ToInt32(DRContex.Sistema.OwnerData);
            nomeTableVisao = "DRDESPESA";
        }

        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
           
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            if (row["STATUS"].ToString() == "A" && !DRContex.Sistema.User.Supervisor)
            {
                throw new Exception("Despesa aprovada somente poderão ser excluídos por usuários supervisor.");
            }
           
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
           
        }
    }
    public enum TipoDespesa 
    {
        Insumo=0,
        MaoObra=1,
        Patrimonio=2,
        Outras
    }
}
