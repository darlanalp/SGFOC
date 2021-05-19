using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;
using DRPatrimonio.Server;
using DRProjetoCadastro.Form;
using DR.Lib.Filtro;

namespace DRPatrimonio.Form
{
    public partial class DRCadPatrimonio : DRFormDialog
    {
        public DRCadPatrimonio()
        {
            InitializeComponent();
        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRPatrimonioServer();
        }
        protected override void NewRegistro()
        {
            this.BsDialog.Row["CodigoPrj"] = DRProjetoContext.DRProjeto.CodProjeto;
            cDataAquisicao.Clear();
        }


        private void LoadInfoCampo()
        {
            if (BsDialog.Row != null && Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
            {
                cDataAquisicao.SetValue(BsDialog.Row["DATAAQUISICAO"]);             
            }
        }
        private void drDateTextBox1_MaskTextBox_Validated(object sender, EventArgs e)
        {
            if (cDataAquisicao.DataInformada())
                BsDialog.Row["DATAAQUISICAO"] = cDataAquisicao.GetDate();
            else
                BsDialog.Row["DATAAQUISICAO"] = DBNull.Value;
        }

        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            LoadInfoCampo();
        }

        private void drConsultaAtividade_BeforeConsulta(object sender, EventArgs e)
        {
            object codEtapa = drConsultaEtapa.GetValueCampo("CODETAPA");
            if (codEtapa != null)
            {
                drConsultaAtividade.Filtro =
                string.Concat(DRProjetoContext.DRProjeto.GetFiltroProjeto(), " AND ", string.Format("(CODETAPA = '{0}')", codEtapa));
            }
        }

        private void DRCadPatrimonio_Load(object sender, EventArgs e)
        {
            drConsultaEtapa.Filtro = DRProjetoContext.DRProjeto.GetFiltroProjeto();
        }

        private void AfterSaveForncedor(object sender, AfterSaveEventArgs e)
        {
            BsDialog.Row["CodFornecedor"] = e.Row["CodFornecedor"];
            drConsulta1.SetConsulta(BsDialog.Row["CodFornecedor"].ToString());
        }

        private void drConsulta1_DoNewRegistro(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Você deseja incluir um Fornecedor", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                UltilsForm.ExecuteFormDialogModal(typeof(DRCadFornecedor), this.StringConexcao, "Fornecedor", CmpOperacao.Novo, "DRFORNECEDOR", null, AfterSaveForncedor);
            }
        }

        private void drTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (drTextBox1.Text != string.Empty && cValor.Text != string.Empty)
            {
                cTotal.Text = Convert.ToString(Convert.ToDecimal(cValor.Text) * Convert.ToInt32(drTextBox1.Text));
            }
        }

    }
}
