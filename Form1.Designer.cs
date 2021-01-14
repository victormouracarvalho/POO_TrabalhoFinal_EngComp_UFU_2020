
namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Estoque = new System.Windows.Forms.TabPage();
            this.btupdateestoque = new System.Windows.Forms.Button();
            this.btinsertestoque = new System.Windows.Forms.Button();
            this.btdeleteestoque = new System.Windows.Forms.Button();
            this.btsaveestoque = new System.Windows.Forms.Button();
            this.btprecocompra = new System.Windows.Forms.TextBox();
            this.btprecovenda = new System.Windows.Forms.TextBox();
            this.btquantidade = new System.Windows.Forms.TextBox();
            this.btcodigo = new System.Windows.Forms.TextBox();
            this.btdescricao = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txbnomeloja = new System.Windows.Forms.TextBox();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.txbvalortotal = new System.Windows.Forms.TextBox();
            this.txbprecovenda = new System.Windows.Forms.TextBox();
            this.btquantidadevenda = new System.Windows.Forms.TextBox();
            this.btsavevenda = new System.Windows.Forms.Button();
            this.btdeletevenda = new System.Windows.Forms.Button();
            this.txbcep = new System.Windows.Forms.TextBox();
            this.txbtelefone = new System.Windows.Forms.TextBox();
            this.txbcnpj = new System.Windows.Forms.TextBox();
            this.horario = new System.Windows.Forms.MaskedTextBox();
            this.btinserirvenda = new System.Windows.Forms.Button();
            this.btupdatevenda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Estoque
            // 
            this.Estoque.BackColor = System.Drawing.Color.LightGray;
            this.Estoque.Controls.Add(this.label15);
            this.Estoque.Controls.Add(this.label13);
            this.Estoque.Controls.Add(this.label12);
            this.Estoque.Controls.Add(this.label11);
            this.Estoque.Controls.Add(this.label10);
            this.Estoque.Controls.Add(this.btupdateestoque);
            this.Estoque.Controls.Add(this.btinsertestoque);
            this.Estoque.Controls.Add(this.btdeleteestoque);
            this.Estoque.Controls.Add(this.btsaveestoque);
            this.Estoque.Controls.Add(this.btprecocompra);
            this.Estoque.Controls.Add(this.btprecovenda);
            this.Estoque.Controls.Add(this.btquantidade);
            this.Estoque.Controls.Add(this.btcodigo);
            this.Estoque.Controls.Add(this.btdescricao);
            this.Estoque.Controls.Add(this.dataGridView2);
            this.Estoque.Location = new System.Drawing.Point(4, 25);
            this.Estoque.Name = "Estoque";
            this.Estoque.Padding = new System.Windows.Forms.Padding(3);
            this.Estoque.Size = new System.Drawing.Size(1334, 485);
            this.Estoque.TabIndex = 1;
            this.Estoque.Text = "Estoque";
            this.Estoque.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btupdateestoque
            // 
            this.btupdateestoque.Location = new System.Drawing.Point(1167, 340);
            this.btupdateestoque.Name = "btupdateestoque";
            this.btupdateestoque.Size = new System.Drawing.Size(150, 44);
            this.btupdateestoque.TabIndex = 9;
            this.btupdateestoque.Text = "Atualizar";
            this.btupdateestoque.UseVisualStyleBackColor = true;
            this.btupdateestoque.Click += new System.EventHandler(this.btupdateestoque_Click);
            // 
            // btinsertestoque
            // 
            this.btinsertestoque.Location = new System.Drawing.Point(989, 340);
            this.btinsertestoque.Name = "btinsertestoque";
            this.btinsertestoque.Size = new System.Drawing.Size(150, 44);
            this.btinsertestoque.TabIndex = 8;
            this.btinsertestoque.Text = "Inserir";
            this.btinsertestoque.UseVisualStyleBackColor = true;
            this.btinsertestoque.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btdeleteestoque
            // 
            this.btdeleteestoque.Location = new System.Drawing.Point(1167, 390);
            this.btdeleteestoque.Name = "btdeleteestoque";
            this.btdeleteestoque.Size = new System.Drawing.Size(150, 44);
            this.btdeleteestoque.TabIndex = 7;
            this.btdeleteestoque.Text = "Deletar";
            this.btdeleteestoque.UseVisualStyleBackColor = true;
            this.btdeleteestoque.Click += new System.EventHandler(this.button5_Click);
            // 
            // btsaveestoque
            // 
            this.btsaveestoque.Location = new System.Drawing.Point(989, 390);
            this.btsaveestoque.Name = "btsaveestoque";
            this.btsaveestoque.Size = new System.Drawing.Size(150, 44);
            this.btsaveestoque.TabIndex = 6;
            this.btsaveestoque.Text = "Salvar";
            this.btsaveestoque.UseVisualStyleBackColor = true;
            this.btsaveestoque.Click += new System.EventHandler(this.btsaveestoque_Click);
            // 
            // btprecocompra
            // 
            this.btprecocompra.Location = new System.Drawing.Point(1074, 266);
            this.btprecocompra.Name = "btprecocompra";
            this.btprecocompra.Size = new System.Drawing.Size(231, 22);
            this.btprecocompra.TabIndex = 5;
            this.btprecocompra.TextChanged += new System.EventHandler(this.btprecocompra_TextChanged);
            // 
            // btprecovenda
            // 
            this.btprecovenda.Location = new System.Drawing.Point(1074, 205);
            this.btprecovenda.Name = "btprecovenda";
            this.btprecovenda.Size = new System.Drawing.Size(231, 22);
            this.btprecovenda.TabIndex = 4;
            this.btprecovenda.TextChanged += new System.EventHandler(this.btprecovenda_TextChanged);
            // 
            // btquantidade
            // 
            this.btquantidade.Location = new System.Drawing.Point(1074, 150);
            this.btquantidade.Name = "btquantidade";
            this.btquantidade.Size = new System.Drawing.Size(231, 22);
            this.btquantidade.TabIndex = 3;
            this.btquantidade.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btcodigo
            // 
            this.btcodigo.Location = new System.Drawing.Point(1074, 91);
            this.btcodigo.Name = "btcodigo";
            this.btcodigo.Size = new System.Drawing.Size(231, 22);
            this.btcodigo.TabIndex = 2;
            this.btcodigo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btdescricao
            // 
            this.btdescricao.Location = new System.Drawing.Point(1074, 32);
            this.btdescricao.Name = "btdescricao";
            this.btdescricao.Size = new System.Drawing.Size(231, 22);
            this.btdescricao.TabIndex = 1;
            this.btdescricao.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(876, 465);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Estoque);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1342, 514);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txbcnpj);
            this.tabPage1.Controls.Add(this.txbtelefone);
            this.tabPage1.Controls.Add(this.txbcep);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1334, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(885, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1086, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 33);
            this.button4.TabIndex = 10;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1115, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1212, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(963, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome da Loja";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1212, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1115, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1086, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1115, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btupdatevenda);
            this.tabPage3.Controls.Add(this.btinserirvenda);
            this.tabPage3.Controls.Add(this.horario);
            this.tabPage3.Controls.Add(this.btdeletevenda);
            this.tabPage3.Controls.Add(this.btsavevenda);
            this.tabPage3.Controls.Add(this.btquantidadevenda);
            this.tabPage3.Controls.Add(this.txbprecovenda);
            this.tabPage3.Controls.Add(this.txbvalortotal);
            this.tabPage3.Controls.Add(this.txbcodigo);
            this.tabPage3.Controls.Add(this.txbnomeloja);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1334, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vendas";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1001, 459);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // txbnomeloja
            // 
            this.txbnomeloja.Location = new System.Drawing.Point(1144, 234);
            this.txbnomeloja.Name = "txbnomeloja";
            this.txbnomeloja.Size = new System.Drawing.Size(164, 22);
            this.txbnomeloja.TabIndex = 1;
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(1144, 184);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(164, 22);
            this.txbcodigo.TabIndex = 2;
            // 
            // txbvalortotal
            // 
            this.txbvalortotal.Location = new System.Drawing.Point(1144, 131);
            this.txbvalortotal.Name = "txbvalortotal";
            this.txbvalortotal.Size = new System.Drawing.Size(164, 22);
            this.txbvalortotal.TabIndex = 3;
            // 
            // txbprecovenda
            // 
            this.txbprecovenda.Location = new System.Drawing.Point(1144, 78);
            this.txbprecovenda.Name = "txbprecovenda";
            this.txbprecovenda.Size = new System.Drawing.Size(164, 22);
            this.txbprecovenda.TabIndex = 4;
            this.txbprecovenda.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btquantidadevenda
            // 
            this.btquantidadevenda.Location = new System.Drawing.Point(1144, 18);
            this.btquantidadevenda.Name = "btquantidadevenda";
            this.btquantidadevenda.Size = new System.Drawing.Size(164, 22);
            this.btquantidadevenda.TabIndex = 5;
            // 
            // btsavevenda
            // 
            this.btsavevenda.Location = new System.Drawing.Point(1087, 400);
            this.btsavevenda.Name = "btsavevenda";
            this.btsavevenda.Size = new System.Drawing.Size(96, 43);
            this.btsavevenda.TabIndex = 6;
            this.btsavevenda.Text = "Salvar";
            this.btsavevenda.UseVisualStyleBackColor = true;
            this.btsavevenda.Click += new System.EventHandler(this.btsavevenda_Click);
            // 
            // btdeletevenda
            // 
            this.btdeletevenda.Location = new System.Drawing.Point(1209, 400);
            this.btdeletevenda.Name = "btdeletevenda";
            this.btdeletevenda.Size = new System.Drawing.Size(99, 43);
            this.btdeletevenda.TabIndex = 7;
            this.btdeletevenda.Text = "Deletar";
            this.btdeletevenda.UseVisualStyleBackColor = true;
            this.btdeletevenda.Click += new System.EventHandler(this.btdeletevenda_Click);
            // 
            // txbcep
            // 
            this.txbcep.Location = new System.Drawing.Point(1115, 314);
            this.txbcep.Name = "txbcep";
            this.txbcep.Size = new System.Drawing.Size(194, 22);
            this.txbcep.TabIndex = 11;
            this.txbcep.TextChanged += new System.EventHandler(this.txbcep_TextChanged);
            // 
            // txbtelefone
            // 
            this.txbtelefone.Location = new System.Drawing.Point(1115, 270);
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(194, 22);
            this.txbtelefone.TabIndex = 12;
            this.txbtelefone.TextChanged += new System.EventHandler(this.txbtelefone_TextChanged);
            // 
            // txbcnpj
            // 
            this.txbcnpj.Location = new System.Drawing.Point(1115, 222);
            this.txbcnpj.Name = "txbcnpj";
            this.txbcnpj.Size = new System.Drawing.Size(194, 22);
            this.txbcnpj.TabIndex = 13;
            this.txbcnpj.TextChanged += new System.EventHandler(this.txbcnpj_TextChanged);
            // 
            // horario
            // 
            this.horario.Location = new System.Drawing.Point(1144, 290);
            this.horario.Mask = "90:00 00/00/0000 ";
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(164, 22);
            this.horario.TabIndex = 8;
            this.horario.ValidatingType = typeof(System.DateTime);
            // 
            // btinserirvenda
            // 
            this.btinserirvenda.Location = new System.Drawing.Point(1087, 337);
            this.btinserirvenda.Name = "btinserirvenda";
            this.btinserirvenda.Size = new System.Drawing.Size(96, 44);
            this.btinserirvenda.TabIndex = 9;
            this.btinserirvenda.Text = "Inserir";
            this.btinserirvenda.UseVisualStyleBackColor = true;
            this.btinserirvenda.Click += new System.EventHandler(this.btinserirvenda_Click);
            // 
            // btupdatevenda
            // 
            this.btupdatevenda.Location = new System.Drawing.Point(1209, 338);
            this.btupdatevenda.Name = "btupdatevenda";
            this.btupdatevenda.Size = new System.Drawing.Size(99, 43);
            this.btupdatevenda.TabIndex = 10;
            this.btupdatevenda.Text = "Atualizar";
            this.btupdatevenda.UseVisualStyleBackColor = true;
            this.btupdatevenda.Click += new System.EventHandler(this.btupdatevenda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1024, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1024, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Preço Unidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1024, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1024, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Código Produto";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1024, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nome da Loja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1024, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Horario ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(915, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Descrição do Produto";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(915, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Código do Produto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(915, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Quantidade Disponível";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(915, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Preço de Venda";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(915, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Preço de Compra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(963, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 14;
            this.label14.Text = "CEP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(963, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Telefone de Contato";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(963, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "CNPJ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(963, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "Endereço";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(963, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "E-mail de Contato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Vendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Estoque.ResumeLayout(false);
            this.Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Estoque;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox btdescricao;
        private System.Windows.Forms.TextBox btquantidade;
        private System.Windows.Forms.TextBox btcodigo;
        private System.Windows.Forms.TextBox btprecocompra;
        private System.Windows.Forms.TextBox btprecovenda;
        private System.Windows.Forms.Button btsaveestoque;
        private System.Windows.Forms.Button btdeleteestoque;
        private System.Windows.Forms.Button btupdateestoque;
        private System.Windows.Forms.Button btinsertestoque;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox btquantidadevenda;
        private System.Windows.Forms.TextBox txbprecovenda;
        private System.Windows.Forms.TextBox txbvalortotal;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.TextBox txbnomeloja;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txbcnpj;
        private System.Windows.Forms.TextBox txbtelefone;
        private System.Windows.Forms.TextBox txbcep;
        private System.Windows.Forms.Button btdeletevenda;
        private System.Windows.Forms.Button btsavevenda;
        private System.Windows.Forms.MaskedTextBox horario;
        private System.Windows.Forms.Button btinserirvenda;
        private System.Windows.Forms.Button btupdatevenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
    }
}

