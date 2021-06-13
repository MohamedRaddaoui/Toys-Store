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
    public partial class facture : Form
    {
        String idc;
        double somme1;
        public facture(String idclient,Double somme)
        {
            InitializeComponent();
            label11.Text = somme + "DT";
            label12.Text = somme + "DT";
            somme1 = somme;
           label8.Text =  DateTime.Now.ToString();
            label9.Text=  DateTime.Now.AddDays(15).ToString();
            idc = idclient;
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

            Double total = 0;
            table.Rows.Clear();

            try
            {

                Conn.Open();
                String req = "SELECT pannier.quantite,jouet.nom,jouet.photo,jouet.prix,pannier.id_jouet,pannier.id_cmd FROM pannier,jouet where pannier.id_client='" + idclient + "' and pannier.id_jouet= jouet.id";
               
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    label7.Text = l.GetValue(5).ToString();

                   int n = l.GetInt32(0);
                   
                    double k = (l.GetDouble(3));
                    double k1 = 0;
                    for (int i = 0; i < n; i++)
                    {
                        k1 = k1 + k;
                    }
                    total = total + k1;
                    table.Rows.Add(l.GetValue(1).ToString(), l.GetValue(0).ToString(), l.GetValue(3).ToString()+"DT", k1 + " DT",l.GetValue(4).ToString());


                }

                l.Close();
                Conn.Close();
               
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facture_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            SqlConnection Conn3 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

            SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            String date = DateTime.Now.ToString();
            int id_fac=0;
            try
            {
                Conn.Open();
               
                String req3 = "insert into Facture(date,login_client,situation,login_caissier,somme) values( '" + date+ "','" + idc + "','0',' ','"+somme1+"')";
                SqlCommand mycommand3 = new SqlCommand(req3, Conn);
                mycommand3.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
            ///////////////////
            ////////////////////
            ///
            try

            {
                Conn3.Open();
                String req = "SELECT id FROM facture where login_client='" + idc + "' and date= '" + date + "'";

                SqlCommand mycommand = new SqlCommand(req, Conn3);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    id_fac = l.GetInt32(0);
                }
                Conn3.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
            /////////////////
            ///////////////////
            /////////////////
            for (int i=0;i<table.RowCount-1;i++)
            {

                String id = table.Rows[i].Cells[4].Value.ToString();
             
                String total = table.Rows[i].Cells[1].Value.ToString();

                try

                {
                    Conn2.Open();
                      String req2 = "insert into facture_jouet(id_fact,id_jouet,quantite) values( '" + id_fac + "','" + id + "','"+total+"')";
                    SqlCommand mycommand2 = new SqlCommand(req2, Conn2);
                    mycommand2.ExecuteNonQuery();  
                    Conn2.Close();

                }
               catch (Exception es)
               { MessageBox.Show(es.Message); }

              
            }




            try
            {
                Conn.Open();
                String req7 = "delete from pannier where id_client='" + idc + "'";
                SqlCommand mycommand7 = new SqlCommand(req7, Conn);
                mycommand7.ExecuteNonQuery();
               
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }


            MessageBox.Show("Votre commande est enregistre");
            shop a = new shop();
            a.id1 = idc;
            a.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panier p = new panier(idc);
            p.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
