using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace musical
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Form2 form2;
        private void button1_Click(object sender, EventArgs e)
        {

            form2 = (Form2)Parent;
            Sheet_write sheet = new Sheet_write(4, 4, form2);
            sheet.Name = "sheet_";
            sheet.SendToBack();
            label1.BackColor = Color.Transparent;
            
            label1.BringToFront();
            label1.BackColor= Color.Transparent;
            this.Controls.Add(sheet);
        }
    }
}
