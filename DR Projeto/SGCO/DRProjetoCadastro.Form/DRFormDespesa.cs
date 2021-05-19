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
using DR.Lib.Filtro;

namespace DRProjetoCadastro.Form
{
    public partial class DRFormDespesa : DRFormDialog
    {
        public DRFormDespesa()
        {
            InitializeComponent();
        }

        public void BeforeConsultaAtividade(object sender, EventArgs e)
        {
            object codEtapa = drConsultaEtapa.GetValueCampo("CODETAPA");
            if (codEtapa != null)
            {
                drConsultaAtividade.Filtro =
                string.Concat(DRProjetoContext.DRProjeto.GetFiltroProjeto(), " AND ", string.Format("(CODETAPA = '{0}')", codEtapa));
            }
            

        }

        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRDespesaServer();
       
            
        }

        private void drTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            UltilsForm.FormataMoedaTextBox(ref dtInclusao, ref  e);
        }

        public override void ExecutaAntesdeSalvar()
        {
            if (cbTipoTarefa.SelectedIndex < 0)
            {
                cbTipoTarefa.Focus();
                throw new Exception("Favor informar o tipo de Despesa.");               
            }
            if (this.Operacao == DR.Lib.Filtro.CmpOperacao.Novo)
                this.BsDialog.Row["CodigoPrj"] = DRProjetoContext.DRProjeto.CodProjeto;
            
        }

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
            if (OwnerData != null && OwnerData is InfoCxt)
            {
                BsDialog.Row["CodAtividade"] = ((InfoCxt)this.OwnerData).CodAtividade;
                BsDialog.Row["CodEtapa"] = ((InfoCxt)this.OwnerData).CodEtapa;
            }
            BsDialog.Row["DataInclusao"] = DateTime.Now.ToShortDateString();
            BsDialog.Row["STATUS"] = "N";
            BsDialog.Row["USUARIOINCLU"] = DRContex.Sistema.User.Usuario;

            cDataPag.Clear();
            SetStatus();
              
        }
        private void BsDialog_AddingNew(object sender, AddingNewEventArgs e)
        {
          
        }

        private void BsDialog_CurrentItemChanged(object sender, EventArgs e)
        {
        }
        

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BsDialog.SetModified();
        }

        private void drTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void drTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            UltilsForm.FormataMoedaTextBox(ref cValor, ref  e);
        }
      
        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            SetStatus();
            LoadInfoCampo();
        }

        private void drTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public override void ExecutaAposCancelar()
        {
            if (Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
            {
                SetStatus();
                LoadInfoCampo();
            }
            base.ExecutaAposCancelar();
        }

        private void DRFormDespesa_Load(object sender, EventArgs e)
        {
            drConsultaEtapa.Filtro = DRProjetoContext.DRProjeto.GetFiltroProjeto();
            drConsultaAtividade.BeforeConsulta += new DRConsulta.BeforeConsultaEventHandler(BeforeConsultaAtividade);
           

        }

        private void btnAprova_Click(object sender, EventArgs e)
        {
            BsDialog.Row["STATUS"] = "A";
            BsDialog.Row["USUARIOAPROVACAO"] = DRContex.Sistema.User.Usuario;
            this.SetStatus();
        }
        private void LoadInfoCampo() 
        {
            if (BsDialog.Row != null && Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
            {
               cDataPag.SetValue(BsDialog.Row["DATAPAG"]);
               if (BsDialog.Row["TipoDespesa"] != DBNull.Value)
                   cbTipoTarefa.SelectedIndex = Convert.ToInt16(BsDialog.Row["TipoDespesa"]);
               else
                   cbTipoTarefa.SelectedIndex = -1;
            }
        }
        private void drDateTextBox1_MaskTextBox_Validated(object sender, EventArgs e)
        {
            if (cDataPag.DataInformada())
                BsDialog.Row["DATAPAG"] = cDataPag.GetDate();
            else
                BsDialog.Row["DATAPAG"] = DBNull.Value;
        }

        private void cbTipoTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoTarefa.SelectedIndex != -1)
                BsDialog.Row["TipoDespesa"] = cbTipoTarefa.SelectedIndex;
        }

        private void DRFormDespesa_Shown(object sender, EventArgs e)
        {
            drConsultaEtapa.textBox1.Focus();

        }

        private void DRFormDespesa_Validated(object sender, EventArgs e)
        {

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

       

        
    }
}
