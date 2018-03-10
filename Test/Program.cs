using System;
using System.Collections.Generic;
using System.Linq;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int totalMoney = guests * 20;

            if (totalMoney < budget)
            {
                int remainingMoney = budget - totalMoney;
                double moneyForFireworks = remainingMoney - (remainingMoney * 0.40);
                double moneyForDonation = remainingMoney - moneyForFireworks;

                Console.WriteLine($"Yes! {moneyForFireworks:f0} lv are for fireworks and {moneyForDonation:f0} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {(totalMoney - budget):f0} lv more.");
            }
        }
    }
}
