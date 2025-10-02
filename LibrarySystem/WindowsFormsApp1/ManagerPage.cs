using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Nesneler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class ManagerPage : Form
    {
        List<Kisi> person;
        public ManagerPage(List<Kisi> persons)
        {
            this.person = persons;
            InitializeComponent();
        }

        // Load existing staff data into the DataGridView when the form loads
        private void ManagerPage_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in person)
            {
                dataGridView_manager.Rows.Add(kisi.getId(), kisi.getName(), kisi.getSurname(), kisi.getCreatedDate(), kisi.getUserName(), kisi.getPassword(), kisi.getAuthority(), kisi.getSalary());
            }
        }

        // Fill text boxes with data from the selected row in the DataGridView
        public void dataGridView_manager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_currentSalary1.Text = dataGridView_manager.CurrentRow.Cells[7].Value.ToString();
            txt_currentSalary2.Text = dataGridView_manager.CurrentRow.Cells[7].Value.ToString();
            txt_currentSalary3.Text = dataGridView_manager.CurrentRow.Cells[7].Value.ToString();
        }

        // Add raise amount to the current salary
        public void btn_addAmount_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_currentSalary1.Text) is int && Convert.ToInt32(txt_raiseAmount.Text) is int)
                {
                    int sum;
                    sum = Convert.ToInt32(txt_currentSalary1.Text) + Convert.ToInt32(txt_raiseAmount.Text);
                    dataGridView_manager.CurrentRow.Cells[7].Value = sum;
                }
                else
                {
                    throw new Exception();
                }
                
            }
            catch
            {
                MessageBox.Show("Unidentified Input Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear the raise amount text box
        private void btn_clearAmount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_managerAmount.Controls.Count; i++)
            {
                if (groupBox_managerAmount.Controls[i] == txt_raiseAmount)
                {
                    groupBox_managerAmount.Controls[i].Text = string.Empty;
                }
            }
        }

        // Add raise percentage to the current salary
        private void btn_addPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_currentSalary2.Text) is double && Convert.ToDouble(txt_raisePercentage.Text) is double)
                {
                    double sumPercentage;
                    sumPercentage = Convert.ToDouble(txt_currentSalary2.Text) * (Convert.ToDouble(txt_raisePercentage.Text) / 100);
                    dataGridView_manager.CurrentRow.Cells[7].Value = Convert.ToDouble(txt_currentSalary2.Text) + sumPercentage;
                    
                }
                else
                {
                    throw new Exception();
                }

            }
            catch
            {
                MessageBox.Show("Unidentified Input Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Clear the raise percentage text box
        private void btn_clearPercentage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_percentage.Controls.Count; i++)
            {
                if (groupBox_percentage.Controls[i] == txt_raisePercentage)
                {
                    groupBox_percentage.Controls[i].Text = string.Empty;
                }
            }

        }

        // Set a new salary directly
        private void btn_addNew_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(txt_currentSalary3.Text) is int && Convert.ToInt32(txt_newSalary.Text) is int)
                {
                    dataGridView_manager.CurrentRow.Cells[7].Value = txt_newSalary.Text;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Unidentified Input Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Clear the new salary text box
        private void btn_clearNew_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_new.Controls.Count; i++)
            {
                if (groupBox_new.Controls[i] == txt_newSalary)
                {
                    groupBox_new.Controls[i].Text = string.Empty;
                }
            }
        }

        private void txt_newSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
