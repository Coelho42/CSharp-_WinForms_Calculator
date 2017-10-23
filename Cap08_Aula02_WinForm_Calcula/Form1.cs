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

        #endregion
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {

        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            if(textBoxDisplay.Text == "")
            {
                MessageBox.Show("Nabo não tens nada no display para operar");
            }
            else
            {
                parcela1 = textBoxDisplay.Text;
                textBoxDisplay.Text = "";
                operation = "+";
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            // Se tiver sinal no operation
            // Se tiver valor em parcela1
            // Se tiver valor no display -----> então posso fazer a operação

            if(operation!= "" && parcela1 != "" && textBoxDisplay.Text != "")
            {
                // Converte para double as string parcela1, display e SOMA
                double resultado = Convert.ToDouble(parcela1) + Convert.ToDouble(textBoxDisplay.Text);

                // Coloca no display o resultado convertido para string 
                textBoxDisplay.Text = resultado.ToString();
            }
        }

        private void básicoToolStripMenuItemFile_Click(object sender, EventArgs e)
        {

        }

        private void cientificoToolStripMenuItemFileCiêntifico_Click(object sender, EventArgs e)
        {

        }

        private void básicoToolStripMenuItemFileAcercaDe_Click(object sender, EventArgs e)
        {

        }
    }
}
