namespace DRProjetoCadastro.Form
{
    partial class DRCadProjeto
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
            this.dsCadastro1 = new DRProjetoCadastro.BLL.DSCadastro();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cDataFin = new DR.Lib.Winform.DRDateTextBox();
            this.cDataIni = new DR.Lib.Winform.DRDateTextBox();
            this.drTextBox12 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox11 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox8 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox6 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox5 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox7 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox9 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox10 = new DR.Lib.Winform.DRTextBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(587, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Size = new System.Drawing.Size(587, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.drTextBox11);
            this.tab1.Controls.Add(this.drTextBox8);
            this.tab1.Controls.Add(this.drTextBox6);
            this.tab1.Controls.Add(this.drTextBox5);
            this.tab1.Controls.Add(this.drTextBox7);
            this.tab1.Controls.Add(this.drTextBox9);
            this.tab1.Controls.Add(this.drTextBox10);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.drTextBox2);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Size = new System.Drawing.Size(579, 310);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRProjeto";
            this.BsDialog.DataSource = this.dsCadastro1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CodigoPrj", true));
            this.drTextBox1.Label.Caption = "Código";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 46;
            this.drTextBox1.Location = new System.Drawing.Point(25, 36);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(87, 20);
            this.drTextBox1.TabIndex = 0;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Nome", true));
            this.drTextBox2.Label.Caption = "Nome";
            this.drTextBox2.Label.Width = 35;
            this.drTextBox2.Location = new System.Drawing.Point(118, 36);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(442, 20);
            this.drTextBox2.TabIndex = 1;
            // 
            // dsCadastro1
            // 
            this.dsCadastro1.DataSetName = "DSCadastro";
            this.dsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cDataFin);
            this.groupBox1.Controls.Add(this.cDataIni);
            this.groupBox1.Controls.Add(this.drTextBox12);
            this.groupBox1.Location = new System.Drawing.Point(25, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cDataFin
            // 
            this.cDataFin.Label.Caption = "Data Previsão do Término";
            this.cDataFin.Label.Width = 130;
            this.cDataFin.Location = new System.Drawing.Point(130, 34);
            // 
            // 
            // 
            this.cDataFin.MaskTextBox.AllowPromptAsInput = false;
            this.cDataFin.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.cDataFin.MaskTextBox.Mask = "00/00/0000";
            this.cDataFin.MaskTextBox.Name = "DRDATA";
            this.cDataFin.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.cDataFin.MaskTextBox.TabIndex = 49;
            this.cDataFin.MaskTextBox.Text = "  /  /";
            this.cDataFin.MaskTextBox.Validated += new System.EventHandler(this.cDataFin_MaskTextBox_Validated);
            this.cDataFin.Name = "cDataFin";
            this.cDataFin.Size = new System.Drawing.Size(100, 20);
            this.cDataFin.TabIndex = 2;
            // 
            // cDataIni
            // 
            this.cDataIni.Label.Caption = "Data Ínicio";
            this.cDataIni.Label.Width = 58;
            this.cDataIni.Location = new System.Drawing.Point(14, 34);
            // 
            // 
            // 
            this.cDataIni.MaskTextBox.AllowPromptAsInput = false;
            this.cDataIni.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.cDataIni.MaskTextBox.Mask = "00/00/0000";
            this.cDataIni.MaskTextBox.Name = "DRDATA";
            this.cDataIni.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.cDataIni.MaskTextBox.TabIndex = 49;
            this.cDataIni.MaskTextBox.Text = "  /  /";
            this.cDataIni.MaskTextBox.Validated += new System.EventHandler(this.cDataIni_MaskTextBox_Validated);
            this.cDataIni.Name = "cDataIni";
            this.cDataIni.Size = new System.Drawing.Size(100, 20);
            this.cDataIni.TabIndex = 1;
            // 
            // drTextBox12
            // 
            this.drTextBox12.Label.Caption = "Valor Total Orçado";
            this.drTextBox12.Label.Width = 96;
            this.drTextBox12.Location = new System.Drawing.Point(277, 34);
            this.drTextBox12.Name = "drTextBox12";
            this.drTextBox12.Size = new System.Drawing.Size(122, 20);
            this.drTextBox12.TabIndex = 0;
            // 
            // drTextBox11
            // 
            this.drTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CEP", true));
            this.drTextBox11.Label.Caption = "Cep";
            this.drTextBox11.Label.Width = 26;
            this.drTextBox11.Location = new System.Drawing.Point(25, 196);
            this.drTextBox11.Name = "drTextBox11";
            this.drTextBox11.Size = new System.Drawing.Size(153, 20);
            this.drTextBox11.TabIndex = 8;
            // 
            // drTextBox8
            // 
            this.drTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "ESTADO", true));
            this.drTextBox8.Label.Caption = "Estado";
            this.drTextBox8.Label.Width = 40;
            this.drTextBox8.Location = new System.Drawing.Point(494, 156);
            this.drTextBox8.Name = "drTextBox8";
            this.drTextBox8.Size = new System.Drawing.Size(66, 20);
            this.drTextBox8.TabIndex = 7;
            // 
            // drTextBox6
            // 
            this.drTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CIDADE", true));
            this.drTextBox6.Label.Caption = "Cidade";
            this.drTextBox6.Label.Width = 40;
            this.drTextBox6.Location = new System.Drawing.Point(25, 156);
            this.drTextBox6.Name = "drTextBox6";
            this.drTextBox6.Size = new System.Drawing.Size(463, 20);
            this.drTextBox6.TabIndex = 6;
            // 
            // drTextBox5
            // 
            this.drTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "BAIRRO", true));
            this.drTextBox5.Label.Caption = "Bairro";
            this.drTextBox5.Label.Width = 34;
            this.drTextBox5.Location = new System.Drawing.Point(145, 116);
            this.drTextBox5.Name = "drTextBox5";
            this.drTextBox5.Size = new System.Drawing.Size(415, 20);
            this.drTextBox5.TabIndex = 5;
            // 
            // drTextBox7
            // 
            this.drTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "COMPLEMENTO", true));
            this.drTextBox7.Label.Caption = "Complemento";
            this.drTextBox7.Label.Width = 71;
            this.drTextBox7.Location = new System.Drawing.Point(25, 117);
            this.drTextBox7.Name = "drTextBox7";
            this.drTextBox7.Size = new System.Drawing.Size(114, 20);
            this.drTextBox7.TabIndex = 4;
            // 
            // drTextBox9
            // 
            this.drTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "NUMERO", true));
            this.drTextBox9.Label.Caption = "Número";
            this.drTextBox9.Label.Width = 44;
            this.drTextBox9.Location = new System.Drawing.Point(459, 77);
            this.drTextBox9.Name = "drTextBox9";
            this.drTextBox9.Size = new System.Drawing.Size(101, 20);
            this.drTextBox9.TabIndex = 3;
            // 
            // drTextBox10
            // 
            this.drTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "ENDERECO", true));
            this.drTextBox10.Label.Caption = "Endereço";
            this.drTextBox10.Label.Width = 53;
            this.drTextBox10.Location = new System.Drawing.Point(25, 77);
            this.drTextBox10.Name = "drTextBox10";
            this.drTextBox10.Size = new System.Drawing.Size(429, 20);
            this.drTextBox10.TabIndex = 2;
            // 
            // DRCadProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 407);
            this.Name = "DRCadProjeto";
            this.Tag = "1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.DRCadProjeto_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DR.Lib.Winform.DRTextBox drTextBox1;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private DRProjetoCadastro.BLL.DSCadastro dsCadastro1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DR.Lib.Winform.DRTextBox drTextBox11;
        private DR.Lib.Winform.DRTextBox drTextBox8;
        private DR.Lib.Winform.DRTextBox drTextBox6;
        private DR.Lib.Winform.DRTextBox drTextBox5;
        private DR.Lib.Winform.DRTextBox drTextBox7;
        private DR.Lib.Winform.DRTextBox drTextBox9;
        private DR.Lib.Winform.DRTextBox drTextBox10;
        private DR.Lib.Winform.DRTextBox drTextBox12;
        private DR.Lib.Winform.DRDateTextBox cDataFin;
        private DR.Lib.Winform.DRDateTextBox cDataIni;
    }
}