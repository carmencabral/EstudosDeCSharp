namespace ProjetoCompras
{
    partial class FormCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.btn_prod_compra = new System.Windows.Forms.Button();
            this.painelProdutos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_lista_produtos = new System.Windows.Forms.DataGridView();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.painelCompras = new System.Windows.Forms.Panel();
            this.dg_lista_compras = new System.Windows.Forms.DataGridView();
            this.item_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.painelBotoes = new System.Windows.Forms.Panel();
            this.btn_nova_compra = new System.Windows.Forms.Button();
            this.btn_exluir_lista_compras = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.painelValor = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.chk_selecionados = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.txt_total_pagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_nao = new System.Windows.Forms.RadioButton();
            this.rdb_sim = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.painelMenu = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuProduto = new System.Windows.Forms.MenuStrip();
            this.menuLocalizarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncluirProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_relatorio = new System.Windows.Forms.Button();
            this.btn_incluir_consumidor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_consumidor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dg_relatorio = new System.Windows.Forms.DataGridView();
            this.consumidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_produtos)).BeginInit();
            this.painelCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_compras)).BeginInit();
            this.painelBotoes.SuspendLayout();
            this.painelValor.SuspendLayout();
            this.painelMenu.SuspendLayout();
            this.menuProduto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prod_compra
            // 
            this.btn_prod_compra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_prod_compra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_compra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_prod_compra.Location = new System.Drawing.Point(8, 6);
            this.btn_prod_compra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_prod_compra.Name = "btn_prod_compra";
            this.btn_prod_compra.Size = new System.Drawing.Size(197, 50);
            this.btn_prod_compra.TabIndex = 2;
            this.btn_prod_compra.Text = "INCLUIR PRODUTO NAS COMPRAS";
            this.btn_prod_compra.UseVisualStyleBackColor = false;
            this.btn_prod_compra.Click += new System.EventHandler(this.btn_prod_compra_Click);
            // 
            // painelProdutos
            // 
            this.painelProdutos.Controls.Add(this.panel1);
            this.painelProdutos.Controls.Add(this.dg_lista_produtos);
            this.painelProdutos.Controls.Add(this.label2);
            this.painelProdutos.Location = new System.Drawing.Point(13, 142);
            this.painelProdutos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.painelProdutos.Name = "painelProdutos";
            this.painelProdutos.Size = new System.Drawing.Size(213, 234);
            this.painelProdutos.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(250, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 100);
            this.panel1.TabIndex = 2;
            // 
            // dg_lista_produtos
            // 
            this.dg_lista_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produto,
            this.preco_produto});
            this.dg_lista_produtos.Location = new System.Drawing.Point(11, 27);
            this.dg_lista_produtos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_lista_produtos.Name = "dg_lista_produtos";
            this.dg_lista_produtos.Size = new System.Drawing.Size(195, 197);
            this.dg_lista_produtos.TabIndex = 0;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.Width = 70;
            // 
            // preco_produto
            // 
            this.preco_produto.HeaderText = "Preço";
            this.preco_produto.Name = "preco_produto";
            this.preco_produto.Width = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTA DE PRODUTOS";
            // 
            // painelCompras
            // 
            this.painelCompras.Controls.Add(this.dg_lista_compras);
            this.painelCompras.Controls.Add(this.label3);
            this.painelCompras.Location = new System.Drawing.Point(400, 142);
            this.painelCompras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.painelCompras.Name = "painelCompras";
            this.painelCompras.Size = new System.Drawing.Size(258, 234);
            this.painelCompras.TabIndex = 4;
            // 
            // dg_lista_compras
            // 
            this.dg_lista_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista_compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_compra,
            this.preco_compra,
            this.quantidade_compra});
            this.dg_lista_compras.Location = new System.Drawing.Point(9, 27);
            this.dg_lista_compras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dg_lista_compras.Name = "dg_lista_compras";
            this.dg_lista_compras.Size = new System.Drawing.Size(244, 197);
            this.dg_lista_compras.TabIndex = 0;
            // 
            // item_compra
            // 
            this.item_compra.HeaderText = "Item";
            this.item_compra.Name = "item_compra";
            this.item_compra.ReadOnly = true;
            this.item_compra.Width = 70;
            // 
            // preco_compra
            // 
            this.preco_compra.HeaderText = "Preço";
            this.preco_compra.Name = "preco_compra";
            this.preco_compra.ReadOnly = true;
            this.preco_compra.Width = 50;
            // 
            // quantidade_compra
            // 
            this.quantidade_compra.HeaderText = "Quantidade";
            this.quantidade_compra.Name = "quantidade_compra";
            this.quantidade_compra.Width = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "LISTA DE COMPRAS";
            // 
            // painelBotoes
            // 
            this.painelBotoes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.painelBotoes.Controls.Add(this.btn_nova_compra);
            this.painelBotoes.Controls.Add(this.btn_exluir_lista_compras);
            this.painelBotoes.Controls.Add(this.btn_prod_compra);
            this.painelBotoes.Location = new System.Drawing.Point(14, 76);
            this.painelBotoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.painelBotoes.Name = "painelBotoes";
            this.painelBotoes.Size = new System.Drawing.Size(644, 60);
            this.painelBotoes.TabIndex = 6;
            // 
            // btn_nova_compra
            // 
            this.btn_nova_compra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_nova_compra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nova_compra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nova_compra.Location = new System.Drawing.Point(227, 6);
            this.btn_nova_compra.Name = "btn_nova_compra";
            this.btn_nova_compra.Size = new System.Drawing.Size(142, 50);
            this.btn_nova_compra.TabIndex = 5;
            this.btn_nova_compra.Text = "NOVA COMPRA";
            this.btn_nova_compra.UseVisualStyleBackColor = false;
            this.btn_nova_compra.Click += new System.EventHandler(this.btn_nova_compra_Click);
            // 
            // btn_exluir_lista_compras
            // 
            this.btn_exluir_lista_compras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_exluir_lista_compras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exluir_lista_compras.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_exluir_lista_compras.Location = new System.Drawing.Point(395, 6);
            this.btn_exluir_lista_compras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_exluir_lista_compras.Name = "btn_exluir_lista_compras";
            this.btn_exluir_lista_compras.Size = new System.Drawing.Size(244, 50);
            this.btn_exluir_lista_compras.TabIndex = 3;
            this.btn_exluir_lista_compras.Text = "EXCLUIR DAS COMPRAS";
            this.btn_exluir_lista_compras.UseVisualStyleBackColor = false;
            this.btn_exluir_lista_compras.Click += new System.EventHandler(this.btn_exluir_lista_compras_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_calcular.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_calcular.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_calcular.Location = new System.Drawing.Point(244, 7);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(186, 48);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "CALCULAR COMPRAS";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // painelValor
            // 
            this.painelValor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.painelValor.Controls.Add(this.label10);
            this.painelValor.Controls.Add(this.chk_todos);
            this.painelValor.Controls.Add(this.chk_selecionados);
            this.painelValor.Controls.Add(this.label7);
            this.painelValor.Controls.Add(this.txt_desconto);
            this.painelValor.Controls.Add(this.btn_calcular);
            this.painelValor.Controls.Add(this.txt_total_pagar);
            this.painelValor.Controls.Add(this.label1);
            this.painelValor.Controls.Add(this.rdb_nao);
            this.painelValor.Controls.Add(this.rdb_sim);
            this.painelValor.Controls.Add(this.label4);
            this.painelValor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelValor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.painelValor.Location = new System.Drawing.Point(16, 380);
            this.painelValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.painelValor.Name = "painelValor";
            this.painelValor.Size = new System.Drawing.Size(841, 64);
            this.painelValor.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(707, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "EUR";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_todos.Location = new System.Drawing.Point(463, 35);
            this.chk_todos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(65, 17);
            this.chk_todos.TabIndex = 20;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
            // 
            // chk_selecionados
            // 
            this.chk_selecionados.AutoSize = true;
            this.chk_selecionados.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_selecionados.Location = new System.Drawing.Point(463, 9);
            this.chk_selecionados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_selecionados.Name = "chk_selecionados";
            this.chk_selecionados.Size = new System.Drawing.Size(112, 17);
            this.chk_selecionados.TabIndex = 19;
            this.chk_selecionados.Text = "Selecionados";
            this.chk_selecionados.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "%";
            // 
            // txt_desconto
            // 
            this.txt_desconto.Location = new System.Drawing.Point(159, 27);
            this.txt_desconto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(40, 23);
            this.txt_desconto.TabIndex = 17;
            this.txt_desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_total_pagar
            // 
            this.txt_total_pagar.Enabled = false;
            this.txt_total_pagar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_pagar.Location = new System.Drawing.Point(601, 25);
            this.txt_total_pagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_total_pagar.Name = "txt_total_pagar";
            this.txt_total_pagar.ReadOnly = true;
            this.txt_total_pagar.Size = new System.Drawing.Size(99, 27);
            this.txt_total_pagar.TabIndex = 5;
            this.txt_total_pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(598, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOTAL A PAGAR";
            // 
            // rdb_nao
            // 
            this.rdb_nao.AutoSize = true;
            this.rdb_nao.Location = new System.Drawing.Point(85, 28);
            this.rdb_nao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_nao.Name = "rdb_nao";
            this.rdb_nao.Size = new System.Drawing.Size(57, 20);
            this.rdb_nao.TabIndex = 4;
            this.rdb_nao.TabStop = true;
            this.rdb_nao.Text = "NÃO";
            this.rdb_nao.UseVisualStyleBackColor = true;
            this.rdb_nao.CheckedChanged += new System.EventHandler(this.rdb_nao_CheckedChanged);
            // 
            // rdb_sim
            // 
            this.rdb_sim.AutoSize = true;
            this.rdb_sim.Location = new System.Drawing.Point(15, 28);
            this.rdb_sim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdb_sim.Name = "rdb_sim";
            this.rdb_sim.Size = new System.Drawing.Size(53, 20);
            this.rdb_sim.TabIndex = 3;
            this.rdb_sim.TabStop = true;
            this.rdb_sim.Text = "SIM";
            this.rdb_sim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "DESCONTO";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(84, 31);
            this.txt_produto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(116, 21);
            this.txt_produto.TabIndex = 1;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(276, 32);
            this.txt_preco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(116, 21);
            this.txt_preco.TabIndex = 2;
            this.txt_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.painelMenu.Controls.Add(this.label6);
            this.painelMenu.Controls.Add(this.label5);
            this.painelMenu.Controls.Add(this.txt_preco);
            this.painelMenu.Controls.Add(this.txt_produto);
            this.painelMenu.Controls.Add(this.menuProduto);
            this.painelMenu.Location = new System.Drawing.Point(13, 10);
            this.painelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(844, 60);
            this.painelMenu.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(225, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(11, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Produto";
            // 
            // menuProduto
            // 
            this.menuProduto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuProduto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLocalizarProduto,
            this.menuIncluirProduto,
            this.menuSair});
            this.menuProduto.Location = new System.Drawing.Point(0, 0);
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuProduto.Size = new System.Drawing.Size(844, 24);
            this.menuProduto.TabIndex = 14;
            this.menuProduto.Text = "Menu Produto";
            this.menuProduto.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuProduto_ItemClicked);
            // 
            // menuLocalizarProduto
            // 
            this.menuLocalizarProduto.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLocalizarProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuLocalizarProduto.Name = "menuLocalizarProduto";
            this.menuLocalizarProduto.Size = new System.Drawing.Size(145, 20);
            this.menuLocalizarProduto.Text = "Localizar Produto";
            this.menuLocalizarProduto.Click += new System.EventHandler(this.menuLocalizarProduto_Click);
            // 
            // menuIncluirProduto
            // 
            this.menuIncluirProduto.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuIncluirProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuIncluirProduto.Name = "menuIncluirProduto";
            this.menuIncluirProduto.Size = new System.Drawing.Size(167, 20);
            this.menuIncluirProduto.Text = "Incluir Novo Produto";
            this.menuIncluirProduto.Click += new System.EventHandler(this.menuIncluirProduto_Click);
            // 
            // menuSair
            // 
            this.menuSair.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(47, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_relatorio);
            this.panel2.Controls.Add(this.btn_incluir_consumidor);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_consumidor);
            this.panel2.Location = new System.Drawing.Point(234, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 234);
            this.panel2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nome";
            // 
            // btn_relatorio
            // 
            this.btn_relatorio.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_relatorio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_relatorio.Location = new System.Drawing.Point(7, 154);
            this.btn_relatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_relatorio.Name = "btn_relatorio";
            this.btn_relatorio.Size = new System.Drawing.Size(142, 52);
            this.btn_relatorio.TabIndex = 3;
            this.btn_relatorio.Text = "RELATÓRIO DE COMPRAS";
            this.btn_relatorio.UseVisualStyleBackColor = false;
            this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
            // 
            // btn_incluir_consumidor
            // 
            this.btn_incluir_consumidor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_incluir_consumidor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btn_incluir_consumidor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_incluir_consumidor.Location = new System.Drawing.Point(7, 93);
            this.btn_incluir_consumidor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_incluir_consumidor.Name = "btn_incluir_consumidor";
            this.btn_incluir_consumidor.Size = new System.Drawing.Size(142, 51);
            this.btn_incluir_consumidor.TabIndex = 2;
            this.btn_incluir_consumidor.Text = "INCLUIR CONSUMIDOR";
            this.btn_incluir_consumidor.UseVisualStyleBackColor = false;
            this.btn_incluir_consumidor.Click += new System.EventHandler(this.btn_incluir_consumidor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "CONSUMIDOR";
            // 
            // txt_consumidor
            // 
            this.txt_consumidor.Location = new System.Drawing.Point(7, 56);
            this.txt_consumidor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_consumidor.Name = "txt_consumidor";
            this.txt_consumidor.Size = new System.Drawing.Size(142, 21);
            this.txt_consumidor.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "RELATÓRIO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_total);
            this.panel3.Controls.Add(this.dg_relatorio);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(667, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 253);
            this.panel3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(132, 224);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(54, 22);
            this.txt_total.TabIndex = 24;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // dg_relatorio
            // 
            this.dg_relatorio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_relatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.consumidor,
            this.total_pago});
            this.dg_relatorio.Enabled = false;
            this.dg_relatorio.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dg_relatorio.Location = new System.Drawing.Point(5, 48);
            this.dg_relatorio.Name = "dg_relatorio";
            this.dg_relatorio.ReadOnly = true;
            this.dg_relatorio.Size = new System.Drawing.Size(182, 172);
            this.dg_relatorio.TabIndex = 23;
            // 
            // consumidor
            // 
            this.consumidor.HeaderText = "Consumidor";
            this.consumidor.Name = "consumidor";
            this.consumidor.ReadOnly = true;
            this.consumidor.Width = 80;
            // 
            // total_pago
            // 
            this.total_pago.HeaderText = "Total pago";
            this.total_pago.Name = "total_pago";
            this.total_pago.ReadOnly = true;
            this.total_pago.Width = 50;
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.painelMenu);
            this.Controls.Add(this.painelValor);
            this.Controls.Add(this.painelBotoes);
            this.Controls.Add(this.painelCompras);
            this.Controls.Add(this.painelProdutos);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuProduto;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE COMPRAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelProdutos.ResumeLayout(false);
            this.painelProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_produtos)).EndInit();
            this.painelCompras.ResumeLayout(false);
            this.painelCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_compras)).EndInit();
            this.painelBotoes.ResumeLayout(false);
            this.painelValor.ResumeLayout(false);
            this.painelValor.PerformLayout();
            this.painelMenu.ResumeLayout(false);
            this.painelMenu.PerformLayout();
            this.menuProduto.ResumeLayout(false);
            this.menuProduto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_relatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_prod_compra;
        private System.Windows.Forms.Panel painelProdutos;
        private System.Windows.Forms.Panel painelCompras;
        private System.Windows.Forms.Panel painelBotoes;
        private System.Windows.Forms.DataGridView dg_lista_produtos;
        private System.Windows.Forms.DataGridView dg_lista_compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_produto;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel painelValor;
        private System.Windows.Forms.RadioButton rdb_nao;
        private System.Windows.Forms.RadioButton rdb_sim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuProduto;
        private System.Windows.Forms.ToolStripMenuItem menuLocalizarProduto;
        private System.Windows.Forms.ToolStripMenuItem menuIncluirProduto;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.TextBox txt_total_pagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Button btn_exluir_lista_compras;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.CheckBox chk_selecionados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_relatorio;
        private System.Windows.Forms.Button btn_incluir_consumidor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_consumidor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dg_relatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pago;
        private System.Windows.Forms.Button btn_nova_compra;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label12;
    }
}

