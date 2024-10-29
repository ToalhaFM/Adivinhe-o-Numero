// See https://aka.ms/new-console-template for more information
using AdvinhaçãoNumeros.Controller;
using AdvinhaçãoNumeros.Models;

int nivel;

Console.WriteLine("\nBem Vindo!\n");
Console.WriteLine("\nAdvinhe o numero\n");
Console.WriteLine("\n-Regras-\n");
Console.WriteLine("1- Existe 3 níveis, cada nível determina a quantidade de chances que você terá.\n");
Console.WriteLine("2- Você terá que adivinhar o número que eu pensei. uma dica o número está entre 1 e 100.\n");
Console.WriteLine("3- Agora as chances de acordo com o nível.\n" +
                    "3.1- Fácil 10 chances para acertar.\n" +
                    "3.2- Médio 5 chances para acertar.\n" +
                    "3.3- Díficl 3 chances para acertar.\n");

Game g = new Game();

Console.WriteLine("Informe o seu nome: ");
g.InformeNome();
Console.WriteLine("Informe o nível do jogo: ");
nivel = int.Parse(Console.ReadLine());
g.NivelGame(nivel);