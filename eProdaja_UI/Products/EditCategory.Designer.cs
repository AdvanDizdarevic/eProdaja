namespace eProdaja_UI.Products
{
    partial class EditCategory
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNazivkategorije = new System.Windows.Forms.TextBox();
            this.chkAktivna = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv kategorije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktivna";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spasi promjene";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNazivkategorije
            // 
            this.txtNazivkategorije.Location = new System.Drawing.Point(137, 85);
            this.txtNazivkategorije.Name = "txtNazivkategorije";
            this.txtNazivkategorije.Size = new System.Drawing.Size(170, 20);
            this.txtNazivkategorije.TabIndex = 3;
            this.txtNazivkategorije.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivkategorije_Validating);
            // 
            // chkAktivna
            // 
            this.chkAktivna.AutoSize = true;
            this.chkAktivna.Location = new System.Drawing.Point(137, 140);
            this.chkAktivna.Name = "chkAktivna";
            this.chkAktivna.Size = new System.Drawing.Size(64, 17);
            this.chkAktivna.TabIndex = 4;
            this.chkAktivna.Text = "-aktivna";
            this.chkAktivna.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 357);
            this.Controls.Add(this.chkAktivna);
            this.Controls.Add(this.txtNazivkategorije);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCategory";
            this.Text = "Edit kategorije";
            this.Load += new System.EventHandler(this.EditCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNazivkategorije;
        private System.Windows.Forms.CheckBox chkAktivna;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}