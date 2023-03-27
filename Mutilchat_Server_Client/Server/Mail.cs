using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Mail
    {
        private string strName;
        private string strTime;
        private string strContent;
        private string strSubject;
        public string StrName { get => strName; set => strName = value; }
        public string StrTime { get => strTime; set => strTime = value; }
        public string StrContent { get => strContent; set => strContent = value; }
        public string StrSubject { get => strSubject; set => strSubject = value; }

        
        public Mail(string strTime, string strName, string strSubject,  string strContent)
        {
            this.StrTime = strTime;
            this.StrName = strName;
            this.StrSubject = strSubject;
            this.StrContent = strContent;
        }
    }
}
