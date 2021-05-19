using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;
using DRProjetoCadastro.Form;
using DR.Relatorio;

namespace DRRelatorios.Rel
{
    public partial class DRRelExtratoPagInvestidor : DRForm
    {
        public DRRelServer ServerDR
        {
            get { return ((DRRelServer)this.Server); }
        }

        protected override void InitServer(ref object _ServerDR)
        {
            _ServerDR = new DRRelServer();
            base.InitServer(ref _ServerDR);
        }
        public DRRelExtratoPagInvestidor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSRel_II ds;
            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Extrato Pagamento Investidor");
            if (drConsInvestidor.GetValueCampo("CODINVESTIDOR") != null)
            {
                ds = ServerDR.GetExtratoPagamento(DRProjetoContext.DRProjeto.CodProjeto,
                     Convert.ToInt32(drConsInvestidor.GetValueCampo("CODINVESTIDOR")));
            }
            else
              ds = ServerDR.GetExtratoPagamento(DRProjetoContext.DRProjeto.CodProjeto,null);

            if (ds.DREXTRATOPAG.Rows.Count == 0)
            {
                DRFormAguarde.FormAguarde.FinalizaAguarde();
                MessageBox.Show("Não foi encontrado nenhuma informação!");
                return;
            }

            DataRow rowEmp = ServerDR.GetInfoEmpresa();

            string caminho;
            DRRelatorisClass.LoadLogoRel(rowEmp, out caminho);

            string titulo = "Extrato de Pagamento Investidor";                                                                                                     
            DRFormAguarde.FormAguarde.FinalizaAguarde();

            using (DRViewRel rel = new DRViewRel())
            {
                Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra:"+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",DRRelatorisClass.GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TITULO",titulo), 
                };

                rel.ExecuteRel(ds.DREXTRATOPAG, "DSRel_II_DREXTRATOPAG", "DRRelExtratoPagInvestidor.rdlc", parametros);

                DRRelatorisClass.DeleteImageLogo();
            }
            ds.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                drConsInvestidor.Clear();
                
            }
            drConsInvestidor.Enabled = !checkBox1.Checked;
        }
    }
}
