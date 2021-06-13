using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class envoyeremails : Form
    {
        public envoyeremails()
        {
            InitializeComponent();

            table.Rows.Clear();
            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {

                Conn.Open();
                String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM nouveauxjouets";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {
                    table.Rows.Add(l.GetValue(0).ToString(), l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString(), l.GetValue(7).ToString(), l.GetValue(8).ToString(), l.GetValue(2).ToString());

                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        private void envoyeremails_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin z = new admin();
            z.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
          
            int selectedrowindex = table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = table.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["id"].Value);
            try
            {
                Conn.Open();
                String req = "delete from nouveauxjouets where id ='" + cellValue + "'";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                mycommand.ExecuteNonQuery();
                MessageBox.Show("jouet supprimé avec succes ");
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

            table.Rows.Clear();
             try
            {

                Conn.Open();
                String req = "SELECT  id,nom,type,agemin,agemax,photo,prix,id_fournisseur,stock FROM nouveauxjouets";
                SqlCommand mycommand = new SqlCommand(req, Conn);
                SqlDataReader l = mycommand.ExecuteReader();


                while (l.Read())
                {
                    table.Rows.Add(l.GetValue(0).ToString(), l.GetValue(1).ToString(), new Bitmap(l.GetValue(5).ToString()), l.GetValue(6).ToString(), l.GetValue(7).ToString(), l.GetValue(8).ToString(), l.GetValue(2).ToString());

                }
                l.Close();
                Conn.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            String msg = "";
            SqlConnection Conn1 = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
            try
            {

                Conn1.Open();
                String req1 = "SELECT  * FROM nouveauxjouets";
                SqlCommand mycommand1 = new SqlCommand(req1, Conn1);
                SqlDataReader l1 = mycommand1.ExecuteReader();
               
                while (l1.Read())
                {
                    msg = msg + "jouet numero " + i + l1.GetString(1) + " type: " + l1.GetString(2) + " age:[" + l1.GetInt32(3) + "ans :" + l1.GetInt32(4) + " ans] Prix: " + l1.GetDouble(6) + " Dt <br>";
                    i++;

                }
                l1.Close();
                Conn1.Close();
            }
            catch (Exception es)
            { MessageBox.Show(es.Message); }

            if (i > 2)
            {
                String email2 = "";
                SqlConnection Conn = new SqlConnection(@"Data Source=desktop-00nlft6\sqlexpress;Initial Catalog=boutique;Integrated Security=True;Pooling=False");
                try
                {

                    Conn.Open();
                    String req = "SELECT * FROM liste_email";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    SqlDataReader l = mycommand.ExecuteReader();

                    while (l.Read())
                    {
                        email2 = l.GetString(1);


                        var smtpClient = new SmtpClient("smtp.gmail.com")
                        {
                            Port = 587,
                            Credentials = new NetworkCredential("monfichier3@gmail.com", "infodegestion"),
                            EnableSsl = true,
                        };

                        smtpClient.Send("monfichier3@gmail.com", email2, "Liste de noveaux jouets", "");
                        var mailMessage = new MailMessage
                        {
                            From = new MailAddress(email2),
                            Subject = "Liste de noveaux jouets",
                            Body = "Liste de noveaux jouets :<br>" + msg,
                            IsBodyHtml = true,
                        };
                        mailMessage.To.Add(email2);

                        smtpClient.Send(mailMessage);

                    }
                    l.Close();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }



                MessageBox.Show("mails envoyes");


                try
                {
                    Conn.Open();
                    String req = "delete from nouveauxjouets";
                    SqlCommand mycommand = new SqlCommand(req, Conn);
                    mycommand.ExecuteNonQuery();
                    Conn.Close();
                }
                catch (Exception es)
                { MessageBox.Show(es.Message); }

                table.DataSource = null;

            }
            else
            { MessageBox.Show("y a pas de nouveaux jouets"); }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
