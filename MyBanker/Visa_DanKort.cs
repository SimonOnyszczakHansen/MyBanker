using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Visa_DanKort : Card, ICredit, MonthlyMax
    {
        Random rnd = new Random();
        string visaDankortPrefix = "4";
        public decimal CreditLimit { get; } = 20000;
        public decimal MonthlyMax { get; } = 25000;

        public Visa_DanKort(string cardHolder) : base(cardHolder)
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
            for (int i = 0; i < 15; i++)
            {
                cardNumber += rnd.Next(0, 10).ToString();
            }
            return  visaDankortPrefix + cardNumber;
        }

        public override string ToString()
        {
            return $"Name on card: {cardHolder} | Card Type: Visa Dancard | card number: {GenerateCardNumber()} | Account number:{GenerateAccountNumber()}\n";
        }
    }
}
