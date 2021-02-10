
namespace AdoNetDemo
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblAddName = new System.Windows.Forms.Label();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.tbxAddStockAmount = new System.Windows.Forms.TextBox();
            this.lblAddStockAmount = new System.Windows.Forms.Label();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateStockamount = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(22, 39);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(762, 205);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(50, 32);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(35, 13);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Name";
            // 
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(159, 25);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(100, 20);
            this.tbxAddName.TabIndex = 2;
            // 
            // tbxAddStockAmount
            // 
            this.tbxAddStockAmount.Location = new System.Drawing.Point(159, 122);
            this.tbxAddStockAmount.Name = "tbxAddStockAmount";
            this.tbxAddStockAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxAddStockAmount.TabIndex = 4;
            // 
            // lblAddStockAmount
            // 
            this.lblAddStockAmount.AutoSize = true;
            this.lblAddStockAmount.Location = new System.Drawing.Point(50, 129);
            this.lblAddStockAmount.Name = "lblAddStockAmount";
            this.lblAddStockAmount.Size = new System.Drawing.Size(71, 13);
            this.lblAddStockAmount.TabIndex = 3;
            this.lblAddStockAmount.Text = "StockAmount";
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(159, 73);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxAddUnitPrice.TabIndex = 6;
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(50, 80);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblAddUnitPrice.TabIndex = 5;
            this.lblAddUnitPrice.Text = "UnitPrice";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxAddStockAmount);
            this.gbxAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxAdd.Controls.Add(this.lblAddName);
            this.gbxAdd.Controls.Add(this.lblAddUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxAddName);
            this.gbxAdd.Controls.Add(this.lblAddStockAmount);
            this.gbxAdd.Location = new System.Drawing.Point(22, 275);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(350, 174);
            this.gbxAdd.TabIndex = 7;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateName);
            this.gbxUpdate.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.tbxUpdateName);
            this.gbxUpdate.Controls.Add(this.lblUpdateStockamount);
            this.gbxUpdate.Location = new System.Drawing.Point(422, 275);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(350, 174);
            this.gbxUpdate.TabIndex = 8;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(265, 129);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(159, 122);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateStockAmount.TabIndex = 4;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(159, 73);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateUnitPrice.TabIndex = 6;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(50, 32);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateName.TabIndex = 1;
            this.lblUpdateName.Text = "Name";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(50, 80);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblUpdateUnitPrice.TabIndex = 5;
            this.lblUpdateUnitPrice.Text = "UnitPrice";
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(159, 25);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateName.TabIndex = 2;
            // 
            // lblUpdateStockamount
            // 
            this.lblUpdateStockamount.AutoSize = true;
            this.lblUpdateStockamount.Location = new System.Drawing.Point(50, 129);
            this.lblUpdateStockamount.Name = "lblUpdateStockamount";
            this.lblUpdateStockamount.Size = new System.Drawing.Size(71, 13);
            this.lblUpdateStockamount.TabIndex = 3;
            this.lblUpdateStockamount.Text = "StockAmount";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(709, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.TextBox tbxAddStockAmount;
        private System.Windows.Forms.Label lblAddStockAmount;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label lblUpdateStockamount;
        private System.Windows.Forms.Button btnRemove;
    }
}

