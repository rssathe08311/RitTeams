using ProfileLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatLib;
using Final___Search_Form;

namespace Project
{
    public partial class Form2 : Form
    {
        //done by jackson heim
        Chat chat;
        public Form2()
        {
            InitializeComponent();

          
            //make all button styles
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 0;

            this.button2.FlatStyle = FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;

            this.button3.FlatStyle = FlatStyle.Flat;
            this.button3.FlatAppearance.BorderSize = 0;

            //event handlers
            this.button1.Click += new EventHandler(Teams__Click);
            this.button2.Click += new EventHandler(Chat__Click);
            this.button3.Click += new EventHandler(Search__Click);
            this.homeBox.Click += new EventHandler(HomeButton__Click);

        }

        //go to teams page
        private void Teams__Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
           // this.Hide();
            form5.ShowDialog();



        }

        //go to chat page
        private void Chat__Click(object sender, EventArgs e)
        {
            Chat form6 = new Chat();
           // this.Hide();
            form6.ShowDialog();



        }

        //go to search page
        private void Search__Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
           // this.Hide();
            form7.ShowDialog();



        }

        private void HomeButton__Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            this.Close();
            this.Hide();
            form1.ShowDialog();

        }
    }
}
