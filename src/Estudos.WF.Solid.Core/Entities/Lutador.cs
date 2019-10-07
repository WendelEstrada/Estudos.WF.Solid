using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.WF.Solid.Core.Entities
{
    public class Lutador
    {
        public Lutador(int id, string nome, int idade, IEnumerable<string> artesMarciais, int lutas, int derrotas, int vitorias)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            ArtesMarciais = artesMarciais;
            Lutas = lutas;
            Derrotas = derrotas;
            Vitorias = vitorias;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public IEnumerable<string> ArtesMarciais { get; private set; }
        public int Lutas { get; private set; }
        public int Derrotas { get; private set; }
        public int Vitorias { get; private set; }
    }
}
