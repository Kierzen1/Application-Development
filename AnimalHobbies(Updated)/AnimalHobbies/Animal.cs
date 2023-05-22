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
using System.Data.SqlTypes;

namespace AnimalHobbies
{
    public partial class Animal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Maple;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public Animal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        void viewAnimals()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * from Animals");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Animals");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        void search()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * from Animals Where AnimalName like '" + textBox4.Text + "%'");
            cmd.Connection = con;
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
        void updateAnimals()
        {
            DataGridViewRow rows = dataGridView1.SelectedRows[0];
            con.Open();
            cmd = new SqlCommand("UPDATE Animals SET AnimalName = @AnimalName, AnimalGender = @AnimalGender, AnimalAge = @AnimalAge, AnimalFood = @AnimalFood, DOB = @DOB, OwnersName = @OwnersName WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(rows.Cells[0].Value.ToString()));
            
            cmd.Parameters.AddWithValue("@AnimalName", animalName.Text);
            cmd.Parameters.AddWithValue("@AnimalGender", animalGender.Text);
            cmd.Parameters.AddWithValue("@AnimalAge", animalAge.Text);
            cmd.Parameters.AddWithValue("@AnimalFood", animalFood.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@OwnersName", ownersName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void deleteAnimals()
        {
            con.Open();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            cmd = new SqlCommand("DELETE FROM Animals WHERE Id =" + int.Parse(row.Cells[0].Value.ToString()), con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void clearFields()
        {
            animalName.Clear();
            animalType.Clear();
            dateTimePicker1.ResetText();
            ownersName.Clear();
            animalFood.ResetText();
            animalGender.Clear();
            animalAge.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Animal_Load(object sender, EventArgs e)
        {
            viewAnimals();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert();
            viewAnimals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateAnimals();
            viewAnimals();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteAnimals();
            viewAnimals();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form animalhobbies = new AnimalHobbies(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            animalhobbies.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
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
            viewAnimals();
            clearFields();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Update the fields?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                updateAnimals();
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Update Cancelled!");
            }
            viewAnimals();
            clearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteAnimals();
            viewAnimals();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addHobbiesButton_Click(object sender, EventArgs e)
        {
            Form animalhobbies = new AnimalHobbies(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            animalhobbies.ShowDialog();
        }
    }
}
