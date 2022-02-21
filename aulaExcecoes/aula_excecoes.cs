using System;

public class Area{
    public static float quadrado(float bas, float alt){
        if(bas<=0 || alt<=0){
            throw new Exception("Base ou altura não podem ser iguais ou menores que 0");
        }
        return bas*alt;
    }
}

public class Aula_excecoes{
    public static void Main(){
        float area=0;
        try
        {
            area = Area.quadrado(0f,5f);
            Console.WriteLine("Area do quadrado {0}", area);
        }catch (Exception e){
            Console.WriteLine("ERRO: {0}", e.Message);
        }finally{
            Console.WriteLine("FIM DO PROCESSO");
        }
    }
}