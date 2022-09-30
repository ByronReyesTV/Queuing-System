using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing_System
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public Label lb2;

        public Form1()
        {
            InitializeComponent();
            instance = this;

            lb2 = new Label();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            Form3 form3 = new Form3();
            form3.Show();

            Random r = new Random();
            int genRand = r.Next(10008,10009);
            label2.Text = "P - " + genRand.ToString();

            Form2.Instance.lb2.Text = label2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This Application is created by: " + "\n" + "\n Byron Santos Reyes" + "\n BSIT - 3A", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
