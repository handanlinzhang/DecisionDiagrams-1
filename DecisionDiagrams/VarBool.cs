﻿// <copyright file="VarBool.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace DecisionDiagrams
{
    /// <summary>
    /// Boolean variable type.
    /// </summary>
    /// <typeparam name="T">The node type.</typeparam>
    public class VarBool<T> : Variable<T>
        where T : IDDNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VarBool{T}"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <param name="indices">The variable indices.</param>
        /// <param name="prob">The variable indices.</param>
        internal VarBool(DDManager<T> manager, int[] indices, double prob)
            : base(manager, indices, VariableType.BOOL, (i) => i, prob)
        {
        }

        /// <summary>
        /// Identity function for a variable.
        /// </summary>
        /// <returns>The identify function.</returns>
        public DD Id()
        {
            return this.Manager.Id(this);
        }

        /// <summary>
        /// Identity function for a variable.
        /// </summary>
        /// <returns>The identify function.</returns>
        internal DDIndex IdIdx()
        {
            return this.Manager.IdIdx(this);
        }
    }
}
