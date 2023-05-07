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
            public Sheet_tag(Color color_, string note_, bool xianhave_)
            {
                color = color_;
                note = note_;
                xianhave = xianhave_;
            }
            public Sheet_tag()
            {
                color = Color.White;
                note = string.Empty;
                xianhave = false;
            }
        }

        public class Hexian
        {
            public System.Windows.Forms.Label[] notes = new System.Windows.Forms.Label[14];
            public System.Windows.Forms.Label back_anchored = new System.Windows.Forms.Label();
            //public PictureBox pictureBox1;
            public int note_long;
            public int note_num = 0;
            public Sheet_write sheet;
            public string time;
            public string lianyinxian = "";
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
            public Hexian(int width, Sheet_write sheet_, string time_)
            {
                note_long = width;
                sheet = sheet_;
                back_anchored.Location = new System.Drawing.Point(sheet.lastX, 0);
                back_anchored.Size = new System.Drawing.Size(note_long, sheet.Height);
                back_anchored.BackColor = Color.Transparent;
                back_anchored.BackColor = Color.Black;
                back_anchored.ContextMenuStrip = sheet_.Note_back_strip;
                back_anchored.Tag = new Hexian_back_Tag(this);
                back_anchored.MouseEnter += new EventHandler(sheet.Hexian_MouseEnter);
                back_anchored.MouseLeave += new EventHandler(sheet.Hexian_MouseLeave);
                sheet.Controls.Add(back_anchored);
                back_anchored.Image = Properties.Resources.屏幕截图_2023_05_08_000323;
                back_anchored.ImageAlign= System.Drawing.ContentAlignment.TopLeft;
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
                notes[note_num] = note;
                note.Size = new Size(back_anchored.Width / 5 + 20, 20);
                note.Location = new Point(back_anchored.Location.X + back_anchored.Width / 2 - note.Width / 2, xian.Location.Y);
                note.Text = ((Sheet_tag)xian.Tag).note;
                note.BackColor = Color.Transparent;
                note.ForeColor = Color.Red;
                note.Name = "note_" + ((Sheet_tag)xian.Tag).note;
                note.Parent = sheet;
                note.Tag = new Hexian_note_Tag(((Sheet_tag)xian.Tag).note);
                sheet.Controls.Add(note);
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
                public string pinlv;
                public Hexian_note_Tag(string pinlv_)
                {
                    pinlv = pinlv_;
                }
            }
        }

        public System.Windows.Forms.Label Hexian_anchored;
        //public string note_now = "1";
        public int xiaojie_note_base = 4;//基准音符
        public int xiaojie_note_num = 4;//一小节几个音符
        public int lastX = 0;
        public Hexian[] Hexians = new Hexian[256];
        public int Hexians_num = 0;
        public void* note_now;
        public Form2 parent;
        public unsafe Sheet_write(int note_base, int note_long, Form2 form2, ref void* note)
        {
            parent = form2;
            //note_now = note;
            xiaojie_note_base = note_base;
            xiaojie_note_num = note_long;
            InitializeComponent();
            note_3.Tag = new Sheet_tag(note_3.ForeColor, "3", true);
            note_5.Tag = new Sheet_tag(note_5.ForeColor, "5", true);
            note_7.Tag = new Sheet_tag(note_7.ForeColor, "7", true);
            note_9.Tag = new Sheet_tag(note_9.ForeColor, "+2", true);
            note_11.Tag = new Sheet_tag(note_11.ForeColor, "+4", true);
            note_10.Tag = new Sheet_tag(note_10.BackColor, "+3", false);
            note_8.Tag = new Sheet_tag(note_8.BackColor, "+1", false);
            note_6.Tag = new Sheet_tag(note_6.BackColor, "6", false);
            note_4.Tag = new Sheet_tag(note_4.BackColor, "4", false);
        }

        private void Sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (parent.note_now == null) return;
            System.Windows.Forms.Label sheet = (System.Windows.Forms.Label)sender;

            if (Hexian_anchored == null | e.X > lastX)
            {
                //xiaojiexian_0.Location.X/xiaojie_note_num 一拍多长
                //(int)Midi.Music_time(parent.note_out)/256.0f 一分音符的几分之几
                //xiaojie_note_base
                Console.WriteLine("一拍多长：" + this.Width / xiaojie_note_num);
                Console.WriteLine("一分音符的几分之几" + 256 / Midi.Music_time(parent.note_now));
                Console.WriteLine("一拍几分音符：" + xiaojie_note_base);
                Hexian hexian = new Hexian((int)((this.Width / 4 / xiaojie_note_num) / (256 / Midi.Music_time(parent.note_now) / xiaojie_note_base)), this, parent.note_now);//宽度算法仍有问题
                Console.WriteLine(hexian.back_anchored.Width);
                Hexians[Hexians_num] = hexian;
                Hexians_num++;
                hexian.Hexian_new_note(sheet);
                Hexian_anchored = hexian.back_anchored;
            }//如果没有和弦就创建和弦
            else
            {
                bool j = false;
                for (int i = 0; i < ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.note_num; i++)
                {
                    if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.notes[i].Name.Equals("note_" + ((Sheet_tag)sheet.Tag).note))
                    {
                        j = true;
                        MessageBox.Show("有了");
                        break;
                    }
                }
                //Console.WriteLine(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.notes[i].Name);
                if (!j)
                {
                    Console.WriteLine("note_" + ((Sheet_tag)sheet.Tag).note);
                    ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_new_note(sheet);
                }
            }//如果有和弦
        }//确定音符

        private void Sheet_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (((Sheet_tag)label.Tag).xianhave)
            {
                label.ForeColor = Color.Red;
            }
            else
            {
                label.BackColor = Color.Orange;
            }
            //note_now = ((label_tag)label.Tag).note;
        }//鼠标进入，显示对应地方的图标

        private void Sheet_MouseMove(object sender, MouseEventArgs e)
        {
            if (Hexian_anchored != null)
                if (e.X <= Hexian_anchored.Location.X || e.X >= Hexian_anchored.Location.X + Hexian_anchored.Width)
                {
                    Hexian_anchored?.BringToFront();
                    //note_anchored = null;
                }
        }

        private void Sheet_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (((Sheet_tag)label.Tag).xianhave)
            {
                label.ForeColor = ((Sheet_tag)label.Tag).color;
            }
            else
            {
                label.BackColor = ((Sheet_tag)label.Tag).color;
            }
            //label.ForeColor = ((label_tag)label.Tag).color;
        }//鼠标离开，取消显示

        private void Sheet_write_Load(object sender, EventArgs e)
        {
            //Xiaojie xiaojie = new Xiaojie(4, 4, this);
        }

        public void Hexian_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            Hexian_anchored?.BringToFront();
            label?.SendToBack();
            Hexian_anchored = label;
        }//用在note的back_anchored

        public void Hexian_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            //note_anchored?.BringToFront();
            //note_anchored=null;
        }//用在note的back_anchored

        private void Sheet_write_MouseMove(object sender, MouseEventArgs e)
        {
            if (Hexian_anchored != null)
                if (e.X <= Hexian_anchored.Location.X || e.X >= Hexian_anchored.Location.X + Hexian_anchored.Width)
                {
                    Hexian_anchored?.BringToFront();
                    //note_anchored = null;
                }
        }

        public string Sheet_write_save()
        {
            string zan="";
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
            return zan;
        }

    }
}
