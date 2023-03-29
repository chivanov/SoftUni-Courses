// See https://aka.ms/new-console-template for more information
using Farm;

public class StartUp
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();
    }
}