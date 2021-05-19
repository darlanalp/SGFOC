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
using Microsoft.Reporting.WinForms;
using DRRelatorios.Rel.Properties;

namespace DRRelatorios.Rel
{
    public partial class DRFORMRelDespesaAtividade : DRForm
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
        public DRFORMRelDespesaAtividade()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ProcessaSubRelatorioDespesa(object sender, SubreportProcessingEventArgs e) 
        {
            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSRel_II_DRDESPESA", ds.DRDESPESA));
        }

        public DSRel_II ds;

        private DateTime? _dataIni;
        private DateTime? _dataFim;

        public void RelatorioDespesaPorAtividade()
        {           
            if (_dataIni != null && _dataFim != null) { }
            else
            if (_dataIni != null || _dataFim != null)
            {
                MessageBox.Show("Favor informar a data inicial e final");
                return;
            }

            if (ServerDR.ExisteDespesasNaoClassificadas(DRProjetoContext.DRProjeto.CodProjeto, _dataIni, _dataFim)) 
            {
                MessageBox.Show(Resources.SMensagemValidacaoDespNaoClassificada, "Informação Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
            }

            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Acompanhamento de Despesa");

            if(ckFiltraEtapa.Checked)
                ds = ServerDR.GetEtapa_Atividade_RelDespesa(DRProjetoContext.DRProjeto.CodProjeto, drSelecAtividade_Etapa1.GetEtapasSelecionadas(),"E",
                                                            _dataIni,_dataFim);
            else
            if (ckFiltraAtividade.Checked)
                ds = ServerDR.GetEtapa_Atividade_RelDespesa(DRProjetoContext.DRProjeto.CodProjeto, drSelecAtividade_Etapa1.GetAtividadesSelecionadas(), "A",
                                                           _dataIni, _dataFim);
            else
                ds = ServerDR.GetEtapa_Atividade_RelDespesa(DRProjetoContext.DRProjeto.CodProjeto, new DataTable(), string.Empty,
                                                           _dataIni, _dataFim);
            
            if (ds.DRETAPA_ATIVIDADE.Rows.Count == 0)
            {
                DRFormAguarde.FormAguarde.FinalizaAguarde();
                MessageBox.Show("Não foi encontrado nenhuma informação!");                
                return;
            }

            DataRow rowEmp = ServerDR.GetInfoEmpresa();
            string valorTotalDespesa = ds.DRDESPESA.Compute("Sum(Valor)", string.Empty).ToString();

            string caminho;
            DRRelatorisClass.LoadLogoRel(rowEmp, out caminho);

            string titulo = "Relatório de Despesa - Etapa/Atividade";
            if(_dataIni != null && _dataFim!= null)
                titulo = string.Format("Relatório de Despesa - Etapa/Atividade - Período de {0} á {1}",Convert.ToDateTime(_dataIni).ToShortDateString(),
                                                                                                    Convert.ToDateTime(_dataFim).ToShortDateString());
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
                    new Microsoft.Reporting.WinForms.ReportParameter("TotalDespesa",valorTotalDespesa)                     
                };
                rel.ExecuteRel(ds.DRETAPA_ATIVIDADE, "DSRel_II_DRETAPA_ATIVIDADE", "DRRelEtapaAtividade.rdlc", parametros,
                new SubreportProcessingEventHandler(ProcessaSubRelatorioDespesa));
            
                
               DRRelatorisClass.DeleteImageLogo();
            }
            ds.Dispose();
        }

        public void RelatorioDespesasNaoClassificada()
        {
            if (_dataIni != null && _dataFim != null) { }
            else
                if (_dataIni != null || _dataFim != null)
                {
                    MessageBox.Show("Favor informar a data inicial e final");
                    return;
                }            

            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Despesas Não Classificadas ");

         
            ds = ServerDR.GetDespesasNaoClassificadas(DRProjetoContext.DRProjeto.CodProjeto,_dataIni, _dataFim);

            if (ds.DRDESPESANAOCLASSIFICADA.Rows.Count == 0)
            {
                DRFormAguarde.FormAguarde.FinalizaAguarde();
                MessageBox.Show("Não foi encontrado nenhuma informação!");
                return;
            }

            DataRow rowEmp = ServerDR.GetInfoEmpresa();
   
            string caminho;
            DRRelatorisClass.LoadLogoRel(rowEmp, out caminho);

            string titulo = "Relatório de Despesas Não Classificada";
            if (_dataIni != null && _dataFim != null)
                titulo = string.Format("Relatório de Despesas Não Classificada - Período de {0} á {1}", Convert.ToDateTime(_dataIni).ToShortDateString(),
                                                                                                    Convert.ToDateTime(_dataFim).ToShortDateString());
            DRFormAguarde.FormAguarde.FinalizaAguarde();

            using (DRViewRel rel = new DRViewRel())
            {
                Microsoft.Reporting.WinForms.ReportParameter[] parametros = 
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("P_OBRA","Obra: "+DRProjetoContext.DRProjeto.NomeProjeto),
                    new Microsoft.Reporting.WinForms.ReportParameter("ImageLogo",caminho),
                    new Microsoft.Reporting.WinForms.ReportParameter("Endereco",DRRelatorisClass.GetEndereco(rowEmp)),
                    new Microsoft.Reporting.WinForms.ReportParameter("NomeEmpresa",rowEmp["NOME"].ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("TITULO",titulo)
                };
                rel.ExecuteRel(ds.DRDESPESANAOCLASSIFICADA, "DSRel_II_DRDESPESANAOCLASSIFICADA", "DRRelDespesa_NaoClassificada.rdlc", parametros);                

                DRRelatorisClass.DeleteImageLogo();
            }
            ds.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _dataIni = null;
            if (dtIni.DataInformada())
                _dataIni = dtIni.GetDate();

            _dataFim = null;
            if (dtFim.DataInformada())
                _dataFim = dtFim.GetDate();

            if (checkBox1.Checked)
                RelatorioDespesasNaoClassificada();
            else
                RelatorioDespesaPorAtividade();
            
           
        }

        private void DGObraRelacionada_DRGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BnOk_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {            
            drSelecAtividade_Etapa1.HabilitaEtapa = ckFiltraEtapa.Checked;
            if (checkBox1.Checked) return;
            ckFiltraAtividade.Checked = !ckFiltraEtapa.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            drSelecAtividade_Etapa1.HabilitaAtividade = ckFiltraAtividade.Checked;
            if (checkBox1.Checked) return;
            ckFiltraEtapa.Checked = !ckFiltraAtividade.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
              ckFiltraEtapa.Checked = false;
              ckFiltraAtividade.Checked = false;
              drSelecAtividade_Etapa1.HabilitaAtividade = ckFiltraAtividade.Checked;
              drSelecAtividade_Etapa1.HabilitaEtapa = ckFiltraEtapa.Checked;
            }
            ckFiltraEtapa.Visible = !checkBox1.Checked;
            ckFiltraAtividade.Visible = !checkBox1.Checked;
        }
    }
}
