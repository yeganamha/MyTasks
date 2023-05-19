using System;

namespace Tasks

{

    internal class Card
    {
        public long Code { get; set; }
        public int CVV { get; set; }
        public string ValidDate { get; set; }
        public string FullName { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public void Medaxil(decimal money)
        {
            if (money <= 0)
                return;
            Balance += money;
        }

        public void Mexaric(decimal money)
        {
            Balance -= money;
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Card MyCard = new Card();

                MyCard.Code = 456874563214;
                MyCard.CVV = 346;
                MyCard.ValidDate = "30.05.2024";
                MyCard.FullName = "Yegana Hasanova";
                MyCard.Bank = "KapitalBank";
                MyCard.Balance = 120.5m;
                MyCard.Medaxil(100);
                MyCard.Mexaric(20.5m);

                Console.WriteLine($" Card Card owner is {MyCard.FullName}");
                Console.WriteLine($" Bank is {MyCard.Bank}");
                Console.WriteLine($"Your CVV Code is {MyCard.CVV}");
                Console.WriteLine($"Your  Valid Date of card is {MyCard.ValidDate}");
                Console.WriteLine($"Your balance is {MyCard.Balance} AZN");




            }
        }
    }
}