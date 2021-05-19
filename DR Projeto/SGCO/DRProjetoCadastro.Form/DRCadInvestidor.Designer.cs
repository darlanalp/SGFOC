namespace DRProjetoCadastro.Form
{
    partial class DRCadInvestidor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.drConsultaCota = new DR.Lib.Winform.DRConsulta();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.drTextBox11 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox5 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox8 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox7 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox9 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox10 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox12 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox13 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox4 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.dsInvestidor1 = new DRProjetoCadastro.BLL.DSInvestidor();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cDataNasc = new DR.Lib.Winform.DRDateTextBox();
            this.drTextBox6 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox16 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox15 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox14 = new DR.Lib.Winform.DRTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbValorCota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cFracao = new DR.Lib.Winform.DRTextBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.cPercenteAdquirido = new DR.Lib.Winform.DRTextBox();
            this.drConsultaObra = new DR.Lib.Winform.DRConsulta();
            this.cApartamento = new DR.Lib.Winform.DRTextBox();
            this.cValorInvet = new DR.Lib.Winform.DRTextBox();
            this.btnRelacObra = new System.Windows.Forms.Button();
            this.DGObraRelacionada = new DR.Lib.Winform.DRDataGridView();
            this.BsObraRelacionada = new DR.Lib.Winform.DRBindingSource(this.components);
            this.drTextBox18 = new DR.Lib.Winform.DRTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvestidor1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGObraRelacionada.DRGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsObraRelacionada)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Size = new System.Drawing.Size(810, 410);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Controls.SetChildIndex(this.tabPage1, 0);
            this.tabControl1.Controls.SetChildIndex(this.tab1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Size = new System.Drawing.Size(810, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.drTextBox18);
            this.tab1.Controls.Add(this.groupBox3);
            this.tab1.Controls.Add(this.groupBox2);
            this.tab1.Controls.Add(this.drTextBox2);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Size = new System.Drawing.Size(802, 384);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRInvestidores";
            this.BsDialog.DataSource = this.dsInvestidor1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            // 
            // drConsultaCota
            // 
            this.drConsultaCota.CampoForenKey = "IDCOTA";
            this.drConsultaCota.CamposConsultados = "IDCOTA;DESCRICAO;PERCENTUAPROJETO;VALORPREVISTO";
            this.drConsultaCota.ConsultaAtiva = true;
            this.drConsultaCota.DescricaoCampos = "Identificador;Descrição;Percentual na Obra;Valor Previsto";
            this.drConsultaCota.Filtro = "";
            this.drConsultaCota.Label.Caption = "Cota";
            this.drConsultaCota.Label.Required = true;
            this.drConsultaCota.Label.Width = 33;
            this.drConsultaCota.Location = new System.Drawing.Point(16, 63);
            this.drConsultaCota.Name = "drConsultaCota";
            this.drConsultaCota.NomeCampoConsulta = "IDCOTA";
            this.drConsultaCota.NomeCampoDescricao = "DESCRICAO";
            this.drConsultaCota.NomeTabela = "DRCOTAS";
            this.drConsultaCota.Size = new System.Drawing.Size(473, 22);
            this.drConsultaCota.TabIndex = 1;
            this.drConsultaCota.TamanhoCampoConsulta = 67;
            this.drConsultaCota.AfterConsulta += new DR.Lib.Winform.DRConsulta.AfterConsultaEventHandler(this.drConsultaCota_AfterConsulta);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.drTextBox11);
            this.groupBox2.Controls.Add(this.drTextBox5);
            this.groupBox2.Controls.Add(this.drTextBox8);
            this.groupBox2.Controls.Add(this.drTextBox7);
            this.groupBox2.Controls.Add(this.drTextBox9);
            this.groupBox2.Controls.Add(this.drTextBox10);
            this.groupBox2.Controls.Add(this.drTextBox12);
            this.groupBox2.Controls.Add(this.drTextBox13);
            this.groupBox2.Location = new System.Drawing.Point(16, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // drTextBox11
            // 
            this.drTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CEP", true));
            this.drTextBox11.Label.Caption = "Cep";
            this.drTextBox11.Label.Visible = false;
            this.drTextBox11.Label.Width = 26;
            this.drTextBox11.Location = new System.Drawing.Point(506, 107);
            this.drTextBox11.Name = "drTextBox11";
            this.drTextBox11.Size = new System.Drawing.Size(153, 20);
            this.drTextBox11.TabIndex = 6;
            // 
            // drTextBox5
            // 
            this.drTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Email", true));
            this.drTextBox5.Label.Caption = "Email";
            this.drTextBox5.Label.Visible = false;
            this.drTextBox5.Label.Width = 32;
            this.drTextBox5.Location = new System.Drawing.Point(19, 144);
            this.drTextBox5.Name = "drTextBox5";
            this.drTextBox5.Size = new System.Drawing.Size(640, 20);
            this.drTextBox5.TabIndex = 7;
            // 
            // drTextBox8
            // 
            this.drTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "ESTADO", true));
            this.drTextBox8.Label.Caption = "Estado";
            this.drTextBox8.Label.Visible = false;
            this.drTextBox8.Label.Width = 40;
            this.drTextBox8.Location = new System.Drawing.Point(455, 107);
            this.drTextBox8.Name = "drTextBox8";
            this.drTextBox8.Size = new System.Drawing.Size(40, 20);
            this.drTextBox8.TabIndex = 5;
            // 
            // drTextBox7
            // 
            this.drTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Cidade", true));
            this.drTextBox7.Label.Caption = "Cidade";
            this.drTextBox7.Label.Visible = false;
            this.drTextBox7.Label.Width = 40;
            this.drTextBox7.Location = new System.Drawing.Point(19, 107);
            this.drTextBox7.Name = "drTextBox7";
            this.drTextBox7.Size = new System.Drawing.Size(430, 20);
            this.drTextBox7.TabIndex = 4;
            // 
            // drTextBox9
            // 
            this.drTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "BAIRRO", true));
            this.drTextBox9.Label.Caption = "Bairro";
            this.drTextBox9.Label.Visible = false;
            this.drTextBox9.Label.Width = 34;
            this.drTextBox9.Location = new System.Drawing.Point(139, 67);
            this.drTextBox9.Name = "drTextBox9";
            this.drTextBox9.Size = new System.Drawing.Size(520, 20);
            this.drTextBox9.TabIndex = 3;
            // 
            // drTextBox10
            // 
            this.drTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "COMPLEMENTO", true));
            this.drTextBox10.Label.Caption = "Complemento";
            this.drTextBox10.Label.Visible = false;
            this.drTextBox10.Label.Width = 71;
            this.drTextBox10.Location = new System.Drawing.Point(19, 68);
            this.drTextBox10.Name = "drTextBox10";
            this.drTextBox10.Size = new System.Drawing.Size(114, 20);
            this.drTextBox10.TabIndex = 2;
            // 
            // drTextBox12
            // 
            this.drTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "NUMERO", true));
            this.drTextBox12.Label.Caption = "Nº";
            this.drTextBox12.Label.Visible = false;
            this.drTextBox12.Label.Width = 19;
            this.drTextBox12.Location = new System.Drawing.Point(558, 28);
            this.drTextBox12.Name = "drTextBox12";
            this.drTextBox12.Size = new System.Drawing.Size(101, 20);
            this.drTextBox12.TabIndex = 1;
            // 
            // drTextBox13
            // 
            this.drTextBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Endereco", true));
            this.drTextBox13.Label.Caption = "Endereço";
            this.drTextBox13.Label.Visible = false;
            this.drTextBox13.Label.Width = 53;
            this.drTextBox13.Location = new System.Drawing.Point(19, 28);
            this.drTextBox13.Name = "drTextBox13";
            this.drTextBox13.Size = new System.Drawing.Size(533, 20);
            this.drTextBox13.TabIndex = 0;
            // 
            // drTextBox4
            // 
            this.drTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CPF", true));
            this.drTextBox4.Label.Caption = "CPF";
            this.drTextBox4.Label.Visible = false;
            this.drTextBox4.Label.Width = 27;
            this.drTextBox4.Location = new System.Drawing.Point(15, 25);
            this.drTextBox4.Name = "drTextBox4";
            this.drTextBox4.Size = new System.Drawing.Size(98, 20);
            this.drTextBox4.TabIndex = 0;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Nome", true));
            this.drTextBox2.Label.Caption = "Nome";
            this.drTextBox2.Label.Required = true;
            this.drTextBox2.Label.Visible = false;
            this.drTextBox2.Label.Width = 39;
            this.drTextBox2.Location = new System.Drawing.Point(121, 22);
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(580, 20);
            this.drTextBox2.TabIndex = 1;
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CodInvestidor", true));
            this.drTextBox1.Label.Caption = "Código Investidor";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Visible = false;
            this.drTextBox1.Label.Width = 106;
            this.drTextBox1.Location = new System.Drawing.Point(16, 22);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(74, 20);
            this.drTextBox1.TabIndex = 0;
            // 
            // dsInvestidor1
            // 
            this.dsInvestidor1.DataSetName = "DSInvestidor";
            this.dsInvestidor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cDataNasc);
            this.groupBox3.Controls.Add(this.drTextBox6);
            this.groupBox3.Controls.Add(this.drTextBox16);
            this.groupBox3.Controls.Add(this.drTextBox15);
            this.groupBox3.Controls.Add(this.drTextBox4);
            this.groupBox3.Controls.Add(this.drTextBox14);
            this.groupBox3.Location = new System.Drawing.Point(16, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 55);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // cDataNasc
            // 
            this.cDataNasc.Label.Caption = "Data Pagamento";
            this.cDataNasc.Label.Visible = false;
            this.cDataNasc.Label.Width = 87;
            this.cDataNasc.Location = new System.Drawing.Point(223, 25);
            // 
            // 
            // 
            this.cDataNasc.MaskTextBox.AllowPromptAsInput = false;
            this.cDataNasc.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.cDataNasc.MaskTextBox.Mask = "00/00/0000";
            this.cDataNasc.MaskTextBox.Name = "DRDATA";
            this.cDataNasc.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.cDataNasc.MaskTextBox.TabIndex = 49;
            this.cDataNasc.MaskTextBox.Text = "  /  /";
            this.cDataNasc.MaskTextBox.Validated += new System.EventHandler(this.drDateTextBox1_MaskTextBox_Validated);
            this.cDataNasc.Name = "cDataNasc";
            this.cDataNasc.Size = new System.Drawing.Size(100, 20);
            this.cDataNasc.TabIndex = 2;
            // 
            // drTextBox6
            // 
            this.drTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "RG", true));
            this.drTextBox6.Label.Caption = "RG";
            this.drTextBox6.Label.Visible = false;
            this.drTextBox6.Label.Width = 23;
            this.drTextBox6.Location = new System.Drawing.Point(119, 25);
            this.drTextBox6.Name = "drTextBox6";
            this.drTextBox6.Size = new System.Drawing.Size(98, 20);
            this.drTextBox6.TabIndex = 1;
            // 
            // drTextBox16
            // 
            this.drTextBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Fax", true));
            this.drTextBox16.Label.Caption = "Fax";
            this.drTextBox16.Label.Visible = false;
            this.drTextBox16.Label.Width = 24;
            this.drTextBox16.Location = new System.Drawing.Point(559, 25);
            this.drTextBox16.Name = "drTextBox16";
            this.drTextBox16.Size = new System.Drawing.Size(100, 20);
            this.drTextBox16.TabIndex = 5;
            // 
            // drTextBox15
            // 
            this.drTextBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Celular", true));
            this.drTextBox15.Label.Caption = "Celular";
            this.drTextBox15.Label.Visible = false;
            this.drTextBox15.Label.Width = 39;
            this.drTextBox15.Location = new System.Drawing.Point(435, 25);
            this.drTextBox15.Name = "drTextBox15";
            this.drTextBox15.Size = new System.Drawing.Size(117, 20);
            this.drTextBox15.TabIndex = 4;
            // 
            // drTextBox14
            // 
            this.drTextBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Telefone", true));
            this.drTextBox14.Label.Caption = "Telefone";
            this.drTextBox14.Label.Visible = false;
            this.drTextBox14.Label.Width = 49;
            this.drTextBox14.Location = new System.Drawing.Point(329, 25);
            this.drTextBox14.Name = "drTextBox14";
            this.drTextBox14.Size = new System.Drawing.Size(100, 20);
            this.drTextBox14.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.DGObraRelacionada);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 384);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Obras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbValorCota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cFracao);
            this.groupBox1.Controls.Add(this.btnCancela);
            this.groupBox1.Controls.Add(this.cPercenteAdquirido);
            this.groupBox1.Controls.Add(this.drConsultaCota);
            this.groupBox1.Controls.Add(this.drConsultaObra);
            this.groupBox1.Controls.Add(this.cApartamento);
            this.groupBox1.Controls.Add(this.cValorInvet);
            this.groupBox1.Controls.Add(this.btnRelacObra);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbValorCota
            // 
            this.lbValorCota.AutoSize = true;
            this.lbValorCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorCota.ForeColor = System.Drawing.Color.Blue;
            this.lbValorCota.Location = new System.Drawing.Point(609, 72);
            this.lbValorCota.Name = "lbValorCota";
            this.lbValorCota.Size = new System.Drawing.Size(15, 13);
            this.lbValorCota.TabIndex = 3;
            this.lbValorCota.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Total da Cota:";
            // 
            // button1
            // 
            this.button1.Image = global::DRProjetoCadastro.Form.Properties.Resources.calculator;
            this.button1.Location = new System.Drawing.Point(206, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Calcula o valor previsto conforme o percentual e valor total da Cota. ");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cFracao
            // 
            this.cFracao.Label.Caption = "Fração do Lote";
            this.cFracao.Label.Required = true;
            this.cFracao.Label.Width = 93;
            this.cFracao.Location = new System.Drawing.Point(251, 105);
            this.cFracao.Name = "cFracao";
            this.cFracao.Size = new System.Drawing.Size(85, 20);
            this.cFracao.TabIndex = 7;
            // 
            // btnCancela
            // 
            this.btnCancela.Enabled = false;
            this.btnCancela.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancela.Location = new System.Drawing.Point(624, 103);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(81, 23);
            this.btnCancela.TabIndex = 10;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cPercenteAdquirido
            // 
            this.cPercenteAdquirido.Label.Caption = "%";
            this.cPercenteAdquirido.Label.Required = true;
            this.cPercenteAdquirido.Label.Width = 16;
            this.cPercenteAdquirido.Location = new System.Drawing.Point(136, 105);
            this.cPercenteAdquirido.Name = "cPercenteAdquirido";
            this.cPercenteAdquirido.Size = new System.Drawing.Size(64, 20);
            this.cPercenteAdquirido.TabIndex = 5;
            // 
            // drConsultaObra
            // 
            this.drConsultaObra.CampoForenKey = "CODIGOPRJ";
            this.drConsultaObra.CamposConsultados = "CODIGOPRJ;NOME";
            this.drConsultaObra.ConsultaAtiva = true;
            this.drConsultaObra.DescricaoCampos = "Cód. Projeto;Nome";
            this.drConsultaObra.Filtro = "";
            this.drConsultaObra.Label.Caption = "Selecione a Obra";
            this.drConsultaObra.Label.Required = true;
            this.drConsultaObra.Label.Width = 105;
            this.drConsultaObra.Location = new System.Drawing.Point(16, 25);
            this.drConsultaObra.Name = "drConsultaObra";
            this.drConsultaObra.NomeCampoConsulta = "CODIGOPRJ";
            this.drConsultaObra.NomeCampoDescricao = "NOME";
            this.drConsultaObra.NomeTabela = "DRPROJETO";
            this.drConsultaObra.Size = new System.Drawing.Size(663, 22);
            this.drConsultaObra.TabIndex = 0;
            this.drConsultaObra.TamanhoCampoConsulta = 67;
            this.drConsultaObra.AfterConsulta += new DR.Lib.Winform.DRConsulta.AfterConsultaEventHandler(this.drConsultaObra_AfterConsulta);
            // 
            // cApartamento
            // 
            this.cApartamento.Label.Caption = "Apartamento";
            this.cApartamento.Label.Required = true;
            this.cApartamento.Label.Width = 78;
            this.cApartamento.Location = new System.Drawing.Point(16, 105);
            this.cApartamento.Name = "cApartamento";
            this.cApartamento.Size = new System.Drawing.Size(114, 20);
            this.cApartamento.TabIndex = 4;
            // 
            // cValorInvet
            // 
            this.cValorInvet.FormatoMoeda = true;
            this.cValorInvet.Label.Caption = "Investimento Previsto ";
            this.cValorInvet.Label.Required = true;
            this.cValorInvet.Label.Width = 133;
            this.cValorInvet.Location = new System.Drawing.Point(351, 103);
            this.cValorInvet.Name = "cValorInvet";
            this.cValorInvet.Size = new System.Drawing.Size(118, 20);
            this.cValorInvet.TabIndex = 8;
            // 
            // btnRelacObra
            // 
            this.btnRelacObra.Location = new System.Drawing.Point(492, 103);
            this.btnRelacObra.Name = "btnRelacObra";
            this.btnRelacObra.Size = new System.Drawing.Size(126, 23);
            this.btnRelacObra.TabIndex = 9;
            this.btnRelacObra.Text = "Relacionar Nova Obra";
            this.btnRelacObra.UseVisualStyleBackColor = true;
            this.btnRelacObra.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGObraRelacionada
            // 
            this.DGObraRelacionada.Dock = System.Windows.Forms.DockStyle.Bottom;
            // 
            // 
            // 
            this.DGObraRelacionada.DRGrid.AllowUserToAddRows = false;
            this.DGObraRelacionada.DRGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DGObraRelacionada.DRGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGObraRelacionada.DRGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGObraRelacionada.DRGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGObraRelacionada.DRGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGObraRelacionada.DRGrid.Location = new System.Drawing.Point(0, 0);
            this.DGObraRelacionada.DRGrid.MultiSelect = false;
            this.DGObraRelacionada.DRGrid.Name = "DG";
            this.DGObraRelacionada.DRGrid.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DGObraRelacionada.DRGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGObraRelacionada.DRGrid.RowTemplate.Height = 18;
            this.DGObraRelacionada.DRGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGObraRelacionada.DRGrid.Size = new System.Drawing.Size(796, 216);
            this.DGObraRelacionada.DRGrid.TabIndex = 36;
            this.DGObraRelacionada.DRGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGObraRelacionada_DRGrid_CellClick);
            this.DGObraRelacionada.DRGrid.DoubleClick += new System.EventHandler(this.BnOk_Click);
            this.DGObraRelacionada.Location = new System.Drawing.Point(3, 165);
            this.DGObraRelacionada.Name = "DGObraRelacionada";
            this.DGObraRelacionada.Size = new System.Drawing.Size(796, 216);
            this.DGObraRelacionada.TabIndex = 47;
            // 
            // drTextBox18
            // 
            this.drTextBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Obs", true));
            this.drTextBox18.Label.Caption = "Observação";
            this.drTextBox18.Label.Visible = false;
            this.drTextBox18.Label.Width = 65;
            this.drTextBox18.Location = new System.Drawing.Point(16, 300);
            this.drTextBox18.Multiline = true;
            this.drTextBox18.Name = "drTextBox18";
            this.drTextBox18.Size = new System.Drawing.Size(378, 73);
            this.drTextBox18.TabIndex = 0;
            // 
            // DRCadInvestidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 481);
            this.MaximizeBox = false;
            this.Name = "DRCadInvestidor";
            this.Tag = "8";
            this.Text = "DRCadInvestidor";
            this.Load += new System.EventHandler(this.DRCadInvestidor_Load);
            this.Shown += new System.EventHandler(this.DRCadInvestidor_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvestidor1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGObraRelacionada.DRGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsObraRelacionada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DR.Lib.Winform.DRTextBox drTextBox11;
        private DRProjetoCadastro.BLL.DSInvestidor dsInvestidor1;
        private DR.Lib.Winform.DRTextBox drTextBox8;
        private DR.Lib.Winform.DRTextBox drTextBox7;
        private DR.Lib.Winform.DRTextBox drTextBox9;
        private DR.Lib.Winform.DRTextBox drTextBox10;
        private DR.Lib.Winform.DRTextBox drTextBox12;
        private DR.Lib.Winform.DRTextBox drTextBox13;
        private DR.Lib.Winform.DRTextBox drTextBox5;
        private DR.Lib.Winform.DRTextBox drTextBox4;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private DR.Lib.Winform.DRTextBox drTextBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DR.Lib.Winform.DRTextBox drTextBox16;
        private DR.Lib.Winform.DRTextBox drTextBox15;
        private DR.Lib.Winform.DRTextBox drTextBox14;
        private DR.Lib.Winform.DRTextBox drTextBox6;
        private DR.Lib.Winform.DRDateTextBox cDataNasc;
        private DR.Lib.Winform.DRTextBox drTextBox18;
        private System.Windows.Forms.Button btnRelacObra;
        private DR.Lib.Winform.DRConsulta drConsultaObra;
        private DR.Lib.Winform.DRDataGridView DGObraRelacionada;
        private DR.Lib.Winform.DRBindingSource BsObraRelacionada;
        private DR.Lib.Winform.DRTextBox cValorInvet;
        private System.Windows.Forms.GroupBox groupBox1;
        private DR.Lib.Winform.DRTextBox cApartamento;
        private System.Windows.Forms.Button btnCancela;
        private DR.Lib.Winform.DRTextBox cPercenteAdquirido;
        private DR.Lib.Winform.DRTextBox cFracao;
        private DR.Lib.Winform.DRConsulta drConsultaCota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbValorCota;
        private System.Windows.Forms.Label label1;
    }
}