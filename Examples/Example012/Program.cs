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

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] collection = new int[10];

FillArray(collection);
PrintArray(collection);
Console.WriteLine();

int pos = indexOf(collection, 4);
Console.WriteLine(pos);

