using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Maestro : Card
    {
        Random rnd = new Random();
        private static int[] MaestroPrefix = { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };

        public Maestro(string cardHolder) : base(cardHolder)
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
            int randomIndex = rnd.Next(0, MaestroPrefix.Length);
            cardNumber = "";
            for (int i = 0; i < 12; i++)
            {
                cardNumber += rnd.Next(0, 10).ToString();
            }
            return MaestroPrefix[randomIndex].ToString() + cardNumber;

        }

        public override string ToString()
        {
            return $"Name on card: {cardHolder} | Card type: Meastro | card number: {GenerateCardNumber()} | Account number:{GenerateAccountNumber()}\n";
        }
    }
}
