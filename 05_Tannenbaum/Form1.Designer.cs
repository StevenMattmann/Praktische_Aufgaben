using System;

namespace _05_Tannenbaum
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
            this.Stammbreite = new System.Windows.Forms.TextBox();
            this.Kronenhoehe = new System.Windows.Forms.TextBox();
            this.Stammhoehe = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TanneZeichnenButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Stammbreite
            // 
            this.Stammbreite.BackColor = System.Drawing.SystemColors.Info;
            this.Stammbreite.Location = new System.Drawing.Point(145, 12);
            this.Stammbreite.Name = "Stammbreite";
            this.Stammbreite.Size = new System.Drawing.Size(93, 20);
            this.Stammbreite.TabIndex = 0;
            // 
            // Kronenhoehe
            // 
            this.Kronenhoehe.BackColor = System.Drawing.SystemColors.Info;
            this.Kronenhoehe.Location = new System.Drawing.Point(145, 64);
            this.Kronenhoehe.Name = "Kronenhoehe";
            this.Kronenhoehe.Size = new System.Drawing.Size(93, 20);
            this.Kronenhoehe.TabIndex = 1;
            // 
            // Stammhoehe
            // 
            this.Stammhoehe.BackColor = System.Drawing.SystemColors.Info;
            this.Stammhoehe.Location = new System.Drawing.Point(145, 38);
            this.Stammhoehe.Name = "Stammhoehe";
            this.Stammhoehe.Size = new System.Drawing.Size(93, 20);
            this.Stammhoehe.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Stammbreite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stammhöhe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kronenhöhe";
            // 
            // TanneZeichnenButton
            // 
            this.TanneZeichnenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TanneZeichnenButton.Location = new System.Drawing.Point(277, 64);
            this.TanneZeichnenButton.Name = "TanneZeichnenButton";
            this.TanneZeichnenButton.Size = new System.Drawing.Size(103, 20);
            this.TanneZeichnenButton.TabIndex = 6;
            this.TanneZeichnenButton.Text = "Tanne zeichnen";
            this.TanneZeichnenButton.UseVisualStyleBackColor = false;
            this.TanneZeichnenButton.Click += new System.EventHandler(this.TanneZeichnenButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(24, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 319);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TanneZeichnenButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Stammhoehe);
            this.Controls.Add(this.Kronenhoehe);
            this.Controls.Add(this.Stammbreite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.TextBox Stammbreite;
        private System.Windows.Forms.TextBox Kronenhoehe;
        private System.Windows.Forms.TextBox Stammhoehe;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TanneZeichnenButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

