
namespace MilestoneOne
{
    partial class inventorySystemForm
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
            this.buttonAddInventoryItem = new System.Windows.Forms.Button();
            this.buttonRemoveInventoryItem = new System.Windows.Forms.Button();
            this.labelInventoryList = new System.Windows.Forms.Label();
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.displayInventory = new System.Windows.Forms.Button();
            this.indexRemoveTextBox = new System.Windows.Forms.TextBox();
            this.restockIndexTextBox = new System.Windows.Forms.TextBox();
            this.increaseStockButton = new System.Windows.Forms.Button();
            this.amountStockTextBox = new System.Windows.Forms.TextBox();
            this.stockIndexLabel = new System.Windows.Forms.Label();
            this.amountStockLabel = new System.Windows.Forms.Label();
            this.indexRemoveLabel = new System.Windows.Forms.Label();
            this.searchSizeLabel = new System.Windows.Forms.Label();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.searchSizeTextBox = new System.Windows.Forms.TextBox();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.buttonModifyItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddInventoryItem
            // 
            this.buttonAddInventoryItem.Location = new System.Drawing.Point(493, 171);
            this.buttonAddInventoryItem.Name = "buttonAddInventoryItem";
            this.buttonAddInventoryItem.Size = new System.Drawing.Size(111, 35);
            this.buttonAddInventoryItem.TabIndex = 7;
            this.buttonAddInventoryItem.Text = "Add Inventory Item";
            this.buttonAddInventoryItem.UseVisualStyleBackColor = true;
            this.buttonAddInventoryItem.Click += new System.EventHandler(this.buttonAddInventoryItem_Click);
            // 
            // buttonRemoveInventoryItem
            // 
            this.buttonRemoveInventoryItem.Location = new System.Drawing.Point(445, 12);
            this.buttonRemoveInventoryItem.Name = "buttonRemoveInventoryItem";
            this.buttonRemoveInventoryItem.Size = new System.Drawing.Size(135, 35);
            this.buttonRemoveInventoryItem.TabIndex = 8;
            this.buttonRemoveInventoryItem.Text = "Remove Inventory Item";
            this.buttonRemoveInventoryItem.UseVisualStyleBackColor = true;
            this.buttonRemoveInventoryItem.Click += new System.EventHandler(this.buttonRemoveInventoryItem_Click);
            // 
            // labelInventoryList
            // 
            this.labelInventoryList.AutoSize = true;
            this.labelInventoryList.Location = new System.Drawing.Point(9, 197);
            this.labelInventoryList.Name = "labelInventoryList";
            this.labelInventoryList.Size = new System.Drawing.Size(54, 13);
            this.labelInventoryList.TabIndex = 17;
            this.labelInventoryList.Text = "Inventory:";
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(12, 213);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(710, 225);
            this.inventoryListBox.TabIndex = 18;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // displayInventory
            // 
            this.displayInventory.Location = new System.Drawing.Point(610, 171);
            this.displayInventory.Name = "displayInventory";
            this.displayInventory.Size = new System.Drawing.Size(111, 36);
            this.displayInventory.TabIndex = 19;
            this.displayInventory.Text = "Display Inventory:";
            this.displayInventory.UseVisualStyleBackColor = true;
            this.displayInventory.Click += new System.EventHandler(this.displayInventory_Click);
            // 
            // indexRemoveTextBox
            // 
            this.indexRemoveTextBox.Location = new System.Drawing.Point(445, 69);
            this.indexRemoveTextBox.Name = "indexRemoveTextBox";
            this.indexRemoveTextBox.Size = new System.Drawing.Size(135, 20);
            this.indexRemoveTextBox.TabIndex = 20;
            // 
            // restockIndexTextBox
            // 
            this.restockIndexTextBox.Location = new System.Drawing.Point(586, 69);
            this.restockIndexTextBox.Name = "restockIndexTextBox";
            this.restockIndexTextBox.Size = new System.Drawing.Size(135, 20);
            this.restockIndexTextBox.TabIndex = 22;
            // 
            // increaseStockButton
            // 
            this.increaseStockButton.Location = new System.Drawing.Point(586, 12);
            this.increaseStockButton.Name = "increaseStockButton";
            this.increaseStockButton.Size = new System.Drawing.Size(135, 35);
            this.increaseStockButton.TabIndex = 21;
            this.increaseStockButton.Text = "Increase Stock";
            this.increaseStockButton.UseVisualStyleBackColor = true;
            this.increaseStockButton.Click += new System.EventHandler(this.increaseStockButton_Click);
            // 
            // amountStockTextBox
            // 
            this.amountStockTextBox.Location = new System.Drawing.Point(586, 112);
            this.amountStockTextBox.Name = "amountStockTextBox";
            this.amountStockTextBox.Size = new System.Drawing.Size(135, 20);
            this.amountStockTextBox.TabIndex = 23;
            // 
            // stockIndexLabel
            // 
            this.stockIndexLabel.AutoSize = true;
            this.stockIndexLabel.Location = new System.Drawing.Point(586, 53);
            this.stockIndexLabel.Name = "stockIndexLabel";
            this.stockIndexLabel.Size = new System.Drawing.Size(77, 13);
            this.stockIndexLabel.TabIndex = 24;
            this.stockIndexLabel.Text = "Index of stock:";
            // 
            // amountStockLabel
            // 
            this.amountStockLabel.AutoSize = true;
            this.amountStockLabel.Location = new System.Drawing.Point(586, 95);
            this.amountStockLabel.Name = "amountStockLabel";
            this.amountStockLabel.Size = new System.Drawing.Size(101, 13);
            this.amountStockLabel.TabIndex = 25;
            this.amountStockLabel.Text = "Amount to increase:";
            // 
            // indexRemoveLabel
            // 
            this.indexRemoveLabel.AutoSize = true;
            this.indexRemoveLabel.Location = new System.Drawing.Point(442, 50);
            this.indexRemoveLabel.Name = "indexRemoveLabel";
            this.indexRemoveLabel.Size = new System.Drawing.Size(120, 13);
            this.indexRemoveLabel.TabIndex = 26;
            this.indexRemoveLabel.Text = "Index of item to remove:";
            // 
            // searchSizeLabel
            // 
            this.searchSizeLabel.AutoSize = true;
            this.searchSizeLabel.Location = new System.Drawing.Point(14, 98);
            this.searchSizeLabel.Name = "searchSizeLabel";
            this.searchSizeLabel.Size = new System.Drawing.Size(30, 13);
            this.searchSizeLabel.TabIndex = 30;
            this.searchSizeLabel.Text = "Size:";
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Location = new System.Drawing.Point(13, 56);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(38, 13);
            this.searchNameLabel.TabIndex = 29;
            this.searchNameLabel.Text = "Name:";
            // 
            // searchSizeTextBox
            // 
            this.searchSizeTextBox.Location = new System.Drawing.Point(13, 115);
            this.searchSizeTextBox.Name = "searchSizeTextBox";
            this.searchSizeTextBox.Size = new System.Drawing.Size(135, 20);
            this.searchSizeTextBox.TabIndex = 28;
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(13, 72);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(135, 20);
            this.searchNameTextBox.TabIndex = 27;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 35);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search For Item";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // buttonModifyItem
            // 
            this.buttonModifyItem.Location = new System.Drawing.Point(304, 12);
            this.buttonModifyItem.Name = "buttonModifyItem";
            this.buttonModifyItem.Size = new System.Drawing.Size(135, 35);
            this.buttonModifyItem.TabIndex = 32;
            this.buttonModifyItem.Text = "Modify Item";
            this.buttonModifyItem.UseVisualStyleBackColor = true;
            this.buttonModifyItem.Click += new System.EventHandler(this.buttonModifyItem_Click);
            // 
            // inventorySystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.buttonModifyItem);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchSizeLabel);
            this.Controls.Add(this.searchNameLabel);
            this.Controls.Add(this.searchSizeTextBox);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.indexRemoveLabel);
            this.Controls.Add(this.amountStockLabel);
            this.Controls.Add(this.stockIndexLabel);
            this.Controls.Add(this.amountStockTextBox);
            this.Controls.Add(this.restockIndexTextBox);
            this.Controls.Add(this.increaseStockButton);
            this.Controls.Add(this.indexRemoveTextBox);
            this.Controls.Add(this.displayInventory);
            this.Controls.Add(this.inventoryListBox);
            this.Controls.Add(this.labelInventoryList);
            this.Controls.Add(this.buttonRemoveInventoryItem);
            this.Controls.Add(this.buttonAddInventoryItem);
            this.Name = "inventorySystemForm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.inventorySystemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddInventoryItem;
        private System.Windows.Forms.Button buttonRemoveInventoryItem;
        private System.Windows.Forms.Label labelInventoryList;
        private System.Windows.Forms.Button displayInventory;
        private System.Windows.Forms.TextBox indexRemoveTextBox;
        private System.Windows.Forms.TextBox restockIndexTextBox;
        private System.Windows.Forms.Button increaseStockButton;
        private System.Windows.Forms.TextBox amountStockTextBox;
        private System.Windows.Forms.Label stockIndexLabel;
        private System.Windows.Forms.Label amountStockLabel;
        private System.Windows.Forms.Label indexRemoveLabel;
        private System.Windows.Forms.Label searchSizeLabel;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.TextBox searchSizeTextBox;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Button buttonModifyItem;
    }
}

