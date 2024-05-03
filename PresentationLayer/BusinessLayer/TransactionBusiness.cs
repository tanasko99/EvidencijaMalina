using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TransactionBusiness
    {
        private readonly TransactionRepository transactionRepository;
        public TransactionBusiness()
        {
            this.transactionRepository = new TransactionRepository();
        }

        public bool InsertTransaction(Transaction s)
        {
            if (this.transactionRepository.InsertTransaction(s) > 0)
                return true;
            else
                return false;
        }

        public List<Transaction> GetAllTransactions()
        {
            return this.transactionRepository.GetAllTransactions();
        }
    }
}