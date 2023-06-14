using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banklibrary
{
    public class Class1
    {
        int bal = 1000;

        public string deposit( int amount)
        {
             bal = bal+ amount;
            return "Total Balance us " + bal.ToString();
        }
        
        public string withdrawl(int amount)
        {
            bal = bal - amount;
            return "Remaining Balance us " + bal.ToString();
        }
    }
}
