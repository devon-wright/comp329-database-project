namespace comp329_database_project
{
    partial class User_Product_Page
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
            this.buttonBuyItems = new System.Windows.Forms.Button();
            this.labelItemsTotal = new System.Windows.Forms.Label();
            this.listBoxCartItems = new System.Windows.Forms.ListBox();
            this.labelCartTitle = new System.Windows.Forms.Label();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.pictureBoxIcecream = new System.Windows.Forms.PictureBox();
            this.buttonAddtoCart = new System.Windows.Forms.Button();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.panel_Icecream_1 = new System.Windows.Forms.Panel();
            this.labelStoreTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelStore = new System.Windows.Forms.FlowLayoutPanel();
            this.labelItemTItle = new System.Windows.Forms.Label();
            this.linkLabelEditAccount = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcecream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.panel_Icecream_1.SuspendLayout();
            this.flowLayoutPanelStore.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelEditAccount);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelStore);
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
            this.splitContainer1.Size = new System.Drawing.Size(1073, 615);
            this.splitContainer1.SplitterDistance = 790;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonBuyItems
            // 
            this.buttonBuyItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuyItems.Location = new System.Drawing.Point(147, 569);
            this.buttonBuyItems.Name = "buttonBuyItems";
            this.buttonBuyItems.Size = new System.Drawing.Size(120, 33);
            this.buttonBuyItems.TabIndex = 0;
            this.buttonBuyItems.Text = "Buy Items";
            this.buttonBuyItems.UseVisualStyleBackColor = true;
            this.buttonBuyItems.Click += new System.EventHandler(this.buttonBuyItems_Click);
            // 
            // labelItemsTotal
            // 
            this.labelItemsTotal.AutoSize = true;
            this.labelItemsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemsTotal.Location = new System.Drawing.Point(176, 512);
            this.labelItemsTotal.Name = "labelItemsTotal";
            this.labelItemsTotal.Size = new System.Drawing.Size(91, 25);
            this.labelItemsTotal.TabIndex = 1;
            this.labelItemsTotal.Text = "$ 00.00";
            // 
            // listBoxCartItems
            // 
            this.listBoxCartItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxCartItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCartItems.FormattingEnabled = true;
            this.listBoxCartItems.ItemHeight = 15;
            this.listBoxCartItems.Location = new System.Drawing.Point(15, 48);
            this.listBoxCartItems.Name = "listBoxCartItems";
            this.listBoxCartItems.Size = new System.Drawing.Size(252, 454);
            this.listBoxCartItems.TabIndex = 2;
            this.listBoxCartItems.Click += new System.EventHandler(this.listBoxCartItems_Click);
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
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveSelected.Enabled = false;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(15, 512);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(106, 25);
            this.buttonRemoveSelected.TabIndex = 4;
            this.buttonRemoveSelected.Text = "Remove Item";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // pictureBoxIcecream
            // 
            this.pictureBoxIcecream.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIcecream.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcecream.Name = "pictureBoxIcecream";
            this.pictureBoxIcecream.Size = new System.Drawing.Size(134, 129);
            this.pictureBoxIcecream.TabIndex = 0;
            this.pictureBoxIcecream.TabStop = false;
            // 
            // buttonAddtoCart
            // 
            this.buttonAddtoCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddtoCart.Location = new System.Drawing.Point(3, 138);
            this.buttonAddtoCart.Name = "buttonAddtoCart";
            this.buttonAddtoCart.Size = new System.Drawing.Size(84, 20);
            this.buttonAddtoCart.TabIndex = 1;
            this.buttonAddtoCart.Text = "Add to Cart";
            this.buttonAddtoCart.UseVisualStyleBackColor = true;
            this.buttonAddtoCart.Click += new System.EventHandler(this.buttonAddtoCart_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownAmount.Location = new System.Drawing.Point(93, 138);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownAmount.TabIndex = 2;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel_Icecream_1
            // 
            this.panel_Icecream_1.Controls.Add(this.labelItemTItle);
            this.panel_Icecream_1.Controls.Add(this.pictureBoxIcecream);
            this.panel_Icecream_1.Controls.Add(this.numericUpDownAmount);
            this.panel_Icecream_1.Controls.Add(this.buttonAddtoCart);
            this.panel_Icecream_1.Location = new System.Drawing.Point(13, 13);
            this.panel_Icecream_1.Name = "panel_Icecream_1";
            this.panel_Icecream_1.Size = new System.Drawing.Size(141, 163);
            this.panel_Icecream_1.TabIndex = 3;
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
            // flowLayoutPanelStore
            // 
            this.flowLayoutPanelStore.Controls.Add(this.panel_Icecream_1);
            this.flowLayoutPanelStore.Location = new System.Drawing.Point(12, 49);
            this.flowLayoutPanelStore.Name = "flowLayoutPanelStore";
            this.flowLayoutPanelStore.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelStore.Size = new System.Drawing.Size(762, 553);
            this.flowLayoutPanelStore.TabIndex = 5;
            // 
            // labelItemTItle
            // 
            this.labelItemTItle.AutoSize = true;
            this.labelItemTItle.Location = new System.Drawing.Point(30, 105);
            this.labelItemTItle.Name = "labelItemTItle";
            this.labelItemTItle.Size = new System.Drawing.Size(78, 13);
            this.labelItemTItle.TabIndex = 3;
            this.labelItemTItle.Text = " xx ICECREAM";
            this.labelItemTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelEditAccount
            // 
            this.linkLabelEditAccount.AutoSize = true;
            this.linkLabelEditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelEditAccount.Location = new System.Drawing.Point(700, 19);
            this.linkLabelEditAccount.Name = "linkLabelEditAccount";
            this.linkLabelEditAccount.Size = new System.Drawing.Size(73, 13);
            this.linkLabelEditAccount.TabIndex = 6;
            this.linkLabelEditAccount.TabStop = true;
            this.linkLabelEditAccount.Text = "Devon Wright";
            this.linkLabelEditAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditAccount_LinkClicked);
            // 
            // User_Product_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 615);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "User_Product_Page";
            this.Text = "User_Product_Page";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcecream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.panel_Icecream_1.ResumeLayout(false);
            this.panel_Icecream_1.PerformLayout();
            this.flowLayoutPanelStore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Label labelCartTitle;
        private System.Windows.Forms.ListBox listBoxCartItems;
        private System.Windows.Forms.Label labelItemsTotal;
        private System.Windows.Forms.Button buttonBuyItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStore;
        private System.Windows.Forms.Panel panel_Icecream_1;
        private System.Windows.Forms.PictureBox pictureBoxIcecream;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Button buttonAddtoCart;
        private System.Windows.Forms.Label labelStoreTitle;
        private System.Windows.Forms.Label labelItemTItle;
        private System.Windows.Forms.LinkLabel linkLabelEditAccount;
    }
}