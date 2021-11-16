using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Comp
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = DateTime.Now.ToString();
			Console.WriteLine(a);
			Console.WriteLine("");

			CPU cpu = new CPU("Intel", "Z200", 2.5, 1500);
			GraphicCard graphicCard = new GraphicCard("GeForce", "GTX1660", "GDDR6", 8, 2500);
			MemoryStick memoryStick = new MemoryStick("GoodRAM", "Ultra", 64, 3600, 1000);
			PowerSuplyUnit powerSuplyUnit = new PowerSuplyUnit("BeQuiet!", "Z550", "Air", 100, true);
			powerSuplyUnit.Wattage = 1200;
			HardDrive hardDrive = new HardDrive("Samsung", "Evo 4", 1024, 15000, 5000);

			Mouse mouse = new Mouse("Zowie", "EC2B", "Black", "PIXEL 3900", 13, 210);
			Keyboard keyboard = new Keyboard("HyperX", "Alloy", "Black", "Red Cherry", 2000);
			Monitor monitor = new Monitor("Zowie", "XL2430", "Black", 24, 144, 1200);
			monitor.Shutdown = false;

			PeripheralDevice peripheralDevice = new PeripheralDevice(keyboard, monitor, mouse);
			Motherboard motherboard = new Motherboard(cpu, graphicCard, memoryStick, hardDrive, powerSuplyUnit);
Computer computer = new Computer(motherboard, peripheralDevice);

			Console.WriteLine($"Graphic Card Name: { motherboard.graphicCard.Model}");
			Console.WriteLine($"PSU temperature is: {motherboard.powerSuplyUnit.Temperature} degrees");

			computer.CheckStatus();

			Console.ReadKey();
		}
	}
}

