﻿namespace SysTINSClass
{
    public class Class1
    {
        private int id;
        public int Id { get; set; }// propriedade Id
        //XML Docs
        /// <summary>
        /// Calcular o valor das parcelas pela divisão do montante pelo número de parcelas respeitando as RNs 25 e 26.
        /// </summary>
        /// <param name="valor"> montante a ser parcelado </param>
        /// <param name="nparc">ó número de parcelas (de acordo a RN25)</param>
        /// <returns> o valor de cada parcela (de acordo com a RN26)</returns>
        public double Calcular(double valor, int nparc) { return valor / nparc; }// metodo da classe
    }
}