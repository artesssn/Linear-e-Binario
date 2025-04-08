    static int BuscarPrimeiraOcorrencia(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length - 1;
        int resultado = -1; 

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == numero)
            {
                resultado = meio;
                direita = meio - 1;
            }
      
            else if (array[meio] < numero)
            {
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
      
        int[] numeros = { 1, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9 };

      
        int numeroParaProcurar = 2;

    
        int resultado = BuscarPrimeiraOcorrencia(numeros, numeroParaProcurar);

     
        if (resultado != -1)
        {
            Console.WriteLine($"A primeira ocorrência de {numeroParaProcurar} está no índice {resultado}.");
        }
        else
        {
            Console.WriteLine($"O número {numeroParaProcurar} não foi encontrado no array.");
        }
    }

