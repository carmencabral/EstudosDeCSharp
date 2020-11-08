using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoCompras
{
    public partial class FormCompras : Form
    {
        CarrinhoCompras cc = new CarrinhoCompras();
        Consumidor c = new Consumidor();

        public FormCompras()
        {
            InitializeComponent();

        }

        private void lista_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txt_total_pagar.Text = "0,00";
            txt_preco.Text = "0,00";
            rdb_nao.Checked = true;
            chk_todos.Checked = true;
            dg_lista_produtos.Rows.Add("café", "2,00");
            dg_lista_produtos.Rows.Add("açúcar", "0,80");
            dg_lista_produtos.Rows.Add("leite", "1,20");
            dg_lista_produtos.Rows.Add("óleo", "1,70");
            dg_lista_produtos.Rows.Add("sal", "1,10");
            dg_lista_produtos.Rows.Add("feijão", "1,30");
            dg_lista_produtos.Rows.Add("arroz", "1,20");
            dg_lista_produtos.Rows.Add("macarrão", "1,10");
            dg_lista_produtos.Rows.Add("farinha de trigo", "0,40");
        }

        private void btn_prod_compra_Click(object sender, EventArgs e)
        {
            //COPIAR DA LISTA DE PRODUTOS PARA LISTA DE COMPRAS
            int n_selecionados = dg_lista_produtos.SelectedRows.Count;
            int pos = n_selecionados - 1;
            for (int i = 0; i < n_selecionados; i++)
            {
                    //produto
                    String item_adicionar = dg_lista_produtos.SelectedRows[pos].Cells[0].Value.ToString();
                    //preço
                    String preco_adicionar = dg_lista_produtos.SelectedRows[pos].Cells[1].Value.ToString();
                    //Inclusão do produto na lista de compras
                    dg_lista_compras.Rows.Add(item_adicionar, preco_adicionar, 1);
                    pos--;
            }
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            FormCompras menuadminform = new FormCompras();
            menuadminform.Show();
            this.Close();
        }

        private void btn_compra_prod_Click(object sender, EventArgs e)
        {
        }

        private void btn_exluir_lista_compras_Click(object sender, EventArgs e)
        {
            //EXCLUIR ITENS SELECIONADOS DA LISTA DE COMPRAS
           
            DataGridViewRow linha;
            int n_selecionados = dg_lista_compras.SelectedRows.Count;
            for (int i = n_selecionados - 1; i >= 0; i--)
            {
                linha = dg_lista_compras.SelectedRows[i];
                dg_lista_compras.Rows.Remove(linha);
            }

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            double total_todos = 0.00;
            double total_selecionados = 0.00;
            int n_selecionados = dg_lista_compras.SelectedRows.Count;
            int n_itens = dg_lista_compras.Rows.Count;
            double total_pagar_com_desconto_todos = 0.00;
            //CALCULAR VALOR DAS COMPRAS PARA TODOS OS ITENS

            if (chk_todos.Checked)
            {
                for (int i = 0; i < n_itens; i++)
                {
                    int qtd = Convert.ToInt16(dg_lista_compras.Rows[i].Cells[2].Value);
                    double preco = Convert.ToDouble(dg_lista_compras.Rows[i].Cells[1].Value); ;
                    total_todos += qtd * preco;
                }
                if (rdb_nao.Checked)
                {
                    txt_total_pagar.Text = Convert.ToString(total_todos);
                }
            }

            //CALCULAR VALOR DAS COMPRAS PARA OS ITENS SELECIONADOS
            if (chk_selecionados.Checked)
            {
                for (int i = 0; i < n_selecionados; i++)
                {
                    int qtd = Convert.ToInt16(dg_lista_compras.SelectedRows[i].Cells[2].Value);
                    double preco = Convert.ToDouble(dg_lista_compras.SelectedRows[i].Cells[1].Value); ;
                    total_selecionados += qtd * preco;
                }
                if (rdb_nao.Checked)
                    txt_total_pagar.Text = Convert.ToString(total_selecionados);
            }

            //CALCULAR VALOR DAS COMPRAS PARA TODOS OS ITENS
            if (chk_selecionados.Checked && chk_todos.Checked)
            {
                if (rdb_nao.Checked)
                    txt_total_pagar.Text = Convert.ToString(total_todos);
            }

            //CALCULAR COM DESCONTO, CONFORME txt_desconto
            if (rdb_sim.Checked)
            {
                if (chk_selecionados.Checked)
                {
                    double desconto_decimal = (Convert.ToDouble(txt_desconto.Text)) / 100;
                    double desconto_valor_selecionados = total_selecionados * desconto_decimal;
                    double total_pagar_com_desconto_selec = total_selecionados - desconto_valor_selecionados;
                    txt_total_pagar.Text = Convert.ToString(total_pagar_com_desconto_selec);
                }
                if (chk_todos.Checked)
                {
                    double desconto_decimal = (Convert.ToDouble(txt_desconto.Text)) / 100;
                    double desconto_valor_todos = total_todos * desconto_decimal;
                    total_pagar_com_desconto_todos = total_todos - desconto_valor_todos;
                    txt_total_pagar.Text = Convert.ToString(total_pagar_com_desconto_todos);
                }
                if (chk_selecionados.Checked && chk_todos.Checked)
                    txt_total_pagar.Text = Convert.ToString(total_pagar_com_desconto_todos);
            }
            
        }
        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_todos.Checked)
            {
                chk_selecionados.Enabled = false;
            }
            else
            {
                chk_selecionados.Enabled = true;
            }
        }

        private void rdb_nao_CheckedChanged(object sender, EventArgs e)
        {
            txt_desconto.Text = "";
        }

        private void menuIncluirProduto_Click(object sender, EventArgs e)
        {
            //INCLUIR PRODUTO: nome e preço, se não houver na lista
            String produto_incluir = txt_produto.Text.ToLower();
            double preco_incluir = Convert.ToDouble(txt_preco.Text);
            int n_produtos = dg_lista_produtos.Rows.Count-1;
            bool localizado = false;
            int pos = 0;

            dg_lista_produtos.ClearSelection();

            for (int i = 0; i < n_produtos; i++)
            {
                DataGridViewRow linha = dg_lista_produtos.Rows[i];
                linha.DefaultCellStyle.BackColor = Color.Empty;
                if (produto_incluir == dg_lista_produtos.Rows[i].Cells[0].Value.ToString())
                {
                    localizado = true;
                    pos = i;
                    linha.DefaultCellStyle.BackColor = Color.Yellow;
                    
                }
                else localizado = false;

            }

            if (!localizado && txt_preco.Text!="0")
                dg_lista_produtos.Rows.Add(produto_incluir.ToLower(), Math.Round(preco_incluir, 2));
            
        }

        private void menuLocalizarProduto_Click(object sender, EventArgs e)
        {
            String produto_localizar = txt_produto.Text.ToLower();
            double preco_localizar = Convert.ToDouble(txt_preco.Text);
            int n_produtos = dg_lista_produtos.Rows.Count - 1;
            int pos = -1;
            dg_lista_produtos.ClearSelection();

            for (int i = 0; i < n_produtos; i++)
            {
                DataGridViewRow linha = dg_lista_produtos.Rows[i];
                linha.DefaultCellStyle.BackColor = Color.Empty;
                if (produto_localizar == dg_lista_produtos.Rows[i].Cells[0].Value.ToString())
                {
                    linha.DefaultCellStyle.BackColor = Color.Yellow;
                    pos = i;
                }
            }
            if (pos == -1)
                MessageBox.Show($"{produto_localizar} - não localizado!", "Informação");
            
        }

        private void btn_incluir_consumidor_Click(object sender, EventArgs e)
        {
            Consumidor c = new Consumidor();

            c.Nome_Consumidor = txt_consumidor.Text;
            c.Valor_Compras = Convert.ToDouble(txt_total_pagar.Text);
            cc.incluir_consumidor(c);

           MessageBox.Show($"Consumidor/a *** {c.Nome_Consumidor} *** incluído/a com sucesso!", "INFORMAÇÃO");
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            int n_consumidores = cc.total_consumidores();

            int i = 0;
            foreach(Consumidor cons in cc.Carrinho_Compras)
            {
                if (i == 0)
                {
                    dg_relatorio.Rows.Add(cons.Nome_Consumidor, cons.Valor_Compras);
                }

                if (i > 0)
                {
                    dg_relatorio.Rows.RemoveAt(i);
                    dg_relatorio.Rows.Insert(i, cons.Nome_Consumidor, cons.Valor_Compras);
                }
                i++;
            }

            //CALCULA TOTAL DAS COMPRAS DOS CONSUMIDORES
            double total = cc.total_relatorio(c.Valor_Compras);
            txt_total.Text = Convert.ToString(total);
        }

        private void btn_nova_compra_Click(object sender, EventArgs e)
        {
            txt_consumidor.Text = "";
            dg_lista_compras.Rows.Clear();
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuProduto_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_consultar_todos_consumidores_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_apagar_relatorio_Click(object sender, EventArgs e)
        {
            
        }
    }
}
