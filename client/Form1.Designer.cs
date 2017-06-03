namespace client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lst_OnlineUser = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1_set = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.开始通话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结束通话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.开始录象ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止录像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtf_SendMessage = new System.Windows.Forms.RichTextBox();
            this.rtf_MessageInfo = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.panel_video = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel_video.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_OnlineUser
            // 
            this.lst_OnlineUser.FormattingEnabled = true;
            this.lst_OnlineUser.ItemHeight = 12;
            this.lst_OnlineUser.Location = new System.Drawing.Point(6, 19);
            this.lst_OnlineUser.MultiColumn = true;
            this.lst_OnlineUser.Name = "lst_OnlineUser";
            this.lst_OnlineUser.Size = new System.Drawing.Size(170, 556);
            this.lst_OnlineUser.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "连接状态：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel2.Text = "等待连接…";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_OnlineUser);
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 585);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前在线";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1_set,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1_set
            // 
            this.toolStripButton1_set.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1_set.Image")));
            this.toolStripButton1_set.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_set.Name = "toolStripButton1_set";
            this.toolStripButton1_set.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1_set.Text = "设置";
            this.toolStripButton1_set.Click += new System.EventHandler(this.toolStripButton1_set_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectToolStripMenuItem,
            this.StopToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton1.Text = "通信状态";
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ConnectToolStripMenuItem.Image")));
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            this.ConnectToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ConnectToolStripMenuItem.Text = "连接";
            this.ConnectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // StopToolStripMenuItem
            // 
            this.StopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StopToolStripMenuItem.Image")));
            this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
            this.StopToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.StopToolStripMenuItem.Text = "停止";
            this.StopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始通话ToolStripMenuItem,
            this.结束通话ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripSplitButton1.Text = "视频";
            // 
            // 开始通话ToolStripMenuItem
            // 
            this.开始通话ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("开始通话ToolStripMenuItem.Image")));
            this.开始通话ToolStripMenuItem.Name = "开始通话ToolStripMenuItem";
            this.开始通话ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开始通话ToolStripMenuItem.Text = "开始通话";
            this.开始通话ToolStripMenuItem.Click += new System.EventHandler(this.开始通话ToolStripMenuItem_Click);
            // 
            // 结束通话ToolStripMenuItem
            // 
            this.结束通话ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("结束通话ToolStripMenuItem.Image")));
            this.结束通话ToolStripMenuItem.Name = "结束通话ToolStripMenuItem";
            this.结束通话ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.结束通话ToolStripMenuItem.Text = "结束通话";
            this.结束通话ToolStripMenuItem.Click += new System.EventHandler(this.结束通话ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始录象ToolStripMenuItem,
            this.停止录像ToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton2.Text = "视频保存";
            // 
            // 开始录象ToolStripMenuItem
            // 
            this.开始录象ToolStripMenuItem.Name = "开始录象ToolStripMenuItem";
            this.开始录象ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开始录象ToolStripMenuItem.Text = "开始录象";
            this.开始录象ToolStripMenuItem.Click += new System.EventHandler(this.开始录象ToolStripMenuItem_Click);
            // 
            // 停止录像ToolStripMenuItem
            // 
            this.停止录像ToolStripMenuItem.Name = "停止录像ToolStripMenuItem";
            this.停止录像ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.停止录像ToolStripMenuItem.Text = "停止录像";
            this.停止录像ToolStripMenuItem.Click += new System.EventHandler(this.停止录像ToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtf_SendMessage);
            this.groupBox3.Controls.Add(this.rtf_MessageInfo);
            this.groupBox3.Controls.Add(this.send);
            this.groupBox3.Location = new System.Drawing.Point(213, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 577);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "业务汇报";
            // 
            // rtf_SendMessage
            // 
            this.rtf_SendMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtf_SendMessage.Location = new System.Drawing.Point(6, 353);
            this.rtf_SendMessage.Name = "rtf_SendMessage";
            this.rtf_SendMessage.Size = new System.Drawing.Size(413, 188);
            this.rtf_SendMessage.TabIndex = 18;
            this.rtf_SendMessage.Text = "";
            // 
            // rtf_MessageInfo
            // 
            this.rtf_MessageInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtf_MessageInfo.HideSelection = false;
            this.rtf_MessageInfo.Location = new System.Drawing.Point(8, 20);
            this.rtf_MessageInfo.Name = "rtf_MessageInfo";
            this.rtf_MessageInfo.ReadOnly = true;
            this.rtf_MessageInfo.Size = new System.Drawing.Size(412, 327);
            this.rtf_MessageInfo.TabIndex = 17;
            this.rtf_MessageInfo.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(337, 547);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(81, 23);
            this.send.TabIndex = 16;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click_1);
            // 
            // panel_video
            // 
            this.panel_video.Controls.Add(this.groupBox4);
            this.panel_video.Location = new System.Drawing.Point(649, 34);
            this.panel_video.Name = "panel_video";
            this.panel_video.Size = new System.Drawing.Size(347, 581);
            this.panel_video.TabIndex = 0;
            this.panel_video.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(4, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 577);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "视频通话";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.videoSourcePlayer1);
            this.groupBox6.Location = new System.Drawing.Point(6, 299);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(334, 271);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "客户端";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(6, 20);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(322, 245);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(6, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 265);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "服务器";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 640);
            this.Controls.Add(this.panel_video);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "客户端";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel_video.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lst_OnlineUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1_set;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtf_SendMessage;
        private System.Windows.Forms.RichTextBox rtf_MessageInfo;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel panel_video;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private AForge.Controls.PictureBox pictureBox1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 开始通话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结束通话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem 开始录象ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止录像ToolStripMenuItem;
    }
}

