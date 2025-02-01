using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        private void label_imc_Click(object sender, EventArgs e)
        {

        }
        */
        private void button_Sair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Saír? ", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            float altura, peso, imc;
            altura = float.Parse(textBox_Altura.Text);
            peso = float.Parse(textBox_Peso.Text);
            imc = (peso * 100 * 100) / (altura * altura);

            if (imc < 18.5) { label_situacao.Text = "Abaixo do Peso"; }
            else if (imc < 25) { label_situacao.Text = "Peso Ideal"; }
            else if (imc < 30) { label_situacao.Text = "Acima do Peso"; }
            else if (imc < 35) { label_situacao.Text = "Obesidade Grau I"; }
            else if (imc < 40) { label_situacao.Text = "Obesidade Grau II"; }
            else { label_situacao.Text = "Obesidade Grau III"; }

            label_resultado_imc.Text = imc.ToString();
        }
    }
}
