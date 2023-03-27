using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;


namespace Server
{
    public partial class Server : Form
    {
        private string strName;
        private string strTime;
        private string strSubject;
        private string strContent;
        public Server()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
            //LoadMailList();
        }
        
        /// <summary>
        /// gửi tin cho tất cả clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        IPEndPoint IP;
        Socket server;
        List<Socket> clientlist;

        public string StrName { get => strName; set => strName = value; }
        public string StrTime { get => strTime; set => strTime = value; }
        public string StrContent { get => strContent; set => strContent = value; }
        public string StrSubject { get => strSubject; set => strSubject = value; }

        /// <summary>
        /// Ket noi toi server
        /// </summary>
        void Connect()
        {
            clientlist = new List<Socket>();
            //ip địa chỉ của server
            IP = new IPEndPoint(IPAddress.Any,9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        Socket client = server.Accept();
                        clientlist.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                        
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });

            Listen.IsBackground = true;
            Listen.Start();
        }
        /// <summary>
        /// dong ket noi den server
        /// </summary>
        void Closeconnect()
        {
            server.Close();
        }
        /// <summary>
        /// gui tin
        /// </summary>
        void Send(Socket client)
        {
            if (client != null && txbMessage.Text != string.Empty)
            {
               // client.Send(Serialize("TIME: " + DateTime.Now.ToString()));
                client.Send(Serialize("NAME: Admin "+"SUBJECT: SubJectMail001"));
                client.Send(Serialize("CONTENT: "+txbMessage.Text));               
            }                 
        }

        public string FuntionGetNameAndSubject(string s,int t)
        {
            string sString = " ";
            if(t==1)// t== 1 sẽ trả về NAME:
            {
                int i = s.IndexOf("SUBJECT");
                if (i >= 0) sString = s.Substring(5, i-5); // cắt chuỗi để lấy nội dung của NAME              
            }
            else if(t==0)//t == 0 sẽ trả về Subject:
            {
                int i = s.IndexOf("SUBJECT");
                if (i >= 0) sString = s.Substring(i + 8); // cắt chuỗi để lấy nội dung của SUBJECT
            }
            return sString;
        }
        /// <summary>
        /// nhan tin
        /// </summary>
        void Receive(object obj)
        {
            
            Socket client = obj as Socket;
            try
            {

                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    if (message.Contains("NAME:"))
                    {
                        StrName = FuntionGetNameAndSubject(message,1);
                        StrSubject = FuntionGetNameAndSubject(message, 0);
                        strTime = DateTime.Now.ToString();
                        Addmessage(DateTime.Now.ToString());// thêm thời gian nhận thư 
                        Addmessage(StrName);
                        Addmessage(StrSubject);

                    }
                    else if (message.Contains("CONTENT:"))
                    {
                        StrContent = message;
                        Addmessage(message);
                        Addmessage(" ");
                       
                    }

                   
                    //gửi cho toàn bộ các client còn lại
                    //
                    //foreach (Socket item in clientlist)
                    //{
                    //    if (item != null && item != client)
                    //        item.Send(Serialize(message));
                    //}

                    //Addmessage(DateTime.Now.ToString());
                    
                }
            }
            catch
            {
                clientlist.Remove(client);
                client.Close();
            }
            
        }

       
        /// <summary>
        /// thêm messaga vào khung chat
        /// </summary>
        /// <param name="s"></param>
        void Addmessage(string s)
        {         
            lsvMessage.Items.Add(new ListViewItem() { Text = s });           
        }

        /// <summary>
        /// phân mảng 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        byte[] Serialize(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        /// <summary>
        /// gộp mảng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);

        }
        /// <summary>
        /// đóng kết nói khi đóng form server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void lsvMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = "Welcome" });

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
            //gửi đến tất cả client đang kết nối
            foreach (Socket item in clientlist)
            {
                Send(item);

            }
            Addmessage(DateTime.Now.ToString() + "--" + "Admin");          
            Addmessage(txbMessage.Text);
            Addmessage(" ");
            txbMessage.Clear();
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Closeconnect();
            Application.Exit();
        }

        void LoadMailList()
        {
            flpMailList.Controls.Clear();
            if (StrName != string.Empty)
            {
                Button btn = new Button() { Width = 400, Height = 100 };
                btn.Text = strName +" "+strTime;

               
                btn.Click += btn_Click; // tạo event mỗi lần click vào button

                flpMailList.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)// hàm sự kiện click button
        {
            MailForm fMail = new MailForm(StrTime, StrName,StrSubject, StrContent);
            fMail.ShowDialog();
        }

        //void AddListMail()
        //{
        //    Mail mail = new Mail(StrTime,StrName, StrSubject, StrContent);
        //    while(true)
        //    {
        //        mail.StrTime = StrTime;
        //        mail.StrName = StrName;
        //        mail.StrSubject = StrSubject;
        //        mail.StrContent = StrContent;
        //    }
        //}

        private void btnLoadMail_Click(object sender, EventArgs e)
        {
            LoadMailList();
        }
    }
}
