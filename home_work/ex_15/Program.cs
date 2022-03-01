void Weekend(int number)
{
    string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Saturday" };
    if (number == 5)
    {
        Console.WriteLine("Shabbat shalom!");
    }
    else if (number == 6)
    {
        Console.WriteLine("My head... i need water! What happend yesterday?");
    }
    else
    {
        Console.WriteLine("Oh no, I have to go for a work;(");
    }
}

Console.Write("Enter the day number of the week: ");
int n = int.Parse(Console.ReadLine());

Weekend(n);