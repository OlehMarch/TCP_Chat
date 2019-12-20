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
            this.TB_TextMessage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Log = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_TextMessage
            // 
            this.TB_TextMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_TextMessage.Location = new System.Drawing.Point(3, 3);
            this.TB_TextMessage.Multiline = true;
            this.TB_TextMessage.Name = "TB_TextMessage";
            this.TB_TextMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_TextMessage.Size = new System.Drawing.Size(237, 278);
            this.TB_TextMessage.TabIndex = 1;
            this.TB_TextMessage.TextChanged += new System.EventHandler(this.TB_TextMessage_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TB_TextMessage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_Log, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 292);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TB_Log
            // 
            this.TB_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Log.Location = new System.Drawing.Point(246, 3);
            this.TB_Log.Multiline = true;
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.ReadOnly = true;
            this.TB_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Log.Size = new System.Drawing.Size(238, 278);
            this.TB_Log.TabIndex = 2;
            // 
            // formClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formClient";
            this.Text = "Client Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClient_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TB_TextMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_Log;
    }
}

