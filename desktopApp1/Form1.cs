using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopApp1
{
    public partial class Form1 : Form
    {
        private enum enType : byte
        {
            small = 5,
            medium = 10,
            large = 15
        }
        private Panel box;
        private short price=0;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\pc\Downloads\c#\desktopApp1\desktopApp1\which-pizza-toppings-do-you-think-each-of-the-turtles-would-v0-pwnipxsez97c1.jpg");
            // Adatta l'immagine alla form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void updatePrice(enType size)
        {
            price = (short)size;
        }
        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked)
            {
                updatePrice(enType.large);
                label3.Text = price.ToString() + "$";
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb2.Checked)
            {
                updatePrice(enType.medium);
                label3.Text = price.ToString() + "$";
            }
        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3.Checked)
            {
                updatePrice(enType.small);
                label3.Text = price.ToString()+"$";
            }

        }

        private void ckb1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb1.Checked)
            {
                price += 1;
                label3.Text = price.ToString() + "$";
            }
            else
            {
                price -= 1;
                label3.Text = price.ToString() + "$";
            }
        }

        private void ckB2_CheckedChanged(object sender, EventArgs e)
        {
            if(ckB2.Checked)
            { 
                price += 1;
                label3.Text = price.ToString() + "$";
            }
            else
            {
                price -= 1;
                label3.Text = price.ToString() + "$";
            }
        }

        private void ckB3_CheckedChanged(object sender, EventArgs e)
        {
            if(ckB3.Checked)
           { 
                price += 1;
                label3.Text = price.ToString() + "$";
           }
            else
            {
                price -= 1;
                label3.Text = price.ToString() + "$";
            }
        }

        private void ckB4_CheckedChanged(object sender, EventArgs e)
        {
            if(ckB4.Checked)
            { 
                price += 2;
                label3.Text = price.ToString() + "$";
            }
            else
            {
                price -= 2;
                label3.Text = price.ToString() + "$";
            }
        }

        private void ckB5_CheckedChanged(object sender, EventArgs e)
        {
            if(ckB5.Checked)
            {
                price += 1;
                label3.Text = price.ToString() + "$";
            }
            else
            {
                price -= 1;
                label3.Text = price.ToString() + "$";
            }
        }

        private void ckB6_CheckedChanged(object sender, EventArgs e)
        {
            if(ckB6.Checked) 
            {
                price += 1;
                label3.Text = price.ToString() + "$";
            }
            else
            {
                price -= 1;
                label3.Text = price.ToString() + "$";
            }
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            if (rb9.Checked)
            {
                price += 5;
                label3.Text = price.ToString() + "$";
            }
            else
            {
                price -= 5;
                label3.Text = price.ToString() + "$";
            }
        }
    }
}
