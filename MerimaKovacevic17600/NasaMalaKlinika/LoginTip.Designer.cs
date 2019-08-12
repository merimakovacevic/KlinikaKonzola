namespace NasaMalaKlinika
{
    partial class LoginTip
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
            this.buttonUposlenik = new System.Windows.Forms.Button();
            this.buttonPacijent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUposlenik
            // 
            this.buttonUposlenik.Location = new System.Drawing.Point(12, 45);
            this.buttonUposlenik.Name = "buttonUposlenik";
            this.buttonUposlenik.Size = new System.Drawing.Size(75, 23);
            this.buttonUposlenik.TabIndex = 0;
            this.buttonUposlenik.Text = "Uposlenik";
            this.buttonUposlenik.UseVisualStyleBackColor = true;
            this.buttonUposlenik.Click += new System.EventHandler(this.buttonUposlenik_Click);
            // 
            // buttonPacijent
            // 
            this.buttonPacijent.Location = new System.Drawing.Point(94, 45);
            this.buttonPacijent.Name = "buttonPacijent";
            this.buttonPacijent.Size = new System.Drawing.Size(75, 23);
            this.buttonPacijent.TabIndex = 1;
            this.buttonPacijent.Text = "Pacijent";
            this.buttonPacijent.UseVisualStyleBackColor = true;
            this.buttonPacijent.Click += new System.EventHandler(this.buttonPacijent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prijavi se kao:";
            // 
            // LoginTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPacijent);
            this.Controls.Add(this.buttonUposlenik);
            this.Name = "LoginTip";
            this.Text = "LoginTip";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginTip_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUposlenik;
        private System.Windows.Forms.Button buttonPacijent;
        private System.Windows.Forms.Label label1;
    }
}