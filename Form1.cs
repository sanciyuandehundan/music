﻿using System;
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
using System.Reflection;

namespace musical
{

    public partial class Form1 : Form
    {
        public Midi midi = new Midi();
        public int panel_number = 0;
        public int base_controls;
        public bool[] indexs = new bool[16];
        public Panel1[] panels=new Panel1[16];
        public Form1()
        {
            indexs[10] = true;
            InitializeComponent();
        }

        public void Panel_add(object sender, EventArgs e)
        {
            for(int i = 0; i < 16; i++)
            {
                if (!indexs[i])
                {
                    panels[i] = new Panel1();
                    this.Controls.Add(panels[i].panel_0);
                    panel_number++;
                    panels[i].panel_0.Location = new Point(Program.form.panel_0.Location.X, Program.form.panel_0.Location.Y + Program.form.panel_0.Height * panel_number);
                    panels[i].index = i;
                    indexs[i] = true;
                    break;
                }
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Midi.Music_play_all();
        }//全部播放

        private void Button2_Click(object sender, EventArgs e)
        {
            Midi.Music_pause_all();
        }//全部暂停

        private void Button3_Click(object sender, EventArgs e)
        {
            Midi.Music_close_all();
            Midi.Music_open_all();
        }//全部重置

        private void Button6_Click(object sender, EventArgs e)
        {
            Midi.Music_close_all();
            string[] strings=new string[panel_number];
            int index = 0;
            for(int i = 0; i < 16; i++)
            {
                if (indexs[i]&i!=10)
                {
                    panels[i].yingui.Yingui_close();
                    strings[index] = panels[i].yingui.local_2;
                    index++;
                }
            }
            Midi.Music_parse_hebin(strings, 480);
            Midi.Music_open_all();
        }//全部储存

        private void button7_Click(object sender, EventArgs e)
        {
            /*Midi.Yingui yingui1 = new Midi.Yingui(File.ReadAllText("C:\\Users\\a0905\\Desktop\\我不曾忘记0.txt"), 0, 0, 80, 4, 4, 0x5f, 0, 3);//跟据
            Console.WriteLine("k");
            yingui1.Yingui_open();
            yingui1.Yingui_play();
            Thread.Sleep(1000);
            yingui1.Yingui_pause();
            Thread.Sleep(1000);
            yingui1.Yingui_resume();
            Thread.Sleep(10000);
            yingui1.Yingui_close();
            //yingui1.Yingui_close();
            //Midi.Music_parse_hebin(2, yingui1.xiaojie_note_long);
            Console.WriteLine("k");*/
        }
    }

    public partial class Panel1 : Control
    {
        public Midi.Yingui yingui;
        public int tempo_minute;
        public int index;
        public int note_base;
        public int instrument;
        public string sheet;
        public int power;
        public bool stop_bool;
        public int xiaojie_num;

        public Thread music_play_thread;
        public int control_index;
        public Panel panel_0 = new System.Windows.Forms.Panel();
        public DomainUpDown panel_diaoshi_0 = new System.Windows.Forms.DomainUpDown();
        public DomainUpDown panel_instrument_0 = new System.Windows.Forms.DomainUpDown();
        public Label panel_time_right_0 = new System.Windows.Forms.Label();
        public Label panel_time_left_0 = new System.Windows.Forms.Label();
        public ProgressBar panel_time_0 = new System.Windows.Forms.ProgressBar();
        public Button panel_stop_0 = new System.Windows.Forms.Button();
        public Button panel_add_0 = new System.Windows.Forms.Button();
        public Button panel_start_0 = new System.Windows.Forms.Button();
        public Button panel_reset_0 = new System.Windows.Forms.Button();
        public Button panel_delete_0 = new System.Windows.Forms.Button();
        public TextBox panel_basenote_0 = new System.Windows.Forms.TextBox();
        public Label panel_label2_0 = new System.Windows.Forms.Label();
        public TextBox panel_speed_0 = new System.Windows.Forms.TextBox();
        public Label panel_label1_0 = new System.Windows.Forms.Label();
        public Label panel_power_show_0 = new System.Windows.Forms.Label();
        public TrackBar panel_power_0 = new System.Windows.Forms.TrackBar();
        public Label panel_notecollectionname_0 = new System.Windows.Forms.Label();
        public Button panel_choice_0 = new System.Windows.Forms.Button();
        public Button panel_save_0 = new System.Windows.Forms.Button();
        public System.Windows.Forms.Timer panel_timer = new System.Windows.Forms.Timer();
        public System.Windows.Forms.Label label1 = new Label();
        public System.Windows.Forms.TextBox xiaojie = new TextBox();
        public DomainUpDown panel_diaoshi_1 = new DomainUpDown();

        /// <summary>
        /// 建构函数
        /// </summary>
        public Panel1()
        {
            panel_time_0.Visible = false;
            panel_time_0.Enabled = false;
            panel_time_left_0.Visible=false;
            panel_time_left_0.Enabled=false;
            panel_time_right_0.Visible=false;
            panel_time_right_0.Enabled=false;
            panel_timer.Enabled=false;
            panel_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panel_power_0)).BeginInit();
            // 
            // textBox1
            // 
            xiaojie.Location = new System.Drawing.Point(((Size)Program.form.textBox1.Location));
            xiaojie.Name = "xiaojie";
            xiaojie.Size = new System.Drawing.Size(((Point)Program.form.textBox1.Size));
            xiaojie.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(((Size)Program.form.label1.Location));
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(((Point)Program.form.label1.Size));
            label1.TabIndex = 23;
            label1.Text = "一小节几拍";
            // 
            // timer1
            // 
            panel_timer.Interval = 1000;
            panel_timer.Tick += new EventHandler(panel_time_start);
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
            panel_0.Controls.Add(xiaojie);
            panel_0.Controls.Add(label1);
            panel_0.Controls.Add(panel_diaoshi_1);
            panel_0.Location = new System.Drawing.Point(Program.form.panel_0.Location.X, Program.form.panel_0.Location.Y);
            panel_0.Name = "panel_0";
            panel_0.Size = new System.Drawing.Size(((Point)Program.form.panel_0.Size));
            panel_0.TabIndex = 1;
            control_index = Program.form.Controls.IndexOf(panel_0);
            // 
            // panel_diaoshi_0
            // 
            panel_diaoshi_0.Items.InsertRange(0, Program.form.panel_diaoshi_0.Items);
            panel_diaoshi_0.Location = new System.Drawing.Point(((Size)Program.form.panel_diaoshi_0.Location));
            panel_diaoshi_0.Name = "panel_diaoshi_0";
            panel_diaoshi_0.Size = new System.Drawing.Size(((Point)Program.form.panel_diaoshi_0.Size));
            panel_diaoshi_0.TabIndex = 20;
            panel_diaoshi_0.TabStop = false;
            panel_diaoshi_0.Text = Program.form.panel_diaoshi_0.Text;
            panel_diaoshi_0.Wrap = true;
            panel_diaoshi_0.ReadOnly = true;
            // 
            // panel_diaoshi_1
            // 
            panel_diaoshi_1.Items.InsertRange(0, Program.form.panel_diaoshi_1.Items);
            panel_diaoshi_1.Location = new System.Drawing.Point(((Size)Program.form.panel_diaoshi_1.Location));
            panel_diaoshi_1.Name = "panel_diaoshi_1";
            panel_diaoshi_1.Size = new System.Drawing.Size(((Point)Program.form.panel_diaoshi_1.Size));
            panel_diaoshi_1.TabIndex = 20;
            panel_diaoshi_1.TabStop = false;
            panel_diaoshi_1.Text = Program.form.panel_diaoshi_1.Text;
            panel_diaoshi_1.Wrap = true;
            panel_diaoshi_1.ReadOnly = true;
            panel_diaoshi_1.SelectedIndex = 7;
            // 
            // panel_instrument_0
            // 
            panel_instrument_0.Items.InsertRange(0, Program.form.panel_instrument_0.Items);
            panel_instrument_0.Location = new System.Drawing.Point(((Size)Program.form.panel_instrument_0.Location));
            panel_instrument_0.Name = "panel_instrument_0";
            panel_instrument_0.Size = new System.Drawing.Size(((Point)Program.form.panel_instrument_0.Size));
            panel_instrument_0.TabIndex = 18;
            panel_instrument_0.TabStop = false;
            panel_instrument_0.Text = "乐器";
            panel_instrument_0.ReadOnly = true;
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
            panel_time_0.Step = 1;
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
            panel_stop_0.Click += new EventHandler(panel_stop);
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
            panel_add_0.Click += new EventHandler(Program.form.Panel_add);

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
            panel_reset_0.Click += new EventHandler(panel_reset);
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
            panel_power_0.Value = 50;
            panel_power_0.Scroll += new EventHandler(panel_power);
            // 
            // panel_notecollectionname_0
            // 
            panel_notecollectionname_0.AutoSize = true;
            panel_notecollectionname_0.Location = new System.Drawing.Point(((Size)Program.form.panel_notecollectionname_0.Location));
            panel_notecollectionname_0.Name = "panel_notecollectionname_0";
            panel_notecollectionname_0.Size = new System.Drawing.Size(((Point)Program.form.panel_notecollectionname_0.Size));
            panel_notecollectionname_0.TabIndex = 1;
            panel_notecollectionname_0.Text = "谱子名";
            panel_notecollectionname_0.BackColor = Program.form.panel_notecollectionname_0.BackColor;
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
        ~Panel1()
        {
            //yingui.Yingui_close();
        }

        /// <summary>
        /// 删除该声部
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_delete_Click(object sender, EventArgs e)
        {
            Program.form.panel_number--;
            control_index = Program.form.Controls.IndexOf(panel_0);
            Program.form.Controls.Remove(this.panel_0);
            for (int i = control_index; i < Program.form.Controls.Count; i++)
            {
                Program.form.Controls[i].Location = new Point(Program.form.Controls[i].Location.X, Program.form.Controls[i].Location.Y - Program.form.Controls[i].Height);
            }//将底下的全部往上提一个，填补此panel删除后的空格
            Program.form.indexs[index] = false;
            Program.form.panels[index] = null;
            this.Dispose();
        }

        /// <summary>
        /// 开始播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_start_Click(object sender, EventArgs e)
        {
            yingui.Yingui_play();
        }

        /// <summary>
        /// 设定乐谱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_save_music(object sender, EventArgs e)
        {
            if (sheet != "" & panel_speed_0.Text != "" & panel_basenote_0.Text != "" & xiaojie.Text != "")
            {
                yingui = new Midi.Yingui(sheet, index, panel_instrument_0.SelectedIndex, int.Parse(panel_speed_0.Text), int.Parse(panel_basenote_0.Text), int.Parse(xiaojie.Text), panel_power_0.Value, 0 - panel_diaoshi_0.SelectedIndex * 20, panel_diaoshi_1.SelectedIndex - 7);
                yingui.Yingui_open();
                //this.panel_time_0.Maximum = (int)((float)(yingui.time) / (float)(57600.0f / 60000.0f));
                //this.panel_time_0.Step = 1000;
                //this.panel_timer.Interval = 1000;
            }
            //Console.WriteLine("UpDown" + (panel_diaoshi_1.SelectedIndex - 7));
            //Console.WriteLine("diaohsi" + (0 - panel_diaoshi_0.SelectedIndex * 20));
        }

        /// <summary>
        /// 加载乐谱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_load(object sender, EventArgs e)
        {
            if (Program.form.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sheet = File.ReadAllText(Program.form.openFileDialog1.FileName);
                int x = panel_notecollectionname_0.Location.X;
                int w = panel_notecollectionname_0.Width;
                //x = x + w / 2;//中心
                panel_notecollectionname_0.Text = Path.GetFileName(Program.form.openFileDialog1.FileName);
                panel_notecollectionname_0.Location = new Point(x + ((w - panel_notecollectionname_0.Width) / 2), panel_notecollectionname_0.Location.Y);
            }
        }

        /// <summary>
        /// 停止执行绪
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_stop(object sender, EventArgs e) => yingui?.Yingui_pause();

        /// <summary>
        /// 音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_power(object sender, EventArgs e)
        {
            power = panel_power_0.Value;
        }

        /// <summary>
        /// 进度条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_time_start(object sender, EventArgs e)
        {
            /*try
            {
                panel_time_0.PerformStep();
                panel_time_left_0.Text =panel_time_0.Value.ToString();
            }
            catch
            {
                panel_timer.Stop();
            }*/
        }

        /// <summary>
        /// 重置播放进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_reset(object sender, EventArgs e)
        {
            yingui?.Yingui_close();
            yingui?.Yingui_open();
        }
    }
}
