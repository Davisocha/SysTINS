using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SysTINSClass
{
    public class Enderecos
    {
        public int Id { get; set; }
        public Cliente Cliente_Id { get; set; }
        public string Cep { get; set; }
        public string? Logradouro { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Tipo_endereco { get; set; }

        public Enderecos()
        {
            Cliente_Id = new();
        }
        public Enderecos(int id, Cliente cliente_id, string cep,string? logradouro, string numero, string? complemento, string bairro, string cidade, string uf, string tipo_endereco) 
        {
            Id = id;
            Cliente_Id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_endereco = tipo_endereco;

        }
        public Enderecos(Cliente cliente_id, string cep, string? logradouro, string numero, string? complemento, string bairro, string cidade, string uf, string tipo_endereco)//Construtor sem Id.
        {
            Cliente_Id = cliente_id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_endereco = tipo_endereco;
        }

        public void InserirEndereco()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }
        public static Enderecos ObterEnderecoPorCliente(int id)
        {
            Enderecos enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                enderecos = new(
                    
                    Cliente.ObterClientePorID(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                    );
            }
            return enderecos;
        }
        public static List<Enderecos> ListaEnderecosPorCliente()
        {
            List<Enderecos> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos order by cliente_id asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new(
                   dr.GetInt32(0),
                   Cliente.ObterClientePorID(dr.GetInt32(1)),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4),
                   dr.GetString(5),
                   dr.GetString(6),
                   dr.GetString(7),
                   dr.GetString(8),
                   dr.GetString(9)
                   ));
            }
            return enderecos;
        }
        public bool AtualizarEndereco()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        public void ExcluirEndereco()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete * from enderecos where id ={Id}";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }




    }
}
