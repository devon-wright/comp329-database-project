namespace comp329_database_project
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.buttonLoginUser = new System.Windows.Forms.Button();
            this.buttonLoginAdmin = new System.Windows.Forms.Button();
            this.linkLabelAddNewUser = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLoginAll = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoginAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginUser
            // 
            this.buttonLoginUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginUser.Location = new System.Drawing.Point(82, 280);
            this.buttonLoginUser.Name = "buttonLoginUser";
            this.buttonLoginUser.Size = new System.Drawing.Size(169, 34);
            this.buttonLoginUser.TabIndex = 0;
            this.buttonLoginUser.Text = "Login as User";
            this.buttonLoginUser.UseVisualStyleBackColor = true;
            this.buttonLoginUser.Click += new System.EventHandler(this.buttonLoginUser_Click);
            // 
            // buttonLoginAdmin
            // 
            this.buttonLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginAdmin.Location = new System.Drawing.Point(82, 320);
            this.buttonLoginAdmin.Name = "buttonLoginAdmin";
            this.buttonLoginAdmin.Size = new System.Drawing.Size(169, 23);
            this.buttonLoginAdmin.TabIndex = 1;
            this.buttonLoginAdmin.Text = "Login as Admin";
            this.buttonLoginAdmin.UseVisualStyleBackColor = true;
            this.buttonLoginAdmin.Click += new System.EventHandler(this.buttonLoginAdmin_Click);
            // 
            // linkLabelAddNewUser
            // 
            this.linkLabelAddNewUser.AutoSize = true;
            this.linkLabelAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelAddNewUser.Location = new System.Drawing.Point(116, 371);
            this.linkLabelAddNewUser.Name = "linkLabelAddNewUser";
            this.linkLabelAddNewUser.Size = new System.Drawing.Size(94, 13);
            this.linkLabelAddNewUser.TabIndex = 2;
            this.linkLabelAddNewUser.TabStop = true;
            this.linkLabelAddNewUser.Text = "Or add a new user";
            this.linkLabelAddNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewUser_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ice-cream Express";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 131);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelLoginAll
            // 
            this.panelLoginAll.Controls.Add(this.textBoxPassword);
            this.panelLoginAll.Controls.Add(this.label3);
            this.panelLoginAll.Controls.Add(this.textBoxFirstname);
            this.panelLoginAll.Controls.Add(this.label2);
            this.panelLoginAll.Controls.Add(this.label1);
            this.panelLoginAll.Controls.Add(this.linkLabelAddNewUser);
            this.panelLoginAll.Controls.Add(this.pictureBox1);
            this.panelLoginAll.Controls.Add(this.buttonLoginAdmin);
            this.panelLoginAll.Controls.Add(this.buttonLoginUser);
            this.panelLoginAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginAll.Location = new System.Drawing.Point(0, 0);
            this.panelLoginAll.Margin = new System.Windows.Forms.Padding(0);
            this.panelLoginAll.Name = "panelLoginAll";
            this.panelLoginAll.Size = new System.Drawing.Size(334, 411);
            this.panelLoginAll.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(119, 249);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(119, 223);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(160, 20);
            this.textBoxFirstname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firstname:";
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.panelLoginAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login_Page";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoginAll.ResumeLayout(false);
            this.panelLoginAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginUser;
        private System.Windows.Forms.Button buttonLoginAdmin;
        private System.Windows.Forms.LinkLabel linkLabelAddNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLoginAll;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
    }
}

