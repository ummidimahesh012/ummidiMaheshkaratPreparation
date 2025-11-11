// See https://aka.ms/new-console-template for more information
//Console.WriteLine(Environment.OSVersion.VersionString);
using System;

interface IVehicle
{
    void StartEngine();
}
interface I2 {
    void StartEngine();
}

public class Program: IVehicle,I2
{
     void IVehicle.StartEngine()
    {
        Console.WriteLine("Engine started. Interface IVehicle implementation.");
    }
    void I2.StartEngine()
    {
        Console.WriteLine("Engine started. Interface I2 implementation.");
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
      ((IVehicle) p).StartEngine();
      ((I2) p).StartEngine();
        Console.WriteLine("welcome to c# programming");
    }
}
