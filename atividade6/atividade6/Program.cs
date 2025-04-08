
    static int EncontrarPosicaoInsercao(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length;

        while (esquerda < direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            if (array[meio] < numero)
            {
                esquerda = meio + 1;
            }
            else
            {
                direita = meio;
            }
        }

        return esquerda;
    }

    static void Main(string[] args)
    {
       
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

        
        int numeroParaInserir = 10;

       
        int posicao = EncontrarPosicaoInsercao(numeros, numeroParaInserir);

      
        Console.WriteLine($"O número {numeroParaInserir} deve ser inserido na posição {posicao}.");
    }

