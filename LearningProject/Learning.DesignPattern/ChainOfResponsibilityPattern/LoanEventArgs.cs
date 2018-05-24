﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ChainOfResponsibilityPattern
{
    public class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }
}
