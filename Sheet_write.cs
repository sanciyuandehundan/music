using sanciyuandehundan_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musical
{
    public unsafe partial class Sheet_write : UserControl
    {
        public struct Sheet_tag
        {
            public Color color;
            public string note;
            public bool xianhave;
            public bool xianat;
            public Sheet_tag(Color color_, string note_, bool xianhave_, bool xianat_)
            {
                color = color_;
                note = note_;
                xianhave = xianhave_;
                xianat = xianat_;
            }
            /*public Sheet_tag()
            {
                color = Color.White;
                note = string.Empty;
                xianhave = false;
            }*/
        }

        public class Hexian
        {
            public System.Windows.Forms.Label back_anchored = new System.Windows.Forms.Label();
            public System.Windows.Forms.Label last_note = new System.Windows.Forms.Label();
            public System.Windows.Forms.Label first_note = new System.Windows.Forms.Label();
            //public PictureBox pictureBox1;
            public int note_long;
            public int note_num = 0;
            public Sheet_write parent;
            public string time;
            public string lianyinxian = "";
            public Hexian last;
            public Hexian next;
            //public Xiaojie Xiaojie;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="width">
            /// 这个音符label的宽
            /// </param>
            /// <param name="control">
            /// 获取谱子控件
            /// </param>
            public Hexian(int width, Sheet_write sheet_, string time_, Hexian last_)
            {
                last = last_;
                if (last != null) last.next = this;
                note_long = width;
                parent = sheet_;
                back_anchored.Location = new System.Drawing.Point(parent.lastX, 0);
                back_anchored.Size = new System.Drawing.Size(note_long, parent.Height);
                back_anchored.BackColor = Color.Transparent;
                back_anchored.BackColor = Color.Black;
                back_anchored.ContextMenuStrip = sheet_.Note_back_strip;
                back_anchored.Tag = new Hexian_back_Tag(this);
                back_anchored.MouseEnter += new EventHandler(parent.Hexian_MouseEnter);
                back_anchored.MouseLeave += new EventHandler(parent.Hexian_MouseLeave);
                parent.Controls.Add(back_anchored);
                back_anchored.BringToFront();
                sheet_.lastX += width;
                this.time = time_;
            }
            public void Hexian_new_note(System.Windows.Forms.Label xian)
            {
                if (note_num == 14)
                {
                    MessageBox.Show("音符太多了哟（︶^︶）");
                    return;
                }
                System.Windows.Forms.Label note = new System.Windows.Forms.Label();
                parent.Controls.Add(note);
                //notes[note_num] = note;
                note.Size = new Size(back_anchored.Width / 5 + 20, 20);
                note.Location = new Point(back_anchored.Location.X + back_anchored.Width / 2 - note.Width / 2, xian.Location.Y);
                note.Text = ((Sheet_tag)xian.Tag).note;
                note.BackColor = Color.Transparent;
                note.ForeColor = Color.Red;
                note.Name = "note_" + ((Sheet_tag)xian.Tag).note;
                note.Tag = new Hexian_note_Tag(((Sheet_tag)xian.Tag).note, last_note, note);
                last_note = note;
                if (!first_note.Created)
                {
                    first_note = note;
                }
                //Console.WriteLine(note.Created);
                //Console.WriteLine(note.Created);
                //xian.Controls.Add(note);
                note.BringToFront();
                note_num++;
            }
            public struct Hexian_back_Tag
            {
                public Hexian parent;
                public Hexian_back_Tag(Hexian hexian)
                {
                    parent = hexian;
                }
            }
            public struct Hexian_note_Tag
            {
                public System.Windows.Forms.Label this_note;
                public string pinlv;
                public System.Windows.Forms.Label last;
                public System.Windows.Forms.Label next;
                public Hexian_note_Tag(string pinlv_, System.Windows.Forms.Label last_, System.Windows.Forms.Label this_note_)
                {
                    this_note = this_note_;
                    last = last_;
                    Console.WriteLine(this_note.Text + ".last.Created: " + last.Created);
                    Console.WriteLine(this_note.Text + ".last" + last.Text);
                    Console.WriteLine(this_note.Text + ".this" + this_note.Text);
                    if (last.Created)
                    {
                        last.Tag = new Hexian_note_Tag(((Hexian_note_Tag)last.Tag).pinlv, ((Hexian_note_Tag)last.Tag).last, ((Hexian_note_Tag)last.Tag).this_note, this_note);
                    }
                    pinlv = pinlv_;
                }
                private Hexian_note_Tag(string pinlv_, System.Windows.Forms.Label last_, System.Windows.Forms.Label this_note_, System.Windows.Forms.Label next_)
                {
                    this_note = this_note_;
                    next = next_;
                    last = last_;
                    pinlv = pinlv_;
                    Console.WriteLine("this: " + this_note.Created);
                    Console.WriteLine("next: " + next.Created);
                    Console.WriteLine("last: " + last.Created);
                    Console.WriteLine("pinlv: " + pinlv);
                }
            }

            public string Hexian_save()
            {
                string zan = "";
                /*
                for (int i = 0; i < this.notes.Length; i++)
                {
                    if (this.notes[i] != null)
                    {
                        zan += ((Hexian.Hexian_note_Tag)this.notes[i].Tag).pinlv + '/';
                    }
                }*/
                Console.WriteLine(first_note.Created);
                zan = Note_save(first_note);
                zan = zan.TrimEnd('/');
                zan += ',' + this.time + '|' + this.lianyinxian;
                return zan + next?.Hexian_save();
            }
            public string Note_save(System.Windows.Forms.Label note)
            {
                if (note != null) if (!note.Created) return "";
                if (note == null) return "";
                string zan = "";
                zan = ((Hexian.Hexian_note_Tag)note.Tag).pinlv + '/';
                Console.WriteLine(zan);
                return zan + Note_save(((Hexian_note_Tag)note.Tag).next);
            }
            public void Hexian_delet()
            {
                parent.lastX -= this.back_anchored.Width;
                this.last.next = this.next;
                this.next.back_anchored.Location = new Point(parent.lastX, 0);
                this.back_anchored.Parent = null;
                /*foreach(System.Windows.Forms.Label a in this.notes)
                {
                    if (a != null) a.Parent = null;
                }
                GC.Collect();*/
            }
        }//加上一个保存方法


        public System.Windows.Forms.Label Hexian_anchored_;//使用get set
        public System.Windows.Forms.Label Hexian_anchored
        {
            set
            {
                //this.Controls.Add(Hexian_anchored_);！！！！！！！！！！！！！！！！！！！！！！！！！！！！
                //Hexian_anchored_?.BringToFront();
                Hexian_anchored_ = value;
            }
            get { return Hexian_anchored_; }
        }//使用get set



        //public string note_now = "1";
        public int xiaojie_note_base = 4;//基准音符
        public int xiaojie_note_num = 4;//一小节几个音符
        public int lastX = 0;
        public Hexian first_Hexian = null;
        public Hexian last_Hexian = null;
        public int Hexians_num = 0;
        public void* note_now;
        public Form2 parent;
        public Sheet_write(int note_base, int note_long, Form2 form2/*, ref void* note*/)
        {
            parent = form2;
            //note_now = note;
            xiaojie_note_base = note_base;
            xiaojie_note_num = note_long;
            InitializeComponent();
            note_1.ForeColor = note_1.BackColor;
            note__2.ForeColor = note__2.BackColor;
            note__4.ForeColor = note__4.BackColor;
            note__6.ForeColor = note__6.BackColor;
            note_13.ForeColor = note_13.BackColor;
            note_15.ForeColor = note_15.BackColor;
            note_17.ForeColor = note_17.BackColor;
            note_19.ForeColor = note_19.BackColor; ;
            note_3.Tag = new Sheet_tag(note_3.ForeColor, "3", true, true);
            note_5.Tag = new Sheet_tag(note_5.ForeColor, "5", true, true);
            note_7.Tag = new Sheet_tag(note_7.ForeColor, "7", true, true);
            note_9.Tag = new Sheet_tag(note_9.ForeColor, "+2", true, true);
            note_11.Tag = new Sheet_tag(note_11.ForeColor, "+4", true, true);
            note_10.Tag = new Sheet_tag(note_10.BackColor, "+3", false, true);
            note_8.Tag = new Sheet_tag(note_8.BackColor, "+1", false, true);
            note_6.Tag = new Sheet_tag(note_6.BackColor, "6", false, true);
            note_4.Tag = new Sheet_tag(note_4.BackColor, "4", false, true);
            //实线内
            note_2.Tag = new Sheet_tag(note_2.BackColor, "2", false, false);
            note_1.Tag = new Sheet_tag(note_1.ForeColor, "1", true, false);
            note__1.Tag = new Sheet_tag(note__1.BackColor, "-7", false, false);
            note__2.Tag = new Sheet_tag(note__2.ForeColor, "-6", true, false);
            note__3.Tag = new Sheet_tag(note__3.BackColor, "-5", false, false);
            note__4.Tag = new Sheet_tag(note__4.ForeColor, "-4", true, false);
            note__5.Tag = new Sheet_tag(note__5.BackColor, "-3", false, false);
            note__6.Tag = new Sheet_tag(note__6.ForeColor, "-2", true, false);
            note_12.Tag = new Sheet_tag(note_12.BackColor, "+5", false, false);
            note_13.Tag = new Sheet_tag(note_13.ForeColor, "+6", true, false);
            note_14.Tag = new Sheet_tag(note_14.BackColor, "+7", false, false);
            note_15.Tag = new Sheet_tag(note_15.ForeColor, "++1", true, false);
            note_16.Tag = new Sheet_tag(note_16.BackColor, "++2", false, false);
            note_17.Tag = new Sheet_tag(note_17.ForeColor, "++3", true, false);
            note_18.Tag = new Sheet_tag(note_18.BackColor, "++4", false, false);
            note_19.Tag = new Sheet_tag(note_19.ForeColor, "++5", true, false);
            note_1.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            note__2.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            note__4.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            note__6.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            note_13.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            note_15.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            note_17.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            note_19.Text = "—————————————————————————————————————————————————————————————————————————————————" + "—————————————————";
            this.note_2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note__1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note__2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note__3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note__4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note__5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note__6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note_19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            //实线外
        }

        private void Sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (parent.note_now == null) return;
            System.Windows.Forms.Label xian = (System.Windows.Forms.Label)sender;

            if (Hexian_anchored == null | e.X > lastX)
            {
                //xiaojiexian_0.Location.X/xiaojie_note_num 一拍多长
                //(int)Midi.Music_time(parent.note_out)/256.0f 一分音符的几分之几
                //xiaojie_note_base
                Console.WriteLine("一拍多长：" + this.Width / xiaojie_note_num);
                Console.WriteLine("一分音符的几分之几" + 256 / Midi.Music_time(parent.note_now));
                Console.WriteLine("一拍几分音符：" + xiaojie_note_base);
                Hexian hexian = new Hexian((int)((this.Width / 4 / xiaojie_note_num) / (256 / Midi.Music_time(parent.note_now) / xiaojie_note_base)), this, parent.note_now, last_Hexian);
                if (first_Hexian == null) first_Hexian = hexian;
                last_Hexian = hexian;
                Console.WriteLine(hexian.back_anchored.Width);
                Hexians_num++;
                hexian.Hexian_new_note(xian);
                Hexian_anchored = hexian.back_anchored;
            }//如果没有和弦就创建和弦
            else
            {
                bool j = false;
                for (int i = 0; i < ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.note_num; i++)
                {
                    if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.last_note.Name.Equals("note_" + ((Sheet_tag)xian.Tag).note))
                    {
                        j = true;
                        MessageBox.Show("有了");
                        break;
                    }
                }//检测欲创建的音符是否已存在
                //Console.WriteLine(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.notes[i].Name);
                if (!j)
                {
                    Console.WriteLine("note_" + ((Sheet_tag)xian.Tag).note);
                    ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_new_note(xian);
                }//不存在则创建
            }//如果有和弦
        }//确定音符

        private void Sheet_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label xian = (System.Windows.Forms.Label)sender;
            //label.Controls.Add(Hexian_anchored);
            //Hexian_anchored?.SendToBack();
            if (((Sheet_tag)xian.Tag).xianat)
            {
                if (((Sheet_tag)xian.Tag).xianhave)
                {
                    xian.ForeColor = Color.Red;
                }
                else
                {
                    xian.BackColor = Color.Orange;
                }
            }//在中间的五条线内
            else
            {
                if (((Sheet_tag)xian.Tag).xianhave)
                {
                    xian.ForeColor = Color.Red;
                }//有线
                else
                {
                    xian.BackColor = Color.Orange;
                }//没线
            }//在中间的五条线外
            //note_now = ((label_tag)label.Tag).note;
        }//鼠标进入，显示对应地方的图标

        private void Sheet_MouseMove(object sender, MouseEventArgs e)
        {
            if (Hexian_anchored != null)
                if (e.X <= Hexian_anchored.Location.X || e.X >= Hexian_anchored.Location.X + Hexian_anchored.Width)
                {
                    Hexian_anchored?.BringToFront();
                }
        }//和弦的背景

        private void Sheet_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;

            if (((Sheet_tag)label.Tag).xianat)
            {
                if (((Sheet_tag)label.Tag).xianhave)
                {
                    label.ForeColor = ((Sheet_tag)label.Tag).color;
                }//有线
                else
                {
                    label.BackColor = ((Sheet_tag)label.Tag).color;
                }//没线
            }//在中间的五条线内
            else
            {
                if (((Sheet_tag)label.Tag).xianhave)
                {
                    label.ForeColor = ((Sheet_tag)label.Tag).color;
                }//有线
                else
                {
                    label.BackColor = ((Sheet_tag)label.Tag).color;
                }//没线
            }//在中间的五条线外
            //label.ForeColor = ((label_tag)label.Tag).color;
        }//谱线

        private void Sheet_write_Load(object sender, EventArgs e)
        {
            //Xiaojie xiaojie = new Xiaojie(4, 4, this);
        }

        public void Hexian_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label xian = (System.Windows.Forms.Label)sender;
            Hexian_anchored?.BringToFront();
            xian?.SendToBack();
            //if(Hexian_anchored.Equals(sender))
            Hexian_anchored = xian;
        }//和弦的背景

        public void Hexian_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label xian = (System.Windows.Forms.Label)sender;
            //note_anchored?.BringToFront();
            //note_anchored=null;
        }//和弦的背景

        private void Sheet_write_MouseMove(object sender, MouseEventArgs e)
        {
            if (Hexian_anchored != null)
                if (e.X <= Hexian_anchored.Location.X || e.X >= Hexian_anchored.Location.X + Hexian_anchored.Width)
                {
                    Hexian_anchored?.BringToFront();
                    //note_anchored = null;
                }
        }//整个控件

        public string Sheet_write_save()
        {
            /*string zan="";
            foreach (Hexian a in Hexians)
            {
                if (a != null)
                {
                    for (int i = 0; i < a.note_num; i++)
                    {
                        if (a.notes[i] != null)
                        {
                            zan+=((Hexian.Hexian_note_Tag)a.notes[i].Tag).pinlv + '/';
                        }
                    }
                    zan=zan.TrimEnd('/');
                    zan += ',' + a.time + '|'+a.lianyinxian;
                }
            }
            return zan;*/
            return first_Hexian?.Hexian_save();
        }//保存

    }
}
