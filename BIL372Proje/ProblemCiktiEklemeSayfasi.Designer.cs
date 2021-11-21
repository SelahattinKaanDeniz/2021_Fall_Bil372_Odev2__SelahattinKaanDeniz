
namespace BIL372Proje
{
    partial class ProblemCiktiEklemeSayfasi
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
            this.alanIDEkleText = new System.Windows.Forms.TextBox();
            this.ciktiIDEkleText = new System.Windows.Forms.TextBox();
            this.sinifIDEkleText = new System.Windows.Forms.TextBox();
            this.problemIDEkleText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alanIDEkleText
            // 
            this.alanIDEkleText.Location = new System.Drawing.Point(113, 66);
            this.alanIDEkleText.Name = "alanIDEkleText";
            this.alanIDEkleText.Size = new System.Drawing.Size(100, 22);
            this.alanIDEkleText.TabIndex = 6;
            // 
            // ciktiIDEkleText
            // 
            this.ciktiIDEkleText.Location = new System.Drawing.Point(113, 149);
            this.ciktiIDEkleText.Name = "ciktiIDEkleText";
            this.ciktiIDEkleText.Size = new System.Drawing.Size(100, 22);
            this.ciktiIDEkleText.TabIndex = 7;
            // 
            // sinifIDEkleText
            // 
            this.sinifIDEkleText.Location = new System.Drawing.Point(357, 66);
            this.sinifIDEkleText.Name = "sinifIDEkleText";
            this.sinifIDEkleText.Size = new System.Drawing.Size(100, 22);
            this.sinifIDEkleText.TabIndex = 8;
            // 
            // problemIDEkleText
            // 
            this.problemIDEkleText.Location = new System.Drawing.Point(357, 149);
            this.problemIDEkleText.Name = "problemIDEkleText";
            this.problemIDEkleText.Size = new System.Drawing.Size(100, 22);
            this.problemIDEkleText.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Alan ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sınıf ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Çıktı ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Problem ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lütfen bilgileri giriniz.";
            // 
            // ProblemCiktiEklemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.problemIDEkleText);
            this.Controls.Add(this.sinifIDEkleText);
            this.Controls.Add(this.ciktiIDEkleText);
            this.Controls.Add(this.alanIDEkleText);
            this.Name = "ProblemCiktiEklemeSayfasi";
            this.Text = "ProblemCiktiEklemeSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alanIDEkleText;
        private System.Windows.Forms.TextBox ciktiIDEkleText;
        private System.Windows.Forms.TextBox sinifIDEkleText;
        private System.Windows.Forms.TextBox problemIDEkleText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}