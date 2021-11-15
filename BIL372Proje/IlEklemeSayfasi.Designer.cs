
namespace BIL372Proje
{
    partial class IlEklemeSayfasi
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
            this.IlEklemeIlKoduText = new System.Windows.Forms.TextBox();
            this.IlEklemeIlAdiText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IlEkleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl bilgilerini eksiksiz giriniz.";
            // 
            // IlEklemeIlKoduText
            // 
            this.IlEklemeIlKoduText.Location = new System.Drawing.Point(102, 52);
            this.IlEklemeIlKoduText.Name = "IlEklemeIlKoduText";
            this.IlEklemeIlKoduText.Size = new System.Drawing.Size(126, 22);
            this.IlEklemeIlKoduText.TabIndex = 1;
            // 
            // IlEklemeIlAdiText
            // 
            this.IlEklemeIlAdiText.Location = new System.Drawing.Point(102, 91);
            this.IlEklemeIlAdiText.Name = "IlEklemeIlAdiText";
            this.IlEklemeIlAdiText.Size = new System.Drawing.Size(126, 22);
            this.IlEklemeIlAdiText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "İl Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "İl Adı:";
            // 
            // IlEkleButton
            // 
            this.IlEkleButton.Location = new System.Drawing.Point(124, 140);
            this.IlEkleButton.Name = "IlEkleButton";
            this.IlEkleButton.Size = new System.Drawing.Size(75, 23);
            this.IlEkleButton.TabIndex = 5;
            this.IlEkleButton.Text = "Ekle";
            this.IlEkleButton.UseVisualStyleBackColor = true;
            this.IlEkleButton.Click += new System.EventHandler(this.IlEkleButton_Click);
            // 
            // IlEklemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 227);
            this.Controls.Add(this.IlEkleButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IlEklemeIlAdiText);
            this.Controls.Add(this.IlEklemeIlKoduText);
            this.Controls.Add(this.label1);
            this.Name = "IlEklemeSayfasi";
            this.Text = "IlEklemeSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IlEklemeIlKoduText;
        private System.Windows.Forms.TextBox IlEklemeIlAdiText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IlEkleButton;
    }
}