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
    public partial class frmPrograma05 : Form
    {
        Random numeroAleatorio = new Random();
        int[] original = new int[15];
        int[] inverso = new int[15];
        public frmPrograma05()
        {
            InitializeComponent();
        }

        private void frmPrograma05_Load(object sender, EventArgs e)
        {
            lblOriginal.Text = "";
            for (int i = 0; i < original.Length; i++)
            {
                int numero = numeroAleatorio.Next(1, 100);
                original[i] = numero;
                lblOriginal.Text += original[i].ToString() + ", ";
            }
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            lblInverso.Text = "";
            for (int i = 0; i < inverso.Length; i++)
            {
                inverso[original.Length - 1 - i] = original[i];
                lblInverso.Text += inverso[i].ToString() + ", ";

            }
        }
    }
}
