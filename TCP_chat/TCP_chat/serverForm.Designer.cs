namespace chat_server
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
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonCreateConnection = new System.Windows.Forms.Button();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.apiData = new System.Windows.Forms.Button();
            this.ServerFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(12, 12);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessage.Size = new System.Drawing.Size(219, 167);
            this.textMessage.TabIndex = 4;
            // 
            // buttonCreateConnection
            // 
            this.buttonCreateConnection.Location = new System.Drawing.Point(237, 12);
            this.buttonCreateConnection.Name = "buttonCreateConnection";
            this.buttonCreateConnection.Size = new System.Drawing.Size(242, 23);
            this.buttonCreateConnection.TabIndex = 3;
            this.buttonCreateConnection.Text = "Create connection";
            this.buttonCreateConnection.UseVisualStyleBackColor = true;
            this.buttonCreateConnection.Click += new System.EventHandler(this.buttonCreateConnection_Click);
            // 
            // CloseConnection
            // 
            this.CloseConnection.Location = new System.Drawing.Point(237, 41);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(242, 23);
            this.CloseConnection.TabIndex = 5;
            this.CloseConnection.Text = "Close connection";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // TB_Message
            // 
            this.TB_Message.Location = new System.Drawing.Point(237, 129);
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.Size = new System.Drawing.Size(242, 20);
            this.TB_Message.TabIndex = 6;
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(237, 156);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(242, 23);
            this.SendMessage.TabIndex = 7;
            this.SendMessage.Text = "Send message";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // apiData
            // 
            this.apiData.Location = new System.Drawing.Point(237, 100);
            this.apiData.Name = "apiData";
            this.apiData.Size = new System.Drawing.Size(242, 23);
            this.apiData.TabIndex = 8;
            this.apiData.Text = "API Address & Socket Number";
            this.apiData.UseMnemonic = false;
            this.apiData.UseVisualStyleBackColor = true;
            this.apiData.Click += new System.EventHandler(this.apiData_Click);
            // 
            // ServerFiles
            // 
            this.ServerFiles.Location = new System.Drawing.Point(237, 70);
            this.ServerFiles.Name = "ServerFiles";
            this.ServerFiles.Size = new System.Drawing.Size(242, 23);
            this.ServerFiles.TabIndex = 9;
            this.ServerFiles.Text = "Browse server files";
            this.ServerFiles.UseVisualStyleBackColor = true;
            this.ServerFiles.Click += new System.EventHandler(this.ServerFiles_Click);
            // 
            // formServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 191);
            this.Controls.Add(this.ServerFiles);
            this.Controls.Add(this.apiData);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.TB_Message);
            this.Controls.Add(this.CloseConnection);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonCreateConnection);
            this.Name = "formServer";
            this.Text = "Server Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonCreateConnection;
        private System.Windows.Forms.Button CloseConnection;
        private System.Windows.Forms.TextBox TB_Message;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Button apiData;
        private System.Windows.Forms.Button ServerFiles;
    }
}

