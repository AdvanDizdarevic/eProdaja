namespace eProdaja_UI.Supliers
{
    partial class EditSupplier
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
            this.spasiPromjenebtn = new System.Windows.Forms.Button();
            this.napomenaInputtxt = new System.Windows.Forms.RichTextBox();
            this.statuschb = new System.Windows.Forms.CheckBox();
            this.ziroRacunInputtxt = new System.Windows.Forms.TextBox();
            this.webInputtxt = new System.Windows.Forms.TextBox();
            this.faksInputtxt = new System.Windows.Forms.MaskedTextBox();
            this.telefonInputtxt = new System.Windows.Forms.MaskedTextBox();
            this.mailInputtxt = new System.Windows.Forms.TextBox();
            this.adresaInputtxt = new System.Windows.Forms.TextBox();
            this.kontaktOsobaInputtxt = new System.Windows.Forms.TextBox();
            this.nazivInputtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // spasiPromjenebtn
            // 
            this.spasiPromjenebtn.Location = new System.Drawing.Point(94, 393);
            this.spasiPromjenebtn.Name = "spasiPromjenebtn";
            this.spasiPromjenebtn.Size = new System.Drawing.Size(200, 45);
            this.spasiPromjenebtn.TabIndex = 41;
            this.spasiPromjenebtn.Text = "Spasi promjene";
            this.spasiPromjenebtn.UseVisualStyleBackColor = true;
            this.spasiPromjenebtn.Click += new System.EventHandler(this.spasiPromjenebtn_Click);
            // 
            // napomenaInputtxt
            // 
            this.napomenaInputtxt.Location = new System.Drawing.Point(340, 108);
            this.napomenaInputtxt.MaxLength = 500;
            this.napomenaInputtxt.Name = "napomenaInputtxt";
            this.napomenaInputtxt.Size = new System.Drawing.Size(226, 213);
            this.napomenaInputtxt.TabIndex = 40;
            this.napomenaInputtxt.Text = "";
            // 
            // statuschb
            // 
            this.statuschb.AutoSize = true;
            this.statuschb.Location = new System.Drawing.Point(94, 343);
            this.statuschb.Name = "statuschb";
            this.statuschb.Size = new System.Drawing.Size(67, 17);
            this.statuschb.TabIndex = 39;
            this.statuschb.Text = "- aktivan";
            this.statuschb.UseVisualStyleBackColor = true;
            // 
            // ziroRacunInputtxt
            // 
            this.ziroRacunInputtxt.Location = new System.Drawing.Point(94, 301);
            this.ziroRacunInputtxt.Name = "ziroRacunInputtxt";
            this.ziroRacunInputtxt.Size = new System.Drawing.Size(200, 20);
            this.ziroRacunInputtxt.TabIndex = 38;
            this.ziroRacunInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.ziroRacunInputtxt_Validating);
            // 
            // webInputtxt
            // 
            this.webInputtxt.Location = new System.Drawing.Point(94, 237);
            this.webInputtxt.Name = "webInputtxt";
            this.webInputtxt.Size = new System.Drawing.Size(200, 20);
            this.webInputtxt.TabIndex = 37;
            this.webInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.webInputtxt_Validating);
            // 
            // faksInputtxt
            // 
            this.faksInputtxt.Location = new System.Drawing.Point(94, 205);
            this.faksInputtxt.Mask = "(999) 000-000";
            this.faksInputtxt.Name = "faksInputtxt";
            this.faksInputtxt.Size = new System.Drawing.Size(200, 20);
            this.faksInputtxt.TabIndex = 36;
            this.faksInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.faksInputtxt_Validating);
            // 
            // telefonInputtxt
            // 
            this.telefonInputtxt.Location = new System.Drawing.Point(94, 169);
            this.telefonInputtxt.Mask = "(999) 000-000";
            this.telefonInputtxt.Name = "telefonInputtxt";
            this.telefonInputtxt.Size = new System.Drawing.Size(200, 20);
            this.telefonInputtxt.TabIndex = 35;
            this.telefonInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInputtxt_Validating);
            // 
            // mailInputtxt
            // 
            this.mailInputtxt.Location = new System.Drawing.Point(94, 269);
            this.mailInputtxt.Name = "mailInputtxt";
            this.mailInputtxt.Size = new System.Drawing.Size(200, 20);
            this.mailInputtxt.TabIndex = 34;
            this.mailInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.mailInputtxt_Validating);
            // 
            // adresaInputtxt
            // 
            this.adresaInputtxt.Location = new System.Drawing.Point(94, 136);
            this.adresaInputtxt.Name = "adresaInputtxt";
            this.adresaInputtxt.Size = new System.Drawing.Size(200, 20);
            this.adresaInputtxt.TabIndex = 33;
            this.adresaInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.adresaInputtxt_Validating);
            // 
            // kontaktOsobaInputtxt
            // 
            this.kontaktOsobaInputtxt.Location = new System.Drawing.Point(94, 105);
            this.kontaktOsobaInputtxt.Name = "kontaktOsobaInputtxt";
            this.kontaktOsobaInputtxt.Size = new System.Drawing.Size(200, 20);
            this.kontaktOsobaInputtxt.TabIndex = 32;
            this.kontaktOsobaInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.kontaktOsobaInputtxt_Validating);
            // 
            // nazivInputtxt
            // 
            this.nazivInputtxt.Location = new System.Drawing.Point(94, 79);
            this.nazivInputtxt.Name = "nazivInputtxt";
            this.nazivInputtxt.Size = new System.Drawing.Size(200, 20);
            this.nazivInputtxt.TabIndex = 31;
            this.nazivInputtxt.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInputtxt_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Status : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Napomena : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Žiroračun : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "E-mail : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Web : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fax : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefon : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adresa : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kontakt Osoba :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Naziv : ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 454);
            this.Controls.Add(this.spasiPromjenebtn);
            this.Controls.Add(this.napomenaInputtxt);
            this.Controls.Add(this.statuschb);
            this.Controls.Add(this.ziroRacunInputtxt);
            this.Controls.Add(this.webInputtxt);
            this.Controls.Add(this.faksInputtxt);
            this.Controls.Add(this.telefonInputtxt);
            this.Controls.Add(this.mailInputtxt);
            this.Controls.Add(this.adresaInputtxt);
            this.Controls.Add(this.kontaktOsobaInputtxt);
            this.Controls.Add(this.nazivInputtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSupplier";
            this.ShowIcon = false;
            this.Text = "Uredi Dobavljača";
            this.Load += new System.EventHandler(this.EditSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spasiPromjenebtn;
        private System.Windows.Forms.RichTextBox napomenaInputtxt;
        private System.Windows.Forms.CheckBox statuschb;
        private System.Windows.Forms.TextBox ziroRacunInputtxt;
        private System.Windows.Forms.TextBox webInputtxt;
        private System.Windows.Forms.MaskedTextBox faksInputtxt;
        private System.Windows.Forms.MaskedTextBox telefonInputtxt;
        private System.Windows.Forms.TextBox mailInputtxt;
        private System.Windows.Forms.TextBox adresaInputtxt;
        private System.Windows.Forms.TextBox kontaktOsobaInputtxt;
        private System.Windows.Forms.TextBox nazivInputtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}