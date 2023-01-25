using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=POOLW42SLPC6514;Initial Catalog=DWConfiguration;Integrated Security=True");

        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public void ShowData()
        {
            SqlCommand cmd = new SqlCommand("Select * from tblEmployee", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            /*if (reader.HasRows)
            {
                dataGridView1.DataSource = reader;
            }*/
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            reader.Close();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (cmd = new SqlCommand("sp_InsertEmployees", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.Add("@empName", SqlDbType.VarChar, 20).Value = textEmpName.Text;
                cmd.Parameters.Add("@empSalary", SqlDbType.Float).Value = Convert.ToSingle(textEmpSalary.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Row Added To Table");
                }
                else
                {
                    MessageBox.Show("Error 404!");
                }
                conn.Close();
                ShowData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (cmd = new SqlCommand("sp_UpdateEmployee", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.Add("@EmpNo", SqlDbType.Int).Value = Convert.ToInt32(txtEmpNo.Text);
                cmd.Parameters.Add("@EmpName", SqlDbType.VarChar, 20).Value = textEmpName.Text;
                cmd.Parameters.Add("@EmpSalary", SqlDbType.Float).Value = Convert.ToSingle(textEmpSalary.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Update The Table");
                }
                else
                {
                    MessageBox.Show("Error 404!");
                }
                conn.Close();
                ShowData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (cmd = new SqlCommand("sp_DeleteEmployee", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.Parameters.Add("@EmpNo", SqlDbType.Int).Value = Convert.ToInt32(txtEmpNo.Text);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Row Deleted");
                }
                else
                {
                    MessageBox.Show("Error 404!");
                }
                conn.Close();
                ShowData();
            }
        }
    }
}
