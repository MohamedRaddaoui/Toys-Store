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
    public partial class panier : Form
    {
        String id2="";
        Double somm;
        public panier(String id)
        {
            double total = 0;
            id2 = id;
            InitializeComponent();
            table.Rows.Clear();
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            
            try
            {

                Conn.Open();
                String req = "SELECT pannier.quantite,jouet.nom,jouet.photo,jouet.prix,pannier.id_jouet FROM pannier,jouet where pannier.id_client='" + id2+"' and pannier.id_jouet= jouet.id";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {


                   int n = l.GetInt32(0);
                  //  float k = l.GetFloat(3);
                    double k = (l.GetDouble(3));
                   double k1 = 0;
                       for(int i=0;i<n;i++)
                    {
                              k1 = k1+k;
                    }
                    total = total + k1;
                        table.Rows.Add(new Bitmap(l.GetValue(2).ToString()), l.GetValue(1).ToString(), l.GetValue(0).ToString() , l.GetValue(3).ToString()+"DT" ,k1+" DT", l.GetValue(4).ToString());
                    somm = total;
                   
                }
                
                l.Close();
                Conn.Close();
                label3.Text = "TOTAL = " + total + " DT";
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

            int selectedrowindex = table.SelectedCells[4].RowIndex;
            DataGridViewRow selectedRow = table.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Column1"].Value);
            try
            {
                Conn.Open();
                String req = "delete from pannier where id_jouet='" + cellValue + "'";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                mycommand.ExecuteNonQuery();
                MessageBox.Show("jouet supprime avec succes");
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
            Double total = 0;
            table.Rows.Clear();
           
            try
            {

                Conn.Open();
                String req = "SELECT pannier.quantite,jouet.nom,jouet.photo,jouet.prix,pannier.id_jouet FROM pannier,jouet where pannier.id_client='" + id2 + "' and pannier.id_jouet= jouet.id";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {


                    int n = l.GetInt32(0);
                    //  float k = l.GetFloat(3);
                    double k = (l.GetDouble(3));
                    double k1 = 0;
                    for (int i = 0; i < n; i++)
                    {
                        k1 = k1 + k;
                    }
                    total = total + k1;
                    table.Rows.Add(new Bitmap(l.GetValue(2).ToString()), l.GetValue(1).ToString(), l.GetValue(0).ToString(), l.GetValue(3).ToString() + "DT", k1 + " DT", l.GetValue(4).ToString());

                    somm = total;
                }

                l.Close();
                Conn.Close();
                label3.Text = "TOTAL = " + total + " DT";
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

        }

        private void panier_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shop a = new shop();
            a.id1 = id2;
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            facture f = new facture(id2, somm);
            f.Show();
            this.Hide();
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
