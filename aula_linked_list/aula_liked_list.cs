using System;
using System.Collections.Generic;


public class Aula_Linked_List{
    public static void Main(){

        LinkedList<string> transp = new LinkedList<string>();
        transp.AddFirst("Carro");
        transp.AddFirst("Caminhão");
        transp.AddFirst("Moto");
        transp.AddFirst("Navio");
        transp.AddLast("Bicicleta");

        LinkedListNode<string> no;
        no = transp.AddLast("Navio");
        transp.AddAfter(no, "patinete");




        foreach (string t in transp)
        {
            Console.WriteLine("Transporte {0}", t);
            
        }


    }
}