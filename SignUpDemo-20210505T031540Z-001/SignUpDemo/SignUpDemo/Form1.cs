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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(name.Text=="" || pass.Text=="")
            { MessageBox.Show("remplir les cases"); }
            else if(comboBox1.SelectedIndex == -1)
            { MessageBox.Show("choisir un role"); }
            else
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

                    try
                    {
                        Boolean test1 = false;
                        Conn.Open();
                        String req = "select * from administrateur ";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader myreader= mycommand.ExecuteReader();
                   while(myreader.Read() && test1==false)
                        {
                            if (myreader.GetString(0) == name.Text && myreader.GetString(1) == pass.Text)
                                test1 = true;
                                   }
                        if(test1==true)
                        { admin a = new admin();
                            a.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("compte inexistant"); }
                    
                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }


                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    
                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");

                    try
                    {
                        Boolean test1 = false;
                        Conn.Open();
                        String req = "select * from client ";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader myreader = mycommand.ExecuteReader();
                        while (myreader.Read() && test1 == false)
                        {
                            if (myreader.GetString(4) == name.Text && myreader.GetString(5) == pass.Text)
                            { test1 = true;
                              
                            }
                        }
                        if (test1 == true)
                        {
                            shop a = new shop();
                            a.id1 = name.Text.ToString();
                            a.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("compte inexistant"); }

                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }
                }
                else if(comboBox1.SelectedIndex == 2)
                {

                    SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                    String nom1="";
                    String prenom1="";
                    String photo1="";
                  
                    try
                    {
                       
                        Boolean test1 = false;
                        Conn.Open();
                        String req = "select * from caissier ";
                        SqlCommand mycommand = new SqlCommand(req, Conn);
                        SqlDataReader myreader = mycommand.ExecuteReader();
                        while (myreader.Read() && test1 == false)
                        {
                            if (myreader.GetString(0) == name.Text && myreader.GetString(1) == pass.Text)
                            {
                                test1 = true;
                                nom1 = myreader.GetString(3);
                                prenom1 = myreader.GetString(4);
                               

                            }
                        }
                        if (test1 == true)
                        {

                            caissierHome a = new caissierHome(nom1, prenom1,name.Text);
                            
                            
                            a.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("compte inexistant"); }

                    }
                    catch (Exception es)
                    { MessageBox.Show(es.Message); }













                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            inscription1 a = new inscription1();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shop a = new shop();
            a.Show();
            this.Hide();

        }
    }
}
