using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SDB.UserControls.General
{
	public partial class ucHourMaskPicker : UserControl
	{
		private int _hourMask;
		private bool _readOnly;
		
		public int HourMask
		{
			get => _hourMask;
			set
			{
				_hourMask = value;
				foreach (Label l in _maskLabels)
					SelectHourLabel(l, (_hourMask & (int)Math.Pow(2, 23 - Convert.ToInt32(l.Tag))) > 0);
			}
		}

		[Description("Whether the hour mask is shown as a read-only control."), Category("Behavior")] 
		public bool IsReadOnly
		{
			get => _readOnly;
			set
			{
				_readOnly = value;
				if (_readOnly)
				{
					btnToggleAll.Visible = false;
					lblInstructions.Text = "Hours during which the sign is blacked out.";
				}
				else
				{
					btnToggleAll.Visible = true;
					lblInstructions.Text = "Select hours during which the sign is blacked out.";
				}
			}
		}

		private readonly Label[] _maskLabels;
		private bool _isToggledOn;

		public ucHourMaskPicker()
		{
			InitializeComponent();
			_maskLabels = new[] { lbl00, lbl01, lbl02, lbl03, lbl04, lbl05, lbl06, lbl07, lbl08, lbl09, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23 };
		}

		private void lblHour_Click(object sender, EventArgs e)
		{
			if (_readOnly)
				return;

			SelectHourLabel((Label)sender, null);
		}

		private void btnToggleAll_Click(object sender, EventArgs e)
		{
			if (_readOnly)
				return;

			_isToggledOn = !_isToggledOn;
			foreach (Label l in _maskLabels)
				SelectHourLabel(l, _isToggledOn);
			_hourMask = _isToggledOn ? (int)Math.Pow(2, 24) - 1 : 0;
		}

		/// <summary>
		/// Selects specified hour label and updates the hour mask. If <paramref name="selected"/> is not specified, the label is toggled from its current state.
		/// </summary>
		/// <param name="l">The hour label to select/deselect/toggle.</param>
		/// <param name="selected">True to select, false to deselect, null to toggle.</param>
		private void SelectHourLabel(Control l, bool? selected)
		{
			if (!(l is Label))
				throw new ArgumentException("Control must be a label.");

			int maskValue = (int)Math.Pow(2, 23 - Convert.ToInt32(l.Tag));
			bool select = selected.HasValue ? selected.Value : ((_hourMask & maskValue) == 0);
			_hourMask = select ? (_hourMask | maskValue) : (_hourMask & ~maskValue);
			l.ForeColor = select ? Color.White : SystemColors.ControlText;
			l.BackColor = select ? Color.Black : SystemColors.Control;
		}

		public void Clear()
		{
			HourMask = 0;
		}
	}
}