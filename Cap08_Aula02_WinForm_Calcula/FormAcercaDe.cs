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
    public partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para fechar esta form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();    //Encerra a Form
        }
    }
}
