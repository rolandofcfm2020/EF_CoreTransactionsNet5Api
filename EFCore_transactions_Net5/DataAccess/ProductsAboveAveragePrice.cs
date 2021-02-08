using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore_transactions_Net5.DataAccess
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
