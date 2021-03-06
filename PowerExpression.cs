﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class PowerExpression : BinaryExpression
    {
        public PowerExpression(Expression x, Expression y) : base(x, y) { }

        public override double Solve()
        {
            return Math.Pow(this.x.Solve(), this.y.Solve());
        }
    }
}
