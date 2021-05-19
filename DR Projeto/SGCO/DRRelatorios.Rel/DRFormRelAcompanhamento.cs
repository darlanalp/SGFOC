using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;
using DR.Utils;
using DRProjetoCadastro.Form;
using DR.Relatorio;
using DRRelatorios.Rel.Properties;

namespace DRRelatorios.Rel
{
    public partial class DRFormRelAcompanhamento : DRForm
    {
        public DRFormRelAcompanhamento()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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
            return string.Format("Relatório de Acompanhamento - Périodo de {0} á {1}", dtIni.GetDate().ToShortDateString(),
                                                                                                    dtFim.GetDate().ToShortDateString());
        }

        private DateTime dtini;
        private DateTime dtfim;

        public void RelatorioAcompanhamento()
        {
            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Acompanhamento ");

            using (DataSet1 ds = ServerDR.GetAcompanhamentoPeriodo(DRProjetoContext.DRProjeto.CodProjeto, dtini, dtfim,checkBox1.Checked))
            {
                if (ds.DRACOMPANHAMENTO.Rows.Count == 0)
                {
                    DRFormAguarde.FormAguarde.FinalizaAguarde();
                    MessageBox.Show("Não foi encontrado nenhuma informação!");
                    return;
                }

                DataRow rowEmp = ServerDR.GetInfoEmpresa();
                string caminho;
                DRRelatorisClass.LoadLogoRel(rowEmp, out caminho);
                string titulo = GetTitulo();



                
                decimal totPrevisto;
                decimal totDespesaAnterior;
                decimal totDespesaAtual;

                ServerDR.GetTotalizadores(DRProjetoContext.DRProjeto.CodProjeto, dtini, dtfim,
                                          out totPrevisto, out totDespesaAnterior, out totDespesaAtual);

                decimal totDespesa = totDespesaAnterior + totDespesaAtual;

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
                    new Microsoft.Reporting.WinForms.ReportParameter("TotalDespesa",totDespesa.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TotalPrevisto",totPrevisto.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TotDespesaAtual",totDespesaAtual.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TotDespesaAnterior",totDespesaAnterior.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("Observacao",txtObs.Text)
                };
                    rel.ExecuteRel(ds.DRACOMPANHAMENTO, "DataSet1_DRACOMPANHAMENTO", "DRRelAcompanhamento.rdlc", parametros);

                }
                DRRelatorisClass.DeleteImageLogo();
            }
        }

        public void RelatorioAcompanhamentoResumido()
        {
            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Acompanhamento Resumido");

            using (DataSet1 ds = ServerDR.GetAcompanhamentoResumido(DRProjetoContext.DRProjeto.CodProjeto,checkBox1.Checked))
            {
                if (ds.DRACOMPRESUMIDO.Rows.Count == 0)
                {
                    DRFormAguarde.FormAguarde.FinalizaAguarde();
                    MessageBox.Show("Não foi encontrado nenhuma informação!");
                    return;
                }

                DataRow rowEmp = ServerDR.GetInfoEmpresa();

                string caminho;

       
                #region Dados p/ Gráfico

                //Somatório do percentual de completude das atividades
                decimal totPercentualComp = Convert.ToDecimal(ds.DRACOMPRESUMIDO.Compute("SUM(PERCENTUALCOMPLETUDE)", "ETAPA = 0"));
                int totalAtividades = Convert.ToInt32(ds.DRACOMPRESUMIDO.Compute("COUNT(CODIGO)", "ETAPA = 0"));
                decimal percent = totPercentualComp / totalAtividades;
                DataRow row = ds.GraficoPizza.NewRow();
                row["Item"] = "Executado";
                row["Percentual"] = percent;
                ds.GraficoPizza.Rows.Add(row);

                DataRow rowRestante = ds.GraficoPizza.NewRow();
                rowRestante["Item"] = "Restante";
                rowRestante["Percentual"] = 100 - percent;
                ds.GraficoPizza.Rows.Add(rowRestante);
                #endregion

                DRFormAguarde.FormAguarde.FinalizaAguarde();

                DRRelatorisClass.LoadLogoRel(rowEmp, out caminho);
                string titulo = "Relatório - Percentual de Completude da Etapa/Atividade";
                using (DRViewRel rel = new DRViewRel())
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra: "+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",DRRelatorisClass.GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TITULO",titulo),
                    new Microsoft.Reporting.WinForms.ReportParameter("Observacao",txtObs.Text)
                    

                };
                    rel.AddDataSource("DataSet1_GraficoPizza", ds.GraficoPizza);
                    rel.ExecuteRel(ds.DRACOMPRESUMIDO, "DataSet1_DRACOMPRESUMIDO", "DRRelAcompanhamentoResumido.rdlc", parametros);

                }
                DRRelatorisClass.DeleteImageLogo();
            }
        }

        public const string GerandoRel = "Gerando Relatório...";

        private void ExecutaRelAcompanhamento() 
        {
            RelatorioAcompanhamento();    
        }


        private void ExecutaRelAcompanhamentoResumido()
        {
            RelatorioAcompanhamentoResumido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbAcDetalhado.Checked)
            {
                if (!dtIni.DataInformada())
                {
                    dtIni.Focus();
                    MessageBox.Show("Favor informar a data inicial.");
                    return;
                }
                if (!dtFim.DataInformada())
                {
                    dtFim.Focus();
                    MessageBox.Show("Favor informar a data final.");
                }
                dtini = dtIni.GetDate();
                dtfim = dtFim.GetDate();

                if (ServerDR.ExisteDespesasNaoClassificadas(DRProjetoContext.DRProjeto.CodProjeto, dtfim))
                {
                    MessageBox.Show(Resources.SMensagemValidacaoDespNaoClassificada2, "Informação Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                ExecutaRelAcompanhamento();
            }
            else
                if (rbAcResumido.Checked)
                    ExecutaRelAcompanhamentoResumido();

        }

        private void rbAcDetalhado_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = rbAcDetalhado.Checked;
            checkBox1.Text = "Mostrar somente Etapas/Atividades que possuem despesas.";
            
        }

        private void rbAcResumido_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = !rbAcResumido.Checked;
            checkBox1.Text = "Mostrar somente Etapas/Atividades iniciadas.";
        }
    }
}
