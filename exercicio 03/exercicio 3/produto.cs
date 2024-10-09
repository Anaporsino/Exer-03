namespace _exercicio__03;

    public class produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Preço { get; set; }
  
        public int Estoque { get; set; }



        public produto(int codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preço = preco;
            Estoque = estoque;
        }

        public void ValorMetodo()
    {
        Console.WriteLine($"o valor em estoque {Estoque}");
    }



    }
