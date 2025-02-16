using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Windows
{
    public partial class UserAccount : Form
    {
        private User systemUser;
        public UserAccount(User user)
        {
            InitializeComponent();
            this.systemUser = user;

            this.Text = $"{systemUser.First_name}'s Account Information";
        }
    }
}
