﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class TestClass
    {
        public static void Method()
        {
            using (FileStream fileStream = new FileStream("c:\test", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
