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
    public partial class DRCadAtividade : DRFormDialog
    {
        public DRCadAtividade()
        {
            InitializeComponent();
            this.EditaPK = true;
        }
        protected override void NewRegistro()
        {            
            this.BsDialog.Row["CODETAPA"] = InformacoesCtx.CodEtapa;
            this.BsDialog.Row["CodigoPrj"] = InformacoesCtx.CodProjeto;
            this.BsDialog.Row["STATUS"] = "A";
            SugereCodigo();
            base.NewRegistro();
        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRAtividadeServer();
            this.SetCampoGridInvisivel("CodigoPrj");
            this.SetCampoGridInvisivel("CODETAPA");
            this.SetCampoGridInvisivel("OBSERVACAO");
        }
        private InfoCxt InformacoesCtx
        {
            get { return (InfoCxt)this.OwnerData; }
        }

        private void CalculaValores() 
        { 
            decimal qtd = 0;
            decimal precoUnitarioMaoObra = 0;
            decimal precoUnitarioMaterial = 0;
         
            if (this.BsDialog.Row["Qtd"] != DBNull.Value && this.BsDialog.Row["Qtd"] != null)
                qtd = Convert.ToDecimal(this.BsDialog.Row["Qtd"]);

            if (this.BsDialog.Row["PrecoUnitarioMaterial"] != DBNull.Value && this.BsDialog.Row["PrecoUnitarioMaterial"] != null)
                precoUnitarioMaterial = Convert.ToDecimal(this.BsDialog.Row["PrecoUnitarioMaterial"]);

            if (this.BsDialog.Row["PrecoUnitarioMaoObra"] != DBNull.Value && this.BsDialog.Row["PrecoUnitarioMaoObra"] != null)
                precoUnitarioMaoObra = Convert.ToDecimal(this.BsDialog.Row["PrecoUnitarioMaoObra"]);


            decimal total = precoUnitarioMaoObra + precoUnitarioMaterial;
            decimal TotalGeral = total * qtd;

            this.BsDialog.Row["Total"] = total;
            this.BsDialog.Row["TotalGeral"] = TotalGeral;

            cTotal.Text = this.BsDialog.Row["Total"].ToString();
            cTotalGeral.Text = this.BsDialog.Row["TotalGeral"].ToString();
        }

        public override void ExecutaAntesdeSalvar()
        {           
            SetStatus(false);         

            if (this.BsDialog.Row["STATUS"].ToString() == "C") 
            {
               this.BsDialog.Row["PercentualCompletude"] = 100;
            }
            ValidaPercentual();
            base.ExecutaAntesdeSalvar();
        }
        public override void ExecutaAposSalvar()
        {
          
            base.ExecutaAposSalvar();
        }

        private void DRCadAtividade_Load(object sender, EventArgs e)
        {
      
        }

        private void SetStatus(bool load)
        {
            if (this.BsDialog.Row != null && Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
            {
                if (load)
                {
                    cbStatus.SelectedIndex = 0;
                    if (this.BsDialog.Row["STATUS"].ToString() == "A")//Andamento
                        cbStatus.SelectedIndex = 0;
                    else
                        if (this.BsDialog.Row["STATUS"].ToString() == "C") //Concluido
                            cbStatus.SelectedIndex = 1;
                }
                else
                {
                    if (cbStatus.SelectedIndex == 0)
                        this.BsDialog.Row["STATUS"] = "A";
                    else
                        if (cbStatus.SelectedIndex == 1)
                            this.BsDialog.Row["STATUS"] = "C";
                }
              
            }
        }

        private void BsDialog_CurrentItemChanged(object sender, EventArgs e)
        {
            SetStatus(true);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            this.BsDialog.SetModified();
        }

        private void drTextBox5_Validated(object sender, EventArgs e)
        {
            CalculaValores();
        }

        private void drTextBox6_Validated(object sender, EventArgs e)
        {
            CalculaValores();
        }

        private void drTextBox7_Validated(object sender, EventArgs e)
        {
            CalculaValores();
        }

        private void SugereCodigo() 
        {
            this.BsDialog.Row["CODATIVIDADE"] =
           ((DRAtividadeServer)this.ObjetGerenciaRegraNegocio).GetNextCodigoAtividade(InformacoesCtx.CodProjeto,
                                                                                      InformacoesCtx.CodEtapa);
            cCodigo.Text = this.BsDialog.Row["CODATIVIDADE"].ToString();
        }

      

        private void ValidaPercentual() 
        {
            if (cPercentual.Text != string.Empty)
            {
                if (Convert.ToInt32(cPercentual.Text) >= 100)
                {
                    this.BsDialog.Row["STATUS"] = "C"; //Concluido
                    cbStatus.SelectedIndex = 1;
                }
                else
                {
                    this.BsDialog.Row["STATUS"] = "A"; //Andamento
                    cbStatus.SelectedIndex = 0;                 
                }

            }
        }
        private void cPercentual_Validated(object sender, EventArgs e)
        {
            ValidaPercentual();  
        }
        private void SetValueDatas() 
        {
            if (this.BsDialog.Row != null && Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
            {
                drDateTextBox1.SetValue(this.BsDialog.Row["DataIni"]);
                drDateTextBox2.SetValue(this.BsDialog.Row["DataTermino"]);
            }
        }
        private void EnviaDataBS() 
        {
            if (drDateTextBox1.DataInformada())
                this.BsDialog.Row["DataIni"] = drDateTextBox1.GetDate();
            else
                this.BsDialog.Row["DataIni"] = DBNull.Value;

            if (drDateTextBox2.DataInformada())
                this.BsDialog.Row["DataTermino"] = drDateTextBox2.GetDate();
            else
                this.BsDialog.Row["DataTermino"] = DBNull.Value;
        }

        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            SetValueDatas();
        }

        public override void ExecutaAposCancelar()
        {
            SetValueDatas();
            SetStatus(true);
            base.ExecutaAposCancelar();
        }

        private void drDateTextBox1_MaskTextBox_Validating(object sender, CancelEventArgs e)
        {
            EnviaDataBS();
        }

        private void drDateTextBox2_MaskTextBox_Validating(object sender, CancelEventArgs e)
        {
            EnviaDataBS();

        }

        private void DRCadAtividade_Shown(object sender, EventArgs e)
        {
            drTextBox1.Focus();
        }

       
        
    }
}
