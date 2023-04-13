using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musical
{
    public partial class Sheet_write : UserControl
    {
        public int note;
        public string sheet;
        public Sheet_write()
        {
            InitializeComponent();
        }

        private void Sheet_MouseClick(object sender, MouseEventArgs e)
        {

        }//确定音符

        private void Sheet_MouseEnter(object sender, EventArgs e)
        {

        }//鼠标进入，显示对应地方的图标

        private void Sheet_MouseLeave(object sender, EventArgs e)
        {

        }//鼠标离开，取消显示
    }
}
