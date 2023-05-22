using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalProject_Booc
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
   
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
        void searchAnimal() 
        {
            con.Open();
            cmd = new SqlCommand("Select  AnimalName, AnimalAge, AnimalType, AnimalColor, AnimalGender, DOB from Animal "
                + " where AnimalName like '" + searchBox.Text + "%'");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "Animal");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
       
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            viewAnimal();
        }

        void viewAnimal() 
        {
            con.Open();
            cmd = new SqlCommand("Select  AnimalName, AnimalAge, AnimalType, AnimalColor, AnimalGender, DOB, AnimalID from Animal ");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Animal");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e) //SAVE BUTTON
        {
            DialogResult r = MessageBox.Show("Are all entries correct? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                saveAnimal();
                MessageBox.Show("Animaal is added succesfully!");
                clearFields();
            }
            else
            {
                MessageBox.Show("Data entry cancelled!");
                clearFields();
            }
            viewAnimal();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            updateAnimal();
            MessageBox.Show("Animaal name: " + nameBox.Text + " has been updated succesfully!");
            viewAnimal();
            clearFields();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from Animal where AnimalName = '" + nameBox.Text + "'");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void clearFields()
        {
            nameBox.Text = "";
            ageBox.Text = "";
            typeBox.Text = "";
            colorBox.Text = "";
            birthdayPicker.Text = "";
            id_box.Text = "";
            genderBox.Text = "";
        }
        void updateAnimal()
        {
            /*DataGridViewRow rows = dataGridView1.SelectedRows[0];
            con.Open();
            cmd = new SqlCommand("UPDATE Animal SET AnimalName = @AnimalName, AnimalAge = @AnimalAge, AnimalType = @AnimalType, AnimalColor = @AnimalColor, AnimalGender = @AnimalGender, DOB = @DOB WHERE AnimalID = @AnimaliD", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(rows.Cells[0].Value.ToString()));
            cmd.Parameters.AddWithValue("@AnimalName", nameBox.Text);
            cmd.Parameters.AddWithValue("@AnimalAge", ageBox.Text);
            cmd.Parameters.AddWithValue("@AnimalType", typeBox);
            cmd.Parameters.AddWithValue("@AnimalColor", colorBox.Text);
            cmd.Parameters.AddWithValue("@AnimalGender", genderBox.Text);
            cmd.Parameters.AddWithValue("@DOB", birthdayPicker.Value);
            cmd.Parameters.AddWithValue("@AnimalID", id_box.Text);
            cmd.ExecuteNonQuery();*/
            //con.Close();

            con.Open();
            cmd = new SqlCommand("update Animal set AnimalName = '" + nameBox.Text
                + "',"
                + " AnimalAge = '" + ageBox.Text 
                + "', AnimalType = '" + typeBox.Text 
                + "',"
                + " AnimalColor = '" + colorBox.Text
                + "', AnimalGender = '" + genderBox.Text 
                + "'"
                + ",DOB = @DOB" 
                + " where AnimalID ="+ int.Parse(id_box.Text));
            cmd.Parameters.AddWithValue("@DOB", birthdayPicker.Value.Date);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void saveAnimal()
        {

            con.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "insert into Animal "
                + "(ANIMALNAME, ANIMALAGE, ANIMALTYPE, ANIMALCOLOR, ANIMALGENDER, ANIMALID, DOB) "
                + "values('" + nameBox.Text + "','" + ageBox.Text + "', '" + typeBox.Text + "', "
                + " '" + colorBox.Text + "', '" + genderBox.Text + "', '" + id_box.Text + "', @DOB)";
            cmd.Parameters.AddWithValue("@DOB", birthdayPicker.Value.Date);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        private void button5_Click(object sender, EventArgs e) //EXIT BUTTON
        {
            Application.Exit();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nameBox.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            ageBox.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            typeBox.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            colorBox.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            genderBox.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            birthdayPicker.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            id_box.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchAnimal();
        }  
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchAnimal();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
             clearFields();
        }

        private void clearTable_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(0);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
