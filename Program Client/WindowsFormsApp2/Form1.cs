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
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string a;
        TcpClient c;
        NetworkStream ns;
        Thread thread;
        TcpListener server;
        TcpClient client;

        string clientIpadress;
        public Form1()
        {
            InitializeComponent();
        }

        private void Conn_Click(object sender, EventArgs e)
        {
            c = new TcpClient();
            c.Connect(TxtIp.Text, int.Parse(TxtPort.Text));
            ns = c.GetStream();
        }

        private void Disc_Click(object sender, EventArgs e)
        {
            ns.Close();
            c.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //a = textBox1.Text;
            byte[] kirim = new byte[1024];
            //kirim = Encoding.ASCII.GetBytes(a);
            kirim = Encoding.ASCII.GetBytes(textBox1.Text);
            ns.Write(kirim, 0, kirim.Length);
            thread = new Thread(bacaData);
            thread.IsBackground = true;
            thread.Start();
        }

        private void bacaData()
        {
            while (true)
            {
                byte[] dataTerima = new byte[1024];
                if (ns.Read(dataTerima, 0, dataTerima.Length) != 0)
                {

                    UpdateLogTextFromThread(Encoding.ASCII.GetString(dataTerima));
                }
            }
        }
        delegate void UpdateLogTextThreadDelegate(string v);
        public void UpdateLogTextFromThread(string v)
        {
            TxtStatus.Invoke(new UpdateLogTextThreadDelegate(UpdateLogText), new object[] { v });
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
