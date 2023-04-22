using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace condoSedUi
{
    public class EncomendasClass
    {
        ConexaoBd conBd = new ConexaoBd();
        NpgsqlCommand commandInsert = new NpgsqlCommand();
        NpgsqlCommand commandselect= new NpgsqlCommand();

        public string mensagem;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;
        private bool @checked;

        
        // construtor
        public EncomendasClass(string destinatarioTxtBox, string apartamentoTxtBox,string blocoTxtBox, string recebedorCondominioTxtBox,
            string recebedorCondominoTxtBox, string rastreamentoTxtBox, bool statusCheckBox, string localizacaoTxtBox)
        {
                       
            // comandos sql
           
            commandselect.CommandText = "Select nmdestinatario, dsbloco, dsapt, nmrecebedordest, cdrastreamento, localizacaofisica, recebedorcondo, status from condo.encomendas";

            //parametros select
            commandselect.Parameters.AddWithValue("@nmdestinatario", destinatarioTxtBox);
            commandselect.Parameters.AddWithValue("@dsapt", apartamentoTxtBox);
            commandselect.Parameters.AddWithValue("@dsbloco", blocoTxtBox);
            commandselect.Parameters.AddWithValue("@recebedorcondo", recebedorCondominioTxtBox);
            commandselect.Parameters.AddWithValue("@nmrecebedordest", recebedorCondominoTxtBox);
            commandselect.Parameters.AddWithValue("@cdrastreamento", rastreamentoTxtBox);
            commandselect.Parameters.AddWithValue("@status", statusCheckBox);
            commandselect.Parameters.AddWithValue("@localizacaofisica", localizacaoTxtBox);

           
            //conectar bd
            try
            {
                commandselect.ExecuteNonQuery();
                conBd.desconect();
            }
            catch (Exception ex)
            {
                this.mensagem = "Erro ao Realizar Pesquisa" + ex;
            }

        }

        public EncomendasClass(string text1, string text2, string text3, string text4, string text5, string text6, bool @checked)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.@checked = @checked;
        }
    }
}
