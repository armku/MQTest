namespace mqcl
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.GroupBox();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.but_connet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_sub = new System.Windows.Forms.Button();
            this.subtoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pubtoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Connect.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(401, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "推送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(146, 304);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(249, 57);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "hello Stdos";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(146, 14);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(357, 284);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "接收mqtt消息";
            // 
            // Connect
            // 
            this.Connect.Controls.Add(this.port);
            this.Connect.Controls.Add(this.ip);
            this.Connect.Controls.Add(this.but_connet);
            this.Connect.Controls.Add(this.label5);
            this.Connect.Controls.Add(this.label2);
            this.Connect.Location = new System.Drawing.Point(-6, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(146, 137);
            this.Connect.TabIndex = 4;
            this.Connect.TabStop = false;
            this.Connect.Text = "连接";
            // 
            // port
            // 
            this.port.Enabled = false;
            this.port.Location = new System.Drawing.Point(8, 79);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(132, 21);
            this.port.TabIndex = 10;
            this.port.Text = "1883";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(8, 40);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(132, 21);
            this.ip.TabIndex = 9;
            this.ip.Text = "127.0.0.1";
            // 
            // but_connet
            // 
            this.but_connet.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_connet.Location = new System.Drawing.Point(18, 104);
            this.but_connet.Name = "but_connet";
            this.but_connet.Size = new System.Drawing.Size(110, 27);
            this.but_connet.TabIndex = 8;
            this.but_connet.Text = "连接";
            this.but_connet.UseVisualStyleBackColor = true;
            this.but_connet.Click += new System.EventHandler(this.But_connet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "服务器(IP/网址)：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_sub);
            this.groupBox2.Controls.Add(this.subtoc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(-6, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订阅";
            // 
            // but_sub
            // 
            this.but_sub.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_sub.Location = new System.Drawing.Point(18, 59);
            this.but_sub.Name = "but_sub";
            this.but_sub.Size = new System.Drawing.Size(110, 27);
            this.but_sub.TabIndex = 12;
            this.but_sub.Text = "订阅";
            this.but_sub.UseVisualStyleBackColor = true;
            this.but_sub.Click += new System.EventHandler(this.But_sub_Click);
            // 
            // subtoc
            // 
            this.subtoc.Location = new System.Drawing.Point(8, 32);
            this.subtoc.Name = "subtoc";
            this.subtoc.Size = new System.Drawing.Size(132, 21);
            this.subtoc.TabIndex = 11;
            this.subtoc.Text = "G/#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "订阅主题：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pubtoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(2, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "推送";
            // 
            // pubtoc
            // 
            this.pubtoc.Location = new System.Drawing.Point(6, 44);
            this.pubtoc.Name = "pubtoc";
            this.pubtoc.Size = new System.Drawing.Size(120, 21);
            this.pubtoc.TabIndex = 11;
            this.pubtoc.Text = "G/ddd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "推送主题：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 372);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(531, 411);
            this.MinimumSize = new System.Drawing.Size(531, 411);
            this.Name = "Form1";
            this.Text = "MqttClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Connect.ResumeLayout(false);
            this.Connect.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Connect;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button but_connet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_sub;
        private System.Windows.Forms.TextBox subtoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pubtoc;
        private System.Windows.Forms.Label label4;
    }
}

