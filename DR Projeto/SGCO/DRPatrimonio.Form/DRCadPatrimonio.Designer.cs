namespace DRPatrimonio.Form
{
    partial class DRCadPatrimonio
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cTotal = new DR.Lib.Winform.DRTextBox();
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.cDataAquisicao = new DR.Lib.Winform.DRDateTextBox();
            this.cValor = new DR.Lib.Winform.DRTextBox();
            this.cObeservacao = new DR.Lib.Winform.DRTextBox();
            this.drTextBox8 = new DR.Lib.Winform.DRTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.drConsulta1 = new DR.Lib.Winform.DRConsulta();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drConsultaAtividade = new DR.Lib.Winform.DRConsulta();
            this.drConsultaEtapa = new DR.Lib.Winform.DRConsulta();
            this.dsPatrimonio1 = new DRPatrimonio.Server.DSPatrimonio();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPatrimonio1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(714, 373);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Size = new System.Drawing.Size(714, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.groupBox4);
            this.tab1.Controls.Add(this.groupBox5);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.cObeservacao);
            this.tab1.Controls.Add(this.drTextBox8);
            this.tab1.Size = new System.Drawing.Size(706, 347);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRPATRIMONIO";
            this.BsDialog.DataSource = this.dsPatrimonio1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cTotal);
            this.groupBox4.Controls.Add(this.drTextBox1);
            this.groupBox4.Controls.Add(this.cDataAquisicao);
            this.groupBox4.Controls.Add(this.cValor);
            this.groupBox4.Location = new System.Drawing.Point(10, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 92);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // cTotal
            // 
            this.cTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "VALORTOTAL", true));
            this.cTotal.FormatoMoeda = true;
            this.cTotal.Label.Caption = "Total";
            this.cTotal.Label.Required = true;
            this.cTotal.Label.Width = 36;
            this.cTotal.Location = new System.Drawing.Point(133, 66);
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            this.cTotal.Size = new System.Drawing.Size(127, 20);
            this.cTotal.TabIndex = 6;
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "QTDPAT", true));
            this.drTextBox1.Label.Caption = "Quantidade";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 72;
            this.drTextBox1.Location = new System.Drawing.Point(14, 66);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(100, 20);
            this.drTextBox1.TabIndex = 4;
            this.drTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.drTextBox1_Validating);
            // 
            // cDataAquisicao
            // 
            this.cDataAquisicao.Label.Caption = "Data Aquisição";
            this.cDataAquisicao.Label.Width = 79;
            this.cDataAquisicao.Location = new System.Drawing.Point(14, 28);
            // 
            // 
            // 
            this.cDataAquisicao.MaskTextBox.AllowPromptAsInput = false;
            this.cDataAquisicao.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.cDataAquisicao.MaskTextBox.Mask = "00/00/0000";
            this.cDataAquisicao.MaskTextBox.Name = "DRDATA";
            this.cDataAquisicao.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.cDataAquisicao.MaskTextBox.TabIndex = 49;
            this.cDataAquisicao.MaskTextBox.Text = "  /  /";
            this.cDataAquisicao.MaskTextBox.Validated += new System.EventHandler(this.drDateTextBox1_MaskTextBox_Validated);
            this.cDataAquisicao.Name = "cDataAquisicao";
            this.cDataAquisicao.Size = new System.Drawing.Size(100, 20);
            this.cDataAquisicao.TabIndex = 1;
            // 
            // cValor
            // 
            this.cValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "VALORAQUISICAO", true));
            this.cValor.FormatoMoeda = true;
            this.cValor.Label.Caption = "Valor de Aquisição";
            this.cValor.Label.Required = true;
            this.cValor.Label.Width = 113;
            this.cValor.Location = new System.Drawing.Point(133, 28);
            this.cValor.Name = "cValor";
            this.cValor.Size = new System.Drawing.Size(127, 20);
            this.cValor.TabIndex = 0;
            // 
            // cObeservacao
            // 
            this.cObeservacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "OBSERVACAO", true));
            this.cObeservacao.Label.Caption = "Observação";
            this.cObeservacao.Label.Width = 65;
            this.cObeservacao.Location = new System.Drawing.Point(282, 262);
            this.cObeservacao.MaxLength = 100;
            this.cObeservacao.Multiline = true;
            this.cObeservacao.Name = "cObeservacao";
            this.cObeservacao.Size = new System.Drawing.Size(395, 73);
            this.cObeservacao.TabIndex = 5;
            // 
            // drTextBox8
            // 
            this.drTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "IDPATRIMONIO", true));
            this.drTextBox8.Label.Caption = "Id. Patrimônio";
            this.drTextBox8.Label.Required = true;
            this.drTextBox8.Label.Width = 85;
            this.drTextBox8.Location = new System.Drawing.Point(10, 19);
            this.drTextBox8.Name = "drTextBox8";
            this.drTextBox8.Size = new System.Drawing.Size(100, 20);
            this.drTextBox8.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.drConsulta1);
            this.groupBox5.Controls.Add(this.drTextBox2);
            this.groupBox5.Location = new System.Drawing.Point(9, 144);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(668, 98);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // drConsulta1
            // 
            this.drConsulta1.CampoForenKey = "CodFornecedor";
            this.drConsulta1.CamposConsultados = "CodFornecedor;NomeFantasia";
            this.drConsulta1.ConsultaAtiva = true;
            this.drConsulta1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BsDialog, "CodFornecedor", true));
            this.drConsulta1.DescricaoCampos = "Código;Fornecedor";
            this.drConsulta1.Filtro = "";
            this.drConsulta1.Label.Caption = "Fornecedor";
            this.drConsulta1.Label.Width = 61;
            this.drConsulta1.Location = new System.Drawing.Point(14, 26);
            this.drConsulta1.Name = "drConsulta1";
            this.drConsulta1.NomeCampoConsulta = "CodFornecedor";
            this.drConsulta1.NomeCampoDescricao = "NomeFantasia";
            this.drConsulta1.NomeTabela = "DRFORNECEDOR";
            this.drConsulta1.Size = new System.Drawing.Size(648, 22);
            this.drConsulta1.TabIndex = 0;
            this.drConsulta1.TamanhoCampoConsulta = 67;
            this.drConsulta1.DoNewRegistro += new DR.Lib.Winform.DRConsulta.ExecuteNovoRegistroEventHandler(this.drConsulta1_DoNewRegistro);
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "PATRIMONIO", true));
            this.drTextBox2.Label.Caption = "Descrição Patrimônio";
            this.drTextBox2.Label.Required = true;
            this.drTextBox2.Label.Width = 127;
            this.drTextBox2.Location = new System.Drawing.Point(13, 65);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(649, 20);
            this.drTextBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drConsultaAtividade);
            this.groupBox1.Controls.Add(this.drConsultaEtapa);
            this.groupBox1.Location = new System.Drawing.Point(10, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // drConsultaAtividade
            // 
            this.drConsultaAtividade.CampoForenKey = "CodAtividade";
            this.drConsultaAtividade.CamposConsultados = "CodAtividade;Descricao ";
            this.drConsultaAtividade.ConsultaAtiva = true;
            this.drConsultaAtividade.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BsDialog, "CODATIVIDADE", true));
            this.drConsultaAtividade.DescricaoCampos = "Código;Atividade";
            this.drConsultaAtividade.Filtro = "";
            this.drConsultaAtividade.Label.Caption = "Atividade";
            this.drConsultaAtividade.Label.Required = true;
            this.drConsultaAtividade.Label.Width = 60;
            this.drConsultaAtividade.Location = new System.Drawing.Point(14, 67);
            this.drConsultaAtividade.Name = "drConsultaAtividade";
            this.drConsultaAtividade.NomeCampoConsulta = "CodAtividade";
            this.drConsultaAtividade.NomeCampoDescricao = "Descricao";
            this.drConsultaAtividade.NomeTabela = "DRATIVIDADE";
            this.drConsultaAtividade.Size = new System.Drawing.Size(648, 22);
            this.drConsultaAtividade.TabIndex = 1;
            this.drConsultaAtividade.TamanhoCampoConsulta = 67;
            this.drConsultaAtividade.BeforeConsulta += new DR.Lib.Winform.DRConsulta.BeforeConsultaEventHandler(this.drConsultaAtividade_BeforeConsulta);
            // 
            // drConsultaEtapa
            // 
            this.drConsultaEtapa.CampoForenKey = "CodEtapa";
            this.drConsultaEtapa.CamposConsultados = "CodEtapa;Descricao ";
            this.drConsultaEtapa.ConsultaAtiva = true;
            this.drConsultaEtapa.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BsDialog, "CodEtapa", true));
            this.drConsultaEtapa.DescricaoCampos = "Código Etapa;Etapa";
            this.drConsultaEtapa.Filtro = "";
            this.drConsultaEtapa.Label.Caption = "Etapa";
            this.drConsultaEtapa.Label.Required = true;
            this.drConsultaEtapa.Label.Width = 40;
            this.drConsultaEtapa.Location = new System.Drawing.Point(14, 26);
            this.drConsultaEtapa.Name = "drConsultaEtapa";
            this.drConsultaEtapa.NomeCampoConsulta = "CodEtapa";
            this.drConsultaEtapa.NomeCampoDescricao = "Descricao";
            this.drConsultaEtapa.NomeTabela = "DRETAPA";
            this.drConsultaEtapa.Size = new System.Drawing.Size(648, 22);
            this.drConsultaEtapa.TabIndex = 0;
            this.drConsultaEtapa.TamanhoCampoConsulta = 67;
            // 
            // dsPatrimonio1
            // 
            this.dsPatrimonio1.DataSetName = "DSPatrimonio";
            this.dsPatrimonio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DRCadPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 444);
            this.Name = "DRCadPatrimonio";
            this.Tag = "10";
            this.Text = "DRCadPatrimonio";
            this.Load += new System.EventHandler(this.DRCadPatrimonio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPatrimonio1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private DR.Lib.Winform.DRDateTextBox cDataAquisicao;
        private DR.Lib.Winform.DRTextBox cValor;
        private System.Windows.Forms.GroupBox groupBox5;
        private DR.Lib.Winform.DRConsulta drConsulta1;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DR.Lib.Winform.DRConsulta drConsultaAtividade;
        private DR.Lib.Winform.DRConsulta drConsultaEtapa;
        private DR.Lib.Winform.DRTextBox cObeservacao;
        private DR.Lib.Winform.DRTextBox drTextBox8;
        private DRPatrimonio.Server.DSPatrimonio dsPatrimonio1;
        private DR.Lib.Winform.DRTextBox cTotal;
        private DR.Lib.Winform.DRTextBox drTextBox1;
    }
}