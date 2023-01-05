using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masinutele
{
    public partial class Register : Form
    {
        private void reset()
        {
            UserReg.Text = "";
            PassReg.Text = "";

        }
        public Register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection conexDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gogus\Desktop\masinutele\masinutele\MasiniDB.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)// BUTONU DE INREGISTRARE
        {
            if (UserReg.Text == "" || PassReg.Text == "")
            {
                MessageBox.Show("Rogu-te introdu niste date.");
            }
            else
            {
                try
                {
                    conexDB.Open();
                    SqlCommand cmd = new SqlCommand("insert into TabelLOGIN(username,password) values(@U,@P)", conexDB);
                    cmd.Parameters.AddWithValue("@U", UserReg.Text);
                    cmd.Parameters.AddWithValue("@P", PassReg.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Te-ai inregistrat cu succes!");

                    conexDB.Close();
                    reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // NUME DE UTILIZATOR
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // PAROLA
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();

        }
    }
}
