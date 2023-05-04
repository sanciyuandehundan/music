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
    public partial class Form2 : Form
    {
        private Regex note_check_number = new Regex("^[0-9]+$");
        //private Regex note_check_point = new Regex("^[.]+$");
        public string note_out;
        public int note_out_point;
        public int note_out_number;
        Sheet_write a;
        public Form2()
        {
            //sheet_write1 = new Sheet_write(4,4);
            InitializeComponent();
        }
        public void note_choice(object sender,EventArgs e)
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
            note_out += ".";
            btn.Tag = i;
            btn.Text = "附点: " + i.ToString();
            note_out_point++;
            note_out_set();
        }
        private void note_out_set()
        {
            note_out=note_out_number.ToString();
            for(int i=0;i<note_out_point;i++)
            {
                note_out += ".";
            }
            label1.Text = note_out;
        }

        int sheet_num = 0;
        private void Sheet_write_add_Click(object sender, EventArgs e)
        {
            Sheet_write sheet = new Sheet_write(4, 4, this);
            sheet.Name = "sheet_";
            sheet.Location = new System.Drawing.Point(0,30+note_1.Height+note_1.Location.X*2+(10+sheet.Height)*sheet_num);
            sheet_num++;
            this.Controls.Add(sheet);
            a = sheet;
        }

        private void Sheet_save_Click(object sender, EventArgs e)
        {
            foreach(Control sheet in this.Controls)
            {
                if (sheet.Name.Equals("sheet_"))
                {
                    ((Sheet_write)sheet).Sheet_write_save();
                }
            }
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog1.FileName,"");
        }
    }
}
