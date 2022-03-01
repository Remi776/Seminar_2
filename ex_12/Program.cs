void Compare(int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine($"{a} кратно {b}");
    }
    else
    {
        Console.WriteLine($"{a} не кратно {b}, остаток {a % b}");
    }
}

Console.Write("Enter number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\nEnter number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Compare(n1, n2);
