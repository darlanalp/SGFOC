namespace DRProjetoCadastro.Form
{
    partial class DRSelectProjeto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DRSelectProjeto));
            this.dsCadastro1 = new DRProjetoCadastro.BLL.DSCadastro();
            this.codigoPrjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drDataGridView1 = new DR.Lib.Winform.DRDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckAtiva = new System.Windows.Forms.CheckBox();
            this.BnOk = new Glass.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView1.DRGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drBS
            // 
            this.drBS.DataMember = "DRProjetoSelect";
            this.drBS.DataSource = this.dsCadastro1;
            this.drBS.PositionChanged += new System.EventHandler(this.drBS_PositionChanged);
            // 
            // dsCadastro1
            // 
            this.dsCadastro1.DataSetName = "DSCadastro";
            this.dsCadastro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codigoPrjDataGridViewTextBoxColumn
            // 
            this.codigoPrjDataGridViewTextBoxColumn.DataPropertyName = "CodigoPrj";
            this.codigoPrjDataGridViewTextBoxColumn.HeaderText = "CodigoPrj";
            this.codigoPrjDataGridViewTextBoxColumn.Name = "codigoPrjDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // dataFinDataGridViewTextBoxColumn
            // 
            this.dataFinDataGridViewTextBoxColumn.DataPropertyName = "DataFin";
            this.dataFinDataGridViewTextBoxColumn.HeaderText = "DataFin";
            this.dataFinDataGridViewTextBoxColumn.Name = "dataFinDataGridViewTextBoxColumn";
            // 
            // drDataGridView1
            // 
            this.drDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.drDataGridView1.DRGrid.AllowUserToAddRows = false;
            this.drDataGridView1.DRGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.drDataGridView1.DRGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.drDataGridView1.DRGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.drDataGridView1.DRGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drDataGridView1.DRGrid.DataSource = this.drBS;
            this.drDataGridView1.DRGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drDataGridView1.DRGrid.Location = new System.Drawing.Point(0, 0);
            this.drDataGridView1.DRGrid.MultiSelect = false;
            this.drDataGridView1.DRGrid.Name = "DG";
            this.drDataGridView1.DRGrid.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.drDataGridView1.DRGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.drDataGridView1.DRGrid.RowTemplate.Height = 18;
            this.drDataGridView1.DRGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drDataGridView1.DRGrid.Size = new System.Drawing.Size(547, 262);
            this.drDataGridView1.DRGrid.TabIndex = 36;
            this.drDataGridView1.DRGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drDataGridView1_DRGrid_CellDoubleClick);
            this.drDataGridView1.DRGrid.DoubleClick += new System.EventHandler(this.BnOk_Click);
            this.drDataGridView1.DRGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drDataGridView1_DRGrid_KeyPress);
            this.drDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.drDataGridView1.Name = "drDataGridView1";
            this.drDataGridView1.Size = new System.Drawing.Size(547, 262);
            this.drDataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckAtiva);
            this.panel1.Controls.Add(this.BnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 49);
            this.panel1.TabIndex = 1;
            // 
            // ckAtiva
            // 
            this.ckAtiva.AutoSize = true;
            this.ckAtiva.Location = new System.Drawing.Point(111, 19);
            this.ckAtiva.Name = "ckAtiva";
            this.ckAtiva.Size = new System.Drawing.Size(190, 17);
            this.ckAtiva.TabIndex = 11;
            this.ckAtiva.Text = "Sempre logar na obra selecionada.";
            this.ckAtiva.UseVisualStyleBackColor = true;
            // 
            // BnOk
            // 
            this.BnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BnOk.Image = ((System.Drawing.Image)(resources.GetObject("BnOk.Image")));
            this.BnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BnOk.Location = new System.Drawing.Point(12, 5);
            this.BnOk.Name = "BnOk";
            this.BnOk.Size = new System.Drawing.Size(92, 32);
            this.BnOk.TabIndex = 10;
            this.BnOk.Text = "Ok";
            this.BnOk.Click += new System.EventHandler(this.BnOk_Click);
            // 
            // DRSelectProjeto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(547, 262);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drDataGridView1);
            this.MaximizeBox = false;
            this.Name = "DRSelectProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRSelectProjeto";
            this.Load += new System.EventHandler(this.DRSelectProjeto_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DRSelectProjeto_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.drBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCadastro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drDataGridView1.DRGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DRProjetoCadastro.BLL.DSCadastro dsCadastro1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPrjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinDataGridViewTextBoxColumn;
        private DR.Lib.Winform.DRDataGridView drDataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Glass.GlassButton BnOk;
        private System.Windows.Forms.CheckBox ckAtiva;
    }
}