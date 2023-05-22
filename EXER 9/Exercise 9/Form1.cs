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
using System.Xml;
//ANOTHER APPROACH
namespace Exercise_9
{
    public partial class Form1 : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Maple;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewForm();
            dataGridView1.Columns[0].Visible = false;
        }
        void viewForm() 
        {
            con.Open();
            cmd = new SqlCommand("Select * from Animals", con);
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "Animals"); 
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        void search() 
        {
            con.Open();
            cmd = new SqlCommand("Select * FROM Animals Where AnimalType LIKE'" + searchBox.Text + "%' OR animalName LIKE '" + searchBox.Text +"%' ", con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "Animals");
            dataGridView1.DataSource = ds.Tables[0];    
            con.Close();
        }

        void insert() 
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO ANIMALS (AnimalType, AnimalName, AnimalGender, AnimalAge, AnimalFood, DOB, OwnersName) VALUES (@animalType, @animalName, @animalGender, @animalAge, @animalFood, @DOB, @ownersName)", con);
            cmd.Parameters.AddWithValue("@AnimalType", animalType.Text);
            cmd.Parameters.AddWithValue("@AnimalName", animalName.Text);
            cmd.Parameters.AddWithValue("@AnimalGender", animalGender.Text);
            cmd.Parameters.AddWithValue("@AnimalAge", animalAge.Text);
            cmd.Parameters.AddWithValue("@AnimalFood", animalFood.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@OwnersName", ownersName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void update()
        {
            DataGridViewRow rows = dataGridView1.SelectedRows[0];
            con.Open();
            cmd = new SqlCommand("UPDATE Animals SET AnimalType = @AnimalType, AnimalName = @AnimalName, AnimalGender = @AnimalGender, AnimalAge = @AnimalAge, AnimalFood = @AnimalFood, DOB = @DOB, OwnersName = @OwnersName WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(rows.Cells[0].Value.ToString()));
            cmd.Parameters.AddWithValue("@AnimalType", animalType.Text);
            cmd.Parameters.AddWithValue("@AnimalName", animalName.Text);
            cmd.Parameters.AddWithValue("@AnimalGender", animalGender.Text);
            cmd.Parameters.AddWithValue("@AnimalAge", animalAge.Text);
            cmd.Parameters.AddWithValue("@AnimalFood", animalFood.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@OwnersName", ownersName.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        void clearFields()
        {
            animalName.Clear();
            animalType.Clear();
            dateTimePicker1.ResetText();
            ownersName.Clear();
            animalGender.Clear();
            animalAge.Clear();
        }
        void delete()
        {
            DataGridViewRow rows = dataGridView1.SelectedRows[0];
            con.Open();
            cmd = new SqlCommand("DELETE FROM Animals WHERE ID = " + int.Parse(rows.Cells[0].Value.ToString()));
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            viewForm();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            search();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Insert this?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Successfully Saved!");
                insert();  
            }
            else 
            {
                MessageBox.Show("Cancelled!");
            }
            viewForm();
            clearFields();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Update the fields?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                update();
                MessageBox.Show("Updated Successfully!");
            }
            else 
            {
                MessageBox.Show("Update Cancelled!");
            }
            
            clearFields();
            viewForm();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            delete();
            viewForm();
        }

        private void animalType_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            animalType.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            animalName.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            animalGender.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            animalAge.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            animalFood.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            dateTimePicker1.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            ownersName.Text = dataGridView1[7, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ownersName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
