using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1_SE14028
{
    class Validation
    {
        public static string CheckEmpty()
        {
            string n;
            while (true)
            {
                try
                {
                    n = Console.ReadLine();
                    if (n == null || n == "")
                    {
                        Console.WriteLine("Cannot be Empty!");
                        Console.Write("Try Again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Try Again!");
                }
            }
            return n;
        }

        public static DateTime CheckDate()
        {
            DateTime n;
            while (true)
            {
                try
                {
                    n = Convert.ToDateTime(Console.ReadLine());
                    if (n == null)
                    {
                        Console.WriteLine("Cannot be Empty!");
                        Console.Write("Try Again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid Format(MM//DD/YYYY)");
                }
            }
            return n;
        }
        public static int CheckInput()
        {
            int n;
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 1 || n > 5)
                    {
                        Console.WriteLine("Choice range must be from 1 to 5");
                        Console.Write("Try Again: ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input Number Only !");
                }
            }
            return n;
        }
    }
}
