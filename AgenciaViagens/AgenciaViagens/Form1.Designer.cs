
namespace AgenciaViagens
{
    partial class Agencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agencia));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DataEmbarque = new System.Windows.Forms.TextBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.button_Calculadora = new System.Windows.Forms.Button();
            this.button_CalcularViagem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_onibus = new System.Windows.Forms.RadioButton();
            this.radioButton_aviao = new System.Windows.Forms.RadioButton();
            this.groupBox_Resultado = new System.Windows.Forms.GroupBox();
            this.textBox_ValorTotal = new System.Windows.Forms.TextBox();
            this.label_GastoDestino = new System.Windows.Forms.Label();
            this.label_GastoTransporte = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.IndianRed;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(728, 67);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Reserva de Passagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(156, 85);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(453, 22);
            this.textBox_nome.TabIndex = 2;
            this.textBox_nome.Leave += new System.EventHandler(this.textBox_nome_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Embarque";
            // 
            // textBox_DataEmbarque
            // 
            this.textBox_DataEmbarque.Location = new System.Drawing.Point(156, 189);
            this.textBox_DataEmbarque.Name = "textBox_DataEmbarque";
            this.textBox_DataEmbarque.Size = new System.Drawing.Size(287, 20);
            this.textBox_DataEmbarque.TabIndex = 6;
            // 
            // button_Sair
            // 
            this.button_Sair.BackColor = System.Drawing.Color.Crimson;
            this.button_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sair.ForeColor = System.Drawing.Color.Black;
            this.button_Sair.Location = new System.Drawing.Point(615, 74);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(101, 44);
            this.button_Sair.TabIndex = 7;
            this.button_Sair.Text = "Saír";
            this.button_Sair.UseVisualStyleBackColor = false;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.BackColor = System.Drawing.Color.SpringGreen;
            this.button_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.button_Confirmar.Location = new System.Drawing.Point(615, 124);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(101, 41);
            this.button_Confirmar.TabIndex = 8;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = false;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.BackColor = System.Drawing.Color.Gold;
            this.button_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpar.ForeColor = System.Drawing.Color.Black;
            this.button_Limpar.Location = new System.Drawing.Point(615, 171);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(101, 38);
            this.button_Limpar.TabIndex = 9;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = false;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // button_Calculadora
            // 
            this.button_Calculadora.BackColor = System.Drawing.Color.Silver;
            this.button_Calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calculadora.ForeColor = System.Drawing.Color.Black;
            this.button_Calculadora.Location = new System.Drawing.Point(615, 215);
            this.button_Calculadora.Name = "button_Calculadora";
            this.button_Calculadora.Size = new System.Drawing.Size(101, 38);
            this.button_Calculadora.TabIndex = 10;
            this.button_Calculadora.Text = "Calculadora";
            this.button_Calculadora.UseVisualStyleBackColor = false;
            this.button_Calculadora.Click += new System.EventHandler(this.button_Calculadora_Click);
            // 
            // button_CalcularViagem
            // 
            this.button_CalcularViagem.BackColor = System.Drawing.Color.Red;
            this.button_CalcularViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CalcularViagem.ForeColor = System.Drawing.Color.White;
            this.button_CalcularViagem.Location = new System.Drawing.Point(615, 283);
            this.button_CalcularViagem.Name = "button_CalcularViagem";
            this.button_CalcularViagem.Size = new System.Drawing.Size(101, 56);
            this.button_CalcularViagem.TabIndex = 11;
            this.button_CalcularViagem.Text = "Calculador Valor Viagem";
            this.button_CalcularViagem.UseVisualStyleBackColor = false;
            this.button_CalcularViagem.Click += new System.EventHandler(this.button_CalcularViagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_onibus);
            this.groupBox1.Controls.Add(this.radioButton_aviao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 96);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meio Transporte";
            // 
            // radioButton_onibus
            // 
            this.radioButton_onibus.AutoSize = true;
            this.radioButton_onibus.Location = new System.Drawing.Point(6, 67);
            this.radioButton_onibus.Name = "radioButton_onibus";
            this.radioButton_onibus.Size = new System.Drawing.Size(74, 20);
            this.radioButton_onibus.TabIndex = 3;
            this.radioButton_onibus.TabStop = true;
            this.radioButton_onibus.Text = "Ônibus";
            this.radioButton_onibus.UseVisualStyleBackColor = true;
            // 
            // radioButton_aviao
            // 
            this.radioButton_aviao.AutoSize = true;
            this.radioButton_aviao.Location = new System.Drawing.Point(7, 32);
            this.radioButton_aviao.Name = "radioButton_aviao";
            this.radioButton_aviao.Size = new System.Drawing.Size(66, 20);
            this.radioButton_aviao.TabIndex = 2;
            this.radioButton_aviao.TabStop = true;
            this.radioButton_aviao.Text = "Avião";
            this.radioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // groupBox_Resultado
            // 
            this.groupBox_Resultado.Controls.Add(this.textBox_ValorTotal);
            this.groupBox_Resultado.Controls.Add(this.label_GastoDestino);
            this.groupBox_Resultado.Controls.Add(this.label_GastoTransporte);
            this.groupBox_Resultado.Controls.Add(this.label6);
            this.groupBox_Resultado.Controls.Add(this.label5);
            this.groupBox_Resultado.Controls.Add(this.label4);
            this.groupBox_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Resultado.Location = new System.Drawing.Point(0, 228);
            this.groupBox_Resultado.Name = "groupBox_Resultado";
            this.groupBox_Resultado.Size = new System.Drawing.Size(609, 121);
            this.groupBox_Resultado.TabIndex = 13;
            this.groupBox_Resultado.TabStop = false;
            this.groupBox_Resultado.Text = "Valores do Pacote";
            // 
            // textBox_ValorTotal
            // 
            this.textBox_ValorTotal.Location = new System.Drawing.Point(199, 90);
            this.textBox_ValorTotal.Name = "textBox_ValorTotal";
            this.textBox_ValorTotal.Size = new System.Drawing.Size(134, 22);
            this.textBox_ValorTotal.TabIndex = 5;
            // 
            // label_GastoDestino
            // 
            this.label_GastoDestino.AutoSize = true;
            this.label_GastoDestino.Location = new System.Drawing.Point(196, 65);
            this.label_GastoDestino.Name = "label_GastoDestino";
            this.label_GastoDestino.Size = new System.Drawing.Size(0, 16);
            this.label_GastoDestino.TabIndex = 4;
            // 
            // label_GastoTransporte
            // 
            this.label_GastoTransporte.AutoSize = true;
            this.label_GastoTransporte.Location = new System.Drawing.Point(196, 32);
            this.label_GastoTransporte.Name = "label_GastoTransporte";
            this.label_GastoTransporte.Size = new System.Drawing.Size(0, 16);
            this.label_GastoTransporte.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gasto com Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gasto Transporte:";
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Location = new System.Drawing.Point(156, 144);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(287, 21);
            this.comboBox_destino.TabIndex = 14;
            // 
            // Agencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 351);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.groupBox_Resultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_CalcularViagem);
            this.Controls.Add(this.button_Calculadora);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.textBox_DataEmbarque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agencia";
            this.Text = "Agencia de Viagens";
            this.Load += new System.EventHandler(this.Agencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Resultado.ResumeLayout(false);
            this.groupBox_Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DataEmbarque;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Button button_Calculadora;
        private System.Windows.Forms.Button button_CalcularViagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_Resultado;
        private System.Windows.Forms.TextBox textBox_ValorTotal;
        private System.Windows.Forms.Label label_GastoDestino;
        private System.Windows.Forms.Label label_GastoTransporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_aviao;
        private System.Windows.Forms.RadioButton radioButton_onibus;
        private System.Windows.Forms.ComboBox comboBox_destino;
    }
}

