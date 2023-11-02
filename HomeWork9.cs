namespace HomeWork9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);


        if(!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        double sum = 0;
        foreach(var gpa in gradebook.Values)
        {
            sum += gpa;
        }
        
        double averageGPA = sum / gradebook.Count;
        Console.WriteLine($"The average GPA is: {averageGPA}");

        alice.PrintInfo();
        bob.PrintInfo();
    }
}

class Student
{
    private int studentID { get; set; }
    private string studentName { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public static List<Student> studentList = new List<Student>();
    public Student(int ID, string StuName)
    {
        studentName = StuName;
        studentID = ID;
        studentList.Add(this);
    }
}
