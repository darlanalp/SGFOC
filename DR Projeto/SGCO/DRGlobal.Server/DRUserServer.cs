using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Utils;
using System.Data;
using DR.Lib.Winform;

namespace DRGlobal.BLL
{
    public class DRUserServer : DRData
    {
        protected override void DoAlteraRegistro(System.Data.DataRow row)
        {
            
        }

        protected override void DoCancelaRegistro(System.Data.DataRow row)
        {
             
        }

        protected override void DoCriaDataSet(out System.Data.DataSet dataSet)
        {

            dataSet = new DSUser();
             
        }

        protected override void DoExecutaAposSalvar()
        {
             
        }
        protected override void ConfiguraDataSetVisao(System.Data.DataSet _dataSet)
        {
            DataTable table = _dataSet.Tables["DRUsuario"];

            DRProps.SetInfoColuna(table, "LOGACODIGOPRJ", ColProps.Visible, false);

        }
        protected override void DoNovoRegistro(System.Data.DataRow row)
        {
            if (!DRContex.Sistema.User.Supervisor)
            {
                throw new Exception("Você não tem permissão para adicionar um novo usuário");
            }

            row["IDUsuario"] = GeraNovoID.NovoCodigo(row.Table.TableName);  
             
        }

        protected override void DoRecuperaRegistroDialog(System.Data.DataSet dataSet, object[] pk)
        {
            DRContex.Sistema.SegurancaCadastroUser.Reset();

            string sql = @"SELECT * FROM DRUsuario(NOLOCK) WHERE IDUsuario =@1";
            DBCon.Fill(dataSet.Tables["DRUsuario"], sql, pk);

            sql = @"SELECT * FROM DRPERMISSAOUSER WHERE IDUSUARIO =@1";
            DBCon.Fill(dataSet.Tables["DRPERMISSAOUSER"], sql, pk);
            LoadListSeguranca(dataSet.Tables["DRPERMISSAOUSER"], DRContex.Sistema.SegurancaCadastroUser);
        }

        public void ReadSegurancaUser(int idUsuario) 
        {
           string sql = @"SELECT * FROM DRPERMISSAOUSER WHERE IDUSUARIO =@1";          
           LoadListSeguranca(DBCon.QuerySelect("TBLSEGUSER", sql, idUsuario),
                             DRContex.Sistema.SegurancaUser);        
        } 


        public void LoadListSeguranca(DataTable table, DRSegurancaForm componenteSeg) 
        {
            foreach (DataRow row in table.Rows) 
            {
                PolicyMaster seg = componenteSeg.ListSeg.Find(s => s.Tag == Convert.ToInt32(row["IDSEGURANCA"]));
              if (seg != null) 
              {
                  seg.Pemitido = true;
                 string[] segItem = row["SEGURANCA"].ToString().Trim().Split(';');
                 foreach (string menu in segItem) 
                 {                      
                     foreach (Policy item in seg.SegurancaItem) 
                     {
                         if(item.Tag.ToString() == menu)
                             item.Pemitido = true;
                     }
                    
                 }
              }
            }

        }

        protected override void DoRecuperaRegistroVisao(out string sql, out string nomeTableVisao)
        {
            if (!DRContex.Sistema.User.Supervisor)
                sql = @"SELECT * FROM DRUsuario WHERE IDUSUARIO = "+DRContex.Sistema.User.IdUsuario;
            else
               sql = @"SELECT * FROM DRUsuario ";
            nomeTableVisao = "DRUsuario";
        }

        public override void SalvaDetalhe(System.Data.DataSet dataSet, object[] pk)
        {
            if (pk != null)
            {
                DBCon.Update(dataSet.Tables["DRPERMISSAOUSER"], pk);
                base.SalvaDetalhe(dataSet, pk);
            }
        }

        protected override void DoSalvaRegistro(System.Data.DataSet dataSet)
        {
        }

        protected override void DoValidaRowDeletar(System.Data.DataRow row, ref bool abortaOperacao)
        {
            if (!DRContex.Sistema.User.Supervisor)
            {
                throw new Exception("Você não tem permissão para remover um usuário");
            }             
        }

        protected override void DoValidateRow(System.Data.DataRow row, ref bool abortaOperacao)
        {
             
        }
    }
}
