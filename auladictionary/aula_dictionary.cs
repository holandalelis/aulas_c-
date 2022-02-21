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

        int chave=20;

        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A chave {0} está na coleção.", chave);
        }else{
            Console.WriteLine("A chave {0} não está na coleção", chave);
        }

        string valor = "Bicicleta";

        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("A chave {0} está na coleção.", valor);
        }else{
            Console.WriteLine("A chave {0} não está na coleção", valor);
        }


    }


}