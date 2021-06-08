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
    }
}
