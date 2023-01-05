using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace masinutele
{
    public partial class Login : Form
    {
        public static string bani = "";
        private void reset()
        {
            UserBox.Text = "";
            PassBox.Text = "";

        }
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conexDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gogus\Desktop\masinutele\masinutele\MasiniDB.mdf;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void INREGISTRARE_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
            r.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "" || PassBox.Text == "")
            {
                MessageBox.Show("Rogu-te introdu niste date");
            }
            else if (UserBox.Text == "admin" || PassBox.Text == "admin")
            {
                Admin adm = new Admin();
                this.Hide();
                adm.Show();
            }
            else
            {
                try
                {
                    conexDB.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From TabelLOGIN where username='" + UserBox.Text + "'and password='" + PassBox.Text + "'", conexDB);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Aplicatie app = new Aplicatie(UserBox.Text);
                        this.Hide();
                        app.Show();


                    }
                    else
                    {
                        MessageBox.Show("Ai gresit ori username, ori parola. Rogu-te introdu alte date.");
                        reset();
                    }
                    conexDB.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}