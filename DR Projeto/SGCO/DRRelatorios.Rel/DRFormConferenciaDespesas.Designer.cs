namespace DRRelatorios.Rel
{
    partial class DRFormConferenciaDespesas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb = new System.Windows.Forms.Label();
            this.dtIni = new DR.Lib.Winform.DRDateTextBox();
            this.dtFim = new DR.Lib.Winform.DRDateTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Se o período não for informado será mostrado todos os\r\nPatrimônios.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 56);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = global::DRRelatorios.Rel.Properties.Resources.kghostview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(98, 10);
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
            this.button3.Location = new System.Drawing.Point(263, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.dtIni);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o período referente as informações do relatório ";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(122, 38);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(13, 13);
            this.lb.TabIndex = 1;
            this.lb.Text = "á";
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
            this.dtIni.TabIndex = 0;
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
            this.dtFim.TabIndex = 2;
            // 
            // DRFormConferenciaDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 173);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DRFormConferenciaDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRFormConferenciaDespesas";
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb;
        private DR.Lib.Winform.DRDateTextBox dtIni;
        private DR.Lib.Winform.DRDateTextBox dtFim;
    }
}