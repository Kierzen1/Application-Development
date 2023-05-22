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

namespace AnimalHobbies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form hobbyForm = new Hobby();
            hobbyForm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form animalForm = new Animal();
            animalForm.ShowDialog();
        }

        private void animalKingdomRegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form animalForm = new Animal();
            animalForm.ShowDialog();
        }

        private void hobbyEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form hobbyForm = new Hobby();
            hobbyForm.ShowDialog();
        }

        private void viewAnimalHobbiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHobby vh = new ViewHobby(); 
            vh.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
