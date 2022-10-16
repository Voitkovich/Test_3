int [] array ={1,12,33,4,15,6,17,28};

int n = array.Length;
int find = 28;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}