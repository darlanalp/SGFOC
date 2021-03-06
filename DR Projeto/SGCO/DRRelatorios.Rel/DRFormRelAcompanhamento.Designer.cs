namespace DRRelatorios.Rel
{
    partial class DRFormRelAcompanhamento
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
            this.dtIni = new DR.Lib.Winform.DRDateTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.dtFim = new DR.Lib.Winform.DRDateTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAcResumido = new System.Windows.Forms.RadioButton();
            this.rbAcDetalhado = new System.Windows.Forms.RadioButton();
            this.txtObs = new DR.Lib.Winform.DRTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 56);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = global::DRRelatorios.Rel.Properties.Resources.kghostview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(276, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Visualizar Impressão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::DRRelatorios.Rel.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(441, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtIni
            // 
            this.dtIni.Label.Caption = "Data Inicial";
            this.dtIni.Label.Width = 60;
            this.dtIni.Location = new System.Drawing.Point(15, 38);
            // 
            // 
            // 
            this.dtIni.MaskTextBox.AllowPromptAsInput = false;
            this.dtIni.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.dtIni.MaskTextBox.Mask = "00/00/0000";
            this.dtIni.MaskTextBox.Name = "DRDATA";
            this.dtIni.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.dtIni.MaskTextBox.TabIndex = 49;
            this.dtIni.MaskTextBox.Text = "  /  /";
            this.dtIni.Name = "dtIni";
            this.dtIni.Size = new System.Drawing.Size(100, 20);
            this.dtIni.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.dtIni);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Location = new System.Drawing.Point(267, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o período referente as informações do relatório ";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(122, 38);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(13, 13);
            this.lb.TabIndex = 5;
            this.lb.Text = "á";
            // 
            // dtFim
            // 
            this.dtFim.Label.Caption = "Data Final";
            this.dtFim.Label.Width = 55;
            this.dtFim.Location = new System.Drawing.Point(144, 38);
            // 
            // 
            // 
            this.dtFim.MaskTextBox.AllowPromptAsInput = false;
            this.dtFim.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.dtFim.MaskTextBox.Mask = "00/00/0000";
            this.dtFim.MaskTextBox.Name = "DRDATA";
            this.dtFim.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.dtFim.MaskTextBox.TabIndex = 49;
            this.dtFim.MaskTextBox.Text = "  /  /";
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(100, 20);
            this.dtFim.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(311, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Mostrar somente Etapas/Atividades que possuem despesas.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAcResumido);
            this.groupBox2.Controls.Add(this.rbAcDetalhado);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Relatório";
            // 
            // rbAcResumido
            // 
            this.rbAcResumido.AutoSize = true;
            this.rbAcResumido.Location = new System.Drawing.Point(15, 47);
            this.rbAcResumido.Name = "rbAcResumido";
            this.rbAcResumido.Size = new System.Drawing.Size(168, 30);
            this.rbAcResumido.TabIndex = 1;
            this.rbAcResumido.Text = "Percentual de Completude da \r\nEtapa/Atividade";
            this.rbAcResumido.UseVisualStyleBackColor = true;
            this.rbAcResumido.CheckedChanged += new System.EventHandler(this.rbAcResumido_CheckedChanged);
            // 
            // rbAcDetalhado
            // 
            this.rbAcDetalhado.AutoSize = true;
            this.rbAcDetalhado.Checked = true;
            this.rbAcDetalhado.Location = new System.Drawing.Point(15, 24);
            this.rbAcDetalhado.Name = "rbAcDetalhado";
            this.rbAcDetalhado.Size = new System.Drawing.Size(171, 17);
            this.rbAcDetalhado.TabIndex = 0;
            this.rbAcDetalhado.TabStop = true;
            this.rbAcDetalhado.Text = "Orçado X Realizado (Despesa)";
            this.rbAcDetalhado.UseVisualStyleBackColor = true;
            this.rbAcDetalhado.CheckedChanged += new System.EventHandler(this.rbAcDetalhado_CheckedChanged);
            // 
            // txtObs
            // 
            this.txtObs.Label.Caption = "Observação:";
            this.txtObs.Label.Width = 68;
            this.txtObs.Location = new System.Drawing.Point(12, 116);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(539, 66);
            this.txtObs.TabIndex = 6;
            // 
            // DRFormRelAcompanhamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 273);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DRFormRelAcompanhamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Acompanhamento";
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private DR.Lib.Winform.DRDateTextBox dtIni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb;
        private DR.Lib.Winform.DRDateTextBox dtFim;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAcResumido;
        private System.Windows.Forms.RadioButton rbAcDetalhado;
        private DR.Lib.Winform.DRTextBox txtObs;
    }
}