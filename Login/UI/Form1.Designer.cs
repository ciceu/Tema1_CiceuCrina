namespace Login
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(35, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Username";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(35, 124);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(69, 17);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(149, 69);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(321, 22);
            this.nameText.TabIndex = 2;
            this.nameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(149, 121);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(321, 22);
            this.passText.TabIndex = 3;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(339, 185);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(131, 35);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
    }
}

