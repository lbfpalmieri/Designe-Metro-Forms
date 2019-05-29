﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDV_DESIGNE_BZ.Class
{
    class BankAccount
    {
        public string NumberAccount { get; set; }
        public string CPFHolder { get; set; }

        public BankAccount()
        {
        }

        public BankAccount(string numberAccount, string cPFHolder)
        {
            NumberAccount = numberAccount;
            CPFHolder = cPFHolder;
        }
    }
}
