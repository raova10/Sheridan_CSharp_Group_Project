﻿namespace InventoryApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProducts
            // 
            this.listProducts.Location = new System.Drawing.Point(302, 237);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(210, 55);
            this.listProducts.TabIndex = 0;
            this.listProducts.Text = "List Products";
            this.listProducts.UseVisualStyleBackColor = true;
            this.listProducts.Click += new System.EventHandler(this.listProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listProducts;
    }
}
