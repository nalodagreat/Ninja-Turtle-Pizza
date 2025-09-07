using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        private int price = 0;

        // 🔹 Variabili per la gestione dei topping
        private string toppings = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\pc\Downloads\c#\desktopApp1\desktopApp1\which-pizza-toppings-do-you-think-each-of-the-turtles-would-v0-pwnipxsez97c1.jpg");
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void updatePrice(enType size)
        {
            price = (int)size;
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked)
            {
                label7.Text = enType.large.ToString();
                updatePrice(enType.large);
                label3.Text = price.ToString() + "$";
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2.Checked)
            {
                label7.Text = enType.medium.ToString();
                updatePrice(enType.medium);
                label3.Text = price.ToString() + "$";
            }
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3.Checked)
            {
                label7.Text = enType.small.ToString();
                updatePrice(enType.small);
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

        private void label4_Click(object sender, EventArgs e) { }

        // 🔹 Metodo aggiornato per gestire tutti i topping
        private void updateToppings()
        {
            string result = "";

            if (ckb1.Checked) result += ckb1.Text + ",";
            if (ckB2.Checked) result += ckB2.Text + ",";
            if (ckB3.Checked) result += ckB3.Text + ",";
            if (ckB4.Checked) result += ckB4.Text + ",";
            if (ckB5.Checked) result += ckB5.Text + ",";
            if (ckB6.Checked) result += ckB6.Text + ",";

            // Rimuove l'ultima virgola se presente
            if (result.EndsWith(","))
                result = result.Substring(0, result.Length - 1);

            // Inserisce a capo ogni 2 topping
            string formatted = "";
            string[] arr = result.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                formatted += arr[i];
                if ((i + 1) % 2 == 0 && i != arr.Length - 1)
                    formatted += "\n";
                else if (i != arr.Length - 1)
                    formatted += ",";
            }

            label8.Text = formatted;
        }

        private void ckb1_CheckedChanged(object sender, EventArgs e)
        {
            price += ckb1.Checked ? 1 : -1;
            label3.Text = price.ToString() + "$";
            updateToppings();
        }

        private void ckB2_CheckedChanged(object sender, EventArgs e)
        {
            price += ckB2.Checked ? 1 : -1;
            label3.Text = price.ToString() + "$";
            updateToppings();
        }

        private void ckB3_CheckedChanged(object sender, EventArgs e)
        {
            price += ckB3.Checked ? 1 : -1;
            label3.Text = price.ToString() + "$";
            updateToppings();
        }

        private void ckB4_CheckedChanged(object sender, EventArgs e)
        {
            price += ckB4.Checked ? 2 : -2;
            label3.Text = price.ToString() + "$";
            updateToppings();
        }

        private void ckB5_CheckedChanged(object sender, EventArgs e)
        {
            price += ckB5.Checked ? 1 : -1;
            label3.Text = price.ToString() + "$";
            updateToppings();
        }

        private void ckB6_CheckedChanged(object sender, EventArgs e)
        {
            price += ckB6.Checked ? 1 : -1;
            label3.Text = price.ToString() + "$";
            updateToppings();
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            if(rb10.Checked)
            {
                label9.Text=rb10.Text;
            }
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            if (rb7.Checked)
            {
                label9.Text = rb7.Text;
            }

        }
    }
}
