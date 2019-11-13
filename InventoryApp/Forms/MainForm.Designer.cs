namespace InventoryApp.Forms
{
    partial class MainForm
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
            this.listProducts = new System.Windows.Forms.Button();
            this.ListParts = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listProducts
            // 
            this.listProducts.Location = new System.Drawing.Point(302, 102);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(210, 66);
            this.listProducts.TabIndex = 0;
            this.listProducts.Text = "Products";
            this.listProducts.UseVisualStyleBackColor = true;
            this.listProducts.Click += new System.EventHandler(this.listProducts_Click);
            // 
            // ListParts
            // 
            this.ListParts.Location = new System.Drawing.Point(302, 174);
            this.ListParts.Name = "ListParts";
            this.ListParts.Size = new System.Drawing.Size(209, 64);
            this.ListParts.TabIndex = 1;
            this.ListParts.Text = "Parts";
            this.ListParts.UseVisualStyleBackColor = true;
            this.ListParts.Click += new System.EventHandler(this.ListParts_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory Management";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListParts);
            this.Controls.Add(this.listProducts);
            this.Name = "MainForm";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listProducts;
        private System.Windows.Forms.Button ListParts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

