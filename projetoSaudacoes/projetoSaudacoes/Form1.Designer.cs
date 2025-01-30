
namespace projetoSaudacoes
{
    partial class Form_saudacao
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
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_exibe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.BackColor = System.Drawing.Color.Linen;
            this.label_nome.ForeColor = System.Drawing.Color.Blue;
            this.label_nome.Location = new System.Drawing.Point(76, 101);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(38, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.ForeColor = System.Drawing.Color.Blue;
            this.textBox_nome.Location = new System.Drawing.Point(145, 98);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(148, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // button_exibe
            // 
            this.button_exibe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exibe.BackColor = System.Drawing.Color.Linen;
            this.button_exibe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_exibe.Location = new System.Drawing.Point(109, 151);
            this.button_exibe.Name = "button_exibe";
            this.button_exibe.Size = new System.Drawing.Size(124, 36);
            this.button_exibe.TabIndex = 2;
            this.button_exibe.Text = "&Clique Aqui";
            this.button_exibe.UseVisualStyleBackColor = false;
            this.button_exibe.Click += new System.EventHandler(this.button_exibe_Click);
            // 
            // Form_saudacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(522, 305);
            this.Controls.Add(this.button_exibe);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_saudacao";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Exemplo - SAUDAÇÃO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button_exibe;
    }
}

