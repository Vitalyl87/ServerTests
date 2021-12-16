using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Server
{
    ///<summary>
    ///It is a chat server based on sockets
    ///</summary>
    class Program
    {
        static int port = 8888;
        static string ipAddress = "127.0.0.1";
        static List<Socket> clients = new List<Socket>();
        static List<string> chatMsg = new List<string>();
        ///<summary>
        ///We ovveride standart behaviour of app on ctrl+c/break/close/logoff/shutdown events
        ///</summary>
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);
        private delegate bool EventHandler();
        static EventHandler _handler;

        ///<summary>
        ///Server starts to listen address and port work with clients 
        ///</summary>
        static void Main(string[] args)
        {
            _handler += new EventHandler(Handler);
            SetConsoleCtrlHandler(_handler, true);

            var ipPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            var listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listenSocket.Bind(ipPoint);

                listenSocket.Listen(100);
                Console.WriteLine("Waiting for clients...");

                var count = 0;
                while (true)
                {
                    var handler = listenSocket.Accept();
                    Console.WriteLine("client " + (count += 1) + " entered chatroom (one chat session statistics)");

                    var connectionData = new ConnectionData(handler, clients, chatMsg);
                    Task.Run(() => ClientThread(connectionData));
                    clients.Add(handler);

                    var history = "";
                    if (chatMsg.Count != 0)
                    {
                        foreach (string str in chatMsg)
                        {
                            history += str + Environment.NewLine;
                        }
                        handler.Send(Encoding.Unicode.GetBytes(history));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ///<summary>
        ///Task for client work
        ///</summary>
        static void ClientThread(object StateInfo)
        {
            var connectionData = (ConnectionData)StateInfo;
            var handler = connectionData.Handler;
            var bytes = 0;
            var data = new byte[256];
            var userName = "";
            while (SocketConnected(handler))
            {
                var builder = new StringBuilder();
                try
                {
                    do
                    {
                        bytes = handler.Receive(data);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (SocketConnected(handler) && handler.Available > 0);

                    if (builder.ToString() != "")
                    {
                        var chatMessage = "";
                        if (userName == "")
                        {
                            userName = builder.ToString();
                            chatMessage = DateTime.Now.ToShortTimeString() + " " + userName + " connected";
                            Console.WriteLine(DateTime.Now.ToShortTimeString() + " " + userName + " connected");
                        }
                        else
                        {
                            chatMessage = DateTime.Now.ToShortTimeString() + " " + userName + ": " + builder.ToString();
                            Console.WriteLine(chatMessage);
                        }

                        Task.Run(() =>
                        {
                            foreach (var client in connectionData.Clients)
                            {
                                client.Send(Encoding.Unicode.GetBytes(chatMessage));
                            }
                        });

                        lock (ConnectionData.lockerObj)
                        {
                            chatMsg.Add(chatMessage);
                        }
                    }
                }
                catch
                {
                    break;
                }
            }
            Console.WriteLine("client " + userName + " was disconnected");
            lock (ConnectionData.lockerObjCli)
            {
                connectionData.Clients.Remove(handler);
            }
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }

        ///<summary>
        ///Test socket connection
        ///</summary>
        static bool SocketConnected(Socket s)
        {
            try
            {
                var part1 = s.Poll(1000, SelectMode.SelectRead);
                var part2 = (s.Available == 0);
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

        ///<summary>
        ///Handler for our action (close/exit app)
        ///</summary>
        private static bool Handler()
        {
            Stop();
            return false;
        }

        ///<summary>
        ///Correctly inform all clients about server shutdown and close all client connections
        ///</summary>
        public static void Stop()
        {
            foreach (var cli in clients)
            {
                cli.Send(Encoding.Unicode.GetBytes("Server close all connections, goodbye!"));
                cli.Shutdown(SocketShutdown.Both);
                cli.Close();
            }
        }
    }
}