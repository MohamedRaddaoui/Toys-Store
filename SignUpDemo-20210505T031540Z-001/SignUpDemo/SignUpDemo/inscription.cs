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
    public partial class inscription : Form
    {
        public inscription()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = a1.Text;
            String prenom = a2.Text;
            String email = a3.Text;
            String login = a4.Text;
            String mot = a5.Text;
            String mot2 = a6.Text;
            if(nom.Equals("")||prenom.Equals("")||email.Equals("")||login.Equals("")||mot.Equals("")||mot2.Equals(""))
            {
                MessageBox.Show("saisir les donnees");
            }
            else if(!mot.Equals(mot2))
            { MessageBox.Show("la confirmation de le mot de passe est incorrecte"); }
            else if ((!email.Contains("@")) || (!email.Contains(".")))
            { MessageBox.Show("Forme de l'email n'est pas valide"); }
            else
            {
                Boolean test = false;
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {

                    Conn.Open();
                    String req = "SELECT * FROM  client ";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    
                    while (l.Read() && !test)
                    {
                        if(l.GetString(4).Equals(login))
                        {
                            test = true;
                            MessageBox.Show("login deja existe saisir un autre login");
                        }
                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }
                if(test==false)
                {
                    SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");



                    try
                    {
                        Conn2.Open();
                        String req2 = "insert into client(mail,nom,prenom,login,motdepasse) values( '" + email + "','" + nom + "','" + prenom+ "','" +login+ "','" + mot + "')";
                        SqlCommand mycommand2 = new SqlCommand(req2, Conn2);
                        mycommand2.ExecuteNonQuery();
                        MessageBox.Show("inscription enregistre");
                        Conn2.Close();
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inscription_Load(object sender, EventArgs e)
        {

        }
    }
}
