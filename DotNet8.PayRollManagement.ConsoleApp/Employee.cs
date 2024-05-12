public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }
    public Employee(int id, string name, double hourlyRate, double hoursWorked)
    {
        Id = id;
        Name = name;
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public double CalculatePay()
    {
        if (HourlyRate < 0 || HoursWorked < 0)
            throw new InvalidOperationException("Hourly rate and hours worked must be non-negative.");

        return HourlyRate * HoursWorked;
    }
    
}

