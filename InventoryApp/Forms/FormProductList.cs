using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp {
    public partial class FormProductList : Form {
        public FormProductList() {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'inventoryAppDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventoryAppDataSet.Product);

        }

        private void btnSave_Click(object sender, EventArgs e) {
            productTableAdapter.Update(inventoryAppDataSet);
            this.Close();
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            inventoryAppDataSet.RejectChanges();
            this.Close();
        }
    }
}
