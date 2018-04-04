namespace Login
{
    partial class FormAdmin_addUser
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
            this.nume = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.numeT = new System.Windows.Forms.TextBox();
            this.userT = new System.Windows.Forms.TextBox();
            this.passT = new System.Windows.Forms.TextBox();
            this.prenumeT = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(38, 37);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(49, 17);
            this.nume.TabIndex = 0;
            this.nume.Text = "Nume:";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(41, 120);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(77, 17);
            this.user.TabIndex = 1;
            this.user.Text = "Username:";
            this.user.Click += new System.EventHandler(this.label2_Click);
            // 
            // prenume
            // 
            this.prenume.AutoSize = true;
            this.prenume.Location = new System.Drawing.Point(38, 75);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(69, 17);
            this.prenume.TabIndex = 2;
            this.prenume.Text = "Prenume:";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(41, 165);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(73, 17);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password:";
            // 
            // numeT
            // 
            this.numeT.Location = new System.Drawing.Point(139, 34);
            this.numeT.Name = "numeT";
            this.numeT.Size = new System.Drawing.Size(256, 22);
            this.numeT.TabIndex = 4;
            // 
            // userT
            // 
            this.userT.Location = new System.Drawing.Point(139, 120);
            this.userT.Name = "userT";
            this.userT.Size = new System.Drawing.Size(256, 22);
            this.userT.TabIndex = 5;
            // 
            // passT
            // 
            this.passT.Location = new System.Drawing.Point(139, 162);
            this.passT.Name = "passT";
            this.passT.Size = new System.Drawing.Size(256, 22);
            this.passT.TabIndex = 6;
            // 
            // prenumeT
            // 
            this.prenumeT.Location = new System.Drawing.Point(139, 75);
            this.prenumeT.Name = "prenumeT";
            this.prenumeT.Size = new System.Drawing.Size(256, 22);
            this.prenumeT.TabIndex = 7;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(234, 223);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // FormAdmin_addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 275);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.prenumeT);
            this.Controls.Add(this.passT);
            this.Controls.Add(this.userT);
            this.Controls.Add(this.numeT);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.user);
            this.Controls.Add(this.nume);
            this.Name = "FormAdmin_addUser";
            this.Text = "FormAdmin_addUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label prenume;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox numeT;
        private System.Windows.Forms.TextBox userT;
        private System.Windows.Forms.TextBox passT;
        private System.Windows.Forms.TextBox prenumeT;
        private System.Windows.Forms.Button Add;
    }
}