using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MailForm : Form
    {
        private string strName;
        private string strTime;
        private string strContent;
        public string StrName { get => strName; set => strName = value; }
        public string StrTime { get => strTime; set => strTime = value; }
        public string StrContent { get => strContent; set => strContent = value; }
        public MailForm(string strTime, string strName,  string strContent)
        {
            InitializeComponent();

            

            this.strTime = StrTime;
            this.strName = StrName;
            this.strContent = StrContent;

            LoadMail();
        }

       void LoadMail()
        {
            lbMailSubject.Text = "MailSubject";
            lbMailAddress.Text = StrName;
            txbContent.Text = StrContent;
        }
       

       
    }
}
