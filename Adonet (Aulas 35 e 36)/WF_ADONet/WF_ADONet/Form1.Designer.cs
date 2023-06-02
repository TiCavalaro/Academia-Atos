namespace WF_ADONet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTodos = new Button();
            txbNome = new TextBox();
            dataGridView1 = new DataGridView();
            btnFiltrar = new Button();
            txbNomeNew = new TextBox();
            txbProfissao = new TextBox();
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonExcluir = new Button();
            buttonAlterar = new Button();
            textBoxId = new TextBox();
            buttonDR = new Button();
            labelDr = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(30, 98);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "Consultar";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(30, 40);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(100, 23);
            txbNome.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(189, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(489, 191);
            dataGridView1.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(28, 69);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txbNomeNew
            // 
            txbNomeNew.Location = new Point(28, 167);
            txbNomeNew.Name = "txbNomeNew";
            txbNomeNew.Size = new Size(100, 23);
            txbNomeNew.TabIndex = 4;
            // 
            // txbProfissao
            // 
            txbProfissao.Location = new Point(28, 210);
            txbProfissao.Name = "txbProfissao";
            txbProfissao.Size = new Size(100, 23);
            txbProfissao.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(25, 239);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 144);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 193);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Profissão";
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(25, 322);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 9;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(25, 351);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(75, 23);
            buttonAlterar.TabIndex = 10;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(578, 312);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 11;
            // 
            // buttonDR
            // 
            buttonDR.Location = new Point(578, 269);
            buttonDR.Name = "buttonDR";
            buttonDR.Size = new Size(75, 23);
            buttonDR.TabIndex = 12;
            buttonDR.Text = "DR Filtrar";
            buttonDR.UseVisualStyleBackColor = true;
            // 
            // labelDr
            // 
            labelDr.AutoSize = true;
            labelDr.Location = new Point(578, 245);
            labelDr.Name = "labelDr";
            labelDr.Size = new Size(40, 15);
            labelDr.TabIndex = 13;
            labelDr.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 558);
            Controls.Add(labelDr);
            Controls.Add(buttonDR);
            Controls.Add(textBoxId);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonExcluir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(txbProfissao);
            Controls.Add(txbNomeNew);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridView1);
            Controls.Add(txbNome);
            Controls.Add(btnTodos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTodos;
        private TextBox txbNome;
        private DataGridView dataGridView1;
        private Button btnFiltrar;
        private TextBox txbNomeNew;
        private TextBox txbProfissao;
        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Button buttonExcluir;
        private Button buttonAlterar;
        private TextBox textBoxId;
        private Button buttonDR;
        private Label labelDr;
    }
}