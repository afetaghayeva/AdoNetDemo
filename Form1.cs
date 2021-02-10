using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly ProductDal  _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product()
            {
                Name = tbxAddName.Text,
                UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                UnitsInStock = Convert.ToInt32(tbxAddUnitPrice.Text)
            });
            LoadProducts();
            MessageBox.Show("Product Added!!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                tbxUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
                tbxUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
                tbxUpdateStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                UnitsInStock = Convert.ToInt32(tbxUpdateStockAmount.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Product Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted!");
        }
    }
}
