using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace 医学图像处理系统
{
    public partial class Form1 : Form
    {
        private string strPassword;
        private string strUserName;
        public FormMain formain;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
         {
             switch (m.Msg)
             {
                 case 0x10:
                     {
                         if (MessageBox.Show("确定退出登录系统吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                         {
                             return;
                         }
                     }
                     break;
             }
             base.WndProc(ref m);
         }
        private void Login_Click(object sender, EventArgs e)
        {
           strUserName=UserNameTxt.Text.Trim().ToString();
           strPassword = PaaswTxt.Text.Trim().ToString();
           if (strUserName == "")
           {
               MessageBox.Show("请输入用户名！", "软件提示", 
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
           }
           else if(strPassword=="")
           {
               MessageBox.Show("请输入密码！", "软件提示",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
           }
           this.Visible=false;
           formain = new FormMain();
           formain.Show();
           this.notifyIcon1.Visible = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UserNameTxt.Text = "";
            PaaswTxt.Text = "";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formain.Visible = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.formain.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Enter_Press()
        {

        }

        private void UserNameTxt_Enter(object sender, EventArgs e)
        {
           // MessageBox.Show("hello");
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = this.Text;
                string ShortFileName = FileName.Substring(FileName.LastIndexOf("\\") + 1);
                //打开子键节点
                RegistryKey MyReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (MyReg == null)
                {//如果子键节点不存在，则创建之
                    MyReg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                }
                //在注册表中设置自启动程序
                MyReg.SetValue(ShortFileName, FileName);
                MessageBox.Show("设置自启动程序操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch (Exception Err)
            {
                MessageBox.Show("写注册表操作发生错误！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}