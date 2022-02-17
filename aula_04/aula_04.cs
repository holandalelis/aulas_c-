using System;

class aula_05{
    static void Main(){
        //Operadores relacionais no C#
        //& -> and/e;
        //| -> or/Ou;
        // >= mesmos padrões de Java <,<=, etc


        int num1 = 5,num2 = 2;
        if (num1>num2|num2==10)
        {
            Console.WriteLine("maior que ou igual a 10");
        }
        else
        {
            Console.WriteLine("menor que");
        }
    }
}