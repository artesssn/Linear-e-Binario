using System;

class Program
{
    
    static int EncontrarIndice(string[] nomes, string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                return i;  
            }
        }
        return -1;  
    }

    static void Main(string[] args)
    {
        
        string[] nomes = { "João", "Maria", "Ana", "Carlos", "Pedro" };

        
        string nomeParaBuscar = "João";

        int indice = EncontrarIndice(nomes, nomeParaBuscar);

      
        if (indice != -1)
        {
            Console.WriteLine($"O nome '{nomeParaBuscar}' está no índice {indice}.");
        }
        else
        {
            Console.WriteLine($"O nome '{nomeParaBuscar}' não foi encontrado.");
        }
    }
}
