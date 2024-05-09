namespace aula0905
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
            this.txbEscrita = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lbxEstados = new System.Windows.Forms.ListBox();
            this.lbxSelecionados = new System.Windows.Forms.ListBox();
            this.btnCopiarSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbEscrita
            // 
            this.txbEscrita.Location = new System.Drawing.Point(102, 12);
            this.txbEscrita.Name = "txbEscrita";
            this.txbEscrita.Size = new System.Drawing.Size(432, 20);
            this.txbEscrita.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxEstados
            // 
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(12, 52);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(522, 21);
            this.cbxEstados.TabIndex = 2;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(12, 92);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lbxEstados
            // 
            this.lbxEstados.FormattingEnabled = true;
            this.lbxEstados.Location = new System.Drawing.Point(12, 121);
            this.lbxEstados.Name = "lbxEstados";
            this.lbxEstados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxEstados.Size = new System.Drawing.Size(252, 95);
            this.lbxEstados.TabIndex = 4;
            // 
            // lbxSelecionados
            // 
            this.lbxSelecionados.FormattingEnabled = true;
            this.lbxSelecionados.Location = new System.Drawing.Point(282, 121);
            this.lbxSelecionados.Name = "lbxSelecionados";
            this.lbxSelecionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxSelecionados.Size = new System.Drawing.Size(252, 95);
            this.lbxSelecionados.TabIndex = 6;
            // 
            // btnCopiarSelecionado
            // 
            this.btnCopiarSelecionado.Location = new System.Drawing.Point(282, 92);
            this.btnCopiarSelecionado.Name = "btnCopiarSelecionado";
            this.btnCopiarSelecionado.Size = new System.Drawing.Size(114, 23);
            this.btnCopiarSelecionado.TabIndex = 5;
            this.btnCopiarSelecionado.Text = "Copiar Selecionados";
            this.btnCopiarSelecionado.UseVisualStyleBackColor = true;
            this.btnCopiarSelecionado.Click += new System.EventHandler(this.btnCopiarSelecionado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 237);
            this.Controls.Add(this.lbxSelecionados);
            this.Controls.Add(this.btnCopiarSelecionado);
            this.Controls.Add(this.lbxEstados);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.cbxEstados);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbEscrita);
            this.Name = "Form1";
            this.Text = "Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEscrita;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.ListBox lbxEstados;
        private System.Windows.Forms.ListBox lbxSelecionados;
        private System.Windows.Forms.Button btnCopiarSelecionado;
    }
}

