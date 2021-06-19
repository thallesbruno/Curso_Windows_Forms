using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_Windows_Forms
{
    public partial class Mod_5_Form1 : Form
    {
        public Mod_5_Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Primeira forma
            //MessageBox.Show(System.Environment.CurrentDirectory);

            //Segunda forma
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nomeArq = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Arquivos\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                MessageBox.Show("Arquivo já existe.");
            }
            else
            {
                MessageBox.Show("Criando arquivo.");
                Stream arquivo = File.Create(nomeArq);
                arquivo.Close();
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nomeArq = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Arquivos\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                MessageBox.Show("Arquivo já existe. Excluindo o arquivo.");
                File.Delete(nomeArq);                
            }
            else
            {
                MessageBox.Show("Não existe arquivo.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String nomePasta = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Exemplos";
            String nomeArq = nomePasta + @"\PrimeiroExemplo.txt";
            if (!Directory.Exists(nomePasta))
            {
                MessageBox.Show("Criando a pasta /Exemplos.");
                Directory.CreateDirectory(nomePasta);
            }
            else
            {
                MessageBox.Show("A pasta já existe.");
            }

            if (!File.Exists(nomeArq))
            {
                MessageBox.Show("Criando o arquivo PrimeiroExemplo.");
                File.Create(nomeArq);
            }
            else
            {
                MessageBox.Show("O arquivo já existe.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String nomePasta = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Exemplos";
            if (Directory.Exists(nomePasta))
            {
                Directory.Delete(nomePasta, true);
                MessageBox.Show("Pasta e arquivo excluídos.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!TxtNomePasta.Text.Trim().Equals(String.Empty))
            {
                String nomePasta = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Exemplos";
                if (Directory.Exists(nomePasta))
                {
                    Directory.Move(nomePasta, TxtNomePasta.Text.Trim());
                }
                MessageBox.Show("Pasta renomeada com sucesso!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!TxtNomeArquivo.Text.Trim().Equals(String.Empty))
            {
                String nomePasta = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Exemplos";
                String nomeArq = nomePasta + @"\PrimeiroExemplo.txt";
                if (File.Exists(nomeArq))
                {
                    File.Move(nomeArq, nomePasta + @"\" + TxtNomeArquivo.Text.Trim());
                    MessageBox.Show("Arquivo renomeado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possível renomear o arquivo.");
                }
                
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            String nomePasta = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Exemplos";
            String nomeArq = nomePasta + @"\PrimeiroExemplo.txt";
            if (File.Exists(nomeArq))
            {
                FileInfo file = new FileInfo(nomeArq);
                textBox1.Text = String.Format(
                    "{0}{1}{2}{3}{4}",
                    file.Name,
                    Environment.NewLine,
                    file.Extension,
                    Environment.NewLine,
                    file.Directory);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (TxtNomePasta.Text.Trim().Equals(String.Empty))
            {
                String nomePasta = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Exemplos";
                if (Directory.Exists(nomePasta))
                {
                    DirectoryInfo directory = new DirectoryInfo(nomePasta);
                    textBox2.Text = String.Format(
                        "{0}{1}{2}",
                        directory.Name,
                        Environment.NewLine,
                        directory.Root);
                }
            }
        }
    }
}
