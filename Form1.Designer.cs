namespace musical
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
            this.panel_diaoshi_1 = new System.Windows.Forms.DomainUpDown();
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
            this.panel_0.Controls.Add(this.panel_diaoshi_1);
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
            // panel_diaoshi_1
            // 
            this.panel_diaoshi_1.Items.Add("♭♭♭♭♭♭♭");
            this.panel_diaoshi_1.Items.Add("♭♭♭♭♭♭");
            this.panel_diaoshi_1.Items.Add("♭♭♭♭♭");
            this.panel_diaoshi_1.Items.Add("♭♭♭♭");
            this.panel_diaoshi_1.Items.Add("♭♭♭");
            this.panel_diaoshi_1.Items.Add("♭♭");
            this.panel_diaoshi_1.Items.Add("♭");
            this.panel_diaoshi_1.Items.Add("无");
            this.panel_diaoshi_1.Items.Add("♯");
            this.panel_diaoshi_1.Items.Add("♯♯");
            this.panel_diaoshi_1.Items.Add("♯♯♯");
            this.panel_diaoshi_1.Items.Add("♯♯♯♯");
            this.panel_diaoshi_1.Items.Add("♯♯♯♯♯");
            this.panel_diaoshi_1.Items.Add("♯♯♯♯♯♯");
            this.panel_diaoshi_1.Items.Add("♯♯♯♯♯♯♯");
            this.panel_diaoshi_1.Location = new System.Drawing.Point(462, 154);
            this.panel_diaoshi_1.Name = "panel_diaoshi_1";
            this.panel_diaoshi_1.Size = new System.Drawing.Size(95, 25);
            this.panel_diaoshi_1.TabIndex = 24;
            this.panel_diaoshi_1.TabStop = false;
            this.panel_diaoshi_1.Text = "升降";
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
            this.panel_diaoshi_0.Items.Add("高音谱");
            this.panel_diaoshi_0.Items.Add("低音谱");
            this.panel_diaoshi_0.Location = new System.Drawing.Point(361, 154);
            this.panel_diaoshi_0.Name = "panel_diaoshi_0";
            this.panel_diaoshi_0.Size = new System.Drawing.Size(72, 25);
            this.panel_diaoshi_0.TabIndex = 20;
            this.panel_diaoshi_0.TabStop = false;
            this.panel_diaoshi_0.Text = "什么谱";
            // 
            // panel_instrument_0
            // 
            this.panel_instrument_0.Items.Add("0 Acoustic Grand Piano 大钢琴（声学钢琴）");
            this.panel_instrument_0.Items.Add("1 Bright Acoustic Piano 明亮的钢琴");
            this.panel_instrument_0.Items.Add("2 Electric Grand Piano 电钢琴");
            this.panel_instrument_0.Items.Add("3 Honky-tonk Piano 酒吧钢琴");
            this.panel_instrument_0.Items.Add("4 Rhodes Piano 柔和的电钢琴");
            this.panel_instrument_0.Items.Add("5 Chorused Piano 加合唱效果的电钢琴");
            this.panel_instrument_0.Items.Add("6 Harpsichord 羽管键琴（拨弦古钢琴）");
            this.panel_instrument_0.Items.Add("7 Clavichord 科拉维科特琴（击弦古钢琴）");
            this.panel_instrument_0.Items.Add("8 Celesta 钢片琴");
            this.panel_instrument_0.Items.Add("9 Glockenspiel 钟琴");
            this.panel_instrument_0.Items.Add("10 Music box 八音盒");
            this.panel_instrument_0.Items.Add("11 Vibraphone 颤音琴");
            this.panel_instrument_0.Items.Add("12 Marimba 马林巴");
            this.panel_instrument_0.Items.Add("13 Xylophone 木琴");
            this.panel_instrument_0.Items.Add("14 Tubular Bells 管钟");
            this.panel_instrument_0.Items.Add("15 Dulcimer 大扬琴");
            this.panel_instrument_0.Items.Add("16 Hammond Organ 击杆风琴");
            this.panel_instrument_0.Items.Add("17 Percussive Organ 打击式风琴");
            this.panel_instrument_0.Items.Add("18 Rock Organ 摇滚风琴");
            this.panel_instrument_0.Items.Add("19 Church Organ 教堂风琴");
            this.panel_instrument_0.Items.Add("20 Reed Organ 簧管风琴");
            this.panel_instrument_0.Items.Add("21 Accordian 手风琴");
            this.panel_instrument_0.Items.Add("22 Harmonica 口琴");
            this.panel_instrument_0.Items.Add("23 Tango Accordian 探戈手风琴");
            this.panel_instrument_0.Items.Add("24 Acoustic Guitar (nylon) 尼龙弦吉他");
            this.panel_instrument_0.Items.Add("25 Acoustic Guitar (steel) 钢弦吉他");
            this.panel_instrument_0.Items.Add("26 Electric Guitar (jazz) 爵士电吉他");
            this.panel_instrument_0.Items.Add("27 Electric Guitar (clean) 清音电吉他");
            this.panel_instrument_0.Items.Add("28 Electric Guitar (muted) 闷音电吉他");
            this.panel_instrument_0.Items.Add("29 Overdriven Guitar 加驱动效果的电吉他");
            this.panel_instrument_0.Items.Add("30 Distortion Guitar 加失真效果的电吉他");
            this.panel_instrument_0.Items.Add("31 Guitar Harmonics 吉他和音");
            this.panel_instrument_0.Items.Add("32 Acoustic Bass 大贝司（声学贝司）");
            this.panel_instrument_0.Items.Add("33 Electric Bass(finger) 电贝司（指弹）");
            this.panel_instrument_0.Items.Add("34 Electric Bass (pick) 电贝司（拨片）");
            this.panel_instrument_0.Items.Add("35 Fretless Bass 无品贝司");
            this.panel_instrument_0.Items.Add("36 Slap Bass 1 掌击Bass 1");
            this.panel_instrument_0.Items.Add("37 Slap Bass 2 掌击Bass 2");
            this.panel_instrument_0.Items.Add("38 Synth Bass 1 电子合成Bass 1");
            this.panel_instrument_0.Items.Add("39 Synth Bass 2 电子合成Bass 2");
            this.panel_instrument_0.Items.Add("40 Violin 小提琴");
            this.panel_instrument_0.Items.Add("41 Viola 中提琴");
            this.panel_instrument_0.Items.Add("42 Cello 大提琴");
            this.panel_instrument_0.Items.Add("43 Contrabass 低音大提琴");
            this.panel_instrument_0.Items.Add("44 Tremolo Strings 弦乐群颤音音色");
            this.panel_instrument_0.Items.Add("45 Pizzicato Strings 弦乐群拨弦音色");
            this.panel_instrument_0.Items.Add("46 Orchestral Harp 竖琴");
            this.panel_instrument_0.Items.Add("47 Timpani 定音鼓");
            this.panel_instrument_0.Items.Add("48 String Ensemble 1 弦乐合奏音色1");
            this.panel_instrument_0.Items.Add("49 String Ensemble 2 弦乐合奏音色2");
            this.panel_instrument_0.Items.Add("50 Synth Strings 1 合成弦乐合奏音色1");
            this.panel_instrument_0.Items.Add("51 Synth Strings 2 合成弦乐合奏音色2");
            this.panel_instrument_0.Items.Add("52 Choir Aahs 人声合唱“啊”");
            this.panel_instrument_0.Items.Add("53 Voice Oohs 人声“嘟”");
            this.panel_instrument_0.Items.Add("54 Synth Voice 合成人声");
            this.panel_instrument_0.Items.Add("55 Orchestra Hit 管弦乐敲击齐奏");
            this.panel_instrument_0.Items.Add("56 Trumpet 小号");
            this.panel_instrument_0.Items.Add("57 Trombone 长号");
            this.panel_instrument_0.Items.Add("58 Tuba 大号");
            this.panel_instrument_0.Items.Add("59 Muted Trumpet 加弱音器小号");
            this.panel_instrument_0.Items.Add("60 French Horn 法国号（圆号）");
            this.panel_instrument_0.Items.Add("61 Brass Section 铜管组（铜管乐器合奏音色）");
            this.panel_instrument_0.Items.Add("62 Synth Brass 1 合成铜管音色1");
            this.panel_instrument_0.Items.Add("63 Synth Brass 2 合成铜管音色2");
            this.panel_instrument_0.Items.Add("64 Soprano Sax  高音萨克斯风");
            this.panel_instrument_0.Items.Add("65 Alto Sax 次中音萨克斯风");
            this.panel_instrument_0.Items.Add("66 Tenor Sax  中音萨克斯风");
            this.panel_instrument_0.Items.Add("67 Baritone Sax 低音萨克斯风");
            this.panel_instrument_0.Items.Add("68 Oboe 双簧管");
            this.panel_instrument_0.Items.Add("69 English Horn 英国管");
            this.panel_instrument_0.Items.Add("70 Bassoon 巴松（大管）");
            this.panel_instrument_0.Items.Add("71 Clarinet 单簧管（黑管）");
            this.panel_instrument_0.Items.Add("72 Piccolo 短笛");
            this.panel_instrument_0.Items.Add("73 Flute 长笛");
            this.panel_instrument_0.Items.Add("74 Recorder 竖笛");
            this.panel_instrument_0.Items.Add("75 Pan Flute 排箫");
            this.panel_instrument_0.Items.Add("76 Bottle Blow [中文名称暂缺]");
            this.panel_instrument_0.Items.Add("77 Shakuhachi 日本尺八");
            this.panel_instrument_0.Items.Add("78 Whistle 口哨声");
            this.panel_instrument_0.Items.Add("79 Ocarina   奥卡雷那");
            this.panel_instrument_0.Items.Add("80 Lead 1 (square)  合成主音1（方波）");
            this.panel_instrument_0.Items.Add("81 Lead 2 (sawtooth) 合成主音2（锯齿波）");
            this.panel_instrument_0.Items.Add("82 Lead 3 (caliope lead) 合成主音3");
            this.panel_instrument_0.Items.Add("83 Lead 4 (chiff lead) 合成主音4");
            this.panel_instrument_0.Items.Add("84 Lead 5 (charang)  合成主音5");
            this.panel_instrument_0.Items.Add("85 Lead 6 (voice) 合成主音6（人声）");
            this.panel_instrument_0.Items.Add("86 Lead 7 (fifths) 合成主音7（平行五度）");
            this.panel_instrument_0.Items.Add("87 Lead 8 (bass+lead)合成主音8（贝司加主音）");
            this.panel_instrument_0.Items.Add("88 Pad 1 (new age) 合成音色1（新世纪）");
            this.panel_instrument_0.Items.Add("89 Pad 2 (warm)  合成音色2（温暖）");
            this.panel_instrument_0.Items.Add("90 Pad 3 (polysynth)  合成音色3");
            this.panel_instrument_0.Items.Add("91 Pad 4 (choir) 合成音色4（合唱）");
            this.panel_instrument_0.Items.Add("92 Pad 5 (bowed) 合成音色5");
            this.panel_instrument_0.Items.Add("93 Pad 6 (metallic) 合成音色6（金属声）");
            this.panel_instrument_0.Items.Add("94 Pad 7 (halo)  合成音色7（光环）");
            this.panel_instrument_0.Items.Add("95 Pad 8 (sweep) 合成音色8");
            this.panel_instrument_0.Items.Add("96 FX 1 (rain) 合成效果1雨声");
            this.panel_instrument_0.Items.Add("97 FX 2 (soundtrack) 合成效果2音轨");
            this.panel_instrument_0.Items.Add("98 FX 3 (crystal) 合成效果3水晶");
            this.panel_instrument_0.Items.Add("99 FX 4 (atmosphere) 合成效果4大气");
            this.panel_instrument_0.Items.Add("100 FX 5 (brightness) 合成效果5明亮");
            this.panel_instrument_0.Items.Add("101 FX 6 (goblins) 合成效果6鬼怪");
            this.panel_instrument_0.Items.Add("102 FX 7 (echoes)  合成效果7回声");
            this.panel_instrument_0.Items.Add("103 FX 8 (sci-fi)  合成效果8科幻");
            this.panel_instrument_0.Items.Add("104 Sitar 西塔尔（印度）");
            this.panel_instrument_0.Items.Add("105 Banjo 班卓琴（美洲）");
            this.panel_instrument_0.Items.Add("106 Shamisen  三昧线（日本）");
            this.panel_instrument_0.Items.Add("107 Koto 十三弦筝（日本）");
            this.panel_instrument_0.Items.Add("108 Kalimba 卡林巴");
            this.panel_instrument_0.Items.Add("109 Bagpipe 风笛");
            this.panel_instrument_0.Items.Add("110 Fiddle 民族提琴");
            this.panel_instrument_0.Items.Add("111 Shanai 山奈");
            this.panel_instrument_0.Items.Add("112 Tinkle Bell 叮当铃");
            this.panel_instrument_0.Items.Add("113 Agogo [中文名称暂缺]");
            this.panel_instrument_0.Items.Add("114 Steel Drums 钢鼓");
            this.panel_instrument_0.Items.Add("115 Woodblock 木鱼");
            this.panel_instrument_0.Items.Add("116 Taiko Drum 太鼓");
            this.panel_instrument_0.Items.Add("117 Melodic Tom 通通鼓");
            this.panel_instrument_0.Items.Add("118 Synth Drum  合成鼓");
            this.panel_instrument_0.Items.Add("119 Reverse Cymbal 铜钹");
            this.panel_instrument_0.Items.Add("120 Guitar Fret Noise 吉他换把杂音");
            this.panel_instrument_0.Location = new System.Drawing.Point(275, 193);
            this.panel_instrument_0.Name = "panel_instrument_0";
            this.panel_instrument_0.Size = new System.Drawing.Size(345, 25);
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
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "全部暂停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "全部重置播放";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "增加声部";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Panel_add);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "删除最底声部";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Panel_delete_last);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "乐谱|*.txt|所有文件|*.*\"";
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
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(22, 442);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
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
        public System.Windows.Forms.DomainUpDown panel_diaoshi_1;
    }
}

