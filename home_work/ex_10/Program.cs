void Versa(int number)
{
    string last_digit = Convert.ToString(number % 10);
    string middle_digit = Convert.ToString(number / 10 % 10);
    string first_digit = Convert.ToString(number / 100);
    Console.WriteLine(last_digit + middle_digit + first_digit);
}

Console.Write("Enter three-digit number: ");
int a = int.Parse(Console.ReadLine());
Versa(a);

