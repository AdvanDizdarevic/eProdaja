namespace eProdaja_UI
{
    partial class KOrisniciForm
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
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.dgv_apiKorisnici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apiKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Location = new System.Drawing.Point(22, 30);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(75, 23);
            this.btnKorisnici.TabIndex = 0;
            this.btnKorisnici.Text = "Call Api";
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.btnKorisnici_Click);
            // 
            // dgv_apiKorisnici
            // 
            this.dgv_apiKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_apiKorisnici.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_apiKorisnici.Location = new System.Drawing.Point(0, 137);
            this.dgv_apiKorisnici.Name = "dgv_apiKorisnici";
            this.dgv_apiKorisnici.Size = new System.Drawing.Size(841, 150);
            this.dgv_apiKorisnici.TabIndex = 1;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 287);
            this.Controls.Add(this.dgv_apiKorisnici);
            this.Controls.Add(this.btnKorisnici);
            this.Name = "frmKorisnici";
            this.Text = "frmKorisnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apiKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.DataGridView dgv_apiKorisnici;
    }
}