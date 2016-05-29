namespace eProdaja_UI
{
    partial class LoginForm
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
            this.txtLozinkaH = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.odustaniBtn = new System.Windows.Forms.Button();
            this.prijavaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLozinkaH
            // 
            this.txtLozinkaH.Location = new System.Drawing.Point(102, 44);
            this.txtLozinkaH.Name = "txtLozinkaH";
            this.txtLozinkaH.PasswordChar = '*';
            this.txtLozinkaH.Size = new System.Drawing.Size(190, 20);
            this.txtLozinkaH.TabIndex = 19;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(102, 18);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(190, 20);
            this.txtKorisnickoIme.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Korisnicko ime";
            // 
            // odustaniBtn
            // 
            this.odustaniBtn.Location = new System.Drawing.Point(102, 79);
            this.odustaniBtn.Name = "odustaniBtn";
            this.odustaniBtn.Size = new System.Drawing.Size(75, 23);
            this.odustaniBtn.TabIndex = 20;
            this.odustaniBtn.Text = "Odustani";
            this.odustaniBtn.UseVisualStyleBackColor = true;
            this.odustaniBtn.Click += new System.EventHandler(this.odustaniBtn_Click);
            // 
            // prijavaBtn
            // 
            this.prijavaBtn.Location = new System.Drawing.Point(217, 79);
            this.prijavaBtn.Name = "prijavaBtn";
            this.prijavaBtn.Size = new System.Drawing.Size(75, 23);
            this.prijavaBtn.TabIndex = 21;
            this.prijavaBtn.Text = "Prijava";
            this.prijavaBtn.UseVisualStyleBackColor = true;
            this.prijavaBtn.Click += new System.EventHandler(this.prijavaBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 132);
            this.Controls.Add(this.prijavaBtn);
            this.Controls.Add(this.odustaniBtn);
            this.Controls.Add(this.txtLozinkaH);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prijava na sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLozinkaH;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button odustaniBtn;
        private System.Windows.Forms.Button prijavaBtn;
    }
}