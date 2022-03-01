void Versa(int number)
{
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Wrong number, try again");
    }
    else
    {
        string last_digit = Convert.ToString(number % 10);
        string middle_digit = Convert.ToString(number / 10 % 10);
        string first_digit = Convert.ToString(number / 100);
        Console.WriteLine(last_digit + middle_digit + first_digit);
    }
}

Console.Write("Enter three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

Versa(a);

