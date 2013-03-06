using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankModelDemo
{
    public interface AccountActions
    {
       void DepositMoney(double sum);
       double CalculateInterest(int months);
    }
}
