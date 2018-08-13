namespace eProdaja_UI.Orders
{
    partial class DetailsForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brNarudzbeLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.iznosNarudzbeLabel = new System.Windows.Forms.Label();
            this.kupacLabel = new System.Windows.Forms.Label();
            this.procesirajButton = new System.Windows.Forms.Button();
            this.skladistaList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stavkeNarudzbeGrid = new MetroFramework.Controls.MetroGrid();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Broj narudžbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Iznos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Kupac:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Datum:";
            // 
            // brNarudzbeLabel
            // 
            this.brNarudzbeLabel.AutoSize = true;
            this.brNarudzbeLabel.Location = new System.Drawing.Point(317, 18);
            this.brNarudzbeLabel.Name = "brNarudzbeLabel";
            this.brNarudzbeLabel.Size = new System.Drawing.Size(72, 13);
            this.brNarudzbeLabel.TabIndex = 51;
            this.brNarudzbeLabel.Text = "Broj narudžbe";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(317, 45);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(38, 13);
            this.datumLabel.TabIndex = 52;
            this.datumLabel.Text = "Datum";
            // 
            // iznosNarudzbeLabel
            // 
            this.iznosNarudzbeLabel.AutoSize = true;
            this.iznosNarudzbeLabel.Location = new System.Drawing.Point(539, 45);
            this.iznosNarudzbeLabel.Name = "iznosNarudzbeLabel";
            this.iznosNarudzbeLabel.Size = new System.Drawing.Size(32, 13);
            this.iznosNarudzbeLabel.TabIndex = 54;
            this.iznosNarudzbeLabel.Text = "Iznos";
            // 
            // kupacLabel
            // 
            this.kupacLabel.AutoSize = true;
            this.kupacLabel.Location = new System.Drawing.Point(539, 18);
            this.kupacLabel.Name = "kupacLabel";
            this.kupacLabel.Size = new System.Drawing.Size(38, 13);
            this.kupacLabel.TabIndex = 53;
            this.kupacLabel.Text = "Kupac";
            // 
            // procesirajButton
            // 
            this.procesirajButton.Location = new System.Drawing.Point(521, 357);
            this.procesirajButton.Name = "procesirajButton";
            this.procesirajButton.Size = new System.Drawing.Size(100, 30);
            this.procesirajButton.TabIndex = 55;
            this.procesirajButton.Text = "Procesiraj";
            this.procesirajButton.UseVisualStyleBackColor = true;
            this.procesirajButton.Click += new System.EventHandler(this.procesirajButton_Click);
            // 
            // skladistaList
            // 
            this.skladistaList.FormattingEnabled = true;
            this.skladistaList.Location = new System.Drawing.Point(105, 357);
            this.skladistaList.Name = "skladistaList";
            this.skladistaList.Size = new System.Drawing.Size(202, 21);
            this.skladistaList.TabIndex = 56;
            this.skladistaList.Validating += new System.ComponentModel.CancelEventHandler(this.skladistaList_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Skladište:";
            // 
            // stavkeNarudzbeGrid
            // 
            this.stavkeNarudzbeGrid.AllowUserToResizeRows = false;
            this.stavkeNarudzbeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stavkeNarudzbeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stavkeNarudzbeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.stavkeNarudzbeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stavkeNarudzbeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.stavkeNarudzbeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stavkeNarudzbeGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.stavkeNarudzbeGrid.EnableHeadersVisualStyles = false;
            this.stavkeNarudzbeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stavkeNarudzbeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stavkeNarudzbeGrid.Location = new System.Drawing.Point(24, 84);
            this.stavkeNarudzbeGrid.Name = "stavkeNarudzbeGrid";
            this.stavkeNarudzbeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stavkeNarudzbeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.stavkeNarudzbeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stavkeNarudzbeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavkeNarudzbeGrid.Size = new System.Drawing.Size(742, 244);
            this.stavkeNarudzbeGrid.TabIndex = 58;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 415);
            this.Controls.Add(this.stavkeNarudzbeGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.skladistaList);
            this.Controls.Add(this.procesirajButton);
            this.Controls.Add(this.iznosNarudzbeLabel);
            this.Controls.Add(this.kupacLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.brNarudzbeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailsForm";
            this.Text = "Detalji narudžbe";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label brNarudzbeLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label iznosNarudzbeLabel;
        private System.Windows.Forms.Label kupacLabel;
        private System.Windows.Forms.Button procesirajButton;
        private System.Windows.Forms.ComboBox skladistaList;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroGrid stavkeNarudzbeGrid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}