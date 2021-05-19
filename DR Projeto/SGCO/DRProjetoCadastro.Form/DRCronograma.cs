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
using System.Reflection;
using DR.Lib.Filtro;
using DR.Utils;

namespace DRProjetoCadastro.Form
{
    public partial class DRCronograma : DRForm
    {
        public DRCronograma()
        {
            InitializeComponent();
            
        }

        public DRCronogramaServer ServerDR
        {
            get { return ((DRCronogramaServer)this.Server); }
        }

        protected override void InitServer(ref object _ServerDR)
        {
            _ServerDR = new DRCronogramaServer();
            base.InitServer(ref _ServerDR);
        }

        private InfoCxt _InfoSelecionada;

        public InfoCxt InfoSelecionada
        {
            get
            {
                if (_InfoSelecionada == null)
                    _InfoSelecionada = new InfoCxt();
                return _InfoSelecionada;
            }
            set { _InfoSelecionada = value; }
        }

        #region Cadastro Etapa    
        string FiltroEtapaSelecionado = string.Empty;
        DRFormVisao FormEtapa;
        private void MostraVisaoEtapa() 
        {
           FormEtapa = ShowFormVisao(typeof(DRCadEtapa), "Cadastro de Etapas", "DREtapa",
                                     pnlEtapa, string.Empty, InfoSelecionada);

           FormEtapa.NavegaEntreRegisto = new DR.Lib.Winform.DRFormVisao.NavengaEntreRegistroEventHandler(NavegaEtapa);
           FormEtapa.Navega();

        }

        private bool TotalizadorAtivado = false;
        private void AtivaTotalizadores_Etapa(bool ativado) 
        {
            ((DREtapaServer)FormEtapa.ObjetGerenciaRegraNegocio).ParamServer.VisualizacaoTotalizadoresAtivado = ativado;
            if(FormVisaoAtividade != null)
                ((DRAtividadeServer)FormVisaoAtividade.ObjetGerenciaRegraNegocio).ParamServer.VisualizacaoTotalizadoresAtivado = ativado;

            FormEtapa.RefreshVisao(string.Empty, InfoSelecionada);
            TotalizadorAtivado = ativado;
            pnlTotalObra.Visible = ativado;
            if (ativado)
            {
                btnAtivaTotalizador.Text = "Cancelar Totalizadores";
                btnAtivaTotalizador.Image = DRProjetoCadastro.Form.Properties.Resources.undo;
                lbValor.Text = ServerDR.GetValorTotalOrcadoObra(DRProjetoContext.DRProjeto.CodProjeto);
            }
            else
            {
                btnAtivaTotalizador.Text = "Visualizar Totalizadores";
                btnAtivaTotalizador.Image = DRProjetoCadastro.Form.Properties.Resources.kformula_kfo;
            }
        }

        private void NavegaEtapa(object sender, DRFormVisao.NavengaEntreRegistroEventArgs e)
        {
            FiltroEtapaSelecionado = string.Format("(CodigoPrj = {0} AND CodEtapa = '{1}')",
                                                  e.RowSelected["CodigoPrj"],
                                                  e.RowSelected["CodEtapa"]);
            lbAtividade.Text =string.Concat("Atividade(s) da Etapa: ",e.RowSelected["CodEtapa"].ToString(),
                                           " - ", e.RowSelected["DESCRICAO"]);

            if (e.RowSelected["CodigoPrj"] != DBNull.Value)
                InfoSelecionada.CodProjeto = Convert.ToInt32(e.RowSelected["CodigoPrj"]);

            if (e.RowSelected["CodEtapa"] != DBNull.Value)
            {
                InfoSelecionada.CodEtapa = e.RowSelected["CodEtapa"].ToString();
            }

            if (FormVisaoAtividade != null)
            {
                FormVisaoAtividade.RefreshVisao(FiltroEtapaSelecionado,InfoSelecionada);
            }
            else
                lbAtividade.Visible = false;
        }

        #endregion

        #region Cadastro Atividade
        DRFormVisao FormVisaoAtividade = null;
        private void MostraVisaoAtividade()
        {
            if (FiltroEtapaSelecionado != string.Empty)
            {
                FormVisaoAtividade =
                ShowFormVisao(typeof(DRCadAtividade), "Cadastro de Atividades", "DRAtividade",
                                          pnlAtividade, FiltroEtapaSelecionado, InfoSelecionada);
                FormVisaoAtividade.NavegaEntreRegisto = new DR.Lib.Winform.DRFormVisao.NavengaEntreRegistroEventHandler(NavegaAtividade);
                FormVisaoAtividade.Navega();
            }
            btnAtividades.Enabled = false;
            lbAtividade.Visible = true;
            btDespeza.Visible = true;
        }
        private void NavegaAtividade(object sender, DR.Lib.Winform.DRFormVisao.NavengaEntreRegistroEventArgs e)
        {          
            if (e.RowSelected["CodAtividade"] != DBNull.Value)
            {
                InfoSelecionada.CodAtividade = e.RowSelected["CodAtividade"].ToString();
            }           
        }
        #endregion

  
        private void DRCronograma_Load(object sender, EventArgs e)
        {
            MostraVisaoEtapa();
            btnAtividades.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(7);
            btnAtivaTotalizador.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(21);
            btDespeza.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(5);

        }

        private void DRCronograma_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormEtapa.NavegaEntreRegisto -= NavegaEtapa;
            FormEtapa.Dispose();
            if (FormVisaoAtividade != null)
            {
                FormVisaoAtividade.NavegaEntreRegisto -= NavegaAtividade;
                FormVisaoAtividade.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostraVisaoAtividade();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(TotalizadorAtivado)
                AtivaTotalizadores_Etapa(false);
            else
               AtivaTotalizadores_Etapa(true);
        }

        private void btDespeza_Click(object sender, EventArgs e)
        {
            DRProjetoContext.DRProjeto.InforParam = InfoSelecionada;
            UltilsForm.ExecuteFormModal(typeof(DRDespesaLan), this.StringConexcao, "Despesa por Etapa/Atividade");
        }
     
        
    }

    

     
}
