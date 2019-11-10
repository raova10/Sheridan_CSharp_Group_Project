﻿using System;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            ShowEditProductForm();

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            btnEdit.Enabled = true;
        }

        private void ShowEditProductForm() {
            FormProductEdit frmEditProduct = new FormProductEdit();
            frmEditProduct.txtProductName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            frmEditProduct.txtProductCategory.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            frmEditProduct.txtProductDesc.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
            frmEditProduct.txtProductMfg.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            frmEditProduct.txtQOH.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            frmEditProduct.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            ShowEditProductForm();
        }
    }
}
