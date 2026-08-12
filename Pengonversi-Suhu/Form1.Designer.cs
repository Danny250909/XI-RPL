namespace Pengonversi_Suhu
{
    partial class Form1
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelDari = new System.Windows.Forms.Label();
            this.comboBoxDari = new System.Windows.Forms.ComboBox();
            this.labelKe = new System.Windows.Forms.Label();
            this.comboBoxKe = new System.Windows.Forms.ComboBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(22, 94);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(145, 21);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Masukkan Suhu :";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(178, 91);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(229, 26);
            this.textInput.TabIndex = 1;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(60, 20);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(347, 37);
            this.labelJudul.TabIndex = 2;
            this.labelJudul.Text = "Kalkulator Konversi Suhu";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDari
            // 
            this.labelDari.AutoSize = true;
            this.labelDari.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDari.Location = new System.Drawing.Point(22, 146);
            this.labelDari.Name = "labelDari";
            this.labelDari.Size = new System.Drawing.Size(124, 23);
            this.labelDari.TabIndex = 3;
            this.labelDari.Text = "Dari Satuan :";
            this.labelDari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDari
            // 
            this.comboBoxDari.FormattingEnabled = true;
            this.comboBoxDari.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur",
            "Kelvin"});
            this.comboBoxDari.Location = new System.Drawing.Point(178, 141);
            this.comboBoxDari.Name = "comboBoxDari";
            this.comboBoxDari.Size = new System.Drawing.Size(148, 28);
            this.comboBoxDari.TabIndex = 4;
            // 
            // labelKe
            // 
            this.labelKe.AutoSize = true;
            this.labelKe.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKe.Location = new System.Drawing.Point(22, 197);
            this.labelKe.Name = "labelKe";
            this.labelKe.Size = new System.Drawing.Size(108, 23);
            this.labelKe.TabIndex = 5;
            this.labelKe.Text = "Ke Satuan :";
            this.labelKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxKe
            // 
            this.comboBoxKe.FormattingEnabled = true;
            this.comboBoxKe.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Reamur",
            "Kelvin"});
            this.comboBoxKe.Location = new System.Drawing.Point(178, 195);
            this.comboBoxKe.Name = "comboBoxKe";
            this.comboBoxKe.Size = new System.Drawing.Size(148, 28);
            this.comboBoxKe.TabIndex = 6;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(251, 239);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(102, 29);
            this.buttonKonversi.TabIndex = 7;
            this.buttonKonversi.Text = "Konversi";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(151, 297);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(86, 26);
            this.labelHasil.TabIndex = 8;
            this.labelHasil.Text = "Hasil : ";
            this.labelHasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(465, 362);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.comboBoxKe);
            this.Controls.Add(this.labelKe);
            this.Controls.Add(this.comboBoxDari);
            this.Controls.Add(this.labelDari);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Pengonversi Suhu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelDari;
        private System.Windows.Forms.ComboBox comboBoxDari;
        private System.Windows.Forms.Label labelKe;
        private System.Windows.Forms.ComboBox comboBoxKe;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelHasil;
    }
}

