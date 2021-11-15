
namespace BIL372Proje
{
    partial class IlceEklemeSayfasi
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
            this.IlceEkleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IlKoduText = new System.Windows.Forms.TextBox();
            this.IlceAdiText = new System.Windows.Forms.TextBox();
            this.IlceKoduText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe bilgilerini  eksiksiz giriniz.";
            // 
            // IlceEkleButton
            // 
            this.IlceEkleButton.Location = new System.Drawing.Point(129, 191);
            this.IlceEkleButton.Name = "IlceEkleButton";
            this.IlceEkleButton.Size = new System.Drawing.Size(75, 23);
            this.IlceEkleButton.TabIndex = 1;
            this.IlceEkleButton.Text = "Ekle";
            this.IlceEkleButton.UseVisualStyleBackColor = true;
            this.IlceEkleButton.Click += new System.EventHandler(this.IlceEkleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İl Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "İlçe Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "İlçe Kodu:";
            // 
            // IlKoduText
            // 
            this.IlKoduText.Location = new System.Drawing.Point(118, 55);
            this.IlKoduText.Name = "IlKoduText";
            this.IlKoduText.Size = new System.Drawing.Size(100, 22);
            this.IlKoduText.TabIndex = 5;
            // 
            // IlceAdiText
            // 
            this.IlceAdiText.Location = new System.Drawing.Point(118, 100);
            this.IlceAdiText.Name = "IlceAdiText";
            this.IlceAdiText.Size = new System.Drawing.Size(100, 22);
            this.IlceAdiText.TabIndex = 6;
            // 
            // IlceKoduText
            // 
            this.IlceKoduText.Location = new System.Drawing.Point(118, 147);
            this.IlceKoduText.Name = "IlceKoduText";
            this.IlceKoduText.Size = new System.Drawing.Size(100, 22);
            this.IlceKoduText.TabIndex = 7;
            // 
            // IlceEklemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 249);
            this.Controls.Add(this.IlceKoduText);
            this.Controls.Add(this.IlceAdiText);
            this.Controls.Add(this.IlKoduText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IlceEkleButton);
            this.Controls.Add(this.label1);
            this.Name = "IlceEklemeSayfasi";
            this.Text = "IlceEklemeSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IlceEkleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IlKoduText;
        private System.Windows.Forms.TextBox IlceAdiText;
        private System.Windows.Forms.TextBox IlceKoduText;
    }
}