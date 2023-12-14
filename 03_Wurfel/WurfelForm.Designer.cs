namespace Wurfel
{
    partial class WurfelForm
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
            this.WurfelnButton = new System.Windows.Forms.Button();
            this.lastThrow = new System.Windows.Forms.Label();
            this.LasThrowValueLabel = new System.Windows.Forms.Label();
            this.TrowValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WurfelnButton
            // 
            this.WurfelnButton.Location = new System.Drawing.Point(81, 63);
            this.WurfelnButton.Margin = new System.Windows.Forms.Padding(2);
            this.WurfelnButton.Name = "WurfelnButton";
            this.WurfelnButton.Size = new System.Drawing.Size(192, 82);
            this.WurfelnButton.TabIndex = 0;
            this.WurfelnButton.Text = "Würfeln";
            this.WurfelnButton.UseVisualStyleBackColor = true;
            this.WurfelnButton.Click += new System.EventHandler(this.WurfelnButton_Click);
            // 
            // lastThrow
            // 
            this.lastThrow.AutoSize = true;
            this.lastThrow.Location = new System.Drawing.Point(71, 231);
            this.lastThrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastThrow.Name = "lastThrow";
            this.lastThrow.Size = new System.Drawing.Size(68, 13);
            this.lastThrow.TabIndex = 1;
            this.lastThrow.Text = "Letzter Wurf:";
            // 
            // LasThrowValueLabel
            // 
            this.LasThrowValueLabel.AutoSize = true;
            this.LasThrowValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.LasThrowValueLabel.Location = new System.Drawing.Point(189, 216);
            this.LasThrowValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LasThrowValueLabel.Name = "LasThrowValueLabel";
            this.LasThrowValueLabel.Size = new System.Drawing.Size(29, 31);
            this.LasThrowValueLabel.TabIndex = 2;
            this.LasThrowValueLabel.Text = "0";
            // 
            // TrowValueLabel
            // 
            this.TrowValueLabel.AutoSize = true;
            this.TrowValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.TrowValueLabel.Location = new System.Drawing.Point(345, 72);
            this.TrowValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrowValueLabel.Name = "TrowValueLabel";
            this.TrowValueLabel.Size = new System.Drawing.Size(57, 63);
            this.TrowValueLabel.TabIndex = 3;
            this.TrowValueLabel.Text = "0";
            // 
            // WurfelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TrowValueLabel);
            this.Controls.Add(this.LasThrowValueLabel);
            this.Controls.Add(this.lastThrow);
            this.Controls.Add(this.WurfelnButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WurfelForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WurfelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WurfelnButton;
        private System.Windows.Forms.Label lastThrow;
        private System.Windows.Forms.Label LasThrowValueLabel;
        private System.Windows.Forms.Label TrowValueLabel;
    }
}

