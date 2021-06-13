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
    public partial class listevente : Form
    {
        int k = 0;
        String id1;
        String nom;
        String prenom;
        public listevente(String id, String nom,String prenom)
        {
            InitializeComponent();
            id1 = id;
            d1.Visible = false;
            d2.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            table.Visible = false;
            visualiser.Visible = false;
            this.nom = nom;
            this.prenom = prenom;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imprimer.Visible = true;
            d1.Visible = true;
            d2.Visible = true;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            table.Visible = false;
            visualiser.Visible = true;
            
            k = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imprimer.Visible = true;
            k = 2;
            d1.Visible = false;
            d2.Visible = false;
            p1.Visible = true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;
            p5.Visible = true;
            table.Visible = false;
            visualiser.Visible = true;
        }

        private void visualiser_Click(object sender, EventArgs e)
        {
            imprimer.Visible = true;
            table.Visible = true;
            if(k==1)
            {
                table.Rows.Clear();
                String  d= d2.Value.Date.ToString();

                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                
                    try
                    {
                        Conn.Open();
                        String req = "SELECT * FROM Facture";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader l = mycommand.ExecuteReader();
                   
                    while (l.Read() )
                        {
                        String nom = "";
                       
                            if (d.Equals(l.GetValue(1).ToString()))
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

                                        nom = l2.GetString(2) + " "+l2.GetString(3);


                                    }
                                }
                            }
                            catch (Exception es)
                            { MessageBox.Show(es.Message); }



                            table.Rows.Add(l.GetValue(0).ToString(), nom, l.GetValue(1).ToString(),l.GetValue(5).ToString() );

                            
                        }
                        }

                        l.Close();
                        Conn.Close();
                      
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                  

                
            }
            if(k==2)
            {

                DateTime d1 = p3.Value.Date;
                DateTime d2 = p5.Value.Date;

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

                        // if (d.Equals(l.GetValue(1).ToString()) && l.GetValue(2).Equals(id1))
                        //if (d.Equals(l.GetValue(1).ToString()))
                            if (d1.CompareTo(l.GetValue(1))<0 && d2.CompareTo(l.GetValue(1)) > 0)
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



                            table.Rows.Add(l.GetValue(0).ToString(), nom, l.GetValue(1).ToString(),  l.GetValue(5).ToString());


                        }
                    }

                    l.Close();
                    Conn.Close();

                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }





            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
       
        private void imprimer_Click(object sender, EventArgs e)
        {
          



            int selectedrowindex = table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = table.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["id_Commande"].Value);
            string cellValue1 = Convert.ToString(selectedRow.Cells["id_client"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["date_Commande"].Value);
            string cellValue3 = Convert.ToString(selectedRow.Cells["Montant"].Value);
          
            DateTime d = Convert.ToDateTime(cellValue2);
            //  li a = new ADD_produit(int.Parse(cellValue), id1);
            impr_ecr a = new impr_ecr(cellValue, d, cellValue3, cellValue1);
         //   factureimp a = new factureimp(cellValue, d, cellValue3, cellValue1);
            a.Show();
            a.id1 = id1;
            a.nom = nom;
            a.prenom = prenom;
            this.Hide();

        }

        private void listevente_Load(object sender, EventArgs e)
        {
        //    using(boutiqueEntities db= new boutiqueEntities())
            {
               // ProductBindingSource.DataSource = db.Products.ToList();
                
            }
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            caissierHome a = new caissierHome(id1, nom, prenom);
            a.Show();
            this.Hide();
        }
    }
}
