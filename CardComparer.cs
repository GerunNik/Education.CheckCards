using System;
using System.Collections.Generic;
using System.Text;

namespace CheckCards
{
    class CardComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.NumberValue > y.NumberValue)
            {
                return 1;
            }
            else if (x.NumberValue == y.NumberValue)
            {
                return 0;
            }

            return -1;
        }
    }
}
