using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvinhaçãoNumeros.Models
{
    internal class UsuariosJogados
    {
        public int NumId {  get; set; }
        public string? Nome {  get; set; }
        public string? Nivel { get; set; }
        public bool Ganhou { get; set; }
        public TimeSpan? Tempo { get; set; }
    }
}
