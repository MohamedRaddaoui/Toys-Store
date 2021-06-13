using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{

    public partial class abonnement : Form
    {
        String id1;
        public abonnement(String id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void abonner_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

            String email1 = email.Text;
            if (email1.Equals(""))
            { MessageBox.Show(" Remplir les cases"); }
            else if((!email1.Contains("@")) || (!email1.Contains(".")))
            { MessageBox.Show("Format de l'email est invalide"); }
            else
            {
                try
                {
                    Conn.Open();
                    String req = "insert into liste_email(email) values( '" + email1 + "')";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show("Merci! pour votre abonnement");
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }
                email.Text = "";
                shop p = new shop();
                p.id1 = id1;
                p.Show();
                this.Hide();
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            shop p = new shop();
            p.id1 = id1;
            p.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
