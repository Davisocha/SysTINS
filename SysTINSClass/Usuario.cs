using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SysTINSClass
{
    
    public class Usuario
    {
        public int Id;
        public string? Nome;
        public string? Email;
        public string? Senha; 
        public Nivel Nivel;
        public bool Ativo;

        public Usuario()  //contrutor vazio
        { 
        Nivel = new(); // se eu criar um usuario com o metodo nivel com seu construtor também vazio
        }

        public Usuario(string nome, string email, string senha, Nivel nivel)// contrustor que eu insiro e por padrão ele estará ativo
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(string nome, string email, string senha, Nivel nivel, bool ativo)// construtor que não contém Id, e se eu quiser adicionar um usuario inativo 
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(int id, string nome, string email, string senha, Nivel nivel, bool ativo)// construtor 
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        //metodo inserir usuario
        public void Inserir() { 
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.Add("spnome",MySql.Data.MySqlClient.MySqlDbType.VarChar).Value=Nome;// ele declara o nome do parametro da procedure,
                                                                                               // e declara o tipo e o valor que sp nome vai receber que é Usuario.Nome  
            cmd.Parameters.AddWithValue("spemail", Email); // ufa esse ja usa o nome do parametro da procedure e usa o parametro da classe
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            var dr = cmd.ExecuteReader();
            if (dr.Read())// se o usuario for adicionado ele pegara o parametro da classe e colocara na posição 0 da tabela de Usuario
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }
        //metodo ObterporId (consultar por Id)
        public static Usuario ObterPorId(int id) 
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandText =  $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            return usuario;
        }
        //obter lista de usuarios
        public List<Usuario> ObterLista()
        {
            List<Usuario> Lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   Nivel.ObterPorId(dr.GetInt32(4)),
                   dr.GetBoolean(5)
                   ));
            }
            return Lista;
        }
        //atualizar
        public bool Atualizar()
        { 
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            return cmd.ExecuteNonQuery() > 0 ? true : false ;

        }
        //efetuar login
        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where email = '{email}' and senha = md5('{senha}') and ativo = 1";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)),
                    dr.GetBoolean(5)
                    );
            }
            return usuario;
        }
    }


}
//        DELIMITER $$
//USE `systinsdb01`$$
//-- drop procedure `sp_usuario_altera`
//CREATE DEFINER =`root`@`localhost` PROCEDURE `sp_usuario_altera`(
//-- parâmetros da procedure
//spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
//begin
//    update usuarios
//    set nome = spnome, senha = md5(spsenha), nivel_id = spnivel where id = spid;
//end$$

//DELIMITER ;


