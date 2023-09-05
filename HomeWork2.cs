namespace HomeWork2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a letter grade:");
        string input = Console.ReadLine();

        if (input == "A")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (input == "B")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (input == "C")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (input == "D")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (input == "F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }    

        Console.WriteLine("Please input the first num: ");
        string input_1 = Console.ReadLine();
        int n1 = Convert.ToInt32(input_1);
        Console.WriteLine("Please input the second num: ");
        string input_2 = Console.ReadLine();
        int n2 = Convert.ToInt32(input_2);
        Console.WriteLine("Please input the third num: ");
        string input_3 = Console.ReadLine();
        int n3 = Convert.ToInt32(input_3);

        if (n1 < n2)
        {
            if (n1 < n3)
            {
                Console.WriteLine("The smallest value is: " + n1);
            }
            else
            {
                Console.WriteLine("The smallest value is: " + n3);
            }
        }
        else
        {
            if (n2 < n3)
            {
                Console.WriteLine("The smallest value is: " + n2);
            }
            else
            {
                Console.WriteLine("The smallest value is: " + n3);
            }
        }


        Console.WriteLine("Please input a year:");
        string input_4 = Console.ReadLine();
        int n4 = Convert.ToInt32(input_4);

        if (((n4 % 4 == 0) && (n4 % 100 != 0)) || (n4 % 400 == 0))
        {
            Console.WriteLine(n4 + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(n4 + " is not a Leap Year.");
        }

    }
}
