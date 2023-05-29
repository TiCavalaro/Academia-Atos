namespace WinFormsAppDesafioAtosG
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
            tbListaSaida = new TextBox();
            lblListaSaida = new Label();
            tbListaEntrada = new TextBox();
            lblListaEntrada = new Label();
            lblDados = new Label();
            lblPlaca = new Label();
            lblHora = new Label();
            tbPlaca = new TextBox();
            dtpHora = new DateTimePicker();
            lblData = new Label();
            dtpData = new DateTimePicker();
            btEntrada = new Button();
            btSaida = new Button();
            SuspendLayout();
            // 
            // tbListaSaida
            // 
            tbListaSaida.BackColor = SystemColors.ControlLight;
            tbListaSaida.Enabled = false;
            tbListaSaida.Location = new Point(568, 106);
            tbListaSaida.Margin = new Padding(4, 3, 4, 3);
            tbListaSaida.Multiline = true;
            tbListaSaida.Name = "tbListaSaida";
            tbListaSaida.ScrollBars = ScrollBars.Vertical;
            tbListaSaida.Size = new Size(321, 412);
            tbListaSaida.TabIndex = 2;
            // 
            // lblListaSaida
            // 
            lblListaSaida.AutoSize = true;
            lblListaSaida.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaSaida.ForeColor = Color.Snow;
            lblListaSaida.Location = new Point(634, 72);
            lblListaSaida.Margin = new Padding(4, 0, 4, 0);
            lblListaSaida.Name = "lblListaSaida";
            lblListaSaida.Size = new Size(192, 20);
            lblListaSaida.TabIndex = 4;
            lblListaSaida.Text = "Veículos que Saíram:";
            // 
            // tbListaEntrada
            // 
            tbListaEntrada.BackColor = SystemColors.ControlLight;
            tbListaEntrada.Enabled = false;
            tbListaEntrada.Location = new Point(239, 106);
            tbListaEntrada.Margin = new Padding(4, 3, 4, 3);
            tbListaEntrada.Multiline = true;
            tbListaEntrada.Name = "tbListaEntrada";
            tbListaEntrada.ScrollBars = ScrollBars.Vertical;
            tbListaEntrada.Size = new Size(321, 412);
            tbListaEntrada.TabIndex = 5;
            // 
            // lblListaEntrada
            // 
            lblListaEntrada.AutoSize = true;
            lblListaEntrada.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaEntrada.ForeColor = Color.Snow;
            lblListaEntrada.Location = new Point(292, 72);
            lblListaEntrada.Margin = new Padding(4, 0, 4, 0);
            lblListaEntrada.Name = "lblListaEntrada";
            lblListaEntrada.Size = new Size(198, 20);
            lblListaEntrada.TabIndex = 6;
            lblListaEntrada.Text = "Veículos na Garagem:";
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDados.ForeColor = Color.Snow;
            lblDados.Location = new Point(38, 72);
            lblDados.Margin = new Padding(4, 0, 4, 0);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(170, 20);
            lblDados.TabIndex = 13;
            lblDados.Text = "Dados do Veículo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlaca.ForeColor = Color.Snow;
            lblPlaca.Location = new Point(81, 124);
            lblPlaca.Margin = new Padding(4, 0, 4, 0);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(66, 16);
            lblPlaca.TabIndex = 14;
            lblPlaca.Text = "PLACA:";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.Snow;
            lblHora.Location = new Point(73, 265);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(88, 16);
            lblHora.TabIndex = 15;
            lblHora.Text = "HORÁRIO:";
            // 
            // tbPlaca
            // 
            tbPlaca.BorderStyle = BorderStyle.FixedSingle;
            tbPlaca.Location = new Point(51, 158);
            tbPlaca.Margin = new Padding(4, 3, 4, 3);
            tbPlaca.Name = "tbPlaca";
            tbPlaca.Size = new Size(136, 23);
            tbPlaca.TabIndex = 16;
            // 
            // dtpHora
            // 
            dtpHora.Enabled = false;
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(73, 296);
            dtpHora.Margin = new Padding(4, 3, 4, 3);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(84, 23);
            dtpHora.TabIndex = 17;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblData.ForeColor = Color.Snow;
            lblData.Location = new Point(81, 340);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(58, 16);
            lblData.TabIndex = 18;
            lblData.Text = "DATA:";
            // 
            // dtpData
            // 
            dtpData.Enabled = false;
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(69, 368);
            dtpData.Margin = new Padding(4, 3, 4, 3);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(94, 23);
            dtpData.TabIndex = 19;
            // 
            // btEntrada
            // 
            btEntrada.BackColor = Color.Gray;
            btEntrada.FlatAppearance.BorderSize = 0;
            btEntrada.FlatStyle = FlatStyle.Flat;
            btEntrada.Location = new Point(13, 463);
            btEntrada.Margin = new Padding(4, 3, 4, 3);
            btEntrada.Name = "btEntrada";
            btEntrada.Size = new Size(102, 44);
            btEntrada.TabIndex = 20;
            btEntrada.Text = "ENTRADA";
            btEntrada.UseVisualStyleBackColor = false;
            // 
            // btSaida
            // 
            btSaida.BackColor = Color.Gray;
            btSaida.FlatAppearance.BorderColor = Color.Goldenrod;
            btSaida.FlatAppearance.BorderSize = 0;
            btSaida.FlatStyle = FlatStyle.Flat;
            btSaida.Location = new Point(129, 463);
            btSaida.Margin = new Padding(4, 3, 4, 3);
            btSaida.Name = "btSaida";
            btSaida.Size = new Size(102, 44);
            btSaida.TabIndex = 21;
            btSaida.Text = "SAÍDA";
            btSaida.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(919, 547);
            Controls.Add(btSaida);
            Controls.Add(btEntrada);
            Controls.Add(dtpData);
            Controls.Add(lblData);
            Controls.Add(dtpHora);
            Controls.Add(tbPlaca);
            Controls.Add(lblHora);
            Controls.Add(lblPlaca);
            Controls.Add(lblDados);
            Controls.Add(lblListaEntrada);
            Controls.Add(tbListaEntrada);
            Controls.Add(lblListaSaida);
            Controls.Add(tbListaSaida);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbListaSaida;
        private Label lblListaSaida;
        private TextBox tbListaEntrada;
        private Label lblListaEntrada;
        private Label lblDados;
        private Label lblPlaca;
        private Label lblHora;
        private TextBox tbPlaca;
        private DateTimePicker dtpHora;
        private Label lblData;
        private DateTimePicker dtpData;
        private Button btEntrada;
        private Button btSaida;
    }
}