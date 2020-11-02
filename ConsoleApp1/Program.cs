using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecisionDiagramTests;
using DecisionDiagrams;

namespace ConsoleApp1
{
    class Program
    {
        internal DD VarA { get; set; }

        /// <summary>
        /// Gets or sets var b.
        /// </summary>
        internal DD VarB { get; set; }
        static void Main(string[] args)
        {
            BddTests tt = new BddTests();
            tt.Initialize();
        }

    }
}
