using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DRProjetoCadastro.Form;
using DR.Utils;
using DR.Relatorio;
using Microsoft.SqlServer.ReportingServices2005.Execution;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace DRRelatorios.Rel
{
    public static class DRRelatorisClass
    {
        public static string GetEndereco(DataRow rowEmp) 
        {
            string endereco = string.Empty;
            endereco = string.Concat(rowEmp["ENDERECO"],",",rowEmp["NUMERO"],",",rowEmp["BAIRRO"],
                                     " - ",rowEmp["TELEFONE1"],"/",rowEmp["TELEFONE2"]);
            return endereco;
        }

        public static void RelatorioAcompanhamento() 
        {
            DRRelServer serverRel = new DRRelServer();
            serverRel.Initializa(DRContex.Sistema.StringConexao);
            DataSet1 ds = serverRel.GetEtapa_Atividade(DRProjetoContext.DRProjeto.CodProjeto);
            DataRow rowEmp = serverRel.GetInfoEmpresa();

            string caminho;
            LoadLogoRel(rowEmp, out caminho);

            using (DRViewRel rel = new DRViewRel())
            {
                Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra:"+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                };
                //rel.AddDataSource("DataSet1_DREMPRESA", ds.DREMPRESA);
               //rel.ExecuteRel(ds.DRInvestidores, "DataSet1_DRInvestidores", "DRRelInvetidor.rdlc", parametros);

            }
            DeleteImageLogo();
        }

 
        public static void RelatorioInvestidores()
        {            
            DRRelServer serverRel = new DRRelServer();
            serverRel.Initializa(DRContex.Sistema.StringConexao);
            using (DataSet1 ds = serverRel.GetInvestidores(DRProjetoContext.DRProjeto.CodProjeto))
            {
                DataRow rowEmp = serverRel.GetInfoEmpresa();

                string caminho;
                LoadLogoRel(rowEmp, out caminho);

                using (DRViewRel rel = new DRViewRel())
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra:"+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                };
                    //rel.AddDataSource("DataSet1_DREMPRESA", ds.DREMPRESA);
                    rel.ExecuteRel(ds.DRInvestidores, "DataSet1_DRInvestidores", "DRRelInvetidor.rdlc", parametros);

                }
                DeleteImageLogo();
            }
        }


        public static void RelatorioEtapas_AtividadesCadastradas()
        {
            DRRelServer serverRel = new DRRelServer();
            serverRel.Initializa(DRContex.Sistema.StringConexao);
            using (DataSet1 ds = serverRel.GetEtapasAtividadesCadastradas(DRProjetoContext.DRProjeto.CodProjeto))
            {
                DataRow rowEmp = serverRel.GetInfoEmpresa();

                string caminho;
                LoadLogoRel(rowEmp, out caminho);

                using (DRViewRel rel = new DRViewRel())
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra:"+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                };
                    //rel.AddDataSource("DataSet1_DREMPRESA", ds.DREMPRESA);
                    rel.ExecuteRel(ds.DRETAPAATIVIDADE, "DataSet1_DRETAPAATIVIDADE", "DRRelEtapasAtividadeProjeto.rdlc", parametros);

                }
                DeleteImageLogo();
            }
        }

        public static void RelatorioCota()
        {
            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Cotas");

            DRRelServer serverRel = new DRRelServer();
            serverRel.Initializa(DRContex.Sistema.StringConexao);
            using (DSRel_II ds = serverRel.GetCotas(DRProjetoContext.DRProjeto.CodProjeto))
            {
                if (ds.DRRELCOTAS.Rows.Count == 0)
                {
                    DRFormAguarde.FormAguarde.FinalizaAguarde();
                    MessageBox.Show("Não foi encontrado nenhuma informação!");
                    return;
                }

                DataRow rowEmp = serverRel.GetInfoEmpresa();

                string caminho;
                LoadLogoRel(rowEmp, out caminho);

             
                using (DRViewRel rel = new DRViewRel())
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {               
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra: "+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",DRRelatorisClass.GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TITULO","Relatório de Cotas"), 
                    new Microsoft.Reporting.WinForms.ReportParameter("TotalPrevistoCota",serverRel.GetValorTotalPrevistoCota(DRProjetoContext.DRProjeto.CodProjeto).ToString())
                };

                    DRFormAguarde.FormAguarde.FinalizaAguarde();

                    //rel.AddDataSource("DataSet1_DREMPRESA", ds.DREMPRESA);
                    rel.ExecuteRel(ds.DRRELCOTAS, "DSRel_II_DRRELCOTAS", "DRRelCotas.rdlc", parametros);

                }
                DeleteImageLogo();
            }
        }

        #region Tratamento do Logo
        public static void LoadLogoRel(DataRow rowEmp, out string caminho)
        {
            caminho = string.Empty;
            if (rowEmp["LOGO"] != DBNull.Value)
            {
                Image img = arrayByteToImage((byte[])rowEmp["LOGO"]);
                DRRelatorisClass.SaveImageLogo(img, out caminho);
                caminho = "file:///" + caminho;
            }
        }

        public static void DeleteImageLogo()
        { 
            string pathImage = Path.Combine(Application.StartupPath, "img.bmp");
            pathImage = pathImage.Replace(@"bin\Debug\", "");
            if (File.Exists(pathImage))
                File.Delete(pathImage);
        }
        public static void SaveImageLogo(Image img, out string caminho) 
        {
            DeleteImageLogo();
            caminho = Path.Combine(Application.StartupPath, "img.bmp");
            caminho = caminho.Replace(@"bin\Debug\", "");
            img.Save(caminho);
        }
        private static System.Drawing.Image arrayByteToImage(byte[] imagemEmBytes)
        {
            MemoryStream ms = null;
            Image img;

            try
            {
                ms = new MemoryStream(imagemEmBytes, 0, imagemEmBytes.Length);
                ms.Write(imagemEmBytes, 0, imagemEmBytes.Length);
                img = Image.FromStream(ms, true);
                return img;
            }
            catch (ArgumentException aex)
            {
                throw new InvalidOperationException("Imagem inválida");
            }
            finally
            {
                if (ms != null)
                {
                    ms.Close();
                    ms = null;
                }
            }
        }
        #endregion

    }
}
