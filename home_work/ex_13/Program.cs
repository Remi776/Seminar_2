void ThirdDigit(string number)
{
    if (number.Length < 3)
    {
        Console.WriteLine("No third digit");
    }
    else
    {
         Console.WriteLine(number[2]);
    }
}

Console.Write("Enter number: ");
string a = Convert.ToString(Console.ReadLine());

ThirdDigit(a);
