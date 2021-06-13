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
    public partial class ADD_produit : Form
    {
        float prix1 ;
       public float prixtt;
       public int qq = 0;
        int id1;
        String id_client1;
        public ADD_produit(int id ,String id_client)
        {
            InitializeComponent();
            id1 = id;
            id_client1 = id_client;
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
           

            try
            {
                Conn.Open();
                String req = "SELECT * FROM jouet ";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    if (id.ToString().Equals(l.GetValue(0).ToString()))
                    {

                        nom.Text = l.GetValue(1).ToString();
                        prix.Text=l.GetValue(6).ToString()+"DT";
                        label6.Text = l.GetDouble(6)+ "DT";
                         image.Image= new Bitmap(l.GetValue(5).ToString());
                        prix1 = float.Parse(l.GetValue(6).ToString());
                        prixtt= float.Parse(l.GetValue(6).ToString());
                     
                    }
                }

                l.Close();
                Conn.Close();

            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
           

        
    
      
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            qq = int.Parse(label1.Text);
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
          
            try
            {
                Conn.Open();
                String req = "insert into pannier(id_client,id_jouet,quantite) values('"+id_client1 + "','" + id1 + "','" + qq + "')";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                mycommand.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

            this.Hide();
        }

        private void ADD_produit_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Equals("1"))
            { MessageBox.Show("la quantite ne peut pas etre inférieure a 1"); }
            else
            {
                int k = int.Parse(label1.Text) - 1;
                label1.Text = "" + k;

                prixtt -= prix1;
                label6.Text = prixtt + "Dt";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        { int k = int.Parse(label1.Text) + 1;
                label1.Text = "" + k;
                prixtt += prix1;
                label6.Text = prixtt + "Dt"; }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panier p = new panier(id_client1);
            p.Show();
            this.Hide();
        }

        private void image_Click(object sender, EventArgs e)
        {

        }
    }
}
