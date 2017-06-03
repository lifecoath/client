namespace client
{
    partial class SettingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_micro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_adr = new System.Windows.Forms.Button();
            this.textBox_adr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_camera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_UserName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络设置";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(77, 39);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(293, 21);
            this.textBox_UserName.TabIndex = 5;
            this.textBox_UserName.Text = "User001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "用户名：";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(294, 66);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(76, 21);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = "1111";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(77, 66);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(144, 21);
            this.textBox_IP.TabIndex = 2;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器Ip：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_micro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button_adr);
            this.groupBox2.Controls.Add(this.textBox_adr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_size);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_camera);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "视频参数设置";
            // 
            // comboBox_micro
            // 
            this.comboBox_micro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_micro.FormattingEnabled = true;
            this.comboBox_micro.Location = new System.Drawing.Point(77, 59);
            this.comboBox_micro.Name = "comboBox_micro";
            this.comboBox_micro.Size = new System.Drawing.Size(293, 20);
            this.comboBox_micro.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "麦克风：";
            // 
            // button_adr
            // 
            this.button_adr.Location = new System.Drawing.Point(336, 118);
            this.button_adr.Name = "button_adr";
            this.button_adr.Size = new System.Drawing.Size(34, 23);
            this.button_adr.TabIndex = 8;
            this.button_adr.Text = "…";
            this.button_adr.UseVisualStyleBackColor = true;
            this.button_adr.Click += new System.EventHandler(this.button_adr_Click);
            // 
            // textBox_adr
            // 
            this.textBox_adr.Location = new System.Drawing.Point(77, 118);
            this.textBox_adr.Name = "textBox_adr";
            this.textBox_adr.Size = new System.Drawing.Size(253, 21);
            this.textBox_adr.TabIndex = 5;
            this.textBox_adr.Text = "E:/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "保存路径：";
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            "1024*768",
            "960*780"});
            this.comboBox_size.Location = new System.Drawing.Point(77, 86);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(293, 20);
            this.comboBox_size.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "分辨率：";
            // 
            // comboBox_camera
            // 
            this.comboBox_camera.FormattingEnabled = true;
            this.comboBox_camera.Location = new System.Drawing.Point(77, 32);
            this.comboBox_camera.Name = "comboBox_camera";
            this.comboBox_camera.Size = new System.Drawing.Size(293, 20);
            this.comboBox_camera.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "摄像头：";
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(226, 311);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 4;
            this.button_change.Text = "修改";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(320, 311);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 354);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingForm";
            this.Text = "设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_camera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_adr;
        private System.Windows.Forms.TextBox textBox_adr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBox_micro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label7;
    }
}