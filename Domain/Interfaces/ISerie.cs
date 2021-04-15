namespace DIO.Series.Domain
{
    interface ISerie
    {
        public string retornaTitulo();

        public int retornaId();

        public bool retornaExcluido();

        public void Excluir();
    }
}
