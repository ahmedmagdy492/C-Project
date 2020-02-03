using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingServer
{
    public partial class Form1 : Form
    {
        private TcpClient client = new TcpClient();
        private NetworkStream stream;
        private AsyncCallback callback;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowData(IAsyncResult result)
        {
            //lsRooms.Items.Add(result.IsCompleted);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect("localhost", 6000);
            stream = client.GetStream();
            byte[] data = new byte[1024];
            callback = new AsyncCallback(ShowData);
            IAsyncResult result = stream.BeginRead(data, 0, data.Length, callback, null);
            string d = Encoding.Default.GetString(data);
            lsRooms.Items.Add(d);
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            string createRoom = "Create Room";
            stream.Write(Encoding.Default.GetBytes(createRoom), 0, Encoding.Default.GetBytes(createRoom).Length);
        }
    }
}
