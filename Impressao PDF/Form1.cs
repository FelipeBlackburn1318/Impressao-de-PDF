using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Impressao_PDF
{
    public partial class Form1 : Form
    {
        String[] arquivo = new String[999];
        int contador = 0;
        int contadorTabela = 0;
        int maximo = 999;
        DataTable tabela = new DataTable();
        String[] erro = new String[999];

        public Form1()
        {
            InitializeComponent();
            try
            {
                tabela.Columns.Add("Ordem de impressão", typeof(int));
                tabela.Columns.Add("Nome do arquivo", typeof(String));
                carregarLista();

            }
            catch
            {

            }
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            try
            {
                if (contador < maximo)
                {
                    OpenFileDialog arqu = new OpenFileDialog();

                    arqu.Filter = "arquivos PDF |*.pdf";
                    arqu.Multiselect = true;

                    if (arqu.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        foreach (String file in arqu.FileNames)
                        {
                            arquivo[contador] = System.IO.Path.GetFullPath(file);
                            carregarLista(System.IO.Path.GetFileName(file));
                            contador++;
                        }
                    }

                }
            }
            catch
            {
            }
        }

        public void carregarLista()
        {
            try
            {
                dtgPdf.DataSource = tabela;
            }
            catch
            {

            }
        }


        public void carregarLista(String nome)
        {
            try
            {
                contadorTabela++;
                tabela.Rows.Add(contadorTabela, nome);

                dtgPdf.DataSource = tabela;
            }
            catch
            {

            }
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                int total = contador;
                contador = 0;
                while (contador < total)
                {
                    p.StartInfo.Verb = "print";
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.StartInfo.FileName = arquivo[contador];
                    p.Start();
                    p.WaitForInputIdle();
                    try
                    {
                        System.Threading.Thread.Sleep(7000);
                        if (false == p.CloseMainWindow())
                            p.Kill();
                    }
                    catch
                    {
                    }

                    contador++;
                }

                limparLista();
            }
            catch
            {
            }
        }

        public void limparLista()
        {
            try
            {
                tabela = new DataTable();
                tabela.Columns.Add("Ordem de impressão", typeof(int));
                tabela.Columns.Add("Nome do arquivo", typeof(String));
                dtgPdf.DataSource = tabela;
                contadorTabela = 0;
                contador = 0;
            }
            catch
            {

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparLista();
        }
    }
}
