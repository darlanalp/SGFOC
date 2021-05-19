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
    public partial class DRFormConferenciaDespesas : DRForm
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

        public DRFormConferenciaDespesas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RelatorioConferencia() 
        {
            DSRel_II ds;

            DateTime? _dataIni = null;
            if (dtIni.DataInformada())
                _dataIni = dtIni.GetDate();

            DateTime? _dataFim = null;
            if (dtFim.DataInformada())
                _dataFim = dtFim.GetDate();



            DRFormAguarde.ExecuteFormWait("Gerando Relatório", "Patrimônios");
            ds = ServerDR.GetDespesadoPeriodo(_dataIni, _dataFim, DRProjetoContext.DRProjeto.CodProjeto);

            if (ds.DRDESPESACONFERENCIA.Rows.Count == 0)
            {
                DRFormAguarde.FormAguarde.FinalizaAguarde();
                MessageBox.Show("Não foi encontrado nenhuma informação!");
                return;
            }

            DataRow rowEmp = ServerDR.GetInfoEmpresa();

            string caminho;
            DRRelatorisClass.LoadLogoRel(rowEmp, out caminho);

            string titulo = "Relatório de Despesas";
            if (_dataIni != null && _dataFim != null)
                titulo = string.Format("Relatório de Despesas - Período de {0} á {1}", Convert.ToDateTime(_dataIni).ToShortDateString(),
                                                                                                    Convert.ToDateTime(_dataFim).ToShortDateString());
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

                rel.ExecuteRel(ds.DRDESPESACONFERENCIA, "DSRel_II_DRDESPESACONFERENCIA", "DRRelConferenciaDespesa.rdlc", parametros);



                DRRelatorisClass.DeleteImageLogo();
            }
            ds.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelatorioConferencia();
        }
    }
}
