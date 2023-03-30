using CustomRandomList;

public class StartUp

{
    static void Main(string[] args)
    {
        RandomList list = new RandomList();

        list.Add("Pesho");
        list.Add("Pesho2");
        list.Add("Pesho3");
        list.Add("Pesho4");
        list.Add("Pesho5");
        list.Add("Pesho6");
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
    }
}