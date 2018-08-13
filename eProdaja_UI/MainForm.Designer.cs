namespace eProdaja_UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoKorisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoProizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoProizvodiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAkcijskiProizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivneNarudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novostiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoKupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljaciInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoSkladistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeSkladistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ulazniRacuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.narudzbeToolStripMenuItem,
            this.novostiToolStripMenuItem,
            this.kupciToolStripMenuItem,
            this.dobavljaciToolStripMenuItem,
            this.skladistaToolStripMenuItem,
            this.izvjestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoKorisniciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fileToolStripMenuItem.Text = "Korisnici";
            // 
            // infoKorisniciToolStripMenuItem
            // 
            this.infoKorisniciToolStripMenuItem.Name = "infoKorisniciToolStripMenuItem";
            this.infoKorisniciToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.infoKorisniciToolStripMenuItem.Text = "Info korisnici";
            this.infoKorisniciToolStripMenuItem.Click += new System.EventHandler(this.infoKorisniciToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoProizvodiToolStripMenuItem,
            this.noviProizvodToolStripMenuItem,
            this.infoProizvodiToolStripMenuItem1,
            this.kategorijeProizvodaToolStripMenuItem,
            this.infoAkcijskiProizvodiToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // infoProizvodiToolStripMenuItem
            // 
            this.infoProizvodiToolStripMenuItem.Name = "infoProizvodiToolStripMenuItem";
            this.infoProizvodiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.infoProizvodiToolStripMenuItem.Text = "Narudzba proizvoda";
            this.infoProizvodiToolStripMenuItem.Click += new System.EventHandler(this.infoProizvodiToolStripMenuItem_Click);
            // 
            // noviProizvodToolStripMenuItem
            // 
            this.noviProizvodToolStripMenuItem.Name = "noviProizvodToolStripMenuItem";
            this.noviProizvodToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.noviProizvodToolStripMenuItem.Text = "Novi proizvod";
            this.noviProizvodToolStripMenuItem.Click += new System.EventHandler(this.noviProizvodToolStripMenuItem_Click);
            // 
            // infoProizvodiToolStripMenuItem1
            // 
            this.infoProizvodiToolStripMenuItem1.Name = "infoProizvodiToolStripMenuItem1";
            this.infoProizvodiToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.infoProizvodiToolStripMenuItem1.Text = "Info proizvodi";
            this.infoProizvodiToolStripMenuItem1.Click += new System.EventHandler(this.infoProizvodiToolStripMenuItem1_Click);
            // 
            // kategorijeProizvodaToolStripMenuItem
            // 
            this.kategorijeProizvodaToolStripMenuItem.Name = "kategorijeProizvodaToolStripMenuItem";
            this.kategorijeProizvodaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kategorijeProizvodaToolStripMenuItem.Text = "Kategorije proizvoda";
            this.kategorijeProizvodaToolStripMenuItem.Click += new System.EventHandler(this.kategorijeProizvodaToolStripMenuItem_Click);
            // 
            // infoAkcijskiProizvodiToolStripMenuItem
            // 
            this.infoAkcijskiProizvodiToolStripMenuItem.Name = "infoAkcijskiProizvodiToolStripMenuItem";
            this.infoAkcijskiProizvodiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.infoAkcijskiProizvodiToolStripMenuItem.Text = "Info akcijski proizvodi";
            this.infoAkcijskiProizvodiToolStripMenuItem.Click += new System.EventHandler(this.infoAkcijskiProizvodiToolStripMenuItem_Click);
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktivneNarudzbeToolStripMenuItem});
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            // 
            // aktivneNarudzbeToolStripMenuItem
            // 
            this.aktivneNarudzbeToolStripMenuItem.Name = "aktivneNarudzbeToolStripMenuItem";
            this.aktivneNarudzbeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aktivneNarudzbeToolStripMenuItem.Text = "Aktivne narudzbe";
            this.aktivneNarudzbeToolStripMenuItem.Click += new System.EventHandler(this.aktivneNarudzbeToolStripMenuItem_Click);
            // 
            // novostiToolStripMenuItem
            // 
            this.novostiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novostiToolStripMenuItem1});
            this.novostiToolStripMenuItem.Name = "novostiToolStripMenuItem";
            this.novostiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.novostiToolStripMenuItem.Text = "Novosti";
            // 
            // novostiToolStripMenuItem1
            // 
            this.novostiToolStripMenuItem1.Name = "novostiToolStripMenuItem1";
            this.novostiToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.novostiToolStripMenuItem1.Text = "Info novosti";
            this.novostiToolStripMenuItem1.Click += new System.EventHandler(this.novostiToolStripMenuItem1_Click);
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoKupciToolStripMenuItem});
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kupciToolStripMenuItem.Text = "Kupci";
            // 
            // infoKupciToolStripMenuItem
            // 
            this.infoKupciToolStripMenuItem.Name = "infoKupciToolStripMenuItem";
            this.infoKupciToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.infoKupciToolStripMenuItem.Text = "Info kupci";
            this.infoKupciToolStripMenuItem.Click += new System.EventHandler(this.infoKupciToolStripMenuItem_Click);
            // 
            // dobavljaciToolStripMenuItem
            // 
            this.dobavljaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dobavljaciInfoToolStripMenuItem});
            this.dobavljaciToolStripMenuItem.Name = "dobavljaciToolStripMenuItem";
            this.dobavljaciToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.dobavljaciToolStripMenuItem.Text = "Dobavljaci";
            // 
            // dobavljaciInfoToolStripMenuItem
            // 
            this.dobavljaciInfoToolStripMenuItem.Name = "dobavljaciInfoToolStripMenuItem";
            this.dobavljaciInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dobavljaciInfoToolStripMenuItem.Text = "Info dobavljaci";
            this.dobavljaciInfoToolStripMenuItem.Click += new System.EventHandler(this.dobavljaciInfoToolStripMenuItem_Click);
            // 
            // skladistaToolStripMenuItem
            // 
            this.skladistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoSkladistaToolStripMenuItem,
            this.stanjeSkladistaToolStripMenuItem});
            this.skladistaToolStripMenuItem.Name = "skladistaToolStripMenuItem";
            this.skladistaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.skladistaToolStripMenuItem.Text = "Skladista";
            // 
            // infoSkladistaToolStripMenuItem
            // 
            this.infoSkladistaToolStripMenuItem.Name = "infoSkladistaToolStripMenuItem";
            this.infoSkladistaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.infoSkladistaToolStripMenuItem.Text = "Info skladista";
            this.infoSkladistaToolStripMenuItem.Click += new System.EventHandler(this.infoSkladistaToolStripMenuItem_Click);
            // 
            // stanjeSkladistaToolStripMenuItem
            // 
            this.stanjeSkladistaToolStripMenuItem.Name = "stanjeSkladistaToolStripMenuItem";
            this.stanjeSkladistaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stanjeSkladistaToolStripMenuItem.Text = "Stanje skladista";
            this.stanjeSkladistaToolStripMenuItem.Click += new System.EventHandler(this.stanjeSkladistaToolStripMenuItem_Click);
            // 
            // izvjestajiToolStripMenuItem
            // 
            this.izvjestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlaziToolStripMenuItem,
            this.ulazniRacuniToolStripMenuItem});
            this.izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            this.izvjestajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvjestajiToolStripMenuItem.Text = "Izvjestaji";
            // 
            // izlaziToolStripMenuItem
            // 
            this.izlaziToolStripMenuItem.Name = "izlaziToolStripMenuItem";
            this.izlaziToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlaziToolStripMenuItem.Text = "Izlazni racuni";
            this.izlaziToolStripMenuItem.Click += new System.EventHandler(this.izlaziToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // ulazniRacuniToolStripMenuItem
            // 
            this.ulazniRacuniToolStripMenuItem.Name = "ulazniRacuniToolStripMenuItem";
            this.ulazniRacuniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ulazniRacuniToolStripMenuItem.Text = "Ulazni racuni";
            this.ulazniRacuniToolStripMenuItem.Click += new System.EventHandler(this.ulazniRacuniToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 437);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "eBookStore";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoKorisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoProizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktivneNarudzbeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem infoProizvodiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kategorijeProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novostiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoKupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljaciInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skladistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoSkladistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeSkladistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoAkcijskiProizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulazniRacuniToolStripMenuItem;
    }
}