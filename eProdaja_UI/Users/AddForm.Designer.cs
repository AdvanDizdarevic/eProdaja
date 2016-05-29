namespace eProdaja_UI.Users
{
    partial class AddForm
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
            this.txtLozinkaH = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajNovi = new System.Windows.Forms.Button();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLozinkaH
            // 
            this.txtLozinkaH.Location = new System.Drawing.Point(110, 194);
            this.txtLozinkaH.Name = "txtLozinkaH";
            this.txtLozinkaH.Size = new System.Drawing.Size(165, 20);
            this.txtLozinkaH.TabIndex = 30;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(110, 168);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(165, 20);
            this.txtKorisnickoIme.TabIndex = 29;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(107, 110);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(168, 20);
            this.txtTelefon.TabIndex = 28;
            this.txtTelefon.Text = " ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(107, 55);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(168, 20);
            this.txtPrezime.TabIndex = 26;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(107, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(168, 20);
            this.txtIme.TabIndex = 25;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Uloge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Korisnicko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime";
            // 
            // btnDodajNovi
            // 
            this.btnDodajNovi.Location = new System.Drawing.Point(200, 358);
            this.btnDodajNovi.Name = "btnDodajNovi";
            this.btnDodajNovi.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNovi.TabIndex = 32;
            this.btnDodajNovi.Text = "Dodaj";
            this.btnDodajNovi.UseVisualStyleBackColor = true;
            this.btnDodajNovi.Click += new System.EventHandler(this.btnDodajNovi_Click);
            // 
            // ulogeList
            // 
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(107, 225);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(168, 94);
            this.ulogeList.TabIndex = 33;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 408);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.btnDodajNovi);
            this.Controls.Add(this.txtLozinkaH);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "Novi korisnik";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLozinkaH;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajNovi;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}