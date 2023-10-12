using System;

namespace _08_Vehicle.Entity
{
    public class _08_Vehicle
    {

        //make a constructor
        public Vehicle()
        {
            //allocating space in memory for:
            L_Indicator = new Indicator();
            R_Indicator = new Indicator();
        }
        //make some properties (adj that describes the vehicle)
        public string? Make {get;set;}
        public string? Model {get;set;}
        public double? Mileage {get;set;}
        public bool IsRunning {get;private set;}
        
        public VehicleType VehicleType {get; set;}

        public Indicator L_Indicator {get;set;}
        public Indicator R_Indicator {get;set;}

        //make some methods...
        public void TurnOn()
    {
        IsRunning = true;
        System.Console.WriteLine("The Vehicle is turned on");
    }
    
    public void TurnOff()
    {
        IsRunning = false;
        System.Console.WriteLine("The vehicle is turned off");
    }

    public void IndicateRight()
    {
        R_Indicator.TurnOn();
        L_Indicator.TurnOff();
        System.Console.WriteLine("Turning Right");
    }
    public void IndicateLeft()
    {
        L_Indicator.TurnOn();
        R_Indicator.TurnOff();
        System.Console.WriteLine("Turning Left");
    }

    public void TurnOnHazzards()
    {
        L_Indicator.TurnOn();
        R_Indicator.TurnOn();
        for(int i = 0; i<5;i++)
        {
            Thread.Sleep(500);
            System.Console.WriteLine("HAZZARDS!!!");
        }
    }
    public void ClearIndicators()
    {
        L_Indicator.TurnOff();
        R_Indicator.TurnOff();
        System.Console.WriteLine("Cleared Indicators!!!");
        Console.ReadKey();
        Console.Clear();
    }
    }

}