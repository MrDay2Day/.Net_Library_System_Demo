using System;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CarRental.Utils;
using LibrarySystem.Windows;

namespace LibrarySystem
{
    public partial class Main : Form
    {
        private Library_SystemEntities db;

        User systemUser;
        public Main()
        {
            InitializeComponent();
            InitialDB();

            main_menu.Visible = false;

            this.info_panel.Visible = true;


        }

        private void InitialDB()
        {
            try
            {
                db = new Library_SystemEntities();
            }
            catch (Exception)
            {
                WarningPopUp popup = new WarningPopUp("Server Error", "Server Connection Error", "There seems to be an issue connecting to the database. Please contact support.");
                popup.ShowDialog();
            }
        }

        private async void Login()
        {
            try
            {
                await Task.Delay(3000);

                var email = tb_email.Text.Trim();
                var password = tb_password.Text;

               

                SHA256 sha = new SHA256Managed();
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sBuilder = new StringBuilder();
                foreach (var b in data)
                {
                    sBuilder.Append(b.ToString("x2"));
                }
                string hash_password = sBuilder.ToString();


                systemUser = db.Users.FirstOrDefault(u => u.Email == email && u.Password == hash_password);
                if (systemUser == null)
                {            
                    MessageBox.Show("Invalid credentials", "Login Error");
                    return;

                }
                login_panel.Visible = false;
                main_menu.Visible = true;
                mbtn_user_name.Text = $"{systemUser.First_name} {systemUser.Last_name[0]}.";

                switch (systemUser.Type)
                {
                    case "ADMIN":
                        mbtn_user_manage.Visible = true;
                        mbtn_overdue.Visible = true;
                        break;
                    case "STAFF":
                        mbtn_overdue.Visible = true;
                        break;
                    default:
                        break;
                }

                UtilityFunctions.CloseAll(this);
                UtilityFunctions.ShowMdiChild<ViewAll>(this, systemUser);

                return;
            }
            catch (Exception err)
            {       
                MessageBox.Show("Something went wrong", "Login Error");
            }
            finally
            {
                this.info_panel.Visible = true;
                tb_email.Text = "";
                tb_password.Text = "";
            }
        }


        private void mbtn_view_all_books_Click(object sender, EventArgs e)
        {
            UtilityFunctions.CloseAll(this);
            UtilityFunctions.ShowMdiChild<ViewAll>(this, systemUser);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.info_panel.Visible = false;
            Login();
        }

        private void mbtn_logout_Click(object sender, EventArgs e)
        {
            UtilityFunctions.CloseAll(this);
            login_panel.Visible = true;
            main_menu.Visible = false;
            systemUser = null;
            mbtn_user_name.Text = "-";
            mbtn_user_manage.Visible = false;
            mbtn_overdue.Visible = false;

        }

        private void mbtn_add_book_Click(object sender, EventArgs e)
        {
            UtilityFunctions.OpenAsDialog<AddBook>();
        }

        private void mbtb_user_account_Click(object sender, EventArgs e)
        {
            using (CreateUser userAccount = (new CreateUser(systemUser))) { 
                userAccount.ShowDialog();
            }
        }

        private void myRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilityFunctions.CloseAll(this);
            UtilityFunctions.ShowMdiChild<MyRentals>(this, systemUser);

        }

        private void mbtn_add_user_Click(object sender, EventArgs e)
        {
            UtilityFunctions.OpenAsDialog<CreateUser>();
        }

        private void mbtn_view_all_users_Click(object sender, EventArgs e)
        {
            UtilityFunctions.CloseAll(this);
            UtilityFunctions.ShowMdiChild<ViewAllUsers>(this, systemUser);

        }

        private void mbtn_overdue_Click(object sender, EventArgs e)
        {
            UtilityFunctions.CloseAll(this);
            UtilityFunctions.ShowMdiChild<Overdue>(this, systemUser);
        }
    }
}
