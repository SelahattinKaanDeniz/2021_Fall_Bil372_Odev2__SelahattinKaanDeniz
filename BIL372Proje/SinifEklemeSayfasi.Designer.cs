
namespace BIL372Proje
{
    partial class SinifEklemeSayfasi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SinifIDText = new System.Windows.Forms.TextBox();
            this.SinifAdiText = new System.Windows.Forms.TextBox();
            this.AlanTipiText = new System.Windows.Forms.TextBox();
            this.SinifEkleButton = new System.Windows.Forms.Button();
            this.SinifCikisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Bilgileri Eksiksiz Giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sınıf ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınıf Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alan Tipi:";
            // 
            // SinifIDText
            // 
            this.SinifIDText.Location = new System.Drawing.Point(89, 83);
            this.SinifIDText.Name = "SinifIDText";
            this.SinifIDText.Size = new System.Drawing.Size(173, 22);
            this.SinifIDText.TabIndex = 4;
            // 
            // SinifAdiText
            // 
            this.SinifAdiText.Location = new System.Drawing.Point(89, 135);
            this.SinifAdiText.Name = "SinifAdiText";
            this.SinifAdiText.Size = new System.Drawing.Size(173, 22);
            this.SinifAdiText.TabIndex = 5;
            // 
            // AlanTipiText
            // 
            this.AlanTipiText.Location = new System.Drawing.Point(89, 189);
            this.AlanTipiText.Name = "AlanTipiText";
            this.AlanTipiText.Size = new System.Drawing.Size(173, 22);
            this.AlanTipiText.TabIndex = 6;
            // 
            // SinifEkleButton
            // 
            this.SinifEkleButton.Location = new System.Drawing.Point(78, 241);
            this.SinifEkleButton.Name = "SinifEkleButton";
            this.SinifEkleButton.Size = new System.Drawing.Size(75, 23);
            this.SinifEkleButton.TabIndex = 7;
            this.SinifEkleButton.Text = "Ekle";
            this.SinifEkleButton.UseVisualStyleBackColor = true;
            this.SinifEkleButton.Click += new System.EventHandler(this.SinifEkleButton_Click);
            // 
            // SinifCikisButton
            // 
            this.SinifCikisButton.Location = new System.Drawing.Point(187, 241);
            this.SinifCikisButton.Name = "SinifCikisButton";
            this.SinifCikisButton.Size = new System.Drawing.Size(75, 23);
            this.SinifCikisButton.TabIndex = 8;
            this.SinifCikisButton.Text = "Çıkış";
            this.SinifCikisButton.UseVisualStyleBackColor = true;
            this.SinifCikisButton.Click += new System.EventHandler(this.SinifCikisButton_Click);
            // 
            // SinifEklemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 295);
            this.Controls.Add(this.SinifCikisButton);
            this.Controls.Add(this.SinifEkleButton);
            this.Controls.Add(this.AlanTipiText);
            this.Controls.Add(this.SinifAdiText);
            this.Controls.Add(this.SinifIDText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SinifEklemeSayfasi";
            this.Text = "SinifEklemeSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SinifIDText;
        private System.Windows.Forms.TextBox SinifAdiText;
        private System.Windows.Forms.TextBox AlanTipiText;
        private System.Windows.Forms.Button SinifEkleButton;
        private System.Windows.Forms.Button SinifCikisButton;
    }
}