

using _10_InterfaceTests;
namespace _10_InterfaceTests;

public class UnitTest1
{
    [Fact]
    public void TesCalling_Interface_Methods()
    {
        //declaring a new interface instance
        // the type will be ifruit
        //we cannot new up interfaces
        //but we can make a new Banana()

        IFruit banana = new Banana();

        string output = banana.Peel();
        System.Console.WriteLine(output);

        System.Console.WriteLine("The banana is peeled" + banana.IsPeeled);

        Assert.True(banana.IsPeeled);

    }
    [Fact]
    public void Interface_Collections()
    {
        Orange orange = new Orange();

        List<IFruit> fruits = new List<IFruit>();={
        new Banana(),
        new Grape(),
        orange
        };
        foreach(IFruit fruit in fruits)
        {
            System.Console.WriteLine(fruit.Name);
            System.Console.WriteLine(fruit.Peel());
        }
        System.Console.WriteLine(orange.Squeeze());
        
    }
}