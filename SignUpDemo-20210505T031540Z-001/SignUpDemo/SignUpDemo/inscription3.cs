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
   
    public partial class inscription3 : Form
    {
        Boolean test = false;
        String image1 = "";
        public inscription3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = a1.Text;
            String prenom = a2.Text;
            String num = a3.Text;
            String numsuc = a4.Text;
            String mot = a5.Text;
            String mot2 = a6.Text;
            String login = a7.Text;
            if(nom.Equals("")|| numsuc.Equals("") || prenom.Equals("") || num.Equals("") || mot.Equals("") || mot2.Equals("") || login.Equals("") )

            { MessageBox.Show("saisir les donnees"); }
            else if (!mot.Equals(mot2))
            { MessageBox.Show("la confirmation de le mot de passe est incorrecte"); }
            else if(test==false)
                { MessageBox.Show("choisir une photo"); }
            else
            {
                Boolean test = false;
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {

                    Conn.Open();
                    String req = "SELECT  * FROM caissier";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();


                    while (l.Read() && !test)
                    {
                        if (l.GetString(0).Equals(login))
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
                if (test == false)
                {
                    SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");



                    try
                    {
                        Conn2.Open();
                        String req2 = "insert into caissier(login,password,photo,nom,prenom,numero_teleph,numero_securite) values( '" + login + "','"+mot+"','" +image1+ "','" + nom + "','" + prenom + "','" +num + "','" + numsuc + "')";
                        SqlCommand mycommand2 = new SqlCommand(req2, Conn2);
                        mycommand2.ExecuteNonQuery();
                        MessageBox.Show("inscription enregistre");
                        Conn2.Close();
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                    a1.Text = "";
                    a2.Text = "";
                    a3.Text = "";
                    a4.Text = "";
                    a5.Text = "";
                    a6.Text = "";
                    a7.Text = "";
                    photo.Image = null;
                }
            }




        }

        private void pho_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // open.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //   display image in picture box  
                photo.Image = new Bitmap(open.FileName);
                //  imgLoc = open.FileName.ToString();
                // image file path  


                // photo.ImageLocation = imgLoc;
                image1 = open.FileName;
                test = true;

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inscription3_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
