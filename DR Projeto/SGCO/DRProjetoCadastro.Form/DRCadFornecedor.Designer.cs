namespace DRProjetoCadastro.Form
{
    partial class DRCadFornecedor
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
            this.drTextBox3 = new DR.Lib.Winform.DRTextBox();
            this.cP_Fisica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cP_Juridica = new System.Windows.Forms.RadioButton();
            this.dsCadastro1 = new DRProjetoCadastro.BLL.DSCadastro();
            this.drTextBox4 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox5 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox6 = new DR.Lib.Winform.DRTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drTextBox11 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox8 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox7 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox9 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox10 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox12 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox13 = new DR.Lib.Winform.DRTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drTextBox16 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox15 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox14 = new DR.Lib.Winform.DRTextBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(727, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Size = new System.Drawing.Size(727, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.groupBox3);
            this.tab1.Controls.Add(this.groupBox2);
            this.tab1.Controls.Add(this.drTextBox6);
            this.tab1.Controls.Add(this.drTextBox5);
            this.tab1.Controls.Add(this.drTextBox4);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.drTextBox3);
            this.tab1.Controls.Add(this.drTextBox2);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Size = new System.Drawing.Size(719, 434);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRFORNECEDOR";
            this.BsDialog.DataSource = this.dsCadastro1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CodFornecedor", true));
            this.drTextBox1.Label.Caption = "Código";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 46;
            this.drTextBox1.Location = new System.Drawing.Point(8, 27);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(100, 20);
            this.drTextBox1.TabIndex = 1;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Nome", true));
            this.drTextBox2.Label.Caption = "Nome";
            this.drTextBox2.Label.Required = true;
            this.drTextBox2.Label.Width = 39;
            this.drTextBox2.Location = new System.Drawing.Point(9, 68);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(685, 20);
            this.drTextBox2.TabIndex = 2;
            this.drTextBox2.Validated += new System.EventHandler(this.drTextBox2_Validated);
            // 
            // drTextBox3
            // 
            this.drTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "NomeFantasia", true));
            this.drTextBox3.Label.Caption = "Nome Fantasia";
            this.drTextBox3.Label.Required = true;
            this.drTextBox3.Label.Width = 91;
            this.drTextBox3.Location = new System.Drawing.Point(9, 107);
            this.drTextBox3.Name = "drTextBox3";
            this.drTextBox3.Size = new System.Drawing.Size(685, 20);
            this.drTextBox3.TabIndex = 3;
            // 
            // cP_Fisica
            // 
            this.cP_Fisica.AutoSize = true;
            this.cP_Fisica.Checked = true;
            this.cP_Fisica.Location = new System.Drawing.Point(19, 20);
            this.cP_Fisica.Name = "cP_Fisica";
            this.cP_Fisica.Size = new System.Drawing.Size(92, 17);
            this.cP_Fisica.TabIndex = 0;
            this.cP_Fisica.TabStop = true;
            this.cP_Fisica.Text = "Pessoa Física";
            this.cP_Fisica.UseVisualStyleBackColor = true;
            this.cP_Fisica.CheckedChanged += new System.EventHandler(this.cP_Fisica_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cP_Juridica);
            this.groupBox1.Controls.Add(this.cP_Fisica);
            this.groupBox1.Location = new System.Drawing.Point(9, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // cP_Juridica
            // 
            this.cP_Juridica.AutoSize = true;
            this.cP_Juridica.Location = new System.Drawing.Point(19, 40);
            this.cP_Juridica.Name = "cP_Juridica";
            this.cP_Juridica.Size = new System.Drawing.Size(101, 17);
            this.cP_Juridica.TabIndex = 1;
            this.cP_Juridica.Text = "Pessoa Jurídica";
            this.cP_Juridica.UseVisualStyleBackColor = true;
            this.cP_Juridica.CheckedChanged += new System.EventHandler(this.cP_Fisica_CheckedChanged);
            // 
            // dsCadastro1
            // 
            this.dsCadastro1.DataSetName = "DSCadastro";
            this.dsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drTextBox4
            // 
            this.drTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CPFCNPJ", true));
            this.drTextBox4.Label.Caption = "CPF/CNPJ";
            this.drTextBox4.Label.Width = 59;
            this.drTextBox4.Location = new System.Drawing.Point(179, 154);
            this.drTextBox4.Name = "drTextBox4";
            this.drTextBox4.Size = new System.Drawing.Size(141, 20);
            this.drTextBox4.TabIndex = 5;
            // 
            // drTextBox5
            // 
            this.drTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Email", true));
            this.drTextBox5.Label.Caption = "Email";
            this.drTextBox5.Label.Width = 32;
            this.drTextBox5.Location = new System.Drawing.Point(179, 195);
            this.drTextBox5.Name = "drTextBox5";
            this.drTextBox5.Size = new System.Drawing.Size(515, 20);
            this.drTextBox5.TabIndex = 7;
            // 
            // drTextBox6
            // 
            this.drTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Contato", true));
            this.drTextBox6.Label.Caption = "Contato";
            this.drTextBox6.Label.Width = 44;
            this.drTextBox6.Location = new System.Drawing.Point(327, 154);
            this.drTextBox6.Name = "drTextBox6";
            this.drTextBox6.Size = new System.Drawing.Size(367, 20);
            this.drTextBox6.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drTextBox11);
            this.groupBox2.Controls.Add(this.drTextBox8);
            this.groupBox2.Controls.Add(this.drTextBox7);
            this.groupBox2.Controls.Add(this.drTextBox9);
            this.groupBox2.Controls.Add(this.drTextBox10);
            this.groupBox2.Controls.Add(this.drTextBox12);
            this.groupBox2.Controls.Add(this.drTextBox13);
            this.groupBox2.Location = new System.Drawing.Point(9, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 143);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // drTextBox11
            // 
            this.drTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CEP", true));
            this.drTextBox11.Label.Caption = "Cep";
            this.drTextBox11.Label.Width = 26;
            this.drTextBox11.Location = new System.Drawing.Point(506, 107);
            this.drTextBox11.Name = "drTextBox11";
            this.drTextBox11.Size = new System.Drawing.Size(153, 20);
            this.drTextBox11.TabIndex = 2;
            // 
            // drTextBox8
            // 
            this.drTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "ESTADO", true));
            this.drTextBox8.Label.Caption = "Estado";
            this.drTextBox8.Label.Width = 40;
            this.drTextBox8.Location = new System.Drawing.Point(455, 107);
            this.drTextBox8.Name = "drTextBox8";
            this.drTextBox8.Size = new System.Drawing.Size(40, 20);
            this.drTextBox8.TabIndex = 1;
            // 
            // drTextBox7
            // 
            this.drTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Cidade", true));
            this.drTextBox7.Label.Caption = "Cidade";
            this.drTextBox7.Label.Width = 40;
            this.drTextBox7.Location = new System.Drawing.Point(19, 107);
            this.drTextBox7.Name = "drTextBox7";
            this.drTextBox7.Size = new System.Drawing.Size(430, 20);
            this.drTextBox7.TabIndex = 0;
            // 
            // drTextBox9
            // 
            this.drTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "BAIRRO", true));
            this.drTextBox9.Label.Caption = "Bairro";
            this.drTextBox9.Label.Width = 34;
            this.drTextBox9.Location = new System.Drawing.Point(139, 67);
            this.drTextBox9.Name = "drTextBox9";
            this.drTextBox9.Size = new System.Drawing.Size(520, 20);
            this.drTextBox9.TabIndex = 6;
            // 
            // drTextBox10
            // 
            this.drTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "COMPLEMENTO", true));
            this.drTextBox10.Label.Caption = "Complemento";
            this.drTextBox10.Label.Width = 71;
            this.drTextBox10.Location = new System.Drawing.Point(19, 68);
            this.drTextBox10.Name = "drTextBox10";
            this.drTextBox10.Size = new System.Drawing.Size(114, 20);
            this.drTextBox10.TabIndex = 5;
            // 
            // drTextBox12
            // 
            this.drTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "NUMERO", true));
            this.drTextBox12.Label.Caption = "Número";
            this.drTextBox12.Label.Width = 44;
            this.drTextBox12.Location = new System.Drawing.Point(558, 28);
            this.drTextBox12.Name = "drTextBox12";
            this.drTextBox12.Size = new System.Drawing.Size(101, 20);
            this.drTextBox12.TabIndex = 4;
            // 
            // drTextBox13
            // 
            this.drTextBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Endereco", true));
            this.drTextBox13.Label.Caption = "Endereço";
            this.drTextBox13.Label.Width = 53;
            this.drTextBox13.Location = new System.Drawing.Point(19, 28);
            this.drTextBox13.Name = "drTextBox13";
            this.drTextBox13.Size = new System.Drawing.Size(533, 20);
            this.drTextBox13.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drTextBox16);
            this.groupBox3.Controls.Add(this.drTextBox15);
            this.groupBox3.Controls.Add(this.drTextBox14);
            this.groupBox3.Location = new System.Drawing.Point(9, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 61);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // drTextBox16
            // 
            this.drTextBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Fax", true));
            this.drTextBox16.Label.Caption = "Fax";
            this.drTextBox16.Label.Width = 24;
            this.drTextBox16.Location = new System.Drawing.Point(231, 29);
            this.drTextBox16.Name = "drTextBox16";
            this.drTextBox16.Size = new System.Drawing.Size(100, 20);
            this.drTextBox16.TabIndex = 2;
            // 
            // drTextBox15
            // 
            this.drTextBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Celular", true));
            this.drTextBox15.Label.Caption = "Celular";
            this.drTextBox15.Label.Width = 39;
            this.drTextBox15.Location = new System.Drawing.Point(125, 29);
            this.drTextBox15.Name = "drTextBox15";
            this.drTextBox15.Size = new System.Drawing.Size(100, 20);
            this.drTextBox15.TabIndex = 1;
            // 
            // drTextBox14
            // 
            this.drTextBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Telefone", true));
            this.drTextBox14.Label.Caption = "Telefone";
            this.drTextBox14.Label.Width = 49;
            this.drTextBox14.Location = new System.Drawing.Point(19, 29);
            this.drTextBox14.Name = "drTextBox14";
            this.drTextBox14.Size = new System.Drawing.Size(100, 20);
            this.drTextBox14.TabIndex = 0;
            // 
            // DRCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 531);
            this.Name = "DRCadFornecedor";
            this.Tag = "2";
            this.Text = "DRCadFornecedor";
            this.Shown += new System.EventHandler(this.DRCadFornecedor_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cP_Fisica;
        private DR.Lib.Winform.DRTextBox drTextBox3;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private DR.Lib.Winform.DRTextBox drTextBox1;
        private System.Windows.Forms.RadioButton cP_Juridica;
        private DRProjetoCadastro.BLL.DSCadastro dsCadastro1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DR.Lib.Winform.DRTextBox drTextBox6;
        private DR.Lib.Winform.DRTextBox drTextBox5;
        private DR.Lib.Winform.DRTextBox drTextBox4;
        private DR.Lib.Winform.DRTextBox drTextBox11;
        private DR.Lib.Winform.DRTextBox drTextBox8;
        private DR.Lib.Winform.DRTextBox drTextBox7;
        private DR.Lib.Winform.DRTextBox drTextBox9;
        private DR.Lib.Winform.DRTextBox drTextBox10;
        private DR.Lib.Winform.DRTextBox drTextBox12;
        private DR.Lib.Winform.DRTextBox drTextBox13;
        private System.Windows.Forms.GroupBox groupBox3;
        private DR.Lib.Winform.DRTextBox drTextBox16;
        private DR.Lib.Winform.DRTextBox drTextBox15;
        private DR.Lib.Winform.DRTextBox drTextBox14;
    }
}