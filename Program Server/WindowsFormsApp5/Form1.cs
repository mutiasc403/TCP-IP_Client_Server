using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        TcpListener server;
        TcpClient client,client2;
        NetworkStream ns;
        Thread thread;
        string clientIpadress;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            
        }

        private void bacaData()
        {
            while (true)
            {
                byte[] dataTerima = new byte[1024];
                if (ns.Read(dataTerima, 0, dataTerima.Length) != 0)
                //string h = Console.Writeline(dataTerima, 0, dataTerima.Length)
                {

                    UpdateLogTextFromThread(Encoding.ASCII.GetString(dataTerima));
                }
            }
        }

        //string m = mutiaaaaa;
        //byte[] u = system.Encoding.UTF8.GetBytes(m);
        //string t = system.Encoding.ASCII.GetString(u, 0, u.Length);
        //Console.WriteLine(t);
        //Message.Show(t);
  
        delegate void UpdateLogTextThreadDelegate(string v);
        public void UpdateLogTextFromThread(string v)
        {
            if (!this.IsDisposed && TxtStatus.InvokeRequired)
            {
                TxtStatus.Invoke(new UpdateLogTextThreadDelegate(UpdateLogText), new object[] { v });
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            ns.Close();
            client.Close();
            server.Stop();
        }

        private void UpdateLogText(string v)
        {
            TxtStatus.Text += v;
            TxtStatus.SelectionStart = TxtStatus.Text.Length;
            TxtStatus.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnopen_Click_1(object sender, EventArgs e)
        {
            //TcpListener server = new TcpListener(int.Parse(txtport.Text));
            server = new TcpListener(int.Parse(txtport.Text));
            server.Start();
            MessageBox.Show("Server Ready");
            client = server.AcceptTcpClient();
            ns = client.GetStream();
            clientIpadress = IPAddress.Parse(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()) + "";
            TxtStatus.Text += clientIpadress + "=&gt; Connected";
            Byte[] datakirim = new byte[1024];
            datakirim = Encoding.ASCII.GetBytes("Hi,, Kamu telah terkoneksi ke server ini");
            ns.Write(datakirim, 0, datakirim.Length);
            thread = new Thread(bacaData);
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnkirim_Click(object sender, EventArgs e)
        {
         byte[] datakirim = new byte[1024];
         datakirim = Encoding.ASCII.GetBytes(txtkirim.Text);
         ns.Write(datakirim, 0, datakirim.Length);
        }

        //uint h;
        //UInt16 n;



        private void txtport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}