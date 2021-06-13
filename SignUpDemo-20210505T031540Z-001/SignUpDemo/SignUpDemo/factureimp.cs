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
using System.Drawing.Imaging;

using System.Drawing;

using System;


namespace SignUpDemo
{
    public partial class factureimp : Form
    {
        public factureimp(String id, DateTime d, String somme, String nom)
        {
            InitializeComponent();
            label7.Text = id.ToString();
            label8.Text = d.ToString();

            label19.Text = nom;
            label11.Text = somme.ToString() +"DT";
                label12.Text= somme.ToString() + "DT";
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
                            k=prix1 * (prix);


                        table.Rows.Add(nomjouet, l.GetValue(2).ToString(), prix.ToString(), k.ToString(), l.GetValue(1).ToString());
                    }

                }

                l.Close();
                Conn.Close();

            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }




        }

        private void factureimp_Load(object sender, EventArgs e)
        {

        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //bmp = new Bitmap(800, 800, g);
           // Graphics ng = Graphics.FromImage(bmp);
         //   ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0,this.Size);
         //   printPreviewDialog1.ShowDialog();


              Graphics g = this.CreateGraphics();
             bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(bmp);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
