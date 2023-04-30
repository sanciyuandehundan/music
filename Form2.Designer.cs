namespace musical
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.note_1 = new System.Windows.Forms.Button();
            this.note_2 = new System.Windows.Forms.Button();
            this.note_4 = new System.Windows.Forms.Button();
            this.note_8 = new System.Windows.Forms.Button();
            this.note_32 = new System.Windows.Forms.Button();
            this.note_16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.note_point = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sheet_write1
            // 
            this.sheet_write1 = new Sheet_write(4, 4);
            this.sheet_write1.BackColor = System.Drawing.SystemColors.Control;
            this.sheet_write1.Location = new System.Drawing.Point(13, 173);
            this.sheet_write1.Name = "sheet_write1";
            this.sheet_write1.Size = new System.Drawing.Size(1593, 365);
            this.sheet_write1.TabIndex = 13;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem2.Text = "!!!!!!";
            // 
            // note_1
            // 
            this.note_1.BackColor = System.Drawing.SystemColors.Control;
            this.note_1.Location = new System.Drawing.Point(12, 21);
            this.note_1.Name = "note_1";
            this.note_1.Size = new System.Drawing.Size(75, 23);
            this.note_1.TabIndex = 1;
            this.note_1.Tag = "1";
            this.note_1.Text = "一分音符";
            this.note_1.UseVisualStyleBackColor = false;
            this.note_1.Click += new System.EventHandler(this.note_choice);
            // 
            // note_2
            // 
            this.note_2.BackColor = System.Drawing.SystemColors.Control;
            this.note_2.Location = new System.Drawing.Point(100, 21);
            this.note_2.Name = "note_2";
            this.note_2.Size = new System.Drawing.Size(75, 23);
            this.note_2.TabIndex = 2;
            this.note_2.Tag = "2";
            this.note_2.Text = "二分音符";
            this.note_2.UseVisualStyleBackColor = false;
            this.note_2.Click += new System.EventHandler(this.note_choice);
            // 
            // note_4
            // 
            this.note_4.BackColor = System.Drawing.SystemColors.Control;
            this.note_4.Location = new System.Drawing.Point(191, 21);
            this.note_4.Name = "note_4";
            this.note_4.Size = new System.Drawing.Size(75, 23);
            this.note_4.TabIndex = 3;
            this.note_4.Tag = "4";
            this.note_4.Text = "四分音符";
            this.note_4.UseVisualStyleBackColor = false;
            this.note_4.Click += new System.EventHandler(this.note_choice);
            // 
            // note_8
            // 
            this.note_8.BackColor = System.Drawing.SystemColors.Control;
            this.note_8.Location = new System.Drawing.Point(277, 21);
            this.note_8.Name = "note_8";
            this.note_8.Size = new System.Drawing.Size(75, 23);
            this.note_8.TabIndex = 4;
            this.note_8.Tag = "8";
            this.note_8.Text = "八分音符";
            this.note_8.UseVisualStyleBackColor = false;
            this.note_8.Click += new System.EventHandler(this.note_choice);
            // 
            // note_32
            // 
            this.note_32.BackColor = System.Drawing.SystemColors.Control;
            this.note_32.Location = new System.Drawing.Point(474, 21);
            this.note_32.Name = "note_32";
            this.note_32.Size = new System.Drawing.Size(113, 23);
            this.note_32.TabIndex = 5;
            this.note_32.Tag = "32";
            this.note_32.Text = "三十二分音符";
            this.note_32.UseVisualStyleBackColor = false;
            this.note_32.Click += new System.EventHandler(this.note_choice);
            // 
            // note_16
            // 
            this.note_16.BackColor = System.Drawing.SystemColors.Control;
            this.note_16.Location = new System.Drawing.Point(364, 21);
            this.note_16.Name = "note_16";
            this.note_16.Size = new System.Drawing.Size(96, 23);
            this.note_16.TabIndex = 6;
            this.note_16.Tag = "16";
            this.note_16.Text = "十六分音符";
            this.note_16.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.note_16.UseVisualStyleBackColor = false;
            this.note_16.Click += new System.EventHandler(this.note_choice);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(746, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "note";
            // 
            // note_point
            // 
            this.note_point.ContextMenuStrip = this.contextMenuStrip1;
            this.note_point.Location = new System.Drawing.Point(622, 21);
            this.note_point.Name = "note_point";
            this.note_point.Size = new System.Drawing.Size(75, 23);
            this.note_point.TabIndex = 8;
            this.note_point.Tag = "0";
            this.note_point.Text = "附点：0";
            this.note_point.UseVisualStyleBackColor = true;
            this.note_point.Click += new System.EventHandler(this.note_point_Click);
            this.note_point.MouseClick += new System.Windows.Forms.MouseEventHandler(this.note_point_MouseClick);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(880, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "多加一行谱";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1013, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 25);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "一小节几拍";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1120, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 25);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "一拍是几分音符";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1616, 805);
            this.Controls.Add(this.sheet_write1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.note_point);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note_16);
            this.Controls.Add(this.note_32);
            this.Controls.Add(this.note_8);
            this.Controls.Add(this.note_4);
            this.Controls.Add(this.note_2);
            this.Controls.Add(this.note_1);
            this.Name = "Form2";
            this.Text = "写谱器";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button note_1;
        private System.Windows.Forms.Button note_2;
        private System.Windows.Forms.Button note_4;
        private System.Windows.Forms.Button note_8;
        private System.Windows.Forms.Button note_32;
        private System.Windows.Forms.Button note_16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button note_point;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Sheet_write sheet_write1;
    }
}