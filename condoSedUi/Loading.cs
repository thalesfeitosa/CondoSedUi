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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                TelaInicial Tin = new TelaInicial();
                Tin.ShowDialog();
            }            
            else porcentagemLabel.Text = progressBar1.Value.ToString() + "%";
        }

        
    }
}
