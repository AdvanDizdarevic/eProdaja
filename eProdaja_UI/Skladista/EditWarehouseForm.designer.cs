namespace eProdaja_UI.Warehouse
{
    partial class EditWarehouseForm
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
            this.statusSkladistachb = new System.Windows.Forms.CheckBox();
            this.opisSkladistatxt = new System.Windows.Forms.TextBox();
            this.adresaSkladistatxt = new System.Windows.Forms.TextBox();
            this.nazivSkladistatxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // spasiPromjenebtn
            // 
            this.spasiPromjenebtn.Location = new System.Drawing.Point(99, 246);
            this.spasiPromjenebtn.Name = "spasiPromjenebtn";
            this.spasiPromjenebtn.Size = new System.Drawing.Size(223, 34);
            this.spasiPromjenebtn.TabIndex = 17;
            this.spasiPromjenebtn.Text = "Spasi promjene";
            this.spasiPromjenebtn.UseVisualStyleBackColor = true;
            this.spasiPromjenebtn.Click += new System.EventHandler(this.spasiPromjenebtn_Click);
            // 
            // statusSkladistachb
            // 
            this.statusSkladistachb.AutoSize = true;
            this.statusSkladistachb.Location = new System.Drawing.Point(99, 192);
            this.statusSkladistachb.Name = "statusSkladistachb";
            this.statusSkladistachb.Size = new System.Drawing.Size(70, 17);
            this.statusSkladistachb.TabIndex = 16;
            this.statusSkladistachb.Text = " - aktivan";
            this.statusSkladistachb.UseVisualStyleBackColor = true;
            // 
            // opisSkladistatxt
            // 
            this.opisSkladistatxt.Location = new System.Drawing.Point(99, 143);
            this.opisSkladistatxt.Name = "opisSkladistatxt";
            this.opisSkladistatxt.Size = new System.Drawing.Size(223, 20);
            this.opisSkladistatxt.TabIndex = 15;
            this.opisSkladistatxt.Validating += new System.ComponentModel.CancelEventHandler(this.opisSkladistatxt_Validating);
            // 
            // adresaSkladistatxt
            // 
            this.adresaSkladistatxt.Location = new System.Drawing.Point(99, 99);
            this.adresaSkladistatxt.Name = "adresaSkladistatxt";
            this.adresaSkladistatxt.Size = new System.Drawing.Size(223, 20);
            this.adresaSkladistatxt.TabIndex = 14;
            this.adresaSkladistatxt.Validating += new System.ComponentModel.CancelEventHandler(this.adresaSkladistatxt_Validating);
            // 
            // nazivSkladistatxt
            // 
            this.nazivSkladistatxt.Location = new System.Drawing.Point(99, 63);
            this.nazivSkladistatxt.Name = "nazivSkladistatxt";
            this.nazivSkladistatxt.Size = new System.Drawing.Size(223, 20);
            this.nazivSkladistatxt.TabIndex = 13;
            this.nazivSkladistatxt.Validating += new System.ComponentModel.CancelEventHandler(this.nazivSkladistatxt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Opis : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adresa :  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv : ";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 300);
            this.Controls.Add(this.spasiPromjenebtn);
            this.Controls.Add(this.statusSkladistachb);
            this.Controls.Add(this.opisSkladistatxt);
            this.Controls.Add(this.adresaSkladistatxt);
            this.Controls.Add(this.nazivSkladistatxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditWarehouseForm";
            this.ShowIcon = false;
            this.Text = "Uredi Skladište";
            this.Load += new System.EventHandler(this.EditWarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spasiPromjenebtn;
        private System.Windows.Forms.CheckBox statusSkladistachb;
        private System.Windows.Forms.TextBox opisSkladistatxt;
        private System.Windows.Forms.TextBox adresaSkladistatxt;
        private System.Windows.Forms.TextBox nazivSkladistatxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}