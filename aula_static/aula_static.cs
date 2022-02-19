using System;

static public class Jogador{
    static int energia;
    static bool vivo;
    static string nome;

    static public void iniciar(string n, bool v, int e){
        n = nome;
        v = vivo;
        e = energia;
    }
    static public void info(){
        Console.WriteLine("Nome do Jogador: {0}", nome);
        Console.WriteLine("Energia do Jogador: {0}", energia);
        Console.WriteLine("Jogador está vivo: {0}", vivo);
    }
}
public class Inimigo{
    static bool alerta;
    string nome;

    public void Inimigo(string n, bool alert){
        n = nome;
        alert = alerta;
    }

    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("---------------");
    }
    
}

public class aulaconstrutores{
   public static void Main(){
       Inimigo i1 = new Inimigo("Pipocudo", false);
       i1.info();
       Inimigo.alerta = true;
       i1.info();
       
} 
}