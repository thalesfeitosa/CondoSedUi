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
    public partial class ConfigBD : Form
    {

        

        public ConfigBD()
        {
            InitializeComponent();
        }

        private void closeFormBdButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void conectaBdButton_Click(object sender, EventArgs e)
        {
            ConexaoBd cnBd = new ConexaoBd();
            
            
        }
    }
}
