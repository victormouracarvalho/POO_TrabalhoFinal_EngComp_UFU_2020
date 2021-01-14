using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp6
{
    public partial class Login : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
            "User Id = {2}; Password = {3}; Database = {4};",
            "localhost", 5432, "postgres", "12345", "postgres");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;

        public Login()
        {   
            conn = new NpgsqlConnection(connstring);
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from func_login(:_firstname, :_midname)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_firstname", Login2.Text);
                cmd.Parameters.AddWithValue("_midname", Senha2.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Autenticação realizada com Sucesso!");
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha incorretos.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Delete fail. Error: " + ex.Message);
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void Login2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
