﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class MinusExpression : BinaryExpression
    {
        public MinusExpression(Expression x, Expression y) : base(x, y) { }

        public override double Solve()
        {
            return this.x.Solve() - this.y.Solve();
        }
    }
}
