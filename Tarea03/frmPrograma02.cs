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
    public partial class frmPrograma02 : Form
    {
        // Declaramos y reservamos memoria para tres arreglos
        // cada arreglo con 15 elementos, vacios

        int[] A = new int[15];
        int[] B = new int[15];
        int[] C = new int[15];


        public frmPrograma02()
        {
            InitializeComponent();
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            // Variable de tipo Random para generar numeros aleatorios
            Random aleatorio = new Random();

            // Llenamos los vectores A y B con numeros aleatorios 1,100
            // y vamos mostrando cada elemento generado

            lblVectorA.Text = "";
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = aleatorio.Next(0, 100);
                lblVectorA.Text += A[i].ToString() + ",";
            }

            lblVectorB.Text = "";
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = aleatorio.Next(0, 100);
                lblVectorB.Text += B[i].ToString() + ",";
            }

            lblVectorC.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Sumamos los elementos de A + B y gurdamos en C
            // mostramos el vector C
            lblVectorC.Text = "";
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i] + B[i];
                lblVectorC.Text += C[i].ToString() + ",";
            }
        }

        private void frmPrograma02_Load(object sender, EventArgs e)
        {

        }
    }
}
