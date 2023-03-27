using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class MailForm : Form
    {
        private string strName;
        private string strTime;
        private string strContent;
        private string strSubject;
        public string StrName { get => strName; set => strName = value; }
        public string StrTime { get => strTime; set => strTime = value; }
        public string StrContent { get => strContent; set => strContent = value; }
        public string StrSubject { get => strSubject; set => strSubject = value; }

        public MailForm(string strTime, string strName, string strSubject,  string strContent)
        {
            InitializeComponent();

            

            this.StrTime = strTime;
            this.StrName = strName;
            this.StrSubject = strSubject;
            this.StrContent = strContent;

            LoadMail();
        }

       void LoadMail()
        {
            lbMailSubject.Text = "MailSubject";
            lbMailAddress.Text = StrName;
            lbMailSubject.Text = StrSubject;
            txbContent.Text = StrContent;
            lbTime.Text = StrTime;
        }
       

       
    }
}
