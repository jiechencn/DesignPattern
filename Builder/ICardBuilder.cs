using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface ICardBuilder
    {
        public ICard Card { get; set; }
        public void BuildBlankCard();
        public void PrintName();
        public void PrintCardNumber();
        public void SetLimit();
        public void SetCharge();
    }
}
