namespace chat_client
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
            this.buttonCreateConnection = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.CloseConnection = new System.Windows.Forms.Button();
            this.TB_Message = new System.Windows.Forms.TextBox();
            this.apiData = new System.Windows.Forms.Button();
            this.ServerFiles = new System.Windows.Forms.Button();
            this.FileGetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateConnection
            // 
            this.buttonCreateConnection.Location = new System.Drawing.Point(237, 12);
            this.buttonCreateConnection.Name = "buttonCreateConnection";
            this.buttonCreateConnection.Size = new System.Drawing.Size(238, 23);
            this.buttonCreateConnection.TabIndex = 0;
            this.buttonCreateConnection.Text = "Create connection";
            this.buttonCreateConnection.UseVisualStyleBackColor = true;
            this.buttonCreateConnection.Click += new System.EventHandler(this.buttonCreateConnection_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(12, 12);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessage.Size = new System.Drawing.Size(219, 174);
            this.textMessage.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(237, 163);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(238, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send Message";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // CloseConnection
            // 
            this.CloseConnection.Location = new System.Drawing.Point(237, 41);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(238, 23);
            this.CloseConnection.TabIndex = 3;
            this.CloseConnection.Text = "Close connection";
            this.CloseConnection.UseVisualStyleBackColor = true;
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // TB_Message
            // 
            this.TB_Message.Location = new System.Drawing.Point(237, 137);
            this.TB_Message.Name = "TB_Message";
            this.TB_Message.Size = new System.Drawing.Size(238, 20);
            this.TB_Message.TabIndex = 4;
            // 
            // apiData
            // 
            this.apiData.Location = new System.Drawing.Point(237, 108);
            this.apiData.Name = "apiData";
            this.apiData.Size = new System.Drawing.Size(238, 23);
            this.apiData.TabIndex = 5;
            this.apiData.Text = "API Address & Socket Number";
            this.apiData.UseMnemonic = false;
            this.apiData.UseVisualStyleBackColor = true;
            this.apiData.Click += new System.EventHandler(this.apiData_Click);
            // 
            // ServerFiles
            // 
            this.ServerFiles.Location = new System.Drawing.Point(237, 70);
            this.ServerFiles.Name = "ServerFiles";
            this.ServerFiles.Size = new System.Drawing.Size(114, 32);
            this.ServerFiles.TabIndex = 6;
            this.ServerFiles.Text = "Browse server files";
            this.ServerFiles.UseVisualStyleBackColor = true;
            this.ServerFiles.Click += new System.EventHandler(this.ServerFiles_Click);
            // 
            // FileGetter
            // 
            this.FileGetter.Location = new System.Drawing.Point(358, 70);
            this.FileGetter.Name = "FileGetter";
            this.FileGetter.Size = new System.Drawing.Size(117, 32);
            this.FileGetter.TabIndex = 7;
            this.FileGetter.Text = "Get file by Id";
            this.FileGetter.UseVisualStyleBackColor = true;
            this.FileGetter.Click += new System.EventHandler(this.FileGetter_Click);
            // 
            // formClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 198);
            this.Controls.Add(this.FileGetter);
            this.Controls.Add(this.ServerFiles);
            this.Controls.Add(this.apiData);
            this.Controls.Add(this.TB_Message);
            this.Controls.Add(this.CloseConnection);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonCreateConnection);
            this.Name = "formClient";
            this.Text = "Client Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateConnection;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button CloseConnection;
        private System.Windows.Forms.TextBox TB_Message;
        private System.Windows.Forms.Button apiData;
        private System.Windows.Forms.Button ServerFiles;
        private System.Windows.Forms.Button FileGetter;
    }
}

