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
    public partial class caissierHome : Form
    {
        String nom;
        String prenom;
        String id1;
        public caissierHome(String a, String b,String id)
        {
            InitializeComponent();
            id1 = id;
            nom = a;
            prenom = b;
            nom1.Text = b + " " + a;
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void caissierHome_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listevente a = new listevente(id1,nom,prenom);
            a.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gestion_com a = new gestion_com(id1,nom,prenom);
            a.Show();
            this.Hide();
        }
    }
}
