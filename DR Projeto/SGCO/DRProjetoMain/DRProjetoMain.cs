using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormMain;
using DRProjetoCadastro.Form;
using DRRelatorios.Rel;
using DRGlobal.Form;
using SGFOC.Properties;
using DR.Utils;
using DRProjetoCadastro.BLL;
using SGFOC;
using DRPatrimonio.Form;
using System.IO;
using DR.Lib.Winform;



namespace DRProjetoMain
{
    public partial class SGFOC : DRMainPrincipal
    {
        public SGFOC()
        {
            InitializeComponent();
            this.Text = DRProjetoContext.DRProjeto.GetSysName() + " - " + DRProjetoContext.DRProjeto.GetVersionSys();
        }
        //protected override Image GetImageFundo()
        //{
        //    this.BackgroundImageLayout = ImageLayout.Tile;
        //    return Resources.LogoSingular;
          
        //}

        protected override void OnAfeterLogin()
        {
            button1.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(1);//Obra
            button2.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(3);//Cronograma
            investidoresToolStripMenuItem.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(8);//Investidor
            button4.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(2); //Fornecedor
            button8.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(5); //Despesa
            button10.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(5); //Gráfico
            button3.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(8); //Investidor
            button6.Enabled = DRContex.Sistema.SegurancaUser.PermitidoAcesso(24); //Backup
   
            base.OnAfeterLogin();
        }
    
        public override Icon GetIcoAplicacao()
        {
            return Resources.SGFOC;

        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool ObraDefaultSetada() 
        {
            bool r = false;

            DRSelecProjeto server = new DRSelecProjeto();
            server.Initializa(DRContex.Sistema.StringConexao);
            object[] result = server.GetProjetoDefault();
            if (result != null)
            {
                DRProjetoContext.DRProjeto.CodProjeto = Convert.ToInt32(result[0]);
                DRProjetoContext.DRProjeto.NomeProjeto = Convert.ToString(result[1]);
                DRProjetoContext.DRProjeto.DataUltimoBck = Convert.ToDateTime(result[2]);
                DRProjetoContext.DRProjeto.strCon = DRContex.Sistema.StringConexao;
                DRContex.Sistema.OwnerData = DRProjetoContext.DRProjeto.CodProjeto;
                r = true;
            }
            server.Dispose();
            return r;
        }

        private void VerificaDespesa_LanFin_NaoAprovado() 
        {
            DRSelecProjeto server = new DRSelecProjeto();
            server.Initializa(DRContex.Sistema.StringConexao);

            string mensagem = "Existem infomações para serem aprovadas pelo usuário supervisor.";
            bool mostra = false;
            if (server.ExisteDespesaParaAprovar()) 
            {
                mensagem += Environment.NewLine + "- Despesas";
                mostra = true;
            }

            if (server.ExisteLanFinParaAprovar())
            {
                mensagem += Environment.NewLine + "- Investidores/Lançamentos Financeiros";
                mostra = true;
            }
            server.Dispose();
            if (mostra)
                MessageBox.Show(mensagem, "Informação importante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SelecionarObra(bool login)
        {
            if (login)
            {
                if (!ObraDefaultSetada())
                    this.ExecuteFormModal(typeof(DRSelectProjeto), "Selecione a Obra");
            }
            else
            {
                this.ExecuteFormModal(typeof(DRSelectProjeto), "Selecione a Obra");
            }

            if (this.Logado)
            {
                LabelSys.Text = "| Obra Seleciona: " + DRProjetoContext.DRProjeto.CodProjeto + " - " + DRProjetoContext.DRProjeto.NomeProjeto;

            }
            VerificaDespesa_LanFin_NaoAprovado();
        }

        private void DRProjetoMain_Load(object sender, EventArgs e)
        {          
            ExecuteLogin();
            if (this.Logado)
            {
                SelecionarObra(true);
                ViewGraficoPrincipal(true);
            }

            DateTime dataUltimoBck = DRProjetoContext.DRProjeto.DataUltimoBck;
            if (dataUltimoBck != DateTime.MinValue)
            {
               DateTime dtLimite = dataUltimoBck.AddDays(6);
               if (DateTime.Now.Date >= dtLimite.Date) 
               {
                   DialogResult result =
                   MessageBox.Show(string.Format("A última cópia de segurança(Backup) do sistema foi realizada em {0},"+
                                                 "é importante que está cópia seja realizada regularmente em Pen Drive."+Environment.NewLine+
                                                 "Deseja realizar a cópia agora?",
                                                 dataUltimoBck.ToShortDateString()),"Importante",MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning) ;
                   if (result == DialogResult.Yes)
                   {
                       backupCópiaDeSegurançaToolStripMenuItem_Click(sender, e);
                   }
               }
            }

        }



        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExecuteLogin();
            VerificaDespesa_LanFin_NaoAprovado();
        
        }

        private void selecionarObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecionarObra(false);
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRCadEmpresa), "DREMPRESA", "Empresa");
        }

        private void acompanhamentoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizaçãoEmArvoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRCronograma), "Cronograma/Acompanhamento da Obra");
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRFormDespesa), "DRDESPESA", @"Despesas  Etapa/Atividade");
            //this.ExecuteForm(typeof(DRDespesaLan), "Despesa por Atividade");
        }

        private void forToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRCadFornecedor), "DRFORNECEDOR", "Forncedores");
        }

        private void despesaPorEtapaAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRDespesaLan), "Despesas por Etapa/Atividade");           
        }

        private void investidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRManutencaoInvestidor), "Investidores");
            //this.ExecuteForm(typeof(DRCadInvestidor), "DRInvestidores", "Investidores");
            
        }

        private void DRProjetoMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void DRProjetoMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Logado)
            {
                if (MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }                
            }
        }

        private void ObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRCadProjeto), "DRProjeto", "Obras");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Backup

        private void backupCópiaDeSegurançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string hora = DateTime.Now.Hour.ToString()+DateTime.Now.Minute.ToString()+DateTime.Now.Second.ToString();
            saveFileDialog1.FileName = string.Format("BackupSGFOC_{0}_{1}_{2}_{3}.BAK",
                                                     DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year,
                                                     hora);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DRFormBackupSQL.ExecuteBackup(saveFileDialog1.FileName, DRContex.Sistema.DataBaseName, DRContex.Sistema.ServerName);         
            }
        }


        #endregion

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        public void ViewGraficoPrincipal(bool load) 
        {
            if (load)
            {
                if (DRProjetoContext.DRProjeto.PreferenciaLocal.MostraGrafico())
                {
                    string titulo = DRProjetoContext.DRProjeto.CodProjeto + " - " + DRProjetoContext.DRProjeto.NomeProjeto;
                    this.ExecuteForm(typeof(DRGraficoPercentualObra), "Gráficos Obra: " + titulo);
                }
            }
            else
            {
                string titulo = DRProjetoContext.DRProjeto.CodProjeto + " - " + DRProjetoContext.DRProjeto.NomeProjeto;
                this.ExecuteForm(typeof(DRGraficoPercentualObra), "Gráficos Obra: " + titulo);
            }

        }

        private void gráficoPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewGraficoPrincipal(false);
        }
        protected override MenuStrip GetMainMenu()
        {
            AddMenuSeguranca(loginToolStripMenuItem, "Etapas", 6);
            AddMenuSeguranca(loginToolStripMenuItem, "Atividade", 7);
            AddMenuSeguranca(loginToolStripMenuItem, "Lançamentos Investidor", 9);
            AddMenuSeguranca(loginToolStripMenuItem, "Visualizar Totalizadores no Cronograma", 21); 
            return this.menuStrip2;
        }

        protected override DRSegurancaForm GetComponenteSeguranca()
        {
            return drControleFormControl1.DR;
        }

        private void usuáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {                    
           this.ExecuteForm(typeof(DRCadUser), "DRUsuario", "Usuários");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
           
        }

        private void investidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DRRelatorisClass.RelatorioInvestidores();            
        }

        private void acompanhamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteFormModal(typeof(DRFormRelAcompanhamento), "Relatório de Acompanhamento");
        }

        private void acompanhamentoInvestidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteFormModal(typeof(DRFormRelAcompInvestidor), "Relatório de Acompanhamento Investidor");
        }

        private void despesaPorEtapaAtividadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ExecuteFormModal(typeof(DRFORMRelDespesaAtividade), "Relatório de Despesa - Etapa/Atividade");
        }

        private void investidoresToolStripMenuItem1_Click()
        {

        }

        private void patrimônioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRCadPatrimonio), "DRPATRIMONIO", "Cadastro de Patrimônios ");
            
        }

        private void patrimôniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteFormModal(typeof(DRFormRelPatrimonio), "Relatório de Patrimônio");
            
        }

        private void rendimentosMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ExecuteForm(typeof(DRCadRendimento), "DRRENDIMENTO", "Rendimentos Mensal");
            
        }

        private void extratoPagamentoInvestidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteFormModal(typeof(DRRelExtratoPagInvestidor), "Extrato de Pagamento Investidor");
           
        }

        private void etapasAtividadesCadastradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DRRelatorisClass.RelatorioEtapas_AtividadesCadastradas();
        }

        private void ajudaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void conferenciaDeDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteFormModal(typeof(DRFormConferenciaDespesas), "Relatório de Conferencia de Despesas");
        }

        private void cotasDaObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExecuteForm(typeof(DRCadCota), "DRCOTAS", "Cotas da Obra");
            
        }

        private void cotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DRRelatorisClass.RelatorioCota();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strPath = Path.Combine(Application.StartupPath, "SGFOC - Manual.mht");
            strPath = strPath.Replace(@"bin\Debug\", "");
            if (!File.Exists(strPath))
            {
                MessageBox.Show("Arquivo de ajuda não encontrado.");
                return;
            }
            System.Diagnostics.Process.Start(strPath); 
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
       

  

    }
}