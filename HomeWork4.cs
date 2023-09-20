namespace HomeWork4;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int output = QuestionOne(a, b);
        Console.WriteLine($"The largest number is: {output}");

        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"N= {n}");
        string? input = Console.ReadLine();
        QuestionTwo(n, input);
        Console.WriteLine("");
        
    }

    static int QuestionOne(int a, int b){
        Console.WriteLine($"a = {a}; b={b}");
        if (a > b){
            return a;
        }
        else{
            return b;
        }
    }

    static void QuestionTwo(int n, string shape){
        int row2 = 0;
        int col2 = 0;
        int inner_row = 0;
        if (shape == "left"){
            for (int row1 = 0; row1<n; row1++)
            {
            for (int col1 = 0; col1<n; col1++)
            {
                if (row1>=col1)
                {
                    Console.Write("*");
                }
            }
          Console.WriteLine("");  
            } 
        }
        else{
            for (row2 = 1; row2 <= n; row2++)
            {
            for (col2 = n; col2 > row2; col2--)
            {
                Console.Write(" ");
            }
            for (inner_row = 0; inner_row < row2; inner_row++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            }
        }
    }
}
