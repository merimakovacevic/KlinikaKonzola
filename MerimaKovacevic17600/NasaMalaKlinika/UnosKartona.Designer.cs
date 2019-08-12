namespace NasaMalaKlinika
{
    partial class UnosKartona
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
            this.textBolesti = new System.Windows.Forms.TextBox();
            this.textNapomene = new System.Windows.Forms.TextBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite bitne napomene o pacijentu: alergije, vakcinacije i prosle bolesti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite listu proslih bolesti:";
            // 
            // textBolesti
            // 
            this.textBolesti.Location = new System.Drawing.Point(28, 180);
            this.textBolesti.Multiline = true;
            this.textBolesti.Name = "textBolesti";
            this.textBolesti.Size = new System.Drawing.Size(345, 76);
            this.textBolesti.TabIndex = 3;
            // 
            // textNapomene
            // 
            this.textNapomene.Location = new System.Drawing.Point(28, 47);
            this.textNapomene.Multiline = true;
            this.textNapomene.Name = "textNapomene";
            this.textNapomene.Size = new System.Drawing.Size(345, 80);
            this.textNapomene.TabIndex = 1;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(278, 268);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(95, 23);
            this.buttonPotvrdi.TabIndex = 4;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // UnosKartona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 303);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.textBolesti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNapomene);
            this.Controls.Add(this.label1);
            this.Name = "UnosKartona";
            this.Text = "UnosKartona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBolesti;
        private System.Windows.Forms.TextBox textNapomene;
        private System.Windows.Forms.Button buttonPotvrdi;
    }
}