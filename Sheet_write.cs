using sanciyuandehundan_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Policy;
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
        }

        public class Hexian//:IDisposable
        {
            public System.Windows.Forms.Label back_anchored = new System.Windows.Forms.Label();
            public Note last_note = new Note();
            public Note first_note_ = new Note();
            public Note first_note
            {
                get
                {
                    return first_note_;
                }
                set
                {
                    first_note_ = value;
                    first_note_ptr = &value;
                }
            }
            public Note* first_note_ptr;
            public int note_long = 0;
            public Sheet_write parent = null;
            public string time = null;
            //public string lianyinxian = "";
            //public bool lianyinxian_have = false;
            public System.Windows.Forms.Label lianyinxian_ = new System.Windows.Forms.Label();
            public string power_code = "";
            public Hexian last = null;
            public Hexian next = null;
            public bool created = false;

            /// <summary>
            /// 建构函数
            /// </summary>
            /// <param name="width">
            /// 这个音符label的宽
            /// </param>
            /// <param name="control">
            /// 获取谱子控件
            /// </param>
            public Hexian(int width, Sheet_write sheet_, string time_, Hexian last_)
            {
                created = true;
                last = last_;
                if (last != null) last.next = this;
                parent = sheet_;
                note_long = width;
                Hexian_back_new();
                this.time = time_;
                
            }
            ~Hexian()
            {
                MessageBox.Show("OK");
            }

            public class Note : System.Windows.Forms.Label
            {
                public Hexian_note_Tag Tag;
            }
            public void Hexian_back_edit_next(int width)
            {
                back_anchored.Location = new Point(back_anchored.Location.X - width, back_anchored.Location.Y);
                Hexian_note_edit(first_note);
                if (next != null) next.Hexian_back_edit_next(width);
            }//back修改用，递归用
            public void Hexian_back_edit_first(int width, Point location)
            {
                int zan = back_anchored.Width - width;
                parent.lastX -= back_anchored.Width;
                note_long = width;
                back_anchored.Location = location;
                back_anchored.Size = new System.Drawing.Size(note_long, parent.Height);
                parent.lastX += back_anchored.Width;
                if (first_note != null) Hexian_note_edit(first_note);
                if (next != null) next.Hexian_back_edit_next(zan);
            }//back修改用，第一个
            public void Hexian_back_new()
            {
                back_anchored.Location = new System.Drawing.Point(parent.lastX, 0);
                back_anchored.Size = new System.Drawing.Size(note_long, parent.Height);
                parent.lastX += back_anchored.Width;
                back_anchored.BackColor = Color.Transparent;
                //back_anchored.BackColor = Color.Black;
                back_anchored.Tag = new Hexian_back_Tag(this);
                parent.Controls.Add(back_anchored);
                back_anchored.SendToBack();
            }//back新建用
            public void Hexian_note_edit(Note note)
            {
                note.Size = new Size(back_anchored.Width / 5 + 20, 20);
                note.Location = new Point(back_anchored.Location.X + back_anchored.Width / 2 - note.Width / 2, note.Location.Y);
                if (note.Tag.next != null) Hexian_note_edit(note.Tag.next);
            }//修改音符
            public void Hexian_note_new(System.Windows.Forms.Label xian)
            {
                Note note = new Note();
                parent.Controls.Add(note);
                //notes[note_num] = note;
                note.Size = new Size(back_anchored.Width / 5 + 20, 20);
                note.Location = new Point(back_anchored.Location.X + back_anchored.Width / 2 - note.Width / 2, xian.Location.Y - (note.Height - xian.Height) / 2);
                note.Text = ((Sheet_tag)xian.Tag).note;
                note.BackColor = Color.Transparent;
                note.ForeColor = Color.Black;
                note.MouseEnter += new EventHandler(Hexian_note_color_own_enter);
                note.MouseLeave += new EventHandler(Hexian_note_color_own_leave);
                note.Name = "note_" + ((Sheet_tag)xian.Tag).note;
                note.Tag = new Hexian_note_Tag(((Sheet_tag)xian.Tag).note, last_note, note, this);
                note.ContextMenuStrip = parent.note;
                last_note = note;
                if (first_note == null || !first_note.Created)
                {
                    first_note = note;
                }
                note.BringToFront();
            }//新建音符
            public struct Hexian_back_Tag
            {
                public Hexian parent;
                public Hexian_back_Tag(Hexian hexian)
                {
                    parent = hexian;
                }
            }
            public class Hexian_note_Tag
            {
                public Hexian parent;
                public Note this_note;
                public string pinlv;
                public Note last;
                public Note next;
                public Note* next_ptr;
                public string xiushi = "(";
                public bool lianyinfirst = false;
                public Hexian_note_Tag(string pinlv_, Note last_, Note this_note_, Hexian hexian)
                {
                    parent = hexian;
                    this_note = this_note_;
                    last = last_;
                    Console.WriteLine(this_note.Text + ".last.Created: " + last.Created);
                    Console.WriteLine(this_note.Text + ".last" + last.Text);
                    Console.WriteLine(this_note.Text + ".this" + this_note.Text);
                    if (last.Created)
                    {
                        last.Tag = new Hexian_note_Tag(last.Tag.pinlv, last.Tag.last, last.Tag.this_note, this_note, hexian);
                    }
                    pinlv = pinlv_;
                }
                public Hexian_note_Tag(string pinlv_, Note last_, Note this_note_, Note next_, Hexian hexian)
                {
                    parent = hexian;
                    this_note = this_note_;
                    next = next_;
                    next_ptr = &next_;
                    last = last_;
                    pinlv = pinlv_;
                    Console.WriteLine("this: " + this_note.Created);
                    Console.WriteLine("last: " + last.Created);
                    Console.WriteLine("pinlv: " + pinlv);
                }
                public void note_xiushi()
                {

                }
                public void note_xiushi_clear()
                {
                    xiushi = "(";
                    next?.Tag.note_xiushi_clear();
                }
                public void note_xiushi_lianyin(bool k)
                {
                    Console.WriteLine("添加成功");
                    lianyinfirst = true;
                    Console.WriteLine(lianyinfirst);
                }
                public void note_xiushi_lianyin_one()
                {
                    xiushi += Midi.Yingui.Lianyin_One;
                }
                public void note_xiushi_lianyin_first()
                {
                    xiushi += Midi.Yingui.Lianyin_first;
                }
                public void note_xiushi_lianyin_ing()
                {
                    xiushi += Midi.Yingui.Lianyin_ing;
                    lianyinfirst = false;
                }
                public void note_xiushi_lianyin_last()
                {
                    if (!lianyinfirst)
                    {
                        this.xiushi += Midi.Yingui.Lianyin_last;
                    }
                    else
                    {
                        this.xiushi += Midi.Yingui.Lianyin_ing_noend;
                    }
                    Console.WriteLine(xiushi);
                    lianyinfirst = false;
                }
            }
            public void Hexian_xiushi_clear()
            {
                first_note?.Tag.note_xiushi_clear();
                next?.Hexian_xiushi_clear();
            }
            public string Hexian_save()
            {
                if (first_note == null) return "";
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
                zan += power_code;
                zan += Hexian_note_save(first_note);
                zan = zan.TrimEnd('/');
                zan += ',' + this.time + '|';
                return zan + next?.Hexian_save();
            }//保存，和弦递归
            public string Hexian_note_save(Note note)
            {
                if (note != null) if (!note.Created) return "";
                if (note == null) return "";
                string zan = "";
                Console.WriteLine(note.Tag.lianyinfirst);
                if (note.Tag.lianyinfirst == true)
                {

                    Console.WriteLine(note.Tag.pinlv + "有连音线");
                    int num = note.Tag.parent.Hexian_lianyin_check(note.Tag.pinlv)-1;
                    Console.WriteLine("后面有几个：" + num);
                    if (num == 0)
                    {
                        note.Tag.note_xiushi_lianyin_one();
                    }
                    else
                    {
                        note.Tag.note_xiushi_lianyin_first();
                        Hexian hexian = note.Tag.parent.next;
                        Note temp=null;
                        for (int i = 0; i < num; i++)
                        {
                            //temp = hexian.Hexian_note_find(note.Tag.pinlv, first_note_ptr);
                            Console.WriteLine("触发回圈: "+num);
                            temp = hexian.Hexian_note_find(hexian.first_note, note.Tag.pinlv);
                            if (i < num - 1)
                            {
                                temp.Tag.note_xiushi_lianyin_ing();
                            }//不是最后一个
                            else
                            {
                                temp.Tag.note_xiushi_lianyin_last();
                                Console.WriteLine("last");
                            }
                            hexian = hexian.next;
                        }
                    }
                }
                zan = note.Tag.pinlv + note.Tag.xiushi + '/';
                Console.WriteLine(zan);
                return zan + Hexian_note_save(note.Tag.next);
            }//保存，音符递归
            /*public bool Hexian_lianyin_check(Note note, string order,sanciyuandehundan_API.Midi.Yingui.Note.Note_xiushi make)
            {
                if (note.Tag.pinlv.Equals(order))
                {
                    Console.WriteLine(note.Tag.pinlv + "相等");
                    switch (make)
                    {
                        case Midi.Yingui.Note.Note_xiushi.xiushi_null:
                            break;
                        case Midi.Yingui.Note.Note_xiushi.lianyin_first:
                            break;
                        case Midi.Yingui.Note.Note_xiushi.lianyin_ing:
                            note.Tag.note_xiushi_lianyin_ing();
                            break;
                        case Midi.Yingui.Note.Note_xiushi.lianyin_last:
                            note.Tag.note_xiushi_lianyin_last();
                            break;
                        case Midi.Yingui.Note.Note_xiushi.lianyin_one:
                            note.Tag.note_xiushi_lianyin_one();
                            break;
                    }
                    return true;
                }
                if (note.Tag.next != null)
                {
                    Console.WriteLine(note.Tag.pinlv + "后面还有");
                    return Hexian_lianyin_check(note.Tag.next, order,make);
                }
                else
                {
                    Console.WriteLine(note.Tag.pinlv + "后面没了");
                    return false;
                }
            }//检测是否有相同音符*/
            public int Hexian_lianyin_check(string order)
            {
                Note temp = Hexian_note_find(first_note, order);
                if (temp!=null)
                {
                    Console.WriteLine(first_note.Tag.pinlv + "first为这个的和弦有与order相同的");
                    if (this.next != null&&temp.Tag.lianyinfirst)
                    {
                        return 1 + next.Hexian_lianyin_check(order);
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 0;
                }
            }
            public void Hexian_back_move(int width)
            {
                this.back_anchored.Location = new Point(this.back_anchored.Location.X - width, 0);
                Hexian_note_move(width, first_note);
                if (next != null)
                {
                    next.Hexian_back_move(width);
                }
            }//和弦标记的移动
            public Note Hexian_note_find(Note note,string order)
            {
                if (note.Tag.pinlv.Equals(order))
                {
                    return note;
                }
                else
                {
                    if (note.Tag.next != null)
                    {
                        return Hexian_note_find(note.Tag.next,order);
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            /*public Note* Hexian_note_find(string order, Note note_now)
            {
                //Console.WriteLine(note_now->Tag.pinlv);
                Console.WriteLine(note_now);
                if (note_now->Tag.pinlv.Equals(order))
                {
                    Console.WriteLine(note_now->Tag.pinlv + "相等");
                    return note_now;
                }
                else
                {
                    Console.WriteLine(note_now->Tag.pinlv + "不相等");
                    if (note_now->Tag.next != null)
                    {
                        Console.WriteLine(note_now->Tag.pinlv + "后面还有");
                        return Hexian_note_find(order, note_now->Tag.next_ptr);
                    }
                    else
                    {
                        Console.WriteLine(note_now->Tag.pinlv + "后面没了");
                        return null;
                    }
                }
            }*/
            public void Hexian_note_move(int width, Note note)
            {
                note.Location = new Point(note.Location.X - width, 0);
                Hexian_note_move(width, note.Tag.next);
            }//和弦内音符的移动
            public bool Hexian_note_have(Note note, string template)
            {
                if (first_note == null) return false;
                //Console.WriteLine("模板  "+template);
                //Console.WriteLine("原有的   "+((Hexian_note_Tag)note.Tag).pinlv);
                if (note.Tag.next != null) return note.Tag.pinlv.Equals(template) | Hexian_note_have(note.Tag.next, template);
                return ((Hexian_note_Tag)note.Tag).pinlv.Equals(template);
            }//检测有没有template的音符
            public void Hexian_note_remove_own(Note note)
            {
                //((Hexian_note_Tag)((Hexian_note_Tag)note.Tag).last.Tag).next = ((Hexian_note_Tag)note.Tag).next;
                if (first_note.Equals(note))
                {
                    first_note = null;
                    first_note = note.Tag.next;
                }
                if (last_note.Equals(note))
                {
                    last_note = note.Tag.last;
                }
                if (note.Tag.last.Created) note.Tag.last.Tag = new Hexian_note_Tag(note.Tag.last.Tag.pinlv, note.Tag.last.Tag.last, note.Tag.last, note.Tag.next, this);
                if (note.Tag.next != null) note.Tag.next.Tag = new Hexian_note_Tag(note.Tag.next.Tag.pinlv, note.Tag.last, note.Tag.next, note.Tag.next.Tag.next, this);
                note.Parent.Controls.Remove(note);
                note.Dispose();
            }//删除单个音符
            public void Hexian_note_remove_all(Note note)
            {
                first_note = null;
                if (note == null) return;
                note.Parent.Controls.Remove(note);
                if (note.Tag.next != null) Hexian_note_remove_all(note.Tag.next);
                note.Dispose();
            }//删除全部音符
            public void Hexian_note_color_all_enter(Note note)
            {
                if (note == null) return;
                note.ForeColor = Color.Orange;
                Hexian_note_color_all_enter(note.Tag.next);
            }
            public void Hexian_note_color_all_leave(Note note)
            {
                if (note == null) return;
                note.ForeColor = Color.Black;
                Hexian_note_color_all_leave(note.Tag.next);
            }
            public void Hexian_note_color_own_enter(object sender, EventArgs e)
            {
                ((System.Windows.Forms.Label)sender).ForeColor = Color.Red;
            }//标记选到了哪个音符
            public void Hexian_note_color_own_leave(object sender, EventArgs e)
            {
                ((System.Windows.Forms.Label)sender).ForeColor = Color.Black;
            }//标记选到了哪个音符
            public void Hexian_power(string power_)
            {
                power_code = power_ + '|';
            }//力度修改
            public void Hexian_stop()
            {
                first_note = null;
                Note note = new Note();
                first_note = note;
                parent.Controls.Add(note);
                note.Size = new Size(back_anchored.Width / 5 + 20, 20);
                note.Location = new Point(back_anchored.Location.X + back_anchored.Width / 2 - note.Width / 2, this.parent.Height / 2);
                note.Text = "0";
                note.BackColor = Color.Transparent;
                note.ForeColor = Color.Red;
                note.Name = "note_0";
                note.Tag = new Hexian_note_Tag("0", last_note, note, this);
                last_note = note;
                if (!first_note.Created)
                {
                    first_note = note;
                }
                note.BringToFront();
            }//休止符

            /*
            public void Dispose()
            {
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }
            protected virtual void Dispose(bool disposing)
            {
                if (!disposing)
                {
                    return;
                }

            }*/
        }

        public System.Windows.Forms.Label Hexian_anchored_;//使用get set
        public System.Windows.Forms.Label Hexian_anchored
        {
            get
            {
                return Hexian_anchored_;
            }
            set
            {
                if (Hexian_anchored != null) ((Hexian.Hexian_back_Tag)Hexian_anchored?.Tag).parent.Hexian_note_color_all_leave(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note);
                Hexian_anchored_ = value;
                if (Hexian_anchored != null) ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_note_color_all_enter(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note);
            }
        }//使用get set
        public int xiaojie_note_base = 4;//基准音符
        public int xiaojie_note_num = 4;//一小节几个音符
        public Hexian first_Hexian = null;
        public Hexian last_Hexian = null;
        public int Hexians_num = 0;
        public int lastX = 0;
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
            note_19.ForeColor = note_19.BackColor;
            note_3.Tag = new Sheet_tag(note_3.BackColor, "3", true, true);
            note_5.Tag = new Sheet_tag(note_5.BackColor, "5", true, true);
            note_7.Tag = new Sheet_tag(note_7.BackColor, "7", true, true);
            note_9.Tag = new Sheet_tag(note_9.BackColor, "+2", true, true);
            note_11.Tag = new Sheet_tag(note_11.BackColor, "+4", true, true);
            note_10.Tag = new Sheet_tag(note_10.BackColor, "+3", false, true);
            note_8.Tag = new Sheet_tag(note_8.BackColor, "+1", false, true);
            note_6.Tag = new Sheet_tag(note_6.BackColor, "6", false, true);
            note_4.Tag = new Sheet_tag(note_4.BackColor, "4", false, true);
            //实线内
            note_2.Tag = new Sheet_tag(note_2.BackColor, "2", false, false);
            note_1.Tag = new Sheet_tag(note_1.BackColor, "1", true, false);
            note__1.Tag = new Sheet_tag(note__1.BackColor, "-7", false, false);
            note__2.Tag = new Sheet_tag(note__2.BackColor, "-6", true, false);
            note__3.Tag = new Sheet_tag(note__3.BackColor, "-5", false, false);
            note__4.Tag = new Sheet_tag(note__4.BackColor, "-4", true, false);
            note__5.Tag = new Sheet_tag(note__5.BackColor, "-3", false, false);
            note__6.Tag = new Sheet_tag(note__6.BackColor, "-2", true, false);
            note_12.Tag = new Sheet_tag(note_12.BackColor, "+5", false, false);
            note_13.Tag = new Sheet_tag(note_13.BackColor, "+6", true, false);
            note_14.Tag = new Sheet_tag(note_14.BackColor, "+7", false, false);
            note_15.Tag = new Sheet_tag(note_15.BackColor, "++1", true, false);
            note_16.Tag = new Sheet_tag(note_16.BackColor, "++2", false, false);
            note_17.Tag = new Sheet_tag(note_17.BackColor, "++3", true, false);
            note_18.Tag = new Sheet_tag(note_18.BackColor, "++4", false, false);
            note_19.Tag = new Sheet_tag(note_19.BackColor, "++5", true, false);
            /*
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
            this.note_19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));*/
            //实线外
            note_1.ContextMenuStrip = this.sheet;
            note_2.ContextMenuStrip = this.sheet;
            note_3.ContextMenuStrip = this.sheet;
            note_4.ContextMenuStrip = this.sheet;
            note_5.ContextMenuStrip = this.sheet;
            note_6.ContextMenuStrip = this.sheet;
            note_7.ContextMenuStrip = this.sheet;
            note_8.ContextMenuStrip = this.sheet;
            note_9.ContextMenuStrip = this.sheet;
            note_10.ContextMenuStrip = this.sheet;
            note_11.ContextMenuStrip = this.sheet;
            note_12.ContextMenuStrip = this.sheet;
            note_13.ContextMenuStrip = this.sheet;
            note_14.ContextMenuStrip = this.sheet;
            note_15.ContextMenuStrip = this.sheet;
            note_16.ContextMenuStrip = this.sheet;
            note_17.ContextMenuStrip = this.sheet;
            note_18.ContextMenuStrip = this.sheet;
            note_19.ContextMenuStrip = this.sheet;
            note__1.ContextMenuStrip = this.sheet;
            note__2.ContextMenuStrip = this.sheet;
            note__3.ContextMenuStrip = this.sheet;
            note__4.ContextMenuStrip = this.sheet;
            note__5.ContextMenuStrip = this.sheet;
            note__6.ContextMenuStrip = this.sheet;
        }
        private void Sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (parent.note_now == null) return;
            System.Windows.Forms.Label xian = (System.Windows.Forms.Label)sender;

            if (Hexian_anchored == null | e.X > lastX)
            {
                /*xiaojiexian_0.Location.X/xiaojie_note_num 一拍多长
                (int)Midi.Music_time(parent.note_out)/256.0f 一分音符的几分之几
                xiaojie_note_base*/
                Console.WriteLine("一拍多长：" + this.Width / xiaojie_note_num);
                Console.WriteLine("一分音符的几分之几" + 256 / Midi.Music_time(parent.note_now));
                Console.WriteLine("一拍几分音符：" + xiaojie_note_base);
                Hexian hexian = new Hexian((int)((this.Width / 4 / xiaojie_note_num) / (256 / Midi.Music_time(parent.note_now) / xiaojie_note_base)), this, parent.note_now, last_Hexian);
                if (first_Hexian == null) first_Hexian = hexian;
                last_Hexian = hexian;
                Console.WriteLine(hexian.back_anchored.Width);
                Hexians_num++;
                hexian.Hexian_note_new(xian);
                Hexian_anchored = hexian.back_anchored;
                hexian.created = true;
            }//如果没有和弦就创建和弦
            else
            {
                //检测欲创建的音符是否已存在
                if (!((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_note_have(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note, ((Sheet_tag)xian.Tag).note))
                {
                    //MessageBox.Show("创建");
                    Console.WriteLine("note_" + ((Sheet_tag)xian.Tag).note);
                    ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_note_new(xian);
                }//不存在则创建
                /*else
                {
                    MessageBox.Show("有了");
                }*/
                if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.time != parent.note_now)
                {
                    Console.WriteLine("edit");
                    ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.time = parent.note_now;
                    ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_back_edit_first((int)((this.Width / 4 / xiaojie_note_num) / (256 / Midi.Music_time(parent.note_now) / xiaojie_note_base)), Hexian_anchored.Location);

                }//如果是要修改和弦长度
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
                    xian.BackColor = Color.Red;
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
                    xian.BackColor = Color.Black;
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
            {
                //Console.WriteLine("have");
                //Console.WriteLine(((Hexian.Hexian_note_Tag)((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note.Tag).pinlv);
                //Console.WriteLine("next_firsr_note"+((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.next?.first_note.Text);
                if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note != null) Console.WriteLine("this.first" + ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note.Text);
                if (e.Location.X > lastX) if (Hexian_anchored != null) ((Hexian.Hexian_back_Tag)Hexian_anchored?.Tag).parent.Hexian_note_color_all_leave(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note);
                if (e.Location.X < lastX) if (Hexian_anchored != null) ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_note_color_all_enter(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note);
                if (e.Location.X > Hexian_anchored.Location.X + Hexian_anchored.Width)
                {
                    Console.WriteLine("right move");
                    if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.next != null)
                    {

                        if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.next.created)
                        {
                            Console.WriteLine("right win");
                            Hexian_anchored = ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.next?.back_anchored;
                        }
                    }
                }//鼠标在和弦右边
                else if (e.X < Hexian_anchored.Location.X)
                {
                    if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.last != null)
                    {
                        Console.WriteLine("left move");
                        if (((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.last.created)
                        {
                            Console.WriteLine("left win");
                            Hexian_anchored = ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.last?.back_anchored;
                        }
                    }
                }//鼠标在和弦左边

            }//如果有和弦
            else
            {
                Console.WriteLine("null");
            }//如果没有和弦
            /*if (Hexian_anchored != null)
                if (e.X <= Hexian_anchored.Location.X || e.X >= Hexian_anchored.Location.X + Hexian_anchored.Width)
                {
                    Hexian_anchored?.BringToFront();
                }*/
        }//谱的背景
        private void Sheet_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (((Sheet_tag)label.Tag).xianat)
            {
                if (((Sheet_tag)label.Tag).xianhave)
                {
                    label.BackColor = ((Sheet_tag)label.Tag).color;
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
                    label.BackColor = ((Sheet_tag)label.Tag).color;
                }//有线
                else
                {
                    label.BackColor = ((Sheet_tag)label.Tag).color;
                }//没线
            }//在中间的五条线外
            //label.ForeColor = ((label_tag)label.Tag).color;
        }//谱线
        /*
        private void Sheet_write_Load(object sender, EventArgs e)
        {
            /*this.Capture=true;
            Xiaojie xiaojie = new Xiaojie(4, 4, this);
            Hexian_anchored.ClientRectangle.Contains(MousePosition);
        }//暂时无用
        public void Hexian_MouseEnter(object sender, EventArgs e)
        {
            /*System.Windows.Forms.Label xian = (System.Windows.Forms.Label)sender;
            Hexian_anchored?.BringToFront();
            xian?.SendToBack();
            //if(Hexian_anchored.Equals(sender))
            Hexian_anchored = xian;
        }//和弦的背景,暂时无用
        public void Hexian_MouseLeave(object sender, EventArgs e)
        {
            /*System.Windows.Forms.Label xian = (System.Windows.Forms.Label)sender;
            note_anchored?.BringToFront();
            note_anchored=null;
        }//和弦的背景,暂时无用
        private void Sheet_write_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (Hexian_anchored != null)
                if (e.X <= Hexian_anchored.Location.X || e.X >= Hexian_anchored.Location.X + Hexian_anchored.Width)
                {
                    Hexian_anchored?.BringToFront();
                    //note_anchored = null;
                }
        }//整个控件,暂时无用
        *///暂时无用
        public string Sheet_write_save()
        {
            first_Hexian.Hexian_xiushi_clear();
            return first_Hexian?.Hexian_save();
        }//保存
        public void Sheet_power(object sender, EventArgs e)
        {
            if (Hexian_anchored != null) return;
            ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_power(((ToolStripMenuItem)sender).Tag.ToString());
        }//力度符号
        public void Sheet_Hexian_clear(object sender, EventArgs e)
        {
            if (Hexian_anchored == null) return;
            ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_note_remove_all(((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.first_note);
        }//清除和弦内音符
        public void Sheet_stop(object sender, EventArgs e)
        {
            if (Hexian_anchored == null) return;
            Sheet_Hexian_clear(sender, e);
            ((Hexian.Hexian_back_Tag)Hexian_anchored.Tag).parent.Hexian_stop();
        }//添加休止符
        private void deletenote_Click(object sender, EventArgs e)
        {
            ((Hexian.Note)note.SourceControl).Tag.parent.Hexian_note_remove_own(((Hexian.Note)note.SourceControl));
        }//删除单个音符
        private void 连音线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hexian.Note note = (Hexian.Note)((System.Windows.Forms.ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            ((Hexian.Hexian_note_Tag)note.Tag).note_xiushi_lianyin(true);
        }
    }
}
