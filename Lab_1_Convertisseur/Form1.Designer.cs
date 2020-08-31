namespace Lab_1_Convertisseur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDecimale = new System.Windows.Forms.Button();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.btnHexa = new System.Windows.Forms.Button();
            this.txtChiffre = new System.Windows.Forms.TextBox();
            this.txtBinaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHexadecimale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textDecimale = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDecimale
            // 
            this.btnDecimale.Location = new System.Drawing.Point(50, 272);
            this.btnDecimale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecimale.Name = "btnDecimale";
            this.btnDecimale.Size = new System.Drawing.Size(82, 32);
            this.btnDecimale.TabIndex = 0;
            this.btnDecimale.Text = "Décimale";
            this.btnDecimale.UseVisualStyleBackColor = true;
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(234, 272);
            this.btnBinaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(82, 32);
            this.btnBinaire.TabIndex = 1;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // btnHexa
            // 
            this.btnHexa.Location = new System.Drawing.Point(440, 272);
            this.btnHexa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHexa.Name = "btnHexa";
            this.btnHexa.Size = new System.Drawing.Size(82, 32);
            this.btnHexa.TabIndex = 2;
            this.btnHexa.Text = "Hexadécimale";
            this.btnHexa.UseVisualStyleBackColor = true;
            // 
            // txtChiffre
            // 
            this.txtChiffre.Location = new System.Drawing.Point(198, 214);
            this.txtChiffre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChiffre.Name = "txtChiffre";
            this.txtChiffre.Size = new System.Drawing.Size(171, 20);
            this.txtChiffre.TabIndex = 3;
            // 
            // txtBinaire
            // 
            this.txtBinaire.Location = new System.Drawing.Point(235, 123);
            this.txtBinaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBinaire.Name = "txtBinaire";
            this.txtBinaire.ReadOnly = true;
            this.txtBinaire.Size = new System.Drawing.Size(92, 20);
            this.txtBinaire.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrer le chiffre à convertir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chiffre converti :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Convertisseur";
            // 
            // txtHexadecimale
            // 
            this.txtHexadecimale.Location = new System.Drawing.Point(430, 123);
            this.txtHexadecimale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHexadecimale.Name = "txtHexadecimale";
            this.txtHexadecimale.ReadOnly = true;
            this.txtHexadecimale.Size = new System.Drawing.Size(92, 20);
            this.txtHexadecimale.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decimale :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hexadécimale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Binaire :";
            // 
            // textDecimale
            // 
            this.textDecimale.Location = new System.Drawing.Point(69, 123);
            this.textDecimale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDecimale.Name = "textDecimale";
            this.textDecimale.ReadOnly = true;
            this.textDecimale.Size = new System.Drawing.Size(92, 20);
            this.textDecimale.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 366);
            this.Controls.Add(this.textDecimale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHexadecimale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBinaire);
            this.Controls.Add(this.txtChiffre);
            this.Controls.Add(this.btnHexa);
            this.Controls.Add(this.btnBinaire);
            this.Controls.Add(this.btnDecimale);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Lab1_Convertisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecimale;
        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.Button btnHexa;
        private System.Windows.Forms.TextBox txtChiffre;
        private System.Windows.Forms.TextBox txtBinaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHexadecimale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textDecimale;
    }
}

