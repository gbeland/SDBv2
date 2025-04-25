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

namespace SDB.MagicInfo.Components
{
    /// <summary>
    /// self contained User Control for Market info
    /// This control should not interact with outside controls or update sql DB
    /// </summary>
    public partial class MarketComponent : UserControl
    {
        //Stored copy of Customer
        private MagicInfoMarket _market;

        /// <summary>
        /// creates empy a market user control.
        /// </summary>
        public MarketComponent()
        {
            InitializeComponent();
            _market = new MagicInfoMarket();
        }

        /// <summary>
        /// Makes all text fields Readonly
        /// True is read only
        /// </summary>
        /// <param name="isReadOnly"></param>
        public void ReadOnly(bool isReadOnly)
        {
            tbxName.ReadOnly = isReadOnly;
            tbxTag.ReadOnly = isReadOnly;
        }

        /// <summary>
        /// Populates text fields based on Market and stores a copy of Market
        /// </summary>
        public void Populate(MagicInfoMarket market)
        {
            if (market == null)
                return;
            _market = market;
            tbxName.Text = market.Name;
            tbxTag.Text = market.Tag;
        }

        /// <summary>
        /// Returns a market based on the text fields
        /// </summary>
        /// <returns></returns>
        public MagicInfoMarket GetMarket()
        {
            _market.Name = tbxName.Text;
            _market.Tag = tbxTag.Text;
            return _market;
        }

        /// <summary>
        /// Clears all textboxes and the stored Market
        /// </summary>
        public void Clear()
        {
            _market = new MagicInfoMarket();
            IEnumerable<TextBox> allTbx = grpMarketInfo.Controls.Cast<Control>().OfType<TextBox>();
            foreach (TextBox tbx in allTbx)
                tbx.Clear();
        }

        /// <summary>
        /// Iterates through all textboxes to see if they are blank. If they are it colors them red, if they are not it colors them green
        /// </summary>
        /// <TODO>Add ability to set color data and more advanced validating</TODO>
        /// <returns>returns true if all fields have text</returns>
        public bool isComplete()
        {
            Color failColor = Color.Salmon;
            Color goodColor = Color.PaleGreen;
            bool isComplete = true;


            IEnumerable<TextBox> allTbx = grpMarketInfo.Controls.Cast<Control>().OfType<TextBox>();

            foreach (TextBox tbx in allTbx)
            {
                if (tbx.Text == string.Empty)
                {
                    tbx.BackColor = failColor;
                    isComplete = false;
                }
                else
                    tbx.BackColor = goodColor;
            }
            return isComplete;
        }
    }
}
