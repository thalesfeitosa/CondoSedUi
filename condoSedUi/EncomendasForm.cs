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
    public partial class EncomendasForm : Form
    {
        public EncomendasForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            EncomendasClass Ec = new EncomendasClass(destinatarioTxtBox.Text, apartamentoTxtBox.Text, blocoTxtBox.Text, recebedorCondominioTxtBox.Text,
                recebedorCondominoTxtBox.Text, rastreamentoTxtBox.Text, statusCheckBox.Checked);
            
        }
    }
}
