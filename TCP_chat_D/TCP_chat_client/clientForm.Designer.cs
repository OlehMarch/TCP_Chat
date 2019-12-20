namespace TCP_chat_client
{
    partial class formClient
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
            this.textRecieve = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonCloseConnection = new System.Windows.Forms.Button();
            this.buttonCreateConnection = new System.Windows.Forms.Button();
            this.textSend = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textRecieve
            // 
            this.textRecieve.Location = new System.Drawing.Point(12, 12);
            this.textRecieve.Multiline = true;
            this.textRecieve.Name = "textRecieve";
            this.textRecieve.Size = new System.Drawing.Size(454, 109);
            this.textRecieve.TabIndex = 1;
            this.textRecieve.Text = "Income Messages";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(332, 174);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(134, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send Message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonCloseConnection
            // 
            this.buttonCloseConnection.Location = new System.Drawing.Point(342, 286);
            this.buttonCloseConnection.Name = "buttonCloseConnection";
            this.buttonCloseConnection.Size = new System.Drawing.Size(124, 23);
            this.buttonCloseConnection.TabIndex = 3;
            this.buttonCloseConnection.Text = "Close connection";
            this.buttonCloseConnection.UseVisualStyleBackColor = true;
            this.buttonCloseConnection.Click += new System.EventHandler(this.buttonCloseConnection_Click);
            // 
            // buttonCreateConnection
            // 
            this.buttonCreateConnection.Location = new System.Drawing.Point(342, 257);
            this.buttonCreateConnection.Name = "buttonCreateConnection";
            this.buttonCreateConnection.Size = new System.Drawing.Size(124, 23);
            this.buttonCreateConnection.TabIndex = 4;
            this.buttonCreateConnection.Text = "Create connection";
            this.buttonCreateConnection.UseVisualStyleBackColor = true;
            this.buttonCreateConnection.Click += new System.EventHandler(this.buttonCreateConnection_Click);
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(12, 127);
            this.textSend.Multiline = true;
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(454, 41);
            this.textSend.TabIndex = 5;
            this.textSend.Text = "Type here to send message";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatusInfo
            // 
            this.toolStatusInfo.Name = "toolStatusInfo";
            this.toolStatusInfo.Size = new System.Drawing.Size(85, 17);
            this.toolStatusInfo.Text = "Execution info ";
            // 
            // formClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 344);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textSend);
            this.Controls.Add(this.buttonCreateConnection);
            this.Controls.Add(this.buttonCloseConnection);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textRecieve);
            this.Name = "formClient";
            this.Text = "Client Window";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRecieve;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonCloseConnection;
        private System.Windows.Forms.Button buttonCreateConnection;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusInfo;
    }
}

