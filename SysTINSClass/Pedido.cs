using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public List<ItemPedido>? Items { get; set; }

        public Pedido()
        {
            Cliente = new();
            Usuario = new();
        }

        public Pedido(Usuario usuario, Cliente cliente)
        {

            Usuario = usuario;
            Cliente = cliente;
        }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            desconto = desconto;
        }
        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> items)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Items = items;
        }

        public void InserirPedido()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void AtualizarPedido()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_pedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spstatus", Status);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where id ={id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pedido = new(
                   dr.GetInt32(0),
                   Usuario.ObterPorId(dr.GetInt32(1)),
                   Cliente.ObterClientePorID(dr.GetInt32(2)),
                   dr.GetDateTime(3),
                   dr.GetString(4),
                   dr.GetDouble(5),
                   ItemPedido.ObterItemPorPedidoID(dr.GetInt32(0))//ele aparece na pposição zero porque ele pega dali o Id necessario para a lista de itemsPedido
                   );
            }
            cmd.Connection.Close();
            return pedido;
        }
        public static List<Pedido> ObterLista()
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 pedidos.Add(new(
                   dr.GetInt32(0),
                   Usuario.ObterPorId(dr.GetInt32(1)),
                   Cliente.ObterClientePorID(dr.GetInt32(2)),
                   dr.GetDateTime(3),
                   dr.GetString(4),
                   dr.GetDouble(5),
                   ItemPedido.ObterItemPorPedidoID(dr.GetInt32(0))
                   ));
            }
            return pedidos;
        }
    }
}


