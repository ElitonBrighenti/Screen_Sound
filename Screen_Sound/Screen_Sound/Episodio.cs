using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Sound
{
    public class Episodio
    {
        private List<string> nomeConvidados = new List<string>();

        public Episodio(int ordem, string titulo, int duracao)
        {
            Ordem = ordem;
            Titulo = titulo;
            Duracao = duracao;
        }

        public int Ordem { get; }
        public string  Titulo { get; }
        public int Duracao { get; }
        public string Resumo => $"Episodio: {Ordem}°. Titulo: {Titulo}, Duração: ({Duracao} min)- {string.Join(", ", nomeConvidados)}";



        public void AdicionarConvidados(string convidado)
        {
            nomeConvidados.Add(convidado);
        }
    }
}
