namespace DRRelatorios.Rel
{
    partial class DRRelExtratoPagInvestidor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.drConsInvestidor = new DR.Lib.Winform.DRConsulta();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 56);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = global::DRRelatorios.Rel.Properties.Resources.kghostview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(352, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Visualizar Impressão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::DRRelatorios.Rel.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(517, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // drConsInvestidor
            // 
            this.drConsInvestidor.CampoForenKey = "CodInvestidor";
            this.drConsInvestidor.CamposConsultados = "CodInvestidor;Nome";
            this.drConsInvestidor.ConsultaAtiva = true;
            this.drConsInvestidor.DescricaoCampos = "Cód. Investidor;Nome";
            this.drConsInvestidor.Filtro = "";
            this.drConsInvestidor.Label.Caption = "Investidor";
            this.drConsInvestidor.Label.Required = true;
            this.drConsInvestidor.Label.Width = 63;
            this.drConsInvestidor.Location = new System.Drawing.Point(21, 34);
            this.drConsInvestidor.Name = "drConsInvestidor";
            this.drConsInvestidor.NomeCampoConsulta = "CodInvestidor";
            this.drConsInvestidor.NomeCampoDescricao = "Nome";
            this.drConsInvestidor.NomeTabela = "DRInvestidores";
            this.drConsInvestidor.Size = new System.Drawing.Size(577, 22);
            this.drConsInvestidor.TabIndex = 6;
            this.drConsInvestidor.TamanhoCampoConsulta = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drConsInvestidor);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Imprimir todos investidores";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DRRelExtratoPagInvestidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 184);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DRRelExtratoPagInvestidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRRelExtratoPagInvestidor";
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private DR.Lib.Winform.DRConsulta drConsInvestidor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}