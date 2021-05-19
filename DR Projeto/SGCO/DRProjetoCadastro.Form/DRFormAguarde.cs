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

namespace DRProjetoCadastro.Form
{
    public partial class DRFormAguarde : DRForm
    {
        public DRFormAguarde()
        {
            InitializeComponent();
        }
        private System.Threading.Thread thread = null;

        private void DRFormAguarde_Load(object sender, EventArgs e)
        {
            if (!this.SomenteAguarde)
            {
                // Cria Thread e executa
                thread = new System.Threading.Thread(new ThreadStart(Execute));
                thread.Start();
            }
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
        public bool SomenteAguarde = false;
        public static DRFormAguarde FormAguarde;

        public static void ExecuteFormWait(string title, string description) 
        {
            FormAguarde = new DRFormAguarde();
            FormAguarde.SomenteAguarde = true;
            FormAguarde.lbTitulo.Text = "Aguarde......";
            FormAguarde.lbResumo.Text = "Executando rotina.";

            if (!String.IsNullOrEmpty(title))
                FormAguarde.lbTitulo.Text = title;
            if (!String.IsNullOrEmpty(description))
                FormAguarde.lbResumo.Text = description;

            FormAguarde.Show(); // A Thread Principal deve travar neste ponto
            FormAguarde.Refresh();
        }

        public void FinalizaAguarde()
        {

            try
            {
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
            this.Close();
        }
        public static void ExecuteAsync(string title, string description, EventHandler handler)
        {
           

            DRFormAguarde formWait = new DRFormAguarde();
            formWait.lbTitulo.Text = "Aguarde......";
            formWait.lbResumo.Text = "Executando rotina.";

            if (!String.IsNullOrEmpty(title))
                formWait.lbTitulo.Text = title;
            if (!String.IsNullOrEmpty(description))
                formWait.lbResumo.Text = description;
      
            formWait.OnExecute += handler;
      
            DialogResult drResult = formWait.ShowDialog(); // A Thread Principal deve travar neste ponto

            // Se ocorreu uma exceção não tratada, exibe para o usuário
            if (formWait.Error!= null && drResult == DialogResult.Abort)
                throw formWait.Error;
               
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
