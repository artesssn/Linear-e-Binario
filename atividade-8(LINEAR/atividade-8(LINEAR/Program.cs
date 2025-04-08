    static int EncontrarPrimeiroPar(int[] array)
    {
     
        for (int i = 0; i < array.Length; i++)
        {
            
            if (array[i] % 2 == 0)
            {
                return array[i]; 
            }
        }

       
        return -1;
    }

    static void Main(string[] args)
    {
      
        int[] numeros = { 7, 15, 3, 22, 9, 10 };

        
        int resultado = EncontrarPrimeiroPar(numeros);

       
        if (resultado != -1)
        {
            Console.WriteLine($"O primeiro número par no array é: {resultado}");
        }
        else
        {
            Console.WriteLine("Nenhum número par foi encontrado no array.");
        }
    }
