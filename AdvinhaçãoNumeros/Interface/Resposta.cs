using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvinhaçãoNumeros.Interface
{
    public struct Resposta
    {
        public string respotando {  get; set; }
        public int contador { get; set; }

        public override string ToString()
        {
            return $"acertou: {this.respotando}" + 
                $"contador: {this.contador}";
        }
    }
}
