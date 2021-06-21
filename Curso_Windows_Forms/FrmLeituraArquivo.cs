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
                lsbConteudo.Items.Clear();
                foreach (var item in array)
                {
                    lsbConteudo.Items.Add(item);
                }
            }
        }
    }
}
