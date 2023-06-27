using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WindowsMonitor
{
    public partial class Form2 : Form
    {
        //传输数据
        public int CPUt
        {
            set
            {
                labelCPU.Text = value.ToString();
                if (value > 80)
                {
                    labelCPU.ForeColor = Color.Red;
                }
                else
                {
                    labelCPU.ForeColor = Color.Green;
                }
            }
        }
        public int GPUt
        {
            set
            {
                labelGPU.Text = value.ToString();
                if (value > 80)
                {
                    labelGPU.ForeColor = Color.Red;
                }
                else
                {
                    labelGPU.ForeColor = Color.Green;
                }
            }
        }

        /// <summary>
        /// 鼠标按下时在窗口中的x坐标
        /// </summary>
        private int mouseAtX;

        /// <summary>
        /// 鼠标按下时在窗口中的y坐标
        /// </summary>
        private int mouseAtY;

        /// <summary>
        /// 鼠标是否在窗口上是按下状态
        /// </summary>
        private bool isMouseDown = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.f2x;
            Top = Properties.Settings.Default.f2y;
            if (Left == 0 && Top == 0)
            {
                Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width - 50;
                Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2;
            }
            //this.BackColor = Color.Blue;
            //this.TransparencyKey = Color.Blue;
            this.Opacity = 0.6;
            this.TopMost = true;
            this.ShowInTaskbar = false;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.SizeAll;
            mouseAtX = e.X;
            mouseAtY = e.Y;
            isMouseDown = true;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Left = MousePosition.X - mouseAtX;
                Top = MousePosition.Y - mouseAtY;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.f2x = Left;
            Properties.Settings.Default.f2y = Top;
            Properties.Settings.Default.Save();
            Cursor = Cursors.Default;
            isMouseDown = false;
        }
    }
}
