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
    public class CadCondominioClass
    {
        ConexaoBd conbd = new ConexaoBd();
        NpgsqlCommand commdinsert = new NpgsqlCommand();
        public string mensagem;

        public CadCondominioClass(string nmpessoa, string nmbloco, string nmunidade, string telefone, bool proprietario,
            string nmproprietario, string nmmoradores, string nmmoradores2, string nmmoradores3, string nmmoradores4, string parentesco,
            string parentesco2, string parentesco3, string parentesco4,DateTime datanascimento, DateTime datanascimento2, DateTime datanascimento3, DateTime datanascimento4,
            Boolean vagagaragem, string veiculomarca, string veiculomarca2, string veiculomarca3, string veiculotipo, string veiculotipo2, string veiculotipo3,
            string veiculomodelo, string veiculomodelo2, string veiculomodelo3,string veiculoplaca, string veiculoplaca2, string veiculoplaca3,  Boolean animais,
            string animalespeciegato, string animalespeciecachorro, string animalespecieoutros, 
            string animalquantidade, string emergencianome, string emergencianome2, string telefoneemergencia, string telefoneemergencia2)
        {
            //comando SQL insert 
            commdinsert.CommandText = "Insert into condo.pessoas (nmpessoa, nmbloco,nmunidade telefone, proprietario, nmproprietario, nmmoradores, nmmoradores2," +
                "nmmoradores3,nmmoradores4, parentesco, parentesco2,parentesco3,parentesco4, datanascimento,datanascimento2,datanascimento3,datanascimento4," +
                " animais, animalespeciegato, animalespeciecachorro, animalespecieoutros, animalquantidade, emergencianome, emergencianome2, telefoneemergencia" +
                "telefoneemergencia2 ) values (@nmpessoa, @nmbloco,@nmunidade, @telefone, @proprietario, @nmproprietario, @nmmoradores, @nmmoradores2," +
                "@nmmoradores3,@nmmoradores4, @parentesco, @parentesco2,@parentesco3,@parentesco4, @datanascimento,@datanascimento2,@datanascimento3,@datanascimento4," +
                " @animais, @animalespeciegato, @animalespeciecachorro, @animalespecieoutros, @animalquantidade, @emergencianome, @emergencianome2, @telefoneemergencia" +
                "@telefoneemergencia2 )";

            commdinsert.CommandText = "Insert into condo.veiculos(vagagaragem, veiculotipo,veiculotipo2,veiculotipo3, veiculomarca," +
                "veiculomarca2,veiculomarca3, veiculomodelo, veiculomodelo2,veiculomodelo3, veiculoplaca, veiculoplaca2,veiculoplaca3) values (@vagagaragem, @veiculotipo,@veiculotipo2,@veiculotipo3," +
                " @veiculomarca,@veiculomarca2,@veiculomarca3, @veiculomodelo, @veiculomodelo2,@veiculomodelo3, @veiculoplaca, @veiculoplaca2,@veiculoplaca3)";

            //parametros tabela condo.pessoas

            commdinsert.Parameters.AddWithValue("@nmpessoa", nmpessoa);
            commdinsert.Parameters.AddWithValue("@nmbloco", nmbloco);
            commdinsert.Parameters.AddWithValue("@telefone",telefone);
            commdinsert.Parameters.AddWithValue("@proprietario",proprietario);
            commdinsert.Parameters.AddWithValue("@nmproprietario",nmproprietario);
            commdinsert.Parameters.AddWithValue("@nmmoradores", nmmoradores);
            commdinsert.Parameters.AddWithValue("@nmmoradores2", nmmoradores2);
            commdinsert.Parameters.AddWithValue("@nmmoradores3", nmmoradores3);
            commdinsert.Parameters.AddWithValue("@nmmoradores4", nmmoradores4);
            commdinsert.Parameters.AddWithValue("@parentesco", parentesco);
            commdinsert.Parameters.AddWithValue("@parentesco2", parentesco2);
            commdinsert.Parameters.AddWithValue("@parentesco3", parentesco3);
            commdinsert.Parameters.AddWithValue("@parentesco4", parentesco4);
            commdinsert.Parameters.AddWithValue("@datanascimento", datanascimento);
            commdinsert.Parameters.AddWithValue("@datanascimento2", datanascimento2);
            commdinsert.Parameters.AddWithValue("@datanascimento3", datanascimento3);
            commdinsert.Parameters.AddWithValue("@datanascimento4", datanascimento4);
            commdinsert.Parameters.AddWithValue("@animais", animais);
            commdinsert.Parameters.AddWithValue("@animalespeciegato", animalespeciegato);
            commdinsert.Parameters.AddWithValue("@animalespeciecachorro", animalespeciecachorro);
            commdinsert.Parameters.AddWithValue("@animalespecieoutros", animalespecieoutros);
            commdinsert.Parameters.AddWithValue("@animalquantidade", animalquantidade);
            commdinsert.Parameters.AddWithValue("@emergencianome", emergencianome);
            commdinsert.Parameters.AddWithValue("@emergencianome2", emergencianome2);
            commdinsert.Parameters.AddWithValue("@telefoneemergencia", telefoneemergencia);
            commdinsert.Parameters.AddWithValue("@telefoneemergencia2", telefoneemergencia2);

            //parametros tabela condo.veiculos
            commdinsert.Parameters.AddWithValue("@vagagaragem", vagagaragem);
            commdinsert.Parameters.AddWithValue("@veiculotipo", veiculotipo);
            commdinsert.Parameters.AddWithValue("@veiculotipo2", veiculotipo2);
            commdinsert.Parameters.AddWithValue("@veiculotipo3", veiculotipo3);
            commdinsert.Parameters.AddWithValue("@veiculomarca", veiculomarca);
            commdinsert.Parameters.AddWithValue("@veiculomarca", veiculomarca2);
            commdinsert.Parameters.AddWithValue("@veiculomarca", veiculomarca3);
            commdinsert.Parameters.AddWithValue("@veiculomodelo", veiculomodelo);
            commdinsert.Parameters.AddWithValue("@veiculomodelo", veiculomodelo2);
            commdinsert.Parameters.AddWithValue("@veiculomodelo", veiculomodelo3);
            commdinsert.Parameters.AddWithValue("@veiculoplaca", veiculoplaca);
            commdinsert.Parameters.AddWithValue("@veiculoplaca", veiculoplaca2);
            commdinsert.Parameters.AddWithValue("@veiculoplaca", veiculoplaca3);

            //conectar com o banco de dados
            try
            {
                commdinsert.Connection = conbd.Connectar();


                //executa o comando

                commdinsert.ExecuteNonQuery();

                conbd.desconect();

                //mostra a mensagem de sucesso

                this.mensagem = "Cadastro Realizado com Sucesso";

                   
            }
            catch (NpgsqlException error)
            {
                //mostra a mensagem de erro no caso de excessão

                this.mensagem = "Erro ao Realizar o cadastro, Verifique a conexão com o banco de dados" + error;
            }
        }



    }
}
