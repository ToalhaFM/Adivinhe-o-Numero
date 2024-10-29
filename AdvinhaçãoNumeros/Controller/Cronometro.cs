using AdvinhaçãoNumeros.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvinhaçãoNumeros.Controller
{
    public class Cronometro
    {
        static Stopwatch Sw = new Stopwatch();

        public void IniciarCronometro()
        {
            Sw.Reset();
            Sw.Start();
            Console.WriteLine("\nTempo Iniciado!\n");
        }
        public void ParaCronometro()
        {

            Sw.Stop(); 
            TimeSpan tempoDecorrido = Sw.Elapsed;
            Console.WriteLine($"Cronômetro parado.\nTempo decorrido: {tempoDecorrido.Hours:00}:" +
                $"{tempoDecorrido.Minutes:00}:{tempoDecorrido.Seconds:00}");
            UsuariosJogados user = new UsuariosJogados();
            user.Tempo = tempoDecorrido;
            GravarJogador gr = new GravarJogador();
            gr.GuardarRocord();
        }    
    }
}
