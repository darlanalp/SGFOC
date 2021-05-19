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

namespace DRProjetoCadastro.Form
{
    public partial class DRDespesaLan : DRForm
    {
        public DRDespesaLan()
        {
            InitializeComponent();
        }

        public DRLanDespesa ServerDR
        {
            get { return ((DRLanDespesa)this.Server); }
        }

        #region Componente de Consult
        private string FiltroObra() 
        {
            return string.Format("(CODIGOPRJ = {0})", DRProjetoContext.DRProjeto.CodProjeto);
        }

        public void BeforeConsultaAtividade(object sender, EventArgs e)
        {
            object codEtapa = drConsultaEtapa.GetValueCampo("CODETAPA");
            if (codEtapa != null)
            {
                drConsultaAtividade.Filtro =
                string.Concat(FiltroObra(), " AND ", string.Format("(CODETAPA = '{0}')", codEtapa));
            }

        }
        protected override void InitServer(ref object _ServerDR)
        {
            _ServerDR = new DRLanDespesa();
            base.InitServer(ref _ServerDR);
        }

        private void DRDespesaLan_Load(object sender, EventArgs e)
        {
            drConsultaEtapa.Filtro = FiltroObra();
            drConsultaAtividade.BeforeConsulta += new DRConsulta.BeforeConsultaEventHandler(BeforeConsultaAtividade);

            if (DRProjetoContext.DRProjeto.InforParam.CodEtapa != string.Empty)
                drConsultaEtapa.SetConsulta(DRProjetoContext.DRProjeto.InforParam.CodEtapa);

            if (DRProjetoContext.DRProjeto.InforParam.CodAtividade != string.Empty)
                drConsultaAtividade.SetConsulta(DRProjetoContext.DRProjeto.InforParam.CodAtividade);
            button1_Click(sender,e);
           

        }
        #endregion

        #region Despesa
        DRFormVisao FormVisaoDespesa = null;

        public string GetFiltroSelecionado() 
        {
            string filtro = string.Empty;
            object codEtapa = drConsultaEtapa.GetValueCampo("CODETAPA");
            string filtroEtapa = string.Empty;
            if (codEtapa != null)
            {
                filtroEtapa = string.Format("(CODETAPA = '{0}')", codEtapa);
            }
            object codAtividade = drConsultaAtividade.GetValueCampo("CODATIVIDADE");
            string filtroAtividade = string.Empty;
            if (codAtividade != null)
            {
                filtroAtividade = string.Format("(CODATIVIDADE = '{0}')",codAtividade);
            }


            filtro =  FiltroObra();
            if (filtro != string.Empty && filtroEtapa != string.Empty)
               filtro = string.Concat(filtro, " AND ", filtroEtapa);
            else
            if (filtroEtapa != string.Empty)
               filtro =  filtroEtapa;

            if (filtro != string.Empty && filtroAtividade != string.Empty)
                filtro = string.Concat(filtro, " AND ", filtroAtividade);
            else
            if(filtroAtividade != string.Empty)
                filtro = filtroAtividade;

            return filtro;
           
        }

        public InfoCxt InfoSelecionada
        {
            get
            {
                if (_InfoSelecionada == null)
                    _InfoSelecionada = new InfoCxt();
                return _InfoSelecionada;
            }
            set { _InfoSelecionada = value; }
        }  private InfoCxt _InfoSelecionada;

        private void ListarDespesa()
        {
            string filtro = GetFiltroSelecionado();
            if (filtro != string.Empty)
            {
                FormVisaoDespesa =
                ShowFormVisao(typeof(DRFormDespesa), "Lançamentos de Despesa", "DRDESPESA",
                                          pnlDespesa, filtro, InfoSelecionada);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            object codEtapa = drConsultaEtapa.GetValueCampo("CODETAPA");
            if (codEtapa != null)
                InfoSelecionada.CodEtapa = codEtapa.ToString();

            object codAtividade = drConsultaAtividade.GetValueCampo("CODATIVIDADE");
            if (codAtividade != null)
                InfoSelecionada.CodAtividade = codAtividade.ToString();

            if (FormVisaoDespesa == null)
                ListarDespesa();
            else
                FormVisaoDespesa.RefreshVisao(GetFiltroSelecionado(), InfoSelecionada);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void drConsultaAtividade_AfterConsulta(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void drConsultaEtapa_AfterConsulta(object sender, EventArgs e)
        {
            button1_Click(sender, e);        
        }

        private void DRDespesaLan_Shown(object sender, EventArgs e)
        {
            
        }
        
    }
}
