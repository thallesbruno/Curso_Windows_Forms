using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Curso_Windows_Forms
{
    public partial class FrmLeituraArquivo : Form
    {
        public FrmLeituraArquivo()
        {
            InitializeComponent();
        }

        private void btnLeitura_Click(object sender, EventArgs e)
        {
            String nomeArq = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Arquivos\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                String[] array = File.ReadAllLines(nomeArq);
                foreach (var item in array)
                {
                    lsbConteudo.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomeArq = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Arquivos\Arquivo.txt";
            if (File.Exists(nomeArq))
            {
                StreamReader reader = new StreamReader(nomeArq);
                String linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    lsbConteudo.Items.Add(linha);
                }
                reader.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbConteudo.Items.Clear();
        }
    }
}
