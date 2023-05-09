using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MasterCard ms = new MasterCard("Simon");
            Console.WriteLine(ms.ToString());

            Visa_DanKort vd = new Visa_DanKort("ddddddddddd");
            Console.WriteLine(vd.ToString());

            Visa_Electron ve = new Visa_Electron("dsadadasd");
            Console.WriteLine(ve.ToString());

            Maestro mae = new Maestro("klsdaklsdlas");
            Console.WriteLine(mae.ToString());

            Debit_Card dc = new Debit_Card("JKLAssdkjljsakd");
            Console.WriteLine(dc.ToString());

            Console.Read();
        }
    }
}
