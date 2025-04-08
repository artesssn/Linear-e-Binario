    static int BuscarPalavra(string texto, string palavra)
    {
    
        return texto.IndexOf(palavra);
    }

    static void Main(string[] args)
    {
   
        Console.WriteLine("Digite o texto:");
        string texto = Console.ReadLine();

       
        Console.WriteLine("Digite a palavra que deseja buscar:");
        string palavra = Console.ReadLine();

        
        int posicao = BuscarPalavra(texto, palavra);

       
        if (posicao != -1)
        {
            Console.WriteLine($"A palavra '{palavra}' foi encontrada no índice {posicao}.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavra}' não foi encontrada no texto.");
        }
    }

