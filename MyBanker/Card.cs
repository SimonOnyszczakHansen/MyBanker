using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        protected string cardHolder;
        protected string cardNumber;
        protected string accountNumber;
        protected DateTime ExpireDate;
        protected int[] prefix; 

        public Card(string cardHolder)
        {
            this.cardHolder = cardHolder;
        }

        public abstract string GenerateCardNumber();

        public abstract string GenerateAccountNumber();

        public abstract string ToString();
    }
}
