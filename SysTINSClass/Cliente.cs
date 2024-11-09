using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Cliente
    {
        public int    Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set;}
        public string? Telefone { get; set;}
        public string Email { get; set;}
        public DateTime? Data_nasc { get; set;}
        public DateTime Data_cad { get; set;}
        public bool Ativo { get; set;}
        public List<Enderecos> Enderecos{ get; set;}
       /// <summary>
       /// Construtor vazio
       /// </summary>
        public Cliente()
        {

        }
        /// <summary>
        /// Construtor para que contém o Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        /// <param name="data_nasc"></param>
        public Cliente(int id, string nome, string cpf, string? telefone, string email, DateTime? data_nasc)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;


        }
       /// <summary>
       /// Construtor que contém Id e o Ativo
       /// </summary>
       /// <param name="id"></param>
       /// <param name="nome"></param>
       /// <param name="cpf"></param>
       /// <param name="telefone"></param>
       /// <param name="email"></param>
       /// <param name="data_cad"></param>
       /// <param name="data_nasc"></param>
       /// <param name="ativo"></param>
        public Cliente(int id, string nome, string cpf, string? telefone, string email,DateTime data_cad, DateTime? data_nasc, bool ativo)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;

        }
        /// <summary>
        /// Construtor sem Id e sem Ativo
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        /// <param name="data_cad"></param>
        /// <param name="data_nasc"></param>
        public Cliente(string nome, string cpf, string? telefone, string email, DateTime data_cad, DateTime? data_nasc)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
        }
       /// <summary>
       /// metodo que Insere o Cliente com os parametro de nome, cpf, tel, email e data_nasc
       /// </summary>
        public void InserirCliente()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_insere_cliente";
            cmd.Parameters.AddWithValue("spnome",Nome );
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", MySql.Data.MySqlClient.MySqlDbType.Date).Value= Data_nasc;
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        /// <summary>
        /// Método para obter um cliente pelo o Id, onde faz uma busca pedindo o Id como parametro para a busca;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Cliente ObterClientePorID(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                   dr.GetString(4),
                    dr.GetDateTime(5)
                   );
            }
            return cliente;
        }
        /// <summary>
        /// método que faz uma lista dos clientes cadastrados ordenados pelo nome
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> ObterListaClientes()
        {
            List<Cliente> Lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new(
                  dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                   dr.GetString(4),
                    dr.GetDateTime(5)
                   )); 
            }
            return Lista;
        }
       /// <summary>
       /// método que atualiza os dados do cliente,que precisam dos paremetros do Id, Nome, Telefone e Data_nasc
       /// </summary>
       /// <returns></returns>
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone",Telefone);
            cmd.Parameters.AddWithValue("spdatanasc",Data_nasc);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        /// <summary>
        /// método que arquiva os clientes, com a propriedade de desativá-los com apenas como parametro o Id 
        /// </summary>
        public void ArquivarCliente()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"update clientes set ativo = 0 where id = {Id};";
            cmd.Parameters.AddWithValue("spid",Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

    }

    
}
