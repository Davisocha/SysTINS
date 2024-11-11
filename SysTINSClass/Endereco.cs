using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SysTINSClass
{
    public class Endereco
    {
        public int Id { get; set; }
        public Cliente Cliente_Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Tipo_endereco { get; set; }

        public Endereco()
        {
          Cliente_Id = new();
        }
        public Endereco(int id, Cliente cliente_id, string cep,string logradouro, string numero, string complemento, string bairro, string cidade, string uf,string tipo_endereco)
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

        public Endereco( Cliente cliente_id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string uf, string tipo_endereco)
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
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_Id);// ele declara o nome do parametro da procedure,
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_endereco);
            Id = Convert.ToInt32(cmd.ExecuteScalar());// ele recebe o Id e Retorna um numero inteiro ou o obj Id que é o nosso caso
            cmd.Connection.Close();
        }
        public static List<Endereco> ObterEnderecoPorCliente(int id)
        {
            List<Endereco> Lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where cliente_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lista.Add(new(
                  Cliente.ObterClientePorID(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                   ));
            }
            cmd.Connection.Close();
            return Lista;
        }
        public bool AtualizarEnderecos()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_endereco_update";
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
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"delete * from enderecos where id ={Id}";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }



    }
}
