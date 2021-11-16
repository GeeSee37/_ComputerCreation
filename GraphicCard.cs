using System;
using System.Collections.Generic;

namespace Comp
{
	class GraphicCard
	{
		public string Name { get; set; }
		public string Model { get; set; }
		public string RamType { get; set; }
		public byte Memory { get; set; }
		public int Price { get; set; }

		public GraphicCard(string name, string model, string ramType, byte memory, int price) 
		{
			Name = name;
			Model = model;
			RamType = ramType;
			Memory = memory;
			Price = price;
		}
	}
}
