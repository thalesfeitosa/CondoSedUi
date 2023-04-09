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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void bdButton_Click(object sender, EventArgs e)
        {
            ConfigBD cfbd= new ConfigBD();
            cfbd.ShowDialog();
            
        }

        private void cadastroCondominoButton_Click(object sender, EventArgs e)
        {
            cadastroCondominoPanel.Visible = true;
        }

        private void cadastroCondominoButton_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            cadastroCondominoPanel.Visible = false;
           /* cadastroCondominoButton.Enabled = false;
            encomendasButton.Enabled= false;
            areaComunButton.Enabled= false;
            livroReclamacoesButton.Enabled= false;
            achadosPerdidosButton.Enabled= false;
            relatoriosButton.Enabled= false;*/
            proprietarioTextBox.Visible = false;
            proprietarioLabel.Visible = false;
            addVagaButton.Visible = false;
            addVagabutton2.Visible = false;
            tipoVagaLbl.Visible = false;
            tipoVagaLbl2.Visible = false;
            tipoVagaLbl3.Visible = false;
            marcaVagaLbl.Visible=false;
            marcaVagaLbl2.Visible=false;
            marcaVagaLbl3.Visible=false;
            modeloVagaLbl.Visible=false;
            modeloVagaLbl2.Visible=false;
            modeloVagaLbl3.Visible=false;
            placaVagaLbl.Visible=false;
            placaVagaLbl2.Visible=false;
            placaVagaLbl3.Visible=false;
            tipoTxtBox.Visible=false;
            tipoTxtBox2.Visible=false;
            tipoTxtBox3.Visible=false;
            marcaTxtBox.Visible=false;
            marcaTxtBox2.Visible=false;
            marcaTxtBox3.Visible=false;
            modeloTxtBox.Visible=false;
            modeloTxtBox2.Visible=false;
            modeloTxtBox3.Visible=false;
            placaTxtBox.Visible=false;
            placaTxtBox2.Visible = false;
            placaTxtBox3.Visible=false;

            


        }

        private void encomendasButton_Click(object sender, EventArgs e)
        {
            cadastroCondominoPanel.Visible = false;

        }

        public void loginLabel_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.ShowDialog();
        }

        private void simCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (simCheckBox.Checked)
            {
                proprietarioTextBox.Visible = true;
                proprietarioLabel.Visible = true;
            }
            else
            {
                proprietarioTextBox.Visible = false;
                proprietarioLabel.Visible = false;
            }
        }

        private void naoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (naoCheckBox.Checked)
            {
                proprietarioTextBox.Visible = false;
                proprietarioLabel.Visible = false;
            }
            else
            {
                proprietarioTextBox.Visible = false;
                proprietarioLabel.Visible = false;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void addVagaButton_Click(object sender, EventArgs e)
        {
            tipoTxtBox2.Visible = true;
            tipoVagaLbl2.Visible = true;
            marcaTxtBox2.Visible=true;
            marcaVagaLbl2.Visible=true;
            modeloTxtBox2.Visible=true;
            modeloVagaLbl2.Visible=true;
            placaTxtBox2.Visible = true;
            placaVagaLbl2.Visible = true;
            addVagabutton2.Visible = true;
        }

        private void garagemSimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           if (garagemSimCheckBox.Checked)
            {
                tipoTxtBox.Visible = true;
                tipoVagaLbl.Visible = true;
                marcaTxtBox.Visible = true;
                marcaVagaLbl.Visible = true;
                modeloTxtBox.Visible = true;
                modeloVagaLbl.Visible = true;
                placaTxtBox.Visible = true;
                placaVagaLbl.Visible = true;
                addVagaButton.Visible = true;

            }
            else
            {
                tipoTxtBox.Visible = false;
                tipoVagaLbl.Visible = false;
                marcaTxtBox.Visible = false;
                marcaVagaLbl.Visible = false;
                modeloTxtBox.Visible = false;
                modeloVagaLbl.Visible = false;
                placaTxtBox.Visible = false;
                placaVagaLbl.Visible = false;
                addVagaButton.Visible = false;
                tipoTxtBox2.Visible = false;
                tipoVagaLbl2.Visible = false;
                marcaTxtBox2.Visible = false;
                marcaVagaLbl2.Visible = false;
                modeloTxtBox2.Visible = false;
                placaTxtBox2.Visible = false;
                placaVagaLbl2.Visible = false;
                addVagabutton2.Visible = false;
                tipoTxtBox3.Visible = false;
                tipoVagaLbl3.Visible = false;
                marcaTxtBox3.Visible = false;
                marcaVagaLbl3.Visible = false;
                modeloTxtBox3.Visible = false;
                modeloVagaLbl3.Visible = false;
                placaVagaLbl3.Visible = false;
                placaTxtBox3.Visible = false;
                modeloVagaLbl2.Visible=false;

            }


        }

        private void addVagabutton2_Click(object sender, EventArgs e)
        {
            tipoTxtBox3.Visible = true;
            tipoVagaLbl3.Visible = true;
            marcaTxtBox3.Visible = true;
            marcaVagaLbl3.Visible = true;
            modeloTxtBox3.Visible = true;
            modeloVagaLbl3.Visible = true;
            placaVagaLbl3 .Visible = true;
            placaTxtBox3 .Visible = true;
        }
    }
}
