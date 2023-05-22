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
    public partial class Hobby : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=Maple;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public Hobby()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        void viewHobby()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * from Hobby");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Hobby");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        void insertHobby()
        {
            con.Open();
            cmd = new SqlCommand("Insert into Hobby (HobbyName) Values('" + textBox2.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            textBox2.Clear();
        }
        void deleteHobby()
        {
            con.Open();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            cmd = new SqlCommand("DELETE FROM Hobby WHERE Id =" + int.Parse(row.Cells[0].Value.ToString()), con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Hobby_Load(object sender, EventArgs e)
        {
            viewHobby();
            dataGridView1.Columns[0].Visible=false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertHobby();
            viewHobby();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteHobby();
            viewHobby();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            insertHobby();
            viewHobby();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteHobby();
            viewHobby();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
