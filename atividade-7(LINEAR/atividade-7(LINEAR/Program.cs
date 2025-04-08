
    static int EncontrarUltimaOcorrencia(int[] array, int elemento)
    {
      
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == elemento)
            {
                return i;  
            }
        }

      
        return -1;
    }

    static void Main(string[] args)
    {
        
        int[] numeros = { 10, 20, 30, 20, 50, 20 };

       
        int elementoParaBuscar = 20;

    
        int indice = EncontrarUltimaOcorrencia(numeros, elementoParaBuscar);

       
        if (indice != -1)
        {
            Console.WriteLine($"A última ocorrência do número {elementoParaBuscar} está no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"O número {elementoParaBuscar} não foi encontrado no array.");
        }
    }

