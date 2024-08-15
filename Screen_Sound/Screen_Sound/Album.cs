using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound
{
    public class Album
    {
        public Album(string nome)
        {
            Nome = nome;
        }

        public List<Musica> musicas = new List<Musica>();

        public string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibeMusicas()
        {
            Console.WriteLine($"**** LISTA DE MUSICAS DO ALBUM {Nome}: ****\n");
            foreach (var music in musicas)
            {
                Console.WriteLine($"{music.Nome}");
            }
            Console.WriteLine($"A duração total do album é de: {DuracaoTotal} segundos!");
        }
    }
}
