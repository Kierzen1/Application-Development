using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormActivity
{
    public partial class Animal_Kingdom : Form
    {
        public Animal_Kingdom()
        {
            InitializeComponent();
        }

        private void canineButton_Click(object sender, EventArgs e)
        {
            Form canine = new Canine_Family();
            canine.ShowDialog();
        }

        private void felineButton_Click(object sender, EventArgs e)
        {
            Form feline = new Feline_Family();
            feline.ShowDialog();
        }

        private void horseButton_Click(object sender, EventArgs e)
        {
            Form horsey = new Horse_Family();
            horsey.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
