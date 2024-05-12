using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.PayRollManagement.ConsoleApp
{
    public static class DevCodes
    {
        public static int ToInt(this object item)
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double ToDouble(this object item)
        {
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
