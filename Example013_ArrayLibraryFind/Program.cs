void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
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

int Indexof(int[] collection, int number)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == number)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

Console.Write("Hello, enter the number from 1 to 10: ");
int number = int.Parse(Console.ReadLine() ?? "");

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, number);

if (pos == -1) Console.WriteLine($"Уour number is not in the array");
else Console.WriteLine($"The index your namber in array is {pos}");
