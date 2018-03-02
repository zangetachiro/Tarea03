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
    public partial class frmPrograma06 : Form
    {
        List<int> A = new List<int>();
        List<int> B = new List<int>();
        List<int> C = new List<int>();
        public frmPrograma06()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Detectamos ucando se presiona Enter (ascii 13)
            if (e.KeyChar==13)
            {
                // Agregamos a la lista del combo
                cboA.Items.Add(cboA.Text);
                //Agregamos a arreglo en memoria lo que teclo el usuario
                A.Add(int.Parse(cboA.Text));

            }
        }

        private void cboB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Detectamos ucando se presiona Enter (ascii 13)
            if (e.KeyChar == 13)
            {
                // Agregamos a la lista del combo
                cboB.Items.Add(cboB.Text);
                //Agregamos a arreglo en memoria lo que teclo el usuario
                B.Add(int.Parse(cboB.Text));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tam = A.Count;

            for (int i = 0, j = tam-1; i < tam;i++,j--)
            {
                C.Add(A[i]*B[j]);
            }
            foreach(int val in C)
            {
                lblC.Text += val.ToString() + "\n\r";

            }
        }
    }
}
