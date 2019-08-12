namespace NasaMalaKlinika
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpcije = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajKartonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularniPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitanPregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaVozackiIspitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledZaKonkursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naplataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uplataZaDanasnjiDanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.plateUposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlogujSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verzijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOKorisniku = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridOKorisniku = new System.Windows.Forms.DataGridView();
            this.Osobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijednost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabListaPacijenata = new System.Windows.Forms.TabPage();
            this.gridPacijenti = new System.Windows.Forms.DataGridView();
            this.ImeIPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SljedeciPregled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosadasnjaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabListaOrdinacija = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.treeOrdinacije = new System.Windows.Forms.TreeView();
            this.tabZauzetostOrdinacija = new System.Windows.Forms.TabPage();
            this.gridZauzetost = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripPoruka = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabOKorisniku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOKorisniku)).BeginInit();
            this.tabListaPacijenata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacijenti)).BeginInit();
            this.tabListaOrdinacija.SuspendLayout();
            this.tabZauzetostOrdinacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZauzetost)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcije,
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpcije
            // 
            this.menuOpcije.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovogPacijentaToolStripMenuItem,
            this.kreirajKartonToolStripMenuItem,
            this.dodajNoviPregledToolStripMenuItem,
            this.pregledajPacijentaToolStripMenuItem,
            this.naplataToolStripMenuItem,
            this.toolStripSeparator2,
            this.plateUposlenikaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlogujSeToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuOpcije.Name = "menuOpcije";
            this.menuOpcije.Size = new System.Drawing.Size(53, 20);
            this.menuOpcije.Text = "Opcije";
            // 
            // dodajNovogPacijentaToolStripMenuItem
            // 
            this.dodajNovogPacijentaToolStripMenuItem.Name = "dodajNovogPacijentaToolStripMenuItem";
            this.dodajNovogPacijentaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.dodajNovogPacijentaToolStripMenuItem.Text = "Dodaj novog pacijenta";
            this.dodajNovogPacijentaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogPacijentaToolStripMenuItem_Click);
            // 
            // kreirajKartonToolStripMenuItem
            // 
            this.kreirajKartonToolStripMenuItem.Name = "kreirajKartonToolStripMenuItem";
            this.kreirajKartonToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.kreirajKartonToolStripMenuItem.Text = "Dodaj karton";
            this.kreirajKartonToolStripMenuItem.Click += new System.EventHandler(this.kreirajKartonToolStripMenuItem_Click);
            // 
            // dodajNoviPregledToolStripMenuItem
            // 
            this.dodajNoviPregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularniPregledToolStripMenuItem,
            this.hitanPregledToolStripMenuItem,
            this.pregledZaVozackiIspitToolStripMenuItem,
            this.pregledZaKonkursToolStripMenuItem});
            this.dodajNoviPregledToolStripMenuItem.Name = "dodajNoviPregledToolStripMenuItem";
            this.dodajNoviPregledToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.dodajNoviPregledToolStripMenuItem.Text = "Dodaj novi pregled";
            // 
            // regularniPregledToolStripMenuItem
            // 
            this.regularniPregledToolStripMenuItem.Name = "regularniPregledToolStripMenuItem";
            this.regularniPregledToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.regularniPregledToolStripMenuItem.Text = "Regularni pregled";
            this.regularniPregledToolStripMenuItem.Click += new System.EventHandler(this.regularniPregledToolStripMenuItem_Click);
            // 
            // hitanPregledToolStripMenuItem
            // 
            this.hitanPregledToolStripMenuItem.Name = "hitanPregledToolStripMenuItem";
            this.hitanPregledToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.hitanPregledToolStripMenuItem.Text = "Hitan pregled";
            this.hitanPregledToolStripMenuItem.Click += new System.EventHandler(this.hitanPregledToolStripMenuItem_Click);
            // 
            // pregledZaVozackiIspitToolStripMenuItem
            // 
            this.pregledZaVozackiIspitToolStripMenuItem.Name = "pregledZaVozackiIspitToolStripMenuItem";
            this.pregledZaVozackiIspitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.pregledZaVozackiIspitToolStripMenuItem.Text = "Pregled za vozacki ispit";
            this.pregledZaVozackiIspitToolStripMenuItem.Click += new System.EventHandler(this.pregledZaVozackiIspitToolStripMenuItem_Click);
            // 
            // pregledZaKonkursToolStripMenuItem
            // 
            this.pregledZaKonkursToolStripMenuItem.Name = "pregledZaKonkursToolStripMenuItem";
            this.pregledZaKonkursToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.pregledZaKonkursToolStripMenuItem.Text = "Pregled za konkurs";
            this.pregledZaKonkursToolStripMenuItem.Click += new System.EventHandler(this.pregledZaKonkursToolStripMenuItem_Click);
            // 
            // pregledajPacijentaToolStripMenuItem
            // 
            this.pregledajPacijentaToolStripMenuItem.Name = "pregledajPacijentaToolStripMenuItem";
            this.pregledajPacijentaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pregledajPacijentaToolStripMenuItem.Text = "Pregledaj pacijenta";
            this.pregledajPacijentaToolStripMenuItem.Click += new System.EventHandler(this.pregledajPacijentaToolStripMenuItem_Click);
            // 
            // naplataToolStripMenuItem
            // 
            this.naplataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uplataZaDanasnjiDanToolStripMenuItem});
            this.naplataToolStripMenuItem.Name = "naplataToolStripMenuItem";
            this.naplataToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.naplataToolStripMenuItem.Text = "Naplata";
            // 
            // uplataZaDanasnjiDanToolStripMenuItem
            // 
            this.uplataZaDanasnjiDanToolStripMenuItem.Name = "uplataZaDanasnjiDanToolStripMenuItem";
            this.uplataZaDanasnjiDanToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.uplataZaDanasnjiDanToolStripMenuItem.Text = "Uplata za danasnji dan";
            this.uplataZaDanasnjiDanToolStripMenuItem.Click += new System.EventHandler(this.uplataZaDanasnjiDanToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // plateUposlenikaToolStripMenuItem
            // 
            this.plateUposlenikaToolStripMenuItem.Name = "plateUposlenikaToolStripMenuItem";
            this.plateUposlenikaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.plateUposlenikaToolStripMenuItem.Text = "Plate uposlenika";
            this.plateUposlenikaToolStripMenuItem.Click += new System.EventHandler(this.plateUposlenikaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // izlogujSeToolStripMenuItem
            // 
            this.izlogujSeToolStripMenuItem.Name = "izlogujSeToolStripMenuItem";
            this.izlogujSeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.izlogujSeToolStripMenuItem.Text = "Odjavi se";
            this.izlogujSeToolStripMenuItem.Click += new System.EventHandler(this.izlogujSeToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verzijaToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // verzijaToolStripMenuItem
            // 
            this.verzijaToolStripMenuItem.Name = "verzijaToolStripMenuItem";
            this.verzijaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verzijaToolStripMenuItem.Text = "Verzija";
            this.verzijaToolStripMenuItem.Click += new System.EventHandler(this.verzijaToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOKorisniku);
            this.tabControl1.Controls.Add(this.tabListaPacijenata);
            this.tabControl1.Controls.Add(this.tabListaOrdinacija);
            this.tabControl1.Controls.Add(this.tabZauzetostOrdinacija);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 279);
            this.tabControl1.TabIndex = 2;
            // 
            // tabOKorisniku
            // 
            this.tabOKorisniku.Controls.Add(this.pictureBox1);
            this.tabOKorisniku.Controls.Add(this.gridOKorisniku);
            this.tabOKorisniku.Location = new System.Drawing.Point(4, 22);
            this.tabOKorisniku.Name = "tabOKorisniku";
            this.tabOKorisniku.Padding = new System.Windows.Forms.Padding(3);
            this.tabOKorisniku.Size = new System.Drawing.Size(560, 253);
            this.tabOKorisniku.TabIndex = 1;
            this.tabOKorisniku.Text = "O prijavljenom korisniku";
            this.tabOKorisniku.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(305, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gridOKorisniku
            // 
            this.gridOKorisniku.AllowUserToAddRows = false;
            this.gridOKorisniku.AllowUserToDeleteRows = false;
            this.gridOKorisniku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOKorisniku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Osobina,
            this.Vrijednost});
            this.gridOKorisniku.Location = new System.Drawing.Point(6, 6);
            this.gridOKorisniku.Name = "gridOKorisniku";
            this.gridOKorisniku.ReadOnly = true;
            this.gridOKorisniku.Size = new System.Drawing.Size(293, 241);
            this.gridOKorisniku.TabIndex = 0;
            // 
            // Osobina
            // 
            this.Osobina.HeaderText = "Osobina";
            this.Osobina.Name = "Osobina";
            this.Osobina.ReadOnly = true;
            // 
            // Vrijednost
            // 
            this.Vrijednost.HeaderText = "Vrijednost";
            this.Vrijednost.Name = "Vrijednost";
            this.Vrijednost.ReadOnly = true;
            // 
            // tabListaPacijenata
            // 
            this.tabListaPacijenata.Controls.Add(this.gridPacijenti);
            this.tabListaPacijenata.Location = new System.Drawing.Point(4, 22);
            this.tabListaPacijenata.Name = "tabListaPacijenata";
            this.tabListaPacijenata.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaPacijenata.Size = new System.Drawing.Size(560, 253);
            this.tabListaPacijenata.TabIndex = 0;
            this.tabListaPacijenata.Text = "Lista pacijenata";
            this.tabListaPacijenata.UseVisualStyleBackColor = true;
            // 
            // gridPacijenti
            // 
            this.gridPacijenti.AllowUserToAddRows = false;
            this.gridPacijenti.AllowUserToDeleteRows = false;
            this.gridPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImeIPrezime,
            this.Spol,
            this.DatumRodjenja,
            this.DatumPrijema,
            this.SljedeciPregled,
            this.DosadasnjaCijena});
            this.gridPacijenti.Location = new System.Drawing.Point(6, 6);
            this.gridPacijenti.Name = "gridPacijenti";
            this.gridPacijenti.ReadOnly = true;
            this.gridPacijenti.Size = new System.Drawing.Size(548, 241);
            this.gridPacijenti.TabIndex = 0;
            // 
            // ImeIPrezime
            // 
            this.ImeIPrezime.HeaderText = "Ime i prezime";
            this.ImeIPrezime.Name = "ImeIPrezime";
            this.ImeIPrezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // DatumPrijema
            // 
            this.DatumPrijema.HeaderText = "Datum prijema";
            this.DatumPrijema.Name = "DatumPrijema";
            this.DatumPrijema.ReadOnly = true;
            // 
            // SljedeciPregled
            // 
            this.SljedeciPregled.HeaderText = "Sljedeci pregled";
            this.SljedeciPregled.Name = "SljedeciPregled";
            this.SljedeciPregled.ReadOnly = true;
            // 
            // DosadasnjaCijena
            // 
            this.DosadasnjaCijena.HeaderText = "Dosadasnja cijena";
            this.DosadasnjaCijena.Name = "DosadasnjaCijena";
            this.DosadasnjaCijena.ReadOnly = true;
            // 
            // tabListaOrdinacija
            // 
            this.tabListaOrdinacija.Controls.Add(this.label1);
            this.tabListaOrdinacija.Controls.Add(this.treeOrdinacije);
            this.tabListaOrdinacija.Location = new System.Drawing.Point(4, 22);
            this.tabListaOrdinacija.Name = "tabListaOrdinacija";
            this.tabListaOrdinacija.Size = new System.Drawing.Size(560, 253);
            this.tabListaOrdinacija.TabIndex = 2;
            this.tabListaOrdinacija.Text = "Ordinacije";
            this.tabListaOrdinacija.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red pacijenata za ordinacije";
            // 
            // treeOrdinacije
            // 
            this.treeOrdinacije.Location = new System.Drawing.Point(3, 25);
            this.treeOrdinacije.Name = "treeOrdinacije";
            this.treeOrdinacije.Size = new System.Drawing.Size(554, 225);
            this.treeOrdinacije.TabIndex = 0;
            // 
            // tabZauzetostOrdinacija
            // 
            this.tabZauzetostOrdinacija.Controls.Add(this.gridZauzetost);
            this.tabZauzetostOrdinacija.Location = new System.Drawing.Point(4, 22);
            this.tabZauzetostOrdinacija.Name = "tabZauzetostOrdinacija";
            this.tabZauzetostOrdinacija.Padding = new System.Windows.Forms.Padding(3);
            this.tabZauzetostOrdinacija.Size = new System.Drawing.Size(560, 253);
            this.tabZauzetostOrdinacija.TabIndex = 3;
            this.tabZauzetostOrdinacija.Text = "Zauzetost ordinacija";
            this.tabZauzetostOrdinacija.UseVisualStyleBackColor = true;
            // 
            // gridZauzetost
            // 
            this.gridZauzetost.AllowUserToAddRows = false;
            this.gridZauzetost.AllowUserToDeleteRows = false;
            this.gridZauzetost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridZauzetost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gridZauzetost.Location = new System.Drawing.Point(6, 6);
            this.gridZauzetost.Name = "gridZauzetost";
            this.gridZauzetost.ReadOnly = true;
            this.gridZauzetost.Size = new System.Drawing.Size(548, 241);
            this.gridZauzetost.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ordinacija";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Zauzeta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPoruka});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripPoruka
            // 
            this.toolStripPoruka.ForeColor = System.Drawing.Color.Red;
            this.toolStripPoruka.Name = "toolStripPoruka";
            this.toolStripPoruka.Size = new System.Drawing.Size(16, 17);
            this.toolStripPoruka.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 363);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabOKorisniku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOKorisniku)).EndInit();
            this.tabListaPacijenata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacijenti)).EndInit();
            this.tabListaOrdinacija.ResumeLayout(false);
            this.tabListaOrdinacija.PerformLayout();
            this.tabZauzetostOrdinacija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridZauzetost)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpcije;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogPacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajKartonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviPregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verzijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOKorisniku;
        private System.Windows.Forms.TabPage tabListaPacijenata;
        private System.Windows.Forms.TabPage tabListaOrdinacija;
        private System.Windows.Forms.ToolStripMenuItem regularniPregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hitanPregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaVozackiIspitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledZaKonkursToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridOKorisniku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijednost;
        private System.Windows.Forms.DataGridView gridPacijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeIPrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijema;
        private System.Windows.Forms.DataGridViewTextBoxColumn SljedeciPregled;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosadasnjaCijena;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem plateUposlenikaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeOrdinacije;
        private System.Windows.Forms.TabPage tabZauzetostOrdinacija;
        private System.Windows.Forms.DataGridView gridZauzetost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem pregledajPacijentaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem izlogujSeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPoruka;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem naplataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uplataZaDanasnjiDanToolStripMenuItem;
    }
}