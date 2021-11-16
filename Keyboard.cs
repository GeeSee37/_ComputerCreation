using System;
using System.Collections.Generic;

namespace Comp
{
	class Keyboard
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public string SwitchType { get; set; }
		public int Price { get; set; }

		public Keyboard(string brand, string model, string color, string switchType, int price)
		{
			Brand = brand;
			Model = model;
			Color = color;
			SwitchType = switchType;
			Price = price;
		}
	}
}
