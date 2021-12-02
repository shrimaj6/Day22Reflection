using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day22Reflection
{
    class UserRegistration
    {
        public static string First_nameuc1 = "^[A-Z]{3}";



        public bool checking(string name)
        {
            return Regex.IsMatch(name, First_nameuc1);
        }

    }
}
