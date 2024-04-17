using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
       Bird bird = new Bird("13","21","Bird Violet");
       bird.PrintInfo();

    }
}

public abstract class Animal 
{
    protected string Weight {get;set;}
    protected string Heigh{get;set;}
    
    public Animal(string Weight,string Heigh)
    {
        this.Weight = Weight;
        this.Heigh = Heigh;
    }

    public abstract void PrintInfo();
}

public class Bird : Animal
{
    private string Name{get;set;}

    public Bird(string Weight,string Heigh,string Name) : base(Weight,Heigh )
    {
           this.Name = Name;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Bird have : \n" + "Weight = " + this.Weight + "\n" + "Height = " + this.Heigh + "\n" + "Name = " + this.Name );
    }
}


