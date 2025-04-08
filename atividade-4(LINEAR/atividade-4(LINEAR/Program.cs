
   static void EncontrarMaiorEMenor(int[] numeros, out int maior, out int menor)
    {
       
        maior = numeros[0];
        menor = numeros[0];

       
        for (int i = 1; i < numeros.Length; i++)
        {
           
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
           
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
    }

    static void Main(string[] args)
    {
       
        int[] numeros = { 12, 5, 7, 23, 9, 16, 3, 8 };

        
        int maior, menor;

        
        EncontrarMaiorEMenor(numeros, out maior, out menor);

       
        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
    }

