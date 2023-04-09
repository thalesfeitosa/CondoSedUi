using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
