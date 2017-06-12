using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;

namespace CNPJCPF
{
    public partial class Form1 : Form
    {
        Controle controle;
        private int contador = 0;
        
        public Form1()
        {
            InitializeComponent();

            controle = new Controle();

            controle.StatusEvento += Controle_StatusEvento;

            txtCnpjCpf.Clear();
        }

        private void Controle_StatusEvento(int progress, string statusTexto)
        {
            toolStripProgressBar1.Value = progress;
            toolStripStatusLabel2.Text = statusTexto;

            // Para atualizar a GUI simultaneamente à medida que o processo em segundo plano progride
            Application.DoEvents();
        }
        

        private void btnAjustarCnpjCpf_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveCaracteres();
                RemoveItensDuplicados();
                Controle_StatusEvento(100, "Tarefas foram completadas com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        private void RemoveCaracteres()
        {
            try
            {
                string registroAjustado = string.Empty;

                List<string> lista = new List<string>();

                if (txtCnpjCpf.Lines.Length > 0)
                {
                    foreach (var i in txtCnpjCpf.Lines)
                    {
                        registroAjustado = controle.RemoveCaracteresTask(i).Result;
                        Controle_StatusEvento(50, "Removendo caracteres especiais...");

                        lista.Add(registroAjustado);
                    }

                    txtCnpjCpf.Clear();

                    foreach (var i in lista)
                    {
                        txtCnpjCpf.Text += i + "\r\n";
                    }                    
                }

                imgRemoveCaracter.Image = Properties.Resources.checked_32_32;
            }
            catch (Exception)
            {
                imgRemoveCaracter.Image = Properties.Resources.error_32_32;                
            }            
        }

        private void RemoveItensDuplicados()
        {
            try
            {                
                List<string> lista = new List<string>();

                if (txtCnpjCpf.Lines.Length > 0)
                {

                    lista = controle.RemoveIntensDuplicadosTask(txtCnpjCpf.Lines).Result;
                    Controle_StatusEvento(50, "Removendo duplicados...");

                    txtCnpjCpf.Clear();

                    foreach (var i in lista)
                    {
                        txtCnpjCpf.Text += i + "\r\n";
                    }                    
                }

                imgRemoveDuplicados.Image = Properties.Resources.checked_32_32;
            }
            catch (Exception)
            {
                imgRemoveDuplicados.Image = Properties.Resources.error_32_32;                
            }
        }

        private void Contador()
        {
            //string[] linhas = Regex.Split(txtCnpjCpf.Text.Trim(), "\r\n");
            contador = txtCnpjCpf.Lines.Length;
            lblQuantidadeRegistro.Text = contador.ToString();
        }

        private void txtCnpjCpf_TextChanged(object sender, EventArgs e)
        {
            Contador();
        }
    }
}