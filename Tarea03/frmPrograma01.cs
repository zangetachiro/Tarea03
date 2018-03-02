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
    public partial class frmPrograma01 : Form
    {
        // Arreglo con 50 valores constantes
        int[] valores = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55,
                          10, 15, 20, 25, 30, 35, 40, 45, 50, 55,
                          10, 15, 20, 25, 30, 35, 40, 45, 50, 55,
                          10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };

        public frmPrograma01()
        {
            InitializeComponent();
        }

     

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Calculamos el promedio del arreglo
            // y lo mostramos en la etiqueta respectiva
            double promedio = valores.Average();
            lblPromedio.Text = promedio.ToString();

            // Determinar valores mayores del promedio 
            // y mostrar esos valores mayores al promedio
            int cuantos = 0;
            lblValoresMayores.Text = "";
            for (int i = 0; i < valores.Length; i++)
                if (valores[i] > promedio)
                {
                    cuantos++;
                    lblValoresMayores.Text += valores[i].ToString() + ",";
                }
            lblMayores.Text = cuantos.ToString();
        }

        private void frmPrograma01_Load(object sender, EventArgs e)
        {
            // Mostramos los valores en la etiqueta cada vez que inicia el programa

            lblValores.Text = "";

            // Recorremos cada elemento del arreglo
            // y lo agregamos a la etiqueta

            foreach (int val in valores)
                lblValores.Text += val.ToString() + ", ";
        }
    }
}
