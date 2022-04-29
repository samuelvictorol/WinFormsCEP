namespace WinForm04CEP
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_logra = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o CEP:";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(24, 61);
            this.txt_cep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(158, 28);
            this.txt_cep.TabIndex = 1;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(208, 59);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(108, 36);
            this.btn_pesquisar.TabIndex = 2;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logradouro";
            // 
            // txt_logra
            // 
            this.txt_logra.Location = new System.Drawing.Point(28, 177);
            this.txt_logra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_logra.Name = "txt_logra";
            this.txt_logra.Size = new System.Drawing.Size(332, 28);
            this.txt_logra.TabIndex = 4;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(28, 258);
            this.txt_bairro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(122, 28);
            this.txt_bairro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bairro";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(194, 258);
            this.txt_cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(166, 28);
            this.txt_cidade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade";
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(28, 337);
            this.txt_uf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(332, 28);
            this.txt_uf.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "UF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(430, 432);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_logra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_logra;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Label label5;
    }
}

