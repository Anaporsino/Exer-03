using _exercicio__02;

aluno aluno1 = new(1986, "Ana Porsino", (new DateTime(2008, 05, 24), "rochaporsinoa@gmail.com");
aluno aluno2 = new (2002, "Ana Brolio", (new DateTime(2008, 05, 24), "anabrolio@gmail.com");
aluno aluno3 = new (2000, "Vitória", (new DateTime(2008, 05, 24), "vitoriaarruda@gmail.com");

Console.WriteLine("O RM do(a) aluno(a) é: " + aluno1.Rm + " o nome é: " + aluno1.Nome + " o ano do nascimenro é: " + aluno1.Nascimento + " e o email é: " +aluno1.Email);
Console.WriteLine("O RM do(a) aluno(a) é: " + aluno2.Rm + " o nome é: " + aluno2.Nome + " o ano do nascimenro é: " + aluno2.Nascimento + " e o email é: " + aluno2.Email);
Console.WriteLine("O RM do(a) aluno(a) é: " + aluno3.Rm + " o nome é: " + aluno3.Nome + " o ano do nascimenro é: " + aluno3.Nascimento + " e o email é: " + aluno3.Email);
Console.ReadLine();