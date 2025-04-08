using System;

class Program
{
 
    static int EncontrarMultiplo(int[] array, int X)
    {
    
        for (int i = 0; i < array.Length; i++)
        {
          
            if (array[i] % X == 0)
            {
                return array[i]; 
            }
        }

       
        return -1;
    }

    static void Main(string[] args)
    {
       
        int[] numeros = { 10, 15, 7, 22, 30, 25 };

        
        int X = 5;

        
        int resultado = EncontrarMultiplo(numeros, X);

       
        if (resultado != -1)
        {
            Console.WriteLine($"O primeiro número múltiplo de {X} é: {resultado}");
        }
        else
        {
            Console.WriteLine($"Nenhum número múltiplo de {X} foi encontrado no array.");
        }
    }
}
