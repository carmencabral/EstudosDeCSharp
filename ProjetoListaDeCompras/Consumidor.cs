using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompras
{
    class Consumidor
    {
        private String _nome_consumidor; 
        private double _valor_compras; 

        //Construtor
        /*public Consumidor(String nome, double valor)
        {
            this._nome_consumidor = nome;
            this._valor_compras = valor;
        }*/
        //Propriedade
        public String Nome_Consumidor
        {
            get => _nome_consumidor;
            set => _nome_consumidor = value;
        }

        public double Valor_Compras
        {
            get => _valor_compras;
            set => _valor_compras = value;
        }
    }
}
