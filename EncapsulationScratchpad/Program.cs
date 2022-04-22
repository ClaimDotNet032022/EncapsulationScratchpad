// See https://aka.ms/new-console-template for more information
using EncapsulationScratchpad;

Console.WriteLine("Hello, World!");


Dog rex = new Dog("Rex");
Dog spot = new Dog("Spot");

rex.Sit();
//rex.Run();
rex.IsRunning = true;
rex.PassTime();
rex.Eat();

Console.WriteLine("Done");