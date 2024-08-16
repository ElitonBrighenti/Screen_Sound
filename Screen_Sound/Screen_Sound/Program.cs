namespace Screen_Sound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1° exemplo sem classe album
            //Musica musica1 = new Musica();

            //musica1.Nome = "Nome01";
            //musica1.Artista = "Artista01";
            //musica1.Duracao = 274;
            //musica1.Disponivel = true;
            //Console.WriteLine(musica1.DescricaoResumida);

            //Musica musica2 = new Musica();
            //musica2.Nome = "Nome02";
            //musica2.Artista = "Artista02";
            //musica2.Duracao = 573;
            //musica2.Disponivel = false;

            //musica1.ExibirFichaTecnica();

            #endregion

            Console.WriteLine("TESTANDO COMMIT03");

            Banda queen = new Banda("Queen");

            Album albumDoQuenn = new Album("A night od the opera");

            Musica musica1 = new Musica(queen, "Love Of My Live")
            {
                Duracao = 213,
                Disponivel = true,
            };

            Musica musica2 = new Musica(queen, "Bohemian")
            {
                Duracao = 354,
                Disponivel = false,
            };

            albumDoQuenn.AdicionarMusica(musica1);
            albumDoQuenn.AdicionarMusica(musica2);
            queen.AdicionarAlbuns(albumDoQuenn);


            musica1.ExibirFichaTecnica();
            musica2.ExibirFichaTecnica();
            albumDoQuenn.ExibeMusicas();
            queen.ExibirDiscografica();


            Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
            ep1.AdicionarConvidados("Ana Pereira");
            ep1.AdicionarConvidados("Mário Francis");

            Episodio ep2 = new(2, "Aprendendo a aprender", 78);
            ep2.AdicionarConvidados("Marcos Felício");

            Podcast podCast = new Podcast("Eliton", "Brasilfone");

            podCast.AdicionarEpisodio(ep1);
            podCast.AdicionarEpisodio(ep2);

            podCast.ExibirDetalhes();





        }
    }
}
