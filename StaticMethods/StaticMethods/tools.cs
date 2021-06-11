using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    //creting a static class prevents an instance of it from being created
    static class tools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
