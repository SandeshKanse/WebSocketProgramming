using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSide
{
    class ProgramChat
    {

        #region collection
        public static readonly Dictionary<string, Dictionary<string, int>> servercollection = new Dictionary<string, Dictionary<string, int>>()
        {
            {"SetA", new Dictionary<string, int>{{"One", 1}, {"Two", 2}}},
            {"SetB", new Dictionary<string, int>{{"Three", 3}, {"Four", 4}}},
            {"SetC", new Dictionary<string, int>{{"Five", 5}, {"Six", 6}}},
            {"SetD", new Dictionary<string, int>{{"Seven", 7}, {"Eight", 8}}},
            {"SetE", new Dictionary<string, int>{{"Nine", 9}, {"Ten", 10}}}
        };

        #endregion collection
        public static void Main(string[] args)
        {
            try
            {
                TcpListener server = new TcpListener(System.Net.IPAddress.Parse("127.0.0.1"), 8888);
                server.Start();
                Console.WriteLine("Server Started and waiting for clients.");
                Socket socketForClients = server.AcceptSocket();
                
                if (socketForClients.Connected)
                {                
                    string opt = "";
                    NetworkStream ns = new NetworkStream(socketForClients);
                    StreamWriter sw = new StreamWriter(ns);
                    StreamReader sr = new StreamReader(ns);
                    sw.AutoFlush = true;
                    Console.WriteLine("Server>> Welcome Client.");

                    while (true)
                    {
                        //TcpClient cli = await server.AcceptTcpClientAsync();
                        string jsonraw = sr.ReadLine();
                        //decryption of data
                        string json = Utility.Decrypt(jsonraw);
                        string msg = json;
                        //Will split string from - and takes first instance/value
                        string splitter1 = msg.Split('-').First();
                        //Will split string from - and takes last instance/value
                        string splitter2 = msg.Split('-').Last();
                        //if input like 'SetA' present then it will return value else null
                        Dictionary<string, int> getVal = servercollection.Keys.Contains(splitter1) ? servercollection[splitter1] : null;
                        
                        string PrinttedOut = "EMPTY!";

                        if (getVal != null)
                        {
                            
                            int IntervalLoop = getVal.Keys.Contains(splitter2) ? getVal[splitter2] : 0;

                            if (IntervalLoop != 0)
                            {
                                for (int i = 0; i < IntervalLoop; i++)
                                {
                                    PrinttedOut = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                                    Console.WriteLine(PrinttedOut);
                                    string encryptPrinttedOut = Utility.Encrypt(PrinttedOut);
                                    //sw.AutoFlush = true;
                                    sw.WriteLine(encryptPrinttedOut);
                                    //this will run after 1 second interval
                                    System.Threading.Thread.Sleep(1000);
                                }
                                //
                            }
                            else
                            {
                                sw.WriteLine(PrinttedOut);
                            }
                        }
                        else
                        {
                            sw.WriteLine(PrinttedOut);
                        }

                        if (opt == null)
                            break;
                    }

                    sr.Close();
                    if (sw != null)
                    {
                        sw.Close();
                    }
                    ns.Close();
                }

                socketForClients.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
