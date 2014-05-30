using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace 医学图像处理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool bExist;
            Mutex MyMutex = new Mutex(true, "OnlyRunOncetime", out bExist);
            if (bExist)
            {
                Application.Run(new Form1());
                MyMutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("程序已经运行！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}