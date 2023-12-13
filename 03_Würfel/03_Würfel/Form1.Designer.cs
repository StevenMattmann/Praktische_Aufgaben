namespace _03_Würfel
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
            this.wuerfeln_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gewuerfelte_zahl = new System.Windows.Forms.TextBox();
            this.zuletzt_gewuerfelte_zahl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wuerfeln_button
            // 
            this.wuerfeln_button.Location = new System.Drawing.Point(66, 89);
            this.wuerfeln_button.Name = "wuerfeln_button";
            this.wuerfeln_button.Size = new System.Drawing.Size(280, 131);
            this.wuerfeln_button.TabIndex = 0;
            this.wuerfeln_button.Text = "Würfeln";
            this.wuerfeln_button.UseVisualStyleBackColor = true;
            this.wuerfeln_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Letzter Wurf:";
            // 
            // gewuerfelte_zahl
            // 
            this.gewuerfelte_zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.gewuerfelte_zahl.Location = new System.Drawing.Point(523, 119);
            this.gewuerfelte_zahl.Name = "gewuerfelte_zahl";
            this.gewuerfelte_zahl.Size = new System.Drawing.Size(45, 53);
            this.gewuerfelte_zahl.TabIndex = 2;
            // 
            // zuletzt_gewuerfelte_zahl
            // 
            this.zuletzt_gewuerfelte_zahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.zuletzt_gewuerfelte_zahl.Location = new System.Drawing.Point(301, 303);
            this.zuletzt_gewuerfelte_zahl.Name = "zuletzt_gewuerfelte_zahl";
            this.zuletzt_gewuerfelte_zahl.Size = new System.Drawing.Size(45, 38);
            this.zuletzt_gewuerfelte_zahl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zuletzt_gewuerfelte_zahl);
            this.Controls.Add(this.gewuerfelte_zahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wuerfeln_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wuerfeln_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gewuerfelte_zahl;
        private System.Windows.Forms.TextBox zuletzt_gewuerfelte_zahl;
    }
}

