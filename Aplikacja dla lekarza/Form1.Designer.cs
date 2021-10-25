
namespace Aplikacja_dla_lekarza
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
            this.components = new System.ComponentModel.Container();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.badanieTextBox = new System.Windows.Forms.TextBox();
            this.dataBadaniaDateTime = new System.Windows.Forms.DateTimePicker();
            this.imiedodajLabel = new System.Windows.Forms.Label();
            this.badaniedodajLabel = new System.Windows.Forms.Label();
            this.datadodajLabel = new System.Windows.Forms.Label();
            this.dodawaniapacjentaLabel = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usunButton = new System.Windows.Forms.Button();
            this.previmieLabel = new System.Windows.Forms.Label();
            this.prevbadanieLabel = new System.Windows.Forms.Label();
            this.prevdataLabel = new System.Windows.Forms.Label();
            this.currimieLabel = new System.Windows.Forms.Label();
            this.currbadanieLabel = new System.Windows.Forms.Label();
            this.currdataLabel = new System.Windows.Forms.Label();
            this.nextimieLabel = new System.Windows.Forms.Label();
            this.nextbadanieLabel = new System.Windows.Forms.Label();
            this.nextdataLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.godzinaLabel = new System.Windows.Forms.Label();
            this.godzinaTimer = new System.Windows.Forms.Timer(this.components);
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.badaniezaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(73, 43);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(100, 20);
            this.imieTextBox.TabIndex = 0;
            // 
            // badanieTextBox
            // 
            this.badanieTextBox.Location = new System.Drawing.Point(73, 69);
            this.badanieTextBox.Name = "badanieTextBox";
            this.badanieTextBox.Size = new System.Drawing.Size(100, 20);
            this.badanieTextBox.TabIndex = 1;
            // 
            // dataBadaniaDateTime
            // 
            this.dataBadaniaDateTime.CustomFormat = "";
            this.dataBadaniaDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataBadaniaDateTime.Location = new System.Drawing.Point(73, 95);
            this.dataBadaniaDateTime.Name = "dataBadaniaDateTime";
            this.dataBadaniaDateTime.Size = new System.Drawing.Size(100, 20);
            this.dataBadaniaDateTime.TabIndex = 2;
            // 
            // imiedodajLabel
            // 
            this.imiedodajLabel.AutoSize = true;
            this.imiedodajLabel.Location = new System.Drawing.Point(12, 50);
            this.imiedodajLabel.Name = "imiedodajLabel";
            this.imiedodajLabel.Size = new System.Drawing.Size(26, 13);
            this.imiedodajLabel.TabIndex = 3;
            this.imiedodajLabel.Text = "Imie";
            // 
            // badaniedodajLabel
            // 
            this.badaniedodajLabel.AutoSize = true;
            this.badaniedodajLabel.Location = new System.Drawing.Point(12, 76);
            this.badaniedodajLabel.Name = "badaniedodajLabel";
            this.badaniedodajLabel.Size = new System.Drawing.Size(46, 13);
            this.badaniedodajLabel.TabIndex = 4;
            this.badaniedodajLabel.Text = "Badanie";
            // 
            // datadodajLabel
            // 
            this.datadodajLabel.AutoSize = true;
            this.datadodajLabel.Location = new System.Drawing.Point(12, 102);
            this.datadodajLabel.Name = "datadodajLabel";
            this.datadodajLabel.Size = new System.Drawing.Size(30, 13);
            this.datadodajLabel.TabIndex = 5;
            this.datadodajLabel.Text = "Data";
            // 
            // dodawaniapacjentaLabel
            // 
            this.dodawaniapacjentaLabel.AutoSize = true;
            this.dodawaniapacjentaLabel.Location = new System.Drawing.Point(45, 16);
            this.dodawaniapacjentaLabel.Name = "dodawaniapacjentaLabel";
            this.dodawaniapacjentaLabel.Size = new System.Drawing.Size(105, 13);
            this.dodawaniapacjentaLabel.TabIndex = 6;
            this.dodawaniapacjentaLabel.Text = "Dodawanie pacjenta";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(73, 121);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 23);
            this.dodajButton.TabIndex = 7;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Poprzedni pacjent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(372, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Obecny pacjent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Następny pacjent";
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(73, 151);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(100, 23);
            this.usunButton.TabIndex = 11;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // previmieLabel
            // 
            this.previmieLabel.AutoSize = true;
            this.previmieLabel.Location = new System.Drawing.Point(220, 49);
            this.previmieLabel.Name = "previmieLabel";
            this.previmieLabel.Size = new System.Drawing.Size(67, 13);
            this.previmieLabel.TabIndex = 12;
            this.previmieLabel.Text = "Brak danych";
            // 
            // prevbadanieLabel
            // 
            this.prevbadanieLabel.AutoSize = true;
            this.prevbadanieLabel.Location = new System.Drawing.Point(220, 76);
            this.prevbadanieLabel.Name = "prevbadanieLabel";
            this.prevbadanieLabel.Size = new System.Drawing.Size(67, 13);
            this.prevbadanieLabel.TabIndex = 13;
            this.prevbadanieLabel.Text = "Brak danych";
            // 
            // prevdataLabel
            // 
            this.prevdataLabel.AutoSize = true;
            this.prevdataLabel.Location = new System.Drawing.Point(220, 102);
            this.prevdataLabel.Name = "prevdataLabel";
            this.prevdataLabel.Size = new System.Drawing.Size(67, 13);
            this.prevdataLabel.TabIndex = 14;
            this.prevdataLabel.Text = "Brak danych";
            // 
            // currimieLabel
            // 
            this.currimieLabel.AutoSize = true;
            this.currimieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currimieLabel.Location = new System.Drawing.Point(372, 50);
            this.currimieLabel.Name = "currimieLabel";
            this.currimieLabel.Size = new System.Drawing.Size(78, 13);
            this.currimieLabel.TabIndex = 15;
            this.currimieLabel.Text = "Brak danych";
            // 
            // currbadanieLabel
            // 
            this.currbadanieLabel.AutoSize = true;
            this.currbadanieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currbadanieLabel.Location = new System.Drawing.Point(372, 76);
            this.currbadanieLabel.Name = "currbadanieLabel";
            this.currbadanieLabel.Size = new System.Drawing.Size(78, 13);
            this.currbadanieLabel.TabIndex = 16;
            this.currbadanieLabel.Text = "Brak danych";
            // 
            // currdataLabel
            // 
            this.currdataLabel.AutoSize = true;
            this.currdataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currdataLabel.Location = new System.Drawing.Point(372, 101);
            this.currdataLabel.Name = "currdataLabel";
            this.currdataLabel.Size = new System.Drawing.Size(78, 13);
            this.currdataLabel.TabIndex = 17;
            this.currdataLabel.Text = "Brak danych";
            // 
            // nextimieLabel
            // 
            this.nextimieLabel.AutoSize = true;
            this.nextimieLabel.Location = new System.Drawing.Point(538, 50);
            this.nextimieLabel.Name = "nextimieLabel";
            this.nextimieLabel.Size = new System.Drawing.Size(67, 13);
            this.nextimieLabel.TabIndex = 18;
            this.nextimieLabel.Text = "Brak danych";
            // 
            // nextbadanieLabel
            // 
            this.nextbadanieLabel.AutoSize = true;
            this.nextbadanieLabel.Location = new System.Drawing.Point(538, 76);
            this.nextbadanieLabel.Name = "nextbadanieLabel";
            this.nextbadanieLabel.Size = new System.Drawing.Size(67, 13);
            this.nextbadanieLabel.TabIndex = 19;
            this.nextbadanieLabel.Text = "Brak danych";
            // 
            // nextdataLabel
            // 
            this.nextdataLabel.AutoSize = true;
            this.nextdataLabel.Location = new System.Drawing.Point(538, 101);
            this.nextdataLabel.Name = "nextdataLabel";
            this.nextdataLabel.Size = new System.Drawing.Size(67, 13);
            this.nextdataLabel.TabIndex = 20;
            this.nextdataLabel.Text = "Brak danych";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(12, 196);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(57, 13);
            this.dataLabel.TabIndex = 21;
            this.dataLabel.Text = "Data ~30s";
            // 
            // godzinaLabel
            // 
            this.godzinaLabel.AutoSize = true;
            this.godzinaLabel.Location = new System.Drawing.Point(82, 196);
            this.godzinaLabel.Name = "godzinaLabel";
            this.godzinaLabel.Size = new System.Drawing.Size(73, 13);
            this.godzinaLabel.TabIndex = 22;
            this.godzinaLabel.Text = "Godzina ~10s";
            // 
            // godzinaTimer
            // 
            this.godzinaTimer.Enabled = true;
            this.godzinaTimer.Interval = 10000;
            this.godzinaTimer.Tick += new System.EventHandler(this.godzinaTimer_Tick);
            // 
            // dataTimer
            // 
            this.dataTimer.Enabled = true;
            this.dataTimer.Interval = 30000;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // badaniezaLabel
            // 
            this.badaniezaLabel.AutoSize = true;
            this.badaniezaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.badaniezaLabel.Location = new System.Drawing.Point(372, 126);
            this.badaniezaLabel.Name = "badaniezaLabel";
            this.badaniezaLabel.Size = new System.Drawing.Size(78, 13);
            this.badaniezaLabel.TabIndex = 23;
            this.badaniezaLabel.Text = "Brak danych";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 221);
            this.Controls.Add(this.badaniezaLabel);
            this.Controls.Add(this.godzinaLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.nextdataLabel);
            this.Controls.Add(this.nextbadanieLabel);
            this.Controls.Add(this.nextimieLabel);
            this.Controls.Add(this.currdataLabel);
            this.Controls.Add(this.currbadanieLabel);
            this.Controls.Add(this.currimieLabel);
            this.Controls.Add(this.prevdataLabel);
            this.Controls.Add(this.prevbadanieLabel);
            this.Controls.Add(this.previmieLabel);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.dodawaniapacjentaLabel);
            this.Controls.Add(this.datadodajLabel);
            this.Controls.Add(this.badaniedodajLabel);
            this.Controls.Add(this.imiedodajLabel);
            this.Controls.Add(this.dataBadaniaDateTime);
            this.Controls.Add(this.badanieTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox badanieTextBox;
        private System.Windows.Forms.DateTimePicker dataBadaniaDateTime;
        private System.Windows.Forms.Label imiedodajLabel;
        private System.Windows.Forms.Label badaniedodajLabel;
        private System.Windows.Forms.Label datadodajLabel;
        private System.Windows.Forms.Label dodawaniapacjentaLabel;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.Label previmieLabel;
        private System.Windows.Forms.Label prevbadanieLabel;
        private System.Windows.Forms.Label prevdataLabel;
        private System.Windows.Forms.Label currimieLabel;
        private System.Windows.Forms.Label currbadanieLabel;
        private System.Windows.Forms.Label currdataLabel;
        private System.Windows.Forms.Label nextimieLabel;
        private System.Windows.Forms.Label nextbadanieLabel;
        private System.Windows.Forms.Label nextdataLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label godzinaLabel;
        private System.Windows.Forms.Timer godzinaTimer;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Label badaniezaLabel;
    }
}

