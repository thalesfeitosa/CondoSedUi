using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NpgsqlTypes;
using System.Drawing.Text;

namespace condoSedUi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cnBd = new NpgsqlConnection();
            cnBd.ConnectionString = "Server = localhost; Port = 5432; Database = condosed;User id= postgres; Password = #abc123#";

            string query = "Select * From system.usuarios where nmusuario =' " + userTextoBox.Text + "'and senha ='" + senhaMasketBox.Text + "'";

            NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(query, cnBd);
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);

            if (dt.Rows.Count == 1 )
            {
                this.Hide();

                                          
                userTextoBox.Text = string.Empty;
                senhaMasketBox.Text = string.Empty; 
                
            }
            

            else
            {
                MessageBox.Show("Usuário ou Senha Incorreta! Verifique", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userTextoBox.Select();
            }
        }
    }
}
