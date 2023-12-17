namespace Final___Search_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchGameTextBox = new System.Windows.Forms.TextBox();
            this.requestGameTextBox = new System.Windows.Forms.TextBox();
            this.requestGameButton = new System.Windows.Forms.Button();
            this.searchGameButton = new System.Windows.Forms.Button();
            this.teamLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gameTableLayoutPanel
            // 
            this.gameTableLayoutPanel.AutoScroll = true;
            this.gameTableLayoutPanel.ColumnCount = 2;
            this.gameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTableLayoutPanel.Location = new System.Drawing.Point(26, 159);
            this.gameTableLayoutPanel.Name = "gameTableLayoutPanel";
            this.gameTableLayoutPanel.RowCount = 2;
            this.gameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gameTableLayoutPanel.Size = new System.Drawing.Size(390, 234);
            this.gameTableLayoutPanel.TabIndex = 0;
            // 
            // searchGameTextBox
            // 
            this.searchGameTextBox.Location = new System.Drawing.Point(36, 124);
            this.searchGameTextBox.Name = "searchGameTextBox";
            this.searchGameTextBox.Size = new System.Drawing.Size(188, 20);
            this.searchGameTextBox.TabIndex = 1;
            this.searchGameTextBox.Text = "Search For A Game!";
            // 
            // requestGameTextBox
            // 
            this.requestGameTextBox.Location = new System.Drawing.Point(36, 407);
            this.requestGameTextBox.Name = "requestGameTextBox";
            this.requestGameTextBox.Size = new System.Drawing.Size(188, 20);
            this.requestGameTextBox.TabIndex = 2;
            this.requestGameTextBox.Text = "Request a Game";
            // 
            // requestGameButton
            // 
            this.requestGameButton.Location = new System.Drawing.Point(246, 407);
            this.requestGameButton.Name = "requestGameButton";
            this.requestGameButton.Size = new System.Drawing.Size(75, 23);
            this.requestGameButton.TabIndex = 3;
            this.requestGameButton.Text = "Request Game!";
            this.requestGameButton.UseVisualStyleBackColor = true;
            // 
            // searchGameButton
            // 
            this.searchGameButton.Location = new System.Drawing.Point(273, 121);
            this.searchGameButton.Name = "searchGameButton";
            this.searchGameButton.Size = new System.Drawing.Size(75, 23);
            this.searchGameButton.TabIndex = 4;
            this.searchGameButton.Text = "Seach Game";
            this.searchGameButton.UseVisualStyleBackColor = true;
            // 
            // teamLayoutPanel
            // 
            this.teamLayoutPanel.AutoScroll = true;
            this.teamLayoutPanel.ColumnCount = 3;
            this.teamLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.teamLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.teamLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.teamLayoutPanel.Location = new System.Drawing.Point(536, 159);
            this.teamLayoutPanel.Name = "teamLayoutPanel";
            this.teamLayoutPanel.RowCount = 1;
            this.teamLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.teamLayoutPanel.Size = new System.Drawing.Size(208, 67);
            this.teamLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(309, 69);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Find the game you want to play by inserting its title in the search bar below, th" +
    "en hit search! Clicking on any result will show which teams are playing that gam" +
    "e";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pick a Platform (Optional)",
            "PC",
            "Xbox One",
            "PlayStation 5",
            "Nintendo Switch",
            "Xbox Series S",
            "PlayStation 4"});
            this.comboBox1.Location = new System.Drawing.Point(536, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Enter Team Name (Optional)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamLayoutPanel);
            this.Controls.Add(this.searchGameButton);
            this.Controls.Add(this.requestGameButton);
            this.Controls.Add(this.requestGameTextBox);
            this.Controls.Add(this.searchGameTextBox);
            this.Controls.Add(this.gameTableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gameTableLayoutPanel;
        private System.Windows.Forms.TextBox searchGameTextBox;
        private System.Windows.Forms.TextBox requestGameTextBox;
        private System.Windows.Forms.Button requestGameButton;
        private System.Windows.Forms.Button searchGameButton;
        private System.Windows.Forms.TableLayoutPanel teamLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

