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
    public partial class chiffre_aff : Form
    {
        int itera1 = 0;
        int itera2 = 0;
        int itera3 = 0;
        Double[] tab1 = new Double[12];
        int i = 0;
        int j = 0;
        int[] tab2 = new int[200];//id jouet par jouet
        String[] tab3 = new String[200];//type de jouet dispo
        String[] tab8 = new String[200];// pour chaque jouet-> type 
        int nbr_type = 0;// nombre de type 
        Double[] tab6 = new Double[200];//prix jouet par jouet
        Double[] tab5 = new Double[200];//tab5 pour le chiffre
        SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

        int gh = 0;//pour connaitre si on va faire la visualisation par date ou par interv
        public chiffre_aff()
        {
            InitializeComponent();
            d1.Visible = false;
            d2.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            visualiser.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            try
            {

                Conn.Open();
                String req = "SELECT * FROM jouet";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {
                    String type = l.GetString(2);
                    Boolean test2 = false;
                    int con = 0;
                    while (!test2 && con < nbr_type)
                    {
                        if (tab3[con].Equals(type))
                            test2 = true;
                        con++;
                    }
                    if (!test2)
                    {
                        tab3[nbr_type] = type;
                        nbr_type++;
                    }
                    tab2[i] = l.GetInt32(0);
                    tab6[i] = l.GetDouble(6);
                    tab8[i] = l.GetString(2);
                    i++;

                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chiffre_aff_Load(object sender, EventArgs e)
        {

        }


        private void fillChart()
        {
            chart1.Visible = true;
            chart2.Visible = false;
            if (itera1 == 1)
            {
                for (int mm = 0; mm < 12; mm++)
                {
                    chart1.Series["chiffre d'affaire"].Points.AddXY(mm, tab1[mm]);

                }
                chart1.Titles.Add("le chiffre d’affaire global");
            }
    }
        private void fillChart2()
        {
            chart2.Visible = true;
            chart1.Visible = false;
            
            if (itera2 == 1)
            {
                for (int mm = 0; mm < nbr_type; mm++)
                {
                    chart2.Series["chiffre d'affaire par type de jouet"].Points.AddXY(tab3[mm], tab5[mm]);

                }
             //   chart2.Titles.Add("chiffre d'affaire par type de jouet");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            itera1 = itera1+1;
            d1.Visible = false;
            d2.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            visualiser.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            double mon = 0.0;
            for (int i = 0; i < 12; i++)
            { tab1[i] = 0; }

            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {

                Conn.Open();
                String req = "SELECT * FROM Facture";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {
                    if (l.GetString(4).Equals("1") && l.GetDateTime(1).Year.ToString().Equals(DateTime.Today.Year.ToString()))
                    {
                       
                        int kk = int.Parse(l.GetDateTime(1).Month.ToString());
                        mon = mon+ l.GetDouble(5);
                        tab1[kk] = tab1[kk] + l.GetDouble(5);
                    }
                   
                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
            fillChart();
            label3.Text = "le chiffre d’affaire global :";
            label4.Text = mon+" Dt";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }









        private void button5_Click(object sender, EventArgs e)
        {
            itera2 = itera2+1;
            d1.Visible = false;
            d2.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            visualiser.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
            chart4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            int[] tab4 = new int[200];
           
           

            for(int k=0;k< nbr_type; k++)
            {
                tab5[k] = 0.0;// tab5 pour chaque type al chiffre d'affaire te3ou
            }




             try
            {

                Conn.Open();
                String req = "SELECT * FROM Facture";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {
                    tab4[j] = l.GetInt32(0);
                    j++;
                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }


            try
            {

                Conn.Open();
                String req = "SELECT * FROM Facture_jouet";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {
                    Boolean test = false;
                   for(int ll=0;ll<j;ll++)
                    {
                        if(tab4[ll].ToString().Equals(l.GetInt32(0).ToString()))
                        {
                            test = true;
                        }
                    }
                   if(test)
                    {
                        for(int ll=0;ll<i;ll++)
                        {
                            if(tab2[ll].ToString().Equals(l.GetInt32(1).ToString()))
                            {
                                double prix_jouet = tab6[ll];
                                String type = tab8[ll];


                                for(int lm=0;lm<nbr_type;lm++)
                                {
                                    if(tab3[lm].Equals(type))
                                    {
                                        tab5[lm] = tab5[lm] +( prix_jouet * l.GetInt32(2));
                                    }
                                }

                              

                            }
                        }
                    }
                    
                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
            fillChart2();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            d1.Visible = false;
            d2.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            visualiser.Visible = false;
            button2.Visible = true;
            button4.Visible = true;
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            visualiser.Visible = false;
          
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            ////////////////////
            d1.Visible = true;
            d2.Visible = true;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            gh = 1;
            visualiser.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            visualiser.Visible = false;
         
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            d1.Visible = false;
            d2.Visible = false;
            p1.Visible =true;
            p2.Visible = true;
            p3.Visible = true;
            p4.Visible = true;
            p5.Visible = true;
            gh = 2;
            visualiser.Visible = true;

        }

        private void visualiser_Click(object sender, EventArgs e)
        {
            foreach (var series in chart3.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart4.Series)
            {
                series.Points.Clear();
            }
            int[] tab10= new int[200];//pour mettre les numeros des factures que on va les traitees
            int i_10 = 0;
            double mon2 = 0;
            if (gh == 1)
            {
                String d = d2.Value.Date.ToString();
                
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

                try
                {
                    Conn.Open();
                    String req = "SELECT * FROM Facture";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read())
                    {


                        if (d.Equals(l.GetValue(1).ToString()))
                        {
                            mon2 = mon2 + l.GetDouble(5);
                            tab10[i_10] = l.GetInt32(0);
                            i_10++;
                        }
                    }
                    Conn.Close();
                }


            catch (Exception es)
            { MessageBox.Show(es.Message); }

               Double[] tab11 = new Double[200];
               for(int kkk=0;kkk<nbr_type;kkk++)
                { tab11[kkk] = 0.0; }
            try
            {

                Conn.Open();
                String req = "SELECT * FROM Facture_jouet";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {
                    Boolean test = false;
                    for (int ll = 0; ll < i_10; ll++)
                    {
                        if (tab10[ll].ToString().Equals(l.GetInt32(0).ToString()))
                        {
                            test = true;
                        }
                    }
                    if (test)
                    {
                        for (int ll = 0; ll < i; ll++)
                        {
                            if (tab2[ll].ToString().Equals(l.GetInt32(1).ToString()))
                            {
                                double prix_jouet = tab6[ll];
                                String type = tab8[ll];


                                for (int lm = 0; lm < nbr_type; lm++)
                                {
                                    if (tab3[lm].Equals(type))
                                    {
                                        tab11[lm] = tab11[lm] + (prix_jouet * l.GetInt32(2));
                                    }
                                }



                            }
                        }
                    }

                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

                chart2.Visible = false;
                chart1.Visible = false;
                chart3.Visible = true;
                for (int mm = 0; mm < nbr_type; mm++)
                {
                    chart3.Series["chiffre d'affaire par type de jouet"].Points.AddXY(tab3[mm], tab11[mm]);

                }
                chart2.Titles.Add("chiffre d'affaire par type de jouet");

                label3.Visible = true;
                label4.Visible = false;
                label3.Text = " le chiffre d’affaire en :" + d+" : "+mon2+" Dt";
                
            }

            if (gh==2)
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
                        if (d1.CompareTo(l.GetValue(1)) < 0 && d2.CompareTo(l.GetValue(1)) > 0)
                        {
                            mon2 = mon2 + l.GetDouble(5);

                            tab10[i_10] = l.GetInt32(0);
                            i_10++;

                        }
                    }
                        l.Close();
                        Conn.Close();

                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }



                Double[] tab11 = new Double[200];
                for (int kkk = 0; kkk < nbr_type; kkk++)
                { tab11[kkk] = 0.0; }
                try
                {

                    Conn.Open();
                    String req = "SELECT * FROM Facture_jouet";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();


                    while (l.Read())
                    {
                        Boolean test = false;
                        for (int ll = 0; ll < i_10; ll++)
                        {
                            if (tab10[ll].ToString().Equals(l.GetInt32(0).ToString()))
                            {
                                test = true;
                            }
                        }
                        if (test)
                        {
                            for (int ll = 0; ll < i; ll++)
                            {
                                if (tab2[ll].ToString().Equals(l.GetInt32(1).ToString()))
                                {
                                    double prix_jouet = tab6[ll];
                                    String type = tab8[ll];


                                    for (int lm = 0; lm < nbr_type; lm++)
                                    {
                                        if (tab3[lm].Equals(type))
                                        {
                                            tab11[lm] = tab11[lm] + (prix_jouet * l.GetInt32(2));
                                        }
                                    }



                                }
                            }
                        }

                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }

                chart2.Visible = false;
                chart1.Visible = false;
                chart3.Visible = false;
                chart4.Visible = true;
                for (int mm = 0; mm < nbr_type; mm++)
                {
                    chart4.Series["chiffre d'affaire par type de jouet"].Points.AddXY(tab3[mm], tab11[mm]);

                }
                chart2.Titles.Add("chiffre d'affaire par type de jouet");

                label3.Visible = true;
                label4.Visible = false;
                label3.Text = " le chiffre d’affaire entre les deux dates " + mon2 + " Dt";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }
    }
}
