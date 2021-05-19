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
    public partial class DRCadProjeto : DRFormDialog
    {
        public DRCadProjeto()
        {
            InitializeComponent();
            this.EditaPK = true;
        }
        protected override void NewRegistro()
        {
            cDataIni.Clear();
            cDataFin.Clear();
            base.NewRegistro();
        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRProjetoServer();
            //this.SetCampoGridInvisivel("CodEmpresa");
        }
        private void LoadCampo()
        {
            if (this.BsDialog.Row != null)
            {
                cDataIni.SetValue(this.BsDialog.Row["DataInicio"]);
                cDataFin.SetValue(this.BsDialog.Row["DataFin"]);
            }
        }
        private void SetCampos()
        {
            if (cDataIni.DataInformada())
                this.BsDialog.Row["DataInicio"] = cDataIni.GetDate();
            else
                this.BsDialog.Row["DataInicio"] = DBNull.Value;

            if (cDataFin.DataInformada())
                this.BsDialog.Row["DataFin"] = cDataFin.GetDate();
            else
                this.BsDialog.Row["DataFin"] = DBNull.Value;


        }
        public override void ExecutaAposCancelar()
        {
            if (this.BsDialog.Row.RowState == DataRowState.Detached) return;
            LoadCampo();
            base.ExecutaAposCancelar();
        }
        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            LoadCampo();
        }

        private void cDataIni_MaskTextBox_Validated(object sender, EventArgs e)
        {
            SetCampos();
        }

        private void cDataFin_MaskTextBox_Validated(object sender, EventArgs e)
        {
            SetCampos();
        }

        private void DRCadProjeto_Shown(object sender, EventArgs e)
        {
            drTextBox1.Focus();
        }
    }
}
