namespace Night_Surfer_Program
{
    partial class formMain
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
            this.hourTime1 = new System.Windows.Forms.NumericUpDown();
            this.minuteTime1 = new System.Windows.Forms.NumericUpDown();
            this.secondTime1 = new System.Windows.Forms.NumericUpDown();
            this.hourTime2 = new System.Windows.Forms.NumericUpDown();
            this.minuteTime2 = new System.Windows.Forms.NumericUpDown();
            this.secondTime2 = new System.Windows.Forms.NumericUpDown();
            this.buttonTime1 = new System.Windows.Forms.Button();
            this.buttonTime2 = new System.Windows.Forms.Button();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelProgress1 = new System.Windows.Forms.Label();
            this.labelProgress2 = new System.Windows.Forms.Label();
            this.labelHour1 = new System.Windows.Forms.Label();
            this.labelMinute1 = new System.Windows.Forms.Label();
            this.labelSecond1 = new System.Windows.Forms.Label();
            this.labelHour2 = new System.Windows.Forms.Label();
            this.labelMinute2 = new System.Windows.Forms.Label();
            this.labelSecond2 = new System.Windows.Forms.Label();
            this.timerClick1 = new System.Windows.Forms.Timer(this.components);
            this.timerClick2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hourTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourTime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteTime2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTime2)).BeginInit();
            this.SuspendLayout();
            // 
            // hourTime1
            // 
            this.hourTime1.Location = new System.Drawing.Point(20, 20);
            this.hourTime1.Name = "hourTime1";
            this.hourTime1.Size = new System.Drawing.Size(36, 20);
            this.hourTime1.TabIndex = 0;
            // 
            // minuteTime1
            // 
            this.minuteTime1.Location = new System.Drawing.Point(80, 20);
            this.minuteTime1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteTime1.Name = "minuteTime1";
            this.minuteTime1.Size = new System.Drawing.Size(36, 20);
            this.minuteTime1.TabIndex = 1;
            // 
            // secondTime1
            // 
            this.secondTime1.Location = new System.Drawing.Point(140, 20);
            this.secondTime1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondTime1.Name = "secondTime1";
            this.secondTime1.Size = new System.Drawing.Size(36, 20);
            this.secondTime1.TabIndex = 2;
            this.secondTime1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // hourTime2
            // 
            this.hourTime2.Location = new System.Drawing.Point(20, 80);
            this.hourTime2.Name = "hourTime2";
            this.hourTime2.Size = new System.Drawing.Size(36, 20);
            this.hourTime2.TabIndex = 3;
            // 
            // minuteTime2
            // 
            this.minuteTime2.Location = new System.Drawing.Point(80, 80);
            this.minuteTime2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteTime2.Name = "minuteTime2";
            this.minuteTime2.Size = new System.Drawing.Size(36, 20);
            this.minuteTime2.TabIndex = 4;
            // 
            // secondTime2
            // 
            this.secondTime2.Location = new System.Drawing.Point(140, 80);
            this.secondTime2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondTime2.Name = "secondTime2";
            this.secondTime2.Size = new System.Drawing.Size(36, 20);
            this.secondTime2.TabIndex = 5;
            this.secondTime2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // buttonTime1
            // 
            this.buttonTime1.Location = new System.Drawing.Point(220, 20);
            this.buttonTime1.Name = "buttonTime1";
            this.buttonTime1.Size = new System.Drawing.Size(75, 23);
            this.buttonTime1.TabIndex = 6;
            this.buttonTime1.Text = "Enter Time 1";
            this.buttonTime1.UseVisualStyleBackColor = true;
            this.buttonTime1.Click += new System.EventHandler(this.buttonTime1_Click);
            // 
            // buttonTime2
            // 
            this.buttonTime2.Location = new System.Drawing.Point(220, 80);
            this.buttonTime2.Name = "buttonTime2";
            this.buttonTime2.Size = new System.Drawing.Size(75, 23);
            this.buttonTime2.TabIndex = 7;
            this.buttonTime2.Text = "Enter Time 2";
            this.buttonTime2.UseVisualStyleBackColor = true;
            this.buttonTime2.Click += new System.EventHandler(this.buttonTime2_Click);
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Location = new System.Drawing.Point(340, 20);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(96, 13);
            this.labelTime1.TabIndex = 8;
            this.labelTime1.Text = "Time until first click";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Location = new System.Drawing.Point(340, 80);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(115, 13);
            this.labelTime2.TabIndex = 9;
            this.labelTime2.Text = "Time until second click";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(175, 140);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(150, 59);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start Program";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelProgress1
            // 
            this.labelProgress1.AutoSize = true;
            this.labelProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress1.Location = new System.Drawing.Point(168, 280);
            this.labelProgress1.Name = "labelProgress1";
            this.labelProgress1.Size = new System.Drawing.Size(35, 37);
            this.labelProgress1.TabIndex = 11;
            this.labelProgress1.Text = "0";
            // 
            // labelProgress2
            // 
            this.labelProgress2.AutoSize = true;
            this.labelProgress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress2.Location = new System.Drawing.Point(290, 280);
            this.labelProgress2.Name = "labelProgress2";
            this.labelProgress2.Size = new System.Drawing.Size(35, 37);
            this.labelProgress2.TabIndex = 12;
            this.labelProgress2.Text = "0";
            // 
            // labelHour1
            // 
            this.labelHour1.AutoSize = true;
            this.labelHour1.Location = new System.Drawing.Point(58, 25);
            this.labelHour1.Name = "labelHour1";
            this.labelHour1.Size = new System.Drawing.Size(15, 13);
            this.labelHour1.TabIndex = 15;
            this.labelHour1.Text = "H";
            // 
            // labelMinute1
            // 
            this.labelMinute1.AutoSize = true;
            this.labelMinute1.Location = new System.Drawing.Point(118, 25);
            this.labelMinute1.Name = "labelMinute1";
            this.labelMinute1.Size = new System.Drawing.Size(16, 13);
            this.labelMinute1.TabIndex = 16;
            this.labelMinute1.Text = "M";
            // 
            // labelSecond1
            // 
            this.labelSecond1.AutoSize = true;
            this.labelSecond1.Location = new System.Drawing.Point(178, 25);
            this.labelSecond1.Name = "labelSecond1";
            this.labelSecond1.Size = new System.Drawing.Size(14, 13);
            this.labelSecond1.TabIndex = 17;
            this.labelSecond1.Text = "S";
            // 
            // labelHour2
            // 
            this.labelHour2.AutoSize = true;
            this.labelHour2.Location = new System.Drawing.Point(58, 85);
            this.labelHour2.Name = "labelHour2";
            this.labelHour2.Size = new System.Drawing.Size(15, 13);
            this.labelHour2.TabIndex = 18;
            this.labelHour2.Text = "H";
            // 
            // labelMinute2
            // 
            this.labelMinute2.AutoSize = true;
            this.labelMinute2.Location = new System.Drawing.Point(118, 85);
            this.labelMinute2.Name = "labelMinute2";
            this.labelMinute2.Size = new System.Drawing.Size(16, 13);
            this.labelMinute2.TabIndex = 19;
            this.labelMinute2.Text = "M";
            // 
            // labelSecond2
            // 
            this.labelSecond2.AutoSize = true;
            this.labelSecond2.Location = new System.Drawing.Point(178, 85);
            this.labelSecond2.Name = "labelSecond2";
            this.labelSecond2.Size = new System.Drawing.Size(14, 13);
            this.labelSecond2.TabIndex = 20;
            this.labelSecond2.Text = "S";
            // 
            // timerClick1
            // 
            this.timerClick1.Interval = 1000;
            this.timerClick1.Tick += new System.EventHandler(this.timerClick1_Tick);
            // 
            // timerClick2
            // 
            this.timerClick2.Interval = 1000;
            this.timerClick2.Tick += new System.EventHandler(this.timerClick2_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.labelSecond2);
            this.Controls.Add(this.labelMinute2);
            this.Controls.Add(this.labelHour2);
            this.Controls.Add(this.labelSecond1);
            this.Controls.Add(this.labelMinute1);
            this.Controls.Add(this.labelHour1);
            this.Controls.Add(this.labelProgress2);
            this.Controls.Add(this.labelProgress1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTime2);
            this.Controls.Add(this.labelTime1);
            this.Controls.Add(this.buttonTime2);
            this.Controls.Add(this.buttonTime1);
            this.Controls.Add(this.secondTime2);
            this.Controls.Add(this.minuteTime2);
            this.Controls.Add(this.hourTime2);
            this.Controls.Add(this.secondTime1);
            this.Controls.Add(this.minuteTime1);
            this.Controls.Add(this.hourTime1);
            this.Name = "formMain";
            this.Text = "Night Surfer Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourTime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteTime2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTime2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hourTime1;
        private System.Windows.Forms.NumericUpDown minuteTime1;
        private System.Windows.Forms.NumericUpDown secondTime1;
        private System.Windows.Forms.NumericUpDown hourTime2;
        private System.Windows.Forms.NumericUpDown minuteTime2;
        private System.Windows.Forms.NumericUpDown secondTime2;
        private System.Windows.Forms.Button buttonTime1;
        private System.Windows.Forms.Button buttonTime2;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelProgress1;
        private System.Windows.Forms.Label labelProgress2;
        private System.Windows.Forms.Label labelHour1;
        private System.Windows.Forms.Label labelMinute1;
        private System.Windows.Forms.Label labelSecond1;
        private System.Windows.Forms.Label labelHour2;
        private System.Windows.Forms.Label labelMinute2;
        private System.Windows.Forms.Label labelSecond2;
        private System.Windows.Forms.Timer timerClick1;
        private System.Windows.Forms.Timer timerClick2;
    }
}

