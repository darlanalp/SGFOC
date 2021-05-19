using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;

namespace DRRelatorios.Rel
{
    public partial class DRSelecAtividade_Etapa : UserControl
    {
        public DataTable GetEtapasSelecionadas() 
        {
            return dsSelect.Tables["TblEtapa"];
        }
        public DataTable GetAtividadesSelecionadas()
        {
            return dsSelect.Tables["TblAtividade"];
        }
        public void AddTab(TabPage page,bool add) 
        {
            if (tabInformacao.TabPages.Contains(page))
            {
                if (!add) tabInformacao.TabPages.Remove(page);
            }
            else
            if(add)
                tabInformacao.TabPages.Add(page);
        }

        public bool HabilitaAtividade 
        {
            get
            {
                //if (!UltilsForm.DesignMode())
                //    return true;
                return _HabilitaAtividade; 
            }
            set
            { 
                _HabilitaAtividade = value;
                AddTab(tabAtividade, _HabilitaAtividade);
            }
        }
        private bool _HabilitaAtividade = false;

        public bool HabilitaEtapa
        {
            get
            {
                //if (!UltilsForm.DesignMode())
                //    return true;
                return _HabilitaEtapa; 
            }
            set 
            {
                _HabilitaEtapa = value;
                AddTab(tabEtapa, _HabilitaEtapa);
            }
        }
        private bool _HabilitaEtapa = false;

        public DRSelecAtividade_Etapa()
        {
            InitializeComponent();
            if(!UltilsForm.DesignMode())
               AddColuna();
        }

        private void AddColuna()
        {
            DataGridViewButtonColumn Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            Excluir.HeaderText = "";
            Excluir.Name = "Remover";
            Excluir.Text = "Remover";
            Excluir.UseColumnTextForButtonValue = true;


            dgAtividade.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {Excluir});
            dgAtividade.DG.Columns[0].HeaderText = "Código";
            dgAtividade.DG.Columns[1].HeaderText = "Atividade";

            DataGridViewButtonColumn ExcluirEtapa = new System.Windows.Forms.DataGridViewButtonColumn();
            ExcluirEtapa.HeaderText = "";
            ExcluirEtapa.Name = "Remover";
            ExcluirEtapa.Text = "Remover";
            ExcluirEtapa.UseColumnTextForButtonValue = true;
            dgEtapa.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ExcluirEtapa });
            dgEtapa.DG.Columns[0].HeaderText = "Código";
            dgEtapa.DG.Columns[1].HeaderText = "Etapa";
        }

        private void AddItem(string table,string col1,string value1,string col2,string value2) 
        {
            DataRow row = dsSelect.Tables[table].NewRow();
            row[col1] = value1;
            row[col2] = value2;
            dsSelect.Tables[table].Rows.Add(row);
        }
        private bool JaAdicionado(string table, string valuePK)
        {
           DataRow row = dsSelect.Tables[table].Rows.Find(valuePK);
           return row != null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codEtapa = drConsultaEtapa.GetValueCampo("CODETAPA").ToString();
            if (!string.IsNullOrEmpty(codEtapa))
            {
                if (JaAdicionado("TblEtapa", codEtapa))
                {
                    MessageBox.Show("Etapa já adicionada");
                    return;
                }
                AddItem("TblEtapa", "CodEtapa", codEtapa, "Etapa",
                             drConsultaEtapa.GetValueCampo("Descricao").ToString());
                drConsultaEtapa.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string codAtividade = drConsultaAtividade.GetValueCampo("CODATIVIDADE").ToString();
            if (!string.IsNullOrEmpty(codAtividade))
            {
                if (JaAdicionado("TblAtividade", codAtividade))
                {
                    MessageBox.Show("Atividade já adicionada");
                    return;
                }
                AddItem("TblAtividade", "CODATIVIDADE", codAtividade, "ATIVIDADE",
                             drConsultaAtividade.GetValueCampo("Descricao").ToString());
                drConsultaAtividade.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"A(s) atividade(s) selecionada(s) serão apagada." + Environment.NewLine +
                    "Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                dsSelect.Tables["TblAtividade"].Rows.Clear();
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"A(s) etapa(s) selecionada(s) serão apagada." + Environment.NewLine +
                                "Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                dsSelect.Tables["TblEtapa"].Rows.Clear();
            }
            
        }

        private void DGEtapa_DRGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex < 0) return;
           if (dgEtapa.DRGrid.Columns[e.ColumnIndex].Name == "Remover") 
           { 
             DataRow row = dsSelect.Tables["TblEtapa"].Rows.Find(dgEtapa.DRGrid.Rows[e.RowIndex].Cells[1].Value);
             if (row != null)
                 row.Delete();
           }
        }
        private void DGAtividade_DRGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgAtividade.DRGrid.Columns[e.ColumnIndex].Name == "Remover")
            {
                DataRow row = dsSelect.Tables["TblAtividade"].Rows.Find(dgAtividade.DRGrid.Rows[e.RowIndex].Cells[1].Value);
                if (row != null)
                    row.Delete();
            }
        }
        
    }
}
