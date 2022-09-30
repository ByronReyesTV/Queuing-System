using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Queuing_System
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue my_queue = new Queue();

            my_queue.Enqueue("10001");
            my_queue.Enqueue("10002");
            my_queue.Enqueue("10003");
            my_queue.Enqueue("10004");
            my_queue.Enqueue("10005");
            my_queue.Enqueue("10006");
            my_queue.Enqueue("10007");

            listBox1.Items.Add("P - 10001");
            listBox1.Items.Add("P - 10002");
            listBox1.Items.Add("P - 10003");
            listBox1.Items.Add("P - 10004");
            listBox1.Items.Add("P - 10005");
            listBox1.Items.Add("P - 10006");
            listBox1.Items.Add("P - 10007");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Queue my_queue = new Queue();

            my_queue.Enqueue("10001");
            my_queue.Enqueue("10002");
            my_queue.Enqueue("10003");
            my_queue.Enqueue("10004");
            my_queue.Enqueue("10005");
            my_queue.Enqueue("10006");
            my_queue.Enqueue("10007");

            listBox1.Items.Clear();

            listBox1.Items.Add("P - 10001");
            listBox1.Items.Add("P - 10002");
            listBox1.Items.Add("P - 10003");
            listBox1.Items.Add("P - 10004");
            listBox1.Items.Add("P - 10005");
            listBox1.Items.Add("P - 10006");
            listBox1.Items.Add("P - 10007");
            listBox1.Items.Add("P - 10008");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
