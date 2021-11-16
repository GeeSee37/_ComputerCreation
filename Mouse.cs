using System;
using System.Collections.Generic;

namespace Comp
{
	class Mouse
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public string Sensor { get; set; }
		public byte Weight { get; set; }
		public int Price { get; set; }

		public Mouse(string brand, string model, string color, string sensor, byte weight, int price)
		{
			Brand = brand;
			Model = model;
			Color = color;
			Sensor = sensor;
			Weight = weight;
			Price = price;
		}
	}
}
