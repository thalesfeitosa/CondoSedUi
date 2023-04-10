using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace condoSedUi
{
    public partial class CadastrarForm : Form
    {
        public CadastrarForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void CadastrarForm_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection("Server = localhost; Port = 5432; Database = condosed;User id= postgres; Password = #abc123#"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT nmfuncao FROM condo.funcao", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            funcaoComboBox.Items.Add(reader["nmfuncao"].ToString());
                        }
                    }
                }
            }

        }

        private void salvarButtonCad_Click(object sender, EventArgs e)
        {
            CadUsuarioClass cad = new CadUsuarioClass(userTextBox.Text, senhaMaskedBox.Text, funcaoComboBox.Text);
            MessageBox.Show(cad.mensagem);
        }
    }
}
