using System;
using System.Collections.Generic;
using System.Text;

namespace CheckCards
{
    public class Card
    {
        public string Colour;
        public string Value;
        public int NumberValue;
        readonly public string Name;

        public Card(Colour Colour, Value Value)
        {
            this.Colour = Colour.ToString();
            this.Value = Value.ToString();
            this.NumberValue = Convert.ToInt32(Value);
            Name = Colour + "-" + Value;
        }
    }
}
