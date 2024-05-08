namespace aula0805
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxNomesAdicionados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVazio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(60, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sobrenome:";
            // 
            // txbNome
            // 
            this.txbNome.AcceptsTab = true;
            this.txbNome.Location = new System.Drawing.Point(133, 58);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(624, 20);
            this.txbNome.TabIndex = 2;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(133, 98);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(624, 20);
            this.txbSobrenome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seu nome completo é:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbNomeCompleto
            // 
            this.txbNomeCompleto.Location = new System.Drawing.Point(16, 192);
            this.txbNomeCompleto.Name = "txbNomeCompleto";
            this.txbNomeCompleto.ReadOnly = true;
            this.txbNomeCompleto.Size = new System.Drawing.Size(741, 20);
            this.txbNomeCompleto.TabIndex = 5;
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(493, 142);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(129, 38);
            this.btnConcatenar.TabIndex = 6;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(628, 142);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 38);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxNomesAdicionados
            // 
            this.cbxNomesAdicionados.FormattingEnabled = true;
            this.cbxNomesAdicionados.Location = new System.Drawing.Point(12, 267);
            this.cbxNomesAdicionados.Name = "cbxNomesAdicionados";
            this.cbxNomesAdicionados.Size = new System.Drawing.Size(741, 21);
            this.cbxNomesAdicionados.TabIndex = 8;
            this.cbxNomesAdicionados.SelectedIndexChanged += new System.EventHandler(this.cbxNomesAdicionados_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nomes Adicionados:";
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVazio.Location = new System.Drawing.Point(301, 314);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(0, 24);
            this.lblVazio.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 468);
            this.Controls.Add(this.lblVazio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxNomesAdicionados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.txbNomeCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeCompleto;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxNomesAdicionados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVazio;
    }
}

