using System;
using System.Collections.Generic;

namespace Comp
{
	class PeripheralDevice
	{
		public Keyboard keyboard { get; set; }
		public Monitor monitor { get; set; }
		public Mouse mouse { get; set; }

		public PeripheralDevice(Keyboard keyboard, Monitor monitor, Mouse mouse)
		{
			this.keyboard = keyboard;
			this.monitor = monitor;
			this.mouse = mouse;
		}
	}
}
