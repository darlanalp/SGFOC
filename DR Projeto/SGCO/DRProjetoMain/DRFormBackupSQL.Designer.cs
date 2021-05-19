namespace SGFOC
{
    partial class DRFormBackupSQL
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
            this.lbResumo = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pg = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbResumo);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 109);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbResumo
            // 
            this.lbResumo.AutoSize = true;
            this.lbResumo.Location = new System.Drawing.Point(29, 28);
            this.lbResumo.Name = "lbResumo";
            this.lbResumo.Size = new System.Drawing.Size(35, 13);
            this.lbResumo.TabIndex = 1;
            this.lbResumo.Text = "label2";
            this.lbResumo.UseWaitCursor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(52, 17);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "label1";
            this.lbTitulo.UseWaitCursor = true;
            // 
            // pg
            // 
            this.pg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.pg.Location = new System.Drawing.Point(0, 86);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(389, 23);
            this.pg.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pg.TabIndex = 1;
            this.pg.UseWaitCursor = true;
            // 
            // DRFormAguarde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 109);
            this.Controls.Add(this.pg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DRFormAguarde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguarde...";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.DRFormAguarde_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DRFormAguarde_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pg;
        public System.Windows.Forms.Label lbResumo;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button button1;
    }
}