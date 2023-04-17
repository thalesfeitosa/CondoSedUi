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

        public string Text1 { get; }
        public string Text2 { get; }
        public string Text3 { get; }
        public string Text4 { get; }
        public bool Checked1 { get; }
        public bool Checked2 { get; }
        public string Text5 { get; }
        public string Text6 { get; }
        public string Text7 { get; }
        public string Text8 { get; }
        public string Text9 { get; }
        public string Text10 { get; }
        public string Text11 { get; }
        public bool Checked3 { get; }
        public string Text12 { get; }
        public string Text13 { get; }
        public string Text14 { get; }
        public string Text15 { get; }
        public string Text16 { get; }
        public string Text17 { get; }
        public string Text18 { get; }
        public string Text19 { get; }
        public string Text20 { get; }
        public string Text21 { get; }
        public string Text22 { get; }
        public string Text23 { get; }
        public bool Checked4 { get; }
        public bool Checked5 { get; }
        public bool Checked6 { get; }
        public bool Checked7 { get; }
        public string Text24 { get; }
        public string Text25 { get; }
        public string Text26 { get; }
        public string Text27 { get; }
        public string Text28 { get; }
        public string Text29 { get; }
        public string Text30 { get; }

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
                "@nmmoradores3, @parentesco, @parentesco2,@parentesco3, @datanascimento,@datanascimento2,@datanascimento3," +
                " @animais, @animalespeciegato, @animalespeciecachorro, @animalespecieoutros, @emergencianome, @emergencianome2, @telefoneemergencia" +
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
            commdinsert.Parameters.AddWithValue("@parentesco", parentesco);
            commdinsert.Parameters.AddWithValue("@parentesco2", parentesco2);
            commdinsert.Parameters.AddWithValue("@parentesco3", parentesco3);
            commdinsert.Parameters.AddWithValue("@datanascimento", datanascimento);
            commdinsert.Parameters.AddWithValue("@datanascimento2", datanascimento2);
            commdinsert.Parameters.AddWithValue("@datanascimento3", datanascimento3);
            commdinsert.Parameters.AddWithValue("@animais", animais);
            commdinsert.Parameters.AddWithValue("@animalespeciegato", animalespeciegato);
            commdinsert.Parameters.AddWithValue("@animalespeciecachorro", animalespeciecachorro);
            commdinsert.Parameters.AddWithValue("@animalespecieoutros", animalespecieoutros);
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

        public CadCondominioClass(string text1, string text2, string text3, string text4, bool checked1, bool checked2, string text5, string text6, string text7, string text8, string text9, string text10, string text11, bool checked3, string text12, string text13, string text14, string text15, string text16, string text17, string text18, string text19, string text20, string text21, string text22, string text23, bool checked4, bool checked5, bool checked6, bool checked7, string text24, string text25, string text26, string text27, string text28, string text29, string text30)
        {
            Text1 = text1;
            Text2 = text2;
            Text3 = text3;
            Text4 = text4;
            Checked1 = checked1;
            Checked2 = checked2;
            Text5 = text5;
            Text6 = text6;
            Text7 = text7;
            Text8 = text8;
            Text9 = text9;
            Text10 = text10;
            Text11 = text11;
            Checked3 = checked3;
            Text12 = text12;
            Text13 = text13;
            Text14 = text14;
            Text15 = text15;
            Text16 = text16;
            Text17 = text17;
            Text18 = text18;
            Text19 = text19;
            Text20 = text20;
            Text21 = text21;
            Text22 = text22;
            Text23 = text23;
            Checked4 = checked4;
            Checked5 = checked5;
            Checked6 = checked6;
            Checked7 = checked7;
            Text24 = text24;
            Text25 = text25;
            Text26 = text26;
            Text27 = text27;
            Text28 = text28;
            Text29 = text29;
            Text30 = text30;
        }
    }
}
