namespace Login
{
    partial class FormAdmin_CRUD
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
            this.components = new System.ComponentModel.Container();
            this.titlu = new System.Windows.Forms.Label();
            this.regia = new System.Windows.Forms.Label();
            this.premiera = new System.Windows.Forms.Label();
            this.distributia = new System.Windows.Forms.Label();
            this.DataL = new System.Windows.Forms.Label();
            this.oraD = new System.Windows.Forms.Label();
            this.bilete = new System.Windows.Forms.Label();
            this.titluT = new System.Windows.Forms.TextBox();
            this.regieT = new System.Windows.Forms.TextBox();
            this.premieraT = new System.Windows.Forms.TextBox();
            this.distributieT = new System.Windows.Forms.TextBox();
            this.BileteT = new System.Windows.Forms.TextBox();
            this.difuzareT = new System.Windows.Forms.TextBox();
            this.finalT = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tabel = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Location = new System.Drawing.Point(47, 35);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(39, 17);
            this.titlu.TabIndex = 0;
            this.titlu.Text = "Titlu:";
            // 
            // regia
            // 
            this.regia.AutoSize = true;
            this.regia.Location = new System.Drawing.Point(47, 75);
            this.regia.Name = "regia";
            this.regia.Size = new System.Drawing.Size(49, 17);
            this.regia.TabIndex = 1;
            this.regia.Text = "Regia:";
            // 
            // premiera
            // 
            this.premiera.AutoSize = true;
            this.premiera.Location = new System.Drawing.Point(47, 160);
            this.premiera.Name = "premiera";
            this.premiera.Size = new System.Drawing.Size(105, 17);
            this.premiera.TabIndex = 2;
            this.premiera.Text = "Data premierei:";
            // 
            // distributia
            // 
            this.distributia.AutoSize = true;
            this.distributia.Location = new System.Drawing.Point(47, 116);
            this.distributia.Name = "distributia";
            this.distributia.Size = new System.Drawing.Size(75, 17);
            this.distributia.TabIndex = 3;
            this.distributia.Text = "Distributia:";
            // 
            // DataL
            // 
            this.DataL.AutoSize = true;
            this.DataL.Location = new System.Drawing.Point(47, 291);
            this.DataL.Name = "DataL";
            this.DataL.Size = new System.Drawing.Size(80, 17);
            this.DataL.TabIndex = 4;
            this.DataL.Text = "Data finala:";
            this.DataL.Click += new System.EventHandler(this.label5_Click);
            // 
            // oraD
            // 
            this.oraD.AutoSize = true;
            this.oraD.Location = new System.Drawing.Point(47, 252);
            this.oraD.Name = "oraD";
            this.oraD.Size = new System.Drawing.Size(91, 17);
            this.oraD.TabIndex = 5;
            this.oraD.Text = "Ora difuzare:";
            // 
            // bilete
            // 
            this.bilete.AutoSize = true;
            this.bilete.Location = new System.Drawing.Point(47, 208);
            this.bilete.Name = "bilete";
            this.bilete.Size = new System.Drawing.Size(65, 17);
            this.bilete.TabIndex = 6;
            this.bilete.Text = "Nr bilete:";
            // 
            // titluT
            // 
            this.titluT.Location = new System.Drawing.Point(238, 30);
            this.titluT.Name = "titluT";
            this.titluT.Size = new System.Drawing.Size(341, 22);
            this.titluT.TabIndex = 7;
            // 
            // regieT
            // 
            this.regieT.Location = new System.Drawing.Point(238, 70);
            this.regieT.Name = "regieT";
            this.regieT.Size = new System.Drawing.Size(341, 22);
            this.regieT.TabIndex = 8;
            // 
            // premieraT
            // 
            this.premieraT.Location = new System.Drawing.Point(238, 160);
            this.premieraT.Name = "premieraT";
            this.premieraT.Size = new System.Drawing.Size(341, 22);
            this.premieraT.TabIndex = 9;
            // 
            // distributieT
            // 
            this.distributieT.Location = new System.Drawing.Point(238, 111);
            this.distributieT.Name = "distributieT";
            this.distributieT.Size = new System.Drawing.Size(341, 22);
            this.distributieT.TabIndex = 10;
            // 
            // BileteT
            // 
            this.BileteT.Location = new System.Drawing.Point(238, 203);
            this.BileteT.Name = "BileteT";
            this.BileteT.Size = new System.Drawing.Size(341, 22);
            this.BileteT.TabIndex = 11;
            // 
            // difuzareT
            // 
            this.difuzareT.Location = new System.Drawing.Point(238, 247);
            this.difuzareT.Name = "difuzareT";
            this.difuzareT.Size = new System.Drawing.Size(341, 22);
            this.difuzareT.TabIndex = 12;
            // 
            // finalT
            // 
            this.finalT.Location = new System.Drawing.Point(238, 288);
            this.finalT.Name = "finalT";
            this.finalT.Size = new System.Drawing.Size(341, 22);
            this.finalT.TabIndex = 13;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(35, 389);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(102, 47);
            this.create.TabIndex = 14;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(290, 389);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(102, 47);
            this.update.TabIndex = 15;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(161, 389);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(102, 47);
            this.read.TabIndex = 16;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(416, 389);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 47);
            this.delete.TabIndex = 17;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // tabel
            // 
            this.tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel.Location = new System.Drawing.Point(598, 27);
            this.tabel.Name = "tabel";
            this.tabel.RowTemplate.Height = 24;
            this.tabel.Size = new System.Drawing.Size(700, 424);
            this.tabel.TabIndex = 19;
            this.tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabel_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Data si ora trebuie sa fie in format DateTime (yyyy-mm-dd hh:mm:ss)";
            // 
            // FormAdmin_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.read);
            this.Controls.Add(this.update);
            this.Controls.Add(this.create);
            this.Controls.Add(this.finalT);
            this.Controls.Add(this.difuzareT);
            this.Controls.Add(this.BileteT);
            this.Controls.Add(this.distributieT);
            this.Controls.Add(this.premieraT);
            this.Controls.Add(this.regieT);
            this.Controls.Add(this.titluT);
            this.Controls.Add(this.bilete);
            this.Controls.Add(this.oraD);
            this.Controls.Add(this.DataL);
            this.Controls.Add(this.distributia);
            this.Controls.Add(this.premiera);
            this.Controls.Add(this.regia);
            this.Controls.Add(this.titlu);
            this.Name = "FormAdmin_CRUD";
            this.Text = "FormAdmin_CRUD";
            this.Load += new System.EventHandler(this.FormAdmin_CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Label regia;
        private System.Windows.Forms.Label premiera;
        private System.Windows.Forms.Label distributia;
        private System.Windows.Forms.Label DataL;
        private System.Windows.Forms.Label oraD;
        private System.Windows.Forms.Label bilete;
        private System.Windows.Forms.TextBox titluT;
        private System.Windows.Forms.TextBox regieT;
        private System.Windows.Forms.TextBox premieraT;
        private System.Windows.Forms.TextBox distributieT;
        private System.Windows.Forms.TextBox BileteT;
        private System.Windows.Forms.TextBox difuzareT;
        private System.Windows.Forms.TextBox finalT;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView tabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
    }
}