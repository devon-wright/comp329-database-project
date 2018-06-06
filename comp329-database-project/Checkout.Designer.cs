namespace comp329_database_project
{
    partial class Checkout
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
            this.labelCartTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.labelItemsTotal = new System.Windows.Forms.Label();
            this.buttonBuyItems = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCartTitle
            // 
            this.labelCartTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCartTitle.AutoSize = true;
            this.labelCartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartTitle.Location = new System.Drawing.Point(174, 6);
            this.labelCartTitle.Name = "labelCartTitle";
            this.labelCartTitle.Size = new System.Drawing.Size(56, 25);
            this.labelCartTitle.TabIndex = 4;
            this.labelCartTitle.Text = "Cart";
            this.labelCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.labelCartTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonReturn);
            this.splitContainer1.Panel2.Controls.Add(this.buttonBuyItems);
            this.splitContainer1.Panel2.Controls.Add(this.labelItemsTotal);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelCartItems);
            this.splitContainer1.Size = new System.Drawing.Size(410, 587);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check all your items are correct, if so press the BUY button, if not click RETURN" +
    " and edit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelCartItems
            // 
            this.flowLayoutPanelCartItems.AutoScroll = true;
            this.flowLayoutPanelCartItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCartItems.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelCartItems.Name = "flowLayoutPanelCartItems";
            this.flowLayoutPanelCartItems.Size = new System.Drawing.Size(407, 409);
            this.flowLayoutPanelCartItems.TabIndex = 0;
            // 
            // labelItemsTotal
            // 
            this.labelItemsTotal.AutoSize = true;
            this.labelItemsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemsTotal.Location = new System.Drawing.Point(300, 426);
            this.labelItemsTotal.Name = "labelItemsTotal";
            this.labelItemsTotal.Size = new System.Drawing.Size(91, 25);
            this.labelItemsTotal.TabIndex = 2;
            this.labelItemsTotal.Text = "$ 00.00";
            // 
            // buttonBuyItems
            // 
            this.buttonBuyItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuyItems.Location = new System.Drawing.Point(271, 462);
            this.buttonBuyItems.Name = "buttonBuyItems";
            this.buttonBuyItems.Size = new System.Drawing.Size(120, 33);
            this.buttonBuyItems.TabIndex = 3;
            this.buttonBuyItems.Text = "Buy Items";
            this.buttonBuyItems.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.Location = new System.Drawing.Point(20, 462);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(120, 33);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCartTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCartItems;
        private System.Windows.Forms.Label labelItemsTotal;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonBuyItems;
    }
}