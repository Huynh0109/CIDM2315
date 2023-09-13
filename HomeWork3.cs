namespace HomeWork3;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Input an integer: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if(N == 0 || N == 1)
        {
            Console.WriteLine($"{N} is non-prime");
        }
        else
        {
            for(int i = 2; i <= N/2; i++)
            {
                if(N % i ==0)
                {
                    Console.WriteLine($"{N} is non-prime");
                    return;
                }
            }
            Console.WriteLine($"{N} is prime");
        }

        
        Console.WriteLine("Assign an int value to N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row<n; row++)
        {
            for (int col = 0; col<n; col++)
            {
                Console.Write("#");
            }
          Console.WriteLine("");  
        } 
        

        
        Console.WriteLine("Assign an int value to N: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        for (int row1 = 0; row1<n1; row1++)
        {
            for (int col1 = 0; col1<n1; col1++)
            {
                if (row1>=col1)
                {
                    Console.Write("*");
                }
            }
          Console.WriteLine("");  
        } 
        

        
        int row2 = 0;
        int col2 = 0;
        int inner_row = 0;
        
        Console.WriteLine("Assign an int value to N:");
        int n2 = Convert.ToInt32(Console.ReadLine());

        for (row2 = 1; row2 <= n2; row2++)
        {
            for (col2 = n2; col2 > row2; col2--)
            {
                Console.Write(" ");
            }
            for (inner_row = 0; inner_row < row2; inner_row++)
            {
                Console.Write(row2);
            }
            Console.WriteLine();
        }

    }
}
