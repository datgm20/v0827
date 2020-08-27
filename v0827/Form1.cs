using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx0 = rand.Next(-20,21);
        int vy0 = rand.Next(-20,21);
        int vx1 = rand.Next(-20, 21);
        int vy1 = rand.Next(-20, 21);
        int vx2 = rand.Next(-20, 21);
        int vy2 = rand.Next(-20, 21);
        int point = 100;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);
            label5.Left = rand.Next(ClientSize.Width - label5.Width);
            label5.Top = rand.Next(ClientSize.Height - label5.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point--;
            label3.Text = "Score " + point;
            
            label1.Left += vx0;
            label1.Top += vy0;
            label4.Left += vx1;
            label4.Top += vy1;
            label5.Left += vx2;
            label5.Top += vy2;

            if (label1.Left < 0)
            {
                vx0 = Math.Abs(vx0);
            }
            if (label1.Top < 0)
            {
                vy0 = Math.Abs(vy0);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx0 = -Math.Abs(vx0);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy0 = -Math.Abs(vy0);
            }

            if (label4.Left < 0)
            {
                vx1 = Math.Abs(vx1);
            }
            if (label4.Top < 0)
            {
                vy1 = Math.Abs(vy1);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx1 = -Math.Abs(vx1);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy1 = -Math.Abs(vy1);
            }

            if (label5.Left < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            if (label5.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            if (label5.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label5.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
            }

            // 2次元クラスPoint型の変数mpを宣言
            Point mp = MousePosition;

            // mpに、マウスのフォーム座標を取り出す。
            //// MousePositionにマウス座標のスクリーン左上からのX、Yが入っている。
            //// PointToClient()を使うと、スクリーン座標を、フォーム座標に変換できる。
            mp = PointToClient(mp);

            // ラベルに座標を表示
            //// 変換したフォーム座標は、mp.X、mp.Yで取り出せる。
            label2.Text = "" + mp.X + "," + mp.Y;

            if ((mp.X >= label1.Left)
                && (mp.X < label1.Right)
                && (mp.Y >= label1.Top)
                && (mp.Y < label1.Bottom)
                )
            {
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
