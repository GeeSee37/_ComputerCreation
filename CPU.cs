using System;
using System.Collections.Generic;

namespace Comp
{
	 class CPU
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Price { get; set; }
		public double Clockrate { get; set; }

		public CPU(string brand, string model, double clockrate, int price)   
		{
			Brand = brand;
			Model = model;
			Clockrate = clockrate;
			Price = price;
		}
	}
}
