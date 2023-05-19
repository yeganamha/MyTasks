using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Card
    {
        public int Code { get; set; }
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



    }
}
