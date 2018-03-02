using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea03
{
    public partial class frmPrograma03 : Form
    {
        Random numeroAleatorio = new Random();
        int[] original= new int[20];
        int[] resultante = new int[20];
        public frmPrograma03()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lblResultante.Text = "";
            for (int i = 0; i < resultante.Length; i++)
            {
                resultante[i] = original[i] * original[i] * original[i];
                lblResultante.Text += resultante[i].ToString() + ", ";
            }
        }

        private void frmPrograma03_Load(object sender, EventArgs e)
        {
            lblOriginal.Text = "";
            for (int i = 0; i < original.Length; i++)
            {
                int numero = numeroAleatorio.Next(1, 100);
                original[i] = numero;
                lblOriginal.Text += original[i].ToString() + ", ";
            }
        }
    }
}
