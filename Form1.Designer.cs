﻿namespace musical
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_save_0 = new System.Windows.Forms.Button();
            this.panel_diaoshi_0 = new System.Windows.Forms.DomainUpDown();
            this.panel_instrument_0 = new System.Windows.Forms.DomainUpDown();
            this.panel_time_right_0 = new System.Windows.Forms.Label();
            this.panel_time_left_0 = new System.Windows.Forms.Label();
            this.panel_time_0 = new System.Windows.Forms.ProgressBar();
            this.panel_stop_0 = new System.Windows.Forms.Button();
            this.panel_add_0 = new System.Windows.Forms.Button();
            this.panel_start_0 = new System.Windows.Forms.Button();
            this.panel_reset_0 = new System.Windows.Forms.Button();
            this.panel_delete_0 = new System.Windows.Forms.Button();
            this.panel_basenote_0 = new System.Windows.Forms.TextBox();
            this.panel_label2_0 = new System.Windows.Forms.Label();
            this.panel_speed_0 = new System.Windows.Forms.TextBox();
            this.panel_label1_0 = new System.Windows.Forms.Label();
            this.panel_power_show_0 = new System.Windows.Forms.Label();
            this.panel_power_0 = new System.Windows.Forms.TrackBar();
            this.panel_notecollectionname_0 = new System.Windows.Forms.Label();
            this.panel_choice_0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_power_0)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_0
            // 
            this.panel_0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_0.Controls.Add(this.label1);
            this.panel_0.Controls.Add(this.textBox1);
            this.panel_0.Controls.Add(this.panel_save_0);
            this.panel_0.Controls.Add(this.panel_diaoshi_0);
            this.panel_0.Controls.Add(this.panel_instrument_0);
            this.panel_0.Controls.Add(this.panel_time_right_0);
            this.panel_0.Controls.Add(this.panel_time_left_0);
            this.panel_0.Controls.Add(this.panel_time_0);
            this.panel_0.Controls.Add(this.panel_stop_0);
            this.panel_0.Controls.Add(this.panel_add_0);
            this.panel_0.Controls.Add(this.panel_start_0);
            this.panel_0.Controls.Add(this.panel_reset_0);
            this.panel_0.Controls.Add(this.panel_delete_0);
            this.panel_0.Controls.Add(this.panel_basenote_0);
            this.panel_0.Controls.Add(this.panel_label2_0);
            this.panel_0.Controls.Add(this.panel_speed_0);
            this.panel_0.Controls.Add(this.panel_label1_0);
            this.panel_0.Controls.Add(this.panel_power_show_0);
            this.panel_0.Controls.Add(this.panel_power_0);
            this.panel_0.Controls.Add(this.panel_notecollectionname_0);
            this.panel_0.Controls.Add(this.panel_choice_0);
            this.panel_0.Location = new System.Drawing.Point(160, 12);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(746, 305);
            this.panel_0.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "一小节几拍";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 22;
            // 
            // panel_save_0
            // 
            this.panel_save_0.Location = new System.Drawing.Point(41, 217);
            this.panel_save_0.Name = "panel_save_0";
            this.panel_save_0.Size = new System.Drawing.Size(75, 23);
            this.panel_save_0.TabIndex = 21;
            this.panel_save_0.Text = "储存设置";
            this.panel_save_0.UseVisualStyleBackColor = true;
            // 
            // panel_diaoshi_0
            // 
            this.panel_diaoshi_0.Items.Add("钢琴");
            this.panel_diaoshi_0.Items.Add("吉他");
            this.panel_diaoshi_0.Location = new System.Drawing.Point(301, 161);
            this.panel_diaoshi_0.Name = "panel_diaoshi_0";
            this.panel_diaoshi_0.Size = new System.Drawing.Size(120, 25);
            this.panel_diaoshi_0.TabIndex = 20;
            this.panel_diaoshi_0.TabStop = false;
            this.panel_diaoshi_0.Text = "调式";
            // 
            // panel_instrument_0
            // 
            this.panel_instrument_0.Items.Add("钢琴");
            this.panel_instrument_0.Items.Add("吉他");
            this.panel_instrument_0.Location = new System.Drawing.Point(437, 160);
            this.panel_instrument_0.Name = "panel_instrument_0";
            this.panel_instrument_0.Size = new System.Drawing.Size(120, 25);
            this.panel_instrument_0.TabIndex = 18;
            this.panel_instrument_0.TabStop = false;
            this.panel_instrument_0.Text = "乐器";
            // 
            // panel_time_right_0
            // 
            this.panel_time_right_0.AutoSize = true;
            this.panel_time_right_0.Location = new System.Drawing.Point(597, 231);
            this.panel_time_right_0.Name = "panel_time_right_0";
            this.panel_time_right_0.Size = new System.Drawing.Size(46, 15);
            this.panel_time_right_0.TabIndex = 17;
            this.panel_time_right_0.Text = "0：00";
            // 
            // panel_time_left_0
            // 
            this.panel_time_left_0.AutoSize = true;
            this.panel_time_left_0.Location = new System.Drawing.Point(172, 231);
            this.panel_time_left_0.Name = "panel_time_left_0";
            this.panel_time_left_0.Size = new System.Drawing.Size(46, 15);
            this.panel_time_left_0.TabIndex = 16;
            this.panel_time_left_0.Text = "0：00";
            // 
            // panel_time_0
            // 
            this.panel_time_0.Location = new System.Drawing.Point(221, 227);
            this.panel_time_0.Name = "panel_time_0";
            this.panel_time_0.Size = new System.Drawing.Size(373, 23);
            this.panel_time_0.TabIndex = 15;
            // 
            // panel_stop_0
            // 
            this.panel_stop_0.Location = new System.Drawing.Point(41, 111);
            this.panel_stop_0.Name = "panel_stop_0";
            this.panel_stop_0.Size = new System.Drawing.Size(75, 23);
            this.panel_stop_0.TabIndex = 14;
            this.panel_stop_0.TabStop = false;
            this.panel_stop_0.Text = "暂停播放";
            this.panel_stop_0.UseVisualStyleBackColor = true;
            // 
            // panel_add_0
            // 
            this.panel_add_0.Location = new System.Drawing.Point(617, 141);
            this.panel_add_0.Name = "panel_add_0";
            this.panel_add_0.Size = new System.Drawing.Size(105, 23);
            this.panel_add_0.TabIndex = 13;
            this.panel_add_0.TabStop = false;
            this.panel_add_0.Text = "增加声部";
            this.panel_add_0.UseVisualStyleBackColor = true;
            // 
            // panel_start_0
            // 
            this.panel_start_0.Location = new System.Drawing.Point(41, 58);
            this.panel_start_0.Name = "panel_start_0";
            this.panel_start_0.Size = new System.Drawing.Size(75, 23);
            this.panel_start_0.TabIndex = 11;
            this.panel_start_0.TabStop = false;
            this.panel_start_0.Text = "开始播放";
            this.panel_start_0.UseVisualStyleBackColor = true;
            // 
            // panel_reset_0
            // 
            this.panel_reset_0.Location = new System.Drawing.Point(41, 164);
            this.panel_reset_0.Name = "panel_reset_0";
            this.panel_reset_0.Size = new System.Drawing.Size(75, 23);
            this.panel_reset_0.TabIndex = 12;
            this.panel_reset_0.TabStop = false;
            this.panel_reset_0.Text = "重置播放进度";
            this.panel_reset_0.UseVisualStyleBackColor = true;
            // 
            // panel_delete_0
            // 
            this.panel_delete_0.Location = new System.Drawing.Point(617, 88);
            this.panel_delete_0.Name = "panel_delete_0";
            this.panel_delete_0.Size = new System.Drawing.Size(105, 23);
            this.panel_delete_0.TabIndex = 10;
            this.panel_delete_0.TabStop = false;
            this.panel_delete_0.Text = "删除此声部";
            this.panel_delete_0.UseVisualStyleBackColor = true;
            // 
            // panel_basenote_0
            // 
            this.panel_basenote_0.Location = new System.Drawing.Point(443, 111);
            this.panel_basenote_0.Name = "panel_basenote_0";
            this.panel_basenote_0.Size = new System.Drawing.Size(100, 25);
            this.panel_basenote_0.TabIndex = 7;
            this.panel_basenote_0.TabStop = false;
            // 
            // panel_label2_0
            // 
            this.panel_label2_0.AutoSize = true;
            this.panel_label2_0.Location = new System.Drawing.Point(329, 116);
            this.panel_label2_0.Name = "panel_label2_0";
            this.panel_label2_0.Size = new System.Drawing.Size(112, 15);
            this.panel_label2_0.TabIndex = 6;
            this.panel_label2_0.Text = "一拍是几分音符";
            // 
            // panel_speed_0
            // 
            this.panel_speed_0.Location = new System.Drawing.Point(443, 31);
            this.panel_speed_0.Name = "panel_speed_0";
            this.panel_speed_0.Size = new System.Drawing.Size(100, 25);
            this.panel_speed_0.TabIndex = 5;
            this.panel_speed_0.TabStop = false;
            // 
            // panel_label1_0
            // 
            this.panel_label1_0.AutoSize = true;
            this.panel_label1_0.Location = new System.Drawing.Point(358, 35);
            this.panel_label1_0.Name = "panel_label1_0";
            this.panel_label1_0.Size = new System.Drawing.Size(82, 15);
            this.panel_label1_0.TabIndex = 4;
            this.panel_label1_0.Text = "一分钟几拍";
            // 
            // panel_power_show_0
            // 
            this.panel_power_show_0.AutoSize = true;
            this.panel_power_show_0.Location = new System.Drawing.Point(218, 149);
            this.panel_power_show_0.Name = "panel_power_show_0";
            this.panel_power_show_0.Size = new System.Drawing.Size(37, 15);
            this.panel_power_show_0.TabIndex = 3;
            this.panel_power_show_0.Text = "音量";
            // 
            // panel_power_0
            // 
            this.panel_power_0.Location = new System.Drawing.Point(182, 120);
            this.panel_power_0.Maximum = 100;
            this.panel_power_0.Name = "panel_power_0";
            this.panel_power_0.Size = new System.Drawing.Size(104, 56);
            this.panel_power_0.TabIndex = 2;
            this.panel_power_0.TabStop = false;
            this.panel_power_0.TickFrequency = 10;
            // 
            // panel_notecollectionname_0
            // 
            this.panel_notecollectionname_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_notecollectionname_0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_notecollectionname_0.Location = new System.Drawing.Point(207, 79);
            this.panel_notecollectionname_0.Name = "panel_notecollectionname_0";
            this.panel_notecollectionname_0.Size = new System.Drawing.Size(52, 15);
            this.panel_notecollectionname_0.TabIndex = 1;
            this.panel_notecollectionname_0.Text = "谱子名";
            this.panel_notecollectionname_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_choice_0
            // 
            this.panel_choice_0.Location = new System.Drawing.Point(195, 53);
            this.panel_choice_0.Name = "panel_choice_0";
            this.panel_choice_0.Size = new System.Drawing.Size(75, 23);
            this.panel_choice_0.TabIndex = 0;
            this.panel_choice_0.TabStop = false;
            this.panel_choice_0.Text = "选择谱子";
            this.panel_choice_0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "全部播放";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "全部暂停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "全部重置播放";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "增加声部";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.panel_add);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "删除最底声部";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.panel_delete_last);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "全部储存";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(98, 444);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(942, 588);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_0);
            this.MaximumSize = new System.Drawing.Size(960, 3000);
            this.MinimumSize = new System.Drawing.Size(960, 382);
            this.Name = "Form1";
            this.Text = "World.Voice.execute();";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel_0.ResumeLayout(false);
            this.panel_0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_power_0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_0;
        public System.Windows.Forms.DomainUpDown panel_diaoshi_0;
        public System.Windows.Forms.DomainUpDown panel_instrument_0;
        public System.Windows.Forms.Label panel_time_right_0;
        public System.Windows.Forms.Label panel_time_left_0;
        public System.Windows.Forms.ProgressBar panel_time_0;
        public System.Windows.Forms.Button panel_stop_0;
        public System.Windows.Forms.Button panel_add_0;
        public System.Windows.Forms.Button panel_start_0;
        public System.Windows.Forms.Button panel_reset_0;
        public System.Windows.Forms.Button panel_delete_0;
        public System.Windows.Forms.TextBox panel_basenote_0;
        public System.Windows.Forms.Label panel_label2_0;
        public System.Windows.Forms.TextBox panel_speed_0;
        public System.Windows.Forms.Label panel_label1_0;
        public System.Windows.Forms.Label panel_power_show_0;
        public System.Windows.Forms.TrackBar panel_power_0;
        public System.Windows.Forms.Label panel_notecollectionname_0;
        public System.Windows.Forms.Button panel_choice_0;
        public System.Windows.Forms.Button panel_save_0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}

