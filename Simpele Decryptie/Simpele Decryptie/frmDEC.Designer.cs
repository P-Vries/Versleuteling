namespace Simpele_Decryptie
{
    partial class frmDEC
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
            this.txbInvoer = new System.Windows.Forms.RichTextBox();
            this.txbUitvoer = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenen = new System.Windows.Forms.Button();
            this.btnUitOpslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teskt: invoer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tekst Uivoer:";
            // 
            // txbInvoer
            // 
            this.txbInvoer.Location = new System.Drawing.Point(12, 25);
            this.txbInvoer.Name = "txbInvoer";
            this.txbInvoer.ReadOnly = true;
            this.txbInvoer.Size = new System.Drawing.Size(776, 135);
            this.txbInvoer.TabIndex = 2;
            this.txbInvoer.Text = "";
            // 
            // txbUitvoer
            // 
            this.txbUitvoer.Location = new System.Drawing.Point(12, 179);
            this.txbUitvoer.Name = "txbUitvoer";
            this.txbUitvoer.Size = new System.Drawing.Size(776, 230);
            this.txbUitvoer.TabIndex = 3;
            this.txbUitvoer.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenen
            // 
            this.btnOpenen.Location = new System.Drawing.Point(682, 415);
            this.btnOpenen.Name = "btnOpenen";
            this.btnOpenen.Size = new System.Drawing.Size(106, 23);
            this.btnOpenen.TabIndex = 5;
            this.btnOpenen.Text = "Bestand Openen";
            this.btnOpenen.UseVisualStyleBackColor = true;
            this.btnOpenen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUitOpslaan
            // 
            this.btnUitOpslaan.Location = new System.Drawing.Point(351, 415);
            this.btnUitOpslaan.Name = "btnUitOpslaan";
            this.btnUitOpslaan.Size = new System.Drawing.Size(97, 23);
            this.btnUitOpslaan.TabIndex = 6;
            this.btnUitOpslaan.Text = "Uitvoer Opslaan";
            this.btnUitOpslaan.UseVisualStyleBackColor = true;
            this.btnUitOpslaan.Click += new System.EventHandler(this.btnUitOpslaan_Click);
            // 
            // frmDEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUitOpslaan);
            this.Controls.Add(this.btnOpenen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbUitvoer);
            this.Controls.Add(this.txbInvoer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDEC";
            this.Text = "Simpele Versleuteling (DEC)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txbInvoer;
        private System.Windows.Forms.RichTextBox txbUitvoer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenen;
        private System.Windows.Forms.Button btnUitOpslaan;
    }
}

