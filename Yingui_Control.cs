using sanciyuandehundan_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musical
{
    public partial class Yingui_Control : UserControl
    {
        public int control_index;
        public Midi.Yingui yingui;
        public int tempo_minute;
        public int index;
        public int note_base;
        public int instrument;
        public string sheet;
        public int power;
        public bool stop_bool;
        public int xiaojie_num;
        private Form1 form;
        public Yingui_Control()
        {
            InitializeComponent();
            form = Program.form;
        }

        private void panel_start_0_Click(object sender, EventArgs e)
        {
            yingui?.Yingui_play();
        }//开始播放

        private void panel_stop_0_Click(object sender, EventArgs e)
        {
            yingui?.Yingui_pause();
        }//暂停播放

        private void panel_reset_0_Click(object sender, EventArgs e)
        {
            yingui?.Yingui_close();
            yingui?.Yingui_open();
        }//重置播放进度

        public void panel_save_0_Click(object sender, EventArgs e)
        {
            if (sheet != null & panel_speed_0.Text != "" & panel_basenote_0.Text != "" & xiaojie.Text != ""&panel_instrument_1.SelectedNode.Name!="")
            {
                yingui = new Midi.Yingui(
                    sheet,
                    index,
                    int.Parse(panel_instrument_1.SelectedNode.Name),
                    int.Parse(panel_speed_0.Text),
                    int.Parse(panel_basenote_0.Text),
                    int.Parse(xiaojie.Text),
                    panel_power_0.Value,
                    0 - panel_diaoshi_0.SelectedIndex * 20,
                    panel_diaoshi_1.SelectedIndex - 7,
                    panel_key_0.SelectedIndex);
                yingui.Yingui_open();
            }
            else
            {
                MessageBox.Show("参数未设定完全");
            }
        }//设定音轨

        private void panel_choice_0_Click(object sender, EventArgs e)
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
        }//提取乐谱文件的字符串

        private void panel_delete_0_Click(object sender, EventArgs e)
        {
            Program.form.panel_number--;
            control_index = Program.form.Controls.IndexOf(this);
            Program.form.Controls.Remove(this);
            for (int i = control_index; i < Program.form.Controls.Count; i++)
            {
                Program.form.Controls[i].Location = new Point(Program.form.Controls[i].Location.X, Program.form.Controls[i].Location.Y - Program.form.Controls[i].Height);
            }//将底下的全部往上提一个，填补此panel删除后的空格
            Program.form.indexs[index] = false;
            Program.form.panels[index] = null;
            Dispose();
        }//删除此声部

        private void panel_add_0_Click(object sender, EventArgs e)//各种控件的设定需和panel1同步
        {
            Program.form.Panel_add(sender, e);
        }

        private void panel_instrument_1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panel_instrument_1.SelectedNode.BackColor = Color.Violet;
        }

        private void panel_instrument_1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (panel_instrument_1.SelectedNode != null)
            {
                panel_instrument_1.SelectedNode.BackColor = Color.White;
            }
        }

        private void panel_basenote_0_Validating(object sender, CancelEventArgs e)
        {
            MaskedTextBox maskedTextBox = new MaskedTextBox();
            maskedTextBox.Mask = "";
        }
    }
}
