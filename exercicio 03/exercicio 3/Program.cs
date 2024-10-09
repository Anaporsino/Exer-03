using _exercicio__03;

produto produto1 = new produto( 0001, "Pão", 12.90, 80);
produto produto2 = new produto(0002, "Bolo", 22.00, 10);
produto produto3 = new produto(0003, "Detergente", 3.90, 180);


Console.WriteLine("Código do produto: " + produto1.Codigo + ", Nome do produto: " + produto1.Nome + ", Preço do produto: " + produto1.Preço + ", Quantidade de estoque: " + produto1.Estoque);
Console.WriteLine("Código do produto: " + produto2.Codigo + ", Nome do produto: " + produto2.Nome + ", Preço do produto: " + produto2.Preço + ", Quantidade de estoque: " + produto2.Estoque);
Console.WriteLine("Código do produto: " + produto3.Codigo + ", Nome do produto: " + produto3.Nome + ", Preço do produto: " + produto3.Preço + ", Quantidade de estoque: " + produto3.Estoque);


Console.ReadLine();