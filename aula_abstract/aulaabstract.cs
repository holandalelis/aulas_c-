using System;

abstract class Veiculo{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    abstract public void aceleracao(int mult);

    public int getVelAtual(){
        return velAtual;
    }

class Carro:Veiculo{
    public Carro(){
        velMaxima=120;
    }
    override public void aceleracao(int mult){
            velAtual+=10*mult;
    }
}


class AulaAbstract{
    static void Main(){
        Carro carro = new Carro();
        Console.WriteLine(carro.getVelAtual());
    }
}
}