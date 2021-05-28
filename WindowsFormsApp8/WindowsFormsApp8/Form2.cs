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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int count,List<Sings> temp)
        {
           
            InitializeComponent();
            this.ListSings2 = temp;
            label6.Text =$"{this.countSings2 = count}";
            Sort();
        }

        private int a = 0, b = 0, c = 0, d = 0;

        private int countSings2 = 0;

        private List<Sings> ListSings2 = new List<Sings>();

        public void Sort()
        {
            
            foreach (Sings i in ListSings2)
            {
                if(i.ID==1)
                {
                    a++;
                    label12.Text = $"{a}";
                }
                if (i.ID == 2)
                {
                    b++;
                    label13.Text = $"{b}";
                }
                if (i.ID == 3)
                {
                    c++;
                    label14.Text = $"{c}";
                }
                if (i.ID == 4)
                {
                    d++;
                    label15.Text = $"{d}";
                }
            }
        }


        private void label16_Click(object sender, EventArgs e)
        {
            foreach (Sings i in ListSings2)
            {
                if (i.ID == 1 && ListSings2.Count != 0)
                {
                    if (ListSings2.Remove(i))
                    {
                        a--;
                        label6.Text = $"{--countSings2}";
                        label12.Text = $"{a}";
                        break;
                    }
                }
            }
        }


        private void label17_Click(object sender, EventArgs e)
        {
            foreach (Sings i in ListSings2)
            {
                if (i.ID == 2 && ListSings2.Count != 0)
                {
                    if (ListSings2.Remove(i))
                    {
                        b--;
                        label6.Text = $"{--countSings2}";
                        label13.Text = $"{b}";
                        break;
                    }
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            foreach (Sings i in ListSings2)
            {
                if (i.ID == 3 && ListSings2.Count != 0)
                {
                    if (ListSings2.Remove(i))
                    {
                        d--;
                        label6.Text = $"{--countSings2}";
                        label14.Text = $"{d}";
                        break;
                    }
                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            foreach (Sings i in ListSings2)
            {
                if (i.ID == 4 && ListSings2.Count != 0)
                {
                    if (ListSings2.Remove(i))
                    {
                        c--;
                        label6.Text = $"{--countSings2}";
                        label15.Text = $"{c}";
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalSum = 0;
            foreach (Sings i in ListSings2)
            {
                totalSum += i.Price;
            }

            label23.Text = $"{totalSum}$";
            label24.Text = $"{countSings2}";
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
