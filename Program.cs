using System;
for (; ; )
{
    Console.WriteLine("What are you looking to do?");
    string decision = Console.ReadLine();

    Random rnd = new Random();
    int numb = rnd.Next(2);

    if (numb == 0)
    {
        Console.WriteLine("Yes, you should.\n");
    }

    else
    {
        Console.WriteLine("No, you should not.\n");
    }
}