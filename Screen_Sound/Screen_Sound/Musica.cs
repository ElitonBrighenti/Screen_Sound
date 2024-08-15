using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound
{
    public class Musica
    {

        public Musica(Banda banda, string nome)
        {
            Artista = banda;
            Nome = nome;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";
        //ARROW FUNCION ou LAMBDA, para propriedade de somente leitura

        public void ExibirFichaTecnica()
        {
            Console.WriteLine("**** MUSICAS DISPONIVEIS ****\n");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine($"Disponivel: {Disponivel}\n");
        }

    }
}
