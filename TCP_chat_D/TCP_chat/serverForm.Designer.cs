namespace TCP_chat_server
{
    partial class formServer
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.textAcceptMessage = new System.Windows.Forms.TextBox();
            this.buttonCreateConnection = new System.Windows.Forms.Button();
            this.buttonCloseConnection = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.textSendMessage = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(336, 162);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(134, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send Message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textAcceptMessage
            // 
            this.textAcceptMessage.Location = new System.Drawing.Point(31, 12);
            this.textAcceptMessage.Multiline = true;
            this.textAcceptMessage.Name = "textAcceptMessage";
            this.textAcceptMessage.Size = new System.Drawing.Size(439, 84);
            this.textAcceptMessage.TabIndex = 4;
            this.textAcceptMessage.Text = "Income Messages";
            // 
            // buttonCreateConnection
            // 
            this.buttonCreateConnection.Location = new System.Drawing.Point(329, 256);
            this.buttonCreateConnection.Name = "buttonCreateConnection";
            this.buttonCreateConnection.Size = new System.Drawing.Size(141, 23);
            this.buttonCreateConnection.TabIndex = 3;
            this.buttonCreateConnection.Text = "Create connection";
            this.buttonCreateConnection.UseVisualStyleBackColor = true;
            this.buttonCreateConnection.Click += new System.EventHandler(this.buttonCreateConnection_Click);
            // 
            // buttonCloseConnection
            // 
            this.buttonCloseConnection.Location = new System.Drawing.Point(329, 285);
            this.buttonCloseConnection.Name = "buttonCloseConnection";
            this.buttonCloseConnection.Size = new System.Drawing.Size(141, 23);
            this.buttonCloseConnection.TabIndex = 6;
            this.buttonCloseConnection.Text = "Close connection";
            this.buttonCloseConnection.UseVisualStyleBackColor = true;
            this.buttonCloseConnection.Click += new System.EventHandler(this.buttonBreakConnection_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(491, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatus
            // 
            this.toolStatus.Name = "toolStatus";
            this.toolStatus.Size = new System.Drawing.Size(82, 17);
            this.toolStatus.Text = "Execution Info";
            // 
            // textSendMessage
            // 
            this.textSendMessage.Location = new System.Drawing.Point(31, 102);
            this.textSendMessage.Multiline = true;
            this.textSendMessage.Name = "textSendMessage";
            this.textSendMessage.Size = new System.Drawing.Size(439, 54);
            this.textSendMessage.TabIndex = 8;
            this.textSendMessage.Text = "Type here to send message";
            // 
            // formServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 333);
            this.Controls.Add(this.textSendMessage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonCloseConnection);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textAcceptMessage);
            this.Controls.Add(this.buttonCreateConnection);
            this.Name = "formServer";
            this.Text = "Server Window";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textAcceptMessage;
        private System.Windows.Forms.Button buttonCreateConnection;
        private System.Windows.Forms.Button buttonCloseConnection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus;
        private System.Windows.Forms.TextBox textSendMessage;
    }
}

