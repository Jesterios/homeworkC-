void FillArray(int[] collection)

void PrintArray(int[] col)

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}


int [] array = new int[10];

FillArray(array);                      
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
