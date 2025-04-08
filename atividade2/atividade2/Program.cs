 
    static bool ExisteNoArray(int[] array, int numero)
    {
        int esquerda = 0;
        int direita = array.Length - 1;

        while (esquerda <= direita)
        {
       
            int meio = esquerda + (direita - esquerda) / 2;

          
            if (array[meio] == numero)
            {
                return true;
            }

        
            if (array[meio] < numero)
            {
                esquerda = meio + 1;
            }
          
            else
            {
                direita = meio - 1;
            }
        }


        return false;
    }

    static void Main(string[] args)
    {
  
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

    
        int numeroParaBuscar = 10;

     
        bool existe = ExisteNoArray(numeros, numeroParaBuscar);

 
        if (existe)
        {
            Console.WriteLine($"O número {numeroParaBuscar} existe no array.");
        }
        else
        {
            Console.WriteLine($"O número {numeroParaBuscar} não existe no array.");
        }
    }

