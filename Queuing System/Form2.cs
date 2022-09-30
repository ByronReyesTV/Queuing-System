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
    public partial class Form2 : Form
    {
        public static Form2 Instance;

        public Label lb2;

        public Form2()
        {
            InitializeComponent();
            Instance = this;

            lb2 = label2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
