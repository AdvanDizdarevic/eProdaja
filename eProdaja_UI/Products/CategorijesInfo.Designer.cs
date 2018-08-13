namespace eProdaja_UI.Products
{
    partial class CategorijesInfo
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
            this.dodajKategoriju = new System.Windows.Forms.Button();
            this.prikaziAktivne = new System.Windows.Forms.Button();
            this.obrisiKategoriju = new System.Windows.Forms.Button();
            this.prikaziNeAktivne = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKategorije = new MetroFramework.Controls.MetroGrid();
            this.KategorijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajKategoriju
            // 
            this.dodajKategoriju.Location = new System.Drawing.Point(16, 76);
            this.dodajKategoriju.Name = "dodajKategoriju";
            this.dodajKategoriju.Size = new System.Drawing.Size(111, 39);
            this.dodajKategoriju.TabIndex = 0;
            this.dodajKategoriju.Text = "Dodaj kategoriju";
            this.dodajKategoriju.UseVisualStyleBackColor = true;
            this.dodajKategoriju.Click += new System.EventHandler(this.dodajKategoriju_Click);
            // 
            // prikaziAktivne
            // 
            this.prikaziAktivne.Location = new System.Drawing.Point(16, 144);
            this.prikaziAktivne.Name = "prikaziAktivne";
            this.prikaziAktivne.Size = new System.Drawing.Size(111, 30);
            this.prikaziAktivne.TabIndex = 1;
            this.prikaziAktivne.Text = "Prikazi aktivne";
            this.prikaziAktivne.UseVisualStyleBackColor = true;
            this.prikaziAktivne.Click += new System.EventHandler(this.prikaziAktivne_Click);
            // 
            // obrisiKategoriju
            // 
            this.obrisiKategoriju.Location = new System.Drawing.Point(146, 76);
            this.obrisiKategoriju.Name = "obrisiKategoriju";
            this.obrisiKategoriju.Size = new System.Drawing.Size(125, 39);
            this.obrisiKategoriju.TabIndex = 2;
            this.obrisiKategoriju.Text = "Obrisi kategoriju";
            this.obrisiKategoriju.UseVisualStyleBackColor = true;
            this.obrisiKategoriju.Click += new System.EventHandler(this.obrisiKategoriju_Click);
            // 
            // prikaziNeAktivne
            // 
            this.prikaziNeAktivne.Location = new System.Drawing.Point(146, 144);
            this.prikaziNeAktivne.Name = "prikaziNeAktivne";
            this.prikaziNeAktivne.Size = new System.Drawing.Size(125, 30);
            this.prikaziNeAktivne.TabIndex = 3;
            this.prikaziNeAktivne.Text = "Prikazi neaktivne";
            this.prikaziNeAktivne.UseVisualStyleBackColor = true;
            this.prikaziNeAktivne.Click += new System.EventHandler(this.prikaziNeAktivne_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(16, 204);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(255, 33);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.Text = "Refresh list";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "*Dobule click za edit kategorije";
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowUserToResizeRows = false;
            this.dgvKategorije.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKategorije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKategorije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKategorije.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKategorije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaID,
            this.Naziv,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKategorije.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKategorije.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKategorije.EnableHeadersVisualStyles = false;
            this.dgvKategorije.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvKategorije.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvKategorije.Location = new System.Drawing.Point(20, 260);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKategorije.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKategorije.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategorije.Size = new System.Drawing.Size(246, 236);
            this.dgvKategorije.TabIndex = 7;
            this.dgvKategorije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategorije_CellDoubleClick_1);
            // 
            // KategorijaID
            // 
            this.KategorijaID.DataPropertyName = "KategorijaID";
            this.KategorijaID.HeaderText = "KategorijaID";
            this.KategorijaID.Name = "KategorijaID";
            this.KategorijaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CategorijesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 516);
            this.Controls.Add(this.dgvKategorije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.prikaziNeAktivne);
            this.Controls.Add(this.obrisiKategoriju);
            this.Controls.Add(this.prikaziAktivne);
            this.Controls.Add(this.dodajKategoriju);
            this.Name = "CategorijesInfo";
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.CategorijesInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajKategoriju;
        private System.Windows.Forms.Button prikaziAktivne;
        private System.Windows.Forms.Button obrisiKategoriju;
        private System.Windows.Forms.Button prikaziNeAktivne;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid dgvKategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}