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

namespace WindowsFormsApp1
{
    public partial class AdminPage : Form
    {
        List<Kisi> person;
        public AdminPage(List<Kisi> persons)
        {
            this.person = persons;
            InitializeComponent();
        }

        // Load existing staff data into the DataGridView when the form loads
        private void AdminPage_Load(object sender, EventArgs e)
        {
            foreach(Kisi staff in person)
            {
                dataGridView_staff.Rows.Add(staff.getId(), staff.getName(), staff.getSurname(), staff.getCreatedDate(), staff.getUserName(), staff.getPassword(), staff.getAuthority());
            }
        }

        // Add new staff member to the DataGridView
        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView_staff.Rows.Add(Convert.ToInt32(txt_id.Text), txt_name.Text, txt_surname.Text, msktxt_date.Text, txt_username.Text, txt_password.Text, txt_authority.Text);
        }

        // Delete selected staff member from the DataGridView
        private void btn_delete_Click(object sender, EventArgs e)
        {
            dataGridView_staff.Rows.Remove(dataGridView_staff.CurrentRow);
        }

        // Fill text boxes with data from the selected row in the DataGridView
        public void fillTexts()
        {
            txt_id.Text = dataGridView_staff.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView_staff.CurrentRow.Cells[1].Value.ToString();
            txt_surname.Text = dataGridView_staff.CurrentRow.Cells[2].Value.ToString();
            msktxt_date.Text = dataGridView_staff.CurrentRow.Cells[3].Value.ToString();
            txt_username.Text = dataGridView_staff.CurrentRow.Cells[4].Value.ToString();
            txt_password.Text = dataGridView_staff.CurrentRow.Cells[5].Value.ToString();
            txt_authority.Text = dataGridView_staff.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillTexts();
        }

        // Update the selected row in the DataGridView with data from the text boxes
        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string surname = txt_surname.Text;
            string date = msktxt_date.Text;
            string username = txt_username.Text;
            string password = txt_password.Text;
            string authority = txt_authority.Text;

            dataGridView_staff.CurrentRow.SetValues(id, name, surname, date, username, password, authority);
            
        }

        // Clear all text boxes in the group box
        private void btn_clear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }

        // Navigate back to the login page
        private void btn_getBack_Click(object sender, EventArgs e)
        {
            form_1 loginPage = new form_1();
            loginPage.Show();
            this.Hide();
        }
    }
}
