namespace Interface4
{
    class Program
    {
        static void Main(string[] args)
        {
            IExchange change;
            UStoNT cashUS = new UStoNT();
            JPtoNT cashJP = new JPtoNT();
            while (true)
            {
                Console.Write("選擇要兌換台幣的外幣? (1.美元　2.日幣　3.離開)");
                int item = int.Parse(Console.ReadLine());
                if (item == 1)
                {
                    change = cashUS;
                }
                else if (item == 2)
                {
                    change = cashJP;
                }
                else
                {
                    break;
                }
                change.Convert();
                Console.WriteLine();
            }
        }
    }
}