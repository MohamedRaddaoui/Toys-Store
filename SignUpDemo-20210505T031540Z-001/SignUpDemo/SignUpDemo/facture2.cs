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
    public partial class facture2 : Form
    {
        int num = 0;
        String c4="";
        String c2="";
        String c3="";
        public facture2(String id, DateTime d, String somme, String nom,int num,String a1,String a2,String a3)
        {
            InitializeComponent();
            this.num = num;
            label7.Text = id.ToString();
            label8.Text = d.ToString();
            c4 = a1;
            c2 = a2;
            c3 = a3;
            label19.Text = nom;
            label11.Text = somme.ToString() + "DT";
            label12.Text = somme.ToString() + "DT";
            label9.Text = d.AddDays(3).ToString();
             SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

            table.Rows.Clear();

            try
            {

                Conn.Open();
                String req = "SELECT * FROM facture_jouet ";

                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    
                    if (l.GetValue(0).ToString().Equals(id))
                    {

                        String idjouet = l.GetValue(1).ToString();

                        Double prix = 0.0;
                        String nomjouet = "";

                        try
                        {

                            Conn2.Open();
                            String req2 = "select * FROM jouet";

                            SqlCommand mycommand2 = new SqlCommand(req2, Conn2);
                            SqlDataReader l2 = mycommand2.ExecuteReader();

                            while (l2.Read())
                            {

                                if ((l2.GetValue(0).ToString()).Equals(idjouet))
                                {

                                    nomjouet = l2.GetValue(1).ToString();
                                    prix = l2.GetDouble(6);
                                 
                                }

                            }
                            Conn2.Close();
                        }
                        catch (Exception es)
                        { MessageBox.Show(es.Message); }

                        int prix1 = int.Parse(l.GetValue(2).ToString());
                        Double k = 0.0;
                            k= prix1 * (prix);


                        table.Rows.Add(nomjouet, l.GetValue(2).ToString(), prix.ToString(), k.ToString(), l.GetValue(1).ToString());
                    }

                }

                l.Close();
                Conn.Close();

            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }



        }

        private void facture2_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                gestion_com a = new gestion_com(c4,c2,c3);
                a.Show();
                this.Hide();
            }
            if(num==2)
            {
                annulervente a = new annulervente();
                a.Show();
                this.Hide();
            
            }
        }
    }
}
