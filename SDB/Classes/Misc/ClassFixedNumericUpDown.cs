using System.Windows.Forms;

namespace SDB.Classes.Misc
{
	/// <summary>
	/// The base class has a problem in that when .ReadOnly the arrow up/down still functions and changes the value.
	/// This inherited class fixes that problem.
	/// </summary>
	public class ClassFixedNumericUpDown : NumericUpDown
	{
		public override void DownButton()
		{
			if (ReadOnly)
				return;
			base.DownButton();
		}

		public override void UpButton()
		{
			if (ReadOnly)
				return;
			base.UpButton();
		}
	}
}