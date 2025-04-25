using System.Windows.Forms;

namespace SDB.Classes.Misc
{
	/// <summary>
	/// This class exists because a regular textbox fails to employ CTRL+_ key combinations properly
	/// when multi-line or readonly. (With some variability that is undetermined.)
	/// </summary>
	public class ClassFixedTextBox : TextBox
	{
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.A:
						SelectAll();
						break;
					case Keys.C:
						Copy();
						break;
					case Keys.V:
						Paste();
						break;
					case Keys.X:
						Cut();
						break;
					case Keys.Z:
						Undo();
						break;
				}
				e.SuppressKeyPress = true;
				e.Handled = true;
			}
			else
				base.OnKeyDown(e);
		}
	}
}
