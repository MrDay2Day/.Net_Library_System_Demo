using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem.Windows
{
    public partial class ViewAll : Form
    {
        private Library_SystemEntities db;
        List<Book> books;
        private User systemUser;

        int pageNumber = 1;
        int availableCount = 0;
        int notAvailableCount = 0;

        int searchType = 1;

        public ViewAll(User user)
        {
            InitializeComponent();
            db = new Library_SystemEntities();
            this.WindowState = FormWindowState.Maximized;
            LoadBooks();
            this.systemUser = user;
        }

        private void LoadBooks()
        {
            try
            {

 

                var db_books = db.sp_FetchBooks_Search_Only(1, 1, 50, null);
                int count = db.sp_FetchBooks_Simple(1, null).Count();

                count_total.Text = count.ToString();
                dg_book_list.DataSource = db_books;

                dg_book_list.Columns[0].Visible = false;

                dg_book_list.Columns[1].HeaderText = "Title";
                dg_book_list.Columns[1].Width = 250;

                dg_book_list.Columns[2].HeaderText = "Description";
                dg_book_list.Columns[2].Width = 350;



            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());

                WarningPopUp warning = new WarningPopUp("Issue Loading Books", "Issue loading Books", "There seems to be an issue loading books.");
                warning.ShowDialog();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
