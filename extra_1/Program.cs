void IsoscelesTriangle(int a, int b, int c)
{
    if ((a + b > c || a + c > b || b + c > a) & (a == b || a == c || c == b))
    {
        Console.WriteLine("\nIsosceles triangle");
    }
    else
    {
        Console.WriteLine("\nThe triangle does not exist");
    }
}

Console.Write("Side length 'a': ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("\nSide length 'b': ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("\nSide length 'c': ");
int num3 = int.Parse(Console.ReadLine());

IsoscelesTriangle(num1, num2, num3);