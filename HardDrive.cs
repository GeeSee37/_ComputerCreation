using System;
using System.Collections.Generic;

namespace Comp
{
	public class HardDrive
	{
		public string Name { get; set; }
		public string Model { get; set; }
		public int Size { get; set; }
		public int Speed { get; set; }
		public int Price { get; set; }

		public HardDrive(string name, string model, int size, int speed, int price)   
		{
			Name = name;
			Model = model;                                                      
			Size = size;
			Speed = speed;
			Price = price;
		}
	}
}
