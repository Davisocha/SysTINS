using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class ItemPedido
    {


        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Produto? Produto { get; set; }
        public double Valor_unit { get; set; }
        public double Quantidade { get; set; }
        public double? Desconto { get; set; }

        public ItemPedido()
        {
            Produto = new();

        }

        public ItemPedido(int id, int pedidoId, Produto? produto,double valor_unit, double quantidade, double? desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            Valor_unit = valor_unit;
            Quantidade = quantidade;
            Desconto = desconto;

        }

        public ItemPedido(int pedidoId, Produto? produto, double quantidade, double? desconto)
        {
            PedidoId = pedidoId;
            Produto = produto;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id",PedidoId);
            cmd.Parameters.AddWithValue("spproduto_id",Produto.Id );//existir um produto,pedido e cliente
            cmd.Parameters.AddWithValue("spquantidade",Quantidade);
            cmd.Parameters.AddWithValue("spdesconto",Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<ItemPedido> ObterItemPorPedidoID(int id)
        {
            List<ItemPedido> itemPedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from itempedido where pedido_id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itemPedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5)

                    ));
            }
            return itemPedidos;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_itempedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Remover()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = $"sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.ExecuteNonQuery();
        }

  
    }
}
