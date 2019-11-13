namespace InventoryApp.Forms
{
    partial class FormAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prodSaveBtn = new System.Windows.Forms.Button();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.txtQOH = new System.Windows.Forms.TextBox();
            this.txtProductMfg = new System.Windows.Forms.TextBox();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblQOH = new System.Windows.Forms.Label();
            this.lblProductMfg = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prodSaveBtn
            // 
            this.prodSaveBtn.Location = new System.Drawing.Point(307, 341);
            this.prodSaveBtn.Name = "prodSaveBtn";
            this.prodSaveBtn.Size = new System.Drawing.Size(107, 38);
            this.prodSaveBtn.TabIndex = 21;
            this.prodSaveBtn.Text = "Add Product";
            this.prodSaveBtn.UseVisualStyleBackColor = true;
            this.prodSaveBtn.Click += new System.EventHandler(this.ProdSaveBtn_Click);
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(307, 153);
            this.txtProductDesc.Multiline = true;
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(240, 65);
            this.txtProductDesc.TabIndex = 20;
            // 
            // txtQOH
            // 
            this.txtQOH.Location = new System.Drawing.Point(307, 286);
            this.txtQOH.Name = "txtQOH";
            this.txtQOH.Size = new System.Drawing.Size(52, 20);
            this.txtQOH.TabIndex = 19;
            // 
            // txtProductMfg
            // 
            this.txtProductMfg.Location = new System.Drawing.Point(307, 242);
            this.txtProductMfg.Name = "txtProductMfg";
            this.txtProductMfg.Size = new System.Drawing.Size(240, 20);
            this.txtProductMfg.TabIndex = 18;
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(307, 109);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(240, 20);
            this.txtProductCategory.TabIndex = 17;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(307, 65);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(240, 20);
            this.txtProductName.TabIndex = 16;
            // 
            // lblQOH
            // 
            this.lblQOH.AutoSize = true;
            this.lblQOH.Location = new System.Drawing.Point(171, 284);
            this.lblQOH.Name = "lblQOH";
            this.lblQOH.Size = new System.Drawing.Size(92, 13);
            this.lblQOH.TabIndex = 15;
            this.lblQOH.Text = "Quantity On Hand";
            // 
            // lblProductMfg
            // 
            this.lblProductMfg.AutoSize = true;
            this.lblProductMfg.Location = new System.Drawing.Point(171, 230);
            this.lblProductMfg.Name = "lblProductMfg";
            this.lblProductMfg.Size = new System.Drawing.Size(110, 13);
            this.lblProductMfg.TabIndex = 14;
            this.lblProductMfg.Text = "Product Manufacturer";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(171, 176);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(100, 13);
            this.lblProductDesc.TabIndex = 13;
            this.lblProductDesc.Text = "Product Description";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(171, 122);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(89, 13);
            this.lblProductCategory.TabIndex = 12;
            this.lblProductCategory.Text = "Product Category";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(171, 68);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 11;
            this.lblProductName.Text = "Product Name";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.prodSaveBtn);
            this.Controls.Add(this.txtProductDesc);
            this.Controls.Add(this.txtQOH);
            this.Controls.Add(this.txtProductMfg);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblQOH);
            this.Controls.Add(this.lblProductMfg);
            this.Controls.Add(this.lblProductDesc);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.lblProductName);
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prodSaveBtn;
        public System.Windows.Forms.TextBox txtProductDesc;
        public System.Windows.Forms.TextBox txtQOH;
        public System.Windows.Forms.TextBox txtProductMfg;
        public System.Windows.Forms.TextBox txtProductCategory;
        public System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblQOH;
        private System.Windows.Forms.Label lblProductMfg;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductName;
    }
}