using System;
using DIO.Series.Domain;

namespace DIO.Series.DTO
{
    public class SerieDTO : BaseDTO
	{
        // Atributos
		public Genero Genero { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public int Ano { get; set; }
		public bool Excluido {get; set;}

        // Métodos
		public SerieDTO(int id, Genero genero, string titulo, string descricao, int ano, bool? excluido = false)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = excluido.Value;
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
    }
}