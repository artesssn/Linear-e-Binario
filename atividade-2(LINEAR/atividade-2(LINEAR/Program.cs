int ContaOcorrencias(int[] array, int elemento)
{
    int ocorrencias = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemento)
        {
            ocorrencias++;
        }
    }
    return ocorrencias;
}
int[] array = { 3, 5, 2, 7, 1, 9, 7, 7 };
int elemento = 7;
int ocorrencias = ContaOcorrencias(array, elemento);
Console.WriteLine("O elemento " + elemento + " aparece " + ocorrencias + " vezes no array.");