using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    /// <summary>
    /// Classe Categoria, com metodos de Inserir, Atualizar, Listar e Consultar
    /// </summary>
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria()//construtor Vazio
        {

        }
        /// <summary>
        /// Contrutor Completo para Categoria.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="sigla"></param>
        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        /// <summary>
        /// Contrutor Com Nome e Sigla.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sigla"></param>
        public Categoria( string? nome, string? sigla)
        {
            
            Nome = nome;
            Sigla = sigla;
        }

        /// <summary>
        /// este metodo irá inserir uma categoria no sistema pedindo os dados como Nome e Sigla, com estrutura com if para confirmação de cadastro de Categoria
        /// </summary>
        public void InserirCategoria()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);//inseri um parametro
            cmd.Parameters.AddWithValue("spsigla", Sigla);//fiquei em duvida e coloquei um Value, sem saber se teria problema
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }
        /// <summary>
        /// Metodo feito para achar uma categoria, sendo o Id como Indice(parametro) para a buca da categoria
        /// </summary>
        public static Categoria ObterPorID(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            return categoria;
        }
        /// <summary>
        /// Metodo feito para listar categorias, ordenadas pelo nome
        /// </summary>
        public static List<Categoria> ListaCategorias()
        {
            List<Categoria> Lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2)
               ));
            }
            return Lista;
        }
        /// <summary>
        /// Metodo feito para atualizar uma categoria, sendo o Id, Nome e Sigla como parametros para a atualização
        /// </summary>
        public bool AtualizarCategorias()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
            
        }
        /// <summary>
        /// Metodo feito para excluir uma categoria, sendo o Id como unico parametro para exclusão
        /// </summary>
        public void ExcluirCatergoria()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_categoria_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }





    }
}
