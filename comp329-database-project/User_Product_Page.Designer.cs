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
            this.linkLabelEditAccount = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelStore = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_Icecream_1 = new System.Windows.Forms.Panel();
            this.labelItemTItle = new System.Windows.Forms.Label();
            this.pictureBoxIcecream = new System.Windows.Forms.PictureBox();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonAddtoCart = new System.Windows.Forms.Button();
            this.labelStoreTitle = new System.Windows.Forms.Label();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.labelCartTitle = new System.Windows.Forms.Label();
            this.listBoxCartItems = new System.Windows.Forms.ListBox();
            this.labelItemsTotal = new System.Windows.Forms.Label();
            this.buttonBuyItems = new System.Windows.Forms.Button();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelStore.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel_Icecream_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcecream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelLogout);
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
            this.splitContainer1.Size = new System.Drawing.Size(1074, 611);
            this.splitContainer1.SplitterDistance = 790;
            this.splitContainer1.TabIndex = 0;
            // 
            // linkLabelEditAccount
            // 
            this.linkLabelEditAccount.AutoSize = true;
            this.linkLabelEditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelEditAccount.Location = new System.Drawing.Point(701, 9);
            this.linkLabelEditAccount.Name = "linkLabelEditAccount";
            this.linkLabelEditAccount.Size = new System.Drawing.Size(73, 13);
            this.linkLabelEditAccount.TabIndex = 6;
            this.linkLabelEditAccount.TabStop = true;
            this.linkLabelEditAccount.Text = "Devon Wright";
            this.linkLabelEditAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditAccount_LinkClicked);
            // 
            // flowLayoutPanelStore
            // 
            this.flowLayoutPanelStore.Controls.Add(this.panel1);
            this.flowLayoutPanelStore.Controls.Add(this.panel2);
            this.flowLayoutPanelStore.Controls.Add(this.panel_Icecream_1);
            this.flowLayoutPanelStore.Location = new System.Drawing.Point(12, 49);
            this.flowLayoutPanelStore.Name = "flowLayoutPanelStore";
            this.flowLayoutPanelStore.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelStore.Size = new System.Drawing.Size(762, 550);
            this.flowLayoutPanelStore.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 163);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " xx ICECREAM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.Location = new System.Drawing.Point(93, 138);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(3, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddtoCart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(160, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 163);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " xx ICECREAM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 129);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown2.Location = new System.Drawing.Point(93, 138);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(3, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add to Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonAddtoCart_Click);
            // 
            // panel_Icecream_1
            // 
            this.panel_Icecream_1.Controls.Add(this.labelItemTItle);
            this.panel_Icecream_1.Controls.Add(this.pictureBoxIcecream);
            this.panel_Icecream_1.Controls.Add(this.numericUpDownAmount);
            this.panel_Icecream_1.Controls.Add(this.buttonAddtoCart);
            this.panel_Icecream_1.Location = new System.Drawing.Point(307, 13);
            this.panel_Icecream_1.Name = "panel_Icecream_1";
            this.panel_Icecream_1.Size = new System.Drawing.Size(141, 163);
            this.panel_Icecream_1.TabIndex = 3;
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
            // pictureBoxIcecream
            // 
            this.pictureBoxIcecream.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxIcecream.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcecream.Name = "pictureBoxIcecream";
            this.pictureBoxIcecream.Size = new System.Drawing.Size(134, 129);
            this.pictureBoxIcecream.TabIndex = 0;
            this.pictureBoxIcecream.TabStop = false;
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
            this.buttonRemoveSelected.Location = new System.Drawing.Point(15, 512);
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
            this.listBoxCartItems.Size = new System.Drawing.Size(252, 454);
            this.listBoxCartItems.TabIndex = 2;
            this.listBoxCartItems.Click += new System.EventHandler(this.listBoxCartItems_Click);
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
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogout.Location = new System.Drawing.Point(734, 28);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 7;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // User_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 611);
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
            this.flowLayoutPanelStore.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel_Icecream_1.ResumeLayout(false);
            this.panel_Icecream_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcecream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
    }
}