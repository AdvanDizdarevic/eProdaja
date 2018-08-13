namespace eProdaja_UI.AkcijskiProizvodi
{
    partial class AddProductOnActionDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.datumKrajaAkcijeDtp = new System.Windows.Forms.DateTimePicker();
            this.nazivProizvodaLbl = new System.Windows.Forms.Label();
            this.sifraProizvodaLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.popustCmb = new System.Windows.Forms.ComboBox();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Datum kraja proizvoda na akciji : ";
            // 
            // datumKrajaAkcijeDtp
            // 
            this.datumKrajaAkcijeDtp.Location = new System.Drawing.Point(35, 222);
            this.datumKrajaAkcijeDtp.Name = "datumKrajaAkcijeDtp";
            this.datumKrajaAkcijeDtp.Size = new System.Drawing.Size(200, 20);
            this.datumKrajaAkcijeDtp.TabIndex = 12;
            this.datumKrajaAkcijeDtp.Validating += new System.ComponentModel.CancelEventHandler(this.datumKrajaAkcijeDtp_Validating);
            // 
            // nazivProizvodaLbl
            // 
            this.nazivProizvodaLbl.AutoSize = true;
            this.nazivProizvodaLbl.Location = new System.Drawing.Point(131, 104);
            this.nazivProizvodaLbl.Name = "nazivProizvodaLbl";
            this.nazivProizvodaLbl.Size = new System.Drawing.Size(0, 13);
            this.nazivProizvodaLbl.TabIndex = 11;
            // 
            // sifraProizvodaLbl
            // 
            this.sifraProizvodaLbl.AutoSize = true;
            this.sifraProizvodaLbl.Location = new System.Drawing.Point(131, 62);
            this.sifraProizvodaLbl.Name = "sifraProizvodaLbl";
            this.sifraProizvodaLbl.Size = new System.Drawing.Size(0, 13);
            this.sifraProizvodaLbl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naziv Proizvoda : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sifra Proizvoda :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Popust :  ";
            // 
            // popustCmb
            // 
            this.popustCmb.FormattingEnabled = true;
            this.popustCmb.Location = new System.Drawing.Point(134, 145);
            this.popustCmb.Name = "popustCmb";
            this.popustCmb.Size = new System.Drawing.Size(121, 21);
            this.popustCmb.TabIndex = 15;
            this.popustCmb.Validating += new System.ComponentModel.CancelEventHandler(this.popustCmb_Validating);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(134, 298);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(254, 47);
            this.dodajBtn.TabIndex = 16;
            this.dodajBtn.Text = "Dodaj proizvod";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddProductOnActionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 354);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.popustCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumKrajaAkcijeDtp);
            this.Controls.Add(this.nazivProizvodaLbl);
            this.Controls.Add(this.sifraProizvodaLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "AddProductOnActionDetails";
            this.ShowIcon = false;
            this.Text = "Dodaj Proizvod na Akciju Detalji";
            this.Load += new System.EventHandler(this.AddProductOnActionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datumKrajaAkcijeDtp;
        private System.Windows.Forms.Label nazivProizvodaLbl;
        private System.Windows.Forms.Label sifraProizvodaLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox popustCmb;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}