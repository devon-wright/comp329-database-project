namespace comp329_database_project
{
    partial class Admin_Analytics
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
            this.labelAdminTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlFactories = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.buttonRemoveFactory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonAddNewEmployee = new System.Windows.Forms.Button();
            this.labelCityTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.linkLabelEditAccount = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNewFactory = new System.Windows.Forms.Button();
            this.labelCartTitle = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFactoryManager = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlFactories.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdminTitle
            // 
            this.labelAdminTitle.AutoSize = true;
            this.labelAdminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminTitle.Location = new System.Drawing.Point(12, 7);
            this.labelAdminTitle.Name = "labelAdminTitle";
            this.labelAdminTitle.Size = new System.Drawing.Size(202, 37);
            this.labelAdminTitle.TabIndex = 4;
            this.labelAdminTitle.Text = "Admin Page";
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControlFactories);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelLogout);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelEditAccount);
            this.splitContainer1.Panel1.Controls.Add(this.labelAdminTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxFactoryManager);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFirstname);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddNewFactory);
            this.splitContainer1.Panel2.Controls.Add(this.labelCartTitle);
            this.splitContainer1.Size = new System.Drawing.Size(831, 508);
            this.splitContainer1.SplitterDistance = 552;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControlFactories
            // 
            this.tabControlFactories.Controls.Add(this.tabPage1);
            this.tabControlFactories.Controls.Add(this.tabPage2);
            this.tabControlFactories.Controls.Add(this.tabPage3);
            this.tabControlFactories.Location = new System.Drawing.Point(12, 65);
            this.tabControlFactories.Name = "tabControlFactories";
            this.tabControlFactories.SelectedIndex = 0;
            this.tabControlFactories.Size = new System.Drawing.Size(532, 437);
            this.tabControlFactories.TabIndex = 8;
            this.tabControlFactories.TabIndexChanged += new System.EventHandler(this.tabControlFactories_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.buttonRemoveFactory);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.labelCityTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hamilton";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonRemoveProduct);
            this.panel2.Controls.Add(this.listBoxProducts);
            this.panel2.Controls.Add(this.buttonAddNewProduct);
            this.panel2.Location = new System.Drawing.Point(232, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 367);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Products:";
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(208, 337);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveProduct.TabIndex = 4;
            this.buttonRemoveProduct.Text = "Remove";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(11, 28);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(272, 303);
            this.listBoxProducts.TabIndex = 1;
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(11, 337);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewProduct.TabIndex = 3;
            this.buttonAddNewProduct.Text = "Add New";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // buttonRemoveFactory
            // 
            this.buttonRemoveFactory.Location = new System.Drawing.Point(416, 6);
            this.buttonRemoveFactory.Name = "buttonRemoveFactory";
            this.buttonRemoveFactory.Size = new System.Drawing.Size(102, 25);
            this.buttonRemoveFactory.TabIndex = 6;
            this.buttonRemoveFactory.Text = "Remove";
            this.buttonRemoveFactory.UseVisualStyleBackColor = true;
            this.buttonRemoveFactory.Click += new System.EventHandler(this.buttonRemoveFactory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRemoveEmployee);
            this.panel1.Controls.Add(this.listBoxEmployees);
            this.panel1.Controls.Add(this.buttonAddNewEmployee);
            this.panel1.Location = new System.Drawing.Point(11, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 367);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employees:";
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(132, 337);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveEmployee.TabIndex = 4;
            this.buttonRemoveEmployee.Text = "Remove";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(6, 28);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(201, 303);
            this.listBoxEmployees.TabIndex = 1;
            // 
            // buttonAddNewEmployee
            // 
            this.buttonAddNewEmployee.Location = new System.Drawing.Point(6, 337);
            this.buttonAddNewEmployee.Name = "buttonAddNewEmployee";
            this.buttonAddNewEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewEmployee.TabIndex = 3;
            this.buttonAddNewEmployee.Text = "Add New";
            this.buttonAddNewEmployee.UseVisualStyleBackColor = true;
            this.buttonAddNewEmployee.Click += new System.EventHandler(this.buttonAddNewEmployee_Click);
            // 
            // labelCityTitle
            // 
            this.labelCityTitle.AutoSize = true;
            this.labelCityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCityTitle.Location = new System.Drawing.Point(6, 9);
            this.labelCityTitle.Name = "labelCityTitle";
            this.labelCityTitle.Size = new System.Drawing.Size(104, 25);
            this.labelCityTitle.TabIndex = 0;
            this.labelCityTitle.Text = "Hamilton";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wellington";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(588, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Auckland";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogout.Location = new System.Drawing.Point(564, 31);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 7;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            // 
            // linkLabelEditAccount
            // 
            this.linkLabelEditAccount.AutoSize = true;
            this.linkLabelEditAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelEditAccount.Location = new System.Drawing.Point(471, 16);
            this.linkLabelEditAccount.Name = "linkLabelEditAccount";
            this.linkLabelEditAccount.Size = new System.Drawing.Size(73, 13);
            this.linkLabelEditAccount.TabIndex = 6;
            this.linkLabelEditAccount.TabStop = true;
            this.linkLabelEditAccount.Text = "Devon Wright";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add New Factory";
            // 
            // buttonAddNewFactory
            // 
            this.buttonAddNewFactory.Location = new System.Drawing.Point(137, 166);
            this.buttonAddNewFactory.Name = "buttonAddNewFactory";
            this.buttonAddNewFactory.Size = new System.Drawing.Size(120, 30);
            this.buttonAddNewFactory.TabIndex = 4;
            this.buttonAddNewFactory.Text = "Add New";
            this.buttonAddNewFactory.UseVisualStyleBackColor = true;
            this.buttonAddNewFactory.Click += new System.EventHandler(this.buttonAddNewFactory_Click);
            // 
            // labelCartTitle
            // 
            this.labelCartTitle.AutoSize = true;
            this.labelCartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartTitle.Location = new System.Drawing.Point(58, 16);
            this.labelCartTitle.Name = "labelCartTitle";
            this.labelCartTitle.Size = new System.Drawing.Size(100, 25);
            this.labelCartTitle.TabIndex = 3;
            this.labelCartTitle.Text = "Controls";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(109, 87);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(149, 20);
            this.textBoxFirstname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount of workers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Manager of Factory:";
            // 
            // comboBoxFactoryManager
            // 
            this.comboBoxFactoryManager.FormattingEnabled = true;
            this.comboBoxFactoryManager.Location = new System.Drawing.Point(109, 139);
            this.comboBoxFactoryManager.Name = "comboBoxFactoryManager";
            this.comboBoxFactoryManager.Size = new System.Drawing.Size(149, 21);
            this.comboBoxFactoryManager.TabIndex = 11;
            // 
            // Admin_Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 508);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Admin_Analytics";
            this.Text = "Admin_Analytics";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlFactories.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdminTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlFactories;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonAddNewEmployee;
        private System.Windows.Forms.Label labelCityTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.LinkLabel linkLabelEditAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddNewFactory;
        private System.Windows.Forms.Label labelCartTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Button buttonRemoveFactory;
        private System.Windows.Forms.ComboBox comboBoxFactoryManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label4;
    }
}