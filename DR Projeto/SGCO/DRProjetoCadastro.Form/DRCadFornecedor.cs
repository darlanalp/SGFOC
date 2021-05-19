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
    public partial class DRCadFornecedor : DRFormDialog
    {
        public DRCadFornecedor()
        {
            InitializeComponent();
        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRFornecedorServer();
            SetCampoGridInvisivel("NOME");
        }
        protected override void NewRegistro()
        {
            cP_Fisica.Checked = true;
            base.NewRegistro();
        }
      
        public override void ExecutaAntesdeSalvar()
        {
            if (cP_Fisica.Checked)
                this.BsDialog.Row["PFisicaJuridica"] = "F";
            else
            if (cP_Juridica.Checked)
                this.BsDialog.Row["PFisicaJuridica"] = "J";
              
            base.ExecutaAntesdeSalvar();
        }
        private void SetCategoria() 
        {
            if (this.BsDialog.Row == null) return;
            if (this.BsDialog.Row["PFisicaJuridica"].ToString() == "F")
                cP_Fisica.Checked = true;
            else
                if (this.BsDialog.Row["PFisicaJuridica"].ToString() == "J")
                cP_Juridica.Checked = true;
        }

        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            SetCategoria();
        }

        public override void ExecutaAposCancelar()
        {
            SetCategoria();
            base.ExecutaAposCancelar();
        }
        private void cP_Fisica_CheckedChanged(object sender, EventArgs e)
        {
            this.BsDialog.SetModified();
        }

        private void DRCadFornecedor_Shown(object sender, EventArgs e)
        {
            drTextBox2.Focus();
        }

        private void drTextBox2_Validated(object sender, EventArgs e)
        {
            drTextBox3.Text = drTextBox2.Text;
        }
    }
}
