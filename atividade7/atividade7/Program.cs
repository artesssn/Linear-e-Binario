    static int BuscarPalavra(string[] dicionario, string palavra)
    {
        int esquerda = 0;
        int direita = dicionario.Length - 1;

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2;

            int comparacao = dicionario[meio].CompareTo(palavra);

          
            if (comparacao == 0)
            {
                return meio; 
            }
         
            else if (comparacao < 0)
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
       
        string[] dicionario = {
            "abacaxi", "aberto", "bola", "cachorro", "elefante", "gato", "livro", "pessoa", "zebra"
        };

      
        string palavraParaProcurar = "cachorro";

        
        int resultado = BuscarPalavra(dicionario, palavraParaProcurar);

       
        if (resultado != -1)
        {
            Console.WriteLine($"A palavra '{palavraParaProcurar}' foi encontrada no índice {resultado}.");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavraParaProcurar}' não foi encontrada no dicionário.");
        }
    }

