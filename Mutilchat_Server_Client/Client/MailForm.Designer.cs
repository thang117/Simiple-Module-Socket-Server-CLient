
namespace Client
{
    partial class MailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMailSubject = new System.Windows.Forms.Label();
            this.lbMailAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbContent);
            this.panel1.Location = new System.Drawing.Point(10, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 226);
            this.panel1.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(310, 202);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(113, 19);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "RecieveTimeMail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "TIME:";
            // 
            // txbContent
            // 
            this.txbContent.Location = new System.Drawing.Point(18, 4);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.ReadOnly = true;
            this.txbContent.Size = new System.Drawing.Size(450, 192);
            this.txbContent.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbMailSubject);
            this.panel2.Controls.Add(this.lbMailAddress);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 60);
            this.panel2.TabIndex = 1;
            // 
            // lbMailSubject
            // 
            this.lbMailSubject.AutoSize = true;
            this.lbMailSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMailSubject.Location = new System.Drawing.Point(103, 37);
            this.lbMailSubject.Name = "lbMailSubject";
            this.lbMailSubject.Size = new System.Drawing.Size(82, 19);
            this.lbMailSubject.TabIndex = 3;
            this.lbMailSubject.Text = "MailSubject";
            // 
            // lbMailAddress
            // 
            this.lbMailAddress.AutoSize = true;
            this.lbMailAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMailAddress.Location = new System.Drawing.Point(77, 11);
            this.lbMailAddress.Name = "lbMailAddress";
            this.lbMailAddress.Size = new System.Drawing.Size(87, 19);
            this.lbMailAddress.TabIndex = 2;
            this.lbMailAddress.Text = "MailAddress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SUBJECT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM:";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMailSubject;
        private System.Windows.Forms.Label lbMailAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}