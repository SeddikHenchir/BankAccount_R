using System;
using System.Collections.Generic;

namespace BankAccountBL
{
    public class Account
    {
        public int Id { get; set; }
        public decimal balance { get; set; }
        public decimal decouvert { get; set; }
        public bool IsWithDecouvert { get; set; }

    }
}
