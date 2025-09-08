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
            rb8.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("u saved us from shreddder!", "Mission Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            rdb1.Enabled = false;
            rdb2.Enabled = false;
            rdb3.Enabled = false;
            ckb1.Enabled=false;
            ckB2.Enabled=false;
            ckB3.Enabled=false;
            ckB4.Enabled=false;
            ckB5.Enabled=false;
            ckB6.Enabled=false;
            rb9.Enabled=false;
            rb10.Enabled=false;
            rb7.Enabled=false;
            rb8.Enabled = false;
            rb8.Enabled = false;
            rb8.Enabled = false;
            button1.Enabled = false;
            button1.BackColor = Color.Silver;
            gb1.BackColor = Color.Silver;
            gb2.BackColor = Color.Silver;
            groupBox1.BackColor = Color.Silver;
            groupBox2.BackColor = Color.Silver;
            groupBox3.BackColor = Color.Silver;
            //button2.Focus();

        }

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
                label11.Text = rb9.Text;
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            if(rb8.Checked)
            {
                label11.Text=rb8.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            rdb1.Checked = true;
            rb8.Checked = true;

            rdb1.Enabled =true;
            rdb2.Enabled = true;
            rdb3.Enabled = true;
            ckB2.Enabled=true;
            ckB3.Enabled=true;
            ckB4.Enabled=true;
            ckB5.Enabled=true;
            ckB6.Enabled=true;
            rb9.Enabled= true;
            rb10.Enabled=true;
            rb7.Enabled= true;
            
            ckb1.Enabled = true;
            rb8.Enabled =true;
           
            button1.Enabled = true;

            //
           
            rdb2.Checked= false;
            rdb3.Checked= false;
            ckB2.Checked= false;
            ckB3.Checked= false;
            ckB4.Checked= false;
            ckB5.Checked= false;
            ckB6.Checked= false;
            rb9. Checked= false;
            rb10.Checked= false;
            rb7. Checked= false;
            ckb1.Checked= false;
            button1.Enabled = true;
            button1.BackColor = Color.Black;
            gb1.BackColor = Color.Red;
            gb2.BackColor = Color.Red;
            groupBox1.BackColor = Color.Red;
            groupBox2.BackColor = Color.Red;
            groupBox3.BackColor = Color.Red;
        }
    }
}
