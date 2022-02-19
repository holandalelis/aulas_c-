using System;

public class Jogador{
    int energia;
    bool vivo;
    string nome;
    public Jogador(string nome){
        this.nome=nome;
        energia=100;
        vivo=true;
    }
}

public class aulaconstrutores{
   public static void Main(){
       Jogador j1 = new Jogador("Pedro");
       Console.WriteLine("Dados do Jogador{0}: ", j1);
} 
}
