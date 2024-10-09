using _exercicio__01;

livro livro1 = new livro("O pequeno príncipe", "Antoine de Saint-Exupéry", "HarperCollins Brasil", 1943);
livro livro2 = new livro("Fogo no parquinho", "Yago Martins", "MC", 2020);
livro livro3 = new livro("o Deus que destroi sonhos", "Rodrigo Bibo", "bibotalk", 2021);

Console.WriteLine("O nome do livro é: " + livro1.Titulo + " de autor: " + livro1.Autor + " da editora: " + livro1.Editora + " e sua data de lançamento é: " + livro1.Ano);
Console.WriteLine("O nome do livro é: " + livro2.Titulo + " de autor: " + livro2.Autor + " da editora: " + livro2.Editora + " e sua data de lançamento é: " + livro2.Ano);
Console.WriteLine("O nome do livro é: " + livro3.Titulo + " de autor: " + livro3.Autor + " da editora: " + livro3.Editora + " e sua data de lançamento é: " + livro3.Ano);
string? v = Console.ReadLine();