namespace InventoryApp {
    partial class FormProductEdit {
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductMfg = new System.Windows.Forms.Label();
            this.lblQOH = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.txtProductMfg = new System.Windows.Forms.TextBox();
            this.txtQOH = new System.Windows.Forms.TextBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.prodSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(63, 80);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(63, 134);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(89, 13);
            this.lblProductCategory.TabIndex = 1;
            this.lblProductCategory.Text = "Product Category";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Location = new System.Drawing.Point(63, 188);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(100, 13);
            this.lblProductDesc.TabIndex = 2;
            this.lblProductDesc.Text = "Product Description";
            // 
            // lblProductMfg
            // 
            this.lblProductMfg.AutoSize = true;
            this.lblProductMfg.Location = new System.Drawing.Point(63, 242);
            this.lblProductMfg.Name = "lblProductMfg";
            this.lblProductMfg.Size = new System.Drawing.Size(110, 13);
            this.lblProductMfg.TabIndex = 3;
            this.lblProductMfg.Text = "Product Manufacturer";
            // 
            // lblQOH
            // 
            this.lblQOH.AutoSize = true;
            this.lblQOH.Location = new System.Drawing.Point(63, 296);
            this.lblQOH.Name = "lblQOH";
            this.lblQOH.Size = new System.Drawing.Size(92, 13);
            this.lblQOH.TabIndex = 4;
            this.lblQOH.Text = "Quantity On Hand";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(199, 77);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(240, 20);
            this.txtProductName.TabIndex = 5;
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(199, 121);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(240, 20);
            this.txtProductCategory.TabIndex = 6;
            // 
            // txtProductMfg
            // 
            this.txtProductMfg.Location = new System.Drawing.Point(199, 254);
            this.txtProductMfg.Name = "txtProductMfg";
            this.txtProductMfg.Size = new System.Drawing.Size(240, 20);
            this.txtProductMfg.TabIndex = 7;
            // 
            // txtQOH
            // 
            this.txtQOH.Location = new System.Drawing.Point(199, 298);
            this.txtQOH.Name = "txtQOH";
            this.txtQOH.Size = new System.Drawing.Size(52, 20);
            this.txtQOH.TabIndex = 8;
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(199, 165);
            this.txtProductDesc.Multiline = true;
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(240, 65);
            this.txtProductDesc.TabIndex = 9;
            // 
            // prodSaveBtn
            // 
            this.prodSaveBtn.Location = new System.Drawing.Point(415, 359);
            this.prodSaveBtn.Name = "prodSaveBtn";
            this.prodSaveBtn.Size = new System.Drawing.Size(107, 38);
            this.prodSaveBtn.TabIndex = 10;
            this.prodSaveBtn.Text = "Save";
            this.prodSaveBtn.UseVisualStyleBackColor = true;
            this.prodSaveBtn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 409);
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
            this.Name = "FormProductEdit";
            this.Text = "Product Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductMfg;
        private System.Windows.Forms.Label lblQOH;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtProductCategory;
        public System.Windows.Forms.TextBox txtProductMfg;
        public System.Windows.Forms.TextBox txtQOH;
        public System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.Button prodSaveBtn;
    }
}