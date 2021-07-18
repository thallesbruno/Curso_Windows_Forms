using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModuloSete
{
    public interface IVeiculo
    {
        String cor { get; set; }
        String modelo { get; set; }
        Double velocidadeMaxima { get; set; }
        int qtdRodas { get; set; }
        int qtdPortas { get; set; }

        string Ligar();
        string Ligar(int velocidade);
        string Ligar(double velocidade);
        string Acelerar();
    }
}
