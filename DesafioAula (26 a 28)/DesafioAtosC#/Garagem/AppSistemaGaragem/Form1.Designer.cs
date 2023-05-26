namespace AppSistemaGaragem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbListaEntrada = new System.Windows.Forms.TextBox();
            this.tbListaSaida = new System.Windows.Forms.TextBox();
            this.lblListaEntrada = new System.Windows.Forms.Label();
            this.lblListaSaida = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btEntrada = new System.Windows.Forms.Button();
            this.btSaida = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbListaEntrada
            // 
            this.tbListaEntrada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbListaEntrada.Enabled = false;
            this.tbListaEntrada.Location = new System.Drawing.Point(226, 80);
            this.tbListaEntrada.Multiline = true;
            this.tbListaEntrada.Name = "tbListaEntrada";
            this.tbListaEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaEntrada.Size = new System.Drawing.Size(276, 358);
            this.tbListaEntrada.TabIndex = 0;
            // 
            // tbListaSaida
            // 
            this.tbListaSaida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbListaSaida.Enabled = false;
            this.tbListaSaida.Location = new System.Drawing.Point(512, 80);
            this.tbListaSaida.Multiline = true;
            this.tbListaSaida.Name = "tbListaSaida";
            this.tbListaSaida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListaSaida.Size = new System.Drawing.Size(276, 358);
            this.tbListaSaida.TabIndex = 1;
            // 
            // lblListaEntrada
            // 
            this.lblListaEntrada.AutoSize = true;
            this.lblListaEntrada.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEntrada.ForeColor = System.Drawing.Color.Snow;
            this.lblListaEntrada.Location = new System.Drawing.Point(251, 49);
            this.lblListaEntrada.Name = "lblListaEntrada";
            this.lblListaEntrada.Size = new System.Drawing.Size(198, 20);
            this.lblListaEntrada.TabIndex = 2;
            this.lblListaEntrada.Text = "Veículos na Garagem:";
            // 
            // lblListaSaida
            // 
            this.lblListaSaida.AutoSize = true;
            this.lblListaSaida.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaSaida.ForeColor = System.Drawing.Color.Snow;
            this.lblListaSaida.Location = new System.Drawing.Point(540, 49);
            this.lblListaSaida.Name = "lblListaSaida";
            this.lblListaSaida.Size = new System.Drawing.Size(192, 20);
            this.lblListaSaida.TabIndex = 3;
            this.lblListaSaida.Text = "Veículos que Saíram:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlaca.Location = new System.Drawing.Point(49, 156);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(117, 20);
            this.tbPlaca.TabIndex = 4;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.Snow;
            this.lblPlaca.Location = new System.Drawing.Point(76, 132);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(66, 16);
            this.lblPlaca.TabIndex = 5;
            this.lblPlaca.Text = "PLACA:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Snow;
            this.lblHora.Location = new System.Drawing.Point(64, 204);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(88, 16);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "HORÁRIO:";
            // 
            // dtpHora
            // 
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(72, 225);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(73, 20);
            this.dtpHora.TabIndex = 7;
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(67, 297);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(81, 20);
            this.dtpData.TabIndex = 9;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Snow;
            this.lblData.Location = new System.Drawing.Point(80, 276);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 16);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "DATA:";
            // 
            // btEntrada
            // 
            this.btEntrada.BackColor = System.Drawing.Color.Goldenrod;
            this.btEntrada.FlatAppearance.BorderSize = 0;
            this.btEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrada.Location = new System.Drawing.Point(22, 367);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(87, 38);
            this.btEntrada.TabIndex = 10;
            this.btEntrada.Text = "ENTRADA";
            this.btEntrada.UseVisualStyleBackColor = false;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // btSaida
            // 
            this.btSaida.BackColor = System.Drawing.Color.Goldenrod;
            this.btSaida.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btSaida.FlatAppearance.BorderSize = 0;
            this.btSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaida.Location = new System.Drawing.Point(115, 367);
            this.btSaida.Name = "btSaida";
            this.btSaida.Size = new System.Drawing.Size(87, 38);
            this.btSaida.TabIndex = 11;
            this.btSaida.Text = "SAÍDA";
            this.btSaida.UseVisualStyleBackColor = false;
            this.btSaida.Click += new System.EventHandler(this.btSaida_Click);
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.ForeColor = System.Drawing.Color.Snow;
            this.lblDados.Location = new System.Drawing.Point(33, 80);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(170, 20);
            this.lblDados.TabIndex = 12;
            this.lblDados.Text = "Dados do Veículo:";
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.buttonSair);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 40);
            this.panelCabecalho.TabIndex = 13;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(760, -1);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(40, 41);
            this.buttonSair.TabIndex = 0;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sistema de Garagem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btSaida);
            this.Controls.Add(this.btEntrada);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.lblListaSaida);
            this.Controls.Add(this.lblListaEntrada);
            this.Controls.Add(this.tbListaSaida);
            this.Controls.Add(this.tbListaEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Garagem";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbListaEntrada;
        private System.Windows.Forms.TextBox tbListaSaida;
        private System.Windows.Forms.Label lblListaEntrada;
        private System.Windows.Forms.Label lblListaSaida;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.Button btSaida;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSair;
    }
}

