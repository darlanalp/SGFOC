namespace DRGlobal.Form
{
    partial class DRCadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DRCadUser));
            this.drTextBox1 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox2 = new DR.Lib.Winform.DRTextBox();
            this.drTextBox3 = new DR.Lib.Winform.DRTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cSuperVisor = new System.Windows.Forms.CheckBox();
            this.dsUser1 = new DRGlobal.BLL.DSUser();
            this.tabPermissao = new System.Windows.Forms.TabPage();
            this.tvMenus = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BsPermissao = new DR.Lib.Winform.DRBindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUser1)).BeginInit();
            this.tabPermissao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsPermissao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPermissao);
            this.tabControl1.Size = new System.Drawing.Size(662, 339);
            this.tabControl1.Controls.SetChildIndex(this.tabPermissao, 0);
            this.tabControl1.Controls.SetChildIndex(this.tab1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Size = new System.Drawing.Size(662, 44);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.groupBox1);
            this.tab1.Controls.Add(this.drTextBox1);
            this.tab1.Size = new System.Drawing.Size(654, 313);
            // 
            // BsDialog
            // 
            this.BsDialog.DataMember = "DRUsuario";
            this.BsDialog.DataSource = this.dsUser1;
            this.BsDialog.CurrentItemChanged += new System.EventHandler(this.BsDialog_CurrentItemChanged);
            // 
            // drTextBox1
            // 
            this.drTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "Nome", true));
            this.drTextBox1.Label.Caption = "Nome";
            this.drTextBox1.Label.Required = true;
            this.drTextBox1.Label.Visible= true;;
            this.drTextBox1.Label.Width = 39;
            this.drTextBox1.Location = new System.Drawing.Point(25, 29);
            this.drTextBox1.MaxLength = 50;
            this.drTextBox1.Name = "drTextBox1";
            this.drTextBox1.Size = new System.Drawing.Size(400, 20);
            this.drTextBox1.TabIndex = 0;
            // 
            // drTextBox2
            // 
            this.drTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "usuario", true));
            this.drTextBox2.Label.Caption = "Usuário";
            this.drTextBox2.Label.Required = true;
            this.drTextBox2.Label.Visible= true;;
            this.drTextBox2.Label.Width = 50;
            this.drTextBox2.Location = new System.Drawing.Point(17, 32);
            this.drTextBox2.MaxLength = 10;
            this.drTextBox2.Name = "drTextBox2";
            this.drTextBox2.Size = new System.Drawing.Size(100, 20);
            this.drTextBox2.TabIndex = 2;
            // 
            // drTextBox3
            // 
            this.drTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsDialog, "senha", true));
            this.drTextBox3.Label.Caption = "Senha";
            this.drTextBox3.Label.Required = true;
            this.drTextBox3.Label.Visible= true;;
            this.drTextBox3.Label.Width = 43;
            this.drTextBox3.Location = new System.Drawing.Point(138, 32);
            this.drTextBox3.MaxLength = 10;
            this.drTextBox3.Name = "drTextBox3";
            this.drTextBox3.PasswordChar = '*';
            this.drTextBox3.Size = new System.Drawing.Size(100, 20);
            this.drTextBox3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cSuperVisor);
            this.groupBox1.Controls.Add(this.drTextBox2);
            this.groupBox1.Controls.Add(this.drTextBox3);
            this.groupBox1.Location = new System.Drawing.Point(25, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cSuperVisor
            // 
            this.cSuperVisor.AutoSize = true;
            this.cSuperVisor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BsDialog, "usuariosupervisor", true));
            this.cSuperVisor.Location = new System.Drawing.Point(254, 35);
            this.cSuperVisor.Name = "cSuperVisor";
            this.cSuperVisor.Size = new System.Drawing.Size(115, 17);
            this.cSuperVisor.TabIndex = 6;
            this.cSuperVisor.Text = "Usuário Supervisor";
            this.cSuperVisor.UseVisualStyleBackColor = true;
            // 
            // dsUser1
            // 
            this.dsUser1.DataSetName = "DSUser";
            this.dsUser1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPermissao
            // 
            this.tabPermissao.Controls.Add(this.tvMenus);
            this.tabPermissao.Controls.Add(this.panel2);
            this.tabPermissao.Location = new System.Drawing.Point(4, 22);
            this.tabPermissao.Name = "tabPermissao";
            this.tabPermissao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPermissao.Size = new System.Drawing.Size(654, 313);
            this.tabPermissao.TabIndex = 1;
            this.tabPermissao.Text = "Permissões";
            this.tabPermissao.UseVisualStyleBackColor = true;
            // 
            // tvMenus
            // 
            this.tvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenus.ImageIndex = 0;
            this.tvMenus.ImageList = this.imageList1;
            this.tvMenus.Location = new System.Drawing.Point(3, 45);
            this.tvMenus.Name = "tvMenus";
            this.tvMenus.SelectedImageIndex = 0;
            this.tvMenus.Size = new System.Drawing.Size(648, 265);
            this.tvMenus.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Permitido.png");
            this.imageList1.Images.SetKeyName(1, "SemPermissao.png");
            this.imageList1.Images.SetKeyName(2, "Sem Seguranca.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 42);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Expandir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(142, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Negar Acesso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Permitir Acesso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DRCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 410);
            this.DesativaSeguranca = true;
            this.Name = "DRCadUser";
            this.Tag = "800002";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DRCadUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsDialog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUser1)).EndInit();
            this.tabPermissao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BsPermissao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DR.Lib.Winform.DRTextBox drTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DR.Lib.Winform.DRTextBox drTextBox3;
        private DR.Lib.Winform.DRTextBox drTextBox2;
        private System.Windows.Forms.CheckBox cSuperVisor;
        private DRGlobal.BLL.DSUser dsUser1;
        private System.Windows.Forms.TabPage tabPermissao;
        private System.Windows.Forms.TreeView tvMenus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DR.Lib.Winform.DRBindingSource BsPermissao;
        private System.Windows.Forms.Button button3;
    }
}