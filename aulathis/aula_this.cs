using System;
public class Calculos{
    public int v1;
    public int v2;

    public int somar(){
        return v1+v2;
    }
    public Calculos(int v1, int v2){
        this.v1 = v1;
        this.v2=v2;
    }
}

public class Aula_this{
    public static void Main(){
        Calculos calculos = new Calculos(10,2);
        Console.WriteLine(calculos.somar());
    }
}