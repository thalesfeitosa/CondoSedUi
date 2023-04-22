using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;  

namespace condoSedUi
{
    public class CadEncomendaClass
    {

        ConexaoBd conBd = new ConexaoBd();
        NpgsqlCommand commandInsert = new NpgsqlCommand();
        public string mensagem;

        public CadEncomendaClass(string destinatarioTxtBox, string apartamentoTxtBox,string blocoTxtBox, string recebedorCondominioTxtBox,
            string recebedorCondominoTxtBox, string rastreamentoTxtBox, bool statusCheckBox, string localizacaoTxtBox)
        {
            
            
            // comandos sql
            commandInsert.CommandText = "Insert Into condo.encomendas (nmdestinatario, dsbloco, dsapt, nmrecebedordest, cdrastreamento, localizacaofisica, recebedorcondo, status)" +
                "VALUES (@nmdestinatario, @dsbloco, @dsapt, @nmrecebedordest, @cdrastreamento, @localizacaofisica, @recebedorcondo, @status)";

            //parametros insert 
            commandInsert.Parameters.AddWithValue("@nmdestinatario", destinatarioTxtBox);
            commandInsert.Parameters.AddWithValue("@dsapt", apartamentoTxtBox);
            commandInsert.Parameters.AddWithValue("@dsbloco", blocoTxtBox);
            commandInsert.Parameters.AddWithValue("@recebedorcondo", recebedorCondominioTxtBox);
            commandInsert.Parameters.AddWithValue("@nmrecebedordest", recebedorCondominoTxtBox);
            commandInsert.Parameters.AddWithValue("@cdrastreamento", rastreamentoTxtBox);
            commandInsert.Parameters.AddWithValue("@status", statusCheckBox);
            commandInsert.Parameters.AddWithValue("@localizacaofisica", localizacaoTxtBox);

            try
            {
                commandInsert.Connection = conBd.Connectar();
                commandInsert.ExecuteNonQuery();
                this.mensagem = "Cadastro Realizado com Sucesso";
                conBd.desconect();
            }
            catch (Exception ex)
            {
                this.mensagem = "Erro ao Conectar ao Banco" + ex;
            }
        }
    }
}
