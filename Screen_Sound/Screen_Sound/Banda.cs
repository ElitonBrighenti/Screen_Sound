using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound
{
    public class Banda
    {
        public Banda(string nome) 
        {
            Nome = nome;
        }

        public List<Album> albums = new List<Album>();

        public string Nome { get; set; }

        public void AdicionarAlbuns(Album album)
        {
            albums.Add(album);
        }
        public void ExibirDiscografica()
        {
            Console.WriteLine($"\n**** DISCOGRAFIA DA BANCA {Nome} ****");
            foreach (Album album in albums)
            {
                Console.WriteLine($"\nAlbum: {album.Nome}\n");
            }
        }
    }
}
