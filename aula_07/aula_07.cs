using System;

class aula_07{
    public static void Main(){
        int v1,v2,soma;
        string nome;

        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());

        soma=v1+v2;

        Console.WriteLine("O resultado da soma entre {0} e {1}, é : {2}", v1,v2,soma);
    }
}