namespace DRProjetoCadastro.Form
{
    partial class DRCadAtividade
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
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.dsCadastro1 = new DRProjetoCadastro.BLL.DSCadastro();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.drDateTextBox2 = new DR.Lib.Winform.DRDateTextBox();
            this.drDateTextBox1 = new DR.Lib.Winform.DRDateTextBox();
            this.cPercentual = new DR.Lib.Winform.DRTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.drConsultaEtapa = new DR.Lib.Winform.DRConsulta();
            this.cCodigo = new DR.Lib.Winform.DRTextBox();
            this.drTextBox4 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox5 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox6 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox7 = new DR.Lib.Winform.DRTextBox();
            this.cTotal = new DR.Lib.Winform.DRTextBox();
            this.cTotalGeral = new DR.Lib.Winform.DRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(659, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 413);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.drTextBox2);
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.cCodigo);
            this.tab1.Controls.Add(this.drConsultaEtapa);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Controls.Add(this.groupBox3);
            this.tab1.Size = new System.Drawing.Size(651, 360);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRAtividade";
            this.BsDialog.DataSource = this.dsCadastro1;
            this.BsDialog.PositionChanged += new System.EventHandler(this.BsDialog_PositionChanged);
            this.BsDialog.CurrentItemChanged += new System.EventHandler(this.BsDialog_CurrentItemChanged);
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Descricao", true));
            this.drTextBox1.Label.Caption = "Atividade";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Width = 60;
            this.drTextBox1.Location = new System.Drawing.Point(106, 69);
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(505, 20);
            this.drTextBox1.TabIndex = 2;
            // 
            // dsCadastro1
            // 
            this.dsCadastro1.DataSetName = "DSCadastro";
            this.dsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.drDateTextBox2);
            this.groupBox3.Controls.Add(this.drDateTextBox1);
            this.groupBox3.Controls.Add(this.cPercentual);
            this.groupBox3.Controls.Add(this.cbStatus);
            this.groupBox3.Controls.Add(this.lStatus);
            this.groupBox3.Location = new System.Drawing.Point(221, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // drDateTextBox2
            // 
            this.drDateTextBox2.Label.Caption = "Data Previsão Término";
            this.drDateTextBox2.Label.Width = 115;
            this.drDateTextBox2.Location = new System.Drawing.Point(122, 32);
            // 
            // 
            // 
            this.drDateTextBox2.MaskTextBox.AllowPromptAsInput = false;
            this.drDateTextBox2.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.drDateTextBox2.MaskTextBox.Mask = "00/00/0000";
            this.drDateTextBox2.MaskTextBox.Name = "DRDATA";
            this.drDateTextBox2.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.drDateTextBox2.MaskTextBox.TabIndex = 49;
            this.drDateTextBox2.MaskTextBox.Text = "  /  /";
            this.drDateTextBox2.MaskTextBox.ValidatingType = typeof(System.DateTime);
            this.drDateTextBox2.MaskTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.drDateTextBox2_MaskTextBox_Validating);
            this.drDateTextBox2.Name = "drDateTextBox2";
            this.drDateTextBox2.Size = new System.Drawing.Size(100, 20);
            this.drDateTextBox2.TabIndex = 1;
            // 
            // drDateTextBox1
            // 
            this.drDateTextBox1.Label.Caption = "Data Inicio";
            this.drDateTextBox1.Label.Width = 58;
            this.drDateTextBox1.Location = new System.Drawing.Point(16, 32);
            // 
            // 
            // 
            this.drDateTextBox1.MaskTextBox.AllowPromptAsInput = false;
            this.drDateTextBox1.MaskTextBox.Location = new System.Drawing.Point(0, 0);
            this.drDateTextBox1.MaskTextBox.Mask = "99/99/9999";
            this.drDateTextBox1.MaskTextBox.Name = "DRDATA";
            this.drDateTextBox1.MaskTextBox.Size = new System.Drawing.Size(69, 20);
            this.drDateTextBox1.MaskTextBox.TabIndex = 49;
            this.drDateTextBox1.MaskTextBox.Text = "  /  /";
            this.drDateTextBox1.MaskTextBox.ValidatingType = typeof(System.DateTime);
            this.drDateTextBox1.MaskTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.drDateTextBox1_MaskTextBox_Validating);
            this.drDateTextBox1.Name = "drDateTextBox1";
            this.drDateTextBox1.Size = new System.Drawing.Size(100, 20);
            this.drDateTextBox1.TabIndex = 0;
            // 
            // cPercentual
            // 
            this.cPercentual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "PercentualCompletude", true));
            this.cPercentual.Label.Caption = "Percentual de Completude";
            this.cPercentual.Label.Width = 132;
            this.cPercentual.Location = new System.Drawing.Point(248, 32);
            this.cPercentual.Name = "cPercentual";
            this.cPercentual.Size = new System.Drawing.Size(86, 20);
            this.cPercentual.TabIndex = 2;
            this.cPercentual.Validated += new System.EventHandler(this.cPercentual_Validated);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Andamento",
            "Concluída"});
            this.cbStatus.Location = new System.Drawing.Point(16, 74);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(335, 21);
            this.cbStatus.TabIndex = 4;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(13, 58);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(37, 13);
            this.lStatus.TabIndex = 3;
            this.lStatus.Text = "Status";
            // 
            // drConsultaEtapa
            // 
            this.drConsultaEtapa.CampoForenKey = "CodEtapa";
            this.drConsultaEtapa.CamposConsultados = "CodigoPrj;CodEtapa;Descricao ";
            this.drConsultaEtapa.ConsultaAtiva = false;
            this.drConsultaEtapa.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BsDialog, "CodEtapa", true));
            this.drConsultaEtapa.DescricaoCampos = "Código Projeto;Código Etapa;Descrição";
            this.drConsultaEtapa.Enabled = false;
            this.drConsultaEtapa.Filtro = "";
            this.drConsultaEtapa.Label.Caption = "Etapa";
            this.drConsultaEtapa.Label.Required = true;
            this.drConsultaEtapa.Label.Width = 40;
            this.drConsultaEtapa.Location = new System.Drawing.Point(16, 26);
            this.drConsultaEtapa.Name = "drConsultaEtapa";
            this.drConsultaEtapa.NomeCampoConsulta = "CodEtapa";
            this.drConsultaEtapa.NomeCampoDescricao = "Descricao";
            this.drConsultaEtapa.NomeTabela = "DRETAPA";
            this.drConsultaEtapa.Size = new System.Drawing.Size(595, 22);
            this.drConsultaEtapa.TabIndex = 0;
            this.drConsultaEtapa.TamanhoCampoConsulta = 67;
            // 
            // cCodigo
            // 
            this.cCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "CodAtividade", true));
            this.cCodigo.Label.Caption = "Código";
            this.cCodigo.Label.Required = true;
            this.cCodigo.Label.Width = 46;
            this.cCodigo.Location = new System.Drawing.Point(16, 69);
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.Size = new System.Drawing.Size(84, 20);
            this.cCodigo.TabIndex = 1;
            // 
            // drTextBox4
            // 
            this.drTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Unidade", true));
            this.drTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drTextBox4.Label.Caption = "Unidade";
            this.drTextBox4.Label.Width = 47;
            this.drTextBox4.Location = new System.Drawing.Point(13, 38);
            this.drTextBox4.Name = "drTextBox4";
            this.drTextBox4.Size = new System.Drawing.Size(50, 20);
            this.drTextBox4.TabIndex = 0;
            // 
            // drTextBox5
            // 
            this.drTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Qtd", true));
            this.drTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drTextBox5.Label.Caption = "Quantidade";
            this.drTextBox5.Label.Width = 62;
            this.drTextBox5.Location = new System.Drawing.Point(69, 38);
            this.drTextBox5.Name = "drTextBox5";
            this.drTextBox5.Size = new System.Drawing.Size(100, 20);
            this.drTextBox5.TabIndex = 1;
            this.drTextBox5.Validated += new System.EventHandler(this.drTextBox5_Validated);
            // 
            // drTextBox6
            // 
            this.drTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "PrecoUnitarioMaterial", true));
            this.drTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drTextBox6.FormatoMoeda = true;
            this.drTextBox6.Label.Caption = "Preço Unitário Material";
            this.drTextBox6.Label.Width = 114;
            this.drTextBox6.Location = new System.Drawing.Point(13, 80);
            this.drTextBox6.Name = "drTextBox6";
            this.drTextBox6.Size = new System.Drawing.Size(156, 20);
            this.drTextBox6.TabIndex = 2;
            this.drTextBox6.Validated += new System.EventHandler(this.drTextBox6_Validated);
            // 
            // drTextBox7
            // 
            this.drTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "PrecoUnitarioMaoObra", true));
            this.drTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drTextBox7.FormatoMoeda = true;
            this.drTextBox7.Label.Caption = "Preço Unitário Mão de Obra";
            this.drTextBox7.Label.Width = 139;
            this.drTextBox7.Location = new System.Drawing.Point(13, 121);
            this.drTextBox7.Name = "drTextBox7";
            this.drTextBox7.Size = new System.Drawing.Size(156, 20);
            this.drTextBox7.TabIndex = 3;
            this.drTextBox7.Validated += new System.EventHandler(this.drTextBox7_Validated);
            // 
            // cTotal
            // 
            this.cTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Total", true));
            this.cTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTotal.Label.Caption = "Total ";
            this.cTotal.Label.Width = 34;
            this.cTotal.Location = new System.Drawing.Point(13, 158);
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            this.cTotal.Size = new System.Drawing.Size(156, 20);
            this.cTotal.TabIndex = 4;
            // 
            // cTotalGeral
            // 
            this.cTotalGeral.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "TotalGeral", true));
            this.cTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTotalGeral.Label.Caption = "Valor Total Previsto";
            this.cTotalGeral.Label.Width = 99;
            this.cTotalGeral.Location = new System.Drawing.Point(13, 201);
            this.cTotalGeral.Name = "cTotalGeral";
            this.cTotalGeral.ReadOnly = true;
            this.cTotalGeral.Size = new System.Drawing.Size(156, 20);
            this.cTotalGeral.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drTextBox5);
            this.groupBox1.Controls.Add(this.drTextBox4);
            this.groupBox1.Controls.Add(this.drTextBox7);
            this.groupBox1.Controls.Add(this.cTotal);
            this.groupBox1.Controls.Add(this.cTotalGeral);
            this.groupBox1.Controls.Add(this.drTextBox6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores Previsto";
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Observacao", true));
            this.drTextBox2.Label.Caption = "Observação";
            this.drTextBox2.Label.Width = 65;
            this.drTextBox2.Location = new System.Drawing.Point(221, 219);
            this.drTextBox2.Multiline = true;
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(390, 129);
            this.drTextBox2.TabIndex = 5;
            // 
            // DRCadAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 457);
            this.Name = "DRCadAtividade";
            this.Tag = "7";
            this.Text = "DRCadAtividade";
            this.Load += new System.EventHandler(this.DRCadAtividade_Load);
            this.Shown += new System.EventHandler(this.DRCadAtividade_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DR.Lib.Winform.DRTextBox drTextBox1;
        private DRProjetoCadastro.BLL.DSCadastro dsCadastro1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private DR.Lib.Winform.DRTextBox drTextBox7;
        private DR.Lib.Winform.DRTextBox drTextBox6;
        private DR.Lib.Winform.DRTextBox drTextBox5;
        private DR.Lib.Winform.DRTextBox drTextBox4;
        private DR.Lib.Winform.DRTextBox cCodigo;
        private DR.Lib.Winform.DRConsulta drConsultaEtapa;
        private DR.Lib.Winform.DRTextBox cTotalGeral;
        private DR.Lib.Winform.DRTextBox cTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private DR.Lib.Winform.DRTextBox cPercentual;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private DR.Lib.Winform.DRDateTextBox drDateTextBox1;
        private DR.Lib.Winform.DRDateTextBox drDateTextBox2;
    }
}