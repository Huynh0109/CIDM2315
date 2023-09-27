namespace HomeWork5;

class Program
{
    static void Main(string[] args)
    {
        // question 1
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = questionOne(a,b);
        Console.WriteLine($"a = {a}; b={b}");
        Console.Write($"The largest number is: {result}\n");

        // question 2
        int e = Convert.ToInt32(Console.ReadLine());
        int f = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int max1 = questionTwo(e,f);
        int max2 = questionTwo(c,d);
        int largestNum = questionTwo(max1, max2);
        Console.WriteLine($"a = {e}; b={f}; c = {c}; d={d};");
        Console.Write($"The largest number is: {largestNum}\n");

        // question 3
        creatAccount();
    }


    // question 1
    static int questionOne(int a, int b)
    {
        return Math.Max(a,b);
    }

    
    // question 2
    static int questionTwo(int a, int b)
    {
        return Math.Max(a, b);
    }

    // question 3
    static bool checkAge(int birth_year)
    {
        int current_year = 2023;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void creatAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string? userName = Console.ReadLine();

        Console.WriteLine("Enter Your Password:");
        string? passWord = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again:");
        string? passWordAgain = Console.ReadLine();

        Console.WriteLine("Enter Your Birthyear:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        bool isOldEnough = checkAge(birthYear);

        if(isOldEnough)
        {
            if(passWord == passWordAgain)
            {
                Console.WriteLine("Account is created sucessfully");
            }
            else if(passWord != passWordAgain)
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
            {
                Console.WriteLine("Could not create an account.");
            }
        
    }

}
