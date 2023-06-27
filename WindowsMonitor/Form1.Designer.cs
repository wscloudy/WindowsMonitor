namespace WindowsMonitor
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            notifyIconMain = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            设置ToolStripMenuItem = new ToolStripMenuItem();
            窗口置顶ToolStripMenuItem = new ToolStripMenuItem();
            选择显示面板ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            circularProgressBarCPU = new CircularProgressBar();
            circularProgressBarMem = new CircularProgressBar();
            groupBoxCPU = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            circularProgressBarCPUt = new CircularProgressBar();
            groupBoxMEM = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            circularProgressBarVM = new CircularProgressBar();
            groupBoxVIDEO = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            circularProgressBarGpuH = new CircularProgressBar();
            circularProgressBarGpuMem = new CircularProgressBar();
            circularProgressBarGpuP = new CircularProgressBar();
            circularProgressBarGpuLoad = new CircularProgressBar();
            textBox1 = new TextBox();
            textBoxCPUx = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            textBoxCPUv = new TextBox();
            label11 = new Label();
            textBoxCPUf = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBoxFan = new TextBox();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBoxCPU.SuspendLayout();
            groupBoxMEM.SuspendLayout();
            groupBoxVIDEO.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIconMain
            // 
            notifyIconMain.ContextMenuStrip = contextMenuStrip1;
            notifyIconMain.Icon = (Icon)resources.GetObject("notifyIconMain.Icon");
            notifyIconMain.Text = "系统资源监控";
            notifyIconMain.Visible = true;
            notifyIconMain.MouseDoubleClick += notifyIconMain_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(100, 22);
            toolStripMenuItem1.Text = "显示";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(100, 22);
            toolStripMenuItem2.Text = "退出";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 681);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1196, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(32, 17);
            toolStripStatusLabel1.Text = "就绪";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(32, 17);
            toolStripStatusLabel2.Text = "CPU";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 设置ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1196, 25);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            设置ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 窗口置顶ToolStripMenuItem, 选择显示面板ToolStripMenuItem, 退出ToolStripMenuItem });
            设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            设置ToolStripMenuItem.Size = new Size(44, 21);
            设置ToolStripMenuItem.Text = "设置";
            // 
            // 窗口置顶ToolStripMenuItem
            // 
            窗口置顶ToolStripMenuItem.CheckOnClick = true;
            窗口置顶ToolStripMenuItem.Name = "窗口置顶ToolStripMenuItem";
            窗口置顶ToolStripMenuItem.Size = new Size(157, 22);
            窗口置顶ToolStripMenuItem.Text = "窗口置顶";
            窗口置顶ToolStripMenuItem.CheckStateChanged += 窗口置顶ToolStripMenuItem_CheckStateChanged;
            // 
            // 选择显示面板ToolStripMenuItem
            // 
            选择显示面板ToolStripMenuItem.Checked = true;
            选择显示面板ToolStripMenuItem.CheckOnClick = true;
            选择显示面板ToolStripMenuItem.CheckState = CheckState.Checked;
            选择显示面板ToolStripMenuItem.Name = "选择显示面板ToolStripMenuItem";
            选择显示面板ToolStripMenuItem.Size = new Size(157, 22);
            选择显示面板ToolStripMenuItem.Text = "显示迷你面板...";
            选择显示面板ToolStripMenuItem.CheckStateChanged += 选择显示面板ToolStripMenuItem_CheckStateChanged;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(157, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // circularProgressBarCPU
            // 
            circularProgressBarCPU.BackColor = Color.Transparent;
            circularProgressBarCPU.Location = new Point(37, 22);
            circularProgressBarCPU.MainColor = Color.LimeGreen;
            circularProgressBarCPU.MaxValue = 100;
            circularProgressBarCPU.Name = "circularProgressBarCPU";
            circularProgressBarCPU.Size = new Size(130, 130);
            circularProgressBarCPU.TabIndex = 6;
            circularProgressBarCPU.Text = "circularProgressBar1";
            circularProgressBarCPU.Unit = "%";
            circularProgressBarCPU.Value = -1;
            // 
            // circularProgressBarMem
            // 
            circularProgressBarMem.BackColor = Color.Transparent;
            circularProgressBarMem.Location = new Point(56, 22);
            circularProgressBarMem.MainColor = Color.LimeGreen;
            circularProgressBarMem.MaxValue = 100;
            circularProgressBarMem.Name = "circularProgressBarMem";
            circularProgressBarMem.Size = new Size(130, 130);
            circularProgressBarMem.TabIndex = 8;
            circularProgressBarMem.Text = "circularProgressBar1";
            circularProgressBarMem.Unit = "%";
            circularProgressBarMem.Value = -1;
            // 
            // groupBoxCPU
            // 
            groupBoxCPU.Controls.Add(label2);
            groupBoxCPU.Controls.Add(label1);
            groupBoxCPU.Controls.Add(circularProgressBarCPUt);
            groupBoxCPU.Controls.Add(circularProgressBarCPU);
            groupBoxCPU.Location = new Point(12, 28);
            groupBoxCPU.Name = "groupBoxCPU";
            groupBoxCPU.Size = new Size(200, 403);
            groupBoxCPU.TabIndex = 10;
            groupBoxCPU.TabStop = false;
            groupBoxCPU.Text = "CPU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 227);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 13;
            label2.Text = "温度";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 12;
            label1.Text = "使用率";
            // 
            // circularProgressBarCPUt
            // 
            circularProgressBarCPUt.BackColor = Color.Transparent;
            circularProgressBarCPUt.Location = new Point(37, 214);
            circularProgressBarCPUt.MainColor = Color.LimeGreen;
            circularProgressBarCPUt.MaxValue = 100;
            circularProgressBarCPUt.Name = "circularProgressBarCPUt";
            circularProgressBarCPUt.Size = new Size(130, 130);
            circularProgressBarCPUt.TabIndex = 11;
            circularProgressBarCPUt.Text = "circularProgressBar1";
            circularProgressBarCPUt.Unit = "℃";
            circularProgressBarCPUt.Value = -1;
            // 
            // groupBoxMEM
            // 
            groupBoxMEM.Controls.Add(label3);
            groupBoxMEM.Controls.Add(label4);
            groupBoxMEM.Controls.Add(circularProgressBarVM);
            groupBoxMEM.Controls.Add(circularProgressBarMem);
            groupBoxMEM.Location = new Point(250, 28);
            groupBoxMEM.Name = "groupBoxMEM";
            groupBoxMEM.Size = new Size(211, 403);
            groupBoxMEM.TabIndex = 11;
            groupBoxMEM.TabStop = false;
            groupBoxMEM.Text = "内存使用率";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 227);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 15;
            label3.Text = "虚拟内存";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 14;
            label4.Text = "物理内存";
            // 
            // circularProgressBarVM
            // 
            circularProgressBarVM.BackColor = Color.Transparent;
            circularProgressBarVM.Location = new Point(56, 214);
            circularProgressBarVM.MainColor = Color.LimeGreen;
            circularProgressBarVM.MaxValue = 100;
            circularProgressBarVM.Name = "circularProgressBarVM";
            circularProgressBarVM.Size = new Size(130, 130);
            circularProgressBarVM.TabIndex = 11;
            circularProgressBarVM.Text = "circularProgressBar2";
            circularProgressBarVM.Unit = "%";
            circularProgressBarVM.Value = -1;
            // 
            // groupBoxVIDEO
            // 
            groupBoxVIDEO.Controls.Add(label8);
            groupBoxVIDEO.Controls.Add(label7);
            groupBoxVIDEO.Controls.Add(label5);
            groupBoxVIDEO.Controls.Add(label6);
            groupBoxVIDEO.Controls.Add(circularProgressBarGpuH);
            groupBoxVIDEO.Controls.Add(circularProgressBarGpuMem);
            groupBoxVIDEO.Controls.Add(circularProgressBarGpuP);
            groupBoxVIDEO.Controls.Add(circularProgressBarGpuLoad);
            groupBoxVIDEO.Location = new Point(500, 28);
            groupBoxVIDEO.Name = "groupBoxVIDEO";
            groupBoxVIDEO.Size = new Size(428, 403);
            groupBoxVIDEO.TabIndex = 12;
            groupBoxVIDEO.TabStop = false;
            groupBoxVIDEO.Text = "显卡";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(203, 32);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 17;
            label8.Text = "显存使用率";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 227);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 16;
            label7.Text = "热点温度";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 227);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 15;
            label5.Text = "功耗";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 32);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 14;
            label6.Text = "GPU使用率";
            // 
            // circularProgressBarGpuH
            // 
            circularProgressBarGpuH.BackColor = Color.Transparent;
            circularProgressBarGpuH.Location = new Point(262, 214);
            circularProgressBarGpuH.MainColor = Color.LimeGreen;
            circularProgressBarGpuH.MaxValue = 100;
            circularProgressBarGpuH.Name = "circularProgressBarGpuH";
            circularProgressBarGpuH.Size = new Size(130, 130);
            circularProgressBarGpuH.TabIndex = 13;
            circularProgressBarGpuH.Text = "circularProgressBar5";
            circularProgressBarGpuH.Unit = "℃";
            circularProgressBarGpuH.Value = -1;
            // 
            // circularProgressBarGpuMem
            // 
            circularProgressBarGpuMem.BackColor = Color.Transparent;
            circularProgressBarGpuMem.Location = new Point(262, 22);
            circularProgressBarGpuMem.MainColor = Color.LimeGreen;
            circularProgressBarGpuMem.MaxValue = 100;
            circularProgressBarGpuMem.Name = "circularProgressBarGpuMem";
            circularProgressBarGpuMem.Size = new Size(130, 130);
            circularProgressBarGpuMem.TabIndex = 12;
            circularProgressBarGpuMem.Text = "circularProgressBar1";
            circularProgressBarGpuMem.Unit = "%";
            circularProgressBarGpuMem.Value = -1;
            // 
            // circularProgressBarGpuP
            // 
            circularProgressBarGpuP.BackColor = Color.Transparent;
            circularProgressBarGpuP.Location = new Point(60, 214);
            circularProgressBarGpuP.MainColor = Color.LimeGreen;
            circularProgressBarGpuP.MaxValue = 100;
            circularProgressBarGpuP.Name = "circularProgressBarGpuP";
            circularProgressBarGpuP.Size = new Size(130, 130);
            circularProgressBarGpuP.TabIndex = 11;
            circularProgressBarGpuP.Text = "circularProgressBar3";
            circularProgressBarGpuP.Unit = "%";
            circularProgressBarGpuP.Value = -1;
            // 
            // circularProgressBarGpuLoad
            // 
            circularProgressBarGpuLoad.BackColor = Color.Transparent;
            circularProgressBarGpuLoad.Location = new Point(60, 22);
            circularProgressBarGpuLoad.MainColor = Color.LimeGreen;
            circularProgressBarGpuLoad.MaxValue = 100;
            circularProgressBarGpuLoad.Name = "circularProgressBarGpuLoad";
            circularProgressBarGpuLoad.Size = new Size(130, 130);
            circularProgressBarGpuLoad.TabIndex = 8;
            circularProgressBarGpuLoad.Text = "circularProgressBar1";
            circularProgressBarGpuLoad.Unit = "%";
            circularProgressBarGpuLoad.Value = -1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 437);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(916, 241);
            textBox1.TabIndex = 13;
            // 
            // textBoxCPUx
            // 
            textBoxCPUx.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCPUx.Location = new Point(6, 47);
            textBoxCPUx.Multiline = true;
            textBoxCPUx.Name = "textBoxCPUx";
            textBoxCPUx.ScrollBars = ScrollBars.Vertical;
            textBoxCPUx.Size = new Size(123, 308);
            textBoxCPUx.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBoxCPUv);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxCPUf);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxFan);
            groupBox1.Controls.Add(textBoxCPUx);
            groupBox1.Location = new Point(934, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 650);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "其他信息";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(139, 369);
            label12.Name = "label12";
            label12.Size = new Size(86, 17);
            label12.TabIndex = 22;
            label12.Text = "CPU核心电压v";
            // 
            // textBoxCPUv
            // 
            textBoxCPUv.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCPUv.Location = new Point(135, 389);
            textBoxCPUv.Multiline = true;
            textBoxCPUv.Name = "textBoxCPUv";
            textBoxCPUv.ScrollBars = ScrollBars.Vertical;
            textBoxCPUv.Size = new Size(110, 255);
            textBoxCPUv.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 369);
            label11.Name = "label11";
            label11.Size = new Size(104, 17);
            label11.TabIndex = 20;
            label11.Text = "CPU核心频率GHz";
            // 
            // textBoxCPUf
            // 
            textBoxCPUf.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCPUf.Location = new Point(6, 389);
            textBoxCPUf.Multiline = true;
            textBoxCPUf.Name = "textBoxCPUf";
            textBoxCPUf.ScrollBars = ScrollBars.Vertical;
            textBoxCPUf.Size = new Size(123, 255);
            textBoxCPUf.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(145, 27);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 17;
            label10.Text = "风扇转速rpm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 27);
            label9.Name = "label9";
            label9.Size = new Size(96, 17);
            label9.TabIndex = 16;
            label9.Text = "CPU核心温度 ℃";
            // 
            // textBoxFan
            // 
            textBoxFan.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFan.Location = new Point(135, 47);
            textBoxFan.Multiline = true;
            textBoxFan.Name = "textBoxFan";
            textBoxFan.ScrollBars = ScrollBars.Vertical;
            textBoxFan.Size = new Size(109, 308);
            textBoxFan.TabIndex = 15;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 703);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(groupBoxVIDEO);
            Controls.Add(groupBoxMEM);
            Controls.Add(groupBoxCPU);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "系统资源监控";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            SizeChanged += FormMain_SizeChanged;
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxCPU.ResumeLayout(false);
            groupBoxCPU.PerformLayout();
            groupBoxMEM.ResumeLayout(false);
            groupBoxMEM.PerformLayout();
            groupBoxVIDEO.ResumeLayout(false);
            groupBoxVIDEO.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIconMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 窗口置顶ToolStripMenuItem;
        private ToolStripMenuItem 选择显示面板ToolStripMenuItem;
        private CircularProgressBar circularProgressBarCPU;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private CircularProgressBar circularProgressBarMem;
        private GroupBox groupBoxCPU;
        private CircularProgressBar circularProgressBarCPUt;
        private GroupBox groupBoxMEM;
        private CircularProgressBar circularProgressBarVM;
        private GroupBox groupBoxVIDEO;
        private CircularProgressBar circularProgressBarGpuH;
        private CircularProgressBar circularProgressBarGpuMem;
        private CircularProgressBar circularProgressBarGpuP;
        private CircularProgressBar circularProgressBarGpuLoad;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private TextBox textBox1;
        private TextBox textBoxCPUx;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox textBoxFan;
        private Label label10;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label label11;
        private TextBox textBoxCPUf;
        private Label label12;
        private TextBox textBoxCPUv;
    }
}