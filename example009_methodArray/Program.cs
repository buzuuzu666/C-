int [] array = {1, 12, 31, 4, 51, 18, 6, 17, 18, 9};

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Write($"{array[index]} ");
        // break;
    }

    index++;
}
