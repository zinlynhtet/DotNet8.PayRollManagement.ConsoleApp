namespace DotNet8.PayRollManagement.ConsoleApp;

public static class DevCodes
{
    public static int ToInt(this object item)
    {
        return Convert.ToInt32(item);
    }

    public static double ToDouble(this object item)
    {
        return Convert.ToDouble(item);
    }
}
