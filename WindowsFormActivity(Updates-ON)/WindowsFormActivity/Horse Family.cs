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
    public partial class Horse_Family : Form
    {
        public Horse_Family()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text+ " " + textBox2.Text + " " + textBox3.Text + " "+ textBox4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count != 0)
            {
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "" + textBox4.Text;
                listBox1.SelectedIndex.ToString(textBox1.Text);



            }
            else
                MessageBox.Show("Select an item to Update!");
        }
    }
}
