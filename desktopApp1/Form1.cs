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
        private Panel box;
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
    }
}
