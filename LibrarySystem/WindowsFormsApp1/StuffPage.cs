using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Nesneler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class StuffPage : Form
    {
        List<book> books;
        public StuffPage(List<book> books)
        {
            this.books = books;

            InitializeComponent();
        }

        //When the form loads, it populates the DataGridView with existing book data
        private void StuffPage_Load(object sender, EventArgs e)
        {
            foreach (book bookStaff in books)
            {
                dataGridView_staff.Rows.Add(bookStaff.getBookId(), bookStaff.getBookName(), bookStaff.getBookAuthor(), bookStaff.getBookLanguage(), bookStaff.getBookPublisher(), bookStaff.getBookType(), bookStaff.getBookCount(), bookStaff.getBookPageCount(), bookStaff.getBookYear());
            }
        }

        //when the add button is clicked, it adds a new book to the DataGridView using data from the text boxes
        private void btn_staffAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_staff.Rows.Add(Convert.ToInt32(txt_bookId.Text), txt_bookName.Text, txt_bookAuthor.Text, txt_bookLanguage.Text, txt_bookPublisher.Text, txt_bookType.Text, Convert.ToInt32(txt_bookCount.Text), Convert.ToInt32(txt_bookPageCount.Text), Convert.ToInt32(txt_bookYear.Text));
            }

            catch (Exception)
            {
                for (int i = 0; i < groupBox_staff.Controls.Count; i++)
                {
                    if (groupBox_staff.Controls[i] is TextBox)
                    {
                        if (groupBox_staff.Controls[i].Text == "")
                        {
                            break;
                        }
                    }
                }

                MessageBox.Show("All fields must be filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //staffDelete button removes the selected row from the DataGridView
        private void btn_staffDelete_Click(object sender, EventArgs e)
        {
            dataGridView_staff.Rows.Remove(dataGridView_staff.CurrentRow);
        }

        //adds the data from the selected row in the DataGridView to the text boxes
        private void dataGridView_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_bookId.Text = dataGridView_staff.CurrentRow.Cells[0].Value.ToString();
            txt_bookName.Text = dataGridView_staff.CurrentRow.Cells[1].Value.ToString();
            txt_bookAuthor.Text = dataGridView_staff.CurrentRow.Cells[2].Value.ToString();
            txt_bookLanguage.Text = dataGridView_staff.CurrentRow.Cells[3].Value.ToString();
            txt_bookPublisher.Text = dataGridView_staff.CurrentRow.Cells[4].Value.ToString();
            txt_bookType.Text = dataGridView_staff.CurrentRow.Cells[5].Value.ToString();
            txt_bookCount.Text = dataGridView_staff.CurrentRow.Cells[6].Value.ToString();
            txt_bookPageCount.Text = dataGridView_staff.CurrentRow.Cells[7].Value.ToString();
            txt_bookYear.Text = dataGridView_staff.CurrentRow.Cells[8].Value.ToString();
        }

        //updates the selected row in the DataGridView with data from the text boxes
        private void btn_staffUpdate_Click(object sender, EventArgs e)
        {
            string bookId = txt_bookId.Text;
            string bookName = txt_bookName.Text;
            string bookAuthor = txt_bookAuthor.Text;
            string bookLanguage = txt_bookLanguage.Text;
            string bookPublisher = txt_bookPublisher.Text;
            string bookType = txt_bookType.Text;
            string bookCount = txt_bookCount.Text;
            string bookPageCount = txt_bookPageCount.Text;
            string bookYear = txt_bookYear.Text;

            dataGridView_staff.CurrentRow.SetValues(bookId, bookName, bookAuthor, bookLanguage, bookPublisher, bookType, bookCount, bookPageCount, bookYear);
        }

        //clears all text boxes in the group box
        private void btn_staffClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_staff.Controls.Count; i++)
            {
                if (groupBox_staff.Controls[i] is TextBox)
                {
                    groupBox_staff.Controls[i].Text = string.Empty;
                }
            }

        }

        //book search button functionality
        private void btn_bookSearch_Click(object sender, EventArgs e)
        {
            book book = null;

            int searchId = Convert.ToInt32(txt_bookSearch.Text);

            try
            {
                foreach (book n in books)
                {
                    if (Convert.ToInt32(n.getBookId()) == searchId)
                    {
                        book = n;
                        break;
                    }

                }

                if (book == null)
                {
                    throw new Exception();
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Please enter a valid book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dataGridView_staff.Rows.Clear();
            dataGridView_staff.Rows.Add(book.getBookId(), book.getBookName(), book.getBookAuthor(), book.getBookLanguage(), book.getBookPublisher(), book.getBookType(), book.getBookCount(), book.getBookPageCount(), book.getBookYear());
            
        }

        //book refresh button functionality to reload all book data into the DataGridView
        private void btn_bookRefresh_Click(object sender, EventArgs e)
        {
            dataGridView_staff.Rows.Clear();

            foreach (book book_refresh in books)
            {
                dataGridView_staff.Rows.Add(book_refresh.getBookId(), book_refresh.getBookName(), book_refresh.getBookAuthor(), book_refresh.getBookLanguage(), book_refresh.getBookPublisher(), book_refresh.getBookType(), book_refresh.getBookCount(), book_refresh.getBookPageCount(), book_refresh.getBookYear());
            }
        }
    }
}
