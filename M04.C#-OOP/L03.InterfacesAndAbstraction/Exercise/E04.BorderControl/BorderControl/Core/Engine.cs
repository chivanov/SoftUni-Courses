using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Core
{
    public class Engine
    {
        private List<IIdentifiable> repository;

        public Engine()
        {
            this.repository = new List<IIdentifiable>();
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputTokens = input.Split().ToArray();
                CreateIdentifiable(inputTokens);

                input = Console.ReadLine();
            }
            string fakeId = Console.ReadLine();
            string[] fakeIds = repository.Where(i=>i.Id.EndsWith(fakeId)).Select(i=>i.Id).ToArray();

            PrintFinalResult(fakeIds);
        }

        private void PrintFinalResult(string[] fakeIds)
        {
            foreach(var fakeId in fakeIds)
            {
                Console.WriteLine(fakeId);
            }
        }

        private void CreateIdentifiable(string[] inputTokens)
        {
            IIdentifiable identifiable;
            if (inputTokens.Length == 3)
            {
                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);
                string id = inputTokens[2];

                identifiable = new Citizen(name, age, id);
            }
            else
            {
                string model = inputTokens[0];
                string id = inputTokens[1];

                identifiable = new Robot(model, id);
            }
            this.repository.Add(identifiable);
        }
    }
}
