using sanciyuandehundan_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musical
{
    public partial class Sheet_write : UserControl
    {
        public struct label_tag
        {
            public Color color;
            public string note;
            public bool xianhave;
            public label_tag(Color color_, string note_, bool xianhave_)
            {
                color = color_;
                note = note_;
                xianhave = xianhave_;
            }
            /*public label_tag()
            {
                color = Color.White;
                note = string.Empty;
                xianhave = false;
            }*/
        }
        /*public class Xiaojie
        {
            public int xiaojielong;
            public System.Windows.Forms.Label back_anchored;
            public Sheet_write parent;
            public Xiaojie(int xiaojie_number, int xiaojie_base, Sheet_write sheet)
            {
                parent = sheet;
                back_anchored = new System.Windows.Forms.Label();
                back_anchored.Size = new Size(386, sheet.Height);
                back_anchored.Location = new Point(0, 0);
                back_anchored.BackColor = Color.Transparent;
                parent.Controls.Add(back_anchored);
                back_anchored.MouseEnter += new EventHandler(sheet.Xiaojie_MouseEnter);
                back_anchored.MouseLeave += new EventHandler(sheet.Xiaojie_MouseLeave);
                back_anchored.Tag = new xiaojie_tag(this);
                back_anchored.BringToFront();
                back_anchored.Image = sheet.imageList1.Images[0];
                back_anchored.Parent = sheet.note_5;
                xiaojielong = 57600 / 120 * xiaojie_number;
            }
            public struct xiaojie_tag
            {
                public Xiaojie xiaojie;
                public xiaojie_tag(Xiaojie xiaojie_)
                {
                    xiaojie = xiaojie_;
                }
            }
        }*/
        public class Hexian
        {
            public System.Windows.Forms.Label[] notes = new System.Windows.Forms.Label[8];
            public System.Windows.Forms.Label back_anchored = new System.Windows.Forms.Label();
            //public PictureBox pictureBox1;
            public int note_long;
            public int note_num = 0;
            public Sheet_write sheet;
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
            public Hexian(int width, Sheet_write sheet_)
            {
                note_long = width;
                sheet = sheet_;
                back_anchored.Location = new System.Drawing.Point(sheet.lastX, 0);
                back_anchored.Size = new System.Drawing.Size(note_long, sheet.Height);
                back_anchored.BackColor = Color.Black;
                back_anchored.ContextMenuStrip = sheet_.Note_back_strip;
                back_anchored.Tag = new Hexian_back_Tag(this);
                back_anchored.MouseEnter += new EventHandler(sheet.Hexian_MouseEnter);
                back_anchored.MouseLeave += new EventHandler(sheet.Hexian_MouseLeave);
                sheet.Controls.Add(back_anchored);
                back_anchored.BringToFront();
                sheet_.lastX += width;
            }
            public void Hexian_new_note(System.Windows.Forms.Label xian)
            {
                if (note_num == 7)
                {
                    MessageBox.Show("音符太多了哟（︶^︶）");
                    return;
                }
                //MessageBox.Show("");
                notes[note_num] = new System.Windows.Forms.Label();
                notes[note_num].Size = new Size(note_long, 200);
                notes[note_num].Location = new Point(back_anchored.Location.X + back_anchored.Width / 2 - notes[note_num].Width/2,xian.Location.Y);
                notes[note_num].Text = "aa";
                notes[note_num].AutoSize = true;
                notes[note_num].BackColor = Color.Transparent;
                notes[note_num].ForeColor = Color.Red;
                notes[note_num].Name = "note_" + ((label_tag)xian.Tag).note;
                notes[note_num].Parent = sheet;
                sheet.Controls.Add(notes[note_num]);
                notes[note_num].BringToFront();
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
        }

        public System.Windows.Forms.Label Hexian_anchored;
        public string note_now="1";
        public int xiaojie_note_base=4;
        public int xiaojie_note_long=4;
        public int lastX=0;
        public Hexian[] Hexians=new Hexian[1];

        public Sheet_write(int note_base, int note_long)
        {
            xiaojie_note_base = note_base;
            xiaojie_note_long = note_long;
            InitializeComponent();
            note_3.Tag = new label_tag(note_3.ForeColor, "3", true);
            note_5.Tag = new label_tag(note_5.ForeColor, "5", true);
            note_7.Tag = new label_tag(note_7.ForeColor, "7", true);
            note_9.Tag = new label_tag(note_9.ForeColor, "+2", true);
            note_11.Tag = new label_tag(note_11.ForeColor, "+4", true);
            note_10.Tag = new label_tag(note_10.BackColor, "+3", false);
            note_8.Tag = new label_tag(note_8.BackColor, "+1", false);
            note_6.Tag = new label_tag(note_6.BackColor, "6", false);
            note_4.Tag = new label_tag(note_4.BackColor, "4", false);
        }

        private void Sheet_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;

            if (Hexian_anchored == null|e.X>lastX)
            {
                Hexian hexian = new Hexian(10*Midi.Yingui.Music_stream_time(note_now, (float)(1.0F / xiaojie_note_base), xiaojie_note_long), this);//宽度算法仍有问题
                Hexians.Append(hexian);
                hexian.Hexian_new_note(label);
                Hexian_anchored = hexian.back_anchored;
            }//如果没有音符就创建音符
            else
            {
                ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_new_note(label);
                //note.Hexian_new_note(label);
            }//如果有
        }//确定音符

        private void Sheet_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (((label_tag)label.Tag).xianhave)
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
            if(Hexian_anchored!=null)
            if(e.X<=Hexian_anchored.Location.X||e.X>=Hexian_anchored.Location.X+Hexian_anchored.Width)
            {
                Hexian_anchored?.BringToFront();
                //note_anchored = null;
            }
        }

        private void Sheet_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (((label_tag)label.Tag).xianhave)
            {
                label.ForeColor = ((label_tag)label.Tag).color;
            }
            else
            {
                label.BackColor = ((label_tag)label.Tag).color;
            }
            //label.ForeColor = ((label_tag)label.Tag).color;
        }//鼠标离开，取消显示

        private void Sheet_write_Load(object sender, EventArgs e)
        {
            //Xiaojie xiaojie = new Xiaojie(4, 4, this);
        }

        public void Hexian_MouseEnter(object sender,EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            Hexian_anchored?.BringToFront();
            label?.SendToBack();
            Hexian_anchored = label;
        }//用在note的back_anchored
        //public void 
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
    }
}
