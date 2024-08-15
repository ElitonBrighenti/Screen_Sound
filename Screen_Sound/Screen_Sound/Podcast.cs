using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound
{
    public class Podcast
    {
        private List<Episodio> episodios = new List<Episodio>();

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public string Host { get;}

        public string Nome { get;}

        public int TotalEpisodios => episodios.Count;


        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }
        
        public void ExibirDetalhes()
        {
            Console.WriteLine("**** POD-CASTS ****\n");
            Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");

            foreach (Episodio ep in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(ep.Resumo);
            }
            Console.WriteLine($"Total de episodios = {TotalEpisodios}");
        }
    }
}

