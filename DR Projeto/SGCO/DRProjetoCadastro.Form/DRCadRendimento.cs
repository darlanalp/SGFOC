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
    public partial class DRCadRendimento : DRFormDialog
    {
        public DRCadRendimento()
        {
            InitializeComponent();
        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRCadRendimentoServer();    
        }
        protected override void NewRegistro()
        {
            this.BsDialog.Row["CodigoPrj"] = DRProjetoContext.DRProjeto.CodProjeto;           
        }

        private void SetInfo()
        { 
            this.BsDialog.Row["DATAAPURACAO"] = cDataApuracao.GetDate().ToShortDateString();
            this.BsDialog.Row["MES"] = cMes.SelectedIndex;
        }

        private void LoadInfo() 
        {
            if (BsDialog.Row == null) return;
            cDataApuracao.SetValue(this.BsDialog.Row["DATAAPURACAO"]);
            if (this.BsDialog.Row["MES"] != DBNull.Value)
               cMes.SelectedIndex = Convert.ToInt16( this.BsDialog.Row["MES"]);      
        }

        private void cMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BsDialog.SetModified();
        }

        private void cDataApuracao_MaskTextBox_Validating(object sender, CancelEventArgs e)
        {
            this.BsDialog.SetModified();

            if (cDataApuracao.DataInformada())
            {
                cMes.SelectedIndex = cDataApuracao.GetDate().Month;
            }
        }
        public override void ExecutaAposCancelar()
        {
            if (Operacao == DR.Lib.Filtro.CmpOperacao.Altera)
            {
                LoadInfo();
            }
            base.ExecutaAposCancelar();
        }

        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            LoadInfo();
        }
        public override void ExecutaAntesdeSalvar()
        {
            SetInfo();

        }
    }
}
