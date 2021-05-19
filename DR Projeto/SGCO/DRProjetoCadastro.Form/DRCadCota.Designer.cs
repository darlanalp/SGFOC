namespace DRProjetoCadastro.Form
{
    partial class DRCadCota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.dsCadastro1 = new DRProjetoCadastro.BLL.DSCadastro();
            this.drCodEtapa = new DR.Lib.Winform.DRTextBox();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox3 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox4 = new DR.Lib.Winform.DRTextBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(643, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Size = new System.Drawing.Size(643, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.drTextBox4);
            this.tab1.Controls.Add(this.drTextBox3);
            this.tab1.Controls.Add(this.drCodEtapa);
            this.tab1.Controls.Add(this.drTextBox2);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Size = new System.Drawing.Size(635, 269);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRCOTAS";
            this.BsDialog.DataSource = this.dsCadastro1;
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "DESCRICAO", true));
            this.drTextBox1.Label.Caption = "Descrição";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 64;
            this.drTextBox1.Location = new System.Drawing.Point(17, 74);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(585, 20);
            this.drTextBox1.TabIndex = 2;
            // 
            // dsCadastro1
            // 
            this.dsCadastro1.DataSetName = "DSCadastro";
            this.dsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drCodEtapa
            // 
            this.drCodEtapa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "IDCOTA", true));
            this.drCodEtapa.Label.Caption = "Identificador";
            this.drCodEtapa.Label.Required = true;
            this.drCodEtapa.Label.Width = 78;
            this.drCodEtapa.Location = new System.Drawing.Point(17, 28);
            this.drCodEtapa.Name = "drCodEtapa";
            this.drCodEtapa.Size = new System.Drawing.Size(150, 20);
            this.drCodEtapa.TabIndex = 0;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "OBSERVACAO", true));
            this.drTextBox2.Label.Caption = "Observação";
            this.drTextBox2.Label.Width = 65;
            this.drTextBox2.Location = new System.Drawing.Point(17, 164);
            this.drTextBox2.Multiline = true;
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(585, 90);
            this.drTextBox2.TabIndex = 2;
            // 
            // drTextBox3
            // 
            this.drTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "PERCENTUAPROJETO", true));
            this.drTextBox3.FormatoMoeda = true;
            this.drTextBox3.Label.Caption = "Percentual da  Cota na Obra";
            this.drTextBox3.Label.Width = 142;
            this.drTextBox3.Location = new System.Drawing.Point(17, 115);
            this.drTextBox3.Name = "drTextBox3";
            this.drTextBox3.Size = new System.Drawing.Size(168, 20);
            this.drTextBox3.TabIndex = 0;
            // 
            // drTextBox4
            // 
            this.drTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "VALORPREVISTO", true));
            this.drTextBox4.FormatoMoeda = true;
            this.drTextBox4.Label.Caption = "Valor Previsto";
            this.drTextBox4.Label.Width = 72;
            this.drTextBox4.Location = new System.Drawing.Point(204, 115);
            this.drTextBox4.Name = "drTextBox4";
            this.drTextBox4.Size = new System.Drawing.Size(168, 20);
            this.drTextBox4.TabIndex = 0;
            // 
            // DRCadCota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 366);
            this.Name = "DRCadCota";
            this.Tag = "22";
            this.Text = "DRCasEtapa";
            this.Load += new System.EventHandler(this.DRCadEtapa_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DRCadEtapa_Scroll);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DR.Lib.Winform.DRTextBox drTextBox1;
        private DRProjetoCadastro.BLL.DSCadastro dsCadastro1;
        private DR.Lib.Winform.DRTextBox drCodEtapa;
        private DR.Lib.Winform.DRTextBox drTextBox3;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private DR.Lib.Winform.DRTextBox drTextBox4;
    }
}