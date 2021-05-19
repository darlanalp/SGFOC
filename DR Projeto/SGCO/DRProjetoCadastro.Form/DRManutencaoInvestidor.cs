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
    public partial class DRManutencaoInvestidor : DRForm
    {
        public DRManutencaoInvestidor()
        {
            InitializeComponent();
        }

        public DRManutencaoInvestiddorServer ServerDR
        {
            get { return ((DRManutencaoInvestiddorServer)this.Server); }
        }

        protected override void InitServer(ref object _ServerDR)
        {
            _ServerDR = new DRManutencaoInvestiddorServer();
            base.InitServer(ref _ServerDR);
        }
        #region Investidor
        DRFormVisao FormInvestidor;
        private string FiltroInvestidor = string.Empty;
        private void MostraVisaoInvestidor()
        {
            FormInvestidor = ShowFormVisao(typeof(DRCadInvestidor), "Investidores", "DRInvestidores",
                                       splitContainer1.Panel1, string.Empty, null);

            FormInvestidor.NavegaEntreRegisto = new DRFormVisao.NavengaEntreRegistroEventHandler(NavegaInvestidor);
            FormInvestidor.Navega();

        }
        private void NavegaInvestidor(object sender, DRFormVisao.NavengaEntreRegistroEventArgs e)
        {
            FiltroInvestidor = string.Format("(CodInvestidor = {0} AND CodigoPrj = '{1}')",
                                                e.RowSelected["CodInvestidor"],
                                                DRProjetoContext.DRProjeto.CodProjeto);
            lbInvestidor.Text ="Lan. Financeiro Investidor: "+ e.RowSelected["Nome"].ToString();

            if (FormVisaoPagInvestidor != null)
            {
                FormVisaoPagInvestidor.RefreshVisao(FiltroInvestidor, null);
                ((DRInvestidorLan)FormVisaoPagInvestidor.FormDialog).CodInvestidorSelect = Convert.ToInt32(e.RowSelected["CodInvestidor"]);
            }

        }
        #endregion

        private void DRManutencaoInvestidor_Load(object sender, EventArgs e)
        {
            MostraVisaoInvestidor();
            btnLanFinan.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(9);
        }

        #region Pagamentos Investidor
        DRFormVisao FormVisaoPagInvestidor = null;
        private void MostraVisaoPagInvestidor()
        {
            if (FiltroInvestidor != string.Empty)
            {
                FormVisaoPagInvestidor =
                ShowFormVisao(typeof(DRInvestidorLan), "Financeiro Investidor", "DRPAGAMENTOINVESTIDOR",
                                          pnlLanFin, FiltroInvestidor, null);
                FormVisaoPagInvestidor.NavegaEntreRegisto = new DR.Lib.Winform.DRFormVisao.NavengaEntreRegistroEventHandler(NavegaLanFinanceiro);             
                FormVisaoPagInvestidor.Navega();
                btnLanFinan.Enabled = false;
                FormInvestidor.Navega();
            }
           
          //  lbAtividade.Visible = true;
          //  btDespeza.Visible = true;
        }
        private void NavegaLanFinanceiro(object sender, DR.Lib.Winform.DRFormVisao.NavengaEntreRegistroEventArgs e)
        {
           
        }
        #endregion

        private void btnLanFinan_Click(object sender, EventArgs e)
        {
            MostraVisaoPagInvestidor();
        }

        private void DRManutencaoInvestidor_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormInvestidor.NavegaEntreRegisto -= NavegaInvestidor;
            FormInvestidor.Dispose();
            if (FormVisaoPagInvestidor != null)
            {
                FormVisaoPagInvestidor.NavegaEntreRegisto -= NavegaLanFinanceiro;
                FormVisaoPagInvestidor.Dispose();
            }
        }

    }
}
