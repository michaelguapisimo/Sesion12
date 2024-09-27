using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesion12.model;

namespace Sesion12
{
    public partial class Form1 : Form
    {
        List<product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<product>();
        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.Id = int.Parse(tbid.Text);
            product.Name = tbname.Text;
            product.Description = tbdescripcion.Text;
            product.price = double.Parse(tbprice.Text);
            products.Add(product);
            showData();
            clearText();
        }
        private void showData()
        {
            dgvproducts.DataSource = null;
            dgvproducts.DataSource = products;
        }
        private void clearText()
        {
            tbid.Clear();
            tbname.Clear();
            tbdescripcion.Clear();
            tbprice.Clear();
            tbid.Focus();
        }

    }
}
