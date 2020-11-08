using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCompras
{
    class CarrinhoCompras
    {
        private List<Consumidor> _carrinho_compras = new List<Consumidor>();

        //Propriedade
        public List<Consumidor> Carrinho_Compras
        {
            get => _carrinho_compras;
            set => _carrinho_compras = value;
        }

        //Método
        public int total_consumidores()
        {
            int cont = 0;
            foreach (Consumidor c in _carrinho_compras)
            {
                cont++;
            }
            return cont;
        }

        public void incluir_consumidor(Consumidor cons)
        {
            //List<Consumidor> lista = _carrinho_compras;
            //_carrinho_compras.Insert(i,cons);
            _carrinho_compras.Add(cons);
        }

        public double total_relatorio(double valor)
        {
            double total = 0;

            foreach (Consumidor c in _carrinho_compras)
            {
                total += c.Valor_Compras;
            }
            return total;
        }

        public string consultar_consumidor(string nome, double valor)
        {
            string nome_resultado = nome;
            double valor_resultado = valor;
            foreach (Consumidor c in _carrinho_compras)
            {
                c.Nome_Consumidor = nome;
                c.Valor_Compras = valor;
                nome_resultado = nome;
                valor_resultado = valor;
            }
            
            return nome_resultado + " gastou " + valor_resultado + " EUR\n";
        }
               

        

    }
}
