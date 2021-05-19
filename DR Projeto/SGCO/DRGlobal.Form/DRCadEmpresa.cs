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
using System.IO;

namespace DRGlobal.Form
{
    public partial class DRCadEmpresa : DRFormDialog
    {
        public DRCadEmpresa()
        {
            InitializeComponent();
        }
        protected override void CriaObjetoGerenciadorRegraNegocio(ref object objRegraNegocio)
        {
            objRegraNegocio = new DREmpresaServer();
            this.SetCampoGridInvisivel("LOGO");
            this.SetCampoGridInvisivel("IDEMPRESA");
        }

        // **** Le a imagem em um array de bytes a partir do sistema de arquivos
        public static byte[] GetFoto(string caminhoArquivoFoto)
        {
            FileStream fs = new FileStream(caminhoArquivoFoto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            byte[] foto = br.ReadBytes((int)fs.Length);

            br.Close();

            fs.Close();

            return foto;
        }

        private string caminhoFoto = string.Empty;
        public override void ExecutaAntesdeSalvar()
        {
            if (caminhoFoto != string.Empty)
            {
                // Le a imagem em um array de bytes do arquivo de sistemas
                byte[] fotoImagem = GetFoto(caminhoFoto);
                if (fotoImagem.Length > 0)
                    this.BsDialog.Row["LOGO"] = fotoImagem;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Abrir Foto";
            dlg.Filter = @"All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dlg.OpenFile());
                    caminhoFoto = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }

            dlg.Dispose();
            this.BsDialog.SetModified();

        }

        private System.Drawing.Image arrayByteToImage(byte[] imagemEmBytes)
        {
            MemoryStream ms = null;
            Image img;

            try
            {
                ms = new MemoryStream(imagemEmBytes, 0, imagemEmBytes.Length);
                ms.Write(imagemEmBytes, 0, imagemEmBytes.Length);
                img = Image.FromStream(ms, true);
                return img;
            }
            catch (ArgumentException aex)
            {
                throw new InvalidOperationException("Imagem inválida");
            }
            finally
            {
                if (ms != null)
                {
                    ms.Close();
                    ms = null;
                }
            }
        }

        private void ExibeImage() 
        {
            caminhoFoto = string.Empty;
            pictureBox1.Image = null;
            if (this.BsDialog.Row == null) return;
            if (this.BsDialog.Row["LOGO"] == DBNull.Value)
            {               
                return;
            }
            pictureBox1.Image = arrayByteToImage((byte[])this.BsDialog.Row["LOGO"]);
        }
      
       

        private void BsDialog_PositionChanged(object sender, EventArgs e)
        {
            ExibeImage();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            this.BsDialog.Row["LOGO"] = DBNull.Value;
            caminhoFoto = string.Empty;

        }
    }
}
