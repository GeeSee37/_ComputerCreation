using System;
using System.Collections.Generic;

namespace Comp
{
	class Motherboard
	{
		public CPU cpu { get; set; }
		public GraphicCard graphicCard { get; set; }
		public MemoryStick memoryStick { get; set; }
		public HardDrive hardDrive { get; set; }
		public PowerSuplyUnit powerSuplyUnit { get; set; }

		public Motherboard(CPU cpu, GraphicCard graphicCard, MemoryStick memoryStick, HardDrive hardDrive, PowerSuplyUnit powerSuplyUnit)
		{
			this.cpu = cpu;
			this.graphicCard = graphicCard;
			this.memoryStick = memoryStick;
			this.hardDrive = hardDrive;
			this.powerSuplyUnit = powerSuplyUnit;
		}
		public void CheckTemperature()
		{
			if (powerSuplyUnit.Temperature >= 100)
			{
				Console.WriteLine("Temperature too high!");
			}
			else
			{
				Console.WriteLine("Temperature is ok!");
			}
		}
	}
}
