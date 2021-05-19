namespace DRGlobal.Form
{
    partial class DRCadEmpresa
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
            this.dsEmpresa1 = new DRGlobal.BLL.DSEmpresa();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drTextBox7 = new DR.Lib.Winform.DRTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox3 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox4 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox5 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox6 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox8 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox9 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox10 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox11 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox12 = new DR.Lib.Winform.DRTextBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(659, 285);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 312);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.drTextBox12);
            this.tab1.Controls.Add(this.drTextBox11);
            this.tab1.Controls.Add(this.drTextBox10);
            this.tab1.Controls.Add(this.drTextBox9);
            this.tab1.Controls.Add(this.drTextBox8);
            this.tab1.Controls.Add(this.drTextBox6);
            this.tab1.Controls.Add(this.drTextBox5);
            this.tab1.Controls.Add(this.drTextBox4);
            this.tab1.Controls.Add(this.drTextBox3);
            this.tab1.Controls.Add(this.drTextBox2);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Size = new System.Drawing.Size(651, 259);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DREMPRESA";
            this.BsDialog.DataSource = this.dsEmpresa1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            // 
            // dsEmpresa1
            // 
            this.dsEmpresa1.DataSetName = "DSEmpresa";
            this.dsEmpresa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.drTextBox7);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(445, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 190);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // drTextBox7
            // 
            this.drTextBox7.Label.Width = 33;
            this.drTextBox7.Location = new System.Drawing.Point(-73, 138);
            this.drTextBox7.Name = "drTextBox7";
            this.drTextBox7.Size = new System.Drawing.Size(66, 20);
            this.drTextBox7.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 206);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(194, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DRGlobal.Form.Properties.Resources.folder_images;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Carregar Imagem";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton2.ToolTipText = "Localizar a logo da empresa";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::DRGlobal.Form.Properties.Resources.button_cancel;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Excluir Imagem";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "NOME", true));
            this.drTextBox1.Label.Caption = "Empresa";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 55;
            this.drTextBox1.Location = new System.Drawing.Point(8, 27);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(429, 20);
            this.drTextBox1.TabIndex = 1;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "ENDERECO", true));
            this.drTextBox2.Label.Caption = "Endereço";
            this.drTextBox2.Label.Width = 53;
            this.drTextBox2.Location = new System.Drawing.Point(8, 65);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(321, 20);
            this.drTextBox2.TabIndex = 3;
            // 
            // drTextBox3
            // 
            this.drTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "NUMERO", true));
            this.drTextBox3.Label.Caption = "Número";
            this.drTextBox3.Label.Width = 44;
            this.drTextBox3.Location = new System.Drawing.Point(336, 65);
            this.drTextBox3.Name = "drTextBox3";
            this.drTextBox3.Size = new System.Drawing.Size(101, 20);
            this.drTextBox3.TabIndex = 5;
            // 
            // drTextBox4
            // 
            this.drTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "COMPLEMENTO", true));
            this.drTextBox4.Label.Caption = "Complemento";
            this.drTextBox4.Label.Width = 71;
            this.drTextBox4.Location = new System.Drawing.Point(8, 105);
            this.drTextBox4.Name = "drTextBox4";
            this.drTextBox4.Size = new System.Drawing.Size(114, 20);
            this.drTextBox4.TabIndex = 7;
            // 
            // drTextBox5
            // 
            this.drTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "BAIRRO", true));
            this.drTextBox5.Label.Caption = "Bairro";
            this.drTextBox5.Label.Width = 34;
            this.drTextBox5.Location = new System.Drawing.Point(128, 104);
            this.drTextBox5.Name = "drTextBox5";
            this.drTextBox5.Size = new System.Drawing.Size(309, 20);
            this.drTextBox5.TabIndex = 9;
            // 
            // drTextBox6
            // 
            this.drTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CIDADE", true));
            this.drTextBox6.Label.Caption = "Cidade";
            this.drTextBox6.Label.Width = 40;
            this.drTextBox6.Location = new System.Drawing.Point(8, 144);
            this.drTextBox6.Name = "drTextBox6";
            this.drTextBox6.Size = new System.Drawing.Size(356, 20);
            this.drTextBox6.TabIndex = 11;
            // 
            // drTextBox8
            // 
            this.drTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "ESTADO", true));
            this.drTextBox8.Label.Caption = "Estado";
            this.drTextBox8.Label.Width = 40;
            this.drTextBox8.Location = new System.Drawing.Point(371, 144);
            this.drTextBox8.Name = "drTextBox8";
            this.drTextBox8.Size = new System.Drawing.Size(66, 20);
            this.drTextBox8.TabIndex = 13;
            // 
            // drTextBox9
            // 
            this.drTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "TELEFONE1", true));
            this.drTextBox9.Label.Caption = "Telefone 1";
            this.drTextBox9.Label.Width = 58;
            this.drTextBox9.Location = new System.Drawing.Point(187, 184);
            this.drTextBox9.Name = "drTextBox9";
            this.drTextBox9.Size = new System.Drawing.Size(122, 20);
            this.drTextBox9.TabIndex = 15;
            // 
            // drTextBox10
            // 
            this.drTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "TELEFONE2", true));
            this.drTextBox10.Label.Caption = "Telefone 2";
            this.drTextBox10.Label.Width = 58;
            this.drTextBox10.Location = new System.Drawing.Point(315, 184);
            this.drTextBox10.Name = "drTextBox10";
            this.drTextBox10.Size = new System.Drawing.Size(122, 20);
            this.drTextBox10.TabIndex = 17;
            // 
            // drTextBox11
            // 
            this.drTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CEP", true));
            this.drTextBox11.Label.Caption = "Cep";
            this.drTextBox11.Label.Width = 26;
            this.drTextBox11.Location = new System.Drawing.Point(8, 184);
            this.drTextBox11.Name = "drTextBox11";
            this.drTextBox11.Size = new System.Drawing.Size(153, 20);
            this.drTextBox11.TabIndex = 19;
            // 
            // drTextBox12
            // 
            this.drTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "EMAIL", true));
            this.drTextBox12.Label.Caption = "Email";
            this.drTextBox12.Label.Width = 32;
            this.drTextBox12.Location = new System.Drawing.Point(9, 220);
            this.drTextBox12.Name = "drTextBox12";
            this.drTextBox12.Size = new System.Drawing.Size(428, 20);
            this.drTextBox12.TabIndex = 21;
            // 
            // DRCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 356);
            this.Name = "DRCadEmpresa";
            this.Tag = "800001";
            this.Text = "DRCadEmpresa";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmpresa1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DRGlobal.BLL.DSEmpresa dsEmpresa1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DR.Lib.Winform.DRTextBox drTextBox6;
        private DR.Lib.Winform.DRTextBox drTextBox5;
        private DR.Lib.Winform.DRTextBox drTextBox4;
        private DR.Lib.Winform.DRTextBox drTextBox3;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private DR.Lib.Winform.DRTextBox drTextBox1;
        private DR.Lib.Winform.DRTextBox drTextBox7;
        private DR.Lib.Winform.DRTextBox drTextBox11;
        private DR.Lib.Winform.DRTextBox drTextBox10;
        private DR.Lib.Winform.DRTextBox drTextBox9;
        private DR.Lib.Winform.DRTextBox drTextBox8;
        private DR.Lib.Winform.DRTextBox drTextBox12;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}