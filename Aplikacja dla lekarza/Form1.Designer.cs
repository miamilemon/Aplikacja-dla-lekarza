
namespace Aplikacja_dla_lekarza
{
    partial class Form1
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
            this.ImieLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.BadanieTextBox = new System.Windows.Forms.TextBox();
            this.ZatwierdzFormBtn = new System.Windows.Forms.Button();
            this.KolejkaBtn = new System.Windows.Forms.Button();
            this.DataDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(12, 48);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(30, 15);
            this.ImieLabel.TabIndex = 0;
            this.ImieLabel.Text = "Imie";
            this.ImieLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Badanie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(64, 40);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(104, 23);
            this.ImieTextBox.TabIndex = 3;
            this.ImieTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BadanieTextBox
            // 
            this.BadanieTextBox.Location = new System.Drawing.Point(64, 70);
            this.BadanieTextBox.Name = "BadanieTextBox";
            this.BadanieTextBox.Size = new System.Drawing.Size(104, 23);
            this.BadanieTextBox.TabIndex = 4;
            // 
            // ZatwierdzFormBtn
            // 
            this.ZatwierdzFormBtn.Location = new System.Drawing.Point(12, 146);
            this.ZatwierdzFormBtn.Name = "ZatwierdzFormBtn";
            this.ZatwierdzFormBtn.Size = new System.Drawing.Size(75, 23);
            this.ZatwierdzFormBtn.TabIndex = 6;
            this.ZatwierdzFormBtn.Text = "Zatwierdź";
            this.ZatwierdzFormBtn.UseVisualStyleBackColor = true;
            this.ZatwierdzFormBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // KolejkaBtn
            // 
            this.KolejkaBtn.Location = new System.Drawing.Point(93, 146);
            this.KolejkaBtn.Name = "KolejkaBtn";
            this.KolejkaBtn.Size = new System.Drawing.Size(75, 23);
            this.KolejkaBtn.TabIndex = 7;
            this.KolejkaBtn.Text = "Kolejka";
            this.KolejkaBtn.UseVisualStyleBackColor = true;
            this.KolejkaBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataDateTime
            // 
            this.DataDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDateTime.Location = new System.Drawing.Point(64, 101);
            this.DataDateTime.Name = "DataDateTime";
            this.DataDateTime.Size = new System.Drawing.Size(104, 23);
            this.DataDateTime.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 220);
            this.Controls.Add(this.DataDateTime);
            this.Controls.Add(this.KolejkaBtn);
            this.Controls.Add(this.ZatwierdzFormBtn);
            this.Controls.Add(this.BadanieTextBox);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImieLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.TextBox BadanieTextBox;
        private System.Windows.Forms.Button ZatwierdzFormBtn;
        private System.Windows.Forms.Button KolejkaBtn;
        private System.Windows.Forms.DateTimePicker DataDateTime;
    }
}

