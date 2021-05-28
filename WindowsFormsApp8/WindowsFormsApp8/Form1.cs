using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int countSings = 0;

        public List<Sings> ListSings = new List<Sings>();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            countSings++;
            label6.Text = $"{countSings}";
            ListSings.Add(new Sings("Razer Naga Pro", 1, 60));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            countSings++;
            label6.Text = $"{countSings}";
            ListSings.Add(new Sings("Razer Nari", 2, 120));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            countSings++;
            label6.Text = $"{countSings}";
            ListSings.Add(new Sings("Razer Huntsman", 3, 190));
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            countSings++;
            label6.Text = $"{countSings}";
            ListSings.Add(new Sings("Razer Seiren", 4, 250));
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(countSings,ListSings);
            form2.Show();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       private void label5_Click(object sender, EventArgs e)
       {

       }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
