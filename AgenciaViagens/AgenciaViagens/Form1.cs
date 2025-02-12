using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//Chamar a calculadora

namespace AgenciaViagens
{
    public partial class Agencia : Form
    {
        public Agencia()
        {
            InitializeComponent();
        }
        //Botão Limpar
        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_nome.Text = ""; // ou
            //textBox_nome.Clear();
            //textBox_nome.Text = string.Empty; 
            comboBox_destino.Text = "";
            textBox_DataEmbarque.Text = "";
            label_GastoDestino.Text = "";
            textBox_ValorTotal.Text = "";
            label_GastoTransporte.Text = "";

            //Radio button checado
            radioButton_aviao.Checked = false;// ou true
            radioButton_onibus.Checked = false;

            /*Caso possuir muitos Textbox ou outro*/
            //foreach (Control caixatexto in this.Controls)
            // {
            //    if (caixatexto is TextBox)
            //    {
            //        caixatexto.Text = "";
            //    }
            //}
        }

        private void button_Calculadora_Click(object sender, EventArgs e)
        {
            //using System.Diagnostics;
            Process.Start(@"C:\Windows\System32\calc.exe");// Chamar a calculadora

        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite o nome");
                textBox_nome.Focus();
            }
            if (comboBox_destino.Text == "")
            {
                MessageBox.Show("Destino não escolhido");
                comboBox_destino.Focus();
            }
            if (radioButton_aviao.Checked == false && radioButton_onibus.Checked == false)
            {
                MessageBox.Show("Meio de transporte não escolhido");
                radioButton_onibus.Focus();
            }

        }

        private void button_CalcularViagem_Click(object sender, EventArgs e)
        {
            float gasto_destino, gasto_transporte, gasto_total;
            switch (comboBox_destino.Text.ToUpper())
            {
                case "SP":
                    gasto_destino = 1000f;
                    break;
                case "RJ":
                    gasto_destino = 1500f;
                    break;
                case "SC":
                    gasto_destino = 2000f;
                    break;
                default:
                    gasto_destino = 1000.0f;
                    break;
            }
            if (radioButton_aviao.Checked == true)
                gasto_transporte = 100f;
            else
                gasto_transporte = 30f;
            gasto_total = gasto_transporte + gasto_destino;
            this.ClientSize = new System.Drawing.Size(725, 350);
            groupBox_Resultado.Visible = true;
            label_GastoDestino.Text = gasto_destino.ToString("C2");
            label_GastoTransporte.Text = gasto_transporte.ToString("C2");
            textBox_ValorTotal.Text = gasto_total.ToString("C2");
        }
        //Load - Dois click 
        private void Agencia_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(725, 350);
            radioButton_aviao.Checked = true;

        }
        //Evento Leave
        private void textBox_nome_Leave(object sender, EventArgs e)
        {
            textBox_nome.Text = textBox_nome.Text.ToUpper();
            comboBox_destino.Text = comboBox_destino.Text.ToUpper();
        }
    }
}
