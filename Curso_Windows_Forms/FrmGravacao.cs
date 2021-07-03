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
    public partial class FrmGravacao : Form
    {
        public FrmGravacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomeArq = @"D:\Dev\visual-studio\Curso_Windows_Forms\Curso_Windows_Forms\bin\Debug\Arquivos\Arquivo.txt";
            using (StreamWriter writer = new StreamWriter(nomeArq))
            {
                writer.WriteLine("Primeiro conteudo escrito");
            }
        }
    }
}
