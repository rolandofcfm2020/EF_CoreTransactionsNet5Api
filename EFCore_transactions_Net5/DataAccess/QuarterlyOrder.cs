﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_transactions_Net5.DataAccess
{
    public partial class QuarterlyOrder
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
