using System;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SDB.Forms.General
{
	public sealed partial class FormUserInput : Form
	{
		private readonly bool _required;

		public string UserText { get; private set; }

		/// <summary>
		/// Creates a user input form with a title and information prompt.
		/// </summary>
		/// <param name="dialogTitle">The title of the user input form.</param>
		/// <param name="infoLabelText">The prompt for information preceding the text box.</param>
		/// <param name="isRequired">Whether input is required (otherwise blank is acceptable).</param>
		/// <param name="defaultValue">The value to populate the input textbox with initially.</param>
		public FormUserInput(string dialogTitle, string infoLabelText, bool isRequired = true, string defaultValue = "")
		{
			InitializeComponent();
			ucSpellCheckLarge1.KeyDown += ucSpellCheckLarge1_KeyDown;
			ucSpellCheckLarge1.txtData.AppendText(defaultValue);
			ucSpellCheckLarge1.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
			ucSpellCheckLarge1.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
			if (!string.IsNullOrEmpty(defaultValue))
				ucSpellCheckLarge1.txtData.SelectAll();
			Text = dialogTitle;
			lblInfo.Text = infoLabelText;
			_required = isRequired;
		}

		private void ucSpellCheckLarge1_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (ModifierKeys != Keys.Control)
				return;

			if (e.Key == System.Windows.Input.Key.Enter)
				SubmitText();
		}

		private void SubmitText()
		{
			ucSpellCheckLarge1.txtData.SelectAll();
			var data = new TextRange(ucSpellCheckLarge1.txtData.Document.ContentStart, ucSpellCheckLarge1.txtData.Document.ContentEnd).Text.Trim();
			if (_required && string.IsNullOrEmpty(data))
			{
				MessageBox.Show("You must enter something to continue.", "Empty Information Not Permitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			UserText = data;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SubmitText();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			UserText = string.Empty;
            DialogResult = DialogResult.Cancel;
            Close();
		}
	}
}