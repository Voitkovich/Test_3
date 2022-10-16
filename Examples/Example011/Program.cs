void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length) 
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] collection = new int[10];

FillArray(collection);
PrintArray(collection);
