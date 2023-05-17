using BirthdayCelebrations.Contracts;
using FoodShortage.Contracts;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
        }

        public string Id { get; set; }  

        public string Name { get; private set; }

        public int Age { get; private set; }
        public string Birthdate { get;  set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
