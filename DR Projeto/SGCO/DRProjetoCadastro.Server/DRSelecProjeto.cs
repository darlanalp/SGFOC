using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR.Lib.RegraNegocio;
using DR.Utils;
using System.Data;


namespace DRProjetoCadastro.BLL
{
    public class DRSelecProjeto : DRDataBase
    {
        private bool Load = false;
        public void ReadProjeto(ref DSCadastro ds)
        {
            Load = true;
            DBCon.Fill(ds.Tables["DRProjetoSelect"], @"SELECT CODIGOPRJ,NOME, ENDERECO, BAIRRO,DATALASTBCK FROM DRPROJETO(NOLOCK)");
            DBCon.FechaConecxao();
            Load = false;
        }

        public void SetDataBck() 
        {
            DBCon.ExecSQL("UPDATE DRPROJETO SET DATALASTBCK =@1", DateTime.Now);
        }

        public void SetObraAtiva(int codigoPrj, bool ativa) 
        {
            if (ativa)
            {
                DBCon.ExecSQL("UPDATE DRUsuario SET LogaCodigoPrj =@1 WHERE IDUsuario =@2", codigoPrj, DRContex.Sistema.User.IdUsuario);
            }
            else
                DBCon.ExecSQL("UPDATE DRUsuario SET LogaCodigoPrj = NULL WHERE IDUsuario =@1", DRContex.Sistema.User.IdUsuario);
        }

        public bool ProjetoDefaultSetado(int codigoPrj) 
        {
            if (!Load)
            {
                return
                DBCon.QueryFind("SELECT LogaCodigoPrj FROM DRUsuario WHERE IDUsuario =@1 AND LogaCodigoPrj=@2",
                                 DRContex.Sistema.User.IdUsuario, codigoPrj);
            }
            return false;
        }

        public object[] GetProjetoDefault()
        {
            object prj =
            DBCon.QueryValue("SELECT LogaCodigoPrj FROM DRUsuario WHERE IDUsuario =@1", DRContex.Sistema.User.IdUsuario);
            if (prj == DBNull.Value || prj == null)
                return null;
            else 
            {
                DataTable tbl =
                DBCon.QuerySelect("Tbl", "SELECT CodigoPrj,Nome,DATALASTBCK FROM DRProjeto WHERE CodigoPrj=@1", prj);
                object[] result = new object[3] { tbl.Rows[0]["CodigoPrj"],
                                                  tbl.Rows[0]["Nome"],
                                                  tbl.Rows[0]["DATALASTBCK"]};

               
                return result;
            }
        }
        public bool ExecutaBackup(string dataBaseName,string caminho)
        {
            return false;
          //return  DBCon.Backup(dataBaseName, caminho);
        }

        public bool ExisteDespesaParaAprovar() 
        {
            if (!DRContex.Sistema.User.Supervisor)
                return false;
            object count = DBCon.QueryValue(@"SELECT COUNT(*) FROM DRDESPESA WHERE CODIGOPRJ=@1 AND STATUS = 'N'", 
                                            Convert.ToInt32(DRContex.Sistema.OwnerData));
            return (count != DBNull.Value && count != null && Convert.ToInt32(count) > 0);           
        }

        public bool ExisteLanFinParaAprovar()
        {
            if (!DRContex.Sistema.User.Supervisor)
                return false;

            object count = DBCon.QueryValue(@"SELECT COUNT(*) FROM DRPAGAMENTOINVESTIDOR WHERE CODIGOPRJ=@1 AND STATUS = 'N'",
                                            Convert.ToInt32(DRContex.Sistema.OwnerData));
            return (count != DBNull.Value && count != null && Convert.ToInt32(count) > 0);
        }


    }
}
