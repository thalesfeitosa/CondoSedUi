using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace condoSedUi
{
    public partial class EncomendasForm : Form
    {
        NpgsqlCommand com = new NpgsqlCommand();
        public string mensagem;

        public EncomendasForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buscarButton_Click(object sender, EventArgs e)
        {
            //busca o que está digitado na txtBox buscarTxtBox

            string busca = buscarTxtBox.Text;

            //executa a consulta do banco de dados
            using (var connecta = new NpgsqlConnection("Server = localhost; Port = 5432; Database = condosed;" +
                "User id= postgres; Password = #abc123#"))
            {
                connecta.Open();
                NpgsqlCommand command = new NpgsqlCommand("Select nmdestinatario, dsbloco, dsapt, nmrecebedordest," +
                    " cdrastreamento, localizacaofisica, recebedorcondo, status from condo.encomendas = @busca", connecta);

                command.Parameters.AddWithValue("@buscarTxtBox", busca);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    destinatarioTxtBox.Text = reader["nmdestinatario"].ToString();
                    apartamentoTxtBox.Text = reader["dsapt"].ToString();
                    blocoTxtBox.Text = reader["dsbloco"].ToString();
                    recebedorCondominioTxtBox.Text = reader["nmrecebedordest"].ToString();
                    rastreamentoTxtBox.Text = reader["cdrastreamento"].ToString();
                    localizacaoTxtBox.Text = reader["localizacaofisica"].ToString();
                    recebedorCondominoTxtBox.Text = reader["recebedorcondo"].ToString();
                    statusCheckBox.Checked = (bool)reader["status"];

                }
                else
                {
                    MessageBox.Show("Que pena, Nenhuim resultado para a Busca :( !!");
                }
                reader.Close();



            }

        }

        public void encomendaSaveButton_Click(object sender, EventArgs e)
        {

            CadEncomendaClass Ecad = new CadEncomendaClass(destinatarioTxtBox.Text, apartamentoTxtBox.Text, blocoTxtBox.Text, recebedorCondominioTxtBox.Text,
                recebedorCondominoTxtBox.Text, rastreamentoTxtBox.Text, statusCheckBox.Checked, localizacaoTxtBox.Text);

            MessageBox.Show(Ecad.mensagem);

            destinatarioTxtBox.Text = string.Empty;
            apartamentoTxtBox.Text = string.Empty;
            blocoTxtBox.Text = string.Empty;
            recebedorCondominioTxtBox.Text = string.Empty;
            recebedorCondominoTxtBox.Text = string.Empty;
            rastreamentoTxtBox.Text = string.Empty;
            statusCheckBox.Checked = false;
            localizacaoTxtBox.Text = string.Empty;

        }

        //public string strconn = @"Server = localhost; Port = 5432; Database = condosed;User id= postgres; Password = #abc123#";
        ConexaoBd strconn = new ConexaoBd();
        NpgsqlConnection objConn = null;
        NpgsqlCommand objCom = null;

        public void listaGrid()
        {
            ConexaoBd strconn = new ConexaoBd();
            string strSql = "Select nmdestinatario, dsbloco, dsapt, nmrecebedordest, cdrastreamento,localizacaofisica, recebedorcondo,status from condo.encomendas";
            objConn = new NpgsqlConnection();
            objCom = new NpgsqlCommand(strSql);

            try
            {
                NpgsqlDataAdapter objAdp = new NpgsqlDataAdapter(objCom);
                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

            catch(NpgsqlException error) 
            {
                MessageBox.Show("Erro de conexão com o Banco" + error);
            }
           
        }

        private void EncomendasForm_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

    }
}
