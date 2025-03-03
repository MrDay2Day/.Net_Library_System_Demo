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
    public partial class CreateUser : Form
    {
        private User systemUser = null;

        public CreateUser()
        {
            InitializeComponent();
        }

        public CreateUser(User user)
        {
            InitializeComponent();
            this.systemUser = user;

            this.Text = $"{systemUser.First_name}'s Account Information";

            combo_userType.Visible = false;
            form_title.Text = "Edit Profile";
            userTypeLable.Visible = false;  

            this.autoaFill();
        }

        private void autoaFill()
        {
            if (systemUser != null) {
                this.info_first_name.Text = systemUser.First_name;
                this.info_last_name.Text = systemUser.Last_name;
                this.info_email.Text = systemUser.Email;
                this.info_phone.Text = systemUser.Phone;
                this.info_password.Text = "************";
                this.info_password_retype.Text = "************";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
