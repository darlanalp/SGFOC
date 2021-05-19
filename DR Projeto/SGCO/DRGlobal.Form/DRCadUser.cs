using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;
using DRGlobal.BLL;
using DR.Utils;
using System.Collections;

namespace DRGlobal.Form
{
    public partial class DRCadUser : DRFormDialog
    {
        public DRCadUser()
        {
            InitializeComponent();
        }

        #region Controle de Permissão de Menus

        private void LoadSegurancaEspecifica(int idSeguranca, TreeNode nodePai) 
        {
            PolicyMaster seg = DRContex.Sistema.SegurancaCadastroUser.ListSeg.Find(x => x.Tag == idSeguranca);
          if (seg != null) 
          {
              foreach (Policy segItem in seg.SegurancaItem) 
              {
                  TreeNode node = new TreeNode(segItem.Caption);
                  node.ImageIndex = 1;
                  node.SelectedImageIndex = 1;
                  segItem.TagPai = idSeguranca;
                  node.Tag = segItem;
                  nodePai.Nodes.Add(node);

                  if (DRContex.Sistema.SegurancaCadastroUser.PermitidoAcesso(idSeguranca, segItem.Tag))
                  {
                      node.ImageIndex = 0;
                      node.SelectedImageIndex = 0;
                  }
              }
          }
        }
        private void LoadMenusFilho(ToolStripDropDownItem menuSistema, TreeNode nodePai)
        {
            foreach (ToolStripItem menu in menuSistema.DropDownItems)
            {
                if (!string.IsNullOrEmpty(menu.Text))
                {
                    TreeNode node = new TreeNode(menu.Text);
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    node.Tag = menu.Tag;

                    if (node.Tag == null || node.Tag == string.Empty)
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 2;
                    }
                    else
                    {
                        LoadSegurancaEspecifica(Convert.ToInt32(node.Tag), node);

                        if (DRContex.Sistema.SegurancaCadastroUser.PermitidoAcesso(Convert.ToInt32(node.Tag)))
                        {
                            node.ImageIndex = 0;
                            node.SelectedImageIndex = 0;
                        }
                                                       
                    }

                    nodePai.Nodes.Add(node);

                    if (menu is ToolStripDropDownItem)
                    {
                        ToolStripDropDownItem item = (System.Windows.Forms.ToolStripDropDownItem)(menu);
                        if (item != null)
                            LoadMenusFilho(item, node);
                    }
                }
            }
        }
        private void LoadMenus(MenuStrip menuSistema)
        {            
            tvMenus.Nodes.Clear();

            TreeNode nodeMaster = new TreeNode("Sistema - SGFOC");
            nodeMaster.ImageIndex = 2;
            nodeMaster.SelectedImageIndex = 2;
            tvMenus.Nodes.Add(nodeMaster);

            foreach (ToolStripItem menu in menuSistema.Items)
            {
                if (!string.IsNullOrEmpty(menu.Text))
                {
                    TreeNode node = new TreeNode(menu.Text);
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    node.Tag = menu.Tag;

                    if (node.Tag == null)
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 2;
                    }
                    else
                    {
                        LoadSegurancaEspecifica(Convert.ToInt32(node.Tag), node);

                        if(DRContex.Sistema.SegurancaCadastroUser.PermitidoAcesso(Convert.ToInt32(node.Tag)))
                        {
                            node.ImageIndex = 0;
                            node.SelectedImageIndex = 0;
                        }
                    }

                    nodeMaster.Nodes.Add(node);

                    LoadMenusFilho((System.Windows.Forms.ToolStripDropDownItem)(menu), node);
                }
            }

        }
        private void AddTagPai(int idSeguranca, string seguranca)
        {
            int ix = BsPermissao.Find("IDSEGURANCA", idSeguranca);
            if (ix != -1)
                BsPermissao.RemoveAt(ix);


            BsPermissao.AddNew();
            BsPermissao.Row["IDUSUARIO"] = this.BsDialog.Row["IDUsuario"];
            BsPermissao.Row["IDSEGURANCA"] = idSeguranca;
            BsPermissao.Row["SEGURANCA"] = seguranca.Trim();

            BsPermissao.EndEdit();
        }
        private string GetPermissao(string subTag, string permissaoAtual, bool adiciona)
        {
            subTag = subTag.Trim();
            string result = string.Empty;

            string[] seg = permissaoAtual.Trim().Split(';');

            if (adiciona)
            {
                string tagFind = Array.Find<string>(seg, x => x == subTag);
                if (string.IsNullOrEmpty(tagFind))
                    result = String.Join(";", seg) + ";" + subTag;
            }
            else
            {
                foreach (string i in seg)
                {
                    if (i != subTag)
                        result += i + ";";
                }
            }
            return result.Trim();
        }
        private void ManutencaoTablePermissao(TreeNode node, bool adiciona)
        {
            if (node.Tag is Policy)
            {
                Policy tag = (Policy)node.Tag;
                int i = BsPermissao.Find("IDSEGURANCA", tag.TagPai);
                if (i != -1)
                {                   
                    BsPermissao.Position = i;
                    string permissao = BsPermissao.Row["SEGURANCA"].ToString().Trim();

                    BsPermissao.Row["SEGURANCA"] = GetPermissao(tag.Tag.ToString(), permissao, adiciona);
                    BsPermissao.EndEdit();
                }
                else
                {
                    if (adiciona)
                    {
                        string permissao = GetPermissao(tag.Tag.ToString(), string.Empty, adiciona);
                        AddTagPai(Convert.ToInt32(tag.TagPai), permissao);
                    }
                }
            }
            else
            {
                if (node.Tag == null || node.Tag == string.Empty)
                {
                    foreach (TreeNode nodeFilho in node.Nodes)
                    {
                        ManutencaoTablePermissao(nodeFilho, adiciona);
                    }
                    return;
                }

                int ix = BsPermissao.Find("IDSEGURANCA", node.Tag);
                if (ix != -1)
                    BsPermissao.RemoveAt(ix);
                if (adiciona)
                    AddTagPai(Convert.ToInt32(node.Tag), string.Empty);

                foreach (TreeNode nodeFilho in node.Nodes)
                {
                    ManutencaoTablePermissao(nodeFilho,  adiciona);
                }
            }
        }
        private void SetPermissao(TreeNode node, int image)
        {
            if (node.Tag != null)
            {
                node.ImageIndex = image;
                node.SelectedImageIndex = image;
            }

            if (node.Nodes != null)
            {
                this.BsDialog.SetModified();
                foreach (TreeNode nodeFilho in node.Nodes)
                {
                    SetPermissao(nodeFilho, image);
                }
            }
        }

        #endregion

        protected override void PodeIncluir()
        {
            if (!DRContex.Sistema.User.Supervisor)
            {
                throw new Exception("Você não tem permissão para adicionar um novo usuário");
            }

        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DRUserServer();
            this.SetCampoGridInvisivel("Senha");
            
        }
        public override void ExecutaAntesdeSalvar()
        {
            if (this.BsDialog.Row["Senha"].ToString().Length < 6)
            {
                drTextBox3.Focus();
                throw new Exception("A senha  deve ser composta de no mínimo 6 dígitos.");
            }



            base.ExecutaAntesdeSalvar();
        }

        public override void ExecutaAntesdeCancelar()
        {
            if( BsPermissao.Row != null)
                BsPermissao.Row.Table.RejectChanges();
            base.ExecutaAntesdeCancelar();
        }

        private void SetSegurancaCadUser()
        {
            if (!DRContex.Sistema.User.Supervisor)
            {
                tabControl1.TabPages.Remove(tabPermissao);
                this.AlowInsert = false;
            }
            else
                if (!tabControl1.TabPages.Contains(tabPermissao))
                    tabControl1.TabPages.Add(tabPermissao);
            
        }

        private void BsDialog_CurrentItemChanged(object sender, EventArgs e)
        {
            cSuperVisor.Enabled = DRContex.Sistema.User.Supervisor;
            LoadMenus(DRContex.Sistema.MenuSistema);

            SetSegurancaCadUser();
        }

        private void DRCadUser_Load(object sender, EventArgs e)
        {
            LoadMenus(DRContex.Sistema.MenuSistema);

            this.BsPermissao.DataMember = "DRUsuario_DRPERMISSAOUSER";
            this.BsPermissao.DataSource = this.BsDialog;

            SetSegurancaCadUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tvMenus.SelectedNode != null)
            {
                SetPermissao(tvMenus.SelectedNode, 0);
                ManutencaoTablePermissao(tvMenus.SelectedNode, true); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tvMenus.SelectedNode != null)
            {
                SetPermissao(tvMenus.SelectedNode,1);
                ManutencaoTablePermissao(tvMenus.SelectedNode, false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tvMenus.ExpandAll();
        }

        
    }
}
