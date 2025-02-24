using System;
using System.Collections;
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

        string searchText = null;
        int pageNumber = 1;
        int total = 0;
        int availableCount = 0;
        int notAvailableCount = 0;
        int searchType = 1; // 1: All, 2: Available Only, 3: Not Available
        int maxSearchContent = 50;

        public ViewAll(User user)
        {
            InitializeComponent();
            db = new Library_SystemEntities();
            this.WindowState = FormWindowState.Maximized;
            LoadBooks();
            this.systemUser = user;

            type_selection.DisplayMember = "Text"; // What the user sees
            type_selection.ValueMember = "Value"; // The associated value

            type_selection.DataSource = new ArrayList
            {
                new { Text = "All", Value = 1 },
                new { Text = "Available", Value = 2 },
                new { Text = "Not Available", Value = 3 }
            };

            type_selection.DropDownStyle = ComboBoxStyle.DropDownList;

            type_selection.SelectedIndex = 0;
            //type_selection.SelectedItem = "All";
            //type_selection.SelectedValue = this.searchType;

        }

        private void setAvailableOrNot()
        {
            this.availableCount = db.Books.Count(b => b.Available == true);
            this.count_available.Text = this.availableCount.ToString();

            this.notAvailableCount = db.Books.Count(b => b.Available == false);
            this.count_not_available.Text = this.notAvailableCount.ToString();


            this.count_total.Text = db.Books.Count().ToString();
        }

        private void loadGrid(System.Data.Entity.Core.Objects.ObjectResult<sp_FetchBooks_Search_Only_Result> data)
        {
            setAvailableOrNot();
            int totalValueOnPagination = (this.pageNumber * this.maxSearchContent) > this.total ? this.total : (this.pageNumber * this.maxSearchContent);
            count_pagination.Text = $"{(this.pageNumber * this.maxSearchContent) - this.maxSearchContent + 1} - {totalValueOnPagination} of {this.total}";

            int maxPages = (int)Math.Ceiling((decimal)this.total / this.maxSearchContent);

            if (maxPages > 1 && this.pageNumber < maxPages)
            {
                btn_next.Enabled = true;
            }
            else
            {
                btn_next.Enabled = false;
            }

            dg_book_list.DataSource = data;

            dg_book_list.Columns[0].Visible = false;
            dg_book_list.Columns[6].Visible = false;
            dg_book_list.Columns[7].Visible = false;
            dg_book_list.Columns[9].Visible = false;
            dg_book_list.Columns[10].Visible = false;

            dg_book_list.Columns[1].HeaderText = "Title";
            dg_book_list.Columns[1].Width = 250;

            dg_book_list.Columns[2].HeaderText = "Description";
            dg_book_list.Columns[2].Width = 350;
            dg_book_list.Columns[3].Width = 200;
            dg_book_list.Columns[0].Visible = false;
            dg_book_list.Columns[4].HeaderText = "Published Year";
            dg_book_list.Columns[8].HeaderText = "Return Date";
        }

        private void LoadBooks()
        {
            try
            {
                type_selection.SelectedValue = 1;
                this.searchType = 1;
                this.pageNumber = 1;
                this.searchText = null;
                search_text.Text = null;
                int count = db.sp_FetchBooks_Simple(this.searchType, this.searchText).Count();
                this.total = count;
                var db_books = db.sp_FetchBooks_Search_Only(this.pageNumber, this.searchType, this.maxSearchContent, this.searchText);

                


                loadGrid(db_books);
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

        private void dg_book_list_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dg_book_list.SelectedRows[0].Cells["Book_id"].Value;
                Console.WriteLine(id);

                if (id != null)
                {
                    Book selectedBook = db.Books.FirstOrDefault(b => b.Book_id == (int)id);
                    if (selectedBook != null)
                    {
                        info_author.Text = selectedBook.Author;
                        info_available.Checked = selectedBook.Available;
                        info_decsription.Text = selectedBook.Description;
                        info_year.Text = selectedBook.PublishedYear.ToString();
                        info_title.Text = selectedBook.Title;

                        if (systemUser.Type == "STAFF" || systemUser.Type == "ADMIN")
                        {
                            btn_edit.Enabled = true;
                            btn_edit.Visible = true;

                            btn_delete.Enabled = true;
                            btn_delete.Visible = true;
                        }

                        btn_borrow.Enabled = true;
                        btn_borrow.Visible = true;

                        btn_clear.Enabled = true;
                        btn_clear.Visible = true;
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("SelectedBook: ", err);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            info_author.Text = null;
            info_available.Checked = false;
            info_decsription.Text = null;
            info_year.Text = null;
            info_title.Text = null;

            btn_edit.Enabled = false;
            btn_edit.Visible = false;

            btn_delete.Enabled = false;
            btn_delete.Visible = false;

            btn_borrow.Enabled = false;
            btn_borrow.Visible = false;

            btn_clear.Enabled = false;
            btn_clear.Visible = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            int maxPages = (int)Math.Ceiling((decimal)this.total / this.maxSearchContent);
            if (this.pageNumber + 1 <= maxPages)
            {
                btn_prev.Enabled = true;
                this.pageNumber++;
                if (this.pageNumber >= maxPages)
                {
                    btn_next.Enabled = false;
                }


                var db_books = db.sp_FetchBooks_Search_Only(this.pageNumber, this.searchType, this.maxSearchContent, this.searchText);
                loadGrid(db_books);
            }
        }
        private void prev_Click(object sender, EventArgs e)
        {

            if (this.pageNumber - 1 >= 1)
            {
                this.pageNumber--;
                if (this.pageNumber == 1)
                {
                    btn_prev.Enabled = false;
                }

                var db_books = db.sp_FetchBooks_Search_Only(this.pageNumber, this.searchType, this.maxSearchContent, this.searchText);
                loadGrid(db_books);
            }
        }

        private void search()
        {
            this.searchText = search_text.Text;

            this.pageNumber = 1;
            int count = db.sp_FetchBooks_Simple(this.searchType, this.searchText).Count();
            this.total = count;
            var db_books = db.sp_FetchBooks_Search_Only(this.pageNumber, this.searchType, this.maxSearchContent, this.searchText);

            loadGrid(db_books);

        }

        private void reset()
        {
            LoadBooks();
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            if (search_text.Text.Length >= 2)
            {
                btn_search.Enabled = true;
            }
            else
            {
                btn_search.Enabled = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void type_selection_SelectedValueChanged_1(object sender, EventArgs e)
        {
            this.searchType = Convert.ToInt32(type_selection.SelectedValue);

            this.pageNumber = 1;
            int count = db.sp_FetchBooks_Simple(this.searchType, this.searchText).Count();
            this.total = count;
            var db_books = db.sp_FetchBooks_Search_Only(this.pageNumber, this.searchType, this.maxSearchContent, this.searchText);

            loadGrid(db_books);
        }
    }



}
