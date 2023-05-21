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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.note_1 = new System.Windows.Forms.Button();
            this.note_2 = new System.Windows.Forms.Button();
            this.note_4 = new System.Windows.Forms.Button();
            this.note_8 = new System.Windows.Forms.Button();
            this.note_32 = new System.Windows.Forms.Button();
            this.note_16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.note_point = new System.Windows.Forms.Button();
            this.Sheet_write_add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sheet_save = new System.Windows.Forms.Button();
            this.note_64 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "乐谱|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // note_1
            // 
            this.note_1.BackColor = System.Drawing.SystemColors.Control;
            this.note_1.Location = new System.Drawing.Point(22, 30);
            this.note_1.Name = "note_1";
            this.note_1.Size = new System.Drawing.Size(75, 23);
            this.note_1.TabIndex = 1;
            this.note_1.TabStop = false;
            this.note_1.Tag = "1";
            this.note_1.Text = "一分音符";
            this.note_1.UseVisualStyleBackColor = false;
            this.note_1.Click += new System.EventHandler(this.note_choice);
            // 
            // note_2
            // 
            this.note_2.BackColor = System.Drawing.SystemColors.Control;
            this.note_2.Location = new System.Drawing.Point(22, 70);
            this.note_2.Name = "note_2";
            this.note_2.Size = new System.Drawing.Size(75, 23);
            this.note_2.TabIndex = 2;
            this.note_2.TabStop = false;
            this.note_2.Tag = "2";
            this.note_2.Text = "二分音符";
            this.note_2.UseVisualStyleBackColor = false;
            this.note_2.Click += new System.EventHandler(this.note_choice);
            // 
            // note_4
            // 
            this.note_4.BackColor = System.Drawing.SystemColors.Control;
            this.note_4.Location = new System.Drawing.Point(22, 110);
            this.note_4.Name = "note_4";
            this.note_4.Size = new System.Drawing.Size(75, 23);
            this.note_4.TabIndex = 3;
            this.note_4.TabStop = false;
            this.note_4.Tag = "4";
            this.note_4.Text = "四分音符";
            this.note_4.UseVisualStyleBackColor = false;
            this.note_4.Click += new System.EventHandler(this.note_choice);
            // 
            // note_8
            // 
            this.note_8.BackColor = System.Drawing.SystemColors.Control;
            this.note_8.Location = new System.Drawing.Point(22, 150);
            this.note_8.Name = "note_8";
            this.note_8.Size = new System.Drawing.Size(75, 23);
            this.note_8.TabIndex = 4;
            this.note_8.TabStop = false;
            this.note_8.Tag = "8";
            this.note_8.Text = "八分音符";
            this.note_8.UseVisualStyleBackColor = false;
            this.note_8.Click += new System.EventHandler(this.note_choice);
            // 
            // note_32
            // 
            this.note_32.BackColor = System.Drawing.SystemColors.Control;
            this.note_32.Location = new System.Drawing.Point(3, 230);
            this.note_32.Name = "note_32";
            this.note_32.Size = new System.Drawing.Size(113, 23);
            this.note_32.TabIndex = 5;
            this.note_32.TabStop = false;
            this.note_32.Tag = "32";
            this.note_32.Text = "三十二分音符";
            this.note_32.UseVisualStyleBackColor = false;
            this.note_32.Click += new System.EventHandler(this.note_choice);
            // 
            // note_16
            // 
            this.note_16.BackColor = System.Drawing.SystemColors.Control;
            this.note_16.Location = new System.Drawing.Point(11, 190);
            this.note_16.Name = "note_16";
            this.note_16.Size = new System.Drawing.Size(96, 23);
            this.note_16.TabIndex = 6;
            this.note_16.TabStop = false;
            this.note_16.Tag = "16";
            this.note_16.Text = "十六分音符";
            this.note_16.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.note_16.UseVisualStyleBackColor = false;
            this.note_16.Click += new System.EventHandler(this.note_choice);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "note";
            // 
            // note_point
            // 
            this.note_point.Location = new System.Drawing.Point(22, 314);
            this.note_point.Name = "note_point";
            this.note_point.Size = new System.Drawing.Size(75, 23);
            this.note_point.TabIndex = 8;
            this.note_point.TabStop = false;
            this.note_point.Tag = "0";
            this.note_point.Text = "附点：0";
            this.note_point.UseVisualStyleBackColor = true;
            this.note_point.MouseClick += new System.Windows.Forms.MouseEventHandler(this.note_point_MouseClick);
            // 
            // Sheet_write_add
            // 
            this.Sheet_write_add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Sheet_write_add.Location = new System.Drawing.Point(434, 12);
            this.Sheet_write_add.Name = "Sheet_write_add";
            this.Sheet_write_add.Size = new System.Drawing.Size(94, 23);
            this.Sheet_write_add.TabIndex = 3;
            this.Sheet_write_add.Text = "多加一行谱";
            this.Sheet_write_add.UseVisualStyleBackColor = true;
            this.Sheet_write_add.Click += new System.EventHandler(this.Sheet_write_add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "一小节几拍";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "一拍是几分音符";
            // 
            // Sheet_save
            // 
            this.Sheet_save.Location = new System.Drawing.Point(565, 12);
            this.Sheet_save.Name = "Sheet_save";
            this.Sheet_save.Size = new System.Drawing.Size(75, 23);
            this.Sheet_save.TabIndex = 13;
            this.Sheet_save.Text = "保存";
            this.Sheet_save.UseVisualStyleBackColor = true;
            this.Sheet_save.Click += new System.EventHandler(this.Sheet_save_Click);
            // 
            // note_64
            // 
            this.note_64.BackColor = System.Drawing.SystemColors.Control;
            this.note_64.Location = new System.Drawing.Point(3, 270);
            this.note_64.Name = "note_64";
            this.note_64.Size = new System.Drawing.Size(113, 23);
            this.note_64.TabIndex = 14;
            this.note_64.TabStop = false;
            this.note_64.Tag = "64";
            this.note_64.Text = "六十四分音符";
            this.note_64.UseVisualStyleBackColor = false;
            this.note_64.Click += new System.EventHandler(this.note_choice);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.note_1);
            this.panel1.Controls.Add(this.note_2);
            this.panel1.Controls.Add(this.note_64);
            this.panel1.Controls.Add(this.note_4);
            this.panel1.Controls.Add(this.note_8);
            this.panel1.Controls.Add(this.note_16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.note_point);
            this.panel1.Controls.Add(this.note_32);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 448);
            this.panel1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1616, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sheet_save);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sheet_write_add);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "写谱器";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form2_Scroll);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Note_64_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button note_1;
        private System.Windows.Forms.Button note_2;
        private System.Windows.Forms.Button note_4;
        private System.Windows.Forms.Button note_8;
        private System.Windows.Forms.Button note_32;
        private System.Windows.Forms.Button note_16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button note_point;
        private System.Windows.Forms.Button Sheet_write_add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Sheet_save;
        private System.Windows.Forms.Button note_64;
        private System.Windows.Forms.Panel panel1;
    }
}