﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class WrongRateInteretException:Exception
    {
       public  WrongRateInteretException (string message) : base(message) { }
    }
}
