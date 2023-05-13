using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musical
{
    public unsafe partial class Form2 : Form
    {
        private Regex note_check_number = new Regex("^[0-9]+$");
        //private Regex note_check_point = new Regex("^[.]+$");
        public string note_now;
        public void* note_out;
        public int note_out_point;
        public int note_out_number;
        public string sheet_txt = "";
        //public void* a;
        public Form2()
        {
            //sheet_write1 = new Sheet_write(4,4);
            InitializeComponent();
        }
        public void note_choice(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (note_check_number.IsMatch(button.Tag.ToString()))
            {
                note_out_point = 0;
                note_point.Tag = 0;
                note_point.Text = "附点: 0";
                note_out_number = int.Parse(button.Tag.ToString());
            }
            note_out_set();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void note_point_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Button.ToString());
            Button btn = (Button)sender;
            int i = int.Parse(btn.Tag.ToString());
            i++;
            note_now += ".";
            btn.Tag = i;
            btn.Text = "附点: " + i.ToString();
            note_out_point++;
            note_out_set();
        }
        private void note_out_set()
        {
            note_now = note_out_number.ToString();
            for (int i = 0; i < note_out_point; i++)
            {
                note_now += ".";
            }
            label1.Text = note_now;
            fixed (void* note_out_ = note_now) ;

        }

        int sheet_num = 0;
        private void Sheet_write_add_Click(object sender, EventArgs e)
        {
            //if(int.TryParse(textBox1.Text))
            int note_base=0;
            int note_long=0;
            if (!(int.TryParse(textBox2.Text, out note_base) & int.TryParse(textBox1.Text, out note_long)))
            {
                MessageBox.Show("设定未完全");
                return;
            }
            Sheet_write sheet = new Sheet_write(int.Parse(textBox2.Text), int.Parse(textBox1.Text), this/*, ref note_out*/);
            sheet.Name = "sheet_";
            Console.WriteLine(sheet.Width);
            Console.WriteLine(this.Width);
            sheet.Location = new System.Drawing.Point((int)(panel1.Width * 1.2), note_1.Height + note_1.Location.X * 2 + (5 + sheet.Height) * sheet_num);
            this.MinimumSize = new Size((int)(panel1.Width * 1.2) + sheet.Width + 80, panel1.Height);
            Console.WriteLine(sheet.Location.X);
            sheet_num++;
            this.Controls.Add(sheet);
        }

        private void Sheet_save_Click(object sender, EventArgs e)
        {
            sheet_txt = "";
            foreach (Control sheet in this.Controls)
            {
                if (sheet.Name.Equals("sheet_"))
                {
                    sheet_txt += ((Sheet_write)sheet).Sheet_write_save();
                }
            }
            sheet_txt = sheet_txt.TrimEnd('|');
            if (saveFileDialog1.FileName == "")
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                sheet_write();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            sheet_write();
        }

        private void sheet_write()
        {
            File.WriteAllText(saveFileDialog1.FileName, sheet_txt);
        }

        private void Form2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                panel1.Location = new Point(panel1.Location.X, e.OldValue - e.NewValue);
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
           // panel1.Height = Program.form2;
        }
    }
}
