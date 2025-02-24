using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1- Faça um programa que: -Leia a cotação do dólar - Leia um valor em dólares - Converta esse valor para Real -Mostre o resultado

            try
            {
                double cotacaoDolar = Convert.ToDouble(txt_cotacao.Text);
                double valorDolar = Convert.ToDouble(txt_valor.Text);

                double valorReal = valorDolar * cotacaoDolar;

                lbl_resultado.Text = $"O valor de {valorDolar} dólares equivale a {valorReal} reais.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, insira valores válidos para a cotação e o valor em dólares.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
