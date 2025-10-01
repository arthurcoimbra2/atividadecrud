using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade1
{
    public partial class formDelete : Form
    {
        public formDelete()
        {
            InitializeComponent();
        }

        private void btAtivar_Click(object sender, EventArgs e)
        {
            lblId.Visible = true;
            txtId.Visible = true;
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=db_usuarios;Uid=root;Pwd=root;";
            string query = "SELECT ID, NOME, EMAIL FROM tb_usuarios";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGrid.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

            string conexao = "Server=localhost;Database=db_usuarios;Uid=root;Pwd=root;";
            string query = "DELETE FROM tb_usuarios WHERE ID = @id_usuario";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@id_usuario", txtId.Text);


                    int linhasAfetadas = cmd.ExecuteNonQuery();


                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("O usuário com ID " + txtId.Text + " foi excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário encontrado com este ID para ser excluído.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar deletar o registro: " + ex.Message);
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
