namespace comp329_database_project
{
    partial class User_Window
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownAmountToBuy = new System.Windows.Forms.NumericUpDown();
            this.buttonBuyItem = new System.Windows.Forms.Button();
            this.listBoxListOfProducts = new System.Windows.Forms.ListBox();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditAccount = new System.Windows.Forms.LinkLabel();
            this.labelStoreTitle = new System.Windows.Forms.Label();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.labelCartTitle = new System.Windows.Forms.Label();
            this.listBoxCartItems = new System.Windows.Forms.ListBox();
            this.labelItemsTotal = new System.Windows.Forms.Label();
            this.buttonBuyItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountToBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownAmountToBuy);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBuyItem);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxListOfProducts);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelLogout);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelEditAccount);
            this.splitContainer1.Panel1.Controls.Add(this.labelStoreTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.buttonRemoveSelected);
            this.splitContainer1.Panel2.Controls.Add(this.labelCartTitle);
            this.splitContainer1.Panel2.Controls.Add(this.listBoxCartItems);
            this.splitContainer1.Panel2.Controls.Add(this.labelItemsTotal);
            this.splitContainer1.Panel2.Controls.Add(this.buttonBuyItems);
            this.splitContainer1.Size = new System.Drawing.Size(748, 523);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.TabIndex = 0;
            // 
            // numericUpDownAmountToBuy
            // 
            this.numericUpDownAmountToBuy.Location = new System.Drawing.Point(245, 446);
            this.numericUpDownAmountToBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmountToBuy.Name = "numericUpDownAmountToBuy";
            this.numericUpDownAmountToBuy.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAmountToBuy.TabIndex = 10;
            this.numericUpDownAmountToBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBuyItem
            // 
            this.buttonBuyItem.Location = new System.Drawing.Point(245, 472);
            this.buttonBuyItem.Name = "buttonBuyItem";
            this.buttonBuyItem.Size = new System.Drawing.Size(120, 37);
            this.buttonBuyItem.TabIndex = 9;
            this.buttonBuyItem.Text = "Buy item";
            this.buttonBuyItem.UseVisualStyleBackColor = true;
            this.buttonBuyItem.Click += new System.EventHandler(this.buttonBuyItem_Click);
            // 
            // listBoxListOfProducts
            // 
            this.listBoxListOfProducts.FormattingEnabled = true;
            this.listBoxListOfProducts.Location = new System.Drawing.Point(19, 72);
            this.listBoxListOfProducts.Name = "listBoxListOfProducts";
            this.listBoxListOfProducts.Size = new System.Drawing.Size(346, 368);
            this.listBoxListOfProducts.TabIndex = 8;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogout.Location = new System.Drawing.Point(406, 31);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 7;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // linkLabelEditAccount
            // 
            this.linkLabelEditAccount.AutoSize = true;
            this.linkLabelEditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelEditAccount.Location = new System.Drawing.Point(373, 12);
            this.linkLabelEditAccount.Name = "linkLabelEditAccount";
            this.linkLabelEditAccount.Size = new System.Drawing.Size(73, 13);
            this.linkLabelEditAccount.TabIndex = 6;
            this.linkLabelEditAccount.TabStop = true;
            this.linkLabelEditAccount.Text = "Devon Wright";
            this.linkLabelEditAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditAccount_LinkClicked);
            // 
            // labelStoreTitle
            // 
            this.labelStoreTitle.AutoSize = true;
            this.labelStoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreTitle.Location = new System.Drawing.Point(12, 7);
            this.labelStoreTitle.Name = "labelStoreTitle";
            this.labelStoreTitle.Size = new System.Drawing.Size(353, 37);
            this.labelStoreTitle.TabIndex = 4;
            this.labelStoreTitle.Text = "Buy Icecream Express";
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveSelected.Enabled = false;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(15, 448);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(106, 25);
            this.buttonRemoveSelected.TabIndex = 4;
            this.buttonRemoveSelected.Text = "Remove Item";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // labelCartTitle
            // 
            this.labelCartTitle.AutoSize = true;
            this.labelCartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartTitle.Location = new System.Drawing.Point(108, 16);
            this.labelCartTitle.Name = "labelCartTitle";
            this.labelCartTitle.Size = new System.Drawing.Size(56, 25);
            this.labelCartTitle.TabIndex = 3;
            this.labelCartTitle.Text = "Cart";
            // 
            // listBoxCartItems
            // 
            this.listBoxCartItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxCartItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCartItems.FormattingEnabled = true;
            this.listBoxCartItems.ItemHeight = 15;
            this.listBoxCartItems.Location = new System.Drawing.Point(15, 48);
            this.listBoxCartItems.Name = "listBoxCartItems";
            this.listBoxCartItems.Size = new System.Drawing.Size(264, 394);
            this.listBoxCartItems.TabIndex = 2;
            // 
            // labelItemsTotal
            // 
            this.labelItemsTotal.AutoSize = true;
            this.labelItemsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemsTotal.Location = new System.Drawing.Point(188, 448);
            this.labelItemsTotal.Name = "labelItemsTotal";
            this.labelItemsTotal.Size = new System.Drawing.Size(91, 25);
            this.labelItemsTotal.TabIndex = 1;
            this.labelItemsTotal.Text = "$ 00.00";
            // 
            // buttonBuyItems
            // 
            this.buttonBuyItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuyItems.Location = new System.Drawing.Point(159, 478);
            this.buttonBuyItems.Name = "buttonBuyItems";
            this.buttonBuyItems.Size = new System.Drawing.Size(120, 33);
            this.buttonBuyItems.TabIndex = 0;
            this.buttonBuyItems.Text = "Buy Items";
            this.buttonBuyItems.UseVisualStyleBackColor = true;
            this.buttonBuyItems.Click += new System.EventHandler(this.buttonBuyItems_Click);
            // 
            // User_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 523);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "User_Window";
            this.Text = "User_Product_Page";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountToBuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Label labelCartTitle;
        private System.Windows.Forms.ListBox listBoxCartItems;
        private System.Windows.Forms.Label labelItemsTotal;
        private System.Windows.Forms.Button buttonBuyItems;
        private System.Windows.Forms.Label labelStoreTitle;
        private System.Windows.Forms.LinkLabel linkLabelEditAccount;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountToBuy;
        private System.Windows.Forms.Button buttonBuyItem;
        private System.Windows.Forms.ListBox listBoxListOfProducts;
    }
}