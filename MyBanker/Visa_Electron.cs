using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Visa_Electron : Card, MonthlyMax
    {
        Random rnd = new Random();
        private static int[] visaElectronPrefix = { 4026, 417500, 4508, 4844,4913, 4917 };
        public decimal MonthlyMax { get; } = 10000;

        public Visa_Electron(string cardHolder) : base(cardHolder)
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
            int randomIndex = rnd.Next(0, visaElectronPrefix.Length);
            cardNumber = "";
            if (visaElectronPrefix[randomIndex] == 417500)
            {
                for (int i = 0; i < 10; i++)
                {
                    cardNumber += rnd.Next(0, 10).ToString();
                }
                return visaElectronPrefix[randomIndex].ToString() + cardNumber;
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    cardNumber += rnd.Next(0, 10).ToString();
                }
                return visaElectronPrefix[randomIndex].ToString() + cardNumber;
            }
        }

        public override string ToString()
        {
            return $"Name on card: {cardHolder} | Card type: Visa Electron | card number: {GenerateCardNumber()} | Account number:{GenerateAccountNumber()}\n";
        }
    }
}
