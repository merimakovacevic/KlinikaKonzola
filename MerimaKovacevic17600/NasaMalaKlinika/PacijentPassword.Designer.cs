namespace NasaMalaKlinika
{
    partial class PacijentPassword
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
            this.textSifra = new System.Windows.Forms.TextBox();
            this.textSifra2 = new System.Windows.Forms.TextBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.profilna = new NasaMalaKlinika.PacijentProfilna();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ponovite sifru";
            // 
            // textSifra
            // 
            this.textSifra.Location = new System.Drawing.Point(138, 10);
            this.textSifra.Name = "textSifra";
            this.textSifra.PasswordChar = '*';
            this.textSifra.Size = new System.Drawing.Size(142, 20);
            this.textSifra.TabIndex = 2;
            this.textSifra.Validating += new System.ComponentModel.CancelEventHandler(this.textSifra_Validating);
            this.textSifra.Validated += new System.EventHandler(this.textSifra_Validated);
            // 
            // textSifra2
            // 
            this.textSifra2.Location = new System.Drawing.Point(138, 40);
            this.textSifra2.Name = "textSifra2";
            this.textSifra2.PasswordChar = '*';
            this.textSifra2.Size = new System.Drawing.Size(142, 20);
            this.textSifra2.TabIndex = 3;
            this.textSifra2.Validating += new System.ComponentModel.CancelEventHandler(this.textSifra2_Validating);
            this.textSifra2.Validated += new System.EventHandler(this.textSifra2_Validated);
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(204, 67);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdi.TabIndex = 4;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // profilna
            // 
            this.profilna.Izabrana = null;
            this.profilna.Location = new System.Drawing.Point(0, 0);
            this.profilna.Name = "profilna";
            this.profilna.Size = new System.Drawing.Size(150, 148);
            this.profilna.TabIndex = 0;
            // 
            // PacijentPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 104);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.textSifra2);
            this.Controls.Add(this.textSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PacijentPassword";
            this.Text = "PacijentPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSifra;
        private System.Windows.Forms.TextBox textSifra2;
        private System.Windows.Forms.Button buttonPotvrdi;
        private PacijentProfilna profilna;
    }
}