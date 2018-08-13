namespace eProdaja_UI.Buyes
{
    partial class KupciForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnPrijedlozi = new System.Windows.Forms.Button();
            this.btnRefrehs = new System.Windows.Forms.Button();
            this.btnOcjene = new System.Windows.Forms.Button();
            this.txtKupac = new System.Windows.Forms.TextBox();
            this.dgvKupci = new MetroFramework.Controls.MetroGrid();
            this.KupacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga kupca: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "*Double click za pregled narudzbi kupca";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(317, 63);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(85, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Pretraga";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // btnPrijedlozi
            // 
            this.btnPrijedlozi.Location = new System.Drawing.Point(30, 115);
            this.btnPrijedlozi.Name = "btnPrijedlozi";
            this.btnPrijedlozi.Size = new System.Drawing.Size(177, 49);
            this.btnPrijedlozi.TabIndex = 4;
            this.btnPrijedlozi.Text = "Prikazi prijedloge";
            this.btnPrijedlozi.UseVisualStyleBackColor = true;
            this.btnPrijedlozi.Click += new System.EventHandler(this.btnPrijedlozi_Click);
            // 
            // btnRefrehs
            // 
            this.btnRefrehs.Location = new System.Drawing.Point(475, 63);
            this.btnRefrehs.Name = "btnRefrehs";
            this.btnRefrehs.Size = new System.Drawing.Size(90, 101);
            this.btnRefrehs.TabIndex = 5;
            this.btnRefrehs.Text = "Refresh list";
            this.btnRefrehs.UseVisualStyleBackColor = true;
            this.btnRefrehs.Click += new System.EventHandler(this.btnRefrehs_Click);
            // 
            // btnOcjene
            // 
            this.btnOcjene.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOcjene.Location = new System.Drawing.Point(229, 115);
            this.btnOcjene.Name = "btnOcjene";
            this.btnOcjene.Size = new System.Drawing.Size(173, 49);
            this.btnOcjene.TabIndex = 6;
            this.btnOcjene.Text = "Prikazi ocjene";
            this.btnOcjene.UseVisualStyleBackColor = true;
            this.btnOcjene.Click += new System.EventHandler(this.btnOcjene_Click);
            // 
            // txtKupac
            // 
            this.txtKupac.Location = new System.Drawing.Point(120, 65);
            this.txtKupac.Name = "txtKupac";
            this.txtKupac.Size = new System.Drawing.Size(177, 20);
            this.txtKupac.TabIndex = 7;
            // 
            // dgvKupci
            // 
            this.dgvKupci.AllowUserToResizeRows = false;
            this.dgvKupci.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKupci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKupci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKupci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKupci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KupacID,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKupci.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKupci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKupci.EnableHeadersVisualStyles = false;
            this.dgvKupci.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvKupci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKupci.Location = new System.Drawing.Point(20, 228);
            this.dgvKupci.Name = "dgvKupci";
            this.dgvKupci.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKupci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKupci.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKupci.Size = new System.Drawing.Size(545, 198);
            this.dgvKupci.TabIndex = 8;
            this.dgvKupci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKupci_CellDoubleClick_1);
            // 
            // KupacID
            // 
            this.KupacID.DataPropertyName = "KupacID";
            this.KupacID.HeaderText = "KupacID";
            this.KupacID.Name = "KupacID";
            this.KupacID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KupciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 446);
            this.Controls.Add(this.dgvKupci);
            this.Controls.Add(this.txtKupac);
            this.Controls.Add(this.btnOcjene);
            this.Controls.Add(this.btnRefrehs);
            this.Controls.Add(this.btnPrijedlozi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "KupciForm";
            this.Text = "Kupci info";
            this.Load += new System.EventHandler(this.KupciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnPrijedlozi;
        private System.Windows.Forms.Button btnRefrehs;
        private System.Windows.Forms.Button btnOcjene;
        private System.Windows.Forms.TextBox txtKupac;
        private MetroFramework.Controls.MetroGrid dgvKupci;
        private System.Windows.Forms.DataGridViewTextBoxColumn KupacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}