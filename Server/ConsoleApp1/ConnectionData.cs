using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    ///<summary>
    ///Class for work with condition
    ///</summary>
    public class ConnectionData
    {
        ///<summary>
        ///Hanlder for client socket
        ///</summary>
        public Socket Handler { get; set; }
        ///<summary>
        ///Clients socket collection
        ///</summary>
        public List<Socket> Clients { get; set; }
        ///<summary>
        ///Chat messages collection
        ///</summary>
        public List<string> ChatMsg { get; set; }
        ///<summary>
        ///Locker object for chat messages collection
        ///</summary>
        public static object lockerObj = new object();
        ///<summary>
        ///Locker object for clients socket collection
        ///</summary>
        public static object lockerObjCli = new object();
        public ConnectionData(Socket socket, List<Socket> sockets, List<string> chatMsg)
        {
            Handler = socket;
            Clients = sockets;
            ChatMsg = chatMsg;
        }
    }
}
