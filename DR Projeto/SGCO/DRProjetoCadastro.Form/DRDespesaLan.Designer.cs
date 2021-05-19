namespace DRProjetoCadastro.Form
{
    partial class DRDespesaLan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DRDespesaLan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.drConsultaEtapa = new DR.Lib.Winform.DRConsulta();
            this.drConsultaAtividade = new DR.Lib.Winform.DRConsulta();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.pnlDespesa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drConsultaEtapa);
            this.panel1.Controls.Add(this.drConsultaAtividade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 58);
            this.panel1.TabIndex = 0;
            // 
            // drConsultaEtapa
            // 
            this.drConsultaEtapa.CampoForenKey = "CodEtapa";
            this.drConsultaEtapa.CamposConsultados = "CodEtapa;Descricao ";
            this.drConsultaEtapa.ConsultaAtiva = true;
            this.drConsultaEtapa.DescricaoCampos = "Código Etapa;Etapa";
            this.drConsultaEtapa.Filtro = "";
            this.drConsultaEtapa.Label.Caption = "Etapa";
            this.drConsultaEtapa.Label.Required = true;
            this.drConsultaEtapa.Label.Width = 40;
            this.drConsultaEtapa.Location = new System.Drawing.Point(12, 18);
            this.drConsultaEtapa.Name = "drConsultaEtapa";
            this.drConsultaEtapa.NomeCampoConsulta = "CodEtapa";
            this.drConsultaEtapa.NomeCampoDescricao = "Descricao";
            this.drConsultaEtapa.NomeTabela = "DRETAPA";
            this.drConsultaEtapa.Size = new System.Drawing.Size(451, 22);
            this.drConsultaEtapa.TabIndex = 44;
            this.drConsultaEtapa.TamanhoCampoConsulta = 67;
            this.drConsultaEtapa.AfterConsulta += new DR.Lib.Winform.DRConsulta.AfterConsultaEventHandler(this.drConsultaEtapa_AfterConsulta);
            // 
            // drConsultaAtividade
            // 
            this.drConsultaAtividade.CampoForenKey = "CodAtividade";
            this.drConsultaAtividade.CamposConsultados = "CodAtividade;Descricao ";
            this.drConsultaAtividade.ConsultaAtiva = true;
            this.drConsultaAtividade.DescricaoCampos = "Código;Atividade";
            this.drConsultaAtividade.Filtro = "";
            this.drConsultaAtividade.Label.Caption = "Atividade";
            this.drConsultaAtividade.Label.Required = true;
            this.drConsultaAtividade.Label.Width = 60;
            this.drConsultaAtividade.Location = new System.Drawing.Point(469, 18);
            this.drConsultaAtividade.Name = "drConsultaAtividade";
            this.drConsultaAtividade.NomeCampoConsulta = "CodAtividade";
            this.drConsultaAtividade.NomeCampoDescricao = "Descricao";
            this.drConsultaAtividade.NomeTabela = "DRATIVIDADE";
            this.drConsultaAtividade.Size = new System.Drawing.Size(459, 22);
            this.drConsultaAtividade.TabIndex = 44;
            this.drConsultaAtividade.TamanhoCampoConsulta = 67;
            this.drConsultaAtividade.AfterConsulta += new DR.Lib.Winform.DRConsulta.AfterConsultaEventHandler(this.drConsultaAtividade_AfterConsulta);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Status= N-Despesa não aprovada / A-Despesa aprovada";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(89, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 30);
            this.button2.TabIndex = 47;
            this.button2.Text = "Sair";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Image = global::DRProjetoCadastro.Form.Properties.Resources.accounting_reload_24;
            this.btnAtualiza.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAtualiza.Location = new System.Drawing.Point(3, 61);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(80, 30);
            this.btnAtualiza.TabIndex = 47;
            this.btnAtualiza.Text = "Atualizar";
            this.btnAtualiza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDespesa
            // 
            this.pnlDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDespesa.Location = new System.Drawing.Point(0, 95);
            this.pnlDespesa.Name = "pnlDespesa";
            this.pnlDespesa.Size = new System.Drawing.Size(942, 327);
            this.pnlDespesa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(119)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(942, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Despesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DRDespesaLan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 422);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlDespesa);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DRDespesaLan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "5";
            this.Text = "DRDespesaLan";
            this.Load += new System.EventHandler(this.DRDespesaLan_Load);
            this.Shown += new System.EventHandler(this.DRDespesaLan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DR.Lib.Winform.DRConsulta drConsultaAtividade;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Panel pnlDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private DR.Lib.Winform.DRConsulta drConsultaEtapa;
    }
}