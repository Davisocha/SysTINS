using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;

namespace SysTINSClass
{
    public class Nivel
    {
        public int Id {  get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        // ? pode receber valores nulos
        // metodo construtor, a gnt chama (new) nos chamamos um metodo vazio
        //metodos contrutores
        public Nivel() { 
            
        }
        public Nivel(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        // metodo de inserir
        public void Inserir() {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;//ele especifica o comando de uma string
            cmd.CommandText = $"insert niveis (nome, sigla) values ('{Nome}','{Sigla}')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();//fechar a conexão
        }
        // metodo de consultar por Id
        public static Nivel ObterPorId(int id)// se ele esta static ele é chamado pela propria classe ele não precisa de uma estancia
                                             // se ele esta estatico ent é só usar nivel.ObterPorID se ele não tiver tem que usar um obj do tipo nivel
                                             // Nivel n = new(); // n.ObterPorId ai da pra usar
        {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())// read retorna verdadeiro ou falso
            {
              //nivel.Id = dr.GetInt32(0);
              // nivel.Nome = dr.GetString(1);
              //nivel.Sigla = dr.GetString(2);
              // duas formas de fazer essa forma de metodos 
              nivel = new(dr.GetInt32(0)/*ele ta buscando um int*/, dr.GetString(1)/*ele esta buscando um texto*/, dr.GetString(2));//usando o metodo contrutor declarado em cima 
            } 
            
            cmd.Connection.Close();
            return nivel;
        }
        //Obter Lista
        public static List<Nivel> ObterLista() // ele vai usar só objs da classe Nivel
        {
            List<Nivel> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from niveis order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) //se der verdadeiro irá passar por esta repetição
            {
                lista.Add(new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2))); //ele adiciona somente niveis no final da lista

            }
            cmd.Connection.Close ();
            return lista;
        }
        //Atualizar (alterar)
        public bool Atualizar()
        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update niveis set nome = '{Nome}', sigla'{Sigla}' where id = {Id}";
            cmd.ExecuteNonQuery();// ele serve para executar o codigos dos metodos do command
            resposta = cmd.ExecuteNonQuery() >0? true:false; //ele retorna o numero das rows afetadas pelo banco de dados e podemos usar esses resultados para manipular da forma que quisermos
            cmd.Connection.Close();
            return resposta;
        }
        //Deletar Nível
        public void Deletar(int id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType= System.Data.CommandType.Text;
            cmd.CommandText = $"delete from niveis where id ={id}";
            cmd.ExecuteNonQuery();
        }
    }
}
