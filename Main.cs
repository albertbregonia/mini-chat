//Base GUI
using System;
using System.Text;
using System.Windows.Forms;

//Network
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace MiniChat
{
    public partial class Main : Form
    {
        TcpClient client;
        TcpListener server;
        StreamWriter output;
        StreamReader scanner;
        string currentClient;

        public Main(){InitializeComponent();}

        private void serverMode_CheckedChanged(object sender, EventArgs e)
        {
            //Implemented for ease of use - ensures that you know when server mode is enabled
            input.Enabled = !serverMode.Checked;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            //Attempt Connection when the 'Connect' button is clicked
            if (server == null || client == null || !client.Connected)
                attemptConnection.RunWorkerAsync();
            else
                MessageBox.Show("A network thread is already running!");
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            //Attempt Connection when the 'Enter' key is pressed in the input window
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; //Removes the windows alert sound effect
                if (server == null || client == null || !client.Connected)
                    attemptConnection.RunWorkerAsync();
                else
                    MessageBox.Show("A network thread is already running!");
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            //Disconnect from current server if connected
            if (server != null || (client != null && client.Connected))
                disconnect();
            else
                MessageBox.Show("A network thread is not running!");
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            //Send a string to the server when the 'Send' button is clicked
            if (client != null && client.Connected)
                SendMsg();
            else
                MessageBox.Show("A network thread is not running!");
        }

        private void msgInput_KeyDown(object sender, KeyEventArgs e)
        {
            //Send a string to the server when the 'Enter' key is pressed in the input window
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (client != null && client.Connected)
                    SendMsg();
                else
                    MessageBox.Show("A network thread is not running!");
            }
        }

        private void SendMsg()
        {
            /* Behind the scenes, this is what the 'StreamWriter' object automates:
             * 
             * int amt = Encoding.ASCII.GetByteCount(msg.Text.Trim() + "\n");
             * byte[] data = new byte[amt];
             * data = Encoding.ASCII.GetBytes(msg.Text.Trim() + "\n");
             * client.GetStream().Write(data, 0, amt);
             * 
             * StreamWriter converts the message to bytes and then writes it to the socket
             */
            output.WriteLine(msgInput.Text.Trim());
            UpdateLog(msgInput.Text.Trim());
            msgInput.Text = "";
        }

        private void disconnect()
        {
            //Clean disconnect
            if(ping.IsBusy)
                ping.CancelAsync();
            MessageBox.Show("Connection Lost");
            UpdateLog("Disconnected");
            client.Close();
            reset();
        }

        private void reset()
        {
            client = null;
            server = null;
            input.Enabled = true;
            serverMode.Enabled = true;
        }

        private void UpdateLog(String s)
        {
            //Message Logging in the Pseudo-Console
            console.Items.Add(DateTime.Now + "\t" + s);
			console.TopIndex = console.Items.Count - 1; //Ensures that the last item is always seen
        }

        private void attemptConnection_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Disable changing settings while attempting a connection
            input.Invoke((MethodInvoker)delegate { input.Enabled = false; });
            serverMode.Invoke((MethodInvoker)delegate { serverMode.Enabled = false; });
            if (serverMode.Checked)
                try //Generates a new TCP Server on Port 54000 and waits for a client to connect
                {
                    server = new TcpListener(IPAddress.Any, 54000);
                    server.Start();
                    MessageBox.Show("Server has successfully initialized. Waiting for a client...");
                    client = server.AcceptTcpClient();
                }
                catch
                {
                    MessageBox.Show("Failed to establish a server on current network.", "ERROR");
                    reset();
                }
            else
                try //Background thread to attempt to connect to a server based on the 'input' window's text
                {
                    String[] connection = input.Text.Trim().Split(':');
                    int port;
                    int.TryParse(connection[1].Trim(), out port);
                    client = new TcpClient(connection[0].Trim(), port);
                }
                catch
                {
                    MessageBox.Show("Invalid IP Address or Port", "Failed to Establish Network Connection");
                    reset();
                }
            if (client != null && client.Connected)
            { //Chat setup and notifier
                output = new StreamWriter(client.GetStream(), Encoding.ASCII);
                scanner = new StreamReader(client.GetStream(), Encoding.ASCII);
                output.AutoFlush = true;
                console.Invoke((MethodInvoker)delegate
                {
                    if (serverMode.Checked)
                    {
                        currentClient = ((IPEndPoint)client.Client.RemoteEndPoint).ToString();
                        UpdateLog(currentClient + " has successfully connected");
                    }
                    else
                    {
                        currentClient = input.Text.Trim();
                        UpdateLog("Successfully connected to: " + input.Text.Trim());
                    } 
                });
                ping.RunWorkerAsync(); //Start Message Handler
            }
        }

        private void ping_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int online;  //Display incoming messages while connection is valid
            while (client != null && client.Connected && (online = client.GetStream().ReadByte())>-1)
                console.Invoke((MethodInvoker)delegate
					{UpdateLog("@" + currentClient + " " + (char)online + scanner.ReadLine());});
            //Disconnect upon connection lost
            console.Invoke((MethodInvoker)delegate 
				{disconnect();});
            ping.CancelAsync(); //End Message Handler
        }
    }
}