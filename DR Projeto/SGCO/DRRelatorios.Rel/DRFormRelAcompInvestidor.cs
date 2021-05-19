using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;
using DR.Relatorio;
using DRProjetoCadastro.Form;
using DRRelatorios.Rel.Properties;

namespace DRRelatorios.Rel
{
    public partial class DRFormRelAcompInvestidor : DRForm
    {
        public DRFormRelAcompInvestidor()
        {
            InitializeComponent();
        }

        public DRRelServer ServerDR
        {
            get { return ((DRRelServer)this.Server); }
        }

        protected override void InitServer(ref object _ServerDR)
        {
            _ServerDR = new DRRelServer();
            base.InitServer(ref _ServerDR);
        }

        public string GetTitulo()
        {
            return string.Format("Relatório de Acompanhamento Investidor X Despesa - Ano {0} ",Ano);
        }

        public void RelatorioAcompanhamento()
        {
            //if (ServerDR.ExisteDespesasNaoClassificadas(DRProjetoContext.DRProjeto.CodProjeto, null,null))
            //{
            //    MessageBox.Show(Resources.SMensagemValidacaoDespNaoClassificada2, "Informação Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}

            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Acompanhamento Entradas X Despesa/Saldo");

            using (DataSet1 ds = ServerDR.MontaPagamentoMensal(DRProjetoContext.DRProjeto.CodProjeto, Ano))
            {
                if (ds.DRACOMPINVESTIDOR.Rows.Count == 0)
                {
                    DRFormAguarde.FormAguarde.FinalizaAguarde();
                    MessageBox.Show("Não foi encontrado nenhuma informação!");
                    return;
                }

                DataRow rowEmp = ServerDR.GetInfoEmpresa();

                string caminho;
                DRRelatorisClass.LoadLogoRel(rowEmp, out caminho);
                string titulo = GetTitulo();

                DRFormAguarde.FormAguarde.FinalizaAguarde();

                using (DRViewRel rel = new DRViewRel())
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra: "+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",DRRelatorisClass.GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TITULO",titulo),
                    new Microsoft.Reporting.WinForms.ReportParameter("Ano",Ano.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("Observacao",txtObs.Text),
                    
                };
                    rel.AddDataSource("DataSet1_DRENTRADA_DESPESA",
                                      ServerDR.GetEntrada_X_Despesa(DRProjetoContext.DRProjeto.CodProjeto,
                                                                    Ano));
                rel.ExecuteRel(ds.DRACOMPINVESTIDOR, "DataSet1_DRACOMPINVESTIDOR", "DRRelAcompanhamentoInvest.rdlc", parametros);

                }
                DRRelatorisClass.DeleteImageLogo();
            }
        }
        private int Ano;
        private void button1_Click(object sender, EventArgs e)
        {

            if (cbAnos.SelectedIndex == -1) return;
            Ano = Convert.ToInt16(cbAnos.SelectedItem);
            RelatorioAcompanhamento();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DRFormRelAcompInvestidor_Load(object sender, EventArgs e)
        {
            using (DataTable tblAno = ServerDR.GetAnos(DRProjetoContext.DRProjeto.CodProjeto))
            {
                foreach (DataRow row in tblAno.Rows)
                {
                    cbAnos.Items.Add(row["ANO"].ToString());
                }
                if (cbAnos.Items.Count > 0)
                    cbAnos.SelectedIndex = cbAnos.Items.Count - 1;

            }
        }
    }
}
