using learning;
class Program
{
    static void Main(string[] args)
    {
        List<Appartment> residents = new List<Appartment>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Show all");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose pls the action: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("\nEnter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the age: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.Write("Enter nationality: ");
                        string nat = Console.ReadLine();

                        residents.Add(new Appartment(age, name, nat));
                        Console.WriteLine("Tenant added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Error! :=> the age should be a number.");
                    }
                    break;

                case "2":
                    Console.Write("\nEnter the tenant's name to delete: ");
                    string nameToRemove = Console.ReadLine();

                    Appartment residentToRemove = residents.Find(r => r.Name == nameToRemove);
                    if (residentToRemove != null)
                    {
                        residents.Remove(residentToRemove);
                        Console.WriteLine("Tenant deleted successfully! :)");
                    }
                    else
                    {
                        Console.WriteLine("A tenant with that name has not been found");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nlist of all tenants: ");
                    if (residents.Count == 0)
                    {
                        Console.WriteLine("Appartment is empty.");
                    }
                    else
                    {
                        foreach (var resident in residents)
                        {
                            resident.Info();
                        }
                    }
                    break;
                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("your choise is incorrect, try again pls");
                    break;
            }

            Console.WriteLine("\nPress on any button to continue...");
            Console.ReadKey();
        }
    }
}