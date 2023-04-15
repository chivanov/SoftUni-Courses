using PizzaCalories;

public class StartUp
{
    private static void Main(string[] args)
    {
        string[] inputPizza = Console.ReadLine().Split();
        string[] inputDough = Console.ReadLine().Split();

        string name = inputPizza[1];       

        //string type = inputDough[0];    
        string flourType = inputDough[1];    
        string bakingTechnique = inputDough[2];
        int weight = int.Parse(inputDough[3]);

        try
        {
            Dough dough = new Dough(flourType, bakingTechnique, weight);
            Pizza pizza = new Pizza(name, dough);

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] toppingInfo = input.Split();
                string toppingType = toppingInfo[1];
                int toppingWeight = int.Parse(toppingInfo[2]);

                Topping topping = new Topping(toppingType, toppingWeight);

                pizza.AddTopping(topping);

                input = Console.ReadLine();
            }
           

            Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}