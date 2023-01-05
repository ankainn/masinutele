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
    public partial class Aplicatie : Form
    {

        public static string stat = "";
        public Aplicatie(string strTextBox1)
        {
            InitializeComponent();
            username.Text = strTextBox1;
            balance.Text = baniCont();
            afisamMasini();
        }

        

        SqlConnection conexDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gogus\Desktop\masinutele\masinutele\MasiniDB.mdf;Integrated Security=True");

        private string baniCont()
        {
            string valoareBani = "";
            conexDB.Open();
            SqlCommand cmd = new SqlCommand("select * from TabelLOGIN where username='" + username.Text + "'", conexDB);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if(dr.Read())
                {
                     valoareBani = dr["balance"].ToString();
                }
            }
                conexDB.Close();
            return valoareBani;
        }

        private void afisamMasini()
        {
            conexDB.Open();

            string Query = "select * from TabelMasini";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conexDB);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            dataMasini2.DataSource = ds.Tables[0];


            conexDB.Close();

        }
        private void Aplicatie_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int key;

        string statusC = "";
        //int pret;
        private void button2_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Alege o masina pe care sa o cumperi.");
            }
            else if(statusC == "Cumparata")
            {
                MessageBox.Show("Masina e deja cumparata.");
            }
            else
            {
                conexDB.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TabelMasini set Status='Cumparata' where Id=@Id", conexDB);
                cmd.Parameters.AddWithValue("@Id", key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ai cumparat masina.");
                conexDB.Close();
                afisamMasini();
            }
            
        }

         
        private void dataMasini2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dataMasini2.SelectedRows[0].Cells[0].Value.ToString());
            statusC = dataMasini2.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void verifStatus_Click(object sender, EventArgs e)
        {
            
        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
