using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    //Banco é a nossa classe de conexão
    public static class Banco //static pois não precisaremos criar uma instancia de Banco para conectar às nossas bases de dados 
    {                          // se a classe é static seus metodos também tem que ser
        public static MySqlCommand Abrir() // meteodo para abrir conexão // banco abrir entrega mysql command com uma conexão a um servidor no ar 
        //dentro da classe de metodos ela representa na interface do mysql, mas a partir dos códigos 
         {
            string strcon = @"server=127.0.0.1;database=systinsdb01;user=root;password="; // conteudo do tipo expressão,string de conexão, e faço a conexão do server
            MySqlConnection cn = new(strcon);// o obj cn vai ter o dados de conexão // ele abre com a string de conexão// ele funcina usando os dados da string de conexão
            MySqlCommand cmd = new();
            try// se colocar tab duplo ele monta isso// é tratamento de fluxo de irregularidades// ele serve pra não dar tela azul no sistema
            {
                cn.Open();// ele abre a conexão e se caso der erro ele vai pegar o cath e rodar // 
                cmd.Connection = cn;// ele espera um obj de mysql conection// que é o obj cn
            }
            catch (Exception ex)// caso de erro traz pra si, apresente o erro
            {
                Console.WriteLine(ex.Message);// ele traz uma mensagem de erro, ele mostra o erro numa telinha preta  
                throw;
            }
            return cmd;
        }                                   
    }
}
