namespace DRRelatorios.Rel
{
    partial class DRSelecAtividade_Etapa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabInformacao = new System.Windows.Forms.TabControl();
            this.tabEtapa = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgEtapa = new DR.Lib.Winform.DRDataGridView();
            this.dsSelect = new System.Data.DataSet();
            this.TblEtapa = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.TblAtividade = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.drConsultaEtapa = new DR.Lib.Winform.DRConsulta();
            this.tabAtividade = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgAtividade = new DR.Lib.Winform.DRDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.drConsultaAtividade = new DR.Lib.Winform.DRConsulta();
            this.tabInformacao.SuspendLayout();
            this.tabEtapa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEtapa.DRGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblEtapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblAtividade)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabAtividade.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtividade.DRGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInformacao
            // 
            this.tabInformacao.Controls.Add(this.tabEtapa);
            this.tabInformacao.Controls.Add(this.tabAtividade);
            this.tabInformacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInformacao.Location = new System.Drawing.Point(0, 0);
            this.tabInformacao.Name = "tabInformacao";
            this.tabInformacao.SelectedIndex = 0;
            this.tabInformacao.Size = new System.Drawing.Size(623, 150);
            this.tabInformacao.TabIndex = 50;
            // 
            // tabEtapa
            // 
            this.tabEtapa.Controls.Add(this.groupBox2);
            this.tabEtapa.Controls.Add(this.panel2);
            this.tabEtapa.Location = new System.Drawing.Point(4, 22);
            this.tabEtapa.Name = "tabEtapa";
            this.tabEtapa.Padding = new System.Windows.Forms.Padding(3);
            this.tabEtapa.Size = new System.Drawing.Size(615, 124);
            this.tabEtapa.TabIndex = 0;
            this.tabEtapa.Text = "Etapas Selecionadas";
            this.tabEtapa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgEtapa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etapas Selecionadas";
            // 
            // dgEtapa
            // 
            this.dgEtapa.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.dgEtapa.DRGrid.AllowUserToAddRows = false;
            this.dgEtapa.DRGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.dgEtapa.DRGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgEtapa.DRGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEtapa.DRGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgEtapa.DRGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEtapa.DRGrid.DataMember = "TblEtapa";
            this.dgEtapa.DRGrid.DataSource = this.dsSelect;
            this.dgEtapa.DRGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEtapa.DRGrid.Location = new System.Drawing.Point(0, 0);
            this.dgEtapa.DRGrid.MultiSelect = false;
            this.dgEtapa.DRGrid.Name = "DG";
            this.dgEtapa.DRGrid.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgEtapa.DRGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgEtapa.DRGrid.RowTemplate.Height = 18;
            this.dgEtapa.DRGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEtapa.DRGrid.Size = new System.Drawing.Size(603, 48);
            this.dgEtapa.DRGrid.TabIndex = 36;
            this.dgEtapa.DRGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEtapa_DRGrid_CellClick);
            this.dgEtapa.Location = new System.Drawing.Point(3, 16);
            this.dgEtapa.Name = "dgEtapa";
            this.dgEtapa.Size = new System.Drawing.Size(603, 48);
            this.dgEtapa.TabIndex = 0;
            // 
            // dsSelect
            // 
            this.dsSelect.DataSetName = "NewDataSet";
            this.dsSelect.Tables.AddRange(new System.Data.DataTable[] {
            this.TblEtapa,
            this.TblAtividade});
            // 
            // TblEtapa
            // 
            this.TblEtapa.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.TblEtapa.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CodEtapa"}, true)});
            this.TblEtapa.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.TblEtapa.TableName = "TblEtapa";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "CodEtapa";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Etapa";
            // 
            // TblAtividade
            // 
            this.TblAtividade.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4});
            this.TblAtividade.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "CodAtividade"}, true)});
            this.TblAtividade.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn3};
            this.TblAtividade.TableName = "TblAtividade";
            // 
            // dataColumn3
            // 
            this.dataColumn3.AllowDBNull = false;
            this.dataColumn3.ColumnName = "CodAtividade";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Atividade";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.drConsultaEtapa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 51);
            this.panel2.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(544, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Limpar ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Selecionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.drConsultaEtapa.Location = new System.Drawing.Point(10, 19);
            this.drConsultaEtapa.Name = "drConsultaEtapa";
            this.drConsultaEtapa.NomeCampoConsulta = "CodEtapa";
            this.drConsultaEtapa.NomeCampoDescricao = "Descricao";
            this.drConsultaEtapa.NomeTabela = "DRETAPA";
            this.drConsultaEtapa.Size = new System.Drawing.Size(463, 22);
            this.drConsultaEtapa.TabIndex = 0;
            this.drConsultaEtapa.TamanhoCampoConsulta = 67;
            // 
            // tabAtividade
            // 
            this.tabAtividade.Controls.Add(this.groupBox4);
            this.tabAtividade.Controls.Add(this.panel3);
            this.tabAtividade.Location = new System.Drawing.Point(4, 22);
            this.tabAtividade.Name = "tabAtividade";
            this.tabAtividade.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtividade.Size = new System.Drawing.Size(615, 124);
            this.tabAtividade.TabIndex = 1;
            this.tabAtividade.Text = "Atividades Selecionadas";
            this.tabAtividade.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgAtividade);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 67);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atividades Selecionadas";
            // 
            // dgAtividade
            // 
            this.dgAtividade.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.dgAtividade.DRGrid.AllowUserToAddRows = false;
            this.dgAtividade.DRGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            this.dgAtividade.DRGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgAtividade.DRGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAtividade.DRGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgAtividade.DRGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtividade.DRGrid.DataMember = "TblAtividade";
            this.dgAtividade.DRGrid.DataSource = this.dsSelect;
            this.dgAtividade.DRGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAtividade.DRGrid.Location = new System.Drawing.Point(0, 0);
            this.dgAtividade.DRGrid.MultiSelect = false;
            this.dgAtividade.DRGrid.Name = "DG";
            this.dgAtividade.DRGrid.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgAtividade.DRGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgAtividade.DRGrid.RowTemplate.Height = 18;
            this.dgAtividade.DRGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAtividade.DRGrid.Size = new System.Drawing.Size(603, 48);
            this.dgAtividade.DRGrid.TabIndex = 36;
            this.dgAtividade.DRGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGAtividade_DRGrid_CellClick);
            this.dgAtividade.Location = new System.Drawing.Point(3, 16);
            this.dgAtividade.Name = "dgAtividade";
            this.dgAtividade.Size = new System.Drawing.Size(603, 48);
            this.dgAtividade.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.drConsultaAtividade);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 51);
            this.panel3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(541, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 23);
            this.button5.TabIndex = 54;
            this.button5.Text = "Limpar ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(476, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Selecionar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.drConsultaAtividade.Location = new System.Drawing.Point(8, 20);
            this.drConsultaAtividade.Name = "drConsultaAtividade";
            this.drConsultaAtividade.NomeCampoConsulta = "CodAtividade";
            this.drConsultaAtividade.NomeCampoDescricao = "Descricao";
            this.drConsultaAtividade.NomeTabela = "DRATIVIDADE";
            this.drConsultaAtividade.Size = new System.Drawing.Size(462, 22);
            this.drConsultaAtividade.TabIndex = 0;
            this.drConsultaAtividade.TamanhoCampoConsulta = 67;
            // 
            // DRSelecAtividade_Etapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabInformacao);
            this.Name = "DRSelecAtividade_Etapa";
            this.Size = new System.Drawing.Size(623, 150);
            this.tabInformacao.ResumeLayout(false);
            this.tabEtapa.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEtapa.DRGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblEtapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblAtividade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabAtividade.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAtividade.DRGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInformacao;
        private System.Windows.Forms.TabPage tabEtapa;
        private System.Windows.Forms.GroupBox groupBox2;
        private DR.Lib.Winform.DRDataGridView dgEtapa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private DR.Lib.Winform.DRConsulta drConsultaEtapa;
        private System.Windows.Forms.TabPage tabAtividade;
        private System.Windows.Forms.GroupBox groupBox4;
        private DR.Lib.Winform.DRDataGridView dgAtividade;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private DR.Lib.Winform.DRConsulta drConsultaAtividade;
        private System.Data.DataSet dsSelect;
        private System.Data.DataTable TblEtapa;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable TblAtividade;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
    }
}
