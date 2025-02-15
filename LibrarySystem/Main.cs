using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Windows;

namespace LibrarySystem
{
    public partial class Main : Form
    {

        private ViewAll viewAllBooks;
        public Main()
        {
            InitializeComponent();

            main_menu.Visible = false;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mbtn_view_all_books_Click(object sender, EventArgs e)
        {

            viewAllBooks = new ViewAll();
            viewAllBooks.MdiParent = this;
            viewAllBooks.Show();            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login_panel.Visible = false;
            main_menu.Visible = true;
        }
    }
}
