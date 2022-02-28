void FillPrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(10, 100);
        Console.Write(array[index] + " ");
        index++;
    }
}

void FindMax(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    while (i < len)
    {
        if (arr[i] % 10 > arr[i] / 10)
        {
            Console.Write(arr[i]+"->"+" ");
            Console.WriteLine(arr[i] % 10);
        }
        else
        {
            Console.Write(arr[i]+"->"+" ");
            Console.WriteLine(arr[i] / 10);
        }
        i++;
    }
}

int[] array = new int[10];

FillPrintArray(array);
Console.WriteLine();
FindMax(array);


