﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLib;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ChatFunction
{
    //create delegate
    public delegate void UpdateConversationDelegate(string text);

    public partial class chat : Form
    {

        public string user ="Username";
        public string IP ="";
        public int port= 89;
        public string targetUser ="Username";
        public string targetIP = "192.168.1.1";
        public int targetPort =89;
        public string text;
        Thread thread;
        Socket listener;

        public chat()
        {
            InitializeComponent();
            CircularPictureBox();

            //set the IP adress of computer
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in ipHost.AddressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.IP = iPAddress.ToString();
                    break;
                }
            }

            // Lock the form size
            this.Size = new Size(816, 489);
            this.MinimumSize = this.MaximumSize = this.Size;

            //make all button styles
            this.sendButton.FlatStyle = FlatStyle.Flat;
            this.sendButton.FlatAppearance.BorderSize = 0;

            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 0;

            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;

            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.FlatAppearance.BorderSize = 0;



            //event handlers
            this.sendButton.Click += new EventHandler(SendButton__Click);
            this.userTextBox.KeyPress += new KeyPressEventHandler(userTextBox_KeyPress);


            this.button1.Click += new EventHandler(button1__Click);
            this.button2.Click += new EventHandler(button2__Click);
            this.button3.Click += new EventHandler(button3__Click);

            this.homeBox.Click += new EventHandler(HomeButton__Click);

        }

        private void CircularPictureBox()
        {
            // Create a circular mask for the PictureBox
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(pictureBox1.ClientRectangle);
            pictureBox1.Region = new Region(path);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(pictureBox2.ClientRectangle);
            pictureBox2.Region = new Region(path2);

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(pictureBox3.ClientRectangle);
            pictureBox3.Region = new Region(path3);

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(pictureBox5.ClientRectangle);
            pictureBox5.Region = new Region(path5);

        }

        private void button1__Click(object sender, EventArgs e)
        {
            // Set properties 
           targetUser = "BennyJones"; 
           targetIP = "127.0.0.1";

            //show text
            this.firstUser.Text = "BennyJones";
            this.firstText.Text = "Hey buddy";
            this.firstUser.ForeColor = Color.Orange;
            this.secondUser.Visible = true;
            this.secondText.Visible = true;
            this.thirdUser.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.label9.Visible = true;
            this.label10.Visible = true;
            this.label11.Visible = true;
            this.lastUser1.Visible = false;
            this.writeBack2.Visible = false;
            this.lastUser2.Visible = false;
            this.writeBack3.Visible = false;


            if (this.writeBack.Text.Length >0)
            {
                this.forthUser.Visible = true;
                this.writeBack.Visible = true;
            }


            //change button colors
            this.button1.BackColor = Color.FromArgb(10, 17, 36);
            this.button2.BackColor = Color.FromArgb(23, 38, 75);
            this.button3.BackColor = Color.FromArgb(23, 38, 75);
         

        }

        private void button2__Click(object sender, EventArgs e)
        {
            // Set properties 
            targetUser = "AnotherPerson";
            targetIP = "161.0.0.1";

            //show text
            this.firstUser.Text = "AnotherPerson";
            this.firstUser.ForeColor = Color.Coral;
            this.firstText.Text = "Who are you?";
            this.secondUser.Visible = false;
            this.secondText.Visible = false;
            this.thirdUser.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.forthUser.Visible = false;
            this.writeBack.Visible = false;
            this.lastUser2.Visible = false;
            this.writeBack3.Visible = false;

            if (this.writeBack2.Text.Length > 0)
            {
                this.lastUser1.Visible = true;
                this.writeBack2.Visible = true;
            }


            //change button colors
            this.button1.BackColor = Color.FromArgb(23, 38, 75);
            this.button2.BackColor = Color.FromArgb(10, 17, 36);
            this.button3.BackColor = Color.FromArgb(23, 38, 75);
          

        }

        private void button3__Click(object sender, EventArgs e)
        {
            // Set properties 
            targetUser = "Friend201";
            targetIP = "193.0.0.1";

            //show text
            this.firstUser.Text = "Friend201";
            this.firstUser.ForeColor = Color.Orange;
            this.firstText.Text = ":)";
            this.secondUser.Visible = false;
            this.secondText.Visible = false;
            this.thirdUser.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;
            this.label11.Visible = false;
            this.forthUser.Visible = false;
            this.writeBack.Visible = false;
            this.lastUser1.Visible = false;
            this.writeBack2.Visible = false;

            if (this.writeBack3.Text.Length>0)
            {
                this.lastUser2.Visible = true;
                this.writeBack3.Visible = true;
            }

            //change button colors
            this.button1.BackColor = Color.FromArgb(23, 38, 75);
            this.button2.BackColor = Color.FromArgb(23, 38, 75);
            this.button3.BackColor = Color.FromArgb(10, 17, 36);
           

        }


        //send the message
        private void SendButton__Click(object sender, EventArgs e)
        {
            //the text
            text = this.userTextBox.Text;
            //send to different people
            if(this.button1.BackColor == Color.FromArgb(10, 17, 36))
            {
                this.forthUser.Visible = true;
                this.writeBack.Visible = true;
                this.writeBack.Text += text + Environment.NewLine;

            }else if(this.button2.BackColor == Color.FromArgb(10, 17, 36))
            {
                this.lastUser1.Visible = true;
                this.writeBack2.Visible = true;
                this.writeBack2.Text+= text + Environment.NewLine;

            }
            else if (this.button3.BackColor == Color.FromArgb(10, 17, 36))
            {
                this.lastUser2.Visible = true;
                this.writeBack3.Visible = true;
                this.writeBack3.Text+= text + Environment.NewLine;

            }
           

            //empty text box
            this.userTextBox.Text = " ";

        }

        private void userTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Trigger the same logic as the sendButton click event
                SendButton__Click(sender, e);

                // Mark the key event as handled to prevent the default behavior (new line in the textbox)
                e.Handled = true;
               
            }
        }



        //add message recieved to convo text box
        public void UpdateConversation(string text)
        {
            //this.convoTextBox.Text += (text + "\n");
           
        }

        //listen for text messages being sent
        public void Listen()
        {
            //declare delagate
            UpdateConversationDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConversationDelegate(UpdateConversation);

            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Any, this.port);

            this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(serverEndpoint);

            //listens for connects can have 300 max
            listener.Listen(300);

            //stay in infinate loop to listen to connections
            while (true)
            {
                //conncest application senf=ding and recieve message
                Socket client = listener.Accept();
                //connect network strean to client
                Stream netStream = new NetworkStream(client);
                //read data on net stream
                StreamReader reader = new StreamReader(netStream);
                //get whole message and turnb to string
                string result = reader.ReadToEnd();

                //use delegate
                Invoke(updateConversationDelegate, result);

                //close things
                reader.Close();
                netStream.Close();
                client.Close();

            }


        }

        private void HomeButton__Click(object sender, EventArgs e)
        {
             
        }






























        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
