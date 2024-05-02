namespace aula0205
{
    partial class Home
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnNegativo = new System.Windows.Forms.Button();
            this.btnCorLaranja = new System.Windows.Forms.Button();
            this.btnCorPreta = new System.Windows.Forms.Button();
            this.btnCorRosa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(166, 103);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(131, 40);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Botão";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(213, 72);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(13, 13);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "0";
            // 
            // btnNegativo
            // 
            this.btnNegativo.Location = new System.Drawing.Point(166, 160);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(131, 40);
            this.btnNegativo.TabIndex = 2;
            this.btnNegativo.Text = "Botão do mal";
            this.btnNegativo.UseVisualStyleBackColor = true;
            this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
            // 
            // btnCorLaranja
            // 
            this.btnCorLaranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCorLaranja.Location = new System.Drawing.Point(400, 103);
            this.btnCorLaranja.Name = "btnCorLaranja";
            this.btnCorLaranja.Size = new System.Drawing.Size(47, 30);
            this.btnCorLaranja.TabIndex = 3;
            this.btnCorLaranja.UseVisualStyleBackColor = false;
            this.btnCorLaranja.Click += new System.EventHandler(this.btnCorLaranja_Click);
            // 
            // btnCorPreta
            // 
            this.btnCorPreta.BackColor = System.Drawing.Color.Black;
            this.btnCorPreta.Location = new System.Drawing.Point(400, 139);
            this.btnCorPreta.Name = "btnCorPreta";
            this.btnCorPreta.Size = new System.Drawing.Size(47, 30);
            this.btnCorPreta.TabIndex = 4;
            this.btnCorPreta.UseVisualStyleBackColor = false;
            this.btnCorPreta.Click += new System.EventHandler(this.btnCorPreto_Click);
            // 
            // btnCorRosa
            // 
            this.btnCorRosa.BackColor = System.Drawing.Color.Pink;
            this.btnCorRosa.Location = new System.Drawing.Point(400, 175);
            this.btnCorRosa.Name = "btnCorRosa";
            this.btnCorRosa.Size = new System.Drawing.Size(47, 30);
            this.btnCorRosa.TabIndex = 5;
            this.btnCorRosa.UseVisualStyleBackColor = false;
            this.btnCorRosa.Click += new System.EventHandler(this.btnCorRosa_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 279);
            this.Controls.Add(this.btnCorRosa);
            this.Controls.Add(this.btnCorPreta);
            this.Controls.Add(this.btnCorLaranja);
            this.Controls.Add(this.btnNegativo);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnClick);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnNegativo;
        private System.Windows.Forms.Button btnCorLaranja;
        private System.Windows.Forms.Button btnCorPreta;
        private System.Windows.Forms.Button btnCorRosa;
    }
}

