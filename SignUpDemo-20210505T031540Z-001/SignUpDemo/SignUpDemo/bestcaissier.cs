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
    public partial class bestcaissier : Form
    {
        String[] tab1 = new string[100];
        Double[] tab2 = new Double[100];
        public bestcaissier()
        {
            InitializeComponent();
           

        }

        private void bestcaissier_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }

        private void image_Click(object sender, EventArgs e)
        {

        }
        public void ini()
        {
            int i = 0;
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {

                Conn.Open();
                String req = "SELECT * FROM caissier";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {

                    tab1[i] = l.GetString(0);
                    tab2[i] = 0;
                  
                    i++;
                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
            try
            {

                Conn.Open();
                String req = "SELECT * FROM Facture";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {

                    if (l.GetDateTime(1).Month.ToString().Equals(DateTime.Today.Month.ToString()))
                        for (int m = 0; m < i; m++)
                        {

                              if (tab1[m].Equals(l.GetValue(2).ToString()))
                            { tab2[m] = tab2[m] + l.GetDouble(5); }
                        }


                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
            double max = 0.0;

            for (int n = 0; n < 100; n++)
            {
                if (tab2[n] > max)
                    max = tab2[n];
            }
            int j = 0;
            Boolean test1 = false;
            while (test1 == false && j < tab1.Length)
            {
                if (tab2[j] == max)
                {
                    test1 = true;
                    String login = tab1[j];
                    try
                    {
                        Conn.Open();
                        String req = "SELECT * FROM caissier where login='" + login + "'";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader l = mycommand.ExecuteReader();


                        while (l.Read())
                        {
                            label5.Text = max.ToString() + " Dt";

                            nom.Text = l.GetString(3) + " " + l.GetString(4);
                            image.Image = new Bitmap(l.GetValue(2).ToString());

                        }
                        l.Close();
                        Conn.Close();
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }


                }
            }


        }
    }
}
