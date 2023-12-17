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
            this.teamSearchTextBox = new System.Windows.Forms.TextBox();
            this.searcherGroupBox = new System.Windows.Forms.GroupBox();
            this.requesterGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.teamResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.searcherGroupBox.SuspendLayout();
            this.requesterGroupBox.SuspendLayout();
            this.teamResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTableLayoutPanel
            // 
            this.gameTableLayoutPanel.AutoScroll = true;
            this.gameTableLayoutPanel.ColumnCount = 2;
            this.gameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.gameTableLayoutPanel.Location = new System.Drawing.Point(18, 128);
            this.gameTableLayoutPanel.Name = "gameTableLayoutPanel";
            this.gameTableLayoutPanel.RowCount = 2;
            this.gameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.gameTableLayoutPanel.Size = new System.Drawing.Size(365, 274);
            this.gameTableLayoutPanel.TabIndex = 0;
            // 
            // searchGameTextBox
            // 
            this.searchGameTextBox.Location = new System.Drawing.Point(18, 94);
            this.searchGameTextBox.Name = "searchGameTextBox";
            this.searchGameTextBox.Size = new System.Drawing.Size(188, 20);
            this.searchGameTextBox.TabIndex = 1;
            this.searchGameTextBox.Text = "Search For A Game!";
            // 
            // requestGameTextBox
            // 
            this.requestGameTextBox.Location = new System.Drawing.Point(9, 78);
            this.requestGameTextBox.Name = "requestGameTextBox";
            this.requestGameTextBox.Size = new System.Drawing.Size(158, 20);
            this.requestGameTextBox.TabIndex = 2;
            this.requestGameTextBox.Text = "Request a Game";
            // 
            // requestGameButton
            // 
            this.requestGameButton.Location = new System.Drawing.Point(174, 77);
            this.requestGameButton.Name = "requestGameButton";
            this.requestGameButton.Size = new System.Drawing.Size(75, 23);
            this.requestGameButton.TabIndex = 3;
            this.requestGameButton.Text = "Request Game!";
            this.requestGameButton.UseVisualStyleBackColor = true;
            // 
            // searchGameButton
            // 
            this.searchGameButton.Location = new System.Drawing.Point(333, 94);
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
            this.teamLayoutPanel.Location = new System.Drawing.Point(14, 83);
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
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(18, 19);
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
            this.comboBox1.Location = new System.Drawing.Point(14, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // teamSearchTextBox
            // 
            this.teamSearchTextBox.Location = new System.Drawing.Point(14, 30);
            this.teamSearchTextBox.Name = "teamSearchTextBox";
            this.teamSearchTextBox.Size = new System.Drawing.Size(156, 20);
            this.teamSearchTextBox.TabIndex = 8;
            this.teamSearchTextBox.Text = "Enter Team Name (Optional)";
            // 
            // searcherGroupBox
            // 
            this.searcherGroupBox.Controls.Add(this.gameTableLayoutPanel);
            this.searcherGroupBox.Controls.Add(this.richTextBox1);
            this.searcherGroupBox.Controls.Add(this.searchGameTextBox);
            this.searcherGroupBox.Controls.Add(this.searchGameButton);
            this.searcherGroupBox.Location = new System.Drawing.Point(36, 28);
            this.searcherGroupBox.Name = "searcherGroupBox";
            this.searcherGroupBox.Size = new System.Drawing.Size(427, 410);
            this.searcherGroupBox.TabIndex = 9;
            this.searcherGroupBox.TabStop = false;
            // 
            // requesterGroupBox
            // 
            this.requesterGroupBox.Controls.Add(this.richTextBox2);
            this.requesterGroupBox.Controls.Add(this.requestGameTextBox);
            this.requesterGroupBox.Controls.Add(this.requestGameButton);
            this.requesterGroupBox.Location = new System.Drawing.Point(493, 332);
            this.requesterGroupBox.Name = "requesterGroupBox";
            this.requesterGroupBox.Size = new System.Drawing.Size(269, 106);
            this.requesterGroupBox.TabIndex = 10;
            this.requesterGroupBox.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(11, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(238, 53);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "Is your game not available? Enter its game title here and we will review it to be" +
    " added to the database";
            // 
            // teamResultsGroupBox
            // 
            this.teamResultsGroupBox.Controls.Add(this.teamLayoutPanel);
            this.teamResultsGroupBox.Controls.Add(this.comboBox1);
            this.teamResultsGroupBox.Controls.Add(this.teamSearchTextBox);
            this.teamResultsGroupBox.Location = new System.Drawing.Point(493, 28);
            this.teamResultsGroupBox.Name = "teamResultsGroupBox";
            this.teamResultsGroupBox.Size = new System.Drawing.Size(269, 298);
            this.teamResultsGroupBox.TabIndex = 11;
            this.teamResultsGroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teamResultsGroupBox);
            this.Controls.Add(this.requesterGroupBox);
            this.Controls.Add(this.searcherGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.searcherGroupBox.ResumeLayout(false);
            this.searcherGroupBox.PerformLayout();
            this.requesterGroupBox.ResumeLayout(false);
            this.requesterGroupBox.PerformLayout();
            this.teamResultsGroupBox.ResumeLayout(false);
            this.teamResultsGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox teamSearchTextBox;
        private System.Windows.Forms.GroupBox searcherGroupBox;
        private System.Windows.Forms.GroupBox requesterGroupBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox teamResultsGroupBox;
    }
}

