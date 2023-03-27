namespace Server
{
    partial class Server
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
            this.btnSend = new System.Windows.Forms.Button();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.flpMailList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(340, 220);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(76, 49);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsvMessage
            // 
            this.lsvMessage.AllowDrop = true;
            this.lsvMessage.BackColor = System.Drawing.Color.Silver;
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(12, 12);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(404, 191);
            this.lsvMessage.TabIndex = 1;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            this.lsvMessage.SelectedIndexChanged += new System.EventHandler(this.lsvMessage_SelectedIndexChanged);
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(12, 220);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(322, 49);
            this.txbMessage.TabIndex = 2;
            // 
            // flpMailList
            // 
            this.flpMailList.AllowDrop = true;
            this.flpMailList.AutoScroll = true;
            this.flpMailList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMailList.Location = new System.Drawing.Point(422, 12);
            this.flpMailList.Name = "flpMailList";
            this.flpMailList.Size = new System.Drawing.Size(426, 191);
            this.flpMailList.TabIndex = 3;
            // 
            // btnLoadMail
            // 
            this.btnLoadMail.Location = new System.Drawing.Point(772, 220);
            this.btnLoadMail.Name = "btnLoadMail";
            this.btnLoadMail.Size = new System.Drawing.Size(76, 49);
            this.btnLoadMail.TabIndex = 4;
            this.btnLoadMail.Text = "LoadMail";
            this.btnLoadMail.UseVisualStyleBackColor = true;
            this.btnLoadMail.Click += new System.EventHandler(this.btnLoadMail_Click);
            // 
            // Server
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 281);
            this.Controls.Add(this.btnLoadMail);
            this.Controls.Add(this.flpMailList);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.btnSend);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.FlowLayoutPanel flpMailList;
        private System.Windows.Forms.Button btnLoadMail;
    }
}

