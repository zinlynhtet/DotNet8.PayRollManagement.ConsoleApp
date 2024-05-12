
using DotNet8.PayRollManagement.ConsoleApp;

var employees = new List<Employee>()
        {
            new Employee(1, "Doe", 25.50, 40),
            new Employee(2, "Smith", 22.75, 38),
            new Employee(3, "Johnson", 30.00, 45),
            new Employee(4, "Williams", 27.80, 42),
            new Employee(5, "Brown", 20.00, 37),
            new Employee(6, "Jones", 28.60, 41),
            new Employee(7, "Garcia", 26.25, 39),
            new Employee(8, "Martinez", 24.75, 36),
            new Employee(9, "Davis", 29.40, 43),
            new Employee(10, "Rodriguez", 23.20, 34)
        };
MainMenu();
void MainMenu()
{
    Console.WriteLine("PayRoll Management System.");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. Employee Details");
    Console.WriteLine("3. Calculate PayRoll");
    Console.WriteLine("4. Exit the Program");

    int input = Console.ReadLine()!.ToInt();
    switch (input)
    {
        case 1:
            AddEmployee();
            break;
        case 2:
            ViewList();
            break;
        default:
            Console.WriteLine("Invalid option. Please select a valid option.");
            MainMenu();
            break;
    }
}


void AddEmployee()
{
    Console.WriteLine(value: "Enter Employee Information");
    Console.Write(value: "ID: ");
    int id = Console.ReadLine()!.ToInt();

    Console.Write(value: "Name: ");
    string name = Console.ReadLine()!;

    Console.Write(value: "Hourly Rate: ");
    double hourlyRate = Console.ReadLine()!.ToDouble();

    var employee = new Employee(id, name, hourlyRate, 0);
    employees.Add(employee);

    Console.WriteLine("Employee added successfully.");
    MainMenu();
}

void ViewList()
{
    if (employees.Count == 0) Console.WriteLine("No Data Found.");
    else Console.WriteLine("Lists");
    foreach (Employee employee in employees)
    {
        Console.WriteLine($"Id : {employee.Id}," +
            $" Name : {employee.Name}," +
            $" HourlyRate : {employee.HourlyRate}");
    }
    MainMenu();
}