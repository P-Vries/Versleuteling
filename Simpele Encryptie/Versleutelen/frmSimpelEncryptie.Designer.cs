namespace Versleutelen
{
    partial class frmSimpelEncryptie
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
            this.txbSimpelTekst = new System.Windows.Forms.RichTextBox();
            this.txbEncTekst = new System.Windows.Forms.RichTextBox();
            this.btnEncryptie = new System.Windows.Forms.Button();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.btnOpenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoer Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uitvoer Tekst:";
            // 
            // txbSimpelTekst
            // 
            this.txbSimpelTekst.Location = new System.Drawing.Point(12, 25);
            this.txbSimpelTekst.Name = "txbSimpelTekst";
            this.txbSimpelTekst.Size = new System.Drawing.Size(776, 223);
            this.txbSimpelTekst.TabIndex = 2;
            this.txbSimpelTekst.Text = "";
            // 
            // txbEncTekst
            // 
            this.txbEncTekst.Location = new System.Drawing.Point(12, 267);
            this.txbEncTekst.Name = "txbEncTekst";
            this.txbEncTekst.ReadOnly = true;
            this.txbEncTekst.Size = new System.Drawing.Size(776, 142);
            this.txbEncTekst.TabIndex = 3;
            this.txbEncTekst.Text = "";
            // 
            // btnEncryptie
            // 
            this.btnEncryptie.Location = new System.Drawing.Point(12, 415);
            this.btnEncryptie.Name = "btnEncryptie";
            this.btnEncryptie.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptie.TabIndex = 4;
            this.btnEncryptie.Text = "Encryptie";
            this.btnEncryptie.UseVisualStyleBackColor = true;
            this.btnEncryptie.Click += new System.EventHandler(this.btnEncryptie_Click);
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Location = new System.Drawing.Point(688, 415);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(100, 23);
            this.btnSaveOutput.TabIndex = 6;
            this.btnSaveOutput.Text = "Uitvoer Opslaan";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // btnOpenen
            // 
            this.btnOpenen.Location = new System.Drawing.Point(351, 415);
            this.btnOpenen.Name = "btnOpenen";
            this.btnOpenen.Size = new System.Drawing.Size(103, 23);
            this.btnOpenen.TabIndex = 7;
            this.btnOpenen.Text = "Bestand Openen";
            this.btnOpenen.UseVisualStyleBackColor = true;
            this.btnOpenen.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // frmSimpelEncryptie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenen);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.btnEncryptie);
            this.Controls.Add(this.txbEncTekst);
            this.Controls.Add(this.txbSimpelTekst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSimpelEncryptie";
            this.Text = "Simpele Versleuteling (ENC)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txbSimpelTekst;
        private System.Windows.Forms.RichTextBox txbEncTekst;
        private System.Windows.Forms.Button btnEncryptie;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.Button btnOpenen;
    }
}

