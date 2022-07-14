namespace ThermalPlotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_FileName = new System.Windows.Forms.TextBox();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_autoScaleX = new System.Windows.Forms.CheckBox();
            this.check_autoScaleY = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_minT4 = new System.Windows.Forms.Button();
            this.button_maxT4 = new System.Windows.Forms.Button();
            this.button_minT3 = new System.Windows.Forms.Button();
            this.button_minT2 = new System.Windows.Forms.Button();
            this.label_T4 = new System.Windows.Forms.Label();
            this.button_maxT3 = new System.Windows.Forms.Button();
            this.label_T1 = new System.Windows.Forms.Label();
            this.button_maxT2 = new System.Windows.Forms.Button();
            this.label_T3 = new System.Windows.Forms.Label();
            this.button_maxT1 = new System.Windows.Forms.Button();
            this.label_T2 = new System.Windows.Forms.Label();
            this.button_minT1 = new System.Windows.Forms.Button();
            this.label_Elapsed = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.check_startStop = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_batteryStatus = new System.Windows.Forms.Label();
            this.label_recordingMode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formsPlot1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formsPlot1.Location = new System.Drawing.Point(1, 102);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(780, 422);
            this.formsPlot1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 87);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ver 1.0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_startStop);
            this.groupBox3.Controls.Add(this.comboBox_Port);
            this.groupBox3.Location = new System.Drawing.Point(488, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 81);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.comboBox_Port.Location = new System.Drawing.Point(17, 18);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(73, 21);
            this.comboBox_Port.TabIndex = 1;
            this.comboBox_Port.SelectedIndexChanged += new System.EventHandler(this.OnComPortChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_FileName);
            this.groupBox2.Controls.Add(this.button_Export);
            this.groupBox2.Controls.Add(this.button_Reset);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 81);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Export";
            // 
            // text_FileName
            // 
            this.text_FileName.Location = new System.Drawing.Point(19, 19);
            this.text_FileName.Name = "text_FileName";
            this.text_FileName.Size = new System.Drawing.Size(352, 20);
            this.text_FileName.TabIndex = 9;
            // 
            // button_Export
            // 
            this.button_Export.Location = new System.Drawing.Point(298, 49);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(73, 22);
            this.button_Export.TabIndex = 8;
            this.button_Export.Text = "Export...";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.OnExport);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(19, 49);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(73, 22);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.OnButtonReset);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_autoScaleX);
            this.groupBox1.Controls.Add(this.check_autoScaleY);
            this.groupBox1.Location = new System.Drawing.Point(386, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scaling";
            // 
            // check_autoScaleX
            // 
            this.check_autoScaleX.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_autoScaleX.AutoSize = true;
            this.check_autoScaleX.Checked = true;
            this.check_autoScaleX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_autoScaleX.Location = new System.Drawing.Point(12, 16);
            this.check_autoScaleX.Name = "check_autoScaleX";
            this.check_autoScaleX.Size = new System.Drawing.Size(73, 23);
            this.check_autoScaleX.TabIndex = 3;
            this.check_autoScaleX.Text = "AutoScaleX";
            this.check_autoScaleX.UseVisualStyleBackColor = true;
            // 
            // check_autoScaleY
            // 
            this.check_autoScaleY.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_autoScaleY.AutoSize = true;
            this.check_autoScaleY.Checked = true;
            this.check_autoScaleY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_autoScaleY.Location = new System.Drawing.Point(12, 48);
            this.check_autoScaleY.Name = "check_autoScaleY";
            this.check_autoScaleY.Size = new System.Drawing.Size(73, 23);
            this.check_autoScaleY.TabIndex = 2;
            this.check_autoScaleY.Text = "AutoScaleY";
            this.check_autoScaleY.UseVisualStyleBackColor = true;
            this.check_autoScaleY.CheckedChanged += new System.EventHandler(this.OnComPortChange);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Location = new System.Drawing.Point(1, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 101);
            this.panel2.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_minT4);
            this.groupBox5.Controls.Add(this.button_maxT4);
            this.groupBox5.Controls.Add(this.button_minT3);
            this.groupBox5.Controls.Add(this.button_minT2);
            this.groupBox5.Controls.Add(this.label_T4);
            this.groupBox5.Controls.Add(this.button_maxT3);
            this.groupBox5.Controls.Add(this.label_T1);
            this.groupBox5.Controls.Add(this.button_maxT2);
            this.groupBox5.Controls.Add(this.label_T3);
            this.groupBox5.Controls.Add(this.button_maxT1);
            this.groupBox5.Controls.Add(this.label_T2);
            this.groupBox5.Controls.Add(this.button_minT1);
            this.groupBox5.Location = new System.Drawing.Point(9, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(629, 100);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Temperature";
            // 
            // button_minT4
            // 
            this.button_minT4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minT4.Location = new System.Drawing.Point(416, 68);
            this.button_minT4.Name = "button_minT4";
            this.button_minT4.Size = new System.Drawing.Size(77, 22);
            this.button_minT4.TabIndex = 20;
            this.button_minT4.Text = "min: T4";
            this.button_minT4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_minT4.UseVisualStyleBackColor = true;
            this.button_minT4.Click += new System.EventHandler(this.button_minT4_Click);
            // 
            // button_maxT4
            // 
            this.button_maxT4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maxT4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maxT4.Location = new System.Drawing.Point(416, 44);
            this.button_maxT4.Name = "button_maxT4";
            this.button_maxT4.Size = new System.Drawing.Size(77, 22);
            this.button_maxT4.TabIndex = 19;
            this.button_maxT4.Text = "max: T4";
            this.button_maxT4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maxT4.UseVisualStyleBackColor = true;
            this.button_maxT4.Click += new System.EventHandler(this.button_maxT4_Click);
            // 
            // button_minT3
            // 
            this.button_minT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minT3.Location = new System.Drawing.Point(291, 70);
            this.button_minT3.Name = "button_minT3";
            this.button_minT3.Size = new System.Drawing.Size(77, 22);
            this.button_minT3.TabIndex = 18;
            this.button_minT3.Text = "min: T3";
            this.button_minT3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_minT3.UseVisualStyleBackColor = true;
            this.button_minT3.Click += new System.EventHandler(this.button_minT3_Click);
            // 
            // button_minT2
            // 
            this.button_minT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minT2.Location = new System.Drawing.Point(166, 70);
            this.button_minT2.Name = "button_minT2";
            this.button_minT2.Size = new System.Drawing.Size(77, 22);
            this.button_minT2.TabIndex = 16;
            this.button_minT2.Text = "min: T2";
            this.button_minT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_minT2.UseVisualStyleBackColor = true;
            this.button_minT2.Click += new System.EventHandler(this.button_minT2_Click);
            // 
            // label_T4
            // 
            this.label_T4.AutoSize = true;
            this.label_T4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_T4.Location = new System.Drawing.Point(411, 16);
            this.label_T4.Name = "label_T4";
            this.label_T4.Size = new System.Drawing.Size(35, 25);
            this.label_T4.TabIndex = 7;
            this.label_T4.Text = "T4";
            // 
            // button_maxT3
            // 
            this.button_maxT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maxT3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maxT3.Location = new System.Drawing.Point(291, 44);
            this.button_maxT3.Name = "button_maxT3";
            this.button_maxT3.Size = new System.Drawing.Size(77, 22);
            this.button_maxT3.TabIndex = 17;
            this.button_maxT3.Text = "max: T3";
            this.button_maxT3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maxT3.UseVisualStyleBackColor = true;
            this.button_maxT3.Click += new System.EventHandler(this.button_maxT3_Click);
            // 
            // label_T1
            // 
            this.label_T1.AutoSize = true;
            this.label_T1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_T1.Location = new System.Drawing.Point(36, 16);
            this.label_T1.Name = "label_T1";
            this.label_T1.Size = new System.Drawing.Size(35, 25);
            this.label_T1.TabIndex = 4;
            this.label_T1.Text = "T1";
            // 
            // button_maxT2
            // 
            this.button_maxT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maxT2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maxT2.Location = new System.Drawing.Point(166, 44);
            this.button_maxT2.Name = "button_maxT2";
            this.button_maxT2.Size = new System.Drawing.Size(77, 22);
            this.button_maxT2.TabIndex = 15;
            this.button_maxT2.Text = "max: T2";
            this.button_maxT2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maxT2.UseVisualStyleBackColor = true;
            this.button_maxT2.Click += new System.EventHandler(this.button_maxT2_Click);
            // 
            // label_T3
            // 
            this.label_T3.AutoSize = true;
            this.label_T3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_T3.Location = new System.Drawing.Point(286, 16);
            this.label_T3.Name = "label_T3";
            this.label_T3.Size = new System.Drawing.Size(35, 25);
            this.label_T3.TabIndex = 6;
            this.label_T3.Text = "T3";
            // 
            // button_maxT1
            // 
            this.button_maxT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maxT1.Location = new System.Drawing.Point(41, 44);
            this.button_maxT1.Name = "button_maxT1";
            this.button_maxT1.Size = new System.Drawing.Size(77, 22);
            this.button_maxT1.TabIndex = 13;
            this.button_maxT1.Text = "max: T1";
            this.button_maxT1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maxT1.UseVisualStyleBackColor = true;
            this.button_maxT1.Click += new System.EventHandler(this.button_maxT1_Click);
            // 
            // label_T2
            // 
            this.label_T2.AutoSize = true;
            this.label_T2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_T2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_T2.Location = new System.Drawing.Point(161, 16);
            this.label_T2.Name = "label_T2";
            this.label_T2.Size = new System.Drawing.Size(35, 25);
            this.label_T2.TabIndex = 5;
            this.label_T2.Text = "T2";
            // 
            // button_minT1
            // 
            this.button_minT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minT1.Location = new System.Drawing.Point(41, 70);
            this.button_minT1.Name = "button_minT1";
            this.button_minT1.Size = new System.Drawing.Size(77, 22);
            this.button_minT1.TabIndex = 14;
            this.button_minT1.Text = "min: T1";
            this.button_minT1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_minT1.UseVisualStyleBackColor = true;
            this.button_minT1.Click += new System.EventHandler(this.button_minT1_Click);
            // 
            // label_Elapsed
            // 
            this.label_Elapsed.AutoSize = true;
            this.label_Elapsed.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Elapsed.ForeColor = System.Drawing.Color.Gray;
            this.label_Elapsed.Location = new System.Drawing.Point(31, 31);
            this.label_Elapsed.Name = "label_Elapsed";
            this.label_Elapsed.Size = new System.Drawing.Size(81, 25);
            this.label_Elapsed.TabIndex = 12;
            this.label_Elapsed.Text = "0:00:00";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(23, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox4);
            this.panel4.Location = new System.Drawing.Point(663, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 101);
            this.panel4.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label_Elapsed);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Elapsed Time";
            // 
            // check_startStop
            // 
            this.check_startStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_startStop.Location = new System.Drawing.Point(17, 48);
            this.check_startStop.Name = "check_startStop";
            this.check_startStop.Size = new System.Drawing.Size(73, 23);
            this.check_startStop.TabIndex = 3;
            this.check_startStop.Text = "Pause";
            this.check_startStop.UseVisualStyleBackColor = true;
            this.check_startStop.CheckedChanged += new System.EventHandler(this.check_startStop_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label_recordingMode);
            this.groupBox6.Controls.Add(this.label_batteryStatus);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(599, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(201, 81);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Meter Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Battery Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Recording Mode:";
            // 
            // label_batteryStatus
            // 
            this.label_batteryStatus.Location = new System.Drawing.Point(116, 24);
            this.label_batteryStatus.Name = "label_batteryStatus";
            this.label_batteryStatus.Size = new System.Drawing.Size(76, 13);
            this.label_batteryStatus.TabIndex = 2;
            this.label_batteryStatus.Text = "N/A";
            // 
            // label_recordingMode
            // 
            this.label_recordingMode.Location = new System.Drawing.Point(116, 51);
            this.label_recordingMode.Name = "label_recordingMode";
            this.label_recordingMode.Size = new System.Drawing.Size(76, 13);
            this.label_recordingMode.TabIndex = 3;
            this.label_recordingMode.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 616);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formsPlot1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "TC0304 Thermal Plotter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_FileName;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_autoScaleX;
        private System.Windows.Forms.CheckBox check_autoScaleY;
        private System.Windows.Forms.Button button_Reset;
        public System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Elapsed;
        private System.Windows.Forms.Label label_T1;
        private System.Windows.Forms.Label label_T2;
        private System.Windows.Forms.Label label_T3;
        private System.Windows.Forms.Label label_T4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_minT4;
        private System.Windows.Forms.Button button_maxT4;
        private System.Windows.Forms.Button button_minT3;
        private System.Windows.Forms.Button button_maxT3;
        private System.Windows.Forms.Button button_minT2;
        private System.Windows.Forms.Button button_maxT2;
        private System.Windows.Forms.Button button_minT1;
        private System.Windows.Forms.Button button_maxT1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox check_startStop;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label_recordingMode;
        private System.Windows.Forms.Label label_batteryStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }


}

