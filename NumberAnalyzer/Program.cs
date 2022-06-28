Console.Write("Hello! Please enter your name: ");
string name = Console.ReadLine();

string answer = " ";

do
{
    Console.Write("\nPlease enter a number from 1 to 100: ");
    int input = int.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    if (input % 2 != 0 && input < 60)
    {
        Console.WriteLine(name + ", you entered " + input + " - This number is odd and less than 60!");
    }
    else if (input % 2 == 0 && input <= 24)
    {
        Console.WriteLine(name + ", you entered " + input + " - This number is even and less than 25!");
    }
    else if (input % 2 == 0 && input >= 26 && input <= 60)
    {
        Console.WriteLine(name + ", you entered " + input + " - This number is even and between 26 and 60 inclusive!");
    }
    else if (input % 2 == 0 && input > 60 && input <= 100)
    {
        Console.WriteLine(name + ", you entered " + input + " - This number is even and greater than 60!");
    }
    else if (input % 2 != 0 && input > 60 && input <= 100)
    {
        Console.WriteLine(name + ", you entered " + input + " - This number is odd and greater than 60!");
    } else
    {
        Console.WriteLine("That wasn't a valid number between 1 and 100...");
    }

    Console.Write("\nWould you like to try another number? (y/n) ");
    answer = Console.ReadLine();

    if (answer == "n")
    {
        Console.WriteLine("Goodbye!");
    } else if (answer == "y")
    {
        continue;
    }

     else
    { 
        Console.WriteLine("That wasn't a valid answer..."); 
    }

} while (answer == "y");



Console.ReadKey();