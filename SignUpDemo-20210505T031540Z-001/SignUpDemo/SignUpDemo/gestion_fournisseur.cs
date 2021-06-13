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
    public partial class gestion_fournisseur : Form
    {
        int num = 0;
        public gestion_fournisseur()
        {
            InitializeComponent();
            label14.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            nom.Visible = false;
            email.Visible = false;
            adresse.Visible = false;
            id1.Visible = false;
            recherche.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button4.Visible = false;

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Salmon;
            button5.BackColor = Color.Crimson;
            button6.BackColor = Color.Crimson;

            label14.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            nom.Visible = true;
            email.Visible = true;
            adresse.Visible = true;
            id1.Visible = false;
            recherche.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            button4.Visible = false;
            nom.Text = "";
            email.Text = "";
            adresse.Text = "";














        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = 1;
            button5.BackColor = Color.Salmon;
            button6.BackColor = Color.Crimson;
            button7.BackColor = Color.Crimson;

            label14.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            nom.Visible = false;
            email.Visible = false;
            adresse.Visible = false;
            id1.Visible = true;
            recherche.Visible = true;
            button3.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            id1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = 2;
       
            recherche.Visible = false;
            button6.BackColor = Color.Salmon;
            button5.BackColor = Color.Crimson;
            button7.BackColor = Color.Crimson;

            label14.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            nom.Visible = false;
            email.Visible = false;
            adresse.Visible = false;
            id1.Visible = true;
            recherche.Visible = true;
            button3.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
        }

        private void recherche_Click(object sender, EventArgs e)
        {
            String id = id1.Text;
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            if (id.Equals(""))
            {
                MessageBox.Show("saisir le id");
            }
            else
            {

                label14.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                nom.Visible = true;
                email.Visible = true;
                adresse.Visible = true;


                Boolean test9 = false;

                try
                {
                    Conn.Open();
                    String req = "SELECT * FROM fournisseur";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read() && !test9)
                    {
                        if (id.Equals(l.GetValue(0).ToString()))
                        {
                            test9 = true;

                            nom.Text = l.GetValue(1).ToString();
                            email.Text = l.GetValue(2).ToString();
                           adresse.Text= l.GetValue(3).ToString();
                        }
                    }

                    l.Close();
                    Conn.Close();
                    if (num == 1)
                    { button3.Visible = true; }
                    if (num == 2)
                    { button4.Visible = true; }
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }
                if (test9 == false)
                { MessageBox.Show("ID invalide"); }
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {

                Conn.Open();
                String req = "SELECT  * FROM fournisseur";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    data.Rows.Add(l.GetValue(0).ToString(), l.GetValue(1).ToString(),  l.GetValue(2).ToString(), l.GetValue(3).ToString());

                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = id1.Text;
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            if (id.Equals(""))
            {
                MessageBox.Show("saisir le id");
            }
            else
            {
                Boolean test7 = false;
                try
                {

                    Conn.Open();
                    String req = "SELECT  id FROM fournisseur";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read() && !test7)
                    {
                        if (id.Equals(l.GetValue(0).ToString()))
                            test7 = true;
                    }

                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }
                if (test7 == false)
                { MessageBox.Show("ID invalide"); }
                else
                {


                    try
                    {
                        Conn.Open();
                        String req = "delete from fournisseur where id='" + id + "'";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("fournisseur supprime avec succes");
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }




                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String nom1 = nom.Text;
            String email1 = email.Text;
            String addr1 = adresse.Text;
            try
            {

               if (nom1.Equals("") || email1.Equals("") || addr1.Equals(""))
                { MessageBox.Show("saisir les donnees"); }
                 else if ((!email1.Contains("@")) || (!email1.Contains(".")))
                { MessageBox.Show("Forme de l'email n'est pas valide"); }
                else
                {
                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                   
                    try
                    {
                        Conn.Open();
                        String req = "insert into fournisseur(nom,mail,adresse) values( '" + nom1 + "','" + email1 + "','" + addr1 +"')";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Fournisseur ajoute avec succes");
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                }
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            String id = id1.Text;
            String nom1 = nom.Text;
            String email1 = email.Text;
            String addr1 = adresse.Text;
            try
            {
               

                if (nom1.Equals("") || id.Equals("") || email1.Equals("" )|| addr1.Equals(""))
                { MessageBox.Show("saisir les donnees"); }
                 else if ((!email1.Contains("@") )|| ( !email1.Contains(".")))
              
                { MessageBox.Show("Forme de l'email n'est pas valide"); }
                else
                {
                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                  
                    try
                    {
                        Conn.Open();
                        String req = "update  fournisseur set nom='" + nom1 + "',mail='" + email1 + "',adresse='" + addr1 + "' where id='"+id+"'";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("Fournisseur modifie avec succes");
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                }
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }

        private void gestion_fournisseur_Load(object sender, EventArgs e)
        {

        }
    }
}
