using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenGIT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btBlau_Click(object sender, EventArgs e)
        {
            FrmBlau frm = new FrmBlau();
            frm.Show();
        }

        private void btVerd_Click(object sender, EventArgs e)
        {
            FrmVerd frm = new FrmVerd();
            frm.Show();
        }
    }
}
