using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Form1 : Form
    {
        LinqtoSqlClassDataContext db;

        public Form1()
        {
            InitializeComponent();
        }
        void showTable()
        {
            db = new LinqtoSqlClassDataContext();
            dataGridView1.DataSource = db.tblEmployees;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    db = new LinqtoSqlClassDataContext();
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    tblEmployee EN = db.tblEmployees.FirstOrDefault(s => s.EmpNo == id);
                    EN.EmpNo = Convert.ToInt32(textBox1.Text);
                    EN.EmpName = textBox2.Text;
                    EN.DeptID = Convert.ToInt32(textBox3.Text);

                    db.SubmitChanges();
                    MessageBox.Show("Data has been Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                }
                else
                {
                    MessageBox.Show("Please Select a Row");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter all fields");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new LinqtoSqlClassDataContext();
            tblEmployee EN = new tblEmployee();
            EN.EmpName = textBox1.Text;
            EN.EmpSalary = Convert.ToInt32(textBox3.Text);
            EN.DeptID = Convert.ToInt32(textBox4.Text);
            db.tblEmployees.InsertOnSubmit(EN);
            db.SubmitChanges();
            showTable();
        }
    }
}

   

