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

namespace Crud
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Cadastro;Integrated Security=True");

        SqlCommand CMD;
        SqlDataAdapter adapter;
        int id = 0;

       
        public Form1()
        {
            InitializeComponent();

            ExibirDados();
        }

        public void ExibirDados()
            
        {
            try
            {

                con.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("Select * from Contatos", con);
                adapter.Fill(dt);
                dgvAgenda.DataSource = dt;
            }
            catch 
            {
                throw;
            }
            finally
            {
                con.Close();
            }

        }
        public void LimparDados()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            id = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair Do Programa?","Agenda",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtNome.Focus();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
