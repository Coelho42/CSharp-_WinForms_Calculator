using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Aula02_WinForm_Calcula
{
    public partial class FormPrincipal : Form
    {
        #region Atributos

        string parcela1;
        string operation;
        double resultado;

        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Números

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "0";
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "1";
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "2";
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "3";
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "4";
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "5";
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "6";
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "7";
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "8";
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "9";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + ",";
        }

        #endregion

        #region Operadores

        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                MessageBox.Show("Nabo não tens nada no display para operar");
            }
            else
            {
                parcela1 = textBoxDisplay.Text;
                textBoxDisplay.Text = "";
                operation = "+";
                labelOperações.Text = parcela1 + " " + operation;
            }
        }

        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                MessageBox.Show("Nabo não tens nada no display para operar");
            }
            else
            {
                parcela1 = textBoxDisplay.Text;
                textBoxDisplay.Text = "";
                operation = "-";
                labelOperações.Text = parcela1 + " " + operation;
            }
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                MessageBox.Show("Nabo não tens nada no display para operar");
            }
            else
            {
                parcela1 = textBoxDisplay.Text;
                textBoxDisplay.Text = "";
                operation = "*";
                labelOperações.Text = parcela1 + " " + operation;
            }
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                MessageBox.Show("Nabo não tens nada no display para operar");
            }
            else
            {
                parcela1 = textBoxDisplay.Text;
                textBoxDisplay.Text = "";
                operation = "/";
                labelOperações.Text = parcela1 + " " + operation;
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "")
            {
                MessageBox.Show("Nabo não tens nada no display para operar");
            }
            else
            {
                // Se tiver sinal no operation
                // Se tiver valor em parcela1
                // Se tiver valor no display -----> então posso fazer a operação
                switch (operation)
                {
                    case "+":
                        resultado = Convert.ToDouble(parcela1) + Convert.ToDouble(textBoxDisplay.Text);
                        textBoxDisplay.Text = resultado.ToString();
                        parcela1 = null;
                        break;

                    case "-":
                        resultado = Convert.ToDouble(parcela1) - Convert.ToDouble(textBoxDisplay.Text);
                        textBoxDisplay.Text = resultado.ToString();
                        parcela1 = null;
                        break;

                    case "*":
                        resultado = Convert.ToDouble(parcela1) * Convert.ToDouble(textBoxDisplay.Text);
                        textBoxDisplay.Text = resultado.ToString();
                        parcela1 = null;
                        break;

                    case "/":
                        resultado = Convert.ToDouble(parcela1) / Convert.ToDouble(textBoxDisplay.Text);
                        textBoxDisplay.Text = resultado.ToString();
                        parcela1 = null;
                        break;
                }
            }
        }

        #endregion

        #region Clears

        private void buttonClear_Click(object sender, EventArgs e)
        {
            parcela1 = null;
            operation = null;
            labelOperações.Text = null;
            textBoxDisplay.Clear();
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int tamanho = textBoxDisplay.TextLength - 1;
            string numeros = textBoxDisplay.Text;
            textBoxDisplay.Clear();
            for (int i = 0; i < tamanho; i++)
            {
                textBoxDisplay.Text = textBoxDisplay.Text + numeros[i];
            }
        }

        #endregion

        #region Files

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void básicoToolStripMenuItemFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicas-te no ménu File, opção Básico");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cientificoToolStripMenuItemFileCiêntifico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicas-te no ménu File, opção Ciêntífica");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void básicoToolStripMenuItemFileAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicas-te no ménu Help, opção Acerca de...");
        }

        #endregion
   
    }
}