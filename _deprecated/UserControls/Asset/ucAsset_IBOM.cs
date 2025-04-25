using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Misc;
using SDB.Forms.Assembly;

namespace SDB.UserControls.Asset
{
	public partial class ucAsset_IBOM : UserControl
	{
		private ClassAsset.ClassIbom _ibom = new ClassAsset.ClassIbom();

		public ClassAsset.ClassIbom IBOM
		{
			get
			{
				UpdateObjectFromControls();
				return _ibom;
			}
			set
			{
				_ibom = value;
				if (_ibom == null)
					Clear();
				else
					Populate();
			}
		}

		public ucAsset_IBOM()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clears all values in the IBOM.
		/// </summary>
		public void Clear()
		{
			foreach (var t in pnlIBOM.Controls.OfType<Panel>().SelectMany(p => p.Controls.OfType<TextBox>()))
				t.Clear();

			foreach (var n in pnlIBOM.Controls.OfType<Panel>().SelectMany(p => p.Controls.OfType<ClassFixedNumericUpDown>()))
				n.Value = 5M;
		}

		/// <summary>
		/// Locks or unlocks the IBOM for editing.
		/// </summary>
		public void LockControls(bool isLocked)
		{
			foreach (var t in pnlIBOM.Controls.OfType<Panel>().SelectMany(p => p.Controls.OfType<TextBox>()))
				t.ReadOnly = isLocked;

			foreach (var n in pnlIBOM.Controls.OfType<Panel>().SelectMany(p => p.Controls.OfType<ClassFixedNumericUpDown>()))
				n.ReadOnly = isLocked;

			foreach (var b in pnlIBOM.Controls.OfType<Panel>().SelectMany(p => p.Controls.OfType<Button>()))
				b.Enabled = !isLocked;
		}

		private void Populate()
		{
			if (_ibom == null)
				return;

			txtLED_JobNum.Text = _ibom.LED_JobNumber;
			txtLED_Assy.Text = _ibom.LED_Assembly;
			txtLED_Calibration.Text = _ibom.LED_Calibration;

			txtPS_Assy.Text = _ibom.PS_Assembly;
			numPS_Voltages_Red.Value = _ibom.PS_RedVoltage;
			numPS_Voltages_Green.Value = _ibom.PS_GreenVoltage;
			numPS_Voltages_Blue.Value = _ibom.PS_BlueVoltage;
			numPS_Voltages_Logic.Value = _ibom.PS_LogicVoltage;

			txtInterfaces_EpromType.Text = _ibom.Interface_EpromType;
			txtInterfaces_EpromFirmwareVersion.Text = _ibom.Interface_EpromVersion;
			if (_ibom.Interface_Assembly_ID.HasValue)
			{
				ClassAssembly interfaceAssembly = ClassAssembly.GetByID(_ibom.Interface_Assembly_ID.Value);
				txtInterfaces_InterfaceAssembly.Text = interfaceAssembly.DisplayMember; // ClassAssembly.GetByID(_ibom.Interface_Assembly_ID.Value).Description;
				txtInterfaces_InterfaceAssembly.Tag = (int?)_ibom.Interface_Assembly_ID.Value;
			}
			else
			{
				txtInterfaces_InterfaceAssembly.Clear();
				txtInterfaces_InterfaceAssembly.Tag = null;
			}
		}

		private void UpdateObjectFromControls()
		{
			_ibom.LED_JobNumber = txtLED_JobNum.Text.Trim();
			_ibom.LED_Assembly = txtLED_Assy.Text.Trim();
			_ibom.LED_Calibration = txtLED_Calibration.Text.Trim();

			_ibom.PS_Assembly = txtPS_Assy.Text.Trim();
			_ibom.PS_RedVoltage = numPS_Voltages_Red.Value;
			_ibom.PS_GreenVoltage = numPS_Voltages_Green.Value;
			_ibom.PS_BlueVoltage = numPS_Voltages_Blue.Value;
			_ibom.PS_LogicVoltage = numPS_Voltages_Logic.Value;

			_ibom.Interface_EpromType = txtInterfaces_EpromType.Text.Trim();
			_ibom.Interface_EpromVersion = txtInterfaces_EpromFirmwareVersion.Text.Trim();
			_ibom.Interface_Assembly_ID = (int?)txtInterfaces_InterfaceAssembly.Tag;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();
		}

		private void NumericUpDown_Enter(object sender, EventArgs e)
		{
			NumericUpDown n = (NumericUpDown)sender;
			n.Select(0, n.Text.Length);
		}

		private void btnInterfaces_SelectInterfaceAssembly_Click(object sender, EventArgs e)
		{
			using (FormAssemblyPicker frmAssemblyPicker = new FormAssemblyPicker(true, _ibom.Interface_Assembly_ID))
			{
				if (frmAssemblyPicker.ShowDialog(this) != DialogResult.OK)
					return;

				txtInterfaces_InterfaceAssembly.Tag = (int?)frmAssemblyPicker.SelectedAssembly.ID;
				txtInterfaces_InterfaceAssembly.Text = frmAssemblyPicker.SelectedAssembly.DisplayMember; // frmAssemblyPicker.SelectedAssembly.Description;
			}
		}
	}
}