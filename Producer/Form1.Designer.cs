namespace Producer
{
    partial class Form1
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDeclareExchangeName = new System.Windows.Forms.TextBox();
            this.cbDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtRoutingName = new System.Windows.Forms.TextBox();
            this.btnBindQueue = new System.Windows.Forms.Button();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tsLblConnectionStatus = new System.Windows.Forms.TextBox();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(52, 43);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(304, 27);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "amqp://guest:guest@localhost:5672/";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(404, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(170, 29);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(52, 122);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(304, 27);
            this.txtDeclareQueueName.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Declare Queue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDeclareExchangeName
            // 
            this.txtDeclareExchangeName.Location = new System.Drawing.Point(52, 184);
            this.txtDeclareExchangeName.Name = "txtDeclareExchangeName";
            this.txtDeclareExchangeName.Size = new System.Drawing.Size(304, 27);
            this.txtDeclareExchangeName.TabIndex = 4;
            // 
            // cbDeclareExchangeType
            // 
            this.cbDeclareExchangeType.FormattingEnabled = true;
            this.cbDeclareExchangeType.Location = new System.Drawing.Point(52, 232);
            this.cbDeclareExchangeType.Name = "cbDeclareExchangeType";
            this.cbDeclareExchangeType.Size = new System.Drawing.Size(304, 28);
            this.cbDeclareExchangeType.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Declare Exchange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtRoutingName
            // 
            this.txtRoutingName.Location = new System.Drawing.Point(52, 302);
            this.txtRoutingName.Name = "txtRoutingName";
            this.txtRoutingName.Size = new System.Drawing.Size(304, 27);
            this.txtRoutingName.TabIndex = 7;
            // 
            // btnBindQueue
            // 
            this.btnBindQueue.Location = new System.Drawing.Point(404, 307);
            this.btnBindQueue.Name = "btnBindQueue";
            this.btnBindQueue.Size = new System.Drawing.Size(170, 29);
            this.btnBindQueue.TabIndex = 8;
            this.btnBindQueue.Text = "Bind Queue";
            this.btnBindQueue.UseVisualStyleBackColor = true;
            this.btnBindQueue.Click += new System.EventHandler(this.btnBindQueue_Click);
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(916, 412);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(151, 27);
            this.txtRoutingKey.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Routing Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Exchange Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(810, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Message";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(1133, 545);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(94, 29);
            this.btnPublish.TabIndex = 17;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(78, 429);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(465, 27);
            this.txtLog.TabIndex = 18;
            // 
            // tsLblConnectionStatus
            // 
            this.tsLblConnectionStatus.Location = new System.Drawing.Point(90, 581);
            this.tsLblConnectionStatus.Name = "tsLblConnectionStatus";
            this.tsLblConnectionStatus.Size = new System.Drawing.Size(125, 27);
            this.tsLblConnectionStatus.TabIndex = 19;
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(916, 372);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(151, 27);
            this.txtExchangeName.TabIndex = 20;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(917, 473);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(326, 27);
            this.txtMessage.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 670);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtExchangeName);
            this.Controls.Add(this.tsLblConnectionStatus);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoutingKey);
            this.Controls.Add(this.btnBindQueue);
            this.Controls.Add(this.txtRoutingName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbDeclareExchangeType);
            this.Controls.Add(this.txtDeclareExchangeName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDeclareQueueName);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDeclareQueueName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDeclareExchangeName;
        private System.Windows.Forms.ComboBox cbDeclareExchangeType;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRoutingName;
        private System.Windows.Forms.Button btnBindQueue;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox tsLblConnectionStatus;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.TextBox txtMessage;
    }
}
