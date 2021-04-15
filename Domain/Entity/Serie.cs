using System;

namespace DIO.Series.Domain
{
    public class Serie : EntidadeBase, ISerie
	{
        // Atributos
		public Genero Genero { get; private set; }
		public string Titulo { get; private set; }
		public string Descricao { get; private set; }
		public int Ano { get; private set; }
		public bool Excluido {get; private set; }

        // Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}

        public bool retornaExcluido()
		{
			return this.Excluido;
		}

        public void Excluir() 
		{
            this.Excluido = true;
        }
    }
}