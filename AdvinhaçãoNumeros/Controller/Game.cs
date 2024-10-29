using AdvinhaçãoNumeros.Interface;
using AdvinhaçãoNumeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvinhaçãoNumeros.Controller
{
    public class Game
    {
        public int NivelJ;
        public void InformeNome()
        {
            string NomePessoa;
            NomePessoa = Console.ReadLine();
            UsuariosJogados usuariosJogados = new UsuariosJogados();
            usuariosJogados.Nome = NomePessoa;
        }

        public void NivelGame(int Nivel) 
        {
            UsuariosJogados usuarios = new UsuariosJogados();
            int cont = 0;   
            Console.WriteLine("\n 1 - Fácil\n 2 - Médio\n 3 - Díficil\n");
            switch (Nivel)
            {
                case 1:
                    Console.WriteLine("Fácil");
                    usuarios.Nivel = "Fácil";
                    cont = 10;
                    Console.WriteLine("Informe um número: ");
                    GameGo(cont);

                    break;
                case 2:
                    Console.WriteLine("Médio");
                    usuarios.Nivel = "Médio";
                    cont = 5;
                    Console.WriteLine("Informe um número: ");
                    GameGo(cont);
                    break;
                case 3: 
                    Console.WriteLine("Díficil");
                    usuarios.Nivel = "Díficil";
                    cont = 3;
                    Console.WriteLine("Informe um número: ");
                    GameGo(cont);
                    break;
                default:
                    Console.WriteLine("\n 1 - Fácil\n 2 - Médio\n 3 - Díficil\n" +
                        "Informe uma d0s numeros acima");
                    break;
            }
            NivelJ = Nivel;
        }

        public Resposta GameGo(int cont)
        {
            Resposta resposta = new Resposta();
            int palpite;
            UsuariosJogados usuariosJogados = new UsuariosJogados();
            Random random = new Random();
            int aleatorio = random.Next(1,100);
            for (int i = 1; i <= cont; i++) 
            {
                palpite = Convert.ToInt32(Console.ReadLine());
                if(aleatorio == palpite)
                {
                    resposta.contador = i;
                    resposta.respotando =  "\nParabéns você acertou!!!\n";
                    usuariosJogados.Ganhou = true;
                    break;
                }
                else
                {
                    resposta.contador = i;
                    resposta.respotando = "\nErrouuuu!!!\n";
                    Console.WriteLine(resposta.respotando);
                    usuariosJogados.Ganhou = false;
                    //Console.WriteLine("Resposta teste: " + aleatorio); //Verificar funcionamento
                }
            }
            
             return resposta;
        }
    }
}
