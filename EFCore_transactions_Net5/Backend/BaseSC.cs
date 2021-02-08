using EFCore_transactions_Net5.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_transactions_Net5.Backend
{
    public class BaseSC
    {
        public NORTHWNDContext DataContext = new NORTHWNDContext();

    
    }
}
