using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Debit_Card : Card
    {
        Random rnd = new Random();
        private static int debitPrefix = 2400;

        public Debit_Card(string cardHolder) : base(cardHolder)
        {
            this.cardHolder = cardHolder;
        }

        public override string GenerateAccountNumber()
        {
            string accountNumber = "";
            for (int i = 0; i < 10; i++)
            {
                accountNumber += rnd.Next(0, 10);
            }
            return "3520" + accountNumber;
        }

        public override string GenerateCardNumber()
        {
            cardNumber = "";
            for (int i = 0; i < 12; i++)
            {
                cardNumber += rnd.Next(0, 10).ToString();
            }
            return debitPrefix + cardNumber;
        }

        public override string ToString()
        {
            return $"Name on card: {cardHolder} | Card Type: Debit | card number: {GenerateCardNumber()} | Account number:{GenerateAccountNumber()}\n";
        }
    }
}
