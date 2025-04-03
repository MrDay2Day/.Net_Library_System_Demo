using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Windows
{
    public partial class MyRentals : Form
    {
        private User systemUser;
        private Library_SystemEntities db;

        private int pageNum = 1; // Current page number
        private int perPage = 30; // Number of items per page

        private int bookIdNumber;

        public MyRentals(User user)
        {
            db = new Library_SystemEntities();
            InitializeComponent();
            this.systemUser = user;
            this.WindowState = FormWindowState.Maximized;

            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            if (systemUser == null)
            {
                MessageBox.Show("User not set.");
                return;
            }

            try
            {
                int count = db.Borrows.Count(x => x.User_id == systemUser.User_id && x.Actual_return_date == null); //Corrected the count

                int limit = ((pageNum - 1) * perPage);

                int maxPages = (int)Math.Ceiling((double)count / perPage);

                button1.Enabled = pageNum > 1;
                button2.Enabled = pageNum < maxPages;

                tally.Text = $"{(limit + 1).ToString()} to " +
                            $"{(limit + perPage > count ? count : (limit) + perPage).ToString()} of {count}";

                var borrowedBooks = db.Borrows
                    .Where(borrow => borrow.User_id == systemUser.User_id && borrow.Actual_return_date == null)
                    .Include(borrow => borrow.Book)
                    .OrderBy(borrow => borrow.Schedule_return_date)
                    .Skip((pageNum - 1) * perPage)
                    .Take(perPage)
                    .ToList();

                var result = borrowedBooks.Select(borrow => new
                {
                    borrow.Book_id,
                    borrow.Book.Title,
                    borrow.Book.Author,
                    borrow.Book.Description,
                    borrow.Borrow_date,
                    borrow.Schedule_return_date,
                    Fee = CalculateFee(borrow.Schedule_return_date) //added Fee
                }).ToList();

                dgvRentals.DataSource = result;

                dgvRentals.Columns["Book_id"].Visible = false;

                if (dgvRentals.Columns.Contains("Borrow_date"))
                {
                    dgvRentals.Columns["Borrow_date"].HeaderText = "Borrow Date";
                    dgvRentals.Columns["Borrow_date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }

                if (dgvRentals.Columns.Contains("Schedule_return_date"))
                {
                    dgvRentals.Columns["Schedule_return_date"].HeaderText = "Return Deadline";
                    dgvRentals.Columns["Schedule_return_date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }

                if (dgvRentals.Columns.Contains("Fee"))
                {
                    dgvRentals.Columns["Fee"].HeaderText = "Fee";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowed books: {ex.Message}");
            }
        }

        private string CalculateFee(DateTime scheduleReturnDate)
        {
            DateTime today = DateTime.Today;
            if (today > scheduleReturnDate)
            {
                TimeSpan difference = today - scheduleReturnDate;
                return $"${difference.Days * 250}";
            }
            else
            {
                return "-";
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (pageNum > 1)
            {
                pageNum--;
                LoadBorrowedBooks();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            pageNum++;
            LoadBorrowedBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPreviousPage_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnNextPage_Click(sender, e);
        }

        private void dgvRentals_Click(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count > 0) // Ensure a row is selected
            {
                var id = dgvRentals.SelectedRows[0].Cells["Book_id"].Value;
                Console.WriteLine($"Book ID for return: {id}");

                if (id != null)
                {
                    int bookId = int.Parse(id.ToString());

                    // Find the row with the matching Book_id
                    DataGridViewRow selectedRow = null;
                    foreach (DataGridViewRow row in dgvRentals.Rows)
                    {
                        if (row.Cells["Book_id"].Value != null && int.Parse(row.Cells["Book_id"].Value.ToString()) == bookId)
                        {
                            selectedRow = row;
                            break;
                        }
                    }

                    if (selectedRow != null)
                    {
                        bookIdNumber = bookId;
                        returnBookBtn.Visible = true;
                        returnBookBtn.Enabled = true;
                        clearBookbtn.Visible = true;
                        clearBookbtn.Enabled = true;
                        textBox1.Text = selectedRow.Cells["Title"].Value?.ToString();
                        textBox2.Text = selectedRow.Cells["Author"].Value?.ToString();
                        textBox3.Text = selectedRow.Cells["Description"].Value?.ToString();

                        // Correct date parsing and formatting
                        if (selectedRow.Cells["Schedule_return_date"].Value != null && selectedRow.Cells["Schedule_return_date"].Value != DBNull.Value)
                        {
                            if (selectedRow.Cells["Schedule_return_date"].Value is DateTime scheduleReturnDate)
                            {
                                textBox4.Text = scheduleReturnDate.ToString("yyyy-MM-dd"); // Format as yyyy-MM-dd
                            }
                            else if (selectedRow.Cells["Schedule_return_date"].Value is string dateString)
                            {
                                DateTime parsedDate;
                                if (DateTime.TryParse(dateString, out parsedDate))
                                {
                                    textBox4.Text = parsedDate.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    textBox4.Text = "Invalid Date"; // Handle invalid date strings
                                }
                            }
                            else
                            {
                                textBox4.Text = "Unknown Date Type"; // Handle other unexpected types
                            }
                        }
                        else
                        {
                            textBox4.Text = ""; // Set textbox to empty string if date is null or DBNull
                        }

                        feeLabel.Text = selectedRow.Cells["Fee"].Value?.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found in DataGridView.");
                    }
                }
            }
        }

        private void clearBookbtn_Click(object sender, EventArgs e)
        {
            bookIdNumber = -1;
            returnBookBtn.Visible = false;
            returnBookBtn.Enabled = false;
            clearBookbtn.Visible = false;
            clearBookbtn.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            feeLabel.Text = "-";
        }
    }
}