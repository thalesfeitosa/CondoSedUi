using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace condoSedUi
{
    public partial class TelaInicial : Form

    {
        public string usuario
        {
            get { return loginLabel.Text; }
            set { loginLabel.Text = value;}


        }
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
            especieLabel.Visible=false;
            gatoCheckBox.Visible=false;
            cachorroCheckBox.Visible=false;
            outrosCheckBox.Visible=false;
            outroTextBox.Visible=false;

            


        }

        private void encomendasButton_Click(object sender, EventArgs e)
        {
            
            cadastroCondominoPanel.Visible = false;
            EncomendasForm Ef = new EncomendasForm();
            Ef.ShowDialog();

            


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

        private void animaisCheckBoxSim_CheckedChanged(object sender, EventArgs e)
        {
        if (animaisCheckBoxSim.Checked)
            {
                especieLabel.Visible = true;
                gatoCheckBox.Visible = true;
                cachorroCheckBox.Visible = true;
                outrosCheckBox.Visible = true;
            }
            else
            {
                especieLabel.Visible = false;
                gatoCheckBox.Visible = false;
                cachorroCheckBox.Visible = false;
                outrosCheckBox.Visible = false;
                outroTextBox.Visible = false;
            }
        }

        private void outrosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (outrosCheckBox.Checked)
            {
                outroTextBox.Visible=true;
            }
            else
            {
                outroTextBox.Visible = false;
            }
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cancelarPessoaButton_Click(object sender, EventArgs e)
        {
            nomeTextBox.Text = string.Empty;
            blocoTextBox.Text = string.Empty;
            aptTextBox.Text = string.Empty;
            proprietarioTextBox.Text = string.Empty;
            simCheckBox.Checked = false;
            naoCheckBox.Checked = false;
            telefoneMaskBox.Text = string.Empty;
            nomeMoradorTxtBox.Text = string.Empty;
            parentescoMoradorTxtBox.Text= string.Empty;
            nascimentoMoradorMaskBox.Text = string.Empty;
            nomeMoradorTxtBox2.Text = string.Empty;
            parentescoMoradorTxtBox2.Text = string.Empty;
            nascimentoMoradorMaskBox2.Text = string.Empty; nomeMoradorTxtBox.Text = string.Empty;
            parentescoMoradorTxtBox3.Text = string.Empty;
            nascimentoMoradorMaskBox3.Text = string.Empty;
            nomeMoradorTxtBox3.Text = string.Empty;
            garagemNaoCheckBox.Checked = false;
            garagemSimCheckBox.Checked = false;
            tipoTxtBox.Text = string.Empty;
            modeloTxtBox.Text = string.Empty;
            marcaTxtBox.Text = string.Empty;
            placaTxtBox.Text = string.Empty;
            tipoTxtBox2.Text = string.Empty;
            modeloTxtBox2.Text = string.Empty;
            marcaTxtBox2.Text = string.Empty;
            placaTxtBox2.Text = string.Empty;
            tipoTxtBox3.Text = string.Empty;
            modeloTxtBox3.Text = string.Empty;
            marcaTxtBox3.Text = string.Empty;
            placaTxtBox3.Text = string.Empty;
            animaisCheckBoxNao.Checked = false;
            animaisCheckBoxSim.Checked = false;
            nomeEmergenciaTextBox.Text = string.Empty;
            parentescoEmergenciaTextBox.Text = string.Empty;
            contatoEmergenciaMaskBox.Text = string.Empty;
            nomeEmergenciaTxtBox2.Text = string.Empty;
            parentescoEmergenciaTxtBox2.Text = string.Empty;
            contatoEmergenciaMaskBox2.Text = string.Empty;



        }

        private void salvarPessoaButton_Click(object sender, EventArgs e)
        {
            CadCondominioClass ccp = new CadCondominioClass(nomeTextBox.Text, blocoTextBox.Text, aptTextBox.Text, telefoneMaskBox.Text,
                simCheckBox.Checked, naoCheckBox.Checked, proprietarioTextBox.Text, nomeMoradorTxtBox.Text, nomeMoradorTxtBox2.Text, nomeMoradorTxtBox3.Text,
                nascimentoMoradorMaskBox.Text, nascimentoMoradorMaskBox2.Text, nascimentoMoradorMaskBox3.Text, garagemSimCheckBox.Checked,tipoTxtBox.Text, tipoTxtBox2.Text, tipoTxtBox3.Text,
                marcaTxtBox.Text, marcaTxtBox2.Text, marcaTxtBox3.Text, modeloTxtBox.Text, modeloTxtBox2.Text, modeloTxtBox3.Text, placaTxtBox.Text, placaTxtBox2.Text, placaTxtBox3.Text,
                animaisCheckBoxSim.Checked, gatoCheckBox.Checked, cachorroCheckBox.Checked, outrosCheckBox.Checked, outroTextBox.Text, nomeEmergenciaTextBox.Text, nomeEmergenciaTxtBox2.Text, parentescoEmergenciaTextBox.Text,
                parentescoEmergenciaTxtBox2.Text, contatoEmergenciaMaskBox.Text, contatoEmergenciaMaskBox2.Text);
            MessageBox.Show(ccp.mensagem);
        }

        private void prestadoresServicoButton_Click(object sender, EventArgs e)
        {
            cadastroCondominoPanel.Visible = false;

        }

        private void relatoriosButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RECURSO EM DESENVOLVIMENTO");
        }
    }
}
