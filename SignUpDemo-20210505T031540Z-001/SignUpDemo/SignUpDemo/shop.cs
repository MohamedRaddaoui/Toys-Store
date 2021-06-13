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
    public partial class shop : Form
    {
        int i = 0;
       public String id1 ; // id1 c'est l'id de  client
       
        
        public shop()
        {
            InitializeComponent();
            name1.Visible = false;
            name2.Visible = false;
            View.Visible = false;
            table.Rows.Clear();
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {

                Conn.Open();
                String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM jouet";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                while (l.Read())
                {
                    table.Rows.Add(  l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString()+" Dt","["+ l.GetValue(3).ToString()+" ans :"+ l.GetValue(4).ToString()+" ans ]", l.GetValue(2).ToString(), l.GetValue(0).ToString());

                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_Click(object sender, EventArgs e)
        {
            if(i==1)
            {
                table.Rows.Clear();
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {
                    String selected = (String)name2.SelectedItem;
                    Conn.Open();
                    String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM jouet where type='"+selected + "'";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read())
                    {
                        table.Rows.Add(l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString() + " Dt", "[" + l.GetValue(3).ToString() + " ans :" + l.GetValue(4).ToString() + " ans ]", l.GetValue(2).ToString(), l.GetValue(0).ToString());

                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }

            }
            if(i==2)
            {

                int min = 0;
                int max = 0;

                String selected = (String)name2.SelectedItem;
                if (selected == "<10DT")
                {
                    min = 0;
                    max = 10;
                }
                if (selected == "[10DT:50DT]")
                {
                    min = 10;
                    max = 50;
                }
                if (selected == "[50DT:100DT]")
                {
                    min = 50;
                    max = 100;
                }
                if (selected == "[100DT:200DT]")
                {
                    min = 100;
                    max = 200;
                }
                if (selected == "[200DT:300DT]")
                {
                    min = 200;
                    max = 300;
                }
                if (selected == "300DT<")
                {
                    min = 300;
                    max = 100000;
                }


                table.Rows.Clear();
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {
                    Conn.Open();
                    String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM jouet where prix  BETWEEN '"+min+"'and '"+max+"'";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read())
                    {
                        table.Rows.Add(l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString() + " Dt", "[" + l.GetValue(3).ToString() + " ans :" + l.GetValue(4).ToString() + " ans ]", l.GetValue(2).ToString(), l.GetValue(0).ToString());

                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }





            }
            if (i==3)
            {
                int min = 0;
                int max = 0;
                
                String selected = (String)name2.SelectedItem;
               if(selected== "<1an")
                { min = 0;
                    max = 1;
                }
                    if (selected == "[1an:2ans]")
                {
                    min = 1;
                    max = 2;
                }
                        if (selected == "[1an:10ans]")
                {
                    min = 1;
                    max = 10;
                }
                            if (selected == "[10an:20ans]")
                {
                    min = 10;
                    max = 20;
                }
                if (selected == "[20an:30ans]")
                {
                    min = 20;
                    max = 30;
                }

                if (selected == "30ans<")
                {
                    min = 30;
                    max = 100;
                }

             


                table.Rows.Clear();
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {
                    Conn.Open();
                    String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM jouet where ( agemin>'" + min + "'AND agemin<'"+max+"') OR( agemax<'"+max+"' AND agemax>'"+min+"')";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read())
                    {
                        table.Rows.Add(l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString() + " Dt", "[" + l.GetValue(3).ToString() + " ans :" + l.GetValue(4).ToString() + " ans ]", l.GetValue(2).ToString(), l.GetValue(0).ToString());

                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }



            }
            if(i==4)
            {
                table.Rows.Clear();
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {
                    String selectedCar = (String)name2.SelectedItem;
                    Conn.Open();
                    String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM jouet where nom='" + selectedCar + "'";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read())
                    {
                        table.Rows.Add(l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString() + " Dt", "[" + l.GetValue(3).ToString() + " ans :" + l.GetValue(4).ToString() + " ans ]", l.GetValue(2).ToString(), l.GetValue(0).ToString());

                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }
            }
        }

        private void shop_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox_recherche.SelectedIndex == -1)
            { MessageBox.Show("choisir un type de recherche"); }
            else
            {
                name1.Visible = true;
                name2.Visible = true;
                View.Visible = true;

                if (comboBox_recherche.SelectedIndex == 1)
                {
                    i = 1;
                    name2.Text = "";//name2 c'est un comboboxe de recherche selon le type saisir
                    name2.Items.Clear(); 
                    name1.Text = "Select Category:";
                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                    try
                    {

                        Conn.Open();
                        String req = "SELECT  Distinct type FROM jouet";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader l = mycommand.ExecuteReader();
                      
                        while (l.Read())
                        {
                            name2.Items.Add(l.GetValue(0).ToString());
                        }
                        l.Close();
                        Conn.Close();
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                }
                if (comboBox_recherche.SelectedIndex == 0)
                {
                    i = 2;
                    name2.Text = "";
                    name2.Items.Clear();
                    name1.Text = "Select price:";

                    name2.Items.Add("<10DT");
                    name2.Items.Add("[10DT:50DT]");
                    name2.Items.Add("[50DT:100DT]");
                    name2.Items.Add("[100DT:200DT]");
                    name2.Items.Add("[200DT:300DT]");
                    name2.Items.Add("300DT<");
                }
                if (comboBox_recherche.SelectedIndex == 2)
                {
                    i = 3;
                    name2.Text = "";
                    name2.Items.Clear();
                    name1.Text = "Select Age:";
                    //    name2.Items.Add("[1an:2ans]");
                    // name2.Items.Add("[2ans:5ans]");
                    // name2.Items.Add("[5ans:8ans]");
                    //  name2.Items.Add("[8ans:15ans]");
                    // name2.Items.Add("[15:19ans]");
                    //name2.Items.Add("[19ans:23ans]");
                    //name2.Items.Add("23ans<");
                    name2.Items.Add("<1an");
                     name2.Items.Add("[1an:10ans]");
                    name2.Items.Add("[10an:20ans]");
                    name2.Items.Add("[20an:30ans]");
                    name2.Items.Add("30ans<");

                }

                if (comboBox_recherche.SelectedIndex == 3)
                {
                    i = 4;
                    name2.Text = "";
                    name2.Items.Clear();
                    name1.Text = "Select Name:";
                  
                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                    try
                    {

                        Conn.Open();
                        String req = "SELECT  Distinct nom FROM jouet";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader l = mycommand.ExecuteReader();

                        while (l.Read())
                        {
                            name2.Items.Add(l.GetValue(0).ToString());
                        }
                        l.Close();
                        Conn.Close();
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (id1==null)
            { MessageBox.Show("faut connecter pour ajouter des jouets au panier"); }
            else
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["id"].Value);
                ADD_produit a = new ADD_produit(int.Parse(cellValue),id1);
                a.Show();
            }
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id1==null)
            { MessageBox.Show("faut connecter pour ajouter des jouets au panier"); }
            else
            {
                panier a = new panier( id1);
                a.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abonnement a = new abonnement(id1);
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            quisommenous a = new quisommenous();
            a.id1 = id1;
            a.Show();
            this.Hide();
        }
    }
}
