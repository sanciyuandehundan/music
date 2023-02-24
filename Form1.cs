using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using sanciyuandehundan_API;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace musical
{
    public partial class Form1 : Form
    {
        public Midi midi = new Midi();
        public int panel_number = 0;
        public int base_controls;
        public Form1()
        {
            InitializeComponent();
        }

        public void panel_add(object sender, EventArgs e)
        {
            Panel1 panel1 = new Panel1();
            this.Controls.Add(panel1.panel_0);
            panel_number++;
            //Debug.Print(Program.form.Controls.IndexOf(panel1.panel_0).ToString());
            panel1.panel_0.Location = new Point(panel_0.Location.X, panel_0.Location.Y+panel_0.Height*panel_number);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }//预定，关闭窗口时停止所有音乐

        private void Form1_Shown(object sender, EventArgs e)
        {
            Program.form.panel_0.Visible = false;
            Program.form.panel_0.Location = new Point(panel_0.Location.X, panel_0.Location.Y - panel_0.Height);
            Program.form.panel_0.Enabled = false;
        }

        private void panel_delete_last(object sender, EventArgs e)
        {
            if(panel_number != 0)
            {
                panel_number-=1;
                Thread.Sleep(100);
                Controls[Controls.Count - 1].Dispose();
            }
        }

    }

    public partial class Panel1:Control
    {
        public int tempo_minute;
        public int index;
        public int note_base;
        public int instrument;
        public int[,] sheet;

        Thread music_play_thread;
        public int control_index;
        public Panel panel_0 = new System.Windows.Forms.Panel();
        DomainUpDown panel_diaoshi_0 = new System.Windows.Forms.DomainUpDown();
        DomainUpDown panel_instrument_0 = new System.Windows.Forms.DomainUpDown();
        Label panel_time_right_0 = new System.Windows.Forms.Label();
        Label panel_time_left_0 = new System.Windows.Forms.Label();
        ProgressBar panel_time_0 = new System.Windows.Forms.ProgressBar();
        Button panel_stop_0 = new System.Windows.Forms.Button();
        Button panel_add_0 = new System.Windows.Forms.Button();
        Button panel_start_0 = new System.Windows.Forms.Button();
        Button panel_reset_0 = new System.Windows.Forms.Button();
        Button panel_delete_0 = new System.Windows.Forms.Button();
        TextBox panel_basenote_0 = new System.Windows.Forms.TextBox();
        Label panel_label2_0 = new System.Windows.Forms.Label();
        TextBox panel_speed_0 = new System.Windows.Forms.TextBox();
        Label panel_label1_0 = new System.Windows.Forms.Label();
        Label panel_power_show_0 = new System.Windows.Forms.Label();
        TrackBar panel_power_0 = new System.Windows.Forms.TrackBar();
        Label panel_notecollectionname_0 = new System.Windows.Forms.Label();
        Button panel_choice_0 = new System.Windows.Forms.Button();
        Button panel_save_0 = new System.Windows.Forms.Button();

        /// <summary>
        /// 建构函数
        /// </summary>
        public Panel1()
        {
            panel_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panel_power_0)).BeginInit();
            // 
            // panel_save_0
            // 
            panel_save_0.Location = new System.Drawing.Point(((Size)Program.form.panel_save_0.Location));
            panel_save_0.Name = "panel_save_0";
            panel_save_0.Size = new System.Drawing.Size(((Point)Program.form.panel_save_0.Size));
            panel_save_0.TabIndex = 21;
            panel_save_0.Text = "储存设置";
            panel_save_0.UseVisualStyleBackColor = true;
            panel_save_0.Click += new EventHandler(panel_save_music);
            // 
            // panel_0
            // 
            panel_0.BackColor = Program.form.panel_0.BackColor;
            panel_0.BorderStyle = Program.form.panel_0.BorderStyle;
            panel_0.Controls.Add(panel_diaoshi_0);
            panel_0.Controls.Add(panel_instrument_0);
            panel_0.Controls.Add(panel_time_right_0);
            panel_0.Controls.Add(panel_time_left_0);
            panel_0.Controls.Add(panel_time_0);
            panel_0.Controls.Add(panel_stop_0);
            panel_0.Controls.Add(panel_add_0);
            panel_0.Controls.Add(panel_start_0);
            panel_0.Controls.Add(panel_reset_0);
            panel_0.Controls.Add(panel_delete_0);
            panel_0.Controls.Add(panel_basenote_0);
            panel_0.Controls.Add(panel_label2_0);
            panel_0.Controls.Add(panel_speed_0);
            panel_0.Controls.Add(panel_label1_0);
            panel_0.Controls.Add(panel_power_show_0);
            panel_0.Controls.Add(panel_power_0);
            panel_0.Controls.Add(panel_notecollectionname_0);
            panel_0.Controls.Add(panel_choice_0);
            panel_0.Controls.Add(panel_save_0);
            panel_0.Location = new System.Drawing.Point(Program.form.panel_0.Location.X, Program.form.panel_0.Location.Y);
            panel_0.Name = "panel_0";
            panel_0.Size = new System.Drawing.Size(((Point)Program.form.panel_0.Size));
            panel_0.TabIndex = 1;
            control_index = Program.form.Controls.IndexOf(panel_0);
            // 
            // panel_diaoshi_0
            // 
            panel_diaoshi_0.Items.Add("钢琴");
            panel_diaoshi_0.Items.Add("吉他");
            panel_diaoshi_0.Location = new System.Drawing.Point(((Size)Program.form.panel_diaoshi_0.Location));
            panel_diaoshi_0.Name = "panel_diaoshi_0";
            panel_diaoshi_0.Size = new System.Drawing.Size(((Point)Program.form.panel_diaoshi_0.Size));
            panel_diaoshi_0.TabIndex = 20;
            panel_diaoshi_0.TabStop = false;
            panel_diaoshi_0.Text = "调式";
            // 
            // panel_instrument_0
            // 
            panel_instrument_0.Items.Add("钢琴");
            panel_instrument_0.Items.Add("吉他");
            panel_instrument_0.Location = new System.Drawing.Point(((Size)Program.form.panel_instrument_0.Location));
            panel_instrument_0.Name = "panel_instrument_0";
            panel_instrument_0.Size = new System.Drawing.Size(((Point)Program.form.panel_instrument_0.Size));
            panel_instrument_0.TabIndex = 18;
            panel_instrument_0.TabStop = false;
            panel_instrument_0.Text = "乐器";
            // 
            // panel_time_right_0
            // 
            panel_time_right_0.AutoSize = true;
            panel_time_right_0.Location = new System.Drawing.Point(((Size)Program.form.panel_time_right_0.Location));
            panel_time_right_0.Name = "panel_time_right_0";
            panel_time_right_0.Size = new System.Drawing.Size(((Point)Program.form.panel_time_right_0.Size));
            panel_time_right_0.TabIndex = 17;
            panel_time_right_0.Text = "0：00";
            // 
            // panel_time_left_0
            // 
            panel_time_left_0.AutoSize = true;
            panel_time_left_0.Location = new System.Drawing.Point(((Size)Program.form.panel_time_left_0.Location));
            panel_time_left_0.Name = "panel_time_left_0";
            panel_time_left_0.Size = new System.Drawing.Size(((Point)Program.form.panel_time_left_0.Size));
            panel_time_left_0.TabIndex = 16;
            panel_time_left_0.Text = "0：00";
            // 
            // panel_time_0
            // 
            panel_time_0.Location = new System.Drawing.Point(((Size)Program.form.panel_time_0.Location));
            panel_time_0.Name = "panel_time_0";
            panel_time_0.Size = new System.Drawing.Size(((Point)Program.form.panel_time_0.Size));
            panel_time_0.TabIndex = 15;
            // 
            // panel_stop_0
            // 
            panel_stop_0.Location = new System.Drawing.Point(((Size)Program.form.panel_stop_0.Location));
            panel_stop_0.Name = "panel_stop_0";
            panel_stop_0.Size = new System.Drawing.Size(((Point)Program.form.panel_stop_0.Size));
            panel_stop_0.TabIndex = 14;
            panel_stop_0.TabStop = false;
            panel_stop_0.Text = "暂停播放";
            panel_stop_0.UseVisualStyleBackColor = true;
            // 
            // panel_add_0
            // 
            panel_add_0.Location = new System.Drawing.Point(((Size)Program.form.panel_add_0.Location));
            panel_add_0.Name = "panel_add_0";
            panel_add_0.Size = new System.Drawing.Size(((Point)Program.form.panel_add_0.Size));
            panel_add_0.TabIndex = 13;
            panel_add_0.TabStop = false;
            panel_add_0.Text = "增加声部";
            panel_add_0.UseVisualStyleBackColor = true;
            panel_add_0.Click += new EventHandler(Program.form.panel_add);
            
            // 
            // panel_start_0
            // 
            panel_start_0.Location = new System.Drawing.Point(((Size)Program.form.panel_start_0.Location));
            panel_start_0.Name = "panel_start_0";
            panel_start_0.Size = new System.Drawing.Size(((Point)Program.form.panel_start_0.Size));
            panel_start_0.TabIndex = 11;
            panel_start_0.TabStop = false;
            panel_start_0.Text = "开始播放";
            panel_start_0.UseVisualStyleBackColor = true;
            panel_start_0.Click += new EventHandler(panel_start_Click);
            // 
            // panel_reset_0
            // 
            panel_reset_0.Location = new System.Drawing.Point(((Size)Program.form.panel_reset_0.Location));
            panel_reset_0.Name = "panel_reset_0";
            panel_reset_0.Size = new System.Drawing.Size(((Point)Program.form.panel_reset_0.Size));
            panel_reset_0.TabIndex = 12;
            panel_reset_0.TabStop = false;
            panel_reset_0.Text = "重置播放进度";
            panel_reset_0.UseVisualStyleBackColor = true;
            // 
            // panel_delete_0
            // 
            panel_delete_0.Location = new System.Drawing.Point(((Size)Program.form.panel_delete_0.Location));
            panel_delete_0.Name = "panel_delete_0";
            panel_delete_0.Size = new System.Drawing.Size(((Point)Program.form.panel_delete_0.Size));
            panel_delete_0.TabIndex = 10;
            panel_delete_0.TabStop = false;
            panel_delete_0.Text = "删除此声部";
            panel_delete_0.UseVisualStyleBackColor = true;
            panel_delete_0.Click += new EventHandler(panel_delete_Click);
            // 
            // panel_basenote_0
            // 
            panel_basenote_0.Location = new System.Drawing.Point(((Size)Program.form.panel_basenote_0.Location));
            panel_basenote_0.Name = "panel_basenote_0";
            panel_basenote_0.Size = new System.Drawing.Size(((Point)Program.form.panel_basenote_0.Size));
            panel_basenote_0.TabIndex = 7;
            panel_basenote_0.TabStop = false;
            // 
            // panel_label2_0
            // 
            panel_label2_0.AutoSize = true;
            panel_label2_0.Location = new System.Drawing.Point(((Size)Program.form.panel_label2_0.Location));
            panel_label2_0.Name = "panel_label2_0";
            panel_label2_0.Size = new System.Drawing.Size(((Point)Program.form.panel_label2_0.Size));
            panel_label2_0.TabIndex = 6;
            panel_label2_0.Text = "一拍是几分音符";
            // 
            // panel_speed_0
            // 
            panel_speed_0.Location = new System.Drawing.Point(((Size)Program.form.panel_speed_0.Location));
            panel_speed_0.Name = "panel_speed_0";
            panel_speed_0.Size = new System.Drawing.Size(((Point)Program.form.panel_speed_0.Size));
            panel_speed_0.TabIndex = 5;
            panel_speed_0.TabStop = false;
            // 
            // panel_label1_0
            // 
            panel_label1_0.AutoSize = true;
            panel_label1_0.Location = new System.Drawing.Point(((Size)Program.form.panel_label1_0.Location));
            panel_label1_0.Name = "panel_label1_0";
            panel_label1_0.Size = new System.Drawing.Size(((Point)Program.form.panel_label1_0.Size));
            panel_label1_0.TabIndex = 4;
            panel_label1_0.Text = "一分钟几拍";
            // 
            // panel_power_show_0
            // 
            panel_power_show_0.AutoSize = true;
            panel_power_show_0.Location = new System.Drawing.Point(((Size)Program.form.panel_power_show_0.Location));
            panel_power_show_0.Name = "panel_power_show_0";
            panel_power_show_0.Size = new System.Drawing.Size(((Point)Program.form.panel_power_show_0.Size));
            panel_power_show_0.TabIndex = 3;
            panel_power_show_0.Text = "音量";
            // 
            // panel_power_0
            // 
            panel_power_0.Location = new System.Drawing.Point(((Size)Program.form.panel_power_0.Location));
            panel_power_0.Maximum = 100;
            panel_power_0.Name = "panel_power_0";
            panel_power_0.Size = new System.Drawing.Size(((Point)Program.form.panel_power_0.Size));
            panel_power_0.TabIndex = 2;
            panel_power_0.TabStop = false;
            panel_power_0.TickFrequency = 10;
            // 
            // panel_notecollectionname_0
            // 
            panel_notecollectionname_0.AutoSize = true;
            panel_notecollectionname_0.Location = new System.Drawing.Point(((Size)Program.form.panel_notecollectionname_0.Location));
            panel_notecollectionname_0.Name = "panel_notecollectionname_0";
            panel_notecollectionname_0.Size = new System.Drawing.Size(((Point)Program.form.panel_notecollectionname_0.Size));
            panel_notecollectionname_0.TabIndex = 1;
            panel_notecollectionname_0.Text = "谱子名";
            // 
            // panel_choice_0
            // 
            panel_choice_0.Location = new System.Drawing.Point(((Size)Program.form.panel_choice_0.Location));
            panel_choice_0.Name = "panel_choice_0";
            panel_choice_0.Size = new System.Drawing.Size(((Point)Program.form.panel_choice_0.Size));
            panel_choice_0.TabIndex = 0;
            panel_choice_0.TabStop = false;
            panel_choice_0.Text = "选择谱子";
            panel_choice_0.UseVisualStyleBackColor = true;
            panel_choice_0.Click += new EventHandler(panel_load);
        }

        private void Panel_save_0_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel_delete_Click(object sender, EventArgs e)
        {
            Program.form.panel_number--;
            control_index = Program.form.Controls.IndexOf(panel_0);
            Program.form.Controls.Remove(this.panel_0);
            for(int i = control_index; i < Program.form.Controls.Count; i++)
            {
                Program.form.Controls[i].Location = new Point(Program.form.Controls[i].Location.X, Program.form.Controls[i].Location.Y- Program.form.Controls[i].Height);
            }//将底下的全部往上提一个，填补此panel删除后的空格
            this.Dispose();
        }
        public void panel_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (!music_play_thread.IsAlive)
                    music_play_thread.Start();
            }
            catch
            {
                MessageBox.Show("未储存乐谱设置");
            }

        }

        /// <summary>
        /// 用于执行绪，播放音乐
        /// </summary>
        public void Musicplay()
        {
            Program.form.midi.Music_Play(Program.form.midi, 100, 40, int.Parse(panel_speed_0.Text), 4, int.Parse(panel_basenote_0.Text), sheet); 
        }
        public void panel_save_music(object sender, EventArgs e)
        {
            music_play_thread = new Thread(new ThreadStart(Musicplay));
        }
        public void panel_load(object sender, EventArgs e)
        {
            if(Program.form.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.form.midi.Music_parse(File.ReadAllText(Program.form.openFileDialog1.FileName));
                //Console.WriteLine(Program.form.openFileDialog1.FileName);
            }
        }
    }
}
