using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;
using DRProjetoCadastro.BLL;
using DR.Utils;

namespace DRProjetoCadastro.Form
{
    public partial class DRGraficoPercentualObra : DRForm
    {
        public DRGraficoPercentualObra()
        {
            InitializeComponent();
        }

        public DRConsultas ServerDR
        {
            get { return ((DRConsultas)this.Server); }
        }

        protected override void InitServer(ref object _ServerDR)
        {
            _ServerDR = new DRConsultas();
            base.InitServer(ref _ServerDR);
        }
        private void LoadGrafico(object sender, EventArgs e)
        {
            dsGraficos1.Clear();
            ServerDR.GetPercentualEtapaObra(dsGraficos1, DRProjetoContext.DRProjeto.CodProjeto);
            ServerDR.GetEtapaOrcadoRealizado(dsGraficos1, DRProjetoContext.DRProjeto.CodProjeto);
            ServerDR.GetPercentualCompletudeEtapa(dsGraficos1, DRProjetoContext.DRProjeto.CodProjeto);
        }
        private void LoadGrafico() 
        {
            DRFormAguarde.ExecuteAsync("Carregando Gráfico.....",
            "Processando informações para o gráfico.", LoadGrafico);
            PercentualCompletudeEtapa.DataBind();
            OrcadoRealizado.DataBind();
            PercentualObra.DataBind();
        }
        private void DRGraficoPercentualObra_Load(object sender, EventArgs e)
        {

            LoadGrafico();
            ckNaoMostraNaAbertura.Checked = !DRProjetoContext.DRProjeto.PreferenciaLocal.MostraGrafico();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadGrafico();
        }

        private void ckNaoMostraNaAbertura_CheckedChanged(object sender, EventArgs e)
        {
            DRProjetoContext.DRProjeto.PreferenciaLocal.SetMostraGrafico(ckNaoMostraNaAbertura.Checked);
        }
    }
}
