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
    public partial class impr_ecr : Form
    {
       public String nom;
       public String prenom;
       public String id1;
        public impr_ecr(String id, DateTime d, String somme, String nom)
        {
            InitializeComponent();

            d.AddDays(3).ToString();
           
            richTextBox1.Text="Facture Numero :"+id+"    date :"+d.ToString()+"     date d'echeance :" + d.AddDays(3).ToString()+"\n"; 
            richTextBox1.Text = richTextBox1.Text + "Nom de client : " + nom + "\n";
            richTextBox1.Text = richTextBox1.Text + "\n \n \n Montant Total" + somme + " Dt \n";



            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

            try
            {

                Conn.Open();
                String req = "SELECT * FROM facture_jouet ";

                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();
                richTextBox1.Text = richTextBox1.Text + "\n \n Liste de commande \n";

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
                        k = prix1 * (prix);

                        richTextBox1.Text = richTextBox1.Text +"Nom:"+nomjouet+"     Quantite :"+ l.GetValue(2).ToString()+"    Prix:"+ prix.ToString()+ "Dt      Montant :" +l.GetValue(1).ToString()+"Dt \n";
                        }
                     }

                l.Close();
                Conn.Close();

            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

            richTextBox1.Text = richTextBox1.Text + "\n \n \n \n \n \n \n \n \n \n TVA non applicable, art,293B du CGI \n";
            richTextBox1.Text = richTextBox1.Text + "Bon pour accord :";
            richTextBox1.Text = richTextBox1.Text + "\n \n                                                                                             Date et signature :";



        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
             }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Sicrosoft Sans Serif "
                , 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void impr_ecr_Load(object sender, EventArgs e)
        {

        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caissierHome a = new caissierHome(nom, prenom,id1) ;
            a.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
