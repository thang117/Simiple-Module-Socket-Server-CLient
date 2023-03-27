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

namespace Client
{
    public partial class Client : Form
    {
        private string strName;
        private string strTime;
        private string strSubject;
        private string strContent;
        public string StrName { get => strName; set => strName = value; }
        public string StrTime { get => strTime; set => strTime = value; }
        public string StrContent { get => strContent; set => strContent = value; }
        public string StrSubject { get => strSubject; set => strSubject = value; }

        public Client()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Connect();
        }
        private void Client_Load(object sender, EventArgs e)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = "Welcome" });

        }
        

        IPEndPoint IP;
        Socket client;
        /// <summary>
        /// Ket noi toi server
        /// </summary>
        void Connect()
        {
            //ip địa chỉ của server
            IP = new IPEndPoint(IPAddress.Parse("192.168.1.150"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }catch{
                MessageBox.Show("Ko the ket noi den server", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();


        }
        /// <summary>
        /// dong ket noi den server
        /// </summary>
        void Closeconnect()
        {
            client.Close();
        }
        /// <summary>
        /// gui tin
        /// </summary>
        void Send()
        {
            if (txbMessage.Text != string.Empty)
            {
                //client.Send(Serialize("TIME: " + DateTime.Now.ToString()));
                client.Send(Serialize("NAME: Admin " + "SUBJECT: SubJectMail002"));
                client.Send(Serialize("CONTENT: " + txbMessage.Text));
                
            }              
        }

        public string FuntionGetNameAndSubject(string s, int t)
        {
            string sString = " ";
            if (t == 1)// t== 1 sẽ trả về NAME:
            {
                int i = s.IndexOf("SUBJECT");
                sString = s.Substring(0, i); // cắt chuỗi để lấy nội dung của NAME              
            }
            else if (t == 0)//t == 0 sẽ trả về Subject:
            {
                int i = s.IndexOf("SUBJECT");
                if (i >= 0) sString = s.Substring(i - 1); // cắt chuỗi để lấy nội dung của SUBJECT
            }
            return sString;
        }

        /// <summary>
        /// nhan tin
        /// </summary>
        void Receive()
        {
            try
            {

                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    
                    if (message.Contains("NAME:"))
                    {
                        StrName = FuntionGetNameAndSubject(message, 1);
                        StrSubject = FuntionGetNameAndSubject(message, 0);
                        Addmessage(DateTime.Now.ToString());
                        Addmessage(StrName);
                        Addmessage(StrSubject);
                    }
                    else if (message.Contains("CONTENT:"))
                    {
                        StrContent = message;
                        Addmessage(message);
                        Addmessage(" ");
                    }
                                        
                   
                }
            }
            catch
            {
                Close();
            }
        }

        /// <summary>
        /// thêm message vào khung chat
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
        /// đóng kết nối khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            Addmessage(DateTime.Now.ToString() + "--" + "Client");        
            Addmessage(txbMessage.Text);
            Addmessage(" ");
            txbMessage.Clear();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Closeconnect();
            Application.Exit();
        }

    }
}
