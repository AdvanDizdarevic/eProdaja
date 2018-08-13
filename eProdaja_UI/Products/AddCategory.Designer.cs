namespace eProdaja_UI.Products
{
    partial class AddCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivkKategorije = new System.Windows.Forms.TextBox();
            this.chkAktivna = new System.Windows.Forms.CheckBox();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv kategorije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktivna";
            // 
            // txtNazivkKategorije
            // 
            this.txtNazivkKategorije.Location = new System.Drawing.Point(142, 77);
            this.txtNazivkKategorije.Name = "txtNazivkKategorije";
            this.txtNazivkKategorije.Size = new System.Drawing.Size(154, 20);
            this.txtNazivkKategorije.TabIndex = 2;
            this.txtNazivkKategorije.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivkKategorije_Validating);
            // 
            // chkAktivna
            // 
            this.chkAktivna.AutoSize = true;
            this.chkAktivna.Location = new System.Drawing.Point(142, 122);
            this.chkAktivna.Name = "chkAktivna";
            this.chkAktivna.Size = new System.Drawing.Size(64, 17);
            this.chkAktivna.TabIndex = 3;
            this.chkAktivna.Text = "-aktivna";
            this.chkAktivna.UseVisualStyleBackColor = true;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Location = new System.Drawing.Point(105, 229);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(150, 42);
            this.btnDodajKategoriju.TabIndex = 4;
            this.btnDodajKategoriju.Text = "Dodaj";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.chkAktivna);
            this.Controls.Add(this.txtNazivkKategorije);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Text = "Dodaj kategoriju";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivkKategorije;
        private System.Windows.Forms.CheckBox chkAktivna;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}