namespace HomeWork6;

class Program
{
    static void Main(string[] args)
    {
        Professor p = new Professor("Alice", "Java", 9000);
        Console.WriteLine($"Professor {p.profName} teaches {p.classTeach}, and the salary is: {p.GetSalary()}");

        Professor p2 = new Professor("Bob", "Math", 8000);
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach}, and the salary is: {p2.GetSalary()}");

        Student s = new Student("Lisa", "Java", 90);
        Console.WriteLine($"Student {s.studentName} enrolls {s.classEnroll}, and the grade is: {s.GetGrade()}");

        Student s2 = new Student("Tom", "Math", 80);
        Console.WriteLine($"Student {s2.studentName} enrolls {s2.classEnroll}, and the grade is: {s2.GetGrade()}");


        double difference = p.GetSalary() - p2.GetSalary();
        Console.WriteLine($"The salary difference between Alice and Bob is: {difference}");

        double totalGrade = s.GetGrade() + s2.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");

    }
}

class Professor
{
    public string profName { get; set; }
    public string classTeach {get; set; }
    private double salary;
    public Professor(string name, string course, double Salary)
    {
        profName = name;
        classTeach = course;
        salary = Salary;
    }
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }

}

class Student
{
    public string studentName { get; set; }
    public string classEnroll { get; set; }
    private double studentGrade;
    public Student (string name, string course, double Grade)
    {
        studentName = name;
        classEnroll = course;
        studentGrade = Grade;
    }
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double GetGrade()
    {
        return studentGrade;
    }
}
