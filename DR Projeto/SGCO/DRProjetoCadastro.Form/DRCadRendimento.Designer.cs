namespace DRProjetoCadastro.Form
{
    partial class DRCadRendimento
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
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.cDataApuracao = new DR.Lib.Winform.DRDateTextBox();
            this.cMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dsCadastro1 = new DRProjetoCadastro.BLL.DSCadastro();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(491, 130);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Size = new System.Drawing.Size(491, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.cMes);
            this.tab1.Controls.Add(this.cDataApuracao);
            this.tab1.Controls.Add(this.drTextBox2);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Size = new System.Drawing.Size(483, 104);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRRENDIMENTO";
            this.BsDialog.DataSource = this.dsCadastro1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "IDRENDIMENTO", true));
            this.drTextBox1.Label.Caption = "Id. Rendimento";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 93;
            this.drTextBox1.Location = new System.Drawing.Point(19, 26);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(50, 20);
            this.drTextBox1.TabIndex = 0;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "VALORRENDIMENTO", true));
            this.drTextBox2.FormatoMoeda = true;
            this.drTextBox2.Label.Caption = "Valor Rendimento";
            this.drTextBox2.Label.Required = true;
            this.drTextBox2.Label.Width = 107;
            this.drTextBox2.Location = new System.Drawing.Point(337, 69);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(126, 20);
            this.drTextBox2.TabIndex = 2;
            // 
            // cDataApuracao
            // 
            this.cDataApuracao.Label.Caption = "Data de Apuração";
            this.cDataApuracao.Label.Required = true;
            this.cDataApuracao.Label.Width = 110;
            this.cDataApuracao.Location = new System.Drawing.Point(125, 26);
            // 
            // 
            // 
            this.cDataApuracao.MaskTextBox.AllowPromptAsInput = false;
            this.cDataApuracao.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.cDataApuracao.MaskTextBox.Mask = "00/00/0000";
            this.cDataApuracao.MaskTextBox.Name = "DRDATA";
            this.cDataApuracao.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.cDataApuracao.MaskTextBox.TabIndex = 49;
            this.cDataApuracao.MaskTextBox.Text = "  /  /";
            this.cDataApuracao.MaskTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cDataApuracao_MaskTextBox_Validating);
            this.cDataApuracao.Name = "cDataApuracao";
            this.cDataApuracao.Size = new System.Drawing.Size(99, 20);
            this.cDataApuracao.TabIndex = 4;
            // 
            // cMes
            // 
            this.cMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMes.FormattingEnabled = true;
            this.cMes.Items.AddRange(new object[] {
            "",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cMes.Location = new System.Drawing.Point(249, 25);
            this.cMes.Name = "cMes";
            this.cMes.Size = new System.Drawing.Size(214, 21);
            this.cMes.TabIndex = 6;
            this.cMes.SelectedIndexChanged += new System.EventHandler(this.cMes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mês:";
            // 
            // dsCadastro1
            // 
            this.dsCadastro1.DataSetName = "DSCadastro";
            this.dsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DRCadRendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 201);
            this.Name = "DRCadRendimento";
            this.Tag = "11";
            this.Text = "DRCadRendimento";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cMes;
        private DR.Lib.Winform.DRDateTextBox cDataApuracao;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private DR.Lib.Winform.DRTextBox drTextBox1;
        private System.Windows.Forms.Label label1;
        private DRProjetoCadastro.BLL.DSCadastro dsCadastro1;
    }
}