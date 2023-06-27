namespace WindowsMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            labelCPU = new Label();
            labelGPU = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 0;
            label1.Text = "GPU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(4, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "CPU";
            // 
            // labelCPU
            // 
            labelCPU.AutoSize = true;
            labelCPU.BackColor = Color.Transparent;
            labelCPU.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPU.Location = new Point(33, 9);
            labelCPU.Name = "labelCPU";
            labelCPU.Size = new Size(29, 17);
            labelCPU.TabIndex = 2;
            labelCPU.Text = "100";
            // 
            // labelGPU
            // 
            labelGPU.AutoSize = true;
            labelGPU.BackColor = Color.Transparent;
            labelGPU.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPU.Location = new Point(33, 26);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(29, 17);
            labelGPU.TabIndex = 3;
            labelGPU.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(57, 26);
            label5.Name = "label5";
            label5.Size = new Size(20, 17);
            label5.TabIndex = 5;
            label5.Text = "℃";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(57, 9);
            label6.Name = "label6";
            label6.Size = new Size(20, 17);
            label6.TabIndex = 4;
            label6.Text = "℃";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(83, 50);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(labelGPU);
            Controls.Add(labelCPU);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.Manual;
            Text = "系统资源监控mini";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            MouseUp += Form2_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelCPU;
        private Label labelGPU;
        private Label label5;
        private Label label6;
    }
}