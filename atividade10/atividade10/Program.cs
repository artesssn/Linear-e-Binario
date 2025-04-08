
    static int EncontrarNumeroMaisProximo(int[] array, int X)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

     
        int maisProximo = array[0];
        int menorDiferenca = Math.Abs(array[0] - X);

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

         
            int diferenca = Math.Abs(array[meio] - X);

     
            if (diferenca < menorDiferenca)
            {
                menorDiferenca = diferenca;
                maisProximo = array[meio];
            }

        
            if (array[meio] > X)
            {
                direita = meio - 1;
            }
        
            else if (array[meio] < X)
            {
                esquerda = meio + 1;
            }
         
            else
            {
                return array[meio];
            }
        }

      
        return maisProximo;
    }

    static void Main(string[] args)
    {
      
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

      
        int X = 10;

      
        int resultado = EncontrarNumeroMaisProximo(numeros, X);

       
        Console.WriteLine($"O número mais próximo de {X} é {resultado}.");
    }

