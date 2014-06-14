using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ChatBotTwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = args[0];
            string password = args[1];
            string channel = args[2];
            string message = args[3];
            Console.WriteLine(username);
            Console.WriteLine(password);
            Console.WriteLine(channel);
            Console.WriteLine(message);
        


            int port;
            string buf, nick, owner, server, chan, merp;
            System.Net.Sockets.TcpClient sock = new System.Net.Sockets.TcpClient();
            System.IO.TextReader input;
            System.IO.TextWriter output;
            merp = username;

            nick = merp;
            owner = merp;
            server = "irc.twitch.tv";
            port = 6667;
            chan = "#" + channel;

            sock.Connect(server, port);
            if (!sock.Connected)
            {
                Console.WriteLine("Failed to connect!");
                Environment.Exit(0);
            }
            input = new System.IO.StreamReader(sock.GetStream());
            output = new System.IO.StreamWriter(sock.GetStream());

            output.Write("PASS " + password + "\r\n" +
               "USER " + nick + " 0 * :" + owner + "\r\n" +
               "NICK " + nick + "\r\n"
            );
            output.Flush();

            for (buf = input.ReadLine(); ; buf = input.ReadLine())
            {

                if (buf.StartsWith("PING ")) { output.Write(buf.Replace("PING", "PONG") + "\r\n"); output.Flush(); }
                if (buf[0] != ':') continue;

                System.Threading.Thread.Sleep(1000);

                output.Flush();

                if (!string.IsNullOrEmpty(buf))
                {
                    output.WriteLine("PRIVMSG " + chan + " : " + message);
                    output.Flush();
                    Environment.Exit(0);
                }
                if (buf.Split(' ')[1] == "001")
                {
                    output.Write(
                       "MODE " + nick + " +B\r\n" +
                       "JOIN " + chan + "\r\n"
                    );
                    output.Flush();
                }
            }
        }
    }
}
