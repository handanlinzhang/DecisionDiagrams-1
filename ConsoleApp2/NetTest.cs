using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecisionDiagrams;

namespace ConsoleApp2
{
    class NetTest
    {

        /// <summary>
        /// How many random inputs to generate per test.
        /// </summary>
        private static int numRandomTests = 400;

        /// <summary>
        /// Gets or sets the decision diagram factory.
        /// </summary>
        public IDDNodeFactory<BDDNode> Factory { get; set; }

        /// <summary>
        /// Gets or sets the manager.
        /// </summary>

        public DDManager<BDDNode> Manager { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether quantification is supported.
        /// </summary>
        public bool QuantifiersSupported { get; set; }

        /// <summary>
        /// Gets or sets var a.
        /// </summary>
        internal DD VarA { get; set; }

        /// <summary>
        /// Gets or sets var b.
        /// </summary>
        internal DD VarB { get; set; }

        /// <summary>
        /// Gets or sets va.
        /// </summary>
        internal VarBool<BDDNode> Va { get; set; }

        /// <summary>
        /// Gets or sets vb.
        /// </summary>
        internal VarBool<BDDNode> Vb { get; set; }

        public void TestNewFunction()
        {
            var dd = this.Manager.And(this.VarA, this.VarB);
            Console.WriteLine(this.Manager.Display(dd));
            Console.ReadKey();
        }

        public void Initialize()
        {        
            Factory = new BDDNodeFactory();

            Manager = new DDManager<BDDNode>(Factory, 16, gcMinCutoff: 4);
            QuantifiersSupported = true;

            this.Va = this.Manager.CreateBool();
            this.Vb = this.Manager.CreateBool();

            this.VarA = this.Manager.Id(this.Va);
            this.VarB = this.Manager.Id(this.Vb);
        }
    }
}
