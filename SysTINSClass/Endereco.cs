using System;
using System.Collections.Generic;
using System.Linq;
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
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public DateTime Data_cad { get; set; }
        public bool Ativo { get; set; }
        public List<Endereco> Enderecos { get; set; }

        //cep char (8) 
        //logradouro varchar(100)
        //numero varchar(40)
        //complemento varchar(60)
        //bairro varchar(60)
        //cidade varchar(60)
        //uf char (2) 
        //tipo_endereco c
        public Endereco()
        {

        }

    }
}
