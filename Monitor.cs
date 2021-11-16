using System;
using System.Collections.Generic;

namespace Comp
{
	class Monitor
	{
		private bool mShutdown;
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public byte ScreenSize { get; set; }
		public int RefreshRate { get; set; }
		public int Price { get; set; }
		public bool Modified { get; set; }

		public bool Shutdown
		{
			get { return mShutdown; }
			set
			{
				if (mShutdown = value)
				{
					this.mShutdown = value;
					this.Modified = true;
				}
				else
				{
					this.mShutdown = false;
					this.Modified = false;
				}
			}
		}
		public Monitor(string brand, string model, string color, byte screenSize, int refreshRate, int price)
		{
			Brand = brand;
			Model = model;
			Color = color;
			ScreenSize = screenSize;
			
			RefreshRate = refreshRate;
			Price = price;
		}
	}
}
