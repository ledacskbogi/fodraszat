﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public interface ICreateInvoice
    {
        void Execute(string customerName);
    }
}
