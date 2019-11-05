using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class StartInfo : Form
    {
        public StartInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HelpBox helpBox = new HelpBox();
            helpBox.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.Show();
        }
    }
}
