using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 医学图像处理系统
{
    public partial class FormMain : Form
    {
        private string StrPath;
        private Bitmap MyBitmap;
        public Doctor doctor;
        public Process process;
        public Patient pat;
        public int iMaxWitdh=509;
        public int iMaxHeight=495;
        public int iPositionX=445;
        public int iPositionY=46;
        public Connection conn;
        private int iState;
        public int count = 1;

        public int IState
        {
            get { return iState; }
            set { iState = value; }
        }
        public FormMain()
        {
            InitializeComponent();
            process = new Process();
           // this.NameTbox.Enabled = false;
          //  this.AgeTbox.Enabled = false;
          //  this.SexTbox.Enabled = false;
         //   this.WrokUnitTbox.Enabled = false;
            conn = new Connection();
            doctor = new Doctor();
            pat = new Patient();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x10:
                    {
                        this.Visible = false;
                          return;
                    }
    
            }
            base.WndProc(ref m);
        }
        private void Check_Click(object sender, EventArgs e)
        {
            if (PatientIdTBox.Text == "")
           {
                MessageBox.Show("错误，没有输入病人的编号！", "系统提示" ,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            PatientInfo patinfo = pat.GetPatient_Info(PatientIdTBox.Text.ToString());
            if (patinfo == null)
            {
                MessageBox.Show("未找有相关记录！", "系统提示", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.NameTbox.Text = patinfo.StrName;
            this.SexTbox.Text = patinfo.StrSex;
            this.AgeTbox.Text = patinfo.IAge.ToString();
            this.WrokUnitTbox.Text = patinfo.StrWorkUnit;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  ListViewItem   i= this.listView1.SelectedItems[0];
           // MessageBox.Show(i.Text);
            for (int i = this.listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = this.listView1.SelectedItems[i];
                MessageBox.Show(item.Text);

            }
        }
        private void FromMain_Resize(object sender, EventArgs e)
        {

        }

        private void Import_button_Click(object sender, EventArgs e)
        {
            int x,y,w,h;
            x = iPositionX;
            y = iPositionY;
            w=iMaxWitdh;
            h=iMaxHeight;

            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.RestoreDirectory = true;
            ofdlg.Filter = "所有图像文件 | *.bmp; *.pcx; *.png; *.jpg; *.gif;" +
                "*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf|" +
                "位图( *.bmp; *.jpg; *.png;...) | *.bmp; *.pcx; *.png; *.jpg; *.gif; *.tif; *.ico|" +
                "矢量图( *.wmf; *.eps; *.emf;...) | *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StrPath = ofdlg.FileName;
                    //把打开的图像赋给Bitmap变量
                    Bitmap SrcBitmap = new Bitmap(ofdlg.FileName.ToString());
                    this.Picture_Reset(SrcBitmap,ref w, ref h, ref x, ref y);
                    pictureBox1.Height = h;
                    pictureBox1.Width = w;
                    this.pictureBox1.Location = new System.Drawing.Point(x, y);
                    MyBitmap = new Bitmap(SrcBitmap, w, h);
                    this.pictureBox1.Image = MyBitmap;//在控件上显示图像          
              }

                catch
                {
                    //提示对话框
                    MessageBox.Show( "打开图像文件错误！", 
                        "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 图像增强处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("错误，没有导入图片！", 
                    "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          process.Lapulas(pictureBox1.Image, pictureBox1);
        }

        private void 负片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("错误，没有导入图片！",
                    "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int R, G, B;
            Bitmap tempBitmap = new Bitmap(pictureBox1.Image);
            for (int i = 0; i < tempBitmap.Width; i++)
            {
                for (int j = 0; j < tempBitmap.Height; j++)
                {
                    R = 255 - tempBitmap.GetPixel(i, j).R;
                    G = 255 - tempBitmap.GetPixel(i, j).G;
                    B = 255 - tempBitmap.GetPixel(i, j).B;
                    tempBitmap.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pictureBox1.Refresh();
                pictureBox1.Image = tempBitmap;
            }
            MessageBox.Show("处理完毕！", "系统提示", MessageBoxButtons.OK);
        }

        private void 旋转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int itemp=pictureBox1.Width;
                pictureBox1.Width = pictureBox1.Height;
                pictureBox1.Height = itemp;
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);//图像的旋转
                pictureBox1.Image = bitmap;

            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void xiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 图像的锐化处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 还原图像ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int x, y;
    ;
            if (MyBitmap != null)
            {
                pictureBox1.Height = MyBitmap.Height;
                pictureBox1.Width = MyBitmap.Width;
                x = iPositionX + (iMaxWitdh - MyBitmap.Width) / 2;
                y = iPositionY + (iMaxHeight - MyBitmap.Height) / 2;
                this.pictureBox1.Location = new System.Drawing.Point(x, y);
                pictureBox1.Image = MyBitmap;
            }
        }

        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x, y, w, h;
            x = iPositionX;
            y = iPositionY;
            w = iMaxWitdh;
            h = iMaxHeight;
        }
   

        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x, y, w, h;
            x = iPositionX;
            y = iPositionY;
            w = iMaxWitdh;
            h = iMaxHeight;

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("错误，没有导入图片！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pictureBox1.Width >= iMaxWitdh || pictureBox1.Height >= iMaxHeight)
            {
                MessageBox.Show("已经是最大不能再放大！", 
                    "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Bitmap tempBitmap = new Bitmap(pictureBox1.Image);
           
                w=Convert.ToInt32(pictureBox1.Width * 1.2);
                if (w >= iMaxWitdh) w = iMaxWitdh;
                h = Convert.ToInt32(pictureBox1.Height * 1.2);
                if (h >= iMaxWitdh) h = iMaxHeight;
                ; x = iPositionX + (iMaxWitdh - w) / 2;
                y = iPositionY + (iMaxHeight - h) / 2;
                pictureBox1.Height = h;
                pictureBox1.Width = w;
                this.pictureBox1.Location = new System.Drawing.Point(x, y);
                Bitmap bt = new Bitmap(tempBitmap, w, h);
                this.pictureBox1.Image = bt;//在控件上显示图像

            }
        }
        private void Picture_Reset(Bitmap bt, ref int w, ref int h, ref int x, ref int y)
        {
            if (bt.Width <= iMaxWitdh)
            {
                w = bt.Width;
                x = iPositionX + (iMaxWitdh - bt.Width) / 2;

            }
            if (bt.Height <= iMaxHeight)
            {
                h = bt.Height;
                y = iPositionY + (iMaxHeight - bt.Height) / 2;
            }
        }

    }
}