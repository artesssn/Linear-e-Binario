
    static int MaiorMenorQueX(int[] array, int X)
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        int resultado = -1; 

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

           
            if (array[meio] < X)
            {
                resultado = array[meio];
                esquerda = meio + 1;
            }
            else
            {
                direita = meio - 1; 
            }
        }

        return resultado; 
    }

    static void Main(string[] args)
    {
       
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

      
        int X = 10;

     
        int resultado = MaiorMenorQueX(numeros, X);

    
        if (resultado != -1)
        {
            Console.WriteLine($"O maior número menor que {X} é {resultado}.");
        }
        else
        {
            Console.WriteLine($"Não existe número menor que {X} no array.");
        }
    }

