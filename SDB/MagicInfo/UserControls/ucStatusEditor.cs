using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.MagicInfo.Classes;

namespace SDB.MagicInfo.UserControls
{
    public partial class ucStatusEditor : UserControl
    {
        public ucStatusEditor()
        {
            InitializeComponent();
            olvColumn3.AspectToStringConverter = x =>
            {
                if (x == null)
                    return string.Empty;

                return (ColorTranslator.ToHtml((Color)x));
            };
        }
        public void Populate()
        {
            olvStatus.Objects = MagicInfoStatus.GetAll_IncludingDisabled();
        }

        private void olvStatus_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == olvColumn3.Index)
            {
                MagicInfoStatus s = (e.Model as MagicInfoStatus);
                if (s.StatusColor == null)
                    return;
                e.SubItem.BackColor = s.StatusColor;
            }
        }

        private void olvStatus_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            MessageBox.Show("Change");
        }

        private void olvStatus_CellClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            if(e.ColumnIndex == olvColumn3.Index)
            {
                using(ColorDialog _dialog = new ColorDialog())
                {
                    _dialog.ShowDialog();
                    Color c = _dialog.Color;
                    //MagicInfoStatus s = e.Model as MagicInfoStatus;
                    (e.Model as MagicInfoStatus).StatusColor = c;
                    
                }
            }


        }

        private void olvStatus_CellEditFinished(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            (e.RowObject as MagicInfoStatus).Status = e.NewValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach(MagicInfoStatus s in olvStatus.Objects)
            {
                if(s.ID == null)
                {
                    if (s.Status != null && s.StatusColor != null)
                    {
                        MagicInfoStatus.AddNew(s);
                    }
                }
                else MagicInfoStatus.Update(s);
            }


            ParentForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            olvStatus.AddObject(new MagicInfoStatus());
        }
    }
}
