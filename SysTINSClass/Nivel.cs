﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Nivel
    {
        public int Id {  get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        // ? pode receber valores nulos
        // metodo construtor, a gnt chama (new) nos chamamos um metodo vazio
        public Nivel() { 
            
        }
        public Nivel(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        //
    }
}
