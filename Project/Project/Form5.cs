using Final___Search_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CustomizeButton(richTextBox1);
            String[] chairBearGames = { "Overwatch 2", "Fortnite" };
            MemberInfo(richTextBox1, "ChairBear", "Member", 3, chairBearGames);
            richTextBox1.Click += richTextBox1_Click;

            CustomizeButton(richTextBox2);
            String[] legendGames = { "Overwatch 2", "Valorant" };
            MemberInfo(richTextBox2, "The Legend 27", "President", 1, legendGames);
            richTextBox2.Click += richTextBox2_Click;

            CustomizeButton(richTextBox3);
            String[] katGames = { "Overwatch 2", "Nba 2k24" };
            MemberInfo(richTextBox3, "Keyboard Kat", "Vice President", 2, katGames);
            richTextBox3.Click += richTextBox3_Click;

            TeamPanel.Click += TeamPanel_Click;
            this.homeButton.Click += new EventHandler(homeButton_Click);
            this.ChatButton1.Click += new EventHandler(ChatButton1_Click);
            this.ChatButton2.Click += new EventHandler(ChatButton2_Click);
            this.ChatButton3.Click += new EventHandler(ChatButton3_Click);
        }

        public void MemberInfo(RichTextBox richTextBox, String name, String role, int rank, String[] games)
        {
            String memberName = name;
            String memberRole = role;
            int memberRank = rank;
            String[] memberGames = games;
            richTextBox.ReadOnly = true;
            // Format the member information with rich text formatting
            string memberInfo = $"\n\n\n\n{memberName}\n{memberRole}\nRank: {memberRank}\nGames: {string.Join(", ", memberGames)}";

            // Clear existing text and append the formatted member information
            richTextBox.Clear();
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold); // Set bold font for the title
            richTextBox.AppendText(memberInfo);

            richTextBox.SelectionStart = richTextBox.Text.IndexOf(memberName[0]);
            richTextBox.SelectionLength = memberName.Length;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.SelectionColor = ColorTranslator.FromHtml("#F17D19");

            // Set the starting position for the remaining text
            int startIndex = richTextBox.Text.IndexOf(memberRole);
            int length = richTextBox.Text.Length - startIndex;

            richTextBox.SelectionStart = startIndex;
            richTextBox.SelectionLength = length;
            richTextBox.SelectionColor = Color.White;

            richTextBox.SelectionStart = richTextBox.Text.IndexOf(memberRole[0]);
            richTextBox.SelectionLength = memberRole.Length;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;

            string richTextBoxText = richTextBox.Text;




        }
        private void CustomizeButton(RichTextBox prof)
        {
            // Set the appearance of the button


            // Set the rounded corners by modifying the Region property
            int radius = 15; // Adjust the radius as needed
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(prof.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(prof.Width - radius, prof.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, prof.Height - radius, radius, radius, 90, 90);
            prof.Region = new Region(path);


        }
        private void tProf1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            // Handle the click event here
            panel1.Visible = true;
        }

        private void richTextBox2_Click(object sender, EventArgs e)
        {
            // Handle the click event here
            panel2.Visible = true;
        }
        private void richTextBox3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChatButton1_Click(object sender, EventArgs e)
        {

            Chat form6 = new Chat();
            this.Close();
            this.Hide();
            form6.ShowDialog();

        }
        private void ChatButton2_Click(object sender, EventArgs e)
        {
            Chat form6 = new Chat();
            this.Close();
            this.Hide();
            form6.ShowDialog();

        }
        private void ChatButton3_Click(object sender, EventArgs e)
        {
            Chat form6 = new Chat();
            this.Close();
            this.Hide();
            form6.ShowDialog();

        }

        private void TeamPanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {

        }

    }
}
