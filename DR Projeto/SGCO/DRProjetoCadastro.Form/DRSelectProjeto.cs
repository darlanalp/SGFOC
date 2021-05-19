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
    public partial class DRSelectProjeto : DRForm
    {
        public DRSelectProjeto()
        {
            InitializeComponent();
        }
        public DRSelecProjeto ServerDR 
        {
            get { return ((DRSelecProjeto)this.Server); }  
        }
        protected override void InitServer(ref object _ServerDR)
        {
            _ServerDR = new  DRSelecProjeto();
            base.InitServer(ref _ServerDR);
        }
      
        private void DRSelectProjeto_Load(object sender, EventArgs e)
        {
            ServerDR.ReadProjeto(ref this.dsCadastro1);

            if (dsCadastro1.Tables["DRProjetoSelect"].Rows.Count == 0)
            {
                UltilsForm.ExecuteFormDialogModal(typeof(DRCadProjeto), this.StringConexcao, "Obra", CmpOperacao.Novo, "DRPROJETO", null);
                ServerDR.ReadProjeto(ref this.dsCadastro1);
                if (dsCadastro1.Tables["DRProjetoSelect"].Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma obra foi cadastrada, entre no sistema novamente", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    this.Close();
                    return;
                }
            }

            drDataGridView1.DRGrid.Columns[0].Width = 50;
            drDataGridView1.DRGrid.Columns[1].Width = 300;
            int position = drBS.Find("CODIGOPRJ", DRProjetoContext.DRProjeto.CodProjeto);
            if (position != -1)
                drBS.Position = position;
            dsCadastro1.AcceptChanges();

            ckAtiva.Checked = ServerDR.ProjetoDefaultSetado(Convert.ToInt32(drBS.Row["CODIGOPRJ"])); 
        }
        private void SelecttRegistro() 
        {
            if (this.drBS.Row != null)
            {
                DRProjetoContext.DRProjeto.CodProjeto = Convert.ToInt32(this.drBS.Row["CodigoPrj"]);
                DRProjetoContext.DRProjeto.DataUltimoBck =  this.drBS.Row["DATALASTBCK"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(this.drBS.Row["DATALASTBCK"]);
                
                DRProjetoContext.DRProjeto.NomeProjeto = string.Concat(Convert.ToString(this.drBS.Row["Nome"])," - ", this.drBS.Row["BAIRRO"].ToString());
                DRProjetoContext.DRProjeto.strCon = this.StringConexcao;

                DRContex.Sistema.OwnerData = Convert.ToInt32(this.drBS.Row["CodigoPrj"]);
                ServerDR.SetObraAtiva(DRProjetoContext.DRProjeto.CodProjeto, ckAtiva.Checked);
                this.Close();
            }
        }
        private void BnOk_Click(object sender, EventArgs e)
        {
            SelecttRegistro();
        }

        private void DRSelectProjeto_FormClosed(object sender, FormClosedEventArgs e)
        {

            drDataGridView1.Dispose();
        }

        private void drDataGridView1_DRGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void drDataGridView1_DRGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecttRegistro();
        }

        private void drBS_PositionChanged(object sender, EventArgs e)
        {
            if (drBS.Row != null)
                ckAtiva.Checked = ServerDR.ProjetoDefaultSetado(Convert.ToInt32(drBS.Row["CODIGOPRJ"])); 
        }

    
    }
}
