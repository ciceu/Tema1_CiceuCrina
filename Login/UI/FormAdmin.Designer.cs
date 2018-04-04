namespace Login
{
    partial class FormAdmin
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
            this.addU = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Label();
            this.crud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addU
            // 
            this.addU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addU.Location = new System.Drawing.Point(89, 132);
            this.addU.Name = "addU";
            this.addU.Size = new System.Drawing.Size(134, 46);
            this.addU.TabIndex = 4;
            this.addU.Text = "Add new user";
            this.addU.UseVisualStyleBackColor = true;
            this.addU.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(209, 40);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(167, 29);
            this.admin.TabIndex = 5;
            this.admin.Text = "Administrator";
            // 
            // crud
            // 
            this.crud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crud.Location = new System.Drawing.Point(334, 132);
            this.crud.Name = "crud";
            this.crud.Size = new System.Drawing.Size(183, 46);
            this.crud.TabIndex = 6;
            this.crud.Text = "CRUD operations";
            this.crud.UseVisualStyleBackColor = true;
            this.crud.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 262);
            this.Controls.Add(this.crud);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.addU);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addU;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button crud;
    }
}