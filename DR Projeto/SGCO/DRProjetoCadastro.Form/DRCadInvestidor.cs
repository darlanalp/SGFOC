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
using DR.Lib.Filtro;
using DRProjetoCadastro.Form.Properties;

namespace DRProjetoCadastro.Form
{
    public partial class DRCadInvestidor : DRFormDialog
    {
        public DRCadInvestidor()
        {
            InitializeComponent();            
        }
        private void SetConfigBsObraInvestidor() 
        {
            this.BsObraRelacionada.DataMember = "FK_DROBRAINVESTIDOR_DRInvestidor";
            this.BsObraRelacionada.DataSource = this.BsDialog;
            DGObraRelacionada.DRGrid.DataSource = this.BsObraRelacionada;

            if(!ColunaAdicionada)
                AddColuna();
        }

        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRInvestidoresServer();
            //this.SetCampoGridInvisivel("CodEmpresa");
        }
        protected override void NewRegistro()
        {
            cDataNasc.Clear();
            base.NewRegistro();
        }
        private void drDateTextBox1_MaskTextBox_Validated(object sender, EventArgs e)
        {
            SetCampos();
        }

        private void BnOk_Click(object sender, EventArgs e)
        {

        }

        private void DRCadInvestidor_Load(object sender, EventArgs e)
        {
            this.SetConfigBsObraInvestidor();
            tabControl1.SelectedTab = tab1;
        }

        public override void ExecutaAposCancelar()
        {
            BsObraRelacionada.Table.RejectChanges();
            LoadCampo();
            base.ExecutaAposCancelar();
        }

        #region Manutenção Relacionamento Obra

        private CmpOperacao OperacaoRelacObra = CmpOperacao.Novo;

        private void LimpaControle() 
        {
            drConsultaObra.Clear();
            cValorInvet.Clear();
            cApartamento.Clear();
            cPercenteAdquirido.Clear();
            cFracao.Clear();
            drConsultaCota.Clear();

            drConsultaObra.Enabled = true;
            btnRelacObra.Text = "Relacionar Nova Obra";
            btnCancela.Enabled = false;

            OperacaoRelacObra = CmpOperacao.Novo;
            DGObraRelacionada.Visible = true;
            lbValorCota.Text = string.Empty;
        }
      
        private void EditaRelacObra() 
        {
            OperacaoRelacObra = CmpOperacao.Altera;
            drConsultaObra.Enabled = false;

            drConsultaObra.SetConsulta( BsObraRelacionada.Row["CodigoPrj"].ToString());
            cValorInvet.Text =  BsObraRelacionada.Row["ValorPrevistoInvesti"].ToString();
            if (cValorInvet.Text != string.Empty)
                cValorInvet.Text = string.Format("{0:C}", Convert.ToDecimal(cValorInvet.Text));
            cApartamento.Text = BsObraRelacionada.Row["Apartamento"].ToString();
            cPercenteAdquirido.Text = BsObraRelacionada.Row["PercentAdquirido"].ToString();
            cFracao.Text = BsObraRelacionada.Row["FRACAOOBRA"].ToString();

            if (BsObraRelacionada.Row["IDCOTA"] != DBNull.Value)
               drConsultaCota.SetConsulta(BsObraRelacionada.Row["IDCOTA"].ToString());
            
            btnRelacObra.Text = "Confirmar Alteração";
            btnCancela.Enabled = true;

            DGObraRelacionada.Visible = false;
            SetFilterCota();
        }

        private void RelacionaObra() 
        {
            object codPrj = drConsultaObra.GetValueCampo("CodigoPrj");

            if (codPrj == null)
            {
                MessageBox.Show("Favor informar a obra!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cApartamento.Text))
            {
                MessageBox.Show("Favor informar o apartamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(cValorInvet.Text))
            {
                MessageBox.Show("Favor informar o valor previsto para investimento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           


            if (OperacaoRelacObra == CmpOperacao.Novo)
            {
                if (BsObraRelacionada.Find("CodigoPrj", codPrj) != -1)
                {
                    MessageBox.Show("Obra já adicionada para o investidor!");
                    return;
                }

                BsObraRelacionada.AddNew();
            }

            BsObraRelacionada.Row["CodInvestidor"] = BsDialog.Row["CodInvestidor"];
            BsObraRelacionada.Row["CodigoPrj"]            = codPrj;
            BsObraRelacionada.Row["ValorPrevistoInvesti"] = cValorInvet.Text.Replace("R$",string.Empty);
            BsObraRelacionada.Row["Apartamento"]          = cApartamento.Text;
            if (cFracao.Text == string.Empty)
                BsObraRelacionada.Row["FRACAOOBRA"] = 0;
            else
                BsObraRelacionada.Row["FRACAOOBRA"] = cFracao.Text;
            if (cPercenteAdquirido.Text == string.Empty)
                BsObraRelacionada.Row["PercentAdquirido"] = 100;
            else
                BsObraRelacionada.Row["PercentAdquirido"] = cPercenteAdquirido.Text;

            if (drConsultaCota.GetValueCampo("DESCRICAO") != null)
            {
                BsObraRelacionada.Row["COTA"] = drConsultaCota.GetValueCampo("DESCRICAO");
                BsObraRelacionada.Row["IDCOTA"] = drConsultaCota.GetValueCampo("IDCOTA");

            }
            else
            {
                BsObraRelacionada.Row["COTA"] = DBNull.Value;
                BsObraRelacionada.Row["IDCOTA"] = DBNull.Value;
            }
            
            BsObraRelacionada.EndEdit();
            LimpaControle();

        }

        private void ExcluiRelacionamentoObra()
        {
            bool existe=((DRInvestidoresServer)this.ObjetGerenciaRegraNegocio).ExisteLanFinanceiroObra(
                                                Convert.ToInt32(BsObraRelacionada.Row["CODINVESTIDOR"]),
                                                Convert.ToInt32(BsObraRelacionada.Row["CodigoPrj"]));
            if (existe)
            {
                MessageBox.Show(Resources.ValidaExclusaoRelacObra, "Erro"
                              , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                
            if (MessageBox.Show("Confirma a exclusão da obra relacionada com investidor?", "Exclusão"
                              , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BsObraRelacionada.RemoveCurrent();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {      
            RelacionaObra();
        }
        private bool ColunaAdicionada = false;
        private void AddColuna() 
        {
            DataGridViewButtonColumn Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 50;
            ////
            DataGridViewButtonColumn Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            Excluir.Text = "Excluir";
            Excluir.UseColumnTextForButtonValue = true;
            Excluir.Width = 50;

            DGObraRelacionada.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Editar, Excluir});
            ColunaAdicionada = true;
        }

        private void DGObraRelacionada_DRGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            if (DGObraRelacionada.DRGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                EditaRelacObra();

            }
            else
                if (DGObraRelacionada.DRGrid.Columns[e.ColumnIndex].Name == "Excluir") 
                { 
                    ExcluiRelacionamentoObra();
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LimpaControle();
        }

        private void SetCampos()
        {
            if(cDataNasc.DataInformada())
               this.BsDialog.Row["DataNascimento"] = cDataNasc.GetDate();
            else
                this.BsDialog.Row["DataNascimento"] = DBNull.Value;
        }
        private void LoadCampo()
        {
            if (this.BsDialog.Row != null)
                cDataNasc.SetValue(this.BsDialog.Row["DataNascimento"]);
        }

        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            LoadCampo();
        }

        public override void ExecutaAntesdeSalvar()
        {
            if (BsObraRelacionada.Table == null || BsObraRelacionada.Table.Rows.Count == 0)
            {
                tabControl1.SelectedTab = tabPage1;
                throw new Exception("Favor relacionar o investidor a uma obra!");
                
            }
            base.ExecutaAntesdeSalvar();
        }

        private void DRCadInvestidor_Shown(object sender, EventArgs e)
        {
            drTextBox2.Focus();
        }

        private void SetFilterCota() 
        {
            if (drConsultaObra.GetValueCampo("CODIGOPRJ") != null)
                drConsultaCota.Filtro = string.Format(" CODIGOPRJ = {0}", drConsultaObra.GetValueCampo("CODIGOPRJ"));
        }

        private void drConsultaObra_AfterConsulta(object sender, EventArgs e)
        {
            SetFilterCota();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            decimal percentualinvest = cPercenteAdquirido.Text == string.Empty ? 0 : Convert.ToDecimal(cPercenteAdquirido.Text);
            decimal vlrTotalCota = 0;

            if (drConsultaCota.GetValueCampo("DESCRICAO") != null)
            {
                vlrTotalCota = Convert.ToDecimal(drConsultaCota.GetValueCampo("VALORPREVISTO"));
            }
            decimal calc = (vlrTotalCota * percentualinvest) / 100;
            cValorInvet.Text = string.Format("{0:C}", Convert.ToDecimal(calc)); 
        }

        private void drConsultaCota_AfterConsulta(object sender, EventArgs e)
        {
            if (drConsultaCota.GetValueCampo("DESCRICAO") != null)
            {
                lbValorCota.Text = string.Format("{0:C}",Convert.ToDecimal(drConsultaCota.GetValueCampo("VALORPREVISTO")));
            }
            else
                lbValorCota.Text = string.Empty;

        }
    }
}
