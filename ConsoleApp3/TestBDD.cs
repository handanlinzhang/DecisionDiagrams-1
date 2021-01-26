using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecisionDiagrams;

namespace ConsoleApp3
{
    class TestBDD : Test<BDDNode>
    {
        /// <summary>
        /// Initialize the test class.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this.Factory = new BDDNodeFactory();
            this.Manager = new DDManager<BDDNode>(this.Factory, 16, gcMinCutoff: 4);
            this.QuantifiersSupported = true;
            this.BaseInitialize();
        }

        /// <summary>
        /// Test conversion to a string.
        /// </summary>
        [TestMethod]
        public void TestDisplay()
        {
            var dd = this.Manager.Not(this.Manager.And(this.VarA, this.VarB));
            Assert.AreEqual(this.Manager.Display(dd), "(0 ? (1 ? false : true) : true)");
        }
    }
}
