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
    public partial class Form1 : Form
    {
        private string connstring = String.Format("Server = {0}; Port = {1};" +
            "User Id = {2}; Password = {3}; Database = {4};",
            "localhost", 5432, "postgres", "12345", "postgres");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;
        private int rowIndexEstoque = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            textBox2.Enabled = textBox3.Enabled = textBox1.Enabled = txbcnpj.Enabled = txbtelefone.Enabled = txbcep.Enabled = false;
            btprecocompra.Enabled = btdescricao.Enabled = btquantidade.Enabled = btprecovenda.Enabled = btcodigo.Enabled = false;
            btquantidadevenda.Enabled = txbprecovenda.Enabled = txbvalortotal.Enabled = txbcodigo.Enabled = txbnomeloja.Enabled = horario.Enabled = false;
            select();
            select_estoque();
            select_venda();
        }


  /// <summary>
  /// /////////////////////////        PARTE 1 DA APLICAÇÃO      //////////////////////////////////////////////////
  /// </summary>
        private void select()
        {
            try
            {
                conn.Open();
                sql = @"select * from cliente_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show("Erro:" + ex.Message);
            }
        }


       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // Função pra mostrar os trem no Grid   
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["nomeloja_"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["email_"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["endereco_"].Value.ToString();
                txbcnpj.Text = dataGridView1.Rows[e.RowIndex].Cells["cnpj_"].Value.ToString();
                txbtelefone.Text = dataGridView1.Rows[e.RowIndex].Cells["telefone_"].Value.ToString();
                txbcep.Text = dataGridView1.Rows[e.RowIndex].Cells["cep_"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e) // insert
        {
            rowIndex = -1;
            MessageBox.Show("Insira um novo valor para Clientes. Ao terminar, Clique em Salvar.");

            textBox2.Enabled = textBox3.Enabled = textBox1.Enabled = txbcnpj.Enabled = txbtelefone.Enabled = txbcep.Enabled = true;
            textBox2.Text = textBox3.Text = textBox1.Text = txbcnpj.Text = txbtelefone.Text = txbcep.Text = null;
            textBox1.Select();
        }


        private void button4_Click(object sender, EventArgs e) // SAVE
        {
            int result = 0;
            if (rowIndex < 0)//insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from cliente_insert(:_nomeloja, :_email, :_endereco, :_cnpj, :_telefone, :_cep)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_nomeloja", textBox1.Text);
                    cmd.Parameters.AddWithValue("_email", textBox2.Text);
                    cmd.Parameters.AddWithValue("_endereco", textBox3.Text);
                    cmd.Parameters.AddWithValue("_cnpj", txbcnpj.Text);
                    cmd.Parameters.AddWithValue("_telefone", txbtelefone.Text);
                    cmd.Parameters.AddWithValue("_cep", txbcep.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Cliente inserido com Sucesso!");
                        select();   
                    }
                    else
                    {
                        MessageBox.Show("Falha na inserção. ");

                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Falha ao Inserir. Erro: " + ex.Message);
                }
            }
            else //update
            {
                try
                {
                    conn.Open();
                    sql = @"select * from cliente_update(:_id,:_nomeloja, :_email, :_endereco, :_cnpj, :_telefone, :_cep)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", int.Parse(dataGridView1.Rows[rowIndex].Cells["Id_"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_nomeloja", textBox1.Text);
                    cmd.Parameters.AddWithValue("_email", textBox2.Text);
                    cmd.Parameters.AddWithValue("_endereco", textBox3.Text);
                    cmd.Parameters.AddWithValue("_cnpj", txbcnpj.Text);
                    cmd.Parameters.AddWithValue("_telefone", txbtelefone.Text);
                    cmd.Parameters.AddWithValue("_cep", txbcep.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Cliente Atualizado com sucesso!");
                        select();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar");

                    }
                    select();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Erro ao atualizar. Erro: " + ex.Message);
                }
            }
            textBox2.Enabled = textBox3.Enabled = textBox1.Enabled = txbcnpj.Enabled = txbtelefone.Enabled = txbcep.Enabled = false;
            result = 0;
        }
        private void button2_Click(object sender, EventArgs e) // UPDATE
        {
            textBox2.Enabled = textBox3.Enabled = textBox1.Enabled = txbcnpj.Enabled = txbtelefone.Enabled = txbcep.Enabled = true;

            if (rowIndex < 0)
            {
                MessageBox.Show("Por Favor, escolha um item para atualizar!");
                    
            }
        }

        private void button3_Click(object sender, EventArgs e) // DELETE
        {

            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor, escolha um cliente para deletar.");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from cliente_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dataGridView1.Rows[rowIndex].Cells["Id_"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Cliente Deletado com Sucesso!");
                    rowIndex = -1;
                    Select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Erro ao Deletar. Erro: " + ex.Message);
            }
            select();
            textBox2.Enabled = textBox3.Enabled = textBox1.Enabled = txbcnpj.Enabled = txbtelefone.Enabled = txbcep.Enabled = false;

        }
        /// <summary>   
        /// /////////////////////////////    SEGUNDA ABA DO PROGRAMA    ////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void select_estoque()
        {
            try
            {
                conn.Open();
                sql = @"select * from estoque_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndexEstoque = e.RowIndex;
                btdescricao.Text = dataGridView2.Rows[e.RowIndex].Cells["_descricao"].Value.ToString();
                btcodigo.Text = dataGridView2.Rows[e.RowIndex].Cells["_codigo"].Value.ToString();
                btquantidade.Text = dataGridView2.Rows[e.RowIndex].Cells["_quantidade"].Value.ToString();
                btprecovenda.Text = dataGridView2.Rows[e.RowIndex].Cells["_precovenda"].Value.ToString();
                btprecocompra.Text = dataGridView2.Rows[e.RowIndex].Cells["_precocompra"].Value.ToString();

            }
        }


        private void btsaveestoque_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndexEstoque < 0)//insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from estoque_insert(:_descricao, :_codigo, :_quantidade, :_precovenda, :_precocompra)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_descricao", btdescricao.Text);
                    cmd.Parameters.AddWithValue("_codigo", btcodigo.Text);
                    cmd.Parameters.AddWithValue("_quantidade", btquantidade.Text);
                    cmd.Parameters.AddWithValue("_precovenda", btprecovenda.Text);
                    cmd.Parameters.AddWithValue("_precocompra", btprecocompra.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Inserção feita com sucesso!");
                        select_estoque();

                    }
                    else
                    {
                        MessageBox.Show("inserção Falhada.");

                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Falha ao inserir. Erro: " + ex.Message);
                }
            }
            else //update
            {
                try
                {
                    conn.Open();
                    sql = @"select * from estoque_update(:es_id, :_descricao, :_codigo, :_quantidade, :_precovenda, :_precocompra)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("es_id", int.Parse(dataGridView2.Rows[rowIndexEstoque].Cells["_id"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_descricao", btdescricao.Text);
                    cmd.Parameters.AddWithValue("_codigo", btcodigo.Text);
                    cmd.Parameters.AddWithValue("_quantidade", btquantidade.Text);
                    cmd.Parameters.AddWithValue("_precovenda", btprecovenda.Text);
                    cmd.Parameters.AddWithValue("_precocompra", btprecocompra.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Item atualizado com sucesso!");
                        select();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Atualizar.");

                    }
                    MessageBox.Show("Item atualizado com sucesso!");
                    select_estoque();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Erro ao Atualizar. Erro: " + ex.Message);
                }
            }
            btprecocompra.Enabled = btdescricao.Enabled = btquantidade.Enabled = btprecovenda.Enabled = btcodigo.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e) // DELETA ESTOQUE
        {
            if (rowIndexEstoque < 0)
            {
                MessageBox.Show("Por favor, selecione um item do Estoque para excluir");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from estoque_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dataGridView2.Rows[rowIndexEstoque].Cells["_id"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Item deletado com sucesso!");
                    rowIndexEstoque = -1;
                    select_estoque();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Falha ao Deletar. Erro: " + ex.Message);
            }
            select_estoque();
        }

        private void button5_Click_1(object sender, EventArgs e) //INSERT ESTOQUE
        {
            MessageBox.Show("Insira um novo valor para o Estoque. Ao terminar, Clique em Salvar.");
            rowIndexEstoque = -1;
            btprecocompra.Enabled = btdescricao.Enabled = btquantidade.Enabled = btprecovenda.Enabled = btcodigo.Enabled = true;
            btprecocompra.Text = btdescricao.Text = btquantidade.Text = btprecovenda.Text = btcodigo.Text = null;
            btprecocompra.Select();
        }
        private void btupdateestoque_Click(object sender, EventArgs e)
        {
            btprecocompra.Enabled = btdescricao.Enabled = btquantidade.Enabled = btprecovenda.Enabled = btcodigo.Enabled = true;

            if (rowIndexEstoque < 0)
            {
                MessageBox.Show("Por favor, escolha um item para atualizar.");

            }
        }






        /// <summary>   
        /// /////////////////////////////    TERCEIRA ABA DO PROGRAMA    ////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private int rowIndexVenda = -1;
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                rowIndexVenda = e.RowIndex;
                btquantidadevenda.Text = dataGridView3.Rows[e.RowIndex].Cells["_quantidade"].Value.ToString();
                txbprecovenda.Text = dataGridView3.Rows[e.RowIndex].Cells["_precovenda"].Value.ToString();
                txbvalortotal.Text = dataGridView3.Rows[e.RowIndex].Cells["_valortotal"].Value.ToString();
                txbcodigo.Text = dataGridView3.Rows[e.RowIndex].Cells["_codigo"].Value.ToString();
                txbnomeloja.Text = dataGridView3.Rows[e.RowIndex].Cells["_nomeloja"].Value.ToString();
                horario.Text = dataGridView3.Rows[e.RowIndex].Cells["_horario"].Value.ToString();

            }
        }
        private void select_venda()
        {
            try
            {
                conn.Open();
                sql = @"select * from venda_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void btsavevenda_Click(object sender, EventArgs e) // SAVE para VENDAS
        {
            int result = 0;
            if (rowIndexVenda < 0)//insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from venda_insert(:_quantidade, :_precovenda, :_valortotal, :_codigo, :_nomeloja, :_horario)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_quantidade", btquantidadevenda.Text);
                    cmd.Parameters.AddWithValue("_precovenda", txbprecovenda.Text);
                    cmd.Parameters.AddWithValue("_valortotal", txbvalortotal.Text);
                    cmd.Parameters.AddWithValue("_codigo", txbcodigo.Text);
                    cmd.Parameters.AddWithValue("_nomeloja", txbnomeloja.Text);
                    cmd.Parameters.AddWithValue("_horario", horario.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Inserção feita com sucesso!");
                        select_venda();

                    }
                    else
                    {
                        MessageBox.Show("inserção Falhada.");

                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Falha ao inserir. Erro: " + ex.Message);
                }
            }
            else //update
            {
                try
                {
                    conn.Open();
                    sql = @"select * from venda_update(:_id, :_quantidade, :_precovenda, :_valortotal, :_codigo, :_nomeloja, :_horario)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", int.Parse(dataGridView3.Rows[rowIndexVenda].Cells["_venda_id"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_quantidade", btquantidadevenda.Text);
                    cmd.Parameters.AddWithValue("_precovenda", txbprecovenda.Text);
                    cmd.Parameters.AddWithValue("_valortotal", txbvalortotal.Text);
                    cmd.Parameters.AddWithValue("_codigo", txbcodigo.Text);
                    cmd.Parameters.AddWithValue("_nomeloja", txbnomeloja.Text);
                    cmd.Parameters.AddWithValue("_horario", horario.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Item atualizado com sucesso!");
                        select_venda();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Atualizar.");

                    }
                    select_venda();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Erro ao Atualizar. Erro: " + ex.Message);
                }
            }
            btquantidadevenda.Enabled = txbprecovenda.Enabled = txbvalortotal.Enabled = txbcodigo.Enabled = txbnomeloja.Enabled = horario.Enabled = false;

        }
        private void btinserirvenda_Click(object sender, EventArgs e) //INSERIR VENDAS
        {
            MessageBox.Show("Insira um novo valor de Vendas. Ao terminar, Clique em Salvar.");
            rowIndexVenda = -1;
            btquantidadevenda.Enabled = txbprecovenda.Enabled = txbvalortotal.Enabled = txbcodigo.Enabled = txbnomeloja.Enabled = horario.Enabled = true;
            btquantidadevenda.Text = txbprecovenda.Text = txbvalortotal.Text = txbcodigo.Text = txbnomeloja.Text = horario.Text = null;
            btquantidadevenda.Select();
        }
        private void btupdatevenda_Click(object sender, EventArgs e)
        {
            btquantidadevenda.Enabled = txbprecovenda.Enabled = txbvalortotal.Enabled = txbcodigo.Enabled = txbnomeloja.Enabled = horario.Enabled = true;

            if (rowIndexVenda < 0)
            {
                MessageBox.Show("Por favor, escolha um item para atualizar.");

            }
        }

        private void btdeletevenda_Click(object sender, EventArgs e)
        {
            if (rowIndexVenda < 0)
            {
                MessageBox.Show("Por favor, selecione um item de Vendas para excluir");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from venda_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dataGridView3.Rows[rowIndexVenda].Cells["_venda_id"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Item deletado com sucesso!");
                    rowIndexEstoque = -1;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Falha ao Deletar. Erro: " + ex.Message);
            }
            select_venda();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btprecovenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btprecocompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbcnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbtelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbcep_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
