
    static int BuscarBinario(int[] array, int elemento)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            
            int meio = esquerda + (direita - esquerda) / 2;

          
            if (array[meio] == elemento)
            {
                return meio;
            }

          
            if (array[meio] < elemento)
            {
                esquerda = meio + 1;
            }
          
            else
            {
                direita = meio - 1;
            }
        }

       
        return -1;
    }

    static void Main(string[] args)
    {
      
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

      
        int numeroParaBuscar = 15;

        
        int indice = BuscarBinario(numeros, numeroParaBuscar);

     
        if (indice != -1)
        {
            Console.WriteLine($"O número {numeroParaBuscar} foi encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"O número {numeroParaBuscar} não foi encontrado no array.");
        }
    }

