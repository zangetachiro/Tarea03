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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void programa1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crear una instancia de la clase
            frmPrograma01 frm = new frmPrograma01();
            frm.MdiParent=this;
            frm.Show();
        }

        private void programa2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrograma02 frm = new frmPrograma02();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proggrama3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrograma03 frm = new frmPrograma03();
            frm.MdiParent = this;
            frm.Show();
        }

        private void programa4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrograma04 frm = new frmPrograma04();
            frm.MdiParent = this;
            frm.Show();
        }

        private void programa5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrograma05 frm = new frmPrograma05();
            frm.MdiParent = this;
            frm.Show();
        }

        private void programa6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrograma06 frm = new frmPrograma06();
            frm.MdiParent = this;
            frm.Show();
        }

        private void programa7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrograma07 frm = new frmPrograma07();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
