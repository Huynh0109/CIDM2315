namespace HomeWork8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(110, "Alice", 28);
        cus1.PrintCusInfo();

        Customer cus2 = new Customer(111, "Bob", 30);
        cus2.PrintCusInfo();

        cus1.ChangeID(220);
        cus1.PrintCusInfo();

        cus2.ChangeID(221);
        cus2.PrintCusInfo();

        cus2.CompareAge(cus1);
    }
}

class Customer
{
    private int cus_id;
    public string cus_name { get; set; }
    public int cus_age { get; set; }
    public Customer (int Cus_id, string Cus_name, int Cus_age)
    {
        cus_name = Cus_name;
        cus_age = Cus_age;
        cus_id = Cus_id;
        this.cus_age = Cus_age;
    }
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }
    public void CompareAge(Customer objCustomer)
    {
        if(this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is younger");
        }
        else
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
    }
}
