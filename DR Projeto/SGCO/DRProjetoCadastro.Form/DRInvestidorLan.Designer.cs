namespace DRProjetoCadastro.Form
{
    partial class DRInvestidorLan
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
            this.dsInvestidor1 = new DRProjetoCadastro.BLL.DSInvestidor();
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.drConsultaObra = new DR.Lib.Winform.DRConsulta();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.cDataPag = new DR.Lib.Winform.DRDateTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cUserAprovacao = new DR.Lib.Winform.DRTextBox();
            this.dtInclusao = new DR.Lib.Winform.DRTextBox();
            this.cUserInclusao = new DR.Lib.Winform.DRTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAprova = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drTextBox3 = new DR.Lib.Winform.DRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drConsulta1 = new DR.Lib.Winform.DRConsulta();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvestidor1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(659, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 308);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.drConsulta1);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.groupBox3);
            this.tab1.Controls.Add(this.drConsultaObra);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Controls.Add(this.groupBox2);
            this.tab1.Size = new System.Drawing.Size(651, 255);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRPAGAMENTOINVESTIDOR";
            this.BsDialog.DataSource = this.dsInvestidor1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            // 
            // dsInvestidor1
            // 
            this.dsInvestidor1.DataSetName = "DSInvestidor";
            this.dsInvestidor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "IDPagamento", true));
            this.drTextBox1.Label.Caption = "Id. Pagamento";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 89;
            this.drTextBox1.Location = new System.Drawing.Point(9, 66);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(100, 20);
            this.drTextBox1.TabIndex = 1;
            // 
            // drConsultaObra
            // 
            this.drConsultaObra.CampoForenKey = "CODIGOPRJ";
            this.drConsultaObra.CamposConsultados = "CODIGOPRJ;NOME";
            this.drConsultaObra.ConsultaAtiva = true;
            this.drConsultaObra.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BsDialog, "CodigoPrj", true));
            this.drConsultaObra.DescricaoCampos = "Cód. Projeto;Nome";
            this.drConsultaObra.Enabled = false;
            this.drConsultaObra.Filtro = "";
            this.drConsultaObra.Label.Caption = "Obra";
            this.drConsultaObra.Label.Required = true;
            this.drConsultaObra.Label.Width = 34;
            this.drConsultaObra.Location = new System.Drawing.Point(115, 64);
            this.drConsultaObra.Name = "drConsultaObra";
            this.drConsultaObra.NomeCampoConsulta = "CODIGOPRJ";
            this.drConsultaObra.NomeCampoDescricao = "NOME";
            this.drConsultaObra.NomeTabela = "DRPROJETO";
            this.drConsultaObra.Size = new System.Drawing.Size(512, 22);
            this.drConsultaObra.TabIndex = 2;
            this.drConsultaObra.TamanhoCampoConsulta = 67;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Valor", true));
            this.drTextBox2.FormatoMoeda = true;
            this.drTextBox2.Label.Caption = "Valor";
            this.drTextBox2.Label.Required = true;
            this.drTextBox2.Label.Width = 36;
            this.drTextBox2.Location = new System.Drawing.Point(13, 27);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(100, 20);
            this.drTextBox2.TabIndex = 0;
            // 
            // cDataPag
            // 
            this.cDataPag.Label.Caption = "Data Pagamento";
            this.cDataPag.Label.Width = 87;
            this.cDataPag.Location = new System.Drawing.Point(119, 27);
            // 
            // 
            // 
            this.cDataPag.MaskTextBox.AllowPromptAsInput = false;
            this.cDataPag.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.cDataPag.MaskTextBox.Mask = "00/00/0000";
            this.cDataPag.MaskTextBox.Name = "DRDATA";
            this.cDataPag.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.cDataPag.MaskTextBox.TabIndex = 49;
            this.cDataPag.MaskTextBox.Text = "  /  /";
            this.cDataPag.MaskTextBox.Validated += new System.EventHandler(this.drDateTextBox1_MaskTextBox_Validated);
            this.cDataPag.Name = "cDataPag";
            this.cDataPag.Size = new System.Drawing.Size(100, 20);
            this.cDataPag.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cUserAprovacao);
            this.groupBox3.Controls.Add(this.dtInclusao);
            this.groupBox3.Controls.Add(this.cUserInclusao);
            this.groupBox3.Location = new System.Drawing.Point(305, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 78);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // cUserAprovacao
            // 
            this.cUserAprovacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "UsuarioAprov", true));
            this.cUserAprovacao.Label.Caption = "UsuarioAprov";
            this.cUserAprovacao.Label.Width = 71;
            this.cUserAprovacao.Location = new System.Drawing.Point(209, 28);
            this.cUserAprovacao.Name = "cUserAprovacao";
            this.cUserAprovacao.ReadOnly = true;
            this.cUserAprovacao.Size = new System.Drawing.Size(96, 20);
            this.cUserAprovacao.TabIndex = 2;
            // 
            // dtInclusao
            // 
            this.dtInclusao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "DataAprovacao", true));
            this.dtInclusao.Label.Caption = "DataAprovacao";
            this.dtInclusao.Label.Required = true;
            this.dtInclusao.Label.Width = 95;
            this.dtInclusao.Location = new System.Drawing.Point(11, 28);
            this.dtInclusao.Name = "dtInclusao";
            this.dtInclusao.ReadOnly = true;
            this.dtInclusao.Size = new System.Drawing.Size(90, 20);
            this.dtInclusao.TabIndex = 0;
            // 
            // cUserInclusao
            // 
            this.cUserInclusao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "UsuarioInclu", true));
            this.cUserInclusao.Label.Caption = "Usuário Inclusão";
            this.cUserInclusao.Label.Width = 86;
            this.cUserInclusao.Location = new System.Drawing.Point(107, 28);
            this.cUserInclusao.Name = "cUserInclusao";
            this.cUserInclusao.ReadOnly = true;
            this.cUserInclusao.Size = new System.Drawing.Size(96, 20);
            this.cUserInclusao.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAprova);
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(305, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 53);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnAprova
            // 
            this.btnAprova.Image = global::DRProjetoCadastro.Form.Properties.Resources.clean;
            this.btnAprova.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAprova.Location = new System.Drawing.Point(215, 15);
            this.btnAprova.Name = "btnAprova";
            this.btnAprova.Size = new System.Drawing.Size(90, 33);
            this.btnAprova.TabIndex = 2;
            this.btnAprova.Text = "Aprovar";
            this.btnAprova.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAprova.UseVisualStyleBackColor = true;
            this.btnAprova.Click += new System.EventHandler(this.btnAprova_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(60, 20);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(108, 20);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "APROVADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // drTextBox3
            // 
            this.drTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Obs", true));
            this.drTextBox3.Label.Caption = "Observação";
            this.drTextBox3.Label.Width = 65;
            this.drTextBox3.Location = new System.Drawing.Point(13, 64);
            this.drTextBox3.MaxLength = 100;
            this.drTextBox3.Multiline = true;
            this.drTextBox3.Name = "drTextBox3";
            this.drTextBox3.Size = new System.Drawing.Size(259, 68);
            this.drTextBox3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cDataPag);
            this.groupBox1.Controls.Add(this.drTextBox2);
            this.groupBox1.Controls.Add(this.drTextBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // drConsulta1
            // 
            this.drConsulta1.CampoForenKey = "CodInvestidor";
            this.drConsulta1.CamposConsultados = "CodInvestidor;Nome";
            this.drConsulta1.ConsultaAtiva = false;
            this.drConsulta1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BsDialog, "CodInvestidor", true));
            this.drConsulta1.DescricaoCampos = "Cód. Investidor;Nome";
            this.drConsulta1.Enabled = false;
            this.drConsulta1.Filtro = "";
            this.drConsulta1.Label.Caption = "Investidor";
            this.drConsulta1.Label.Required = true;
            this.drConsulta1.Label.Width = 63;
            this.drConsulta1.Location = new System.Drawing.Point(9, 23);
            this.drConsulta1.Name = "drConsulta1";
            this.drConsulta1.NomeCampoConsulta = "CodInvestidor";
            this.drConsulta1.NomeCampoDescricao = "Nome";
            this.drConsulta1.NomeTabela = "DRInvestidores";
            this.drConsulta1.Size = new System.Drawing.Size(618, 22);
            this.drConsulta1.TabIndex = 0;
            this.drConsulta1.TamanhoCampoConsulta = 67;
            // 
            // DRInvestidorLan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 352);
            this.Name = "DRInvestidorLan";
            this.Tag = "9";
            this.Text = "DR";
            this.Shown += new System.EventHandler(this.DRInvestidorLan_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvestidor1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DRProjetoCadastro.BLL.DSInvestidor dsInvestidor1;
        private DR.Lib.Winform.DRTextBox drTextBox1;
        private DR.Lib.Winform.DRConsulta drConsultaObra;
        private DR.Lib.Winform.DRDateTextBox cDataPag;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DR.Lib.Winform.DRTextBox cUserAprovacao;
        private DR.Lib.Winform.DRTextBox cUserInclusao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAprova;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private DR.Lib.Winform.DRTextBox dtInclusao;
        private System.Windows.Forms.GroupBox groupBox1;
        private DR.Lib.Winform.DRTextBox drTextBox3;
        private DR.Lib.Winform.DRConsulta drConsulta1;
    }
}