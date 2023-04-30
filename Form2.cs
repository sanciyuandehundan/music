using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Form2()
        {
            sheet_write1 = new Sheet_write(4,4);
            InitializeComponent();
        }
        public void note_choice(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            if (note_check_number.IsMatch(button.Tag.ToString()))
            {
                note_out_number = int.Parse(button.Tag.ToString());
            }
            note_out_set();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void note_point_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            int i = int.Parse(btn.Tag.ToString());
            if (e.Button == MouseButtons.Left)//左键增加附点
            {
                i++;
                note_out += ".";
            }
            else if (e.Button == MouseButtons.Right)//右键减少附点
            {
                i--;
                if(i > 0)
                {
                    i--;
                    //note_out_point
                }
                else
                {
                    MessageBox.Show("没有附点了");
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
