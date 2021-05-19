namespace DRRelatorios.Rel
{
    partial class DRFORMRelDespesaAtividade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.drConsulta1 = new DR.Lib.Winform.DRConsulta();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckFiltraAtividade = new System.Windows.Forms.CheckBox();
            this.ckFiltraEtapa = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.dtIni = new DR.Lib.Winform.DRDateTextBox();
            this.dtFim = new DR.Lib.Winform.DRDateTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.drSelecAtividade_Etapa1 = new DRRelatorios.Rel.DRSelecAtividade_Etapa();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 56);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::DRRelatorios.Rel.Properties.Resources.kghostview;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(357, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Visualizar Impressão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::DRRelatorios.Rel.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(522, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(477, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "Selecionar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // drConsulta1
            // 
            this.drConsulta1.CampoForenKey = "CodEtapa";
            this.drConsulta1.CamposConsultados = "CodEtapa;Descricao ";
            this.drConsulta1.ConsultaAtiva = true;
            this.drConsulta1.DescricaoCampos = "Código Etapa;Etapa";
            this.drConsulta1.Filtro = "";
            this.drConsulta1.Label.Caption = "Etapa";
            this.drConsulta1.Label.Required = true;
            this.drConsulta1.Label.Width = 40;
            this.drConsulta1.Location = new System.Drawing.Point(10, 19);
            this.drConsulta1.Name = "drConsulta1";
            this.drConsulta1.NomeCampoConsulta = "CodEtapa";
            this.drConsulta1.NomeCampoDescricao = "Descricao";
            this.drConsulta1.NomeTabela = "DRETAPA";
            this.drConsulta1.Size = new System.Drawing.Size(461, 22);
            this.drConsulta1.TabIndex = 49;
            this.drConsulta1.TamanhoCampoConsulta = 67;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 103);
            this.panel4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.ckFiltraAtividade);
            this.groupBox3.Controls.Add(this.ckFiltraEtapa);
            this.groupBox3.Location = new System.Drawing.Point(312, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 92);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(239, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Mostrar somente despesas não classificadas.";
            this.toolTip1.SetToolTip(this.checkBox1, "A despesas não classificadas são despesas que a Etapa/Atividade não foi informada" +
                    " ou não foi aprovada pelo usuário supervisor.");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckFiltraAtividade
            // 
            this.ckFiltraAtividade.AutoSize = true;
            this.ckFiltraAtividade.Location = new System.Drawing.Point(14, 38);
            this.ckFiltraAtividade.Name = "ckFiltraAtividade";
            this.ckFiltraAtividade.Size = new System.Drawing.Size(121, 17);
            this.ckFiltraAtividade.TabIndex = 2;
            this.ckFiltraAtividade.Text = "Filtrar por Atividades";
            this.ckFiltraAtividade.UseVisualStyleBackColor = true;
            this.ckFiltraAtividade.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckFiltraEtapa
            // 
            this.ckFiltraEtapa.AutoSize = true;
            this.ckFiltraEtapa.Location = new System.Drawing.Point(14, 17);
            this.ckFiltraEtapa.Name = "ckFiltraEtapa";
            this.ckFiltraEtapa.Size = new System.Drawing.Size(100, 17);
            this.ckFiltraEtapa.TabIndex = 1;
            this.ckFiltraEtapa.Text = "Filtrar por Etapa";
            this.ckFiltraEtapa.UseVisualStyleBackColor = true;
            this.ckFiltraEtapa.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.dtIni);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o período referente as informações do relatório ";
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
            this.label1.Text = "Se o período não for informado será mostrado todas as\r\nDespesas.";
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
            // drSelecAtividade_Etapa1
            // 
            this.drSelecAtividade_Etapa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drSelecAtividade_Etapa1.HabilitaAtividade = false;
            this.drSelecAtividade_Etapa1.HabilitaEtapa = false;
            this.drSelecAtividade_Etapa1.Location = new System.Drawing.Point(0, 103);
            this.drSelecAtividade_Etapa1.Name = "drSelecAtividade_Etapa1";
            this.drSelecAtividade_Etapa1.Size = new System.Drawing.Size(624, 302);
            this.drSelecAtividade_Etapa1.TabIndex = 1;
            // 
            // DRFORMRelDespesaAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.drSelecAtividade_Etapa1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DRFORMRelDespesaAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRFORMRelDespesaAtividade";
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private DR.Lib.Winform.DRConsulta drConsulta1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckFiltraAtividade;
        private System.Windows.Forms.CheckBox ckFiltraEtapa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
        private DR.Lib.Winform.DRDateTextBox dtIni;
        private DR.Lib.Winform.DRDateTextBox dtFim;
        private DRSelecAtividade_Etapa drSelecAtividade_Etapa1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}