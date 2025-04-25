using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.General;
using SDB.Forms.Assembly;

namespace SDB.Forms.Admin
{
	public partial class FormAdmin_CameraType_AddEdit : Form
	{
		private const string _CHANNEL_STRING = @"[CHANNEL]";
		private ClassCameraType _cameraType = new ClassCameraType();
		private ClassAssembly _associatedAssembly;
		private readonly bool _isEditing;
		private TextBox _selectedTextBox;
		private readonly TextBox[] _channelInsertableTextboxes;

		public FormAdmin_CameraType_AddEdit(bool isEditing, int? cameraTypeID = null)
		{
			InitializeComponent();
			_channelInsertableTextboxes = new[] { txtUrlFormat_Still, txtUrlFormat_Monitor, txtUrlFormat_Video };

			_isEditing = isEditing;

			if (_isEditing && cameraTypeID.HasValue)
			{
				_cameraType = ClassCameraType.GetByID(cameraTypeID.Value);
				if (_cameraType.AssemblyID.HasValue)
					_associatedAssembly = ClassAssembly.GetByID(_cameraType.AssemblyID.Value);
				Populate();
			}

			txtCameraType_Description.Select();
		}

		private void Populate()
		{
			txtCameraType_Description.Text = _cameraType.Description;
			txtUrlFormat_Still.Text = _cameraType.URL_Format_Still;
			txtUrlFormat_Monitor.Text = _cameraType.URL_Format_Monitor;
			txtUrlFormat_Video.Text = _cameraType.URL_Format_Video;
			if (_associatedAssembly != null)
				txtAssembly.Text = _associatedAssembly.Description;
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			TextBox t = (TextBox)sender;
			t.SelectAll();

			_selectedTextBox = _channelInsertableTextboxes.Any(c => c == t) ? t : null;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			#region Validation
			if (string.IsNullOrEmpty(txtCameraType_Description.Text) || string.IsNullOrEmpty(txtUrlFormat_Still.Text))
			{
				MessageBox.Show("Camera Type Model/Description, Still Image URL Format, and Monitoring Image URL Format cannot be blank.", "Camera Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			UpdateCameraTypeObjectFromFields();
			try
			{
				if (_isEditing)
					ClassCameraType.Update(_cameraType);
				else
					ClassCameraType.AddNew(ref _cameraType);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("Could not update or add camera type. Ensure the Camera Type Model/Description is unique.{0}{0}{1}", Environment.NewLine, exc.Message), "Camera Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateCameraTypeObjectFromFields()
		{
			_cameraType.Description = txtCameraType_Description.Text.Trim();
			_cameraType.URL_Format_Still = txtUrlFormat_Still.Text.Trim();
			_cameraType.URL_Format_Monitor = txtUrlFormat_Monitor.Text.Trim();
			_cameraType.URL_Format_Video = txtUrlFormat_Video.Text.Trim();
			if (_associatedAssembly != null)
				_cameraType.AssemblyID = _associatedAssembly.ID;
			else
				_cameraType.AssemblyID = null;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnInsertField_Channel_Click(object sender, EventArgs e)
		{
			if (_selectedTextBox == null)
				return;

			int selectionStart = _selectedTextBox.SelectionStart;
			_selectedTextBox.Text = _selectedTextBox.Text.Insert(selectionStart, _CHANNEL_STRING);

			_selectedTextBox.Select();
			_selectedTextBox.Select(selectionStart, _CHANNEL_STRING.Length);
		}

		private void btnAssembly_Select_Click(object sender, EventArgs e)
		{
			using (FormAssemblyPicker frmAssemblyPicker = new FormAssemblyPicker(true))
			{
				if (frmAssemblyPicker.ShowDialog(this) != DialogResult.OK)
					return;

				_associatedAssembly = frmAssemblyPicker.SelectedAssembly;
				txtAssembly.Text = _associatedAssembly.Description;
			}
		}

		private void btnAssembly_Clear_Click(object sender, EventArgs e)
		{
			_associatedAssembly = null;
			txtAssembly.Clear();
		}
	}
}