using System;


delegate int op(int n1, int n2);

public class Mat{
    public static int soma(int n1, int n2){
        return n1+n2;
    }
    public static int multiplicacao(int n1, int n2){
        return n1*n2;
    }
}

/*public class parans{
    public int teste (params int[]n){
        int soma=0;
        for (int i=0;i<n.Length;i++){
            soma+=n[i];
        }
    }
}*/


class aula_delegate{
   public static void Main(){
       int res;

       op d1 = new op(Mat.soma);
       res=d1(10,50);
       Console.WriteLine("Soma: {0}", res);
      
       d1=new op(Mat.multiplicacao);
       res=d1(10,20);
       Console.WriteLine(res);

}    
}