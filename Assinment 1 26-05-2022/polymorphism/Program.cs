using System;
namespace Polymorphism
{
    class Program
    {
        public static void Main()
        {

            string a = Console.ReadLine();
            double rj;
            Usd r = new Usd();
            Data = 12;
            r.convert();
        }
    }
}
abstract class convertCurrency
{
    public abstract double convert();

}
class Usd : convertCurrency
{
    private double input;
    public double Data  // property

    {
        get
        {
            return this.input;
        }
        set
        {
            this.input = value;
        }

    }
    public override double convert()
    {
        return input * 76;
    }

}
class inr : convertCurrency
{
    private double input;
    public double data  
    {
     
        get
        {
            return this.input;
        }
        set
        {
            this.input = value;
        } 
    }
    public override double convert()
    {
        return input * 1.00;
    }

}
class pound : convertCurrency
{
    private double input;
    public double data 
    {
         get
        {
            return this.input;
        }
        set
        {
            this.input = value;
        }
    }
    public override double convert()
    {
        return input * 97.42;
    }
}