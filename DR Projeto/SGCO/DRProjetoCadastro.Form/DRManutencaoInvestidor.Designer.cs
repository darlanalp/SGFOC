namespace DRProjetoCadastro.Form
{
    partial class DRManutencaoInvestidor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLanFinan = new System.Windows.Forms.Button();
            this.pnlLanFin = new System.Windows.Forms.Panel();
            this.lbInvestidor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnLanFinan);
            this.splitContainer1.Panel2.Controls.Add(this.pnlLanFin);
            this.splitContainer1.Panel2.Controls.Add(this.lbInvestidor);
            this.splitContainer1.Size = new System.Drawing.Size(872, 262);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnLanFinan
            // 
            this.btnLanFinan.Image = global::DRProjetoCadastro.Form.Properties.Resources.Despesa;
            this.btnLanFinan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLanFinan.Location = new System.Drawing.Point(5, 3);
            this.btnLanFinan.Name = "btnLanFinan";
            this.btnLanFinan.Size = new System.Drawing.Size(162, 37);
            this.btnLanFinan.TabIndex = 4;
            this.btnLanFinan.Text = "Lançamentos Financeiros";
            this.btnLanFinan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLanFinan.UseVisualStyleBackColor = true;
            this.btnLanFinan.Click += new System.EventHandler(this.btnLanFinan_Click);
            // 
            // pnlLanFin
            // 
            this.pnlLanFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLanFin.Location = new System.Drawing.Point(0, 43);
            this.pnlLanFin.Name = "pnlLanFin";
            this.pnlLanFin.Size = new System.Drawing.Size(872, 118);
            this.pnlLanFin.TabIndex = 2;
            // 
            // lbInvestidor
            // 
            this.lbInvestidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.lbInvestidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInvestidor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInvestidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvestidor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbInvestidor.Location = new System.Drawing.Point(0, 0);
            this.lbInvestidor.Name = "lbInvestidor";
            this.lbInvestidor.Size = new System.Drawing.Size(872, 43);
            this.lbInvestidor.TabIndex = 3;
            this.lbInvestidor.Text = "Etapa(s) da Obra";
            this.lbInvestidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DRManutencaoInvestidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DRManutencaoInvestidor";
            this.Tag = "4";
            this.Text = "DRManutencaoInvestidor";
            this.Load += new System.EventHandler(this.DRManutencaoInvestidor_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DRManutencaoInvestidor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlLanFin;
        private System.Windows.Forms.Label lbInvestidor;
        private System.Windows.Forms.Button btnLanFinan;

    }
}