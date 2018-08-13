namespace eProdaja_UI.Warehouse
{
    partial class AddWarehouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWarehouseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nazivSkladistatxt = new System.Windows.Forms.TextBox();
            this.adresaSkladistatxt = new System.Windows.Forms.TextBox();
            this.opisSkladistatxt = new System.Windows.Forms.TextBox();
            this.statusSkladistachb = new System.Windows.Forms.CheckBox();
            this.dodajSkladistebtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status : ";
            // 
            // nazivSkladistatxt
            // 
            this.nazivSkladistatxt.Location = new System.Drawing.Point(93, 63);
            this.nazivSkladistatxt.Name = "nazivSkladistatxt";
            this.nazivSkladistatxt.Size = new System.Drawing.Size(223, 20);
            this.nazivSkladistatxt.TabIndex = 4;
            this.nazivSkladistatxt.Validating += new System.ComponentModel.CancelEventHandler(this.nazivSkladistatxt_Validating);
            // 
            // adresaSkladistatxt
            // 
            this.adresaSkladistatxt.Location = new System.Drawing.Point(93, 99);
            this.adresaSkladistatxt.Name = "adresaSkladistatxt";
            this.adresaSkladistatxt.Size = new System.Drawing.Size(223, 20);
            this.adresaSkladistatxt.TabIndex = 5;
            this.adresaSkladistatxt.Validating += new System.ComponentModel.CancelEventHandler(this.adresaSkladistatxt_Validating);
            // 
            // opisSkladistatxt
            // 
            this.opisSkladistatxt.Location = new System.Drawing.Point(93, 143);
            this.opisSkladistatxt.Name = "opisSkladistatxt";
            this.opisSkladistatxt.Size = new System.Drawing.Size(223, 20);
            this.opisSkladistatxt.TabIndex = 6;
            this.opisSkladistatxt.Validating += new System.ComponentModel.CancelEventHandler(this.opisSkladistatxt_Validating);
            // 
            // statusSkladistachb
            // 
            this.statusSkladistachb.AutoSize = true;
            this.statusSkladistachb.Location = new System.Drawing.Point(93, 192);
            this.statusSkladistachb.Name = "statusSkladistachb";
            this.statusSkladistachb.Size = new System.Drawing.Size(70, 17);
            this.statusSkladistachb.TabIndex = 7;
            this.statusSkladistachb.Text = " - aktivan";
            this.statusSkladistachb.UseVisualStyleBackColor = true;
            // 
            // dodajSkladistebtn
            // 
            this.dodajSkladistebtn.Location = new System.Drawing.Point(93, 246);
            this.dodajSkladistebtn.Name = "dodajSkladistebtn";
            this.dodajSkladistebtn.Size = new System.Drawing.Size(223, 34);
            this.dodajSkladistebtn.TabIndex = 8;
            this.dodajSkladistebtn.Text = "Dodaj skladište";
            this.dodajSkladistebtn.UseVisualStyleBackColor = true;
            this.dodajSkladistebtn.Click += new System.EventHandler(this.dodajSkladistebtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AddWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.dodajSkladistebtn);
            this.Controls.Add(this.statusSkladistachb);
            this.Controls.Add(this.opisSkladistatxt);
            this.Controls.Add(this.adresaSkladistatxt);
            this.Controls.Add(this.nazivSkladistatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddWarehouseForm";
            this.ShowIcon = false;
            this.Text = "Dodaj Skladište";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nazivSkladistatxt;
        private System.Windows.Forms.TextBox adresaSkladistatxt;
        private System.Windows.Forms.TextBox opisSkladistatxt;
        private System.Windows.Forms.CheckBox statusSkladistachb;
        private System.Windows.Forms.Button dodajSkladistebtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}