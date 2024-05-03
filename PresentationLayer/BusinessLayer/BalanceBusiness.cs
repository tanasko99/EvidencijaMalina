using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BalanceBusiness
    {
        private readonly BalanceRepository balanceRepository;

        public BalanceBusiness()
        {
            balanceRepository = new BalanceRepository();
        }

        public List<Balance> GetBalance()
        {
            return this.balanceRepository.GetBalance();
        }



    }
}