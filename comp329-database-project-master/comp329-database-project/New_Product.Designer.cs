namespace comp329_database_project
{
    partial class New_Product
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
            this.labelAddUserTitle = new System.Windows.Forms.Label();
            this.textBoxIcecreamMade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFlavour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectFactory = new System.Windows.Forms.ComboBox();
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddUserTitle
            // 
            this.labelAddUserTitle.AutoSize = true;
            this.labelAddUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddUserTitle.Location = new System.Drawing.Point(42, 9);
            this.labelAddUserTitle.Name = "labelAddUserTitle";
            this.labelAddUserTitle.Size = new System.Drawing.Size(264, 31);
            this.labelAddUserTitle.TabIndex = 4;
            this.labelAddUserTitle.Text = "Add a New Product";
            // 
            // textBoxIcecreamMade
            // 
            this.textBoxIcecreamMade.Location = new System.Drawing.Point(127, 95);
            this.textBoxIcecreamMade.Name = "textBoxIcecreamMade";
            this.textBoxIcecreamMade.Size = new System.Drawing.Size(160, 20);
            this.textBoxIcecreamMade.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount Made:";
            // 
            // textBoxFlavour
            // 
            this.textBoxFlavour.Location = new System.Drawing.Point(127, 69);
            this.textBoxFlavour.Name = "textBoxFlavour";
            this.textBoxFlavour.Size = new System.Drawing.Size(160, 20);
            this.textBoxFlavour.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Flavour: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Factory: ";
            // 
            // comboBoxSelectFactory
            // 
            this.comboBoxSelectFactory.FormattingEnabled = true;
            this.comboBoxSelectFactory.Location = new System.Drawing.Point(127, 123);
            this.comboBoxSelectFactory.Name = "comboBoxSelectFactory";
            this.comboBoxSelectFactory.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSelectFactory.TabIndex = 13;
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelAdd.Location = new System.Drawing.Point(84, 226);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(169, 28);
            this.buttonCancelAdd.TabIndex = 15;
            this.buttonCancelAdd.Text = "Or Cancel";
            this.buttonCancelAdd.UseVisualStyleBackColor = true;
            this.buttonCancelAdd.Click += new System.EventHandler(this.buttonCancelAdd_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProduct.Location = new System.Drawing.Point(84, 172);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(169, 48);
            this.buttonAddProduct.TabIndex = 14;
            this.buttonAddProduct.Text = "Add this Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.buttonCancelAdd);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.comboBoxSelectFactory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIcecreamMade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFlavour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAddUserTitle);
            this.Name = "New_Product";
            this.Text = "New_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddUserTitle;
        private System.Windows.Forms.TextBox textBoxIcecreamMade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFlavour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectFactory;
        private System.Windows.Forms.Button buttonCancelAdd;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}