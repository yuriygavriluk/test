﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            TestClass.Method();

            Console.WriteLine("Changes in master branch");
            Console.WriteLine("Changes from another place");
        }
    }
}
