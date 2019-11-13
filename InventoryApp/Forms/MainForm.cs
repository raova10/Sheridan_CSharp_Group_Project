using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.Forms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void listProducts_Click(object sender, EventArgs e) {
            FormProductList frmProdList = new FormProductList();
            frmProdList.Show();
        }

        private void ListParts_Click(object sender, EventArgs e)
        {
            FormPartList frmPartList = new FormPartList();
            frmPartList.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
