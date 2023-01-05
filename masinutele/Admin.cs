using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masinutele
{
    public partial class Admin : Form
    {

        private void reset()
        {
            MarcaBox.Text = "";
            AnBox.Text = "";
            KmBox.Text = "";
            PretBox.Text = "";
            CaroserieBox.Text = "";
            CombustibilBox.Text = "";
            MotorBox.Text = "";
        }
        public Admin()
        {
            InitializeComponent();
            afisamMasini();
        }

        SqlConnection conexDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gogus\Desktop\masinutele\masinutele\MasiniDB.mdf;Integrated Security=True");


        private void afisamMasini()
        {
            conexDB.Open();

            string Query = "select * from TabelMasini";
            SqlDataAdapter sda = new SqlDataAdapter(Query,conexDB);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);   
            dataMasini1.DataSource = ds.Tables[0];  


            conexDB.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (MarcaBox.Text == "" || AnBox.Text == "" || MotorBox.Text == "" || CaroserieBox.Text == "" || KmBox.Text == "" || PretBox.Text == "" || CombustibilBox.Text == "") 
            {
                MessageBox.Show("Introdu date pentru a adauga masina!");
            }
            else
            {
                try
                {
                    conexDB.Open();
                    SqlCommand cmd = new SqlCommand("insert into TabelMasini(Marca,An,Motor,Caroserie,KM,Pret,Combustibil) values(@M,@A,@MO,@C,@K,@P,@CC)", conexDB);
                    cmd.Parameters.AddWithValue("@M", MarcaBox.Text);
                    cmd.Parameters.AddWithValue("@A", AnBox.Text);
                    cmd.Parameters.AddWithValue("@MO", MotorBox.Text);
                    cmd.Parameters.AddWithValue("@C", CaroserieBox.Text);
                    cmd.Parameters.AddWithValue("@K", KmBox.Text);
                    cmd.Parameters.AddWithValue("@P", PretBox.Text);
                    cmd.Parameters.AddWithValue("@CC", CombustibilBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ai introdus masina cu succes! Bravo Gogule");

                    conexDB.Close();
                    afisamMasini();
                    reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            
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

        int key = 0;
        private void dataMasini1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MarcaBox.Text = dataMasini1.SelectedRows[0].Cells[1].Value.ToString();
            AnBox.Text = dataMasini1.SelectedRows[0].Cells[2].Value.ToString();
            MotorBox.Text = dataMasini1.SelectedRows[0].Cells[3].Value.ToString();
            CaroserieBox.Text = dataMasini1.SelectedRows[0].Cells[4].Value.ToString();
            KmBox.Text = dataMasini1.SelectedRows[0].Cells[5].Value.ToString();
            PretBox.Text = dataMasini1.SelectedRows[0].Cells[6].Value.ToString();
            CombustibilBox.Text = dataMasini1.SelectedRows[0].Cells[7].Value.ToString();
            
            
            if(MarcaBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataMasini1.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Alege o masina care sa o stergi");
            }
            else
            {
                conexDB.Open();
                SqlCommand cmd = new SqlCommand("delete from TabelMasini where Id=@Id", conexDB);
                cmd.Parameters.AddWithValue("@Id",key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Masina a fost stearsa Gogule");

                conexDB.Close();
                afisamMasini();
                reset();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (MarcaBox.Text == "" || AnBox.Text == "" || MotorBox.Text == "" || CaroserieBox.Text == "" || KmBox.Text == "" || PretBox.Text == "" || CombustibilBox.Text == "")
            {
                MessageBox.Show("Introdu date pentru a edita masinutza!");
            }
            else
            {
                conexDB.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TabelMasini set Marca=@M,An=@A,Motor=@MO,Caroserie=@C,KM=@K,Pret=@P,Combustibil=@CC where Id=@Id", conexDB);
                cmd.Parameters.AddWithValue("@M", MarcaBox.Text);
                cmd.Parameters.AddWithValue("@A", AnBox.Text);
                cmd.Parameters.AddWithValue("@MO", MotorBox.Text);
                cmd.Parameters.AddWithValue("@C", CaroserieBox.Text);
                cmd.Parameters.AddWithValue("@K", KmBox.Text);
                cmd.Parameters.AddWithValue("@P", PretBox.Text);
                cmd.Parameters.AddWithValue("@CC", CombustibilBox.Text);
                cmd.Parameters.AddWithValue("@Id", key);

                try 
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Masina editata! Bravo Gogule");

                conexDB.Close();
                afisamMasini();
                reset();


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
