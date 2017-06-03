using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using AForge;
using AForge.Video.DirectShow;

using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;
namespace client
{
    public partial class SettingForm : Form
    {
        private FilterInfoCollection videoDevices;//摄像头设备


        public SettingForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;


            textBox_UserName.Enabled = false;
            textBox_adr.Enabled = false;
            textBox_IP.Enabled = false;
            textBox_port.Enabled = false;
            comboBox_camera.Enabled = false;
            comboBox_micro.Enabled = false;
            comboBox_size.Enabled = false;
            button_adr.Enabled = false;
            button_save.Enabled = false;

            comboBox_size.SelectedIndex = 0;
            GetVideoDev();
        }
        /// <summary>
        /// 获取摄像头设备
        /// </summary>
        private void GetVideoDev()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                comboBox_camera.Items.Add(device.MonikerString);
            }
            comboBox_camera.SelectedIndex = 0;
        }
        /// <summary>
        /// 获取音频设备
        /// </summary>
        private void GetVioceDev()
        {
            
        }
        /// <summary>
        /// 设置文档
        /// </summary>
        private void WriteInfo()
        {
            XmlTextWriter writer = new XmlTextWriter("setting.xml",null);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartElement("item");
            writer.WriteElementString("UserName", textBox_UserName.Text);
            writer.WriteElementString("IP", textBox_IP.Text);
            writer.WriteElementString("Port", textBox_port.Text);
            writer.WriteElementString("Camera", comboBox_camera.Text);
            writer.WriteElementString("Micro", comboBox_micro.Text);
            writer.WriteElementString("size", comboBox_size.Text);
            writer.WriteElementString("address", textBox_adr.Text);
            writer.WriteEndElement();

            writer.Close();

        }
        /// <summary>
        /// 参数修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_change_Click(object sender, EventArgs e)
        {
            textBox_UserName.Enabled = true;
            textBox_adr.Enabled = true;
            textBox_IP.Enabled = true;
            textBox_port.Enabled = true;
            comboBox_camera.Enabled = true;
            comboBox_micro.Enabled = true;
            comboBox_size.Enabled = true;
            button_adr.Enabled = true;

            button_save.Enabled = true;
        }
        /// <summary>
        /// 参数保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_save_Click(object sender, EventArgs e)
        {
            textBox_UserName.Enabled = false;
            textBox_adr.Enabled = false;
            textBox_IP.Enabled = false;
            textBox_port.Enabled = false;
            comboBox_camera.Enabled = false;
            comboBox_micro.Enabled = false;
            comboBox_size.Enabled = false;
            button_adr.Enabled = false;

            button_save.Enabled = false;

            WriteInfo();
            MessageBox.Show("       保存成功");
            this.Close();
        }
        /// <summary>
        /// 选择保存路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_adr_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_adr.Text = folderBrowserDialog1.SelectedPath;
            }
        }

   
    }
}
