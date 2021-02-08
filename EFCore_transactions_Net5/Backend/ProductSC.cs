using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_transactions_Net5.Backend
{
    public class ProductSC : BaseSC
    {
        public string ModifyProduct(int id)
        {
            var product = DataContext.Products.FirstOrDefault(f => f.ProductId == id);
            product.ProductName = "Chang";
            DataContext.SaveChanges();
            return product.ProductName;
        }
    }
}
