using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace 医学图像处理系统
{
   public class Process
    {

       public void  Lapulas(Image srcImage, PictureBox pictureBox1)
      {
          int[] R=new int[9];
          int[] G = new int[9];
          int[] B= new int[9];
          int iGreen, iBlue, iRed;
          Bitmap bt = new Bitmap(srcImage);
          Bitmap bt1= new Bitmap(srcImage);
          for (int i = 1; i < bt.Width - 1; i++)
          {
              for (int j = 1; j < bt.Height - 1; j++)
              {
                  R[1] = bt.GetPixel(i - 1, j - 1).R;
                  R[2] = bt.GetPixel(i, j - 1).R;
                  R[3] = bt.GetPixel(i + 1, j - 1).R;
                  R[4] = bt.GetPixel(i - 1, j).R;
                  R[5] = bt.GetPixel(i + 1, j).R;
                  R[6] = bt.GetPixel(i - 1, j + 1).R;
                  R[7] = bt.GetPixel(i, j + 1).R;
                  R[8] = bt.GetPixel(i + 1, j + 1).R;
                  iRed = bt.GetPixel(i, j).R;

                  G[1] = bt.GetPixel(i - 1, j - 1).G;
                  G[2] = bt.GetPixel(i, j - 1).G;
                  G[3] = bt.GetPixel(i + 1, j - 1).G;
                  G[4] = bt.GetPixel(i - 1, j).G;
                  G[5] = bt.GetPixel(i + 1, j).G;
                  G[6] = bt.GetPixel(i - 1, j + 1).G;
                  G[7] = bt.GetPixel(i, j + 1).G;
                  G[8] = bt.GetPixel(i + 1, j + 1).G;
                  iGreen = bt.GetPixel(i, j).G;

                  B[1] = bt.GetPixel(i - 1, j - 1).B;
                  B[2] = bt.GetPixel(i, j - 1).B;
                  B[3] = bt.GetPixel(i + 1, j - 1).B;
                  B[4] = bt.GetPixel(i - 1, j).B;
                  B[5] = bt.GetPixel(i + 1, j).B;
                  B[6] = bt.GetPixel(i - 1, j + 1).B;
                  B[7] = bt.GetPixel(i, j + 1).B;
                  B[8] = bt.GetPixel(i + 1, j + 1).B;
                  iBlue = bt.GetPixel(i, j).B;

                  iGreen = iGreen + Calc_sum(G,iGreen)/3;
                  iBlue= iBlue + Calc_sum(B,iBlue) / 3;
                  iRed= iRed + Calc_sum(R,iRed) / 3;
  
                  iGreen = iGreen > 255 ? 255 : iGreen;
                  iGreen = iGreen< 0 ? 0 : iGreen;
                  iBlue = iBlue < 0 ? 0 : iBlue;
                  iBlue = iBlue > 255 ? 255 : iBlue;
                  iRed = iRed > 255 ? 255 : iRed;
                  iRed = iRed <0  ? 0 : iRed;

                  bt1.SetPixel(i, j, Color.FromArgb(iRed, iGreen, iBlue));
              }
               pictureBox1.Refresh();
               pictureBox1.Image = bt1;
              }
             MessageBox.Show("处理完毕！", "系统提示");
      }
       private int Calc_sum(int []temp,int iRGB)
       {
           int sum=8*iRGB;
           for(int i = 1; i < 9; i++)
           {
               sum -= temp[i];
           }
           return sum;
       }

   }
}
