using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface4
{
    internal class JPtoNT:IExchange
    {
        private double rate;
        public double Rate
        {
            get { return 0.375; }
        }
        public void Convert()
        {
            Console.Write("請輸入要兌換的日幣：");
            double JPd = float.Parse(Console.ReadLine());
            double NTd = JPd * Rate;
            Console.WriteLine("日幣 {0}元,可兌換台幣 {1}元", JPd, NTd.ToString("#.#"));
        }
    }
}
