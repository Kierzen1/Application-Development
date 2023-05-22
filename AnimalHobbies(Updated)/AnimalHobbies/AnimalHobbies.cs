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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalHobbies
{
    public partial class AnimalHobbies : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Maple;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        int id;
        public AnimalHobbies(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.id = id;
        }
        void addToAnimal(int hobbyID)
        {
            con.Open();
            cmd = new SqlCommand("Insert into AnimalHobbies (hobbyID, animalID) Values("+ hobbyID +", "+id+")");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void deleteAnimal(int hobbyID)
        {
            con.Open();
            cmd = new SqlCommand("DELETE FROM AnimalHobbies WHERE animalID = "+id+" AND hobbyID = "+hobbyID+"", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void viewAH()
        {
            con.Open();
            cmd = new SqlCommand("SELECT Hobby.* FROM Hobby INNER JOIN AnimalHobbies ON Hobby.Id = AnimalHobbies.hobbyID WHERE AnimalHobbies.animalID = " + id);
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Hobby");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        void selectAll() 
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Hobby");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader(); 
            while (dr.Read()) 
            {
                checkedListBox1.Items.Add(""+ dr.GetString(1)+ "\r\n," + dr.GetInt32(0)+"");
            }
            con.Close();
        }
        private void AnimalHobbies_Load(object sender, EventArgs e)
        {
            viewAH();
            selectAll();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int hobbyID = int.Parse(checkedListBox1.Items[e.Index].ToString().Split(',')[1]);
            if (e.NewValue == CheckState.Checked)
            {
                addToAnimal(hobbyID);
            }
            else
            {
                deleteAnimal(hobbyID);
            }
            viewAH();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
