using System;

namespace WinFormsAppAprendizado
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
            label1 = new Label();
            buttonP = new Button();
            buttonA = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            label3 = new Label();
            splitter1 = new Splitter();
            buttonCadastroAlunos = new Button();
            buttonCadastroPessoas = new Button();
            buttonAlunos = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(447, 15);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo, este programa irá mostar a quantidade de pessoas e alunos cadastrados";
            // 
            // buttonP
            // 
            buttonP.BackColor = SystemColors.ActiveBorder;
            buttonP.ForeColor = SystemColors.ButtonHighlight;
            buttonP.Location = new Point(147, 53);
            buttonP.Name = "buttonP";
            buttonP.Size = new Size(75, 23);
            buttonP.TabIndex = 1;
            buttonP.Text = "Pessoas";
            buttonP.UseVisualStyleBackColor = false;
            buttonP.Click += buttonP_Click;
            // 
            // buttonA
            // 
            buttonA.BackColor = SystemColors.ActiveBorder;
            buttonA.ForeColor = SystemColors.ButtonHighlight;
            buttonA.Location = new Point(147, 105);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(75, 23);
            buttonA.TabIndex = 2;
            buttonA.Text = "Alunos";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += buttonA_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantidade de pessoas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 4;
            label3.Text = "Quantidade de alunos";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 366);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // buttonCadastroAlunos
            // 
            buttonCadastroAlunos.BackColor = SystemColors.ActiveBorder;
            buttonCadastroAlunos.ForeColor = SystemColors.ButtonHighlight;
            buttonCadastroAlunos.Location = new Point(113, 91);
            buttonCadastroAlunos.Name = "buttonCadastroAlunos";
            buttonCadastroAlunos.Size = new Size(75, 23);
            buttonCadastroAlunos.TabIndex = 7;
            buttonCadastroAlunos.Text = "Matrículas";
            buttonCadastroAlunos.UseVisualStyleBackColor = false;
            buttonCadastroAlunos.Click += buttonCadastroAlunos_Click;
            // 
            // buttonCadastroPessoas
            // 
            buttonCadastroPessoas.BackColor = SystemColors.ActiveBorder;
            buttonCadastroPessoas.Location = new Point(113, 50);
            buttonCadastroPessoas.Name = "buttonCadastroPessoas";
            buttonCadastroPessoas.Size = new Size(75, 23);
            buttonCadastroPessoas.TabIndex = 8;
            buttonCadastroPessoas.Text = "Pessoas";
            buttonCadastroPessoas.UseVisualStyleBackColor = false;
            buttonCadastroPessoas.Click += buttonCadastroPessoas_Click;
            // 
            // buttonAlunos
            // 
            buttonAlunos.BackColor = SystemColors.ActiveBorder;
            buttonAlunos.Location = new Point(80, 131);
            buttonAlunos.Name = "buttonAlunos";
            buttonAlunos.Size = new Size(130, 23);
            buttonAlunos.TabIndex = 9;
            buttonAlunos.Text = "Alunos";
            buttonAlunos.UseVisualStyleBackColor = false;
            buttonAlunos.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAlunos);
            groupBox1.Controls.Add(buttonCadastroAlunos);
            groupBox1.Controls.Add(buttonCadastroPessoas);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 195);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(472, 366);
            Controls.Add(groupBox1);
            Controls.Add(splitter1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonA);
            Controls.Add(buttonP);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonP;
        private Button buttonA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label3;
        private Splitter splitter1;
        private Button buttonCadastroAlunos;
        private Button buttonCadastroPessoas;
        private Button buttonAlunos;
        private GroupBox groupBox1;
    }
}