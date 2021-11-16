using System;
using System.Collections.Generic;

namespace Comp
{
	class PowerSuplyUnit
	{
		private int mWattage;
		public string Brand { get; set; }
		public string Model { get; set; }
		public string CoolingMethod { get; set; }
		public byte Temperature { get; set; }
		public bool ComputerSwitch { get; set; }

		public int Wattage
		{
			get { return mWattage; }
			set
			{
				if (value >= 0 && value <= 1500)
				{
					mWattage = value;
				}
				else
				{
					Console.WriteLine("Wrong Value");
				}
			}
		}
		public PowerSuplyUnit(string brand, string model, string coolingMethod, byte temperature, bool computerSwitch)
		{
			Brand = brand;
			Model = model;
			CoolingMethod = coolingMethod;
			Temperature = temperature;
			ComputerSwitch = computerSwitch;
		}
	}
}
