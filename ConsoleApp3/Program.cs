using System;
using DecisionDiagrams;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {      
        static void Main(string[] args)
        {
            TestBDD testbdd = new TestBDD();
            testbdd.Initialize();
            testbdd.TestDisplay();
        }
    }
}
