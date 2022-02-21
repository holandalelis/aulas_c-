using System;

public class mat{
    public static double pi = 3.14;
    public static int dobro(int n){
        return n*2;
    }
}

class aula_static{
   public static void Main(){
       double vPi=mat.pi;
       int num=10;
       Console.WriteLine(mat.dobro(num));
}    
}
