    static int BuscarPrimeiraOcorrencia(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] == numero)
            {
               
                if (meio == 0 || array[meio - 1] != numero)
                {
                    return meio;
                }
              
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

        return -1;
    }


    static List<int> EncontrarTodasOcorrencias(int[] array, int numero)
    {
        List<int> indices = new List<int>();

      
        int primeiraOcorrencia = BuscarPrimeiraOcorrencia(array, numero);

        if (primeiraOcorrencia != -1)
        {
          
            indices.Add(primeiraOcorrencia);

            int i = primeiraOcorrencia + 1;
            while (i < array.Length && array[i] == numero)
            {
                indices.Add(i);
                i++;
            }

          
            i = primeiraOcorrencia - 1;
            while (i >= 0 && array[i] == numero)
            {
                indices.Add(i);
                i--;
            }

        
            indices.Sort();
        }

        return indices;
    }

    static void Main(string[] args)
    {
    
        int[] numeros = { 1, 3, 5, 7, 9, 9, 9, 11, 13, 15, 17, 19, 21 };

      
        int numeroParaBuscar = 9;

        
        List<int> indices = EncontrarTodasOcorrencias(numeros, numeroParaBuscar);

     
        if (indices.Count > 0)
        {
            Console.WriteLine($"O número {numeroParaBuscar} foi encontrado nos índices: {string.Join(", ", indices)}.");
        }
        else
        {
            Console.WriteLine($"O número {numeroParaBuscar} não foi encontrado no array.");
        }
    }

