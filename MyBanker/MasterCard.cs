using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class MasterCard : Card, ICredit, MonthlyMax
    {
        Random rnd = new Random();
        private static int[] mastercardPrefix = { 51, 52, 53, 54, 55 };
        public decimal CreditLimit { get; } = 40000;
        public decimal MonthlyMax { get; } = 30000;
        public decimal DailyMax { get; set; } = 5000;

        public MasterCard(string cardHolder) : base(cardHolder)
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
            int randomIndex = rnd.Next(0, mastercardPrefix.Length);
            cardNumber = "";
            for (int i = 0; i < 14; i++)
            {
                cardNumber += rnd.Next(0, 10).ToString();
            }
            return mastercardPrefix[randomIndex].ToString() + cardNumber;
        }

        public override string ToString()
        {
            return $"Name on card: {cardHolder} | Card Type: Mastercard | card number: {GenerateCardNumber()} | Account number:{GenerateAccountNumber()}\n";
        }
    }
}
