using System;
using System.Collections.Generic;

namespace Comp
{
	class Computer
	{
		public Motherboard motherboard { get; set; }
		public PeripheralDevice peripheralDevice { get; set; }

		public Computer(Motherboard motherboard, PeripheralDevice peripheralDevice)
		{
			this.motherboard = motherboard;
			this.peripheralDevice = peripheralDevice;
		}

		public void CheckStatus()
		{
			if (motherboard.powerSuplyUnit.ComputerSwitch == true)
			{
				Console.WriteLine("Computer is ON");
			}
			else
			{
				Console.WriteLine("Computer is OFF");
			}

			motherboard.CheckTemperature();
		}
		
	}
}