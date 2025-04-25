using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.Classes.User;

namespace SDB.UserControls.Admin
{
    public partial class ucUserManager : UserControl
    {
        public ucUserManager()
        {
            InitializeComponent();
        }

        public void PopulateUserList()
        {
            olvUserList.Objects = ClassUser.GetAll(ClassUser.UserAccountStatus.All);
        }


    }
}
