using System.Collections.Generic;
using DIO.Series.DTO;
using DIO.Series.Domain;
using DIO.Series.Repository;

namespace DIO.Series.Application
{
    public static class SerieApp
    {
        public static SerieRepositorio repositorio = new SerieRepositorio();

		public static void Atualiza(int id, SerieDTO objeto)
		{
			Serie serie = new Serie(id: objeto.Id,
										genero: objeto.Genero,
										titulo: objeto.Titulo,
										ano: objeto.Ano,
										descricao: objeto.Descricao);
			repositorio.Atualiza(id, serie);
		}

		public static void Excluir(int id)
		{
			repositorio.Excluir(id);
		}

		public static void Insere(SerieDTO objeto)
		{
			Serie serie = new Serie(id: objeto.Id,
							genero: objeto.Genero,
							titulo: objeto.Titulo,
							ano: objeto.Ano,
							descricao: objeto.Descricao);
			repositorio.Insere(serie);
		}

		public static List<SerieDTO> Lista()
		{
			List<SerieDTO> retorno = new List<SerieDTO>();
			List<Serie> lista = repositorio.Lista();
            if (lista != null && lista.Count > 0)
            {
                foreach (Serie item in lista)
                {
					SerieDTO serie = new SerieDTO(id: item.Id,
												  genero: item.Genero,
												  titulo: item.Titulo,
												  ano: item.Ano,
												  descricao: item.Descricao,
												  excluido: item.Excluido);
					retorno.Add(serie);
				}
            }
			return retorno;
		}

		public static int ProximoId()
		{
			return repositorio.ProximoId();
		}

		public static SerieDTO RetornaPorId(int id)
		{
			Serie serie = repositorio.RetornaPorId(id);
			SerieDTO dto = new SerieDTO(id: serie.Id,
										genero: serie.Genero,
										titulo: serie.Titulo,
										ano: serie.Ano,
										descricao: serie.Descricao,
										excluido: serie.Excluido);
			return dto;
		}
	}
}
