using System;

public class Jogador{
    int energia;
    bool vivo;
    string nome;

    public Jogador(string nome, bool vivo, int energia){
        this.nome = nome;
        this.vivo = vivo;
        this.energia = energia;
    }
    public void info(){
        Console.WriteLine("Nome do Jogador: {0}", nome);
        Console.WriteLine("Energia do Jogador: {0}", energia);
        Console.WriteLine("Jogador está vivo: {0}", vivo);
    }
}

public class aulaconstrutores{
   public static void Main(){
       Jogador j1 = new Jogador("Pedro", true, 35);
       Jogador j2 = new Jogador("Mayara", true, 90);
       j2.info();
} 
}
