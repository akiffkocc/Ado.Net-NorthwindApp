using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeli_WinForm
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesFrom form = new CategoriesFrom();
            form.WindowState|= FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
        }

        private void personelExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelExcelForm pef = new PersonelExcelForm();
            pef.WindowState|= FormWindowState.Maximized;
            pef.MdiParent = this;
            pef.Show();
        }
    }
}
