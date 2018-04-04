namespace Login
{
    partial class FormAngajat
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
            this.film = new System.Windows.Forms.Label();
            this.rand = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.Label();
            this.titluT = new System.Windows.Forms.TextBox();
            this.randT = new System.Windows.Forms.TextBox();
            this.addFilm = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Label();
            this.dataT = new System.Windows.Forms.TextBox();
            this.locT = new System.Windows.Forms.TextBox();
            this.viewTickets = new System.Windows.Forms.Button();
            this.angajat = new System.Windows.Forms.Label();
            this.tabel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // film
            // 
            this.film.AutoSize = true;
            this.film.Location = new System.Drawing.Point(30, 110);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(64, 17);
            this.film.TabIndex = 0;
            this.film.Text = "Titlu film:";
            // 
            // rand
            // 
            this.rand.AutoSize = true;
            this.rand.Location = new System.Drawing.Point(30, 147);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(46, 17);
            this.rand.TabIndex = 1;
            this.rand.Text = "Rand:";
            // 
            // loc
            // 
            this.loc.AutoSize = true;
            this.loc.Location = new System.Drawing.Point(30, 179);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(35, 17);
            this.loc.TabIndex = 2;
            this.loc.Text = "Loc:";
            // 
            // titluT
            // 
            this.titluT.Location = new System.Drawing.Point(173, 105);
            this.titluT.Name = "titluT";
            this.titluT.Size = new System.Drawing.Size(256, 22);
            this.titluT.TabIndex = 3;
            // 
            // randT
            // 
            this.randT.Location = new System.Drawing.Point(173, 142);
            this.randT.Name = "randT";
            this.randT.Size = new System.Drawing.Size(256, 22);
            this.randT.TabIndex = 4;
            // 
            // addFilm
            // 
            this.addFilm.Location = new System.Drawing.Point(123, 297);
            this.addFilm.Name = "addFilm";
            this.addFilm.Size = new System.Drawing.Size(100, 41);
            this.addFilm.TabIndex = 5;
            this.addFilm.Text = "Add film";
            this.addFilm.UseVisualStyleBackColor = true;
            this.addFilm.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(30, 215);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(42, 17);
            this.data.TabIndex = 6;
            this.data.Text = "Data:";
            // 
            // dataT
            // 
            this.dataT.Location = new System.Drawing.Point(173, 215);
            this.dataT.Name = "dataT";
            this.dataT.Size = new System.Drawing.Size(256, 22);
            this.dataT.TabIndex = 7;
            // 
            // locT
            // 
            this.locT.Location = new System.Drawing.Point(173, 179);
            this.locT.Name = "locT";
            this.locT.Size = new System.Drawing.Size(256, 22);
            this.locT.TabIndex = 8;
            // 
            // viewTickets
            // 
            this.viewTickets.Location = new System.Drawing.Point(298, 297);
            this.viewTickets.Name = "viewTickets";
            this.viewTickets.Size = new System.Drawing.Size(100, 41);
            this.viewTickets.TabIndex = 9;
            this.viewTickets.Text = "View tickets";
            this.viewTickets.UseVisualStyleBackColor = true;
            this.viewTickets.Click += new System.EventHandler(this.viewTickets_Click);
            // 
            // angajat
            // 
            this.angajat.AutoSize = true;
            this.angajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angajat.Location = new System.Drawing.Point(429, 26);
            this.angajat.Name = "angajat";
            this.angajat.Size = new System.Drawing.Size(86, 25);
            this.angajat.TabIndex = 10;
            this.angajat.Text = "Angajat";
            // 
            // tabel
            // 
            this.tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel.Location = new System.Drawing.Point(471, 67);
            this.tabel.Name = "tabel";
            this.tabel.RowTemplate.Height = 24;
            this.tabel.Size = new System.Drawing.Size(484, 306);
            this.tabel.TabIndex = 11;
            this.tabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabel_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data si ora trebuie sa fie in format DateTime (yyyy-mm-dd hh:mm:ss)";
            // 
            // FormAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabel);
            this.Controls.Add(this.angajat);
            this.Controls.Add(this.viewTickets);
            this.Controls.Add(this.locT);
            this.Controls.Add(this.dataT);
            this.Controls.Add(this.data);
            this.Controls.Add(this.addFilm);
            this.Controls.Add(this.randT);
            this.Controls.Add(this.titluT);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.rand);
            this.Controls.Add(this.film);
            this.Name = "FormAngajat";
            this.Text = "FormAngajat";
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label film;
        private System.Windows.Forms.Label rand;
        private System.Windows.Forms.Label loc;
        private System.Windows.Forms.TextBox titluT;
        private System.Windows.Forms.TextBox randT;
        private System.Windows.Forms.Button addFilm;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.TextBox dataT;
        private System.Windows.Forms.TextBox locT;
        private System.Windows.Forms.Button viewTickets;
        private System.Windows.Forms.Label angajat;
        private System.Windows.Forms.DataGridView tabel;
        private System.Windows.Forms.Label label1;
    }
}