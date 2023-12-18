using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfileLib;

namespace Project
{
    public partial class Form3 : Form
    {
        Profile profile;
        List<string> feedback = new List<string>();

        public int TextSize;
        public string ColorMode;

        public event EventHandler ColorChangeEvent;

        public Form3()
        {
            InitializeComponent();

            //form default settings
            this.Size = new Size(816, 489);
            this.MaximumSize = this.MinimumSize = this.Size;

            //Settings tab button event handlers
            this.profileButton.Click += new EventHandler(ProfileButton__Click);
            this.accessButton.Click += new EventHandler(AccessButton__Click);
            this.aboutButton.Click += new EventHandler(AboutButton__Click);
            this.helpButton.Click += new EventHandler(HelpButton__Click);



            //Text Combo Box
            this.textComboBox.Items.Add("8");
            this.textComboBox.Items.Add("10");
            this.textComboBox.Items.Add("12");
            this.textComboBox.Items.Add("14");

            this.textComboBox.KeyPress += new KeyPressEventHandler(TextComboBox_KeyPress);
            this.textComboBox.SelectedIndexChanged += new EventHandler(TextComboBox__SelectedIndexChanged);

            //displayComboBox
            this.displayComboBox.Items.Add("Dark");
            this.displayComboBox.Items.Add("Light");
            this.displayComboBox.SelectedIndex = 0;

            this.displayComboBox.KeyPress += new KeyPressEventHandler(TextComboBox_KeyPress);
            this.displayComboBox.SelectedIndexChanged += new EventHandler(DisplayComboBox__SelectedIndexChanged);

            //about tab text box
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.ScrollBars = ScrollBars.Vertical;

            //faq text box and contact text box
            this.faqTextBox.Multiline = true;
            this.faqTextBox.ScrollBars = ScrollBars.Vertical;
            this.contactTextBox.Multiline = true;
            this.contactTextBox.ScrollBars = ScrollBars.Vertical;


            //button asthetics
            this.profileButton.FlatStyle = FlatStyle.Flat;
            this.profileButton.FlatAppearance.BorderSize = 0;

            this.accessButton.FlatStyle = FlatStyle.Flat;
            this.accessButton.FlatAppearance.BorderSize = 0;

            this.aboutButton.FlatStyle = FlatStyle.Flat;
            this.aboutButton.FlatAppearance.BorderSize = 0;

            this.helpButton.FlatStyle = FlatStyle.Flat;
            this.helpButton.FlatAppearance.BorderSize = 0;

            this.usernameButton.FlatStyle = FlatStyle.Flat;
            this.usernameButton.FlatAppearance.BorderSize = 0;

            this.imageButton.FlatStyle = FlatStyle.Flat;
            this.imageButton.FlatAppearance.BorderSize = 0;

            this.emailButton.FlatStyle = FlatStyle.Flat;
            this.emailButton.FlatAppearance.BorderSize = 0;

            this.passwordButton.FlatStyle = FlatStyle.Flat;
            this.passwordButton.FlatAppearance.BorderSize = 0;

            this.settingsGroupBox.FlatStyle = FlatStyle.Flat;
            //this.settingsGroupBox.FlatAppearance.BorderSize = 0;

            //initialization of profile object
            profile = new Profile();

            //username settings
            profile.username = "user1";

            this.usernameTextBox.Text = profile.username;
            this.usernameTextBox.BorderStyle = BorderStyle.None;

            this.usernameButton.Click += new EventHandler(UsernameButton__Click);

            //email settings
            profile.email = "******@email.com";
            this.emailTextBox.Text = profile.email;
            this.emailTextBox.BorderStyle = BorderStyle.None;
            this.emailButton.Click += new EventHandler(EmailButton__Click);

            //password settings
            profile.password = "Password";

            this.passwordTextBox.Text = profile.password;
            this.passwordButton.Click += new EventHandler(PassowrdButton__Click);

            //image button event handlers 
            this.imageButton.Click += new EventHandler(ImageButton__Click);

            //contact button even handler
            this.contactButton.Click += new EventHandler(ContactButton__Click);

            //back button
            this.homeBox.Click += new EventHandler(HomeBox__Click);

            TextSize = int.Parse(this.textComboBox.SelectedItem.ToString());
            ColorMode = this.displayComboBox.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProfileButton__Click(object sender, EventArgs e)
        {
            //profile tab display
            this.profilePictureBox.Visible = true;
            this.profileLabel.Visible = true;
            this.usernameTextBox.Visible = true;
            this.usernameButton.Visible = true;
            this.imageButton.Visible = true;
            this.profileLabel2.Visible = true;
            this.emailButton.Visible = true;
            this.emailTitleLabel.Visible = true;
            this.emailTextBox.Visible = true;
            this.passwordTitleLabel.Visible = true;
            this.passwordButton.Visible = true;
            this.passwordTextBox.Visible = true;

            //access and display tab
            this.accessLabel.Visible = false;
            this.textSizeLabel.Visible = false;
            this.colorModeLabel.Visible = false;
            this.textComboBox.Visible = false;
            this.displayComboBox.Visible = false;

            //about tab
            this.aboutLabel.Visible = false;
            this.aboutTextBox.Visible = false;

            //help and support tab
            this.helpLabel.Visible = false;
            this.contactTextBox.Visible = false;
            this.faqLabel.Visible = false;
            this.faqTextBox.Visible = false;
            this.contactLabel.Visible = false;
            this.contactButton.Visible = false;


            ResetButtonColors();

            if (this.displayComboBox.SelectedItem != null)
            {
                if (this.displayComboBox.SelectedItem.ToString() == "Dark")
                {
                    // Set dark mode button colors
                    this.profileButton.BackColor = Color.FromArgb(1, 40, 71);
                    this.profileButton.ForeColor = Color.White;
                }
                else if (this.displayComboBox.SelectedItem.ToString() == "Light")
                {
                    // Set light mode button colors
                    this.profileButton.BackColor = Color.FromArgb(69, 139, 196);
                    this.profileButton.ForeColor = Color.Black;
                }
            }
        }

        private void AccessButton__Click(object sender, EventArgs e)
        {
            //access tab
            this.accessLabel.Visible = true;
            this.textSizeLabel.Visible = true;
            this.colorModeLabel.Visible = true;
            this.textComboBox.Visible = true;
            this.displayComboBox.Visible = true;

            //profile tab
            this.profilePictureBox.Visible = false;
            this.profileLabel.Visible = false;
            this.usernameTextBox.Visible = false;
            this.usernameButton.Visible = false;
            this.imageButton.Visible = false;
            this.profileLabel2.Visible = false;
            this.emailButton.Visible = false;
            this.emailTitleLabel.Visible = false;
            this.emailTextBox.Visible = false;
            this.passwordTitleLabel.Visible = false;
            this.passwordButton.Visible = false;
            this.passwordTextBox.Visible = false;

            //about tab
            this.aboutLabel.Visible = false;
            this.aboutTextBox.Visible = false;

            //help and support tab
            this.helpLabel.Visible = false;
            this.contactTextBox.Visible = false;
            this.faqLabel.Visible = false;
            this.faqTextBox.Visible = false;
            this.contactLabel.Visible = false;
            this.contactButton.Visible = false;


            ResetButtonColors();

            if (this.displayComboBox.SelectedItem != null)
            {
                if (this.displayComboBox.SelectedItem.ToString() == "Dark")
                {
                    // Set dark mode button colors
                    this.accessButton.BackColor = Color.FromArgb(1, 40, 71);
                    this.accessButton.ForeColor = Color.White;
                }
                else if (this.displayComboBox.SelectedItem.ToString() == "Light")
                {
                    // Set light mode button colors
                    this.accessButton.BackColor = Color.FromArgb(69, 139, 196);
                    this.accessButton.ForeColor = Color.Black;
                }
            }
        }

        private void AboutButton__Click(Object sender, EventArgs e)
        {
            //about tab
            this.aboutLabel.Visible = true;
            this.aboutTextBox.Visible = true;

            //profile tab
            this.profilePictureBox.Visible = false;
            this.profileLabel.Visible = false;
            this.usernameTextBox.Visible = false;
            this.usernameButton.Visible = false;
            this.imageButton.Visible = false;
            this.profileLabel2.Visible = false;
            this.emailButton.Visible = false;
            this.emailTitleLabel.Visible = false;
            this.emailTextBox.Visible = false;
            this.passwordTitleLabel.Visible = false;
            this.passwordButton.Visible = false;
            this.passwordTextBox.Visible = false;

            //access and display tab
            this.accessLabel.Visible = false;
            this.textSizeLabel.Visible = false;
            this.colorModeLabel.Visible = false;
            this.textComboBox.Visible = false;
            this.displayComboBox.Visible = false;

            //help and support tab
            this.helpLabel.Visible = false;
            this.contactTextBox.Visible = false;
            this.faqLabel.Visible = false;
            this.faqTextBox.Visible = false;
            this.contactLabel.Visible = false;
            this.contactButton.Visible = false;

            ResetButtonColors();

            if (this.displayComboBox.SelectedItem != null)
            {
                if (this.displayComboBox.SelectedItem.ToString() == "Dark")
                {
                    // Set dark mode button colors
                    this.aboutButton.BackColor = Color.FromArgb(1, 40, 71);
                    this.aboutButton.ForeColor = Color.White;
                }
                else if (this.displayComboBox.SelectedItem.ToString() == "Light")
                {
                    // Set light mode button colors
                    this.aboutButton.BackColor = Color.FromArgb(69, 139, 196);
                    this.aboutButton.ForeColor = Color.Black;
                }
            }
        }

        private void HelpButton__Click(object sender, EventArgs e)
        {
            this.helpLabel.Visible = true;
            this.contactTextBox.Visible = true;
            this.faqLabel.Visible = true;
            this.faqTextBox.Visible = true;
            this.contactLabel.Visible = true;
            this.contactButton.Visible = true;

            //profile tab
            this.profilePictureBox.Visible = false;
            this.profileLabel.Visible = false;
            this.usernameTextBox.Visible = false;
            this.usernameButton.Visible = false;
            this.imageButton.Visible = false;
            this.profileLabel2.Visible = false;
            this.emailButton.Visible = false;
            this.emailTitleLabel.Visible = false;
            this.emailTextBox.Visible = false;
            this.passwordTitleLabel.Visible = false;
            this.passwordButton.Visible = false;
            this.passwordTextBox.Visible = false;

            //access and display tab
            this.accessLabel.Visible = false;
            this.textSizeLabel.Visible = false;
            this.colorModeLabel.Visible = false;
            this.textComboBox.Visible = false;
            this.displayComboBox.Visible = false;

            //about tab
            this.aboutLabel.Visible = false;
            this.aboutTextBox.Visible = false;

            ResetButtonColors();




            if (this.displayComboBox.SelectedItem != null)
            {
                if (this.displayComboBox.SelectedItem.ToString() == "Dark")
                {
                    // Set dark mode button colors
                    this.helpButton.BackColor = Color.FromArgb(1, 40, 71);
                    this.helpButton.ForeColor = Color.White;
                }
                else if (this.displayComboBox.SelectedItem.ToString() == "Light")
                {
                    // Set light mode button colors
                    this.helpButton.BackColor = Color.FromArgb(69, 139, 196);
                    this.helpButton.ForeColor = Color.Black;
                }
            }
        }

        private void ResetButtonColors()
        {
            if (this.displayComboBox.SelectedItem != null)
            {
                if (this.displayComboBox.SelectedItem.ToString() == "Dark")
                {
                    this.profileButton.BackColor = Color.FromArgb(2, 64, 113);
                    this.profileButton.ForeColor = Color.FromArgb(255, 255, 255);
                    this.accessButton.BackColor = Color.FromArgb(2, 64, 113);
                    this.accessButton.ForeColor = Color.FromArgb(255, 255, 255);
                    this.aboutButton.BackColor = Color.FromArgb(2, 64, 113);
                    this.aboutButton.ForeColor = Color.FromArgb(255, 255, 255);
                    this.helpButton.BackColor = Color.FromArgb(2, 64, 113);
                    this.helpButton.ForeColor = Color.FromArgb(255, 255, 255);
                }

                if (displayComboBox.SelectedItem.ToString() == "Light")
                {
                    this.profileButton.BackColor = Color.FromArgb(113, 180, 235);
                    this.profileButton.ForeColor = Color.FromArgb(0, 0, 0);
                    this.accessButton.BackColor = Color.FromArgb(113, 180, 235);
                    this.accessButton.ForeColor = Color.FromArgb(0, 0, 0);
                    this.aboutButton.BackColor = Color.FromArgb(113, 180, 235);
                    this.aboutButton.ForeColor = Color.FromArgb(0, 0, 0);
                    this.helpButton.BackColor = Color.FromArgb(113, 180, 235);
                    this.helpButton.ForeColor = Color.FromArgb(0, 0, 0);
                }
            }

        }

        private void TextComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSize = textComboBox.SelectedItem.ToString();

            // Convert the selected size to an integer
            if (int.TryParse(selectedSize, out int textSize))
            {
                // Set the font size for relevant controls (adjust as needed)
                this.aboutTextBox.Font = new Font(profileLabel.Font.FontFamily, textSize);
                this.faqTextBox.Font = new Font(profileLabel.Font.FontFamily, textSize);
                this.contactTextBox.Font = new Font(profileLabel.Font.FontFamily, textSize);
                this.emailTextBox.Font = new Font(profileLabel.Font.FontFamily, textSize);
                this.passwordTextBox.Font = new Font(profileLabel.Font.FontFamily, textSize);

            }
        }

        private void DisplayComboBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = displayComboBox.SelectedItem.ToString();

            if (selected == "Dark")
            {
                this.BackColor = Color.FromArgb(0, 7, 25);
                this.settingsGroupBox.BackColor = Color.FromArgb(0, 14, 48);

                this.faqTextBox.BackColor = Color.FromArgb(0, 7, 25);
                this.contactTextBox.BackColor = Color.FromArgb(0, 7, 25);
                this.aboutTextBox.BackColor = Color.FromArgb(0, 7, 25);

                this.usernameButton.BackColor = Color.FromArgb(2, 64, 113);
                this.imageButton.BackColor = Color.FromArgb(2, 64, 113);
                this.emailButton.BackColor = Color.FromArgb(2, 64, 113);
                this.passwordButton.BackColor = Color.FromArgb(2, 64, 113);

                this.usernameTextBox.BackColor = Color.FromArgb(0, 7, 25);
                this.emailTextBox.BackColor = Color.FromArgb(0, 7, 25);
                this.passwordTextBox.BackColor = Color.FromArgb(0, 7, 25);
                this.contactButton.BackColor = Color.FromArgb(2, 64, 113);

                SetAllControlsTextColor(this, Color.White);

                this.displayComboBox.ForeColor = Color.Black;
                this.textComboBox.ForeColor = Color.Black;
            }

            if (selected == "Light")
            {
                this.BackColor = Color.FromArgb(151, 195, 230);
                this.settingsGroupBox.BackColor = Color.FromArgb(196, 223, 245);
                this.profileButton.BackColor = Color.FromArgb(113, 180, 235);
                this.accessButton.BackColor = Color.FromArgb(113, 180, 235);
                this.aboutButton.BackColor = Color.FromArgb(113, 180, 235);
                this.helpButton.BackColor = Color.FromArgb(113, 180, 235);


                this.faqTextBox.BackColor = Color.FromArgb(151, 195, 230);
                this.contactTextBox.BackColor = Color.FromArgb(151, 195, 230);
                this.aboutTextBox.BackColor = Color.FromArgb(151, 195, 230);

                this.usernameButton.BackColor = Color.FromArgb(62, 141, 207);
                this.imageButton.BackColor = Color.FromArgb(62, 141, 207);
                this.emailButton.BackColor = Color.FromArgb(62, 141, 207);
                this.passwordButton.BackColor = Color.FromArgb(62, 141, 207);

                this.usernameTextBox.BackColor = Color.FromArgb(151, 195, 230);
                this.emailTextBox.BackColor = Color.FromArgb(151, 195, 230);
                this.passwordTextBox.BackColor = Color.FromArgb(151, 195, 230);
                this.contactButton.BackColor = Color.FromArgb(62, 141, 207);

                SetAllControlsTextColor(this, Color.Black);
            }
            // Invoke ColorChangeEvent when color mode changes
            OnColorChangeEvent();
        }
        private void TextComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void SetAllControlsTextColor(Control control, Color color)
        {
            control.ForeColor = color;

            foreach (Control childControl in control.Controls)
            {
                SetAllControlsTextColor(childControl, color);
            }
        }
        private void UsernameButton__Click(object sender, EventArgs e)
        {
            if (this.usernameButton.Text == "Edit Username")
            {
                this.usernameTextBox.ReadOnly = false;
                profile.username = this.usernameTextBox.Text;
                this.usernameTextBox.Text = profile.username;
                this.usernameButton.Text = "Set";
            }

            else if (this.usernameButton.Text == "Set")
            {
                this.usernameTextBox.ReadOnly = true;
                this.usernameButton.Text = "Edit Username";
            }


        }
        private void EmailButton__Click(Object sender, EventArgs e)
        {
            if (this.emailButton.Text == "Change")
            {
                this.emailTextBox.ReadOnly = false;
                profile.email = this.emailTextBox.Text;
                this.emailTextBox.Text = profile.email;
                this.emailButton.Text = "Set";
            }

            else if (this.emailButton.Text == "Set")
            {
                this.emailTextBox.ReadOnly = true;
                this.emailButton.Text = "Change";
            }
        }
        private void PassowrdButton__Click(object sender, EventArgs e)
        {
            if (this.passwordButton.Text == "Reset")
            {
                this.passwordTextBox.ReadOnly = false;
                profile.password = this.passwordTextBox.Text;
                this.passwordTextBox.Text = profile.password;
                this.passwordButton.Text = "Set";
            }

            else if (this.passwordButton.Text == "Set")
            {
                this.passwordTextBox.ReadOnly = true;
                this.passwordButton.Text = "Reset";
            }
        }
        private void ImageButton__Click(Object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected image file path
                string imagePath = openFileDialog.FileName;

                // Set the image on the imageButton
                Image image = Image.FromFile(imagePath);
                this.profilePictureBox.Image = image;

                // Optionally, you can save the image path to your profile or perform other actions.
                // For example:
                profile.profilePicture = imagePath;

                // You may want to adjust the size mode of the PictureBox depending on your layout
                this.profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void ContactButton__Click(Object sender, EventArgs e)
        {
            feedback.Add(contactTextBox.Text);
            contactTextBox.Text = "Thank you for letting us know!";
        }
        private void HomeBox__Click(Object sender, EventArgs e)
        {
            this.Close();
        }
        public string getColorMode()
        {
            return this.displayComboBox.SelectedIndex.ToString();
        }
        public int getTextSize()
        {
            return int.Parse(this.textComboBox.SelectedIndex.ToString());
        }
        protected virtual void OnColorChangeEvent()
        {
            ColorChangeEvent?.Invoke(this, EventArgs.Empty);
        }



























        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
