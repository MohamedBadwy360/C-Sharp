namespace PracticalUseCaseOnInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "John Doe", 200, 1000);
            Maintainance maintainance = new Maintainance(2, "Jane Doe", 160, 800);
            Sales sales = new Sales(3, "John Smith", 180, 900, 0.05m, 10000);
            Developer developer = new Developer(4, "Jane Smith", 200, 1200, true);


            //Console.WriteLine("\n------------- manager --------------");
            //Console.WriteLine(manager);
            //Console.WriteLine("\n------------- maintainance --------------");
            //Console.WriteLine(maintainance);
            //Console.WriteLine("\n------------- sales --------------");
            //Console.WriteLine(sales);
            //Console.WriteLine("\n------------- developer --------------");
            //Console.WriteLine(developer);

            Employee[] employees = { manager, maintainance, sales, developer };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
