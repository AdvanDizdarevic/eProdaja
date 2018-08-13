namespace eProdaja_UI.Warehouse
{
    partial class WarehouseForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.opistxt = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prikaziSvaSkladistabtn = new System.Windows.Forms.Button();
            this.prikaziNeAktivneSkladistebtn = new System.Windows.Forms.Button();
            this.prikaziAktivnaSkladistabtn = new System.Windows.Forms.Button();
            this.urediSkladistebtn = new System.Windows.Forms.Button();
            this.dodajSkladistebtn = new System.Windows.Forms.Button();
            this.izbrisSkladistebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pretragabtn = new System.Windows.Forms.Button();
            this.pretragaSkladistetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skladistedgw = new MetroFramework.Controls.MetroGrid();
            this.SkladisteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladistedgw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.Location = new System.Drawing.Point(10, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Double click za citanje opisa skladista";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.opistxt);
            this.groupBox3.Location = new System.Drawing.Point(410, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 301);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opis skladista";
            // 
            // opistxt
            // 
            this.opistxt.Location = new System.Drawing.Point(11, 19);
            this.opistxt.Name = "opistxt";
            this.opistxt.ReadOnly = true;
            this.opistxt.Size = new System.Drawing.Size(238, 266);
            this.opistxt.TabIndex = 0;
            this.opistxt.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prikaziSvaSkladistabtn);
            this.groupBox2.Controls.Add(this.prikaziNeAktivneSkladistebtn);
            this.groupBox2.Controls.Add(this.prikaziAktivnaSkladistabtn);
            this.groupBox2.Controls.Add(this.urediSkladistebtn);
            this.groupBox2.Controls.Add(this.dodajSkladistebtn);
            this.groupBox2.Controls.Add(this.izbrisSkladistebtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 150);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skladišta";
            // 
            // prikaziSvaSkladistabtn
            // 
            this.prikaziSvaSkladistabtn.Location = new System.Drawing.Point(291, 28);
            this.prikaziSvaSkladistabtn.Name = "prikaziSvaSkladistabtn";
            this.prikaziSvaSkladistabtn.Size = new System.Drawing.Size(77, 90);
            this.prikaziSvaSkladistabtn.TabIndex = 42;
            this.prikaziSvaSkladistabtn.Text = "Refesh";
            this.prikaziSvaSkladistabtn.UseVisualStyleBackColor = true;
            this.prikaziSvaSkladistabtn.Click += new System.EventHandler(this.prikaziSvaSkladistabtn_Click);
            // 
            // prikaziNeAktivneSkladistebtn
            // 
            this.prikaziNeAktivneSkladistebtn.Location = new System.Drawing.Point(161, 81);
            this.prikaziNeAktivneSkladistebtn.Name = "prikaziNeAktivneSkladistebtn";
            this.prikaziNeAktivneSkladistebtn.Size = new System.Drawing.Size(112, 37);
            this.prikaziNeAktivneSkladistebtn.TabIndex = 41;
            this.prikaziNeAktivneSkladistebtn.Text = "Prikaži ne aktivne";
            this.prikaziNeAktivneSkladistebtn.UseVisualStyleBackColor = true;
            this.prikaziNeAktivneSkladistebtn.Click += new System.EventHandler(this.prikaziNeAktivneSkladistebtn_Click);
            // 
            // prikaziAktivnaSkladistabtn
            // 
            this.prikaziAktivnaSkladistabtn.Location = new System.Drawing.Point(161, 28);
            this.prikaziAktivnaSkladistabtn.Name = "prikaziAktivnaSkladistabtn";
            this.prikaziAktivnaSkladistabtn.Size = new System.Drawing.Size(112, 37);
            this.prikaziAktivnaSkladistabtn.TabIndex = 40;
            this.prikaziAktivnaSkladistabtn.Text = "Prikaži aktivne";
            this.prikaziAktivnaSkladistabtn.UseVisualStyleBackColor = true;
            this.prikaziAktivnaSkladistabtn.Click += new System.EventHandler(this.prikaziAktivnaSkladistabtn_Click);
            // 
            // urediSkladistebtn
            // 
            this.urediSkladistebtn.Location = new System.Drawing.Point(13, 95);
            this.urediSkladistebtn.Name = "urediSkladistebtn";
            this.urediSkladistebtn.Size = new System.Drawing.Size(112, 23);
            this.urediSkladistebtn.TabIndex = 39;
            this.urediSkladistebtn.Text = "Uredi Skladiste";
            this.urediSkladistebtn.UseVisualStyleBackColor = true;
            this.urediSkladistebtn.Click += new System.EventHandler(this.urediSkladistebtn_Click);
            // 
            // dodajSkladistebtn
            // 
            this.dodajSkladistebtn.Location = new System.Drawing.Point(13, 28);
            this.dodajSkladistebtn.Name = "dodajSkladistebtn";
            this.dodajSkladistebtn.Size = new System.Drawing.Size(112, 23);
            this.dodajSkladistebtn.TabIndex = 37;
            this.dodajSkladistebtn.Text = "Dodaj Skladište";
            this.dodajSkladistebtn.UseVisualStyleBackColor = true;
            this.dodajSkladistebtn.Click += new System.EventHandler(this.dodajSkladistebtn_Click);
            // 
            // izbrisSkladistebtn
            // 
            this.izbrisSkladistebtn.Location = new System.Drawing.Point(13, 61);
            this.izbrisSkladistebtn.Name = "izbrisSkladistebtn";
            this.izbrisSkladistebtn.Size = new System.Drawing.Size(112, 23);
            this.izbrisSkladistebtn.TabIndex = 38;
            this.izbrisSkladistebtn.Text = "Izbriši Skladište";
            this.izbrisSkladistebtn.UseVisualStyleBackColor = true;
            this.izbrisSkladistebtn.Click += new System.EventHandler(this.izbrisSkladistebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pretragabtn);
            this.groupBox1.Controls.Add(this.pretragaSkladistetxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 135);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga  skladišta";
            // 
            // pretragabtn
            // 
            this.pretragabtn.Location = new System.Drawing.Point(291, 57);
            this.pretragabtn.Name = "pretragabtn";
            this.pretragabtn.Size = new System.Drawing.Size(83, 23);
            this.pretragabtn.TabIndex = 2;
            this.pretragabtn.Text = "Traži";
            this.pretragabtn.UseVisualStyleBackColor = true;
            this.pretragabtn.Click += new System.EventHandler(this.pretragabtn_Click);
            // 
            // pretragaSkladistetxt
            // 
            this.pretragaSkladistetxt.Location = new System.Drawing.Point(13, 60);
            this.pretragaSkladistetxt.Name = "pretragaSkladistetxt";
            this.pretragaSkladistetxt.Size = new System.Drawing.Size(260, 20);
            this.pretragaSkladistetxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pretraži po nazivu";
            // 
            // skladistedgw
            // 
            this.skladistedgw.AllowUserToResizeRows = false;
            this.skladistedgw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skladistedgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skladistedgw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.skladistedgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skladistedgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.skladistedgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skladistedgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkladisteID,
            this.Naziv,
            this.Adresa,
            this.Opis,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skladistedgw.DefaultCellStyle = dataGridViewCellStyle2;
            this.skladistedgw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skladistedgw.EnableHeadersVisualStyles = false;
            this.skladistedgw.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.skladistedgw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skladistedgw.Location = new System.Drawing.Point(20, 418);
            this.skladistedgw.Name = "skladistedgw";
            this.skladistedgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skladistedgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.skladistedgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.skladistedgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skladistedgw.Size = new System.Drawing.Size(636, 237);
            this.skladistedgw.TabIndex = 47;
            this.skladistedgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skladistedgw_CellDoubleClick_1);
            // 
            // SkladisteID
            // 
            this.SkladisteID.DataPropertyName = "SkladisteID";
            this.SkladisteID.HeaderText = "SkladisteID";
            this.SkladisteID.Name = "SkladisteID";
            this.SkladisteID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 675);
            this.Controls.Add(this.skladistedgw);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "WarehouseForm";
            this.ShowIcon = false;
            this.Text = "Skladište Forma";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skladistedgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox opistxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button prikaziSvaSkladistabtn;
        private System.Windows.Forms.Button prikaziNeAktivneSkladistebtn;
        private System.Windows.Forms.Button prikaziAktivnaSkladistabtn;
        private System.Windows.Forms.Button urediSkladistebtn;
        private System.Windows.Forms.Button dodajSkladistebtn;
        private System.Windows.Forms.Button izbrisSkladistebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pretragabtn;
        private System.Windows.Forms.TextBox pretragaSkladistetxt;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid skladistedgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkladisteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}