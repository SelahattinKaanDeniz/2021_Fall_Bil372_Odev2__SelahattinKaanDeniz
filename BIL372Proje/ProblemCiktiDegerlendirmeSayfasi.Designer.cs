
namespace BIL372Proje
{
    partial class ProblemCiktiDegerlendirmeSayfasi
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.problemIDText = new System.Windows.Forms.TextBox();
            this.belirtecIDText = new System.Windows.Forms.TextBox();
            this.skorTarihiText = new System.Windows.Forms.TextBox();
            this.skorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // problemIDText
            // 
            this.problemIDText.Location = new System.Drawing.Point(129, 58);
            this.problemIDText.Name = "problemIDText";
            this.problemIDText.Size = new System.Drawing.Size(153, 22);
            this.problemIDText.TabIndex = 2;
            // 
            // belirtecIDText
            // 
            this.belirtecIDText.Location = new System.Drawing.Point(392, 58);
            this.belirtecIDText.Name = "belirtecIDText";
            this.belirtecIDText.Size = new System.Drawing.Size(152, 22);
            this.belirtecIDText.TabIndex = 3;
            // 
            // skorTarihiText
            // 
            this.skorTarihiText.Location = new System.Drawing.Point(392, 155);
            this.skorTarihiText.Name = "skorTarihiText";
            this.skorTarihiText.Size = new System.Drawing.Size(152, 22);
            this.skorTarihiText.TabIndex = 4;
            // 
            // skorText
            // 
            this.skorText.Location = new System.Drawing.Point(129, 155);
            this.skorText.Name = "skorText";
            this.skorText.Size = new System.Drawing.Size(153, 22);
            this.skorText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Problem ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Belirtec ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Skor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skor Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lütfen bilgileri giriniz.";
            // 
            // ProblemCiktiDegerlendirmeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 297);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skorText);
            this.Controls.Add(this.skorTarihiText);
            this.Controls.Add(this.belirtecIDText);
            this.Controls.Add(this.problemIDText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ProblemCiktiDegerlendirmeSayfasi";
            this.Text = "ProblemCiktiDegerlendirmeSayfasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox problemIDText;
        private System.Windows.Forms.TextBox belirtecIDText;
        private System.Windows.Forms.TextBox skorTarihiText;
        private System.Windows.Forms.TextBox skorText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}