using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.InfoForm f = new Users.InfoForm();
            f.MdiParent = this;
            f.Show();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products.AddForm f = new Products.AddForm();
            f.MdiParent = this;
            f.Show();
        }
    }
}
