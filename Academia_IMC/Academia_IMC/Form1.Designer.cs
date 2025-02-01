
namespace Academia_IMC
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
            this.label2 = new System.Windows.Forms.Label();
            this.label_imc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Peso = new System.Windows.Forms.TextBox();
            this.textBox_Altura = new System.Windows.Forms.TextBox();
            this.label_resultado_imc = new System.Windows.Forms.Label();
            this.label_situacao = new System.Windows.Forms.Label();
            this.button_Sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label_imc
            // 
            this.label_imc.AutoSize = true;
            this.label_imc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imc.Location = new System.Drawing.Point(46, 158);
            this.label_imc.Name = "label_imc";
            this.label_imc.Size = new System.Drawing.Size(38, 20);
            this.label_imc.TabIndex = 2;
            this.label_imc.Text = "IMC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Situação";
            // 
            // textBox_Peso
            // 
            this.textBox_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Peso.Location = new System.Drawing.Point(155, 43);
            this.textBox_Peso.Name = "textBox_Peso";
            this.textBox_Peso.Size = new System.Drawing.Size(183, 26);
            this.textBox_Peso.TabIndex = 4;
            // 
            // textBox_Altura
            // 
            this.textBox_Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Altura.Location = new System.Drawing.Point(155, 97);
            this.textBox_Altura.Name = "textBox_Altura";
            this.textBox_Altura.Size = new System.Drawing.Size(183, 26);
            this.textBox_Altura.TabIndex = 5;
            // 
            // label_resultado_imc
            // 
            this.label_resultado_imc.AutoSize = true;
            this.label_resultado_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado_imc.Location = new System.Drawing.Point(152, 158);
            this.label_resultado_imc.Name = "label_resultado_imc";
            this.label_resultado_imc.Size = new System.Drawing.Size(0, 20);
            this.label_resultado_imc.TabIndex = 6;
            // 
            // label_situacao
            // 
            this.label_situacao.AutoSize = true;
            this.label_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_situacao.Location = new System.Drawing.Point(152, 208);
            this.label_situacao.Name = "label_situacao";
            this.label_situacao.Size = new System.Drawing.Size(0, 20);
            this.label_situacao.TabIndex = 7;
            // 
            // button_Sair
            // 
            this.button_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sair.Location = new System.Drawing.Point(266, 242);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(89, 31);
            this.button_Sair.TabIndex = 8;
            this.button_Sair.Text = "Saír";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Academia_IMC.Properties.Resources.tela;
            this.pictureBox1.Location = new System.Drawing.Point(373, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button_calcular
            // 
            this.button_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.Location = new System.Drawing.Point(50, 242);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(89, 31);
            this.button_calcular.TabIndex = 10;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 285);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label_situacao);
            this.Controls.Add(this.label_resultado_imc);
            this.Controls.Add(this.textBox_Altura);
            this.Controls.Add(this.textBox_Peso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_imc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Academia IMC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_imc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Peso;
        private System.Windows.Forms.TextBox textBox_Altura;
        private System.Windows.Forms.Label label_resultado_imc;
        private System.Windows.Forms.Label label_situacao;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_calcular;
    }
}

