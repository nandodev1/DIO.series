namespace DIO.series
{
    public class Serie : EntidadeBase
    
    {
        public Genero Genero {get; set;}
        public string Titulo {get; set;}

        public string Descricao {get; set;}

        private int Ano {get; set;}

        public Serie(Genero genero, string titulo, string descricao, int ano)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
        public override string ToString()
        {
            return $@"Genero: {this.Genero}\n
                    Titulo: {this.Titulo} \n
                    Descrição: {this.Descricao}\n
                    Ano lançamento: {this.Ano}";
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}