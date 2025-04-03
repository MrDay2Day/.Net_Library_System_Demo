using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRental.Utils;

namespace LibrarySystem.Windows
{
    public partial class CreateUser : Form
    {
        private User systemUser = null;
        private Library_SystemEntities db;

        public CreateUser()
        {
            InitializeComponent();
            db = new Library_SystemEntities();
            InitializeUserTypeComboBox();
        }

        public CreateUser(User user)
        {
            InitializeComponent();
            this.systemUser = user;
            db = new Library_SystemEntities();

            this.Text = $"{systemUser.First_name}'s Account Information";

            combo_userType.Visible = false;
            form_title.Text = "Edit Profile";
            userTypeLable.Visible = false;

            this.autoaFill();
        }

        private void InitializeUserTypeComboBox()
        {
            combo_userType.Items.AddRange(new string[] { "ADMIN", "USER", "STAFF" });
            combo_userType.SelectedIndex = 1;
        }

        private void autoaFill()
        {
            if (systemUser != null)
            {
                this.info_first_name.Text = systemUser.First_name;
                this.info_last_name.Text = systemUser.Last_name;
                this.info_email.Text = systemUser.Email;
                this.info_phone.Text = systemUser.Phone;
                this.info_password.Text = null;
                this.info_password_retype.Text = null;

                combo_userType.Visible = false;

                //if (combo_userType.Visible) 
                //{
                //    if (combo_userType.Items.Contains(systemUser.Type))
                //    {
                //        combo_userType.SelectedItem = systemUser.Type;
                //    }
                //    else if (combo_userType.Items.Count > 1) 
                //    {
                //        combo_userType.SelectedIndex = 1;
                //    }
                //}
            }
        }

        private void close()
        {
            this.Close();
        }

        private void save()
        {
            if (systemUser == null)
            {
                CreateNewUser();
            }
            else
            {
                UpdateExistingUser();
            }
        }

        private void CreateNewUser()
        {
            try
            {
                string hashpw = UtilityFunctions.EncryptPassword(info_password.Text);

                if (string.IsNullOrEmpty(info_password.Text) || string.IsNullOrEmpty(info_password_retype.Text) || hashpw != UtilityFunctions.EncryptPassword(info_password_retype.Text))
                {
                    MessageBox.Show("Passwords do not match or are empty.");
                    return;
                }

                User newUser = new User
                {
                    First_name = info_first_name.Text,
                    Last_name = info_last_name.Text,
                    Email = info_email.Text,
                    Phone = info_phone.Text,
                    Password = hashpw,
                    Type = combo_userType.SelectedItem.ToString()
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("User created successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}");
            }
        }

        private void UpdateExistingUser()
        {
            try
            {
                systemUser.First_name = info_first_name.Text;
                systemUser.Last_name = info_last_name.Text;
                systemUser.Email = info_email.Text;
                systemUser.Phone = info_phone.Text;

                if (!string.IsNullOrEmpty(info_password.Text))
                {
                    if (info_password.Text == info_password_retype.Text)
                    {
                        systemUser.Password = UtilityFunctions.EncryptPassword(info_password.Text);
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match.");
                        return;
                    }
                }

                db.SaveChanges();

                MessageBox.Show("User information updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
        }

        private void btn_save_new_Click(object sender, EventArgs e)
        {
            save();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            close();
        }

    }
}