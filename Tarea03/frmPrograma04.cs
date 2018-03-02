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
    public partial class frmPrograma04 : Form
    {
        Random numeroAleatorio = new Random();
        int[] original = new int[20];
        public frmPrograma04()
        {
            InitializeComponent();
        }

        private void frmPrograma04_Load(object sender, EventArgs e)
        {
            lblOriginal.Text = "";
            for (int i = 0; i < original.Length; i++)
            {
                int numero = numeroAleatorio.Next(-100, 100);
                original[i] = numero;
                lblOriginal.Text += original[i].ToString() + ", ";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lblCeros.Text = "0";
            lblNegativos.Text = "0";
            lblPositivos.Text = "0";
            lblSumNeg.Text = "0";
            lblSumPos.Text = "0";

            int ceros = 0, negativos = 0, positivos = 0, sumneg = 0, sumpos = 0;
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == 0)
                {
                    ceros++;
                    lblCeros.Text = ceros.ToString();
                }
                if (original[i] < 0)
                {
                    negativos++;
                    sumneg += original[i];
                    lblNegativos.Text = negativos.ToString();
                    lblSumNeg.Text = sumneg.ToString();
                }
                if (original[i] > 0)
                {
                    positivos++;
                    sumpos += original[i];
                    lblPositivos.Text = positivos.ToString();
                    lblSumPos.Text = sumpos.ToString();
                }
            }
        }
    }
}
