using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTask
{
    internal class Card
    {
        public int PIN;
        public int Money;
        public string Number;

        public Card (int pin, int money, string number)
        {
            PIN = pin;
            Money = money;
            Number = number;
        }
    }
}
