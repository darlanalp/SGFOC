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
    public partial class DRInvestidorLan : DRFormDialog
    {
        public DRInvestidorLan()
        {
            InitializeComponent();
        }

        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRInvestidorLanServer();          
        }

        public int CodInvestidorSelect;

        private void SetStatus()
        {
            if (BsDialog.Row == null) return;

            if (BsDialog.Row["STATUS"].ToString() == "N")
            {
                lbStatus.Text = "Em Análise";
                lbStatus.ForeColor = Color.Red;
                btnAprova.Visible = DRContex.Sistema.User.Supervisor;
            }
            else
                if (BsDialog.Row["STATUS"].ToString() == "A")
                {
                    lbStatus.Text = "Aprovada";
                    lbStatus.ForeColor = Color.Blue;
                    btnAprova.Visible = false;
                }

        }
        protected override void NewRegistro()
        {
            this.BsDialog.Row["UsuarioInclu"] = DRContex.Sistema.User.Usuario;
            BsDialog.Row["STATUS"] = "N";
            BsDialog.Row["CodigoPrj"] = DRProjetoContext.DRProjeto.CodProjeto;
            BsDialog.Row["CodInvestidor"] = this.CodInvestidorSelect;
            cDataPag.Clear();
            SetStatus();
            base.NewRegistro();
        }

        private void btnAprova_Click(object sender, EventArgs e)
        {
            BsDialog.Row["STATUS"] = "A";
            BsDialog.Row["UsuarioAprov"] = DRContex.Sistema.User.Usuario;
            BsDialog.Row["DataAprovacao"] = DateTime.Now.Date;
            
            this.SetStatus();
        }

        private void LoadDataPag()
        {
            if (BsDialog.Row != null && Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
                cDataPag.SetValue(BsDialog.Row["DATAPAG"]);
        }
        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            SetStatus();
            LoadDataPag();
        }

        private void drDateTextBox1_MaskTextBox_Validated(object sender, EventArgs e)
        {
            if (cDataPag.DataInformada())
                BsDialog.Row["DATAPAG"] = cDataPag.GetDate();
            else
                BsDialog.Row["DATAPAG"] = DBNull.Value;
        }

        public override void ExecutaAposCancelar()
        {
            if (Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
            {
                SetStatus();
                LoadDataPag();
            }
            base.ExecutaAposCancelar();
        }

        private void DRInvestidorLan_Shown(object sender, EventArgs e)
        {
            drTextBox2.Focus();
        }
    }
}
