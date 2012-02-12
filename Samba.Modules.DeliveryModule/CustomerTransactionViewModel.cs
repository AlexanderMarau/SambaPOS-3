﻿using System;

namespace Samba.Modules.DeliveryModule
{
    public class CustomerTransactionViewModel
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Receivable { get; set; }
        public decimal Liability { get; set; }
        public decimal Balance { get; set; }
    }
}