namespace MO10
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.rgGirl = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.butPersonalIdentificationNumber = new System.Windows.Forms.Button();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.cbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.labDeduction = new System.Windows.Forms.Label();
            this.timDeduction = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "datum narození";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(95, 7);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(151, 20);
            this.dtpBirthdate.TabIndex = 1;
            this.dtpBirthdate.Value = new System.DateTime(2000, 3, 3, 16, 33, 0, 0);
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.DtpBirthdate_ValueChanged);
            // 
            // rgGirl
            // 
            this.rgGirl.AutoSize = true;
            this.rgGirl.Checked = true;
            this.rgGirl.Location = new System.Drawing.Point(14, 53);
            this.rgGirl.Margin = new System.Windows.Forms.Padding(2);
            this.rgGirl.Name = "rgGirl";
            this.rgGirl.Size = new System.Drawing.Size(51, 17);
            this.rgGirl.TabIndex = 2;
            this.rgGirl.TabStop = true;
            this.rgGirl.Text = "holka";
            this.rgGirl.UseVisualStyleBackColor = true;
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Location = new System.Drawing.Point(14, 70);
            this.rbBoy.Margin = new System.Windows.Forms.Padding(2);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(45, 17);
            this.rbBoy.TabIndex = 3;
            this.rbBoy.Text = "kluk";
            this.rbBoy.UseVisualStyleBackColor = true;
            // 
            // butPersonalIdentificationNumber
            // 
            this.butPersonalIdentificationNumber.Location = new System.Drawing.Point(14, 34);
            this.butPersonalIdentificationNumber.Margin = new System.Windows.Forms.Padding(2);
            this.butPersonalIdentificationNumber.Name = "butPersonalIdentificationNumber";
            this.butPersonalIdentificationNumber.Size = new System.Drawing.Size(76, 19);
            this.butPersonalIdentificationNumber.TabIndex = 4;
            this.butPersonalIdentificationNumber.Text = "RČ";
            this.butPersonalIdentificationNumber.UseVisualStyleBackColor = true;
            this.butPersonalIdentificationNumber.Click += new System.EventHandler(this.ButPersonalIdentificationNumber_Click);
            // 
            // rtbOut
            // 
            this.rtbOut.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbOut.Location = new System.Drawing.Point(14, 85);
            this.rtbOut.Margin = new System.Windows.Forms.Padding(2);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(232, 112);
            this.rtbOut.TabIndex = 5;
            this.rtbOut.Text = "";
            // 
            // cbDayOfWeek
            // 
            this.cbDayOfWeek.FormattingEnabled = true;
            this.cbDayOfWeek.Location = new System.Drawing.Point(95, 32);
            this.cbDayOfWeek.Name = "cbDayOfWeek";
            this.cbDayOfWeek.Size = new System.Drawing.Size(151, 21);
            this.cbDayOfWeek.TabIndex = 8;
            this.cbDayOfWeek.Text = "Vyber den v týdnu";
            this.cbDayOfWeek.SelectedIndexChanged += new System.EventHandler(this.CbDayOfWeek_SelectedIndexChanged);
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(95, 59);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(151, 21);
            this.cbDay.TabIndex = 9;
            this.cbDay.Text = "Vyber den";
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.CbDay_SelectedIndexChanged);
            // 
            // labDeduction
            // 
            this.labDeduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDeduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labDeduction.Location = new System.Drawing.Point(12, 199);
            this.labDeduction.Name = "labDeduction";
            this.labDeduction.Size = new System.Drawing.Size(232, 160);
            this.labDeduction.TabIndex = 10;
            this.labDeduction.Text = "odpočet";
            this.labDeduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timDeduction
            // 
            this.timDeduction.Enabled = true;
            this.timDeduction.Tick += new System.EventHandler(this.TimDeduction_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 368);
            this.Controls.Add(this.labDeduction);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbDayOfWeek);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.butPersonalIdentificationNumber);
            this.Controls.Add(this.rbBoy);
            this.Controls.Add(this.rgGirl);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MO10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.RadioButton rgGirl;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.Button butPersonalIdentificationNumber;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.ComboBox cbDayOfWeek;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label labDeduction;
        private System.Windows.Forms.Timer timDeduction;
    }
}

