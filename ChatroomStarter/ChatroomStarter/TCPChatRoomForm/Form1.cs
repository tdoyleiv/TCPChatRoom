﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using Server;
using System.Net.Sockets;


namespace TCPChatRoomForm
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string sentData = null;

        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======
   
>>>>>>> 22ba8cc7de04eddddf5eaf621da0eb81dff709a2
        private void Form1_Load(object sender, EventArgs e)
        {

        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            Message();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AskName_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   

        }

        private void PromptServor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Message()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(message));
            else
                textBox.Text = textBox1.Text + Environment.NewLine + " >> " + readData;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
        public string Receive()
        {
            while (true)
            {
                byte[] receivedMessage = new byte[256];
                stream.Read(receivedMessage, 0, receivedMessage.Length);
                UI.DisplayMessage(Encoding.ASCII.GetString(receivedMessage));
            }
        }
        public void Send(string Message, string userName)
        {
            byte[] message = Encoding.ASCII.GetBytes(userName + ":" + Message);
            stream.Write(message, 0, message.Count());
            //stream.Flush();
        }

    }
}
