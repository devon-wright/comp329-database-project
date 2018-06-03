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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginUser
            // 
            this.buttonLoginUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginUser.Location = new System.Drawing.Point(83, 235);
            this.buttonLoginUser.Name = "buttonLoginUser";
            this.buttonLoginUser.Size = new System.Drawing.Size(169, 48);
            this.buttonLoginUser.TabIndex = 0;
            this.buttonLoginUser.Text = "Login as User";
            this.buttonLoginUser.UseVisualStyleBackColor = true;
            this.buttonLoginUser.Click += new System.EventHandler(this.buttonLoginUser_Click);
            // 
            // buttonLoginAdmin
            // 
            this.buttonLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginAdmin.Location = new System.Drawing.Point(83, 299);
            this.buttonLoginAdmin.Name = "buttonLoginAdmin";
            this.buttonLoginAdmin.Size = new System.Drawing.Size(169, 48);
            this.buttonLoginAdmin.TabIndex = 1;
            this.buttonLoginAdmin.Text = "Login as Admin";
            this.buttonLoginAdmin.UseVisualStyleBackColor = true;
            this.buttonLoginAdmin.Click += new System.EventHandler(this.buttonLoginAdmin_Click);
            // 
            // linkLabelAddNewUser
            // 
            this.linkLabelAddNewUser.AutoSize = true;
            this.linkLabelAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelAddNewUser.Location = new System.Drawing.Point(120, 367);
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
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ice-cream Express";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 131);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelAddNewUser);
            this.Controls.Add(this.buttonLoginAdmin);
            this.Controls.Add(this.buttonLoginUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login_Page";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginUser;
        private System.Windows.Forms.Button buttonLoginAdmin;
        private System.Windows.Forms.LinkLabel linkLabelAddNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

