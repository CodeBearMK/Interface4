using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface4
{
    internal class UStoNT:IExchange
    {
        private double rate;
        public double Rate
        {
            get { return 29.9; }
        }

        public void Convert()
        {
            Console.Write("請輸入要兌換的美元：");
            double USd = float.Parse(Console.ReadLine());
            double NTd = USd * Rate;
            Console.WriteLine("美元 {0}元,可兌換台幣 {1}元", USd, NTd.ToString("#.#"));
        }
    }
}
