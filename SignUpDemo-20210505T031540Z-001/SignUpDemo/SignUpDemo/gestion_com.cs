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
    public partial class gestion_com : Form
    {
        String login;
        String nom1;
        String prenom;
        public gestion_com(String id, String nom2,String prenom)
        {
            InitializeComponent();
            login = id;
            this.nom1 = nom2;
            this.prenom = prenom;
            table.Rows.Clear();
            

            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

            try
            {
                Conn.Open();
                String req = "SELECT * FROM Facture";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    String nom = "";

                    if (l.GetValue(4).ToString().Equals("0"))
                    {
                        String loginclient = l.GetString(3);

                        SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

                        try
                        {
                            Conn2.Open();
                            String req2 = "SELECT * FROM client";
                            SqlCommand mycommand2 = new SqlCommand(req2, Conn2);
                            SqlDataReader l2 = mycommand2.ExecuteReader();
                            Boolean test9 = false;

                            while (l2.Read() && !test9)
                            {
                                if (l2.GetString(4).Equals(loginclient))
                                {
                                    test9 = true;

                                    nom = l2.GetString(2) + " " + l2.GetString(3);


                                }
                            }
                        }
                        catch (Exception es)
                        { MessageBox.Show(es.Message); }



                        table.Rows.Add(l.GetValue(0).ToString(), nom, l.GetValue(1).ToString(), l.GetValue(5).ToString());

                    }
                    
                }

                l.Close();
                Conn.Close();

            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gestion_com_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedrowindex = table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = table.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["id_Commande"].Value);
            string cellValue1 = Convert.ToString(selectedRow.Cells["id_client"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["date_Commande"].Value);
            string cellValue3 = Convert.ToString(selectedRow.Cells["Montant"].Value);
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
           
            try
            {
                Conn.Open();
                String req = "update  Facture set login_caissier='" +login + "',situation='1' where id ='" + cellValue + "'";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                mycommand.ExecuteNonQuery();
                MessageBox.Show("Facture valide avec succes");
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

            table.Rows.Clear();


       
            try
            {
                Conn.Open();
                String req = "SELECT * FROM Facture";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    String nom = "";

                    if (l.GetValue(4).ToString().Equals("0"))
                    {
                        String loginclient = l.GetString(3);

                        SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

                        try
                        {
                            Conn2.Open();
                            String req2 = "SELECT * FROM client";
                            SqlCommand mycommand2 = new SqlCommand(req2, Conn2);
                            SqlDataReader l2 = mycommand2.ExecuteReader();
                            Boolean test9 = false;

                            while (l2.Read() && !test9)
                            {
                                if (l2.GetString(4).Equals(loginclient))
                                {
                                    test9 = true;

                                    nom = l2.GetString(2) + " " + l2.GetString(3);


                                }
                            }
                        }
                        catch (Exception es)
                        { MessageBox.Show(es.Message); }



                        table.Rows.Add(l.GetValue(0).ToString(), nom, l.GetValue(1).ToString(), l.GetValue(5).ToString());

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
            int selectedrowindex = table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = table.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["id_Commande"].Value);
            string cellValue1 = Convert.ToString(selectedRow.Cells["id_client"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["date_Commande"].Value);
            string cellValue3 = Convert.ToString(selectedRow.Cells["Montant"].Value);
            MessageBox.Show("id comm"+ cellValue);
            MessageBox.Show("id client"+ cellValue1);
            MessageBox.Show("date"+ cellValue2);
            MessageBox.Show("Montant"+ cellValue3);
            facture2 a = new facture2(cellValue, Convert.ToDateTime(cellValue2), cellValue3, cellValue1, 1, login,nom1,prenom) ;

            a.Show();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caissierHome a = new caissierHome(login, nom1, prenom);
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
