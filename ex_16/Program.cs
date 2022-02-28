int sqr(int n)
{
    return(n * n);
}

Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} * {a} = " + sqr(a));

