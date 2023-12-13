namespace _04_Reisedauer_zum_Mond
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.in_tagen_auswahl = new System.Windows.Forms.RadioButton();
            this.in_stunden_auswahl = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.geschwindigkeit_eingabe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reisedauer_berechnen_button = new System.Windows.Forms.Button();
            this.ergebniss_berechnung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // in_tagen_auswahl
            // 
            this.in_tagen_auswahl.AutoSize = true;
            this.in_tagen_auswahl.Location = new System.Drawing.Point(43, 106);
            this.in_tagen_auswahl.Name = "in_tagen_auswahl";
            this.in_tagen_auswahl.Size = new System.Drawing.Size(68, 17);
            this.in_tagen_auswahl.TabIndex = 0;
            this.in_tagen_auswahl.TabStop = true;
            this.in_tagen_auswahl.Text = "In Tagen";
            this.in_tagen_auswahl.UseVisualStyleBackColor = true;
            // 
            // in_stunden_auswahl
            // 
            this.in_stunden_auswahl.AutoSize = true;
            this.in_stunden_auswahl.Location = new System.Drawing.Point(195, 106);
            this.in_stunden_auswahl.Name = "in_stunden_auswahl";
            this.in_stunden_auswahl.Size = new System.Drawing.Size(77, 17);
            this.in_stunden_auswahl.TabIndex = 1;
            this.in_stunden_auswahl.TabStop = true;
            this.in_stunden_auswahl.Text = "In Stunden";
            this.in_stunden_auswahl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reisedauer zum mond berechnen";
            // 
            // geschwindigkeit_eingabe
            // 
            this.geschwindigkeit_eingabe.Location = new System.Drawing.Point(195, 182);
            this.geschwindigkeit_eingabe.Name = "geschwindigkeit_eingabe";
            this.geschwindigkeit_eingabe.Size = new System.Drawing.Size(100, 20);
            this.geschwindigkeit_eingabe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geschwindigkeit in Km/h";
            // 
            // reisedauer_berechnen_button
            // 
            this.reisedauer_berechnen_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reisedauer_berechnen_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.reisedauer_berechnen_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reisedauer_berechnen_button.Location = new System.Drawing.Point(43, 246);
            this.reisedauer_berechnen_button.Name = "reisedauer_berechnen_button";
            this.reisedauer_berechnen_button.Size = new System.Drawing.Size(252, 42);
            this.reisedauer_berechnen_button.TabIndex = 5;
            this.reisedauer_berechnen_button.Text = "Reisedauer Berechnen";
            this.reisedauer_berechnen_button.UseVisualStyleBackColor = false;
            this.reisedauer_berechnen_button.Click += new System.EventHandler(this.reisedauer_berechnen_button_Click);
            // 
            // ergebniss_berechnung
            // 
            this.ergebniss_berechnung.Location = new System.Drawing.Point(195, 372);
            this.ergebniss_berechnung.Name = "ergebniss_berechnung";
            this.ergebniss_berechnung.ReadOnly = true;
            this.ergebniss_berechnung.Size = new System.Drawing.Size(100, 20);
            this.ergebniss_berechnung.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reisedauer zum mond beträgt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ergebniss_berechnung);
            this.Controls.Add(this.reisedauer_berechnen_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geschwindigkeit_eingabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.in_stunden_auswahl);
            this.Controls.Add(this.in_tagen_auswahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton in_tagen_auswahl;
        private System.Windows.Forms.RadioButton in_stunden_auswahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox geschwindigkeit_eingabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reisedauer_berechnen_button;
        private System.Windows.Forms.TextBox ergebniss_berechnung;
        private System.Windows.Forms.Label label3;
    }
}

