﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        TcpClient clientSocket;
        NetworkStream stream;
        public string UserId;
        public string userName;
        public bool isOnline;
        public Client(string IP, int port, string userName)
        {
            clientSocket = new TcpClient();
            clientSocket.Connect(IPAddress.Parse(IP), port);
            stream = clientSocket.GetStream();
            this.userName = userName;
            
        }
        //public void Send()
        //{
        //    string messageString = UI.GetInput();
        //    byte[] message = Encoding.ASCII.GetBytes(messageString);
        //    stream.Write(message, 0, message.Count());
            // Console.WriteLine("Sent: {0}", message);
        //}
        //public void Receive()
        //{
            //byte[] receivedMessage = new byte[256];
            //stream.Read(receivedMessage, 0, receivedMessage.Length);
            //UI.DisplayMessage(Encoding.ASCII.GetString(receivedMessage));
            // recievedMessageString = System.Test.Encoding.ASCII.GetString( data, 0 , bytes);
            // Console.WriteLine("Recieved: {0}", rerevievedMessageString);
            // return recievedMessageString;
        //}
        // moved to the form
    }
}
