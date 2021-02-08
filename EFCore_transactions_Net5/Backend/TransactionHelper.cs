using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_transactions_Net5.Backend
{
    public class TransactionHelper : BaseSC
    {
        //https://docs.microsoft.com/en-us/ef/ef6/saving/transactions
        public void RunVoidTransaction(Action actionDB)
        {


            using (var con = DataContext)
            {
                using (var transaction = con.Database.BeginTransaction())
                {
                    try
                    {
                        actionDB();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        throw new Exception(ex.Message);
                    }
                }
            }

        }

        public object RunTransaction(Func<object> function)
        {
            using (var transactionContext = DataContext)
            {
                using (var db_transactionContext = transactionContext.Database.BeginTransaction())
                {
                    try
                    {
                        var result = function();
                        db_transactionContext.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {

                        db_transactionContext.Rollback();
                        throw new Exception(ex.Message);
                    }
                }

            }
        }

    }
}
