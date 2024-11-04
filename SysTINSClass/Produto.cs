using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SysTINSClass
{
    /// <summary>
    /// A Classe Produto é composta pelos 4 metodos de Inserir, atualizar, ObterPorId e Lista de Produtos.
    /// </summary>
    internal class Produto
    {
    

        public int Id { get ; set ; }
        public int Cod_barras { get ; set ; }
        public string? Descricao { get; set; }
        public int Valor_unit { get ; set; }
        public string Unidade_venda { get; set ; }
        public Categoria Categoria_id { get; set ; }
        public int Estoque_minimo { get ; set; }
        public int? Classe_desconto { get ; set; }
        public int? Imagem { get ;set; }
        public Timestamp Data_cad { get ; set ; }
        
        public Produto()
        {
          
        }
 
        public Produto(int cod_barras, string? descricao, int valor_unit, string unidade_venda, Categoria categoria_id, int estoque_minimo, int? classe_desconto)//fiz sem Id e sem data_cad
        {
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria_id = categoria_id;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
        }
        //metodo inserir Produto
       /// <summary>
       /// Inserir Produto é um metodo que cadastra um produto, ao banco de Dados com sua categoria inserida
       /// </summary>
        public void InserirProduto()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cod_barras;// ele declara o nome do parametro da procedure,
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.ObterPorID);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();  

        }
        //metodo ObterPorId (consultar por Id)
        public static Produto ObterPorId(int id)
        {
            Produto categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from categorias where {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetInt32(2),
                    dr.GetString(3),
                    Categoria.ObterPorID(dr.GetInt32(4)),
                    (dr.GetInt32(5)),
                    dr.GetInt32(6));
            }
            cmd.Connection.Close();
            return categoria;
        }
        //obter lista de Produtos
        /// <summary>
        /// Este metodo é feito para obter a lista dos produtos cadastrados no sistema ordenado pelo id
        /// </summary>
        /// <returns></returns>
        public static List<Produto> ObterLista()
        {
            List<Produto> Lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos order by id asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetInt32(2),
                   dr.GetString(3),
                   Categoria.ObterPorID(dr.GetInt32(4)),
                   dr.GetInt32(5),
                   dr.GetInt32(6)
                   ));
            }
            return Lista;
        }
        /// <summary>
        /// Este metodo Atualiza os produtos do Sistema 
        /// </summary>
        /// <returns></returns>
        public bool AtualizarProdutos()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Cod_barras;
            cmd.Parameters.AddWithValue("spdescricao", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.Add("spunidade_venda", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value= Unidade_venda;
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria.ObterPorID);
            cmd.Parameters.AddWithValue("spestoque_minimo", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Estoque_minimo;
            cmd.Parameters.AddWithValue("spclasse_desconto", MySql.Data.MySqlClient.MySqlDbType.Decimal).Value = Classe_desconto;
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }




    }
}
