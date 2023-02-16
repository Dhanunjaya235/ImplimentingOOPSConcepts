using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public interface Bank
    {
        void Deposit(uint amount);

        void Withdraw(uint amount);

        void CheckBalance();

    }
}
