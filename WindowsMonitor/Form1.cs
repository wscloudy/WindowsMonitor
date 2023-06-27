using LibreHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware.Cpu;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsMonitor
{
    public partial class FormMain : Form
    {
        private bool isRun = true;
        private LibreHardwareMonitor.Hardware.Computer computer = new LibreHardwareMonitor.Hardware.Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsMotherboardEnabled = true,
            IsControllerEnabled = true,
            IsNetworkEnabled = true,
            IsStorageEnabled = true
        };
        private string info = "";
        string cpux = "";
        string fan = "";
        string cpuclock = "";
        string cpuv = "";
        private Form2 form2 = new Form2();

        public FormMain()
        {
            //׼����������ʱ����
            this.WindowState = FormWindowState.Minimized;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //����ʱ����������
            this.Visible = false;
            notifyIconMain.Visible = true;

            //�������㴰��
            form2.Show();

            computer.Open();
            Thread.Sleep(1000);
            Thread th = new Thread(() =>
            {
                while (isRun)
                {
                    GetSystemInfo();
                    Thread.Sleep(3000);
                }
                computer.Close();
            });
            th.IsBackground = true;
            th.Start();

        }

        public void GetSystemInfo()
        {
            //ˢ�½���
            this.Invoke(new Action(() =>
            {
                circularProgressBarMem.Value = (int)SystemInfo.MemoryHelper.GetMemoryValue().UsedPercentage;
                if (circularProgressBarMem.Value > 80)
                    groupBoxMEM.ForeColor = Color.Red;
                else
                    groupBoxMEM.ForeColor = Color.Black;
                toolStripStatusLabel1.Text = "�ڴ�ռ��: " + ((double)SystemInfo.MemoryHelper.GetMemoryValue().UsedPhysicalMemory / 1024 / 1024 / 1024).ToString("f1") + "GB / " + SystemInfo.MemoryHelper.GetMemoryValue().TotalPhysicalMemory / 1024 / 1024 / 1024 + "GB";
            }));

            computer.Accept(new UpdateVisitor());
            this.Invoke(new Action(() =>
            {
                info = "";
                cpux = "";
                fan = "";
                cpuclock = "";
                cpuv = "";
                foreach (IHardware hardware in computer.Hardware)
                {
                    foreach (IHardware subhardware in hardware.SubHardware)
                    {
                        foreach (ISensor sensor in subhardware.Sensors)
                        {
                            HardwareFind(hardware, sensor);
                        }
                    }

                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        HardwareFind(hardware, sensor);
                    }
                }
                textBox1.Text = info;
                textBoxCPUx.Text = cpux;
                textBoxFan.Text = fan;
                textBoxCPUf.Text = cpuclock;
                textBoxCPUv.Text = cpuv;
                //notifyIconMain.BalloonTipText = info;
                //notifyIconMain.ShowBalloonTip(1);
            }));
            //computer.Close();
        }

        private void HardwareFind(IHardware hardware, ISensor sensor)
        {
            if (hardware.HardwareType == HardwareType.Cpu)
            {

                if (sensor.SensorType == SensorType.Temperature)
                {
                    if (sensor.Name == "CPU Package")
                    {
                        if (sensor.Value > 75)
                            groupBoxCPU.ForeColor = Color.Red;
                        else
                            groupBoxCPU.ForeColor = Color.Black;
                        circularProgressBarCPUt.Value = (int)(sensor.Value == null ? -1 : sensor.Value.Value);
                        form2.CPUt = circularProgressBarCPUt.Value;
                        if (this.Visible == true) info += "CPU�¶ȣ�" + circularProgressBarCPUt.Value + "��" + "\r\n";
                    }
                    else if (!sensor.Name.Contains("TjMax"))
                    {
                        cpux += sensor.Name.Replace("CPU Core ", "") + " = " + (int)(sensor.Value == null ? -1 : sensor.Value.Value) + "\r\n";
                    }
                }
                else if (sensor.SensorType == SensorType.Load)
                {
                    if (sensor.Name == "CPU Total")
                    {
                        circularProgressBarCPU.Value = (int)(sensor.Value == null ? -1 : sensor.Value.Value);
                    }
                }
                else if (sensor.SensorType == SensorType.Power)
                {
                    if (sensor.Name == "CPU Package")
                    {
                        toolStripStatusLabel2.Text = "CPU: " + (sensor.Value == null ? -1 : sensor.Value.Value).ToString("f2") + "W";
                    }
                }
                else if (sensor.SensorType == SensorType.Clock)
                {
                    cpuclock += sensor.Name.Replace("CPU Core ", "") + " = " + ((sensor.Value == null ? -1 : sensor.Value.Value) / 1000).ToString("f1") + "\r\n";
                }
                else if (sensor.SensorType == SensorType.Voltage)
                {
                    cpuv += sensor.Name.Replace("CPU Core ", "") + " = " + (sensor.Value == null ? -1 : sensor.Value.Value).ToString("f3") + "\r\n";
                }
            }
            else if (hardware.HardwareType == HardwareType.GpuAmd || hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuIntel)
            {
                if (sensor.SensorType == SensorType.Temperature)
                {
                    if (sensor.Name == "GPU Hot Spot")
                    {
                        if (sensor.Value > 85)
                            groupBoxVIDEO.ForeColor = Color.Red;
                        else
                            groupBoxVIDEO.ForeColor = Color.Black;
                        circularProgressBarGpuH.Value = (int)(sensor.Value == null ? -1 : sensor.Value.Value);
                        form2.GPUt = circularProgressBarGpuH.Value;
                        if (this.Visible == true) info += "GPU�¶ȣ�" + circularProgressBarGpuH.Value + "��" + "\r\n";
                    }
                }
                else if (sensor.SensorType == SensorType.Load)
                {
                    if (sensor.Name == "GPU Core")
                    {
                        circularProgressBarGpuLoad.Value = (int)(sensor.Value == null ? -1 : sensor.Value.Value);
                    }
                    else if (sensor.Name == "GPU Memory")
                    {
                        circularProgressBarGpuMem.Value = (int)(sensor.Value == null ? -1 : sensor.Value.Value);
                    }
                    else if (sensor.Name == "GPU Power")
                    {
                        circularProgressBarGpuP.Value = (int)(sensor.Value == null ? -1 : sensor.Value.Value);
                    }
                }
            }
            else if (hardware.HardwareType == HardwareType.Memory)
            {
                if (sensor.SensorType == SensorType.Load)
                {
                    if (sensor.Name == "Virtual Memory")
                    {
                        if (sensor.Value > 90)
                            groupBoxMEM.ForeColor = Color.Red;
                        else
                            groupBoxMEM.ForeColor = Color.Black;
                        circularProgressBarVM.Value = (int)(sensor.Value == null ? -1 : sensor.Value.Value);
                    }
                }
            }
            else if (hardware.HardwareType == HardwareType.Storage)
            {
                if (sensor.SensorType == SensorType.Temperature)
                {
                    if (sensor.Name == "Temperature")
                    {
                        if (this.Visible == true) info += hardware.Name + "�¶ȣ�" + (int)(sensor.Value == null ? -1 : sensor.Value.Value) + "��" + "\r\n";
                    }
                }
            }
            //����
            if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAmd || hardware.HardwareType == HardwareType.Cooler ||
                    hardware.HardwareType == HardwareType.Cpu || hardware.HardwareType == HardwareType.Motherboard)
            {
                if (sensor.SensorType == SensorType.Fan)
                {
                    if (sensor.Name.Contains("Fan"))
                    {
                        fan += sensor.Name + " = " + (int)(sensor.Value == null ? -1 : sensor.Value.Value) + "\r\n";
                    }
                }
            }
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRun = false;
            Thread.Sleep(1100);
            System.Environment.Exit(0);
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isRun = false;
            Thread.Sleep(1100);
            System.Environment.Exit(0);
        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            isRun = false;
            Thread.Sleep(1100);
            System.Environment.Exit(0);
        }

        private void �����ö�ToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (�����ö�ToolStripMenuItem.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void ѡ����ʾ���ToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (ѡ����ʾ���ToolStripMenuItem.Checked)
            {
                form2.Visible = true;
            }
            else
            {
                form2.Visible = false;
            }
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    }
}