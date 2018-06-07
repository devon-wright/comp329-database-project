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
            this.SuspendLayout();
            // 
            // labelAddUserTitle
            // 
            this.labelAddUserTitle.AutoSize = true;
            this.labelAddUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddUserTitle.Location = new System.Drawing.Point(21, 14);
            this.labelAddUserTitle.Name = "labelAddUserTitle";
            this.labelAddUserTitle.Size = new System.Drawing.Size(264, 31);
            this.labelAddUserTitle.TabIndex = 4;
            this.labelAddUserTitle.Text = "Add a New Product";
            // 
            // New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.labelAddUserTitle);
            this.Name = "New_Product";
            this.Text = "New_Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddUserTitle;
    }
}