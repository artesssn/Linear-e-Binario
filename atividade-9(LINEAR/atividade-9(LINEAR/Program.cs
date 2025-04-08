    static int BuscarComSentinela(int[] array, int elemento)
    {
        int n = array.Length;

      
        int sentinela = elemento;
        array[n - 1] = sentinela;

        int i = 0;

        while (array[i] != sentinela)
        {
            i++;
        }

        
        if (i < n - 1)
        {
            return i; 
        }
        else
        {
            return -1; 
        }
    }

    static void Main(string[] args)
    {
       
        int[] numeros = { 10, 20, 30, 40, 50 };

      
        int elementoParaBuscar = 30;

        
        int indice = BuscarComSentinela(numeros, elementoParaBuscar);

     
        if (indice != -1)
        {
            Console.WriteLine($"Elemento {elementoParaBuscar} encontrado no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"Elemento {elementoParaBuscar} não encontrado no array.");
        }
    }

