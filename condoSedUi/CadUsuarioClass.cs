using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace condoSedUi
{
    public class CadUsuarioClass
    {
        ConexaoBd con = new ConexaoBd();
        NpgsqlCommand commandinsert = new NpgsqlCommand();
        NpgsqlCommand select = new NpgsqlCommand();
       

        public String mensagem;

        public CadUsuarioClass(string nmusuario, string senha, string funcao)
        {


            // comando sql - insert, update, delete
            commandinsert.CommandText = "Insert into system.usuarios (nmusuario, senha, funcao) values (@nmusuario, @senha, @funcao) ";

            select.CommandText = "Select nmusuario from system.usuarios";


            // parametros insert
            commandinsert.Parameters.AddWithValue("@nmusuario", nmusuario);
            commandinsert.Parameters.AddWithValue("@senha", senha);
            commandinsert.Parameters.AddWithValue("@funcao", funcao);

            select.Parameters.AddWithValue("@nmusuario", nmusuario);
            select.Parameters.AddWithValue("@senha", senha);
            select.Parameters.AddWithValue("@funcao", funcao);

            //conectar com BD
            try
            {
                commandinsert.Connection = con.Connectar();

                //executar comando
                commandinsert.ExecuteNonQuery();

                con.desconect();



                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastro Realizado Com Sucesso";

            }

            catch (NpgsqlException error)
            {
                this.mensagem = "Erro de Conexão com bd" + error;
            }


        }
    }

}
    

