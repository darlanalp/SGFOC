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
    public partial class DRCadEtapa : DRFormDialog
    {
        public DRCadEtapa()
        {
            InitializeComponent();
            this.EditaPK = true;
        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DREtapaServer();
            this.SetCampoGridInvisivel("CodigoPrj");
        }
        public override void ExecutaAntesdeSalvar()
        {
            if (this.Operacao == DR.Lib.Filtro.CmpOperacao.Novo)
                this.BsDialog.Row["CodigoPrj"] = DRProjetoContext.DRProjeto.CodProjeto;
            base.ExecutaAntesdeSalvar();
        }

        private void DRCadEtapa_Load(object sender, EventArgs e)
        {
            drCodEtapa.Focus();
        }

        private void DRCadEtapa_Scroll(object sender, ScrollEventArgs e)
        {
            drTextBox1.Focus();
        }
    }
}
