namespace DRProjetoCadastro.Form
{
    partial class DRCronograma
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlEtapa = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtivaTotalizador = new System.Windows.Forms.Button();
            this.btnAtividades = new System.Windows.Forms.Button();
            this.btDespeza = new System.Windows.Forms.Button();
            this.pnlAtividade = new System.Windows.Forms.Panel();
            this.lbAtividade = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTotalObra = new System.Windows.Forms.Panel();
            this.lbValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTotalObra.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlEtapa);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btDespeza);
            this.splitContainer1.Panel2.Controls.Add(this.pnlAtividade);
            this.splitContainer1.Panel2.Controls.Add(this.lbAtividade);
            this.splitContainer1.Size = new System.Drawing.Size(795, 444);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlEtapa
            // 
            this.pnlEtapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEtapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEtapa.Location = new System.Drawing.Point(0, 66);
            this.pnlEtapa.Name = "pnlEtapa";
            this.pnlEtapa.Size = new System.Drawing.Size(795, 166);
            this.pnlEtapa.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlTotalObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAtivaTotalizador);
            this.panel1.Controls.Add(this.btnAtividades);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etapa(s) da Obra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAtivaTotalizador
            // 
            this.btnAtivaTotalizador.Image = global::DRProjetoCadastro.Form.Properties.Resources.kformula_kfo;
            this.btnAtivaTotalizador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivaTotalizador.Location = new System.Drawing.Point(154, 3);
            this.btnAtivaTotalizador.Name = "btnAtivaTotalizador";
            this.btnAtivaTotalizador.Size = new System.Drawing.Size(151, 38);
            this.btnAtivaTotalizador.TabIndex = 0;
            this.btnAtivaTotalizador.Text = "Visualizar Totalizadores";
            this.btnAtivaTotalizador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAtivaTotalizador, "Habilita/Desabilita a visualização dos totalizadores (Valor orçado,%,Executado) e" +
                    " períodos.");
            this.btnAtivaTotalizador.UseVisualStyleBackColor = true;
            this.btnAtivaTotalizador.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAtividades
            // 
            this.btnAtividades.Image = global::DRProjetoCadastro.Form.Properties.Resources.Atividade_;
            this.btnAtividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtividades.Location = new System.Drawing.Point(10, 3);
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Size = new System.Drawing.Size(138, 38);
            this.btnAtividades.TabIndex = 0;
            this.btnAtividades.Text = "Mostrar Atividades";
            this.btnAtividades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAtividades, "Visualizar Atividades conforme a Etapa selecionada");
            this.btnAtividades.UseVisualStyleBackColor = true;
            this.btnAtividades.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDespeza
            // 
            this.btDespeza.Image = global::DRProjetoCadastro.Form.Properties.Resources.Despesa;
            this.btDespeza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDespeza.Location = new System.Drawing.Point(4, 4);
            this.btDespeza.Name = "btDespeza";
            this.btDespeza.Size = new System.Drawing.Size(89, 25);
            this.btDespeza.TabIndex = 1;
            this.btDespeza.Text = "Despesas ";
            this.btDespeza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDespeza.UseVisualStyleBackColor = true;
            this.btDespeza.Visible = false;
            this.btDespeza.Click += new System.EventHandler(this.btDespeza_Click);
            // 
            // pnlAtividade
            // 
            this.pnlAtividade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAtividade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAtividade.Location = new System.Drawing.Point(0, 33);
            this.pnlAtividade.Name = "pnlAtividade";
            this.pnlAtividade.Size = new System.Drawing.Size(795, 175);
            this.pnlAtividade.TabIndex = 1;
            // 
            // lbAtividade
            // 
            this.lbAtividade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.lbAtividade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAtividade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtividade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAtividade.Location = new System.Drawing.Point(0, 0);
            this.lbAtividade.Name = "lbAtividade";
            this.lbAtividade.Size = new System.Drawing.Size(795, 33);
            this.lbAtividade.TabIndex = 2;
            this.lbAtividade.Text = "Atividade(s) da Etapa";
            this.lbAtividade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Obra orçada em:";
            // 
            // pnlTotalObra
            // 
            this.pnlTotalObra.BackColor = System.Drawing.SystemColors.Info;
            this.pnlTotalObra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalObra.Controls.Add(this.lbValor);
            this.pnlTotalObra.Controls.Add(this.label2);
            this.pnlTotalObra.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTotalObra.Location = new System.Drawing.Point(462, 0);
            this.pnlTotalObra.Name = "pnlTotalObra";
            this.pnlTotalObra.Size = new System.Drawing.Size(331, 42);
            this.pnlTotalObra.TabIndex = 3;
            this.pnlTotalObra.Visible = false;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.ForeColor = System.Drawing.Color.Blue;
            this.lbValor.Location = new System.Drawing.Point(154, 12);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(142, 20);
            this.lbValor.TabIndex = 2;
            this.lbValor.Text = "Obra orçada em:";
            // 
            // DRCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 444);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DRCronograma";
            this.Tag = "3";
            this.Text = "DRCronograma";
            this.Load += new System.EventHandler(this.DRCronograma_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DRCronograma_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTotalObra.ResumeLayout(false);
            this.pnlTotalObra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEtapa;
        private System.Windows.Forms.Panel pnlAtividade;
        private System.Windows.Forms.Button btnAtividades;
        private System.Windows.Forms.Label lbAtividade;
        private System.Windows.Forms.Button btnAtivaTotalizador;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btDespeza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTotalObra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbValor;
    }
}