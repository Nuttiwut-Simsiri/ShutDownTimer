namespace ShutdownTimer
{
    partial class ShutdownTimer
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
            this.actionDropDown = new System.Windows.Forms.ComboBox();
            this.timerSetter = new System.Windows.Forms.NumericUpDown();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.summary_box = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerSetter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionDropDown
            // 
            this.actionDropDown.DropDownHeight = 120;
            this.actionDropDown.FormattingEnabled = true;
            this.actionDropDown.IntegralHeight = false;
            this.actionDropDown.ItemHeight = 13;
            this.actionDropDown.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Abort"});
            this.actionDropDown.Location = new System.Drawing.Point(40, 47);
            this.actionDropDown.MaxDropDownItems = 3;
            this.actionDropDown.Name = "actionDropDown";
            this.actionDropDown.Size = new System.Drawing.Size(282, 21);
            this.actionDropDown.TabIndex = 1;
            this.actionDropDown.Text = "Select Action";
            // 
            // timerSetter
            // 
            this.timerSetter.DecimalPlaces = 1;
            this.timerSetter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timerSetter.Location = new System.Drawing.Point(40, 64);
            this.timerSetter.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timerSetter.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timerSetter.Name = "timerSetter";
            this.timerSetter.Size = new System.Drawing.Size(282, 20);
            this.timerSetter.TabIndex = 4;
            this.timerSetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerSetter.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_confirm.Location = new System.Drawing.Point(29, 31);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(303, 50);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // summary_box
            // 
            this.summary_box.Location = new System.Drawing.Point(6, 19);
            this.summary_box.Name = "summary_box";
            this.summary_box.Size = new System.Drawing.Size(344, 46);
            this.summary_box.TabIndex = 5;
            this.summary_box.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actionDropDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timerSetter);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 104);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_confirm);
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.summary_box);
            this.groupBox4.Location = new System.Drawing.Point(12, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 71);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action Status";
            // 
            // ShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 411);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShutdownTimer";
            this.Text = "ShutDownTimer";
            this.Load += new System.EventHandler(this.ShutdownTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timerSetter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox actionDropDown;
        private System.Windows.Forms.NumericUpDown timerSetter;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.RichTextBox summary_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

