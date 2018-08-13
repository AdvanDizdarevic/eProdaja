namespace eProdaja_UI.Supliers
{
    partial class SupliersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pretragabtn = new System.Windows.Forms.Button();
            this.pretragaDobavljactxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prikaziSveProizvodebtn = new System.Windows.Forms.Button();
            this.prikaziNeAktivneProizvodebtn = new System.Windows.Forms.Button();
            this.prikaziAktivneProizvodebtn = new System.Windows.Forms.Button();
            this.urediProizvodbtn = new System.Windows.Forms.Button();
            this.dodajProizvodbtn = new System.Windows.Forms.Button();
            this.izbrisiPorizvodbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.napomenatxt = new System.Windows.Forms.RichTextBox();
            this.dobavljacidgw = new MetroFramework.Controls.MetroGrid();
            this.DobavljacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Web = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZiroRacuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacidgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.Location = new System.Drawing.Point(10, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Double click za odabir dobavljaca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pretragabtn);
            this.groupBox1.Controls.Add(this.pretragaDobavljactxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga dobavljača";
            // 
            // pretragabtn
            // 
            this.pretragabtn.Location = new System.Drawing.Point(297, 60);
            this.pretragabtn.Name = "pretragabtn";
            this.pretragabtn.Size = new System.Drawing.Size(83, 23);
            this.pretragabtn.TabIndex = 2;
            this.pretragabtn.Text = "Traži";
            this.pretragabtn.UseVisualStyleBackColor = true;
            this.pretragabtn.Click += new System.EventHandler(this.pretragabtn_Click);
            // 
            // pretragaDobavljactxt
            // 
            this.pretragaDobavljactxt.Location = new System.Drawing.Point(13, 60);
            this.pretragaDobavljactxt.Name = "pretragaDobavljactxt";
            this.pretragaDobavljactxt.Size = new System.Drawing.Size(260, 20);
            this.pretragaDobavljactxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pretraži po Nazivu ili Kotakt Osobi : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prikaziSveProizvodebtn);
            this.groupBox2.Controls.Add(this.prikaziNeAktivneProizvodebtn);
            this.groupBox2.Controls.Add(this.prikaziAktivneProizvodebtn);
            this.groupBox2.Controls.Add(this.urediProizvodbtn);
            this.groupBox2.Controls.Add(this.dodajProizvodbtn);
            this.groupBox2.Controls.Add(this.izbrisiPorizvodbtn);
            this.groupBox2.Location = new System.Drawing.Point(18, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dobavljaci";
            // 
            // prikaziSveProizvodebtn
            // 
            this.prikaziSveProizvodebtn.Location = new System.Drawing.Point(297, 23);
            this.prikaziSveProizvodebtn.Name = "prikaziSveProizvodebtn";
            this.prikaziSveProizvodebtn.Size = new System.Drawing.Size(77, 99);
            this.prikaziSveProizvodebtn.TabIndex = 42;
            this.prikaziSveProizvodebtn.Text = "Refresh";
            this.prikaziSveProizvodebtn.UseVisualStyleBackColor = true;
            this.prikaziSveProizvodebtn.Click += new System.EventHandler(this.prikaziSveProizvodebtn_Click);
            // 
            // prikaziNeAktivneProizvodebtn
            // 
            this.prikaziNeAktivneProizvodebtn.Location = new System.Drawing.Point(161, 73);
            this.prikaziNeAktivneProizvodebtn.Name = "prikaziNeAktivneProizvodebtn";
            this.prikaziNeAktivneProizvodebtn.Size = new System.Drawing.Size(112, 45);
            this.prikaziNeAktivneProizvodebtn.TabIndex = 41;
            this.prikaziNeAktivneProizvodebtn.Text = "Prikaži ne aktivne";
            this.prikaziNeAktivneProizvodebtn.UseVisualStyleBackColor = true;
            this.prikaziNeAktivneProizvodebtn.Click += new System.EventHandler(this.prikaziNeAktivneProizvodebtn_Click);
            // 
            // prikaziAktivneProizvodebtn
            // 
            this.prikaziAktivneProizvodebtn.Location = new System.Drawing.Point(161, 28);
            this.prikaziAktivneProizvodebtn.Name = "prikaziAktivneProizvodebtn";
            this.prikaziAktivneProizvodebtn.Size = new System.Drawing.Size(112, 39);
            this.prikaziAktivneProizvodebtn.TabIndex = 40;
            this.prikaziAktivneProizvodebtn.Text = "Prikaži aktivne";
            this.prikaziAktivneProizvodebtn.UseVisualStyleBackColor = true;
            this.prikaziAktivneProizvodebtn.Click += new System.EventHandler(this.prikaziAktivneProizvodebtn_Click);
            // 
            // urediProizvodbtn
            // 
            this.urediProizvodbtn.Location = new System.Drawing.Point(22, 95);
            this.urediProizvodbtn.Name = "urediProizvodbtn";
            this.urediProizvodbtn.Size = new System.Drawing.Size(112, 23);
            this.urediProizvodbtn.TabIndex = 39;
            this.urediProizvodbtn.Text = "Uredi Dobavljača";
            this.urediProizvodbtn.UseVisualStyleBackColor = true;
            this.urediProizvodbtn.Click += new System.EventHandler(this.urediProizvodbtn_Click);
            // 
            // dodajProizvodbtn
            // 
            this.dodajProizvodbtn.Location = new System.Drawing.Point(22, 28);
            this.dodajProizvodbtn.Name = "dodajProizvodbtn";
            this.dodajProizvodbtn.Size = new System.Drawing.Size(112, 23);
            this.dodajProizvodbtn.TabIndex = 37;
            this.dodajProizvodbtn.Text = "Dodaj Dobavljača";
            this.dodajProizvodbtn.UseVisualStyleBackColor = true;
            this.dodajProizvodbtn.Click += new System.EventHandler(this.dodajProizvodbtn_Click);
            // 
            // izbrisiPorizvodbtn
            // 
            this.izbrisiPorizvodbtn.Location = new System.Drawing.Point(22, 61);
            this.izbrisiPorizvodbtn.Name = "izbrisiPorizvodbtn";
            this.izbrisiPorizvodbtn.Size = new System.Drawing.Size(112, 23);
            this.izbrisiPorizvodbtn.TabIndex = 38;
            this.izbrisiPorizvodbtn.Text = "Izbriši Dobavljača";
            this.izbrisiPorizvodbtn.UseVisualStyleBackColor = true;
            this.izbrisiPorizvodbtn.Click += new System.EventHandler(this.izbrisiPorizvodbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.napomenatxt);
            this.groupBox3.Location = new System.Drawing.Point(410, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 283);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Napomena";
            // 
            // napomenatxt
            // 
            this.napomenatxt.Location = new System.Drawing.Point(15, 19);
            this.napomenatxt.Name = "napomenatxt";
            this.napomenatxt.ReadOnly = true;
            this.napomenatxt.Size = new System.Drawing.Size(292, 247);
            this.napomenatxt.TabIndex = 0;
            this.napomenatxt.Text = "";
            // 
            // dobavljacidgw
            // 
            this.dobavljacidgw.AllowUserToResizeRows = false;
            this.dobavljacidgw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dobavljacidgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dobavljacidgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dobavljacidgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dobavljacidgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dobavljacidgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dobavljacidgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DobavljacID,
            this.Naziv,
            this.KontaktOsoba,
            this.Adresa,
            this.Telefon,
            this.Fax,
            this.Web,
            this.Email,
            this.ZiroRacuni,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dobavljacidgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.dobavljacidgw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dobavljacidgw.EnableHeadersVisualStyles = false;
            this.dobavljacidgw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dobavljacidgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dobavljacidgw.Location = new System.Drawing.Point(20, 425);
            this.dobavljacidgw.Name = "dobavljacidgw";
            this.dobavljacidgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dobavljacidgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dobavljacidgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dobavljacidgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dobavljacidgw.Size = new System.Drawing.Size(703, 237);
            this.dobavljacidgw.TabIndex = 5;
            this.dobavljacidgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dobavljacidgw_CellDoubleClick_1);
            // 
            // DobavljacID
            // 
            this.DobavljacID.DataPropertyName = "DobavljacID";
            this.DobavljacID.HeaderText = "DobavljacID";
            this.DobavljacID.Name = "DobavljacID";
            this.DobavljacID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontak osoba";
            this.KontaktOsoba.Name = "KontaktOsoba";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            // 
            // Web
            // 
            this.Web.DataPropertyName = "Web";
            this.Web.HeaderText = "Web";
            this.Web.Name = "Web";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // ZiroRacuni
            // 
            this.ZiroRacuni.DataPropertyName = "ZiroRacuni";
            this.ZiroRacuni.HeaderText = "Ziro racuni";
            this.ZiroRacuni.Name = "ZiroRacuni";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // SupliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 682);
            this.Controls.Add(this.dobavljacidgw);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SupliersForm";
            this.ShowIcon = false;
            this.Text = "Dobavljači";
            this.Load += new System.EventHandler(this.SupliersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacidgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pretragabtn;
        private System.Windows.Forms.TextBox pretragaDobavljactxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button prikaziSveProizvodebtn;
        private System.Windows.Forms.Button prikaziNeAktivneProizvodebtn;
        private System.Windows.Forms.Button prikaziAktivneProizvodebtn;
        private System.Windows.Forms.Button urediProizvodbtn;
        private System.Windows.Forms.Button dodajProizvodbtn;
        private System.Windows.Forms.Button izbrisiPorizvodbtn;
        private System.Windows.Forms.RichTextBox napomenatxt;
        private MetroFramework.Controls.MetroGrid dobavljacidgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn DobavljacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Web;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZiroRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}