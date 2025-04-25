using System;
using System.Drawing;

namespace SDB.Classes.Tech
{
	public class ClassTech_Status
	{
		public int? Value { get; set; }
		public Color Color { get; set; }
		public string Description { get; set; }

		public override string ToString()
		{
			return Description;
		}
	}
}