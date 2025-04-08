int BuscaSequencial(int[] array, int elemento)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemento)
        {
            return i;
        }
    }
    return -1; 
}

int[] array = { 3, 5, 2, 7, 1, 9 };
int elemento = 7;
int indice = BuscaSequencial(array, elemento);

if (indice != -1)
{
    Console.WriteLine("Elemento encontrado no índice " + indice);
}
else
{
    Console.WriteLine("Elemento não encontrado");
}