using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fan_Class
{
	public class Fan
	{
		const int FAST = 3;
		const int MEDIUM = 2;
		const int SLOW = 1;

		private int speed { get; set; }
		private bool on { get; set; }
        private string color { get; set; }
        private double radius { get; set; }

        public Fan()
		{
			this.speed = SLOW;
			this.on = false;
			this.color = "Blue";
			this.radius = 5;
		}
        public Fan(int speed, bool on, string color, double radius)
        {
            this.speed = speed;
            this.on = on;
            this.color = color;
            this.radius = radius;
        }

		public void turnOn()
		{
			this.on = true;
		}

		public void turnOff()
		{
			this.on = false;
		}

		public void setSpeed(int speed_Manual)
		{

				if (speed_Manual == 1) this.speed = SLOW;
				if (speed_Manual == 2) this.speed = MEDIUM;
				if (speed_Manual == 3) this.speed = FAST;
        }

		public void setColor(string color_Manual)
		{
			this.color = color_Manual;
		}

		public void setRadius(int radius_Manual)
		{
			this.radius = radius_Manual;
		}

		public void toString()
		{
			if (this.on)
			{
				Console.WriteLine("State: on");
				Console.WriteLine("Speed: " + this.speed);
			}
			else
				Console.WriteLine("State: off");

			Console.WriteLine("Color: " + this.color);
			Console.WriteLine("Radius: " + this.radius);
			Console.WriteLine();
		}
	}
}

