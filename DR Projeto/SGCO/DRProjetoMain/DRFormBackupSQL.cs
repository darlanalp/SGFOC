using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DR.Lib.Winform;
using System.Threading;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer;
using System.IO;
using DRProjetoCadastro.Form;
using DRProjetoCadastro.BLL;
using DR.Utils;

namespace SGFOC
{
    public partial class DRFormBackupSQL : DRForm
    {
        public DRFormBackupSQL()
        {
            InitializeComponent();
        }
        private System.Threading.Thread thread = null;

        private void DRFormAguarde_Load(object sender, EventArgs e)
        {
            // Cria Thread e executa
            thread = new System.Threading.Thread(new ThreadStart(Execute));
            thread.Start();
        }
        /// <summary>
        /// Exceção retornada pelo processo executado
        /// </summary>
        public Exception Error = null;

        /// <summary>
        /// Evento responsável pela execução do processo
        /// </summary>
        public event EventHandler OnExecute;
        private bool temErro = false;
        // Executa Thread
        private void Execute()
        {
            DialogResult = DialogResult.None;

            try
            {
                // Dispara Evento
                if (OnExecute != null)
                {
                    OnExecute(this, new EventArgs());
                }

                // Fecha Form e retorna Sucesso
                DialogResult = DialogResult.OK;
            }
            catch (ThreadInterruptedException)
            {
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                temErro = true;
                // Envia exceção para a Thread Principal
                Error = ex;

                // Fecha Form e retorna Falha
                DialogResult = DialogResult.Abort;
            }
        }
        #region Backup
        public string Caminho;
        public string BancoDados;
        public string Servidor;
        public void ExecuteBackup(object sender, EventArgs e) 
        {          

            this.pg.Maximum = 100;
            BackupBanco();

        }
        public void BackupBanco()
        {
            Server svr = new Server(Servidor);
            Backup bkp = new Backup();
            bkp.Devices.AddDevice(Caminho, DeviceType.File);
            bkp.Database = BancoDados;
            bkp.Action = BackupActionType.Database;
            bkp.Initialize = true;
            bkp.PercentCompleteNotification = 10;
            bkp.PercentComplete += new PercentCompleteEventHandler(bkp_PercentComplete);
            bkp.SqlBackup(svr);
        }

        private void UpdateProg(int percent)
        {
            this.pg.Value = percent;
            this.pg.Update();
            //int x = 0;
            //for (int i = 0; i < 100000000; i++)
            //{
            //    x++;
            //}
        }
        public delegate void updatebar(int percent);

        public void bkp_PercentComplete(object sender, PercentCompleteEventArgs e)
        {           
            pg.Invoke(new updatebar(this.UpdateProg),e.Percent);
        }
        #endregion

        public static void ExecuteBackup(string caminho, string bancoDados, string servidor)
        {
            DRFormBackupSQL formWait = new DRFormBackupSQL();
            formWait.lbTitulo.Text = "Aguarde......";            
            formWait.lbTitulo.Text = "Realizando Backup(Cópia de segurança).";
            formWait.lbResumo.Text = "Este procedimento poderá demorar, pois está sendo efetuada" + Environment.NewLine +
                                     "uma cópia de todo o sistema.";
            formWait.Caminho = caminho;
            formWait.BancoDados = bancoDados;
            formWait.Servidor = servidor;

            formWait.OnExecute = new EventHandler(formWait.ExecuteBackup);


      
            DialogResult drResult = formWait.ShowDialog(); // A Thread Principal deve travar neste ponto

            // Se ocorreu uma exceção não tratada, exibe para o usuário
            if (formWait.Error != null && drResult == DialogResult.Abort)
                throw formWait.Error;
            else 
            {
                DRSelecProjeto server = new DRSelecProjeto();
                server.Initializa(DRContex.Sistema.StringConexao);
                server.SetDataBck();
                server.Dispose();

                    DRProjetoContext.DRProjeto.PreferenciaLocal.SetDataUltimoBackupPres(DateTime.Now);
                    MessageBox.Show("Backup realizado com sucesso!" + Environment.NewLine +
                                    "Arquivo disponibilizado em:" + caminho,
                                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
               
        }
        private void KillThread()
        {
            if (thread != null && thread.IsAlive)
            {
                thread.Interrupt(); // Mata Thread
                thread = null;
            }
        }

        private void DRFormAguarde_FormClosed(object sender, FormClosedEventArgs e)
        {
            KillThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
