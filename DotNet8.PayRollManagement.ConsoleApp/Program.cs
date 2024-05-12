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
    Console.WriteLine("2. View Employee Details");
    Console.WriteLine("3. Calculate PayRoll");
    Console.WriteLine("4. Find Employee");
    Console.WriteLine("5. Update Hours and Calculate PayRoll");
    Console.WriteLine("6. Exit the Program");

    var input = Console.ReadLine()!.ToInt();
    switch (input)
    {
        case 1:
            AddEmployee();
            break;
        case 2:
            ViewList();
            break;
        case 3:
            CalculatePayRoll();
            break;
        case 4:
            FindEmployee();
            break;
        case 5:
            UpdateHoursAndCalculatePayroll();
            break;
        case 6:
            Environment.Exit(0);
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
    var id = Console.ReadLine()!.ToInt();

    Console.Write(value: "Name: ");
    var name = Console.ReadLine()!;

    Console.Write(value: "Hourly Rate: ");
    var hourlyRate = Console.ReadLine()!.ToDouble();

    var employee = new Employee(id, name, hourlyRate, 0);
    employees.Add(employee);

    Console.WriteLine("Employee added successfully.");
    MainMenu();
}

void ViewList()
{
    Console.WriteLine(employees.Count == 0 ? "No Data Found." : "Lists");
    foreach (var employee in employees)
    {
        Console.WriteLine($"Id : {employee.Id}," +
                          $" Name : {employee.Name}," +
                          $" HourlyRate : {employee.HourlyRate}");
    }

    MainMenu();
}

void CalculatePayRoll()
{
    if (employees.Count == 0)
    {
        Console.WriteLine("No Data Found.");
        MainMenu();
        return;
    }

    foreach (Employee employee in employees)
    {
        Console.Write($"Enter Worked Hours for {employee.Name}: ");
        employee.HoursWorked = Console.ReadLine()!.ToDouble();
    }

    var headers = new[]
    {
        new ColumnHeader("ID"),
        new ColumnHeader("Name"),
        new ColumnHeader("Hourly Rate", Alignment.Right),
        new ColumnHeader("Hours Worked", Alignment.Right),
        new ColumnHeader("Total Pay", Alignment.Right),
    };

    var table = new Table(headers)
    {
        Config = TableConfiguration.UnicodeAlt()
    };
    double totalAmount = 0;

    foreach (Employee employee in employees)
    {
        double totalPay = employee.CalculatePay();
        totalAmount += totalPay;
        table.AddRow(employee.Id, employee.Name, employee.HourlyRate, employee.HoursWorked, totalPay);
    }

    table.AddRow("", "", "", "Total : ", "$ " + totalAmount);
    Console.WriteLine(table.ToString());
    MainMenu();
}

void FindEmployee()
{
    Console.Write("Enter Employee ID: ");
    var id = Console.ReadLine()!.ToInt();
    var item = employees.FirstOrDefault(e => e.Id == id)!;
    if (item is null)
    {
        Console.WriteLine("Employee not found.");
    }

    Console.WriteLine("Employee Found:");
    Console.WriteLine($"ID: {item!.Id}");
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"Hourly Rate: {item.HourlyRate}");
    Console.WriteLine($"Hours Worked: {item.HoursWorked}");
    Console.WriteLine($"Total Pay: {item.CalculatePay()}$");
    MainMenu();
}

void UpdateHoursAndCalculatePayroll()
{
    Console.Write("Enter Employee ID: ");
    var id = Console.ReadLine()!.ToInt();
    var employee = employees.FirstOrDefault(e => e.Id == id)!;
    if (employee is null)
    {
        Console.WriteLine("Employee not found.");
    }

    Console.Write($"Enter Worked Hours for {employee!.Name}: ");
    var hoursWorked = Console.ReadLine()!.ToDouble();
    employee.HoursWorked = hoursWorked;

    Console.WriteLine($"Total Pay for {employee.Name}: {employee.CalculatePay()}$");

    MainMenu();
}