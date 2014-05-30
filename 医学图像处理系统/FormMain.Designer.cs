namespace 医学图像处理系统
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WrokUnitTbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgeTbox = new System.Windows.Forms.TextBox();
            this.SexTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.PatientIdTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Import_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.几何变换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.旋转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像增强处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像的锐化处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.负片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WrokUnitTbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AgeTbox);
            this.groupBox1.Controls.Add(this.SexTbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NameTbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Check);
            this.groupBox1.Controls.Add(this.PatientIdTBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "病人基本信息";
            // 
            // WrokUnitTbox
            // 
            this.WrokUnitTbox.Location = new System.Drawing.Point(73, 145);
            this.WrokUnitTbox.Name = "WrokUnitTbox";
            this.WrokUnitTbox.Size = new System.Drawing.Size(173, 21);
            this.WrokUnitTbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "工作单位：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "年龄：";
            // 
            // AgeTbox
            // 
            this.AgeTbox.Location = new System.Drawing.Point(160, 109);
            this.AgeTbox.Name = "AgeTbox";
            this.AgeTbox.Size = new System.Drawing.Size(33, 21);
            this.AgeTbox.TabIndex = 12;
            // 
            // SexTbox
            // 
            this.SexTbox.Location = new System.Drawing.Point(73, 109);
            this.SexTbox.Name = "SexTbox";
            this.SexTbox.Size = new System.Drawing.Size(34, 21);
            this.SexTbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "性别：";
            // 
            // NameTbox
            // 
            this.NameTbox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTbox.ForeColor = System.Drawing.Color.Black;
            this.NameTbox.Location = new System.Drawing.Point(73, 79);
            this.NameTbox.Name = "NameTbox";
            this.NameTbox.Size = new System.Drawing.Size(120, 21);
            this.NameTbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "病人基本信息：";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(205, 28);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(51, 23);
            this.Check.TabIndex = 3;
            this.Check.Text = "查询";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // PatientIdTBox
            // 
            this.PatientIdTBox.Location = new System.Drawing.Point(73, 28);
            this.PatientIdTBox.Name = "PatientIdTBox";
            this.PatientIdTBox.Size = new System.Drawing.Size(120, 21);
            this.PatientIdTBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "病人病号：";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(26, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(359, 106);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "  编号";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " 就诊时间";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = " 主治医师";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "科室";
            this.columnHeader4.Width = 79;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 335);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "就诊信息";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(210, 176);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(175, 124);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "诊断结果：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "病情描述：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(164, 124);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "  ";
            // 
            // Import_button
            // 
            this.Import_button.BackColor = System.Drawing.Color.Lime;
            this.Import_button.Location = new System.Drawing.Point(667, 556);
            this.Import_button.Name = "Import_button";
            this.Import_button.Size = new System.Drawing.Size(72, 29);
            this.Import_button.TabIndex = 19;
            this.Import_button.Text = "导入影像";
            this.Import_button.UseVisualStyleBackColor = false;
            this.Import_button.Click += new System.EventHandler(this.Import_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.几何变换ToolStripMenuItem,
            this.处理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.还原图像ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 还原图像ToolStripMenuItem
            // 
            this.还原图像ToolStripMenuItem.Name = "还原图像ToolStripMenuItem";
            this.还原图像ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.还原图像ToolStripMenuItem.Text = "还原图像";
            this.还原图像ToolStripMenuItem.Click += new System.EventHandler(this.还原图像ToolStripMenuItem_Click_1);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 几何变换ToolStripMenuItem
            // 
            this.几何变换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.旋转ToolStripMenuItem,
            this.放大ToolStripMenuItem,
            this.缩小ToolStripMenuItem});
            this.几何变换ToolStripMenuItem.Name = "几何变换ToolStripMenuItem";
            this.几何变换ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.几何变换ToolStripMenuItem.Text = "几何变换";
            // 
            // 旋转ToolStripMenuItem
            // 
            this.旋转ToolStripMenuItem.Name = "旋转ToolStripMenuItem";
            this.旋转ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.旋转ToolStripMenuItem.Text = "旋转";
            this.旋转ToolStripMenuItem.Click += new System.EventHandler(this.旋转ToolStripMenuItem_Click);
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.放大ToolStripMenuItem.Text = "放大";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.缩小ToolStripMenuItem.Text = "缩小";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // 处理ToolStripMenuItem
            // 
            this.处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图像增强处理ToolStripMenuItem,
            this.图像的锐化处理ToolStripMenuItem,
            this.负片ToolStripMenuItem});
            this.处理ToolStripMenuItem.Name = "处理ToolStripMenuItem";
            this.处理ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.处理ToolStripMenuItem.Text = "处理算法";
            // 
            // 图像增强处理ToolStripMenuItem
            // 
            this.图像增强处理ToolStripMenuItem.Name = "图像增强处理ToolStripMenuItem";
            this.图像增强处理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图像增强处理ToolStripMenuItem.Text = "增强";
            this.图像增强处理ToolStripMenuItem.Click += new System.EventHandler(this.图像增强处理ToolStripMenuItem_Click);
            // 
            // 图像的锐化处理ToolStripMenuItem
            // 
            this.图像的锐化处理ToolStripMenuItem.Name = "图像的锐化处理ToolStripMenuItem";
            this.图像的锐化处理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图像的锐化处理ToolStripMenuItem.Text = "锐化";
            this.图像的锐化处理ToolStripMenuItem.Click += new System.EventHandler(this.图像的锐化处理ToolStripMenuItem_Click);
            // 
            // 负片ToolStripMenuItem
            // 
            this.负片ToolStripMenuItem.Name = "负片ToolStripMenuItem";
            this.负片ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.负片ToolStripMenuItem.Text = "负片";
            this.负片ToolStripMenuItem.Click += new System.EventHandler(this.负片ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(445, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 495);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 597);
            this.Controls.Add(this.Import_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Click += new System.EventHandler(this.FromMain_Resize);
            this.Resize += new System.EventHandler(this.FromMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PatientIdTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WrokUnitTbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgeTbox;
        private System.Windows.Forms.TextBox SexTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Import_button;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像增强处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图像的锐化处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 负片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 几何变换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 旋转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
    }
}