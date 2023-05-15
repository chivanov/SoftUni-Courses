using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;
using FoodShortage.Contracts;
using FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Core
{
    public class Engine
    {
        private List<IBuyer> repository;

        public Engine()
        {
            this.repository = new List<IBuyer>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            FillRepositoty(n);

            string input = Console.ReadLine();
            while (input != "End")
            {

                IBuyer newBuyer = BuyFood(input, repository);
                if (repository.Contains(newBuyer))
                {
                    newBuyer.BuyFood();
                }

                input = Console.ReadLine();
            }
           

            PrintFinalResult(repository);
        }

        private IBuyer BuyFood(string buyer, List<IBuyer> repository)
        {
            IBuyer currBuyer = repository.FirstOrDefault(cb => cb.Name == buyer);
            return currBuyer;
        }

        private void FillRepositoty(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] buyersInfo = Console.ReadLine().Split().ToArray();
                string name = buyersInfo[0];
                int age = int.Parse(buyersInfo[1]);
                
                IBuyer buyer = null;

                if (buyersInfo.Length == 3)
                {
                    string group = buyersInfo[2];
                    buyer = new Rebel(name, age, group);
                }
                else if (buyersInfo.Length == 4)
                {
                    string iD = buyersInfo[2];
                    string birthday = buyersInfo[3];
                    buyer = new Citizen(name, age, iD, birthday);
                }
                if (buyer != null)
                {
                    this.repository.Add(buyer);
                }
            }
        }

        private void PrintFinalResult(List<IBuyer> repository)
        {
            int totalFood = repository.Sum(buyer => buyer.Food);
            Console.WriteLine(totalFood);
        }


    }
}
