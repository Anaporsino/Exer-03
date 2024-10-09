namespace _exercicio__04;

public class carro
{
    public string Marca { get; set; }

    public string Modelo { get; set; }

    public double Velocidade { get; set; }



    public carro(string marca, string modelo, double velocidade)
    {
        Marca = marca;
        Modelo = modelo;
        Velocidade = velocidade;
    }

    public void ValorMetodo()
    {
        Console.WriteLine($"O carro atingiu {Velocidade} da velocidade.");
    }



}
