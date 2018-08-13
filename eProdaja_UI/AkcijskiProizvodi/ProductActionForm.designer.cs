namespace eProdaja_UI.AkcijskiProizvodi
{
    partial class ProductActionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dodajNaAkcijuBtn = new System.Windows.Forms.Button();
            this.ukloniProizvodBtn = new System.Windows.Forms.Button();
            this.osvjeziListuBtn = new System.Windows.Forms.Button();
            this.urediProizvodBtn = new System.Windows.Forms.Button();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.AkcijskiProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaPopustom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnoDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajNaAkcijuBtn
            // 
            this.dodajNaAkcijuBtn.Location = new System.Drawing.Point(26, 63);
            this.dodajNaAkcijuBtn.Name = "dodajNaAkcijuBtn";
            this.dodajNaAkcijuBtn.Size = new System.Drawing.Size(127, 50);
            this.dodajNaAkcijuBtn.TabIndex = 1;
            this.dodajNaAkcijuBtn.Text = "Dodaj Proizvod na Akciju";
            this.dodajNaAkcijuBtn.UseVisualStyleBackColor = true;
            this.dodajNaAkcijuBtn.Click += new System.EventHandler(this.dodajNaAkcijuBtn_Click);
            // 
            // ukloniProizvodBtn
            // 
            this.ukloniProizvodBtn.Location = new System.Drawing.Point(174, 63);
            this.ukloniProizvodBtn.Name = "ukloniProizvodBtn";
            this.ukloniProizvodBtn.Size = new System.Drawing.Size(127, 50);
            this.ukloniProizvodBtn.TabIndex = 2;
            this.ukloniProizvodBtn.Text = "Ukloni Proizvod sa Akcije";
            this.ukloniProizvodBtn.UseVisualStyleBackColor = true;
            this.ukloniProizvodBtn.Click += new System.EventHandler(this.ukloniProizvodBtn_Click);
            // 
            // osvjeziListuBtn
            // 
            this.osvjeziListuBtn.Location = new System.Drawing.Point(307, 63);
            this.osvjeziListuBtn.Name = "osvjeziListuBtn";
            this.osvjeziListuBtn.Size = new System.Drawing.Size(127, 50);
            this.osvjeziListuBtn.TabIndex = 4;
            this.osvjeziListuBtn.Text = "Osvježi Listu";
            this.osvjeziListuBtn.UseVisualStyleBackColor = true;
            this.osvjeziListuBtn.Click += new System.EventHandler(this.osvjeziListuBtn_Click);
            // 
            // urediProizvodBtn
            // 
            this.urediProizvodBtn.Location = new System.Drawing.Point(440, 63);
            this.urediProizvodBtn.Name = "urediProizvodBtn";
            this.urediProizvodBtn.Size = new System.Drawing.Size(127, 50);
            this.urediProizvodBtn.TabIndex = 5;
            this.urediProizvodBtn.Text = "Uredi Proizvod";
            this.urediProizvodBtn.UseVisualStyleBackColor = true;
            this.urediProizvodBtn.Click += new System.EventHandler(this.urediProizvodBtn_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AkcijskiProizvodID,
            this.ProizvodID,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.SaPopustom,
            this.DatumPocetka,
            this.DatumKraja,
            this.UkupnoDana,
            this.SlikaThumb});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 166);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(845, 336);
            this.metroGrid1.TabIndex = 6;
            // 
            // AkcijskiProizvodID
            // 
            this.AkcijskiProizvodID.DataPropertyName = "AkcijskiProizvodID";
            this.AkcijskiProizvodID.HeaderText = "AkcijskiProizvodID";
            this.AkcijskiProizvodID.Name = "AkcijskiProizvodID";
            this.AkcijskiProizvodID.Visible = false;
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // SaPopustom
            // 
            this.SaPopustom.DataPropertyName = "SaPopustom";
            this.SaPopustom.HeaderText = "Cijena sa popustom";
            this.SaPopustom.Name = "SaPopustom";
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "Datum pocetka akcije";
            this.DatumPocetka.Name = "DatumPocetka";
            // 
            // DatumKraja
            // 
            this.DatumKraja.DataPropertyName = "DatumKraja";
            this.DatumKraja.HeaderText = "Datum kraja akcije";
            this.DatumKraja.Name = "DatumKraja";
            // 
            // UkupnoDana
            // 
            this.UkupnoDana.DataPropertyName = "UkupnoDana";
            this.UkupnoDana.HeaderText = "Ukupno dana do kraja akcije";
            this.UkupnoDana.Name = "UkupnoDana";
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            // 
            // ProductActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 522);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.urediProizvodBtn);
            this.Controls.Add(this.osvjeziListuBtn);
            this.Controls.Add(this.ukloniProizvodBtn);
            this.Controls.Add(this.dodajNaAkcijuBtn);
            this.MaximizeBox = false;
            this.Name = "ProductActionForm";
            this.ShowIcon = false;
            this.Text = "Proizvodi na Akciji";
            this.Load += new System.EventHandler(this.ProductActionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dodajNaAkcijuBtn;
        private System.Windows.Forms.Button ukloniProizvodBtn;
        private System.Windows.Forms.Button osvjeziListuBtn;
        private System.Windows.Forms.Button urediProizvodBtn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AkcijskiProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaPopustom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKraja;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnoDana;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
    }
}