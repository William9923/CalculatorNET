﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class DivideByZeroException : MathErrorException
    {
        private double dividend;

        public double getDivident()
        {
            return this.dividend;
        }
        public DivideByZeroException(double _dividend)
        {
            this.dividend = _dividend;
        }
        public override string errorMessage()
        {
            return ($"{this.dividend} is divided by zero\n"); ;
        }
    }
}
