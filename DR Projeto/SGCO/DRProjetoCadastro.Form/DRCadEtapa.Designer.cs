namespace DRProjetoCadastro.Form
{
    partial class DRCadEtapa
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(643, 135);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Size = new System.Drawing.Size(643, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.checkBox1);
            this.tab1.Controls.Add(this.drCodEtapa);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Size = new System.Drawing.Size(635, 109);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DREtapa";
            this.BsDialog.DataSource = this.dsCadastro1;
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Descricao", true));
            this.drTextBox1.Label.Caption = "Etapa";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 40;
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
            this.drCodEtapa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CodEtapa", true));
            this.drCodEtapa.Label.Caption = "Código";
            this.drCodEtapa.Label.Required = true;
            this.drCodEtapa.Label.Width = 46;
            this.drCodEtapa.Location = new System.Drawing.Point(17, 28);
            this.drCodEtapa.Name = "drCodEtapa";
            this.drCodEtapa.Size = new System.Drawing.Size(150, 20);
            this.drCodEtapa.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BsDialog, "MostrarGrafico", true));
            this.checkBox1.Location = new System.Drawing.Point(186, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Mostrar no Gráfico de Entrada";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DRCadEtapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 206);
            this.Name = "DRCadEtapa";
            this.Tag = "6";
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}