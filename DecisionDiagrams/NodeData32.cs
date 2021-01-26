// <copyright file="NodeData16.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace DecisionDiagrams
{
    /// <summary>
    /// Common node metadata type for packing data together.
    /// </summary>
    internal struct NodeData32
    {
        /// <summary>
        /// The data as a packed 32-bit integer.
        /// </summary>
        private uint data;
        public double Prob;
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeData32"/> struct.
        /// </summary>
        /// <param name="variable">The variable id.</param>
        /// <param name="mark">The GC mark.</param>
        /// <param name="prob">The probability. </param>
        public NodeData32(int variable, bool mark, double prob)
        {
            this.data = unchecked((uint)variable);
            this.Prob = prob;
            this.Mark = mark;
        }

        /// <summary>
        /// Gets the variable id.
        /// </summary>
        public int Variable
        {
            get
            {
                return unchecked((int)(this.data & 0x7FFFFFFF));
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the GC mark bit is set.
        /// </summary>
        public bool Mark
        {
            get
            {
                return (this.data >> 31) == 1;
            }

            set
            {
                if (value)
                {
                    this.data |= 0x80000000;
                }
                else
                {
                    this.data &= 0x7FFFFFFF;
                }
            }
        }
    }
}
