using System;
using System.Drawing;
using System.Windows.Forms;
using SDB.Classes.General;

namespace SDB.UserControls.General
{
	public partial class ucGeneralNote : UserControl
	{
		public delegate void UpdateEvent();
		public event UpdateEvent Updated;

		private readonly ClassGeneralNote _note;
		private bool _ignoreResize;

		public ucGeneralNote(ClassGeneralNote note, string authorName)
		{
			InitializeComponent();
			_note = note;
			btnDelete.Visible = GS.Settings.LoggedOnUser.IsMod || GS.Settings.LoggedOnUser.IsAdmin;
			lblDateTime.Text = _note.NoteDateTime.ToString("yyyy-MM-dd HH:mm");
			lblUser.Text = string.Format("{0}:", authorName);
			txtNote.Text = _note.NoteText;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Delete this note?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
				return;

			_note.Delete();
			if (Updated != null)
				Updated();
		}

		private void ucGeneralNote_ClientSizeChanged(object sender, EventArgs e)
		{
			if (_ignoreResize)
				return;

			_ignoreResize = true;
			if (string.IsNullOrEmpty(txtNote.Text))
				return;

			var size = new Size(txtNote.ClientSize.Width, int.MaxValue);
			const TextFormatFlags FLAGS = TextFormatFlags.WordBreak;
			var borders = txtNote.Height - txtNote.ClientSize.Height;
			size = TextRenderer.MeasureText(txtNote.Text, txtNote.Font, size, FLAGS);
			var height = size.Height + borders + Padding.Vertical;
			Height = height + pnlHeader.Height;
			_ignoreResize = false;
		}
	}
}