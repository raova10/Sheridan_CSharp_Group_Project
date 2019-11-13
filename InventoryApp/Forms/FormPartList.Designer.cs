namespace InventoryApp.Forms
{
    partial class FormPartList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button addPartBtn;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partQuantityOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryAppDataSet = new InventoryApp.InventoryAppDataSet();
            addPartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartBtn
            // 
            addPartBtn.Location = new System.Drawing.Point(604, 24);
            addPartBtn.Name = "addPartBtn";
            addPartBtn.Size = new System.Drawing.Size(122, 44);
            addPartBtn.TabIndex = 1;
            addPartBtn.Text = "Add Part";
            addPartBtn.UseVisualStyleBackColor = true;
            addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.partDescDataGridViewTextBoxColumn,
            this.partQuantityOnHandDataGridViewTextBoxColumn,
            this.partManufacturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "PartName";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            // 
            // partDescDataGridViewTextBoxColumn
            // 
            this.partDescDataGridViewTextBoxColumn.DataPropertyName = "PartDesc";
            this.partDescDataGridViewTextBoxColumn.HeaderText = "PartDesc";
            this.partDescDataGridViewTextBoxColumn.Name = "partDescDataGridViewTextBoxColumn";
            // 
            // partQuantityOnHandDataGridViewTextBoxColumn
            // 
            this.partQuantityOnHandDataGridViewTextBoxColumn.DataPropertyName = "PartQuantityOnHand";
            this.partQuantityOnHandDataGridViewTextBoxColumn.HeaderText = "PartQuantityOnHand";
            this.partQuantityOnHandDataGridViewTextBoxColumn.Name = "partQuantityOnHandDataGridViewTextBoxColumn";
            // 
            // partManufacturerDataGridViewTextBoxColumn
            // 
            this.partManufacturerDataGridViewTextBoxColumn.DataPropertyName = "PartManufacturer";
            this.partManufacturerDataGridViewTextBoxColumn.HeaderText = "PartManufacturer";
            this.partManufacturerDataGridViewTextBoxColumn.Name = "partManufacturerDataGridViewTextBoxColumn";
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.inventoryAppDataSet;
            // 
            // inventoryAppDataSet
            // 
            this.inventoryAppDataSet.DataSetName = "InventoryAppDataSet";
            this.inventoryAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormPartList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(addPartBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPartList";
            this.RightToLeftLayout = true;
            this.Text = "Part List";
            this.Load += new System.EventHandler(this.FormPartList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryAppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partQuantityOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partBindingSource;
        private InventoryAppDataSet inventoryAppDataSet;
    }
}