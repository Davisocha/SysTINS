﻿using Google.Protobuf.WellKnownTypes;
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
    public class Produto
    {
    

        public int Id { get ; set ; }
        public string Cod_barras { get ; set ; }
        public string? Descricao { get; set; }
        public double Valor_unit { get ; set; }
        public string? Unidade_venda { get; set ; }
        public Categoria Categoria { get; set ; }
        public double Estoque_minimo { get ; set; }
        public double? Classe_desconto { get ; set; }
        public DateTime Data_cad { get ; set ; }
        
        public Produto()
        {
            Categoria = new();
        }
 
        public Produto(int id,string cod_barras, string? descricao, double valor_unit, string? unidade_venda, Categoria categoria_id, double estoque_minimo, double? classe_desconto, DateTime data_cad)//fiz sem Id
        {
            Id = id;
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria = categoria_id;
            Estoque_minimo = estoque_minimo;
            Classe_desconto = classe_desconto;
            Data_cad = data_cad;
        }
        public Produto( string cod_barras, string? descricao, double valor_unit, string? unidade_venda, Categoria categoria_id, double estoque_minimo, double? classe_desconto)//fiz sem Id e sem data cad
        {
            
            Cod_barras = cod_barras;
            Descricao = descricao;
            Valor_unit = valor_unit;
            Unidade_venda = unidade_venda;
            Categoria = categoria_id;
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
                cmd.Parameters.AddWithValue("spcod_barras",Cod_barras);// ele declara o nome do parametro da procedure,
                cmd.Parameters.AddWithValue("spdescricao", Descricao);
                cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
                cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
                cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
                cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
                cmd.Parameters.AddWithValue("spclasse_desconto", Classe_desconto);
                Id =Convert.ToInt32( cmd.ExecuteScalar());// ele recebe o Id e Retorna um numero inteiro ou o obj Id que é o nosso caso
                cmd.Connection.Close();  

            }
        //metodo ObterPorId (consultar por Id)
        public static Produto ObterPorId(int id)
        {
            Produto produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id ={id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produtos = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetDouble(3),
                   dr.GetString(4),
                   Categoria.ObterPorID(dr.GetInt32(5)),
                   dr.GetDouble(6),
                   dr.GetDouble(7),
                   dr.GetDateTime(9)
                   );
            }
            cmd.Connection.Close();
            return produtos;
        }
        public static Produto ObterPorCodBar(string codbar)
        {
            Produto produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produtos where id ={codbar}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                produtos = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetDouble(3),
                   dr.GetString(4),
                   Categoria.ObterPorID(dr.GetInt32(5)),
                   dr.GetDouble(6),
                   dr.GetDouble(7),
                   dr.GetDateTime(9)
                   );
            }
            cmd.Connection.Close();
            return produtos;
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
            cmd.CommandText = $"select * from produtos order by descricao asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetDouble(3),
                   dr.GetString(4),
                   Categoria.ObterPorID(dr.GetInt32(5)),
                   dr.GetDouble(6),
                   dr.GetDouble(7),
                   dr.GetDateTime(9)
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
            cmd.CommandText = $"sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras",Cod_barras);
            cmd.Parameters.AddWithValue("spdescricao",Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", Valor_unit);
            cmd.Parameters.AddWithValue("spunidade_venda", Unidade_venda);
            cmd.Parameters.AddWithValue("spcategoria_id", Categoria);
            cmd.Parameters.AddWithValue("spestoque_minimo", Estoque_minimo);
            cmd.Parameters.AddWithValue("spclasse_desconto",Classe_desconto);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        public void ExcluirProduto()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"delete * produtos from where id = {Id}";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


    }
}
