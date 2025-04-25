using System;
using System.Windows.Forms;

namespace SDB.Classes.Misc
{
	public class NullableDateTimePicker : DateTimePicker
	{
		private bool _isNull;

		public new DateTime? Value
		{
			get => _isNull ? (DateTime?)null : base.Value;
			set
			{
				if (value == null)
				{
					if (_isNull == false)
					{
						_isNull = true;
					}
					Format = DateTimePickerFormat.Custom;
					CustomFormat = " ";
				}
				else
				{
					if (_isNull)
					{
						Format = DateTimePickerFormat.Custom;
						CustomFormat = "yyyy-MM-dd";
						_isNull = false;
					}
					base.Value = (DateTime)value;
				}
				base.OnValueChanged(new EventArgs());
			}
		}

		protected override void OnCloseUp(EventArgs eventargs)
		{
			if (MouseButtons == MouseButtons.None)
			{
				if (_isNull)
				{
					Format = DateTimePickerFormat.Custom;
					CustomFormat = "yyyy-MM-dd";
					_isNull = false;
				}
			}
			base.OnCloseUp(eventargs);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyCode != Keys.Delete) return;
			_isNull = true;
			Value = null;
			base.OnValueChanged(e);
		}
	}
}