//Criar um vetor de valores inteiros
int tamanho = 100;
int[] vetor = new int[tamanho];

//Percorrer o vetor com um laço
Random random = new Random();
for(int i = 0; i < vetor.Length; i++)
{
    //Gerar um valor aleatório em C#
    vetor[i] = random.Next(1000);
}

//Imprimir o vetor com valores aleatórios
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

//Ordenar o vetor usando o Bubble Sort
for(int i = 0; i < vetor.Length - 1; i++)
{
    if(vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
    }
}

Console.Write("\n");
//Imprimir o vetor com valores aleatórios
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}


