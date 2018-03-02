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
    public partial class frmPrograma07 : Form
    {
        List<int> A = new List<int>();
        double[] V = new double[50];
        public frmPrograma07()
        {
            InitializeComponent();
        }

        private void cboA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cboA.Items.Add(cboA.Text);
                A.Add(int.Parse(cboA.Text));
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int emay = 0, emen = 100;
            double med = 0, vari = 0, desv = 0;

            emay= Mayor(emay);
            emen=Menor(emen);
            med = Media(med);
            vari = Varianza(med);
            desv = Desviacion(vari);


            lblResultado.Text = "Elemento mayor:" + emay.ToString() + "\n\r" + "Elemento menor: " + emen.ToString();
            lblResultado.Text += "\n\rLa media es: " + med.ToString();
            lblResultado.Text += "\n\rLa varianza es: " + vari.ToString();
            lblResultado.Text += "\n\rLa desviacion es: " + desv.ToString();
        }

        public int Mayor(int x)
        {
            foreach(int val in A)
            {
                if(val>x)
                {
                    x = val;
                }
            }
            return x;
        }
        public int Menor(int x)
        {
            foreach (int val in A)
            {
                if (val <x)
                {
                    x = val;
                }
            }
            return x;
        }
        public double Media(double x)
        {
            double suma=0,total=0;
            foreach (int val in A)
            {
                total++;
                suma += val;
                x = suma / total;
            }
            return x;
        }
        public double Varianza(double x)
        {
            int contador=0;
            double tmp=0,fin=0;
            foreach(int val in A)
            {
                V[contador]=val;
                contador++;
            }
            for (int i=0;i<contador;i++)
            {
                tmp = Math.Pow((V[i] - x),2);
                fin += tmp;
            }
            fin = fin / contador;
            return fin;
        }
        public double Desviacion(double x)
        {
            double z;
            z = Math.Sqrt(x);
            return z;
        }
    }
}
