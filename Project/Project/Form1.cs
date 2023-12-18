using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        //done by jackson heim


        //setting integration by Reva Sathe
        public Form3 settings = new Form3();
        int textSize;
        string colorMode;
        Form3 form3;

        public Home()
        {
            InitializeComponent();
            CircularPictureBox();

            //event handlers

            this.profileBox.MouseEnter += new EventHandler(Panel__MouseEnter);
            this.teamsBox.MouseEnter += new EventHandler(Panel__MouseEnter);
            this.profileBox.MouseLeave += new EventHandler(Panel__MouseLeave);
            this.teamsBox.MouseLeave += new EventHandler(Panel__MouseLeave);

            this.pictureBox2.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox3.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox4.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox5.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox6.MouseEnter += new EventHandler(PictureBox__MouseEnter);
            this.pictureBox7.MouseEnter += new EventHandler(PictureBox__MouseEnter);

            this.pictureBox2.MouseLeave += new EventHandler(PictureBox__MouseLeave);
            this.pictureBox3.MouseLeave += new EventHandler(PictureBox__MouseLeave);
            this.pictureBox4.MouseLeave += new EventHandler(PictureBox__MouseLeave);
            this.pictureBox5.MouseLeave += new EventHandler(PictureBox__MouseLeave);
            this.pictureBox6.MouseLeave += new EventHandler(PictureBox__MouseLeave);
            this.pictureBox7.MouseLeave += new EventHandler(PictureBox__MouseLeave);

            this.label2.MouseEnter += new EventHandler(Label__MouseEnter);
            this.label3.MouseEnter += new EventHandler(Label__MouseEnter);
            this.label2.MouseLeave += new EventHandler(Label__MouseLeave);
            this.label3.MouseLeave += new EventHandler(Label__MouseLeave);

            this.pictureBox1.MouseEnter += new EventHandler(Settings__MouseEnter);

            //for going to new pages
            this.teamsBox.Click += new EventHandler(Teams__Click);
            this.profileBox.Click += new EventHandler(Profile__Click);
            this.pictureBox1.Click += new EventHandler(Settings__Click);

            form3 = new Form3();


            // Subscribe to ColorChangeEvent
            this.pictureBox1.Click += new EventHandler(Settings_ColorChangeEvent);
            //settings.ColorChangeEvent += Settings_ColorChangeEvent;
        }

        private void CircularPictureBox()
        {
            // Create a circular mask for the PictureBox
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(pictureBox2.ClientRectangle);
            pictureBox2.Region = new Region(path);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(pictureBox3.ClientRectangle);
            pictureBox3.Region = new Region(path2);

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(pictureBox4.ClientRectangle);
            pictureBox4.Region = new Region(path3);

            GraphicsPath path4 = new GraphicsPath();
            path4.AddEllipse(pictureBox5.ClientRectangle);
            pictureBox5.Region = new Region(path4);

            GraphicsPath path5 = new GraphicsPath();
            path5.AddEllipse(pictureBox6.ClientRectangle);
            pictureBox6.Region = new Region(path5);

            GraphicsPath path6 = new GraphicsPath();
            path6.AddEllipse(pictureBox7.ClientRectangle);
            pictureBox7.Region = new Region(path6);
        }

        //for changing color of panels
        private void Panel__MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(29, 45, 87);
        }

        private void Panel__MouseLeave(object sender, EventArgs e) 
        {
            ((Panel)sender).BackColor = Color.FromArgb(18, 27, 51);
        }

        //for changing color of panels with picture box
        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Parent.BackColor = Color.FromArgb(29, 45, 87);
        }

        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Parent.BackColor = Color.FromArgb(18, 27, 51);
        }

        //for changing color of panels with lables
        private void Label__MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.FromArgb(29, 45, 87);
        }

        private void Label__MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Parent.BackColor = Color.FromArgb(18, 27, 51);
        }

        private void Settings__MouseEnter(Object sender, EventArgs e)
        {
           
        }

        //go to teams page
        private void Teams__Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
         


        }

        //go to profile page
        private void Profile__Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();



        }

        //go to settings page
        private void Settings__Click(object sender, EventArgs e)
        {
            //this.Hide();
            form3.ShowDialog();
            UpdateColorMode();



        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Settings_ColorChangeEvent(object sender, EventArgs e)
        {
            // Adjust color in response to the color change
            UpdateColorMode();
        }
        private void UpdateColorMode()
        {
            // Retrieve the color mode from Form3
            string colorMode = settings.getColorMode();

            // Implement your color changes based on the color mode
            if (colorMode == "0")
            {
                // Example: Set a dark mode color
                this.BackColor = Color.FromArgb(0, 0, 0);
                // Additional color changes based on your requirements...
            }
            else if (colorMode == "1")
            {
                // Example: Set a light mode color
                this.BackColor = Color.FromArgb(255, 255, 255);
                // Additional color changes based on your requirements...
            }
        }

    }
}
