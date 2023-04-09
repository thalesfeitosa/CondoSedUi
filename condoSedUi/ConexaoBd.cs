using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using Npgsql.Internal;




namespace condoSedUi
{
    public class ConexaoBd
    {
        //instancia de conexão
        NpgsqlConnection conn = new NpgsqlConnection();
        
        //construtor (tem o mesmo nome da classe)

        public ConexaoBd()
        {
            // string de conexão

            conn.ConnectionString = "Server = localhost; Port = 5432; Database = condosed; User id = postgres; Password = #abc123#";
        }

        //método conectar

        public NpgsqlConnection Connectar()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();    
            }
            return conn;

        }

        //método desconectar

        public void desconect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
