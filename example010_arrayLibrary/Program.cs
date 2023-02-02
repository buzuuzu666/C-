void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0; 
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int indx = 0; 
    while (indx < count)
    {
        Console.Write($"{col[indx]} ");
        indx++;
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int i = 0;
    int position = -1; //если искомого элемента нет в массиве, будет выведено -1.
    while (i < count)
    {
        if (collection[i] == find)
        {
            position = i;
            break; // выход после первого найденного элемента. без break покажет индекс последнего найденного элемента.
        }
        i++;
    }
    return position;

}

int [] array = new int [10]; // создаст массив в котором будет 10 элементов, нули.

FillArray(array);
// array[3] = 4; 
// array[6] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4); // передаем функции два аргумента.
Console.WriteLine($"Индекс искомого числа в массиве = {pos} ");