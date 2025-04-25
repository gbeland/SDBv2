using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.General;
using SDB.Forms.General;

namespace SDB.UserControls.General
{
	public partial class ucGeneralNotes : UserControl
	{
		private List<ClassGeneralNote> _notes = new List<ClassGeneralNote>();
		private readonly Dictionary<int, string> _userNames = new Dictionary<int, string>();

		public ucGeneralNotes()
		{
			InitializeComponent();
		}

		public void RefreshNotes()
		{
			try
			{
				_notes = ClassGeneralNote.GetAll();
				PopulateUserNames();
				Populate();
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				Console.WriteLine("Error refreshing general notes: " + exc.Message);
			}
		}

		private void Populate()
		{
			pnlGeneralNotes.SuspendLayout();
			pnlGeneralNotes.Controls.Clear(true);
			for (var i = _notes.Count - 1; i >= 0; i--)
			{
				var authorName = string.Empty;
				try
				{
					authorName = _userNames[_notes[i].UserID];
				}
				catch
				{
				}
				var generalNote = new ucGeneralNote(_notes[i], authorName);
				generalNote.Updated += gn_Updated;
				generalNote.Dock = DockStyle.Top;
				pnlGeneralNotes.Controls.Add(generalNote);
			}
			pnlGeneralNotes.ResumeLayout();
			if (pnlGeneralNotes.Controls.Count > 0)
				pnlGeneralNotes.ScrollControlIntoView(pnlGeneralNotes.Controls[0]);
		}

		private void PopulateUserNames()
		{
			_userNames.Clear();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(@"SELECT u.userid, CONCAT(u.firstname, LEFT(u.lastname, 1)) firstl
						FROM users u
						WHERE u.userid in ({0});", string.Join(",", _notes.Select(n => n.UserID).Distinct()));
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
							_userNames.Add(reader.GetDBInt("userid"), reader.GetDBString("firstl"));
					}
				}
				conn.Close();
			}
		}

		void gn_Updated()
		{
			RefreshNotes();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (var fui = new FormUserInput("New General Note", "Enter note:"))
			{
				fui.ShowDialog();
				if (fui.DialogResult != DialogResult.OK)
					return;

				var newNote = new ClassGeneralNote
				              {
					              UserID = GS.Settings.LoggedOnUser.ID,
								  NoteText = fui.UserText.Trim()
				              };
				ClassGeneralNote.AddNew(ref newNote);
				RefreshNotes();
			}
		}
	}
}