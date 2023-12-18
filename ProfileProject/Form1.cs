using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProfileProjectv4
{
    public partial class Form1 : Form
    {
        // Variables to store user data
        private string username = "BabyGronkinator";
        private string status = "";

        public Form1()
        {
            InitializeComponent();
            // Initialize the form with default data
            label1.Text = username;
            label7.Text = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Edit Username button click event
            string newUsername = PromptForInput("Enter your new username:", "Edit Username", username);
            if (!string.IsNullOrEmpty(newUsername))
            {
                username = newUsername;
                label1.Text = username;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Confirm Update button click event
            status = textBox1.Text;
            label7.Text = $"\"{status}\"";
            label7.TextAlign = ContentAlignment.MiddleCenter; // Center-align the text
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Change Background button click event
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Preview Profile button click event
            textBox1.Visible = false;
            comboBox1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // Back button click event
            textBox1.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Update Photo button click event
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private string PromptForInput(string prompt, string title, string defaultValue)
        {
            // Display an input dialog and return the entered value
            Form promptForm = new Form();
            promptForm.Width = 300;
            promptForm.Height = 150;
            promptForm.Text = title;

            Label promptLabel = new Label() { Left = 20, Top = 20, Width = 260, Text = prompt };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 260, Text = defaultValue };
            Button confirmation = new Button() { Text = "Ok", Left = 110, Width = 70, Top = 70 };

            confirmation.Click += (sender, e) => { promptForm.Close(); };

            promptForm.Controls.Add(confirmation);
            promptForm.Controls.Add(promptLabel);
            promptForm.Controls.Add(textBox);

            promptForm.ShowDialog();

            return textBox.Text;
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
