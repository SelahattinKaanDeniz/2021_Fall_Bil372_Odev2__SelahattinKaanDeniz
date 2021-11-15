
namespace BIL372Proje
{
    partial class AlanEklemeSayfasi
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
            this.AlanIDText = new System.Windows.Forms.TextBox();
            this.AlanAdiText = new System.Windows.Forms.TextBox();
            this.AlanTipiText = new System.Windows.Forms.TextBox();
            this.AlanEkleButton = new System.Windows.Forms.Button();
            this.AlanCikisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilgileri eksiksiz giriniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alan ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alan Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alan Tipi (Müdahale ->0 Çıktı->1):";
            // 
            // AlanIDText
            // 
            this.AlanIDText.Location = new System.Drawing.Point(237, 84);
            this.AlanIDText.Name = "AlanIDText";
            this.AlanIDText.Size = new System.Drawing.Size(252, 22);
            this.AlanIDText.TabIndex = 4;
            // 
            // AlanAdiText
            // 
            this.AlanAdiText.Location = new System.Drawing.Point(237, 135);
            this.AlanAdiText.Name = "AlanAdiText";
            this.AlanAdiText.Size = new System.Drawing.Size(252, 22);
            this.AlanAdiText.TabIndex = 5;
            // 
            // AlanTipiText
            // 
            this.AlanTipiText.Location = new System.Drawing.Point(237, 181);
            this.AlanTipiText.Name = "AlanTipiText";
            this.AlanTipiText.Size = new System.Drawing.Size(252, 22);
            this.AlanTipiText.TabIndex = 6;
            // 
            // AlanEkleButton
            // 
            this.AlanEkleButton.Location = new System.Drawing.Point(156, 241);
            this.AlanEkleButton.Name = "AlanEkleButton";
            this.AlanEkleButton.Size = new System.Drawing.Size(75, 23);
            this.AlanEkleButton.TabIndex = 7;
            this.AlanEkleButton.Text = "Ekle";
            this.AlanEkleButton.UseVisualStyleBackColor = true;
            this.AlanEkleButton.Click += new System.EventHandler(this.AlanEkleButton_Click);
            // 
            // AlanCikisButton
            // 
            this.AlanCikisButton.Location = new System.Drawing.Point(266, 241);
            this.AlanCikisButton.Name = "AlanCikisButton";
            this.AlanCikisButton.Size = new System.Drawing.Size(75, 23);
            this.AlanCikisButton.TabIndex = 8;
            this.AlanCikisButton.Text = "Çıkış";
            this.AlanCikisButton.UseVisualStyleBackColor = true;
            this.AlanCikisButton.Click += new System.EventHandler(this.AlanCikisButton_Click);
            // 
            // AlanEklemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 306);
            this.Controls.Add(this.AlanCikisButton);
            this.Controls.Add(this.AlanEkleButton);
            this.Controls.Add(this.AlanTipiText);
            this.Controls.Add(this.AlanAdiText);
            this.Controls.Add(this.AlanIDText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlanEklemeSayfasi";
            this.Text = "AlanEklemeSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AlanIDText;
        private System.Windows.Forms.TextBox AlanAdiText;
        private System.Windows.Forms.TextBox AlanTipiText;
        private System.Windows.Forms.Button AlanEkleButton;
        private System.Windows.Forms.Button AlanCikisButton;
    }
}