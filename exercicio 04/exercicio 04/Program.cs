using _exercicio__04;

carro carro1 = new carro("BMW", "BMW X6 M Competition", 250.0);
carro carro2 = new carro("Chevrolet", "ONIX", 180.0);
carro carro3 = new carro("Kwid", "outsider", 155.0);


Console.WriteLine("Marca do carro: " + carro1.Marca + ", Modelo do carro: " + carro1.Modelo + ", Velocidade: " + carro1.Velocidade + "KM/ h");
Console.WriteLine("Marca do carro: " + carro2.Marca + ", Modelo do carro: " + carro2.Modelo + ", Velocidade: " + carro2.Velocidade + "KM/ h");
Console.WriteLine("Marca do carro: " + carro3.Marca + ", Modelo do carro: " + carro3.Modelo + ", Velocidade :" + carro3.Velocidade + "KM/ h");

Console.ReadLine();