
namespace Ogrenci_Sinav_Not_Kayit_Sistemi
{
    partial class Ogrenci_Kayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.number_textbox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number:";
            // 
            // number_textbox
            // 
            this.number_textbox.Location = new System.Drawing.Point(169, 24);
            this.number_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.number_textbox.Mask = "0000";
            this.number_textbox.Name = "number_textbox";
            this.number_textbox.Size = new System.Drawing.Size(80, 22);
            this.number_textbox.TabIndex = 1;
            this.number_textbox.ValidatingType = typeof(int);
            this.number_textbox.TextChanged += new System.EventHandler(this.number_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log in:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ogrenci_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(373, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.number_textbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ogrenci_Kayit";
            this.Text = "Ogrenci Detay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox number_textbox;
        private System.Windows.Forms.Button button1;
    }
}

