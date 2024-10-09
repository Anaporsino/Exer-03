namespace _exercicio__01
{

    public class livro
    {

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }
        
        public int Ano { get; set; }


        public livro(string titulo, string autor, string editora, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Ano = ano;
        }

    }
}