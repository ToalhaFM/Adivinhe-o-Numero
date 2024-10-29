using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvinhaçãoNumeros.Models
{
    public class GravarJogador
    {


        public void GuardarRocord() 
        {
            UsuariosJogados user = new UsuariosJogados();
            string arquivo = @"C:\Users\jeova\OneDrive\Área de Trabalho\Projetos pessoais\Projetos pessoais em Cshape\AdvinhaçãoNumeros\AdvinhaçãoNumeros\Models\Raking.txt";

            if (!File.Exists(arquivo))
            {
                string CriarTxt = Convert.ToString(user.NumId) + user.Nome + user.Nivel + Convert.ToString(user.Ganhou) + Convert.ToString(user.Tempo) + Environment.NewLine;
                File.WriteAllText(arquivo, CriarTxt);
            }
            else
            {
                string AddTxt = Convert.ToString(user.NumId) + user.Nome + user.Nivel + Convert.ToString(user.Ganhou) + Convert.ToString(user.Tempo) + Environment.NewLine;
                File.WriteAllText(arquivo, AddTxt);
            }
            string LerArquivo = File.ReadAllText(arquivo);
            Console.WriteLine(LerArquivo);
            //Está dando erro!
            //Só retorna 0false e salva no arquivo
        }
    }
}
