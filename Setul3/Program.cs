using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the problem number: ");
            string problemNumber = Console.ReadLine();

            string className = $"Problema{problemNumber}";
            Type type = Type.GetType(className);

            if (type != null)
            {
                MethodInfo method = type.GetMethod("Solve");
                if (method != null)
                {
                    object instance = Activator.CreateInstance(type);
                    method.Invoke(instance, null);
                }
                else
                {
                    Console.WriteLine("Solve method not found for the specified problem.");
                }
            }
            else
            {
                Console.WriteLine("Problem class not found for the specified number.");
            }
        }
    }
}
