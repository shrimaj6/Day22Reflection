using System;
using System.Reflection;

namespace Day22Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                //for assembly
                Assembly assembly = typeof(int).Assembly;
                Console.WriteLine(assembly);

                Type hype = typeof(System.String);
                Console.WriteLine(hype.Assembly);


                //For method
                Type o = typeof(UserRegistration);
                MethodInfo[] mi = o.GetMethods(BindingFlags.Public | BindingFlags.Instance);

                foreach (MethodInfo m in mi)
                {
                    Console.WriteLine(m);

                }
            }
        }
    }
}

