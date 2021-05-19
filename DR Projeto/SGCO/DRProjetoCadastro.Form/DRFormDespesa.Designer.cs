namespace DRProjetoCadastro.Form
{
    partial class DRFormDespesa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drConsultaAtividade = new DR.Lib.Winform.DRConsulta();
            this.drConsultaEtapa = new DR.Lib.Winform.DRConsulta();
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.cValor = new DR.Lib.Winform.DRTextBox();
            this.drConsulta1 = new DR.Lib.Winform.DRConsulta();
            this.dsCadastro1 = new DRProjetoCadastro.BLL.DSCadastro();
            this.drTextBox8 = new DR.Lib.Winform.DRTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAprova = new System.Windows.Forms.Button();
            this.drTextBox9 = new DR.Lib.Winform.DRTextBox();
            this.cUserAprovacao = new DR.Lib.Winform.DRTextBox();
            this.cUserInclusao = new DR.Lib.Winform.DRTextBox();
            this.dtInclusao = new DR.Lib.Winform.DRTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoTarefa = new System.Windows.Forms.ComboBox();
            this.cDataPag = new DR.Lib.Winform.DRDateTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(702, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Size = new System.Drawing.Size(702, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.groupBox4);
            this.tab1.Controls.Add(this.groupBox5);
            this.tab1.Controls.Add(this.groupBox3);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Size = new System.Drawing.Size(694, 394);
            // 
            // BsDialog
            // 
            this.BsDialog.AllowNew = true;
            this.BsDialog.DataMember = "DRDESPESA";
            this.BsDialog.DataSource = this.dsCadastro1;
            this.BsDialog.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.BsDialog_AddingNew);
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            this.BsDialog.CurrentItemChanged += new System.EventHandler(this.BsDialog_CurrentItemChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drConsultaAtividade);
            this.groupBox1.Controls.Add(this.drConsultaEtapa);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 101);
            this.groupBox1.TabIndex = 0;
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
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "IdDespesa", true));
            this.drTextBox1.Label.Caption = "Identificador da Despesa";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 149;
            this.drTextBox1.Location = new System.Drawing.Point(11, 130);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(98, 20);
            this.drTextBox1.TabIndex = 3;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Descricao", true));
            this.drTextBox2.Label.Caption = "Descrição da Despesa";
            this.drTextBox2.Label.Required = true;
            this.drTextBox2.Label.Width = 135;
            this.drTextBox2.Location = new System.Drawing.Point(13, 65);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(649, 20);
            this.drTextBox2.TabIndex = 1;
            // 
            // cValor
            // 
            this.cValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Valor", true));
            this.cValor.FormatoMoeda = true;
            this.cValor.Label.Caption = "Valor";
            this.cValor.Label.Required = true;
            this.cValor.Label.Width = 36;
            this.cValor.Location = new System.Drawing.Point(13, 27);
            this.cValor.Name = "cValor";
            this.cValor.Size = new System.Drawing.Size(100, 20);
            this.cValor.TabIndex = 0;
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
            // dsCadastro1
            // 
            this.dsCadastro1.DataSetName = "DSCadastro";
            this.dsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drTextBox8
            // 
            this.drTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "NumeroNota", true));
            this.drTextBox8.Label.Caption = "Nº Nota";
            this.drTextBox8.Label.Width = 45;
            this.drTextBox8.Location = new System.Drawing.Point(224, 27);
            this.drTextBox8.Name = "drTextBox8";
            this.drTextBox8.Size = new System.Drawing.Size(100, 20);
            this.drTextBox8.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAprova);
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnAprova
            // 
            this.btnAprova.Image = global::DRProjetoCadastro.Form.Properties.Resources.clean;
            this.btnAprova.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAprova.Location = new System.Drawing.Point(198, 14);
            this.btnAprova.Name = "btnAprova";
            this.btnAprova.Size = new System.Drawing.Size(90, 33);
            this.btnAprova.TabIndex = 2;
            this.btnAprova.Text = "Aprovar";
            this.btnAprova.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAprova.UseVisualStyleBackColor = true;
            this.btnAprova.Click += new System.EventHandler(this.btnAprova_Click);
            // 
            // drTextBox9
            // 
            this.drTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Observacao", true));
            this.drTextBox9.Label.Caption = "Observação";
            this.drTextBox9.Label.Width = 65;
            this.drTextBox9.Location = new System.Drawing.Point(12, 117);
            this.drTextBox9.MaxLength = 100;
            this.drTextBox9.Multiline = true;
            this.drTextBox9.Name = "drTextBox9";
            this.drTextBox9.Size = new System.Drawing.Size(312, 48);
            this.drTextBox9.TabIndex = 5;
            // 
            // cUserAprovacao
            // 
            this.cUserAprovacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "USUARIOAPROVACAO", true));
            this.cUserAprovacao.Label.Caption = "Usuário Aprovação";
            this.cUserAprovacao.Label.Width = 98;
            this.cUserAprovacao.Location = new System.Drawing.Point(209, 28);
            this.cUserAprovacao.Name = "cUserAprovacao";
            this.cUserAprovacao.ReadOnly = true;
            this.cUserAprovacao.Size = new System.Drawing.Size(96, 20);
            this.cUserAprovacao.TabIndex = 1;
            // 
            // cUserInclusao
            // 
            this.cUserInclusao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "USUARIOINCLU", true));
            this.cUserInclusao.Label.Caption = "Usuário Inclusão";
            this.cUserInclusao.Label.Width = 86;
            this.cUserInclusao.Location = new System.Drawing.Point(107, 28);
            this.cUserInclusao.Name = "cUserInclusao";
            this.cUserInclusao.ReadOnly = true;
            this.cUserInclusao.Size = new System.Drawing.Size(96, 20);
            this.cUserInclusao.TabIndex = 1;
            this.cUserInclusao.TextChanged += new System.EventHandler(this.drTextBox6_TextChanged);
            // 
            // dtInclusao
            // 
            this.dtInclusao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "DataInclusao", true));
            this.dtInclusao.Label.Caption = "Data Inclusão";
            this.dtInclusao.Label.Required = true;
            this.dtInclusao.Label.Width = 86;
            this.dtInclusao.Location = new System.Drawing.Point(11, 28);
            this.dtInclusao.Name = "dtInclusao";
            this.dtInclusao.ReadOnly = true;
            this.dtInclusao.Size = new System.Drawing.Size(90, 20);
            this.dtInclusao.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cUserAprovacao);
            this.groupBox3.Controls.Add(this.dtInclusao);
            this.groupBox3.Controls.Add(this.drTextBox1);
            this.groupBox3.Controls.Add(this.cUserInclusao);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(354, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 171);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbTipoTarefa);
            this.groupBox4.Controls.Add(this.cDataPag);
            this.groupBox4.Controls.Add(this.cValor);
            this.groupBox4.Controls.Add(this.drTextBox9);
            this.groupBox4.Controls.Add(this.drTextBox8);
            this.groupBox4.Location = new System.Drawing.Point(8, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 171);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Despesa";
            // 
            // cbTipoTarefa
            // 
            this.cbTipoTarefa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTarefa.FormattingEnabled = true;
            this.cbTipoTarefa.Items.AddRange(new object[] {
            "Insumo",
            "Mão de Obra",
            "Patrimônio",
            "Outras"});
            this.cbTipoTarefa.Location = new System.Drawing.Point(14, 71);
            this.cbTipoTarefa.Name = "cbTipoTarefa";
            this.cbTipoTarefa.Size = new System.Drawing.Size(310, 21);
            this.cbTipoTarefa.TabIndex = 4;
            this.cbTipoTarefa.SelectedIndexChanged += new System.EventHandler(this.cbTipoTarefa_SelectedIndexChanged);
            // 
            // cDataPag
            // 
            this.cDataPag.Label.Caption = "Data Pagamento";
            this.cDataPag.Label.Width = 87;
            this.cDataPag.Location = new System.Drawing.Point(119, 28);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.drConsulta1);
            this.groupBox5.Controls.Add(this.drTextBox2);
            this.groupBox5.Location = new System.Drawing.Point(7, 118);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(668, 98);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // DRFormDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 491);
            this.Name = "DRFormDespesa";
            this.Tag = "5";
            this.Text = "DRFormDespesa";
            this.Load += new System.EventHandler(this.DRFormDespesa_Load);
            this.Shown += new System.EventHandler(this.DRFormDespesa_Shown);
            this.Validated += new System.EventHandler(this.DRFormDespesa_Validated);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DR.Lib.Winform.DRConsulta drConsulta1;
        private DR.Lib.Winform.DRTextBox cValor;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private DR.Lib.Winform.DRTextBox drTextBox1;
        private DR.Lib.Winform.DRConsulta drConsultaAtividade;
        private DR.Lib.Winform.DRConsulta drConsultaEtapa;
        private DRProjetoCadastro.BLL.DSCadastro dsCadastro1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private DR.Lib.Winform.DRTextBox drTextBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private DR.Lib.Winform.DRTextBox cUserAprovacao;
        private DR.Lib.Winform.DRTextBox cUserInclusao;
        private DR.Lib.Winform.DRTextBox dtInclusao;
        private DR.Lib.Winform.DRTextBox drTextBox9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAprova;
        private DR.Lib.Winform.DRDateTextBox cDataPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoTarefa;
    }
}