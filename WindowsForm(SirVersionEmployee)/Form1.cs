using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=Database2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Form1()
        {
           InitializeComponent();
           
        }
      
        void saveEmployee()
        {
           
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "insert into Employee "
                + "(EMP_TITLE, EMP_LNAME, EMP_FNAME, EMP_INITIAL, EMP_JOB, EMP_HIRE_DATE) "
                + "values('"+ textBox1.Text +"','"+ textBox2.Text +"', '"+ textBox3.Text +"', "
                + " '"+ textBox4.Text +"', '"+ textBox5.Text +"', @emp_hire_date)";
            cmd.Parameters.AddWithValue("@emp_hire_date",dateTimePicker1.Value.Date);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void viewEmployee()
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            con.Open();
            cmd = new SqlCommand("select * from employee");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds,"employee");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        void search()
        {
           
            con.Open();
            cmd = new SqlCommand("select * from employee where EMP_LNAME like '"+ textBox6.Text  +"%'");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "employee");
            con.Close(); 
            dataGridView1.DataSource = ds.Tables[0];
          
        }
      
        void deleteEmployee(string lname)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are all entries correct? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (r == DialogResult.Yes )
            {
                saveEmployee();
                 MessageBox.Show("Employee is added succesfully!");
                 clearFields();
            }
            else {
                MessageBox.Show("Data entry cancelled!");
                clearFields();
            }
            viewEmployee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewEmployee();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            search();
        }
        void clearFields() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[5, e.RowIndex].Value.ToString();
           dateTimePicker1.Text = dataGridView1[6,e.RowIndex].Value.ToString();
        }
        void updateEmployee()
        {
            con.Open();
            cmd = new SqlCommand("update Employee set emp_title = '" + textBox1.Text + "',"
                + " emp_lname = '" + textBox2.Text + "', emp_fname = '" + textBox3.Text + "',"
                + " emp_initial = '" + textBox4.Text + "', emp_job = '" + textBox5.Text + "'"
                + ",emp_hire_date = @emp_hire_date"
                + " where emp_num = '" + textBox7.Text + "' ");
            cmd.Parameters.AddWithValue("@emp_hire_date", dateTimePicker1.Value.Date);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void deleteEmployee()
        {
            con.Open();
            cmd = new SqlCommand("delete from employee where emp_num = '"+ textBox7.Text +"'");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            updateEmployee();
            MessageBox.Show("Employee number: " + textBox7.Text + " has been updated succesfully!");
            viewEmployee();
            clearFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewEmployee();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteEmployee();
            MessageBox.Show("Employee number: " + textBox7.Text + " is successfully deleted!");
            viewEmployee();
            clearFields();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
