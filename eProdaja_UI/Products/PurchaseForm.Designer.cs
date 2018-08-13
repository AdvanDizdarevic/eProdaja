namespace eProdaja_UI.Products
{
    partial class PurchaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dobavljac = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textKontakt = new System.Windows.Forms.TextBox();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textNapomena = new System.Windows.Forms.TextBox();
            this.textPDV = new System.Windows.Forms.TextBox();
            this.textIznos = new System.Windows.Forms.TextBox();
            this.textBrFakture = new System.Windows.Forms.TextBox();
            this.Napomena = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSkladiste = new System.Windows.Forms.ComboBox();
            this.Stavke = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gridSkladista = new MetroFramework.Controls.MetroGrid();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ukloniProizvod = new System.Windows.Forms.Button();
            this.textCijena = new System.Windows.Forms.TextBox();
            this.textKolicina = new System.Windows.Forms.TextBox();
            this.textSifraProizvoda = new System.Windows.Forms.TextBox();
            this.btnZakljuci = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnTraziProizvod = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Dobavljac.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Stavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSkladista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dobavljac
            // 
            this.Dobavljac.Controls.Add(this.button1);
            this.Dobavljac.Controls.Add(this.textTelefon);
            this.Dobavljac.Controls.Add(this.textKontakt);
            this.Dobavljac.Controls.Add(this.textNaziv);
            this.Dobavljac.Controls.Add(this.label3);
            this.Dobavljac.Controls.Add(this.label2);
            this.Dobavljac.Controls.Add(this.label1);
            this.Dobavljac.Location = new System.Drawing.Point(23, 63);
            this.Dobavljac.Name = "Dobavljac";
            this.Dobavljac.Size = new System.Drawing.Size(705, 182);
            this.Dobavljac.TabIndex = 0;
            this.Dobavljac.TabStop = false;
            this.Dobavljac.Text = "Dobavljac";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pretraga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Validating += new System.ComponentModel.CancelEventHandler(this.button1_Validating);
            // 
            // textTelefon
            // 
            this.textTelefon.Location = new System.Drawing.Point(98, 92);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.ReadOnly = true;
            this.textTelefon.Size = new System.Drawing.Size(253, 20);
            this.textTelefon.TabIndex = 5;
            // 
            // textKontakt
            // 
            this.textKontakt.Location = new System.Drawing.Point(98, 67);
            this.textKontakt.Name = "textKontakt";
            this.textKontakt.ReadOnly = true;
            this.textKontakt.Size = new System.Drawing.Size(253, 20);
            this.textKontakt.TabIndex = 4;
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(98, 38);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.ReadOnly = true;
            this.textNaziv.Size = new System.Drawing.Size(253, 20);
            this.textNaziv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kontak osoba :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.textNapomena);
            this.groupBox1.Controls.Add(this.textPDV);
            this.groupBox1.Controls.Add(this.textIznos);
            this.groupBox1.Controls.Add(this.textBrFakture);
            this.groupBox1.Controls.Add(this.Napomena);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboSkladiste);
            this.groupBox1.Location = new System.Drawing.Point(23, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ulazna faktura";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(98, 75);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(275, 20);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
            // 
            // textNapomena
            // 
            this.textNapomena.Location = new System.Drawing.Point(468, 19);
            this.textNapomena.Multiline = true;
            this.textNapomena.Name = "textNapomena";
            this.textNapomena.Size = new System.Drawing.Size(206, 104);
            this.textNapomena.TabIndex = 11;
            // 
            // textPDV
            // 
            this.textPDV.Location = new System.Drawing.Point(273, 100);
            this.textPDV.Name = "textPDV";
            this.textPDV.ReadOnly = true;
            this.textPDV.Size = new System.Drawing.Size(100, 20);
            this.textPDV.TabIndex = 10;
            // 
            // textIznos
            // 
            this.textIznos.Location = new System.Drawing.Point(98, 100);
            this.textIznos.Name = "textIznos";
            this.textIznos.ReadOnly = true;
            this.textIznos.Size = new System.Drawing.Size(100, 20);
            this.textIznos.TabIndex = 9;
            // 
            // textBrFakture
            // 
            this.textBrFakture.Location = new System.Drawing.Point(98, 49);
            this.textBrFakture.Name = "textBrFakture";
            this.textBrFakture.Size = new System.Drawing.Size(275, 20);
            this.textBrFakture.TabIndex = 7;
            this.textBrFakture.Validating += new System.ComponentModel.CancelEventHandler(this.textBrFakture_Validating);
            // 
            // Napomena
            // 
            this.Napomena.AutoSize = true;
            this.Napomena.Location = new System.Drawing.Point(379, 23);
            this.Napomena.Name = "Napomena";
            this.Napomena.Size = new System.Drawing.Size(59, 13);
            this.Napomena.TabIndex = 6;
            this.Napomena.Text = "Napomena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "PDV :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Iznos racuna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Datum : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Broj fakture : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Skladiste :";
            // 
            // comboSkladiste
            // 
            this.comboSkladiste.FormattingEnabled = true;
            this.comboSkladiste.Location = new System.Drawing.Point(98, 20);
            this.comboSkladiste.Name = "comboSkladiste";
            this.comboSkladiste.Size = new System.Drawing.Size(275, 21);
            this.comboSkladiste.TabIndex = 0;
            this.comboSkladiste.Validating += new System.ComponentModel.CancelEventHandler(this.comboSkladiste_Validating);
            // 
            // Stavke
            // 
            this.Stavke.Controls.Add(this.label12);
            this.Stavke.Controls.Add(this.gridSkladista);
            this.Stavke.Controls.Add(this.btn_ukloniProizvod);
            this.Stavke.Controls.Add(this.textCijena);
            this.Stavke.Controls.Add(this.textKolicina);
            this.Stavke.Controls.Add(this.textSifraProizvoda);
            this.Stavke.Controls.Add(this.btnZakljuci);
            this.Stavke.Controls.Add(this.btnDodaj);
            this.Stavke.Controls.Add(this.btnTraziProizvod);
            this.Stavke.Controls.Add(this.label11);
            this.Stavke.Controls.Add(this.label10);
            this.Stavke.Controls.Add(this.label9);
            this.Stavke.Location = new System.Drawing.Point(23, 394);
            this.Stavke.Name = "Stavke";
            this.Stavke.Size = new System.Drawing.Size(705, 239);
            this.Stavke.TabIndex = 2;
            this.Stavke.TabStop = false;
            this.Stavke.Text = "Stavke";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "*Doubleclick na proizvod za brisanje sa liste";
            // 
            // gridSkladista
            // 
            this.gridSkladista.AllowUserToResizeRows = false;
            this.gridSkladista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSkladista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSkladista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSkladista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSkladista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSkladista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Proizvodi,
            this.Cijena,
            this.Kolicina});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSkladista.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridSkladista.EnableHeadersVisualStyles = false;
            this.gridSkladista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSkladista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSkladista.Location = new System.Drawing.Point(18, 112);
            this.gridSkladista.Name = "gridSkladista";
            this.gridSkladista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSkladista.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridSkladista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSkladista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSkladista.Size = new System.Drawing.Size(466, 121);
            this.gridSkladista.TabIndex = 11;
            this.gridSkladista.Validating += new System.ComponentModel.CancelEventHandler(this.gridSkladista_Validating);
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.Visible = false;
            // 
            // Proizvodi
            // 
            this.Proizvodi.DataPropertyName = "Proizvodi";
            this.Proizvodi.HeaderText = "Proizvod";
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.Width = 200;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            // 
            // btn_ukloniProizvod
            // 
            this.btn_ukloniProizvod.Location = new System.Drawing.Point(540, 99);
            this.btn_ukloniProizvod.Name = "btn_ukloniProizvod";
            this.btn_ukloniProizvod.Size = new System.Drawing.Size(134, 23);
            this.btn_ukloniProizvod.TabIndex = 10;
            this.btn_ukloniProizvod.Text = "Ukloni oznaceni";
            this.btn_ukloniProizvod.UseVisualStyleBackColor = true;
            this.btn_ukloniProizvod.Click += new System.EventHandler(this.btn_ukloniProizvod_Click);
            // 
            // textCijena
            // 
            this.textCijena.Location = new System.Drawing.Point(283, 60);
            this.textCijena.Name = "textCijena";
            this.textCijena.Size = new System.Drawing.Size(113, 20);
            this.textCijena.TabIndex = 9;
            this.textCijena.Text = "0000.00";
            this.textCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCijena_KeyPress);
            // 
            // textKolicina
            // 
            this.textKolicina.Location = new System.Drawing.Point(104, 60);
            this.textKolicina.Name = "textKolicina";
            this.textKolicina.Size = new System.Drawing.Size(116, 20);
            this.textKolicina.TabIndex = 8;
            this.textKolicina.Text = "000";
            // 
            // textSifraProizvoda
            // 
            this.textSifraProizvoda.Location = new System.Drawing.Point(104, 30);
            this.textSifraProizvoda.Name = "textSifraProizvoda";
            this.textSifraProizvoda.Size = new System.Drawing.Size(116, 20);
            this.textSifraProizvoda.TabIndex = 7;
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.Location = new System.Drawing.Point(540, 170);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(150, 63);
            this.btnZakljuci.TabIndex = 6;
            this.btnZakljuci.Text = "Zakljuci";
            this.btnZakljuci.UseVisualStyleBackColor = true;
            this.btnZakljuci.Click += new System.EventHandler(this.btnZakljuci_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(415, 58);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(105, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnTraziProizvod
            // 
            this.btnTraziProizvod.Location = new System.Drawing.Point(283, 27);
            this.btnTraziProizvod.Name = "btnTraziProizvod";
            this.btnTraziProizvod.Size = new System.Drawing.Size(113, 23);
            this.btnTraziProizvod.TabIndex = 4;
            this.btnTraziProizvod.Text = "Trazi proizvod";
            this.btnTraziProizvod.UseVisualStyleBackColor = true;
            this.btnTraziProizvod.Click += new System.EventHandler(this.btnTraziProizvod_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cijena :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Kolicina :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Naziv autora : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 649);
            this.Controls.Add(this.Stavke);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dobavljac);
            this.Name = "PurchaseForm";
            this.Text = "Nabavka proizvoda";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.Dobavljac.ResumeLayout(false);
            this.Dobavljac.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Stavke.ResumeLayout(false);
            this.Stavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSkladista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Dobavljac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.TextBox textKontakt;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textNapomena;
        private System.Windows.Forms.TextBox textPDV;
        private System.Windows.Forms.TextBox textIznos;
        private System.Windows.Forms.TextBox textBrFakture;
        private System.Windows.Forms.Label Napomena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboSkladiste;
        private System.Windows.Forms.GroupBox Stavke;
        private System.Windows.Forms.TextBox textCijena;
        private System.Windows.Forms.TextBox textKolicina;
        private System.Windows.Forms.TextBox textSifraProizvoda;
        private System.Windows.Forms.Button btnZakljuci;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnTraziProizvod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ukloniProizvod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroGrid gridSkladista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.Label label12;
    }
}