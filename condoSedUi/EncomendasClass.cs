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

        // construtor
        public EncomendasClass(string destinatarioTxtBox, string apartamentoTxtBox,string blocoTxtBox, string recebedorCondominioTxtBox,
            string recebedorCondominoTxtBox, string rastreamentoTxtBox, bool statusCheckBox, string localizacaoTxtBox)
        {
            // comandos sql
            commandInsert.CommandText = "Insert Into condo.encomendas (nmdestinatario, dsbloco, dsapt, nmrecebedordest, cdrastreamento, localizacaofisica, recebedorcondo, status, idpessoa)" +
                "VALURES (@nmdestinatario, @dsbloco, @dsapt, @nmrecebedordest, @cdrastreamento, @localizacaofisica, @recebedorcondo, @status, @idpessoa)";

            commandselect.CommandText = "Select nmdestinatario, dsbloco, dsapt, nmrecebedordest, cdrastreamento, localizacaofisica, recebedorcondo, status from condo.encomendas";

            //parametros 
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
        


    }
}
