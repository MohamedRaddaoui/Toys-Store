using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class gestion_jouets : Form
    {
        public String imgLoc;
        int num = 1;
        Boolean test = false;
        public gestion_jouets()
        {
            InitializeComponent();
            name2.Visible = false;
            name2.Text = "";//name2 c'est un comboboxe de recherche selon le type saisir
            name2.Items.Clear();
            name2.Text = "choisir un type";
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {

                Conn.Open();
                String req = "SELECT * FROM type_jouet";
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

        private void pho_Click(object sender, EventArgs e)
        {
            
                OpenFileDialog open = new OpenFileDialog();
                   // open.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All files (*.*)|*.*";

                     open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (open.ShowDialog() == DialogResult.OK)
            {
              //   display image in picture box  
                photo.Image = new Bitmap(open.FileName);
              //  imgLoc = open.FileName.ToString();
                // image file path  


               // photo.ImageLocation = imgLoc;
               image.Text = open.FileName;
                test = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void type_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String nom1 = nom.Text;
            String type1="";
                //= type.Text;
            int agemax1=0;
            int agemin1=0;
            float prix1=0;
            int idfour1=0;
            int stock1=0;
            Boolean test9 = false;// test9 pour le format des entiers
            try
            {


                try
                {  agemax1 = int.Parse(agemax.Text);
                } catch
                {  test9 = true;
                MessageBox.Show("le age max c'est un entier il faut saisir un entier");
                }
                try
                {
                     agemin1 = int.Parse(agemin.Text);
                }
                catch
                {
                    test9 = true;
                    MessageBox.Show("le age min c'est un entier il faut saisir un entier");
                }
                try
                {
                    prix1 = float.Parse(prix.Text);
                }
                catch
                {
                    test9 = true;
                    MessageBox.Show("le prix est un reel il faut saisir un reel");
                }
                try
                {
                    idfour1 = int.Parse(idfour.Text);
                }
                catch
                {
                    test9 = true;
                    MessageBox.Show("le id de la fournisseur est un entier il faut saisir un entier");
                }
                try
                {
                     stock1 = int.Parse(stock.Text);
                }
                catch
                {
                    test9 = true;
                    MessageBox.Show("le stock est un entier il faut saisir un entier");
                }
                if (test9 == false)
                {
                   
                    Boolean test12 = false;//test11pour tester si l'id de la fournisseur est existe ou non
                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                    try
                    {

                        Conn.Open();
                        String req = "SELECT * FROM fournisseur";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader l = mycommand.ExecuteReader();


                        while (l.Read())
                        {
                            if (l.GetInt32(0).ToString().Equals(idfour1.ToString()))
                                test12 = true;
                        }
                        l.Close();
                        Conn.Close();
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }



                    type1 = (String)name2.SelectedItem;
                    if (name2.SelectedIndex == -1)
                    { MessageBox.Show("choisir un type de jouet");
                        
                    }
                    else if(!(agemax1>agemin1))
                    { MessageBox.Show("l'age max doit etre superieure a l'age min"); }
                   else if (!test12)

                    { MessageBox.Show("id de fournisseur est invalide"); }

                   else if (test == false)
                    { MessageBox.Show("choisir une photo"); }
                    //
                    else if (nom1.Equals("") || type1.Equals("") || agemax.Text == "" || agemin.Text == "" || prix.Text == "" || idfour.Text == "" || stock.Text == "")
                    { MessageBox.Show("saisir les donnees"); }


                    else if (agemax1 < 1 || agemax1 > 100 || agemin1 < 1 || agemin1 > 100)
                    { MessageBox.Show("[] invalide"); }
                    else if (prix1 < 0)
                    { MessageBox.Show("prix invalide"); }
                    else if (stock1 < 0)
                    { MessageBox.Show("stock invalide"); }
                    else
                    {
                        String k = image.Text;
                      
                        SqlConnection Conn2 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

                        try
                        {
                            Conn.Open();
                            String req = "insert into jouet(nom,type,agemin,agemax,photo,prix,id_fournisseur,stock) values( '" + nom1 + "','" + type1 + "','" + agemin1 + "','" + agemax1 + "','" + k + "','" + prix1 + "','" + idfour1 + "','" + stock1 + "')";
                            SqlCommand mycommand = new SqlCommand(req, Conn);
                            mycommand.ExecuteNonQuery();
                            MessageBox.Show("Jouet ajoute avec succes");
                        }
                        catch (Exception es)
                        { MessageBox.Show(es.Message); }


                        try
                        {
                            Conn2.Open();
                            String req2 = "insert into nouveauxjouets(nom,type,agemin,agemax,photo,prix,id_fournisseur,stock) values( '" + nom1 + "','" + type1 + "','" + agemin1 + "','" + agemax1 + "','" + k + "','" + prix1 + "','" + idfour1 + "','" + stock1 + "')";
                            SqlCommand mycommand2 = new SqlCommand(req2, Conn2);
                            mycommand2.ExecuteNonQuery();

                        }
                        catch (Exception es)
                        { MessageBox.Show(es.Message); }

                    }
                }
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {
               
                Conn.Open();
                String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM jouet";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();

                
                while (l.Read())
                {
                    data.Rows.Add(l.GetValue(0).ToString(), l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString(), l.GetValue(7).ToString(), l.GetValue(8).ToString(), l.GetValue(2).ToString() );
                    
                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          String id=  id1.Text;
            String nom1 = nom.Text;
            String type1 = "";
                type1=(String)name2.SelectedItem;
           
            try
            {
                int agemax1 = int.Parse(agemax.Text);
                int agemin1 = int.Parse(agemin.Text);
                float prix1 = float.Parse(prix.Text);
                int idfour1 = int.Parse(idfour.Text);
                int stock1 = int.Parse(stock.Text);
                Boolean test12 = false;//test11pour tester si l'id de la fournisseur est existe ou non
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {

                    Conn.Open();
                    String req = "SELECT * FROM fournisseur";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();


                    while (l.Read())
                    {
                        if (l.GetInt32(0).ToString().Equals(idfour1.ToString()))
                            test12 = true;
                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }

                if (type1.Equals(""))
                { MessageBox.Show("il faut choisir un type"); }
                 if (nom1.Equals("") || type1.Equals("") || agemax.Text == "" || agemin.Text == "" || prix.Text == "" || idfour.Text == "" || stock.Text == "")
                { MessageBox.Show("saisir les donnees"); }
                 if(!(agemax1>agemin1))
                { MessageBox.Show("l'age max doit etre superieure a l'age min"); }
                 else if(!test12)
                { MessageBox.Show("l'id de fournisseur n'est pas valide"); }
                else if (agemax1 < 1 || agemax1 > 100 || agemin1 < 1 || agemin1 > 100)
                { MessageBox.Show("[] invalide"); }
                else if (prix1 < 0)
                { MessageBox.Show("prix invalide"); }
                else if (stock1 < 0)
                { MessageBox.Show("stock invalide"); }
                else
                {
                    String k = image.Text;
                    try
                    {
                        Conn.Open();
                        String req = "update  jouet set nom='" + nom1 + "',type='" + type1 + "',agemin='" + agemin1 + "',agemax='" + agemax1 + "',photo='" + k + "',prix='" + prix1 + "',id_fournisseur='" + idfour1 + "',stock='" + stock1 + "' where id ='" + id + "'";
                          SqlCommand mycommand = new SqlCommand(req, Conn);
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("jouet modifie avec succes");
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                }
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = id1.Text;
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            if (id.Equals(""))
            {
                MessageBox.Show("saisir le id");
            }
            else
            {
                Boolean test7 = false;
                try
                {
                   
                    Conn.Open();
                    String req = "SELECT  id FROM jouet";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read() && !test7)
                    {
                        if (id.Equals(l.GetValue(0).ToString()))
                            test7 = true;
                    }

                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }
                if (test7 == false)
                { MessageBox.Show("ID invalide"); }
                else
                {

                  
                    try
                    {
                        Conn.Open();
                        String req = "delete from jouet where id='"+id+"'";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        mycommand.ExecuteNonQuery();
                        MessageBox.Show("jouet supprime avec succes");
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }




                }
            }
        }

     

        private void button6_Click(object sender, EventArgs e)
        {
            name2.Visible = true;
            image.Text = "";
            nom.Text = "";
            type.Text = "";
            agemin.Text = "";
            agemax.Text = "";
            idfour.Text = "";
            prix.Text = "";
            stock.Text = "";
            photo.Image = null;

            id1.Visible = false;
            label1.Visible = false;
            recherche.Visible = false;
            button6.BackColor = Color.Salmon;
            button5.BackColor = Color.Crimson;
            button7.BackColor = Color.Crimson;
            photo.Visible = true;
            pho.Visible = true;
            label16.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label15.Visible = true;
            label14.Visible = true;
            label17.Visible = true;
            nom.Visible = true;
            type.Visible = true;
            agemin.Visible = true;
            agemax.Visible = true;
            idfour.Visible = true;
            prix.Visible = true;
            stock.Visible = true;
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;


          








        }

        private void button5_Click(object sender, EventArgs e)
        {
            name2.Visible = false;
            id1.Text = "";
            button5.BackColor = Color.Salmon;
            button6.BackColor = Color.Crimson;
            button7.BackColor = Color.Crimson;
           
            photo.Visible = false;
            pho.Visible = false;
            label16.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            label17.Visible = false;
            nom.Visible = false;
            type.Visible = false;
            agemin.Visible = false;
            agemax.Visible = false;
            idfour.Visible = false;
            prix.Visible = false;
            stock.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            num = 1;
            id1.Visible = true;
            label1.Visible = true;
            recherche.Visible = true;
        }

        private void recherche_Click(object sender, EventArgs e)
        {
            name2.Visible = true;
            photo.Visible = true;
            pho.Visible = true;
            label16.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label15.Visible = true;
            label14.Visible = true;
            label17.Visible = true;
            nom.Visible = true;
          //  type.Visible = true;
            agemin.Visible = true;
            agemax.Visible = true;
            idfour.Visible = true;
            prix.Visible = true;
            stock.Visible = true;
            button1.Visible = false;

            String id = id1.Text;
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            if (id.Equals(""))
            {
                MessageBox.Show("saisir le id");
            }
            else
            {
                Boolean test9 = false;

                try
                {
                     Conn.Open();
                    String req = "SELECT * FROM jouet";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read() && !test9)
                    {
                        if (id.Equals(l.GetValue(0).ToString()))
                        {
                            test9 = true;

                            nom.Text = l.GetValue(1).ToString();
                            type.Text = l.GetValue(1).ToString();
                            agemax.Text = l.GetValue(3).ToString();
                            agemin.Text = l.GetValue(4).ToString();
                          name2.SelectedItem = l.GetValue(2).ToString();
                            idfour.Text = l.GetValue(7).ToString();
                            stock.Text = l.GetValue(8).ToString();
                            photo.Image = new Bitmap(l.GetValue(5).ToString());
                            image.Text = l.GetValue(5).ToString();
                        }
                    }

                    l.Close();
                    Conn.Close();
                    if(num==1)
                    { button3.Visible = true; }
                    if(num==2)
                    { button4.Visible = true; }
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }
                if (test9 == false)
                { MessageBox.Show("ID invalide"); }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            name2.Visible = false;
            id1.Text = "";
            button7.BackColor = Color.Salmon;
            button5.BackColor = Color.Crimson;
            button6.BackColor = Color.Crimson;
           
            photo.Visible = false;
            pho.Visible = false;
            label16.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            label17.Visible = false;
            nom.Visible = false;
            type.Visible = false;
            agemin.Visible = false;
            agemax.Visible = false;
            idfour.Visible = false;
            prix.Visible = false;
            stock.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            num = 2;
            id1.Visible = true;
            label1.Visible = true;
            recherche.Visible = true;
        }

        private void photo_Click(object sender, EventArgs e)
        {

        }

        private void gestion_jouets_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            admin z = new admin();
            z.Show();
            this.Hide();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
