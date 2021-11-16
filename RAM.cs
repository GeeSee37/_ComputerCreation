using System;
using System.Collections.Generic;

namespace Comp
{
	 class MemoryStick
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public byte Size { get; set; }
		public int Speed { get; set; }
		public int Price { get; set; }

		public MemoryStick(string brand, string model, byte size, int speed, int price)   
		{
			Brand = brand;
			Model = model;
			Size = size;
			Speed = speed;
			Price = price;
		}
	}
}
