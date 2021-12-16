//Do we really need all of these references?
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client
{
    ///<summary>
    ///This program is a chat bot for work with local server by socket
    ///</summary>
    class Program
    {
        static int port = 8888;
        static string address = "127.0.0.1";
        static string fileName = Guid.NewGuid().ToString() + ".txt";
        static List<string> names = new List<string>() { "Glen", "Max", "Tim", "John", "Andrew" };
        static List<string> answers = new List<string>()
        {
            "Hello!", "How are you?", "What's it?", "Fine, thank you!", "Glad to see you.", "I am ok and you?", "Oh, it is a good place",
            "Let's play!", "Muhahaha", "ok"
        };
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                var sendName = false;
                var needChat = false;
                try
                {
                    var ipPoint = new IPEndPoint(IPAddress.Parse(address), port);
                    var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);           
                    socket.Connect(ipPoint);
                    needChat = true;
                    Task.Run(() => writerActions(socket));

                    var times = rnd.Next(1, 5);

                    while (SocketConnected(socket) && needChat)
                    {
                        var message = "";
                        if (sendName)
                        {
                            message = answers[rnd.Next(0, answers.Count)];
                            Thread.Sleep(rnd.Next(0, 5000));
                        }
                        else
                        {
                            message = names[rnd.Next(0, names.Count)];
                            sendName = true;
                        }
                        if (SocketConnected(socket) && message != "")
                        {
                            var data = Encoding.Unicode.GetBytes(message);
                            socket.Send(data);
                        }
                        if (times < 1)
                        {
                            needChat = false;
                            Console.WriteLine("Client ended his task");
                        }
                        times = times - 1;
                    }

                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (needChat)
                {
                    Console.WriteLine("Server closed all connections...");
                }
                Console.WriteLine("Try to reconnect to chat server...");                    
            }
        }

        ///<summary>
        ///Task action for receive chat messages
        ///</summary>
        static void writerActions(Socket socket)
        {
            fileName = Guid.NewGuid().ToString() + ".txt";
            while (SocketConnected(socket))
            {
                try
                {
                    var data = new byte[256];
                    var builder = new StringBuilder();
                    var bytes = 0;

                    do
                    {
                        bytes = socket.Receive(data, data.Length, 0);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (SocketConnected(socket) && socket.Available > 0);


                    using (var sw = File.AppendText(Environment.CurrentDirectory + "\\" + fileName))
                    {
                        sw.WriteLine(builder.ToString());
                    }
                }
                catch
                {
                    break;
                }
            }

        }

        ///<summary>
        ///Test socket connection
        ///</summary>
        static bool SocketConnected(Socket socketInstance)
        {
            try
            {
                var part1 = socketInstance.Poll(1000, SelectMode.SelectRead);
                var part2 = (socketInstance.Available == 0);
                if (part1 && part2)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}