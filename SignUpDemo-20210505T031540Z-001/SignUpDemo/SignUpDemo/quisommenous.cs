using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class quisommenous : Form
    {
        public String id1;
        public quisommenous()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            shop a = new shop();
            a.id1 = id1;
            a.Show();
            this.Hide();
        }

        private void quisommenous_Load(object sender, EventArgs e)
        {

        }
    }
}
