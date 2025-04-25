using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.Assembly;

namespace SDB.Forms.Admin
{
	/// <summary>
	/// This form used for replacing one assembly with another when deleting or merging.
	/// </summary>
	public partial class FormAdmin_Assembly_Select : Form
	{
		public ClassAssembly Assembly = new ClassAssembly();
		private readonly List<ClassAssembly> _assemblies;

		/// <summary>
		/// This form used for replacing one assembly with another when deleting or merging.
		/// </summary>
		/// <param name="showDisabled">Includes disabled assemblies in the list.</param>
		public FormAdmin_Assembly_Select(bool showDisabled = false)
		{
			InitializeComponent();
			_assemblies = showDisabled ? ClassAssembly.GetByType().ToList() : ClassAssembly.GetByType().Where(a => !a.Disabled).ToList();
			
			cmbAssembly.DisplayMember = "DisplayMember";
			cmbAssembly.ValueMember = "ID";
			cmbAssembly.DataSource = _assemblies;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Assembly = (ClassAssembly)cmbAssembly.SelectedItem;
			if (Assembly.Disabled)
			{
				if (MessageBox.Show("This assembly has been disabled, are you sure you want to select it?", "Disabled Assembly", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
					return;
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void cmbAssembly_DrawItem(object sender, DrawItemEventArgs e)
		{
			var comboBox = (ComboBox)sender;
			e.DrawBackground();

            var text = comboBox.GetItemText(comboBox.Items[e.Index]);
            Font f = ((Control)sender).Font;
            var brush = (comboBox.Items[e.Index] as ClassAssembly).Disabled ? Brushes.Gray : Brushes.Black;
            e.Graphics.DrawString(text, f, brush, e.Bounds.X, e.Bounds.Y);

        }
	}
}