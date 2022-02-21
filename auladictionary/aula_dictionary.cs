using System;
using System.Collections.Generic;

public class Aula_dictionary{
    public static void Main(){
        Dictionary <int, string> veiculos = new Dictionary<int, string>();
        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Caminhão");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);


    }


}