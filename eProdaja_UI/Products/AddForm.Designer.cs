namespace eProdaja_UI.Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.comboJedinica = new System.Windows.Forms.ComboBox();
            this.comboVrsta = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jed. mjere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Slika";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(66, 41);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(264, 20);
            this.txtSifra.TabIndex = 7;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(66, 77);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(264, 20);
            this.txtNaziv.TabIndex = 8;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(66, 144);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(186, 20);
            this.txtSlika.TabIndex = 11;
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(258, 144);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(75, 23);
            this.btnSlika.TabIndex = 12;
            this.btnSlika.Text = "Dodaj";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(408, 196);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(132, 44);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Sacuvaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(408, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(132, 120);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(66, 106);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(75, 20);
            this.txtCijena.TabIndex = 9;
            // 
            // comboJedinica
            // 
            this.comboJedinica.FormattingEnabled = true;
            this.comboJedinica.Location = new System.Drawing.Point(209, 109);
            this.comboJedinica.Name = "comboJedinica";
            this.comboJedinica.Size = new System.Drawing.Size(121, 21);
            this.comboJedinica.TabIndex = 15;
            // 
            // comboVrsta
            // 
            this.comboVrsta.FormattingEnabled = true;
            this.comboVrsta.Location = new System.Drawing.Point(66, 10);
            this.comboVrsta.Name = "comboVrsta";
            this.comboVrsta.Size = new System.Drawing.Size(264, 21);
            this.comboVrsta.TabIndex = 16;
            this.comboVrsta.SelectedIndexChanged += new System.EventHandler(this.comboVrsta_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(579, 182);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboVrsta);
            this.Controls.Add(this.comboJedinica);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox comboJedinica;
        private System.Windows.Forms.ComboBox comboVrsta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}