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
    public partial class formID : Form
    {
        public formID()
        {
            InitializeComponent();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btAtivar_Click(object sender, EventArgs e)
        {
            lblId.Visible = true;
            txtId.Visible = true;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            string conexao = "Server=localhost;Database=db_usuarios;Uid=root;Pwd=root;";
            string query = "SELECT ID, NOME, EMAIL FROM tb_usuarios WHERE ID = @id";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGrid.DataSource = dt;
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar consultar o registro: " + ex.Message);
                }
            }
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

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
