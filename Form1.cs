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
using System.Reflection;

namespace musical
{
    public partial class Form1 : Form
    {
        public Midi midi = new Midi();
        public int panel_number = 0;
        public int base_controls;
        public Panel1[] shengbu=new Panel1[16];
        public Form1()
        {
            InitializeComponent();
        }

        public void panel_add(object sender, EventArgs e)
        {
            Panel1 panel1 = new Panel1();
            this.Controls.Add(panel1.panel_0);
            panel1.index = panel_number;
            panel_number++;
            shengbu[panel1.index] = panel1;
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
        }//删除最底下的声部

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < panel_number; i++)
            {
                if (shengbu[i].music_play_thread != null)
                {
                    if (!shengbu[i].music_play_thread.IsAlive)
                    {
                        shengbu[i].music_play_thread.Start();
                        shengbu[i].panel_timer.Start();
                    }
                    if (shengbu[i].stop_bool)
                    {
                       shengbu[i].music_play_thread.Resume();
                        shengbu[i]. panel_timer.Start();
                    }
                }
            }
        }//全部播放

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panel_number; i++)
            {
                if (shengbu[i].music_play_thread.IsAlive)
                {
                    shengbu[i].music_play_thread.Suspend();
                    shengbu[i].panel_timer.Stop();
                    shengbu[i].stop_bool = true;
                }
            }
        
        }//全部暂停

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < panel_number; i++)
            {
                if (shengbu[i].stop_bool)
                { 
                shengbu[i].music_play_thread = new Thread(new ThreadStart(shengbu[i].Musicplay));
                shengbu[i].panel_time_0.Value = 0;
                shengbu[i].panel_time_left_0.Text = "0:00";
                shengbu[i].stop_bool = false;
                }
            }
        }//全部重置

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i=0; i < panel_number; i++)
            {
                if (shengbu[i].sheet != null & shengbu[i].panel_speed_0.Text != null & shengbu[i].panel_basenote_0.Text != null & shengbu[i].xiaojie.Text!=null)
                {
                    Program.form.midi.Music_speed(int.Parse(shengbu[i].panel_speed_0.Text), shengbu[i].index);
                    Program.form.midi.Music_power(shengbu[i].panel_power_0.Value, shengbu[i].sheet, shengbu[i].index);
                    Program.form.midi.Music_note_base(int.Parse(shengbu[i].panel_basenote_0.Text), int.Parse(shengbu[i].xiaojie.Text), shengbu[i].index);
                    Program.form.midi.Music_parse(shengbu[i].sheet, shengbu[i].index, 4);
                    Program.form.midi.Music_instrument(shengbu[i].instrument, shengbu[i].index);
                    shengbu[i].music_play_thread = new Thread(new ThreadStart(shengbu[i].Musicplay));
                    int t = Program.form.midi.time[shengbu[i].index] / 1000;
                    shengbu[i].panel_time_right_0.Text = (t / 60).ToString() + ":" + (t % 60).ToString();
                    shengbu[i].panel_time_0.Maximum = t;
                    shengbu[i].panel_time_0.Step = 1;
                }
                else
                {
                    MessageBox.Show("条件未设置完全");
                }
            }
        }//全部储存
    }

    public partial class Panel1:Control
    {
        public int tempo_minute;
        public int index;
        public int note_base;
        public int instrument;
        public string sheet;
        public int power;
        public bool stop_bool;

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
        public System.Windows.Forms.Label label1=new Label();
        public System.Windows.Forms.TextBox xiaojie=new TextBox();

        /// <summary>
        /// 建构函数
        /// </summary>
        public Panel1()
        {
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
            label1.Location = new System.Drawing.Point(((Size)Program.form.label1 .Location));
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
            for(int i = control_index; i < Program.form.Controls.Count; i++)
            {
                Program.form.Controls[i].Location = new Point(Program.form.Controls[i].Location.X, Program.form.Controls[i].Location.Y- Program.form.Controls[i].Height);
            }//将底下的全部往上提一个，填补此panel删除后的空格
            this.Dispose();
        }

        /// <summary>
        /// 开始播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_start_Click(object sender, EventArgs e)
        {
            if (music_play_thread != null)
            {
                if (!music_play_thread.IsAlive & stop_bool == false)
                {
                    music_play_thread.Start();
                    panel_timer.Start();
                }
                if (stop_bool)
                {
                    music_play_thread.Resume();
                    panel_timer.Start();
                }

                Console.WriteLine(panel_time_0.Maximum);
                //Console.WriteLine(panel_time_0.);
            }

        }

        /// <summary>
        /// 用于执行绪，播放音乐
        /// </summary>
        public void Musicplay()
        {
            Program.form.midi.Music_play(Program.form.midi.music[index],index);
        }//力度的随机还没做，为模仿人类

        /// <summary>
        /// 设定乐谱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_save_music(object sender, EventArgs e)
        {
            if ( sheet!= null & panel_speed_0.Text != null & panel_basenote_0.Text != null & xiaojie.Text != null)
            {

                Program.form.midi.Music_speed(int.Parse(panel_speed_0.Text), index);
                Program.form.midi.Music_power(power,sheet, index);
                Program.form.midi.Music_note_base(int.Parse(panel_basenote_0.Text),int.Parse(xiaojie.Text), index);
                Program.form.midi.Music_parse(sheet, index, 4);
                Program.form.midi.Music_instrument(instrument, index);
                music_play_thread = new Thread(new ThreadStart(Musicplay));
                int t = Program.form.midi.time[index] / 1000;
                panel_time_right_0.Text = (t / 60).ToString() + ":" + (t % 60).ToString();
                panel_time_0.Maximum = t;//250,用25000毫秒跑完，100毫秒跑一次
                panel_time_0.Step = 1;
            }
            else
            {
                MessageBox.Show("条件未设置完全");
            }
        }//调式和乐器还未弄

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
                int x=panel_notecollectionname_0.Location.X;
                int w = panel_notecollectionname_0.Width;
                //x = x + w / 2;//中心
                panel_notecollectionname_0.Text= Path.GetFileName(Program.form.openFileDialog1.FileName);
                panel_notecollectionname_0.Location = new Point(x+((w-panel_notecollectionname_0.Width)/2),panel_notecollectionname_0.Location.Y);
            }
        }//midi档案的读取还没做，简谱和midi档案的互相转换还没做，格式的介绍还没做,midioutlongmsg还没研究

        /// <summary>
        /// 停止执行绪
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_stop(object sender, EventArgs e)
        {
            if (music_play_thread.IsAlive)
            {
                music_play_thread.Suspend();
                panel_timer.Stop();
                stop_bool = true;
            }
        }

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
            try
            {
                panel_time_0.PerformStep();
                panel_time_left_0.Text = (panel_time_0.Value / 60).ToString() + ":" + (panel_time_0.Value % 60).ToString();
            }
            catch
            {
                panel_timer.Stop();
            }
        }

        /// <summary>
        /// 重置播放进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void panel_reset(object sender, EventArgs e)
        {
            if (stop_bool)
            {
                music_play_thread = new Thread(new ThreadStart(Musicplay));
                panel_time_0.Value = 0;
                panel_time_left_0.Text = "0:00";
                stop_bool = false;
            }
        }
    }
}
