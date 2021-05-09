using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface ICardBuilder
    {

        public ICard Card { get; set; }
        public void BuildCard();
        public void PrintName();
        public void PrintCardNumber();
        public void SetLimit();
        public void SetCharge();

    }
}
