namespace PlayThis
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.currentMoodTextBox = new System.Windows.Forms.TextBox();
            this.currentMoodLabel = new System.Windows.Forms.Label();
            this.changeMoodLabel = new System.Windows.Forms.Label();
            this.changeMoodTextBox = new System.Windows.Forms.TextBox();
            this.initTestButton = new System.Windows.Forms.Button();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.enterGenreLabel = new System.Windows.Forms.Label();
            this.catOneLabel = new System.Windows.Forms.Label();
            this.catTwoLabel = new System.Windows.Forms.Label();
            this.emotionThreeLabel = new System.Windows.Forms.Label();
            this.emotionOneLabel = new System.Windows.Forms.Label();
            this.emotionTwoLabel = new System.Windows.Forms.Label();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.enterGenreTextBox = new System.Windows.Forms.TextBox();
            this.catOneTextBox = new System.Windows.Forms.TextBox();
            this.catTwoTextBox = new System.Windows.Forms.TextBox();
            this.emotionOneTextBox = new System.Windows.Forms.TextBox();
            this.emotionTwoTextBox = new System.Windows.Forms.TextBox();
            this.emotionThreeTextBox = new System.Windows.Forms.TextBox();
            this.meTalkingToAaronText = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 374);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.initTestButton);
            this.tabPage1.Controls.Add(this.changeMoodTextBox);
            this.tabPage1.Controls.Add(this.changeMoodLabel);
            this.tabPage1.Controls.Add(this.currentMoodLabel);
            this.tabPage1.Controls.Add(this.currentMoodTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game Suggestion Quiz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.emotionThreeTextBox);
            this.tabPage2.Controls.Add(this.emotionTwoTextBox);
            this.tabPage2.Controls.Add(this.emotionOneTextBox);
            this.tabPage2.Controls.Add(this.catTwoTextBox);
            this.tabPage2.Controls.Add(this.catOneTextBox);
            this.tabPage2.Controls.Add(this.enterGenreTextBox);
            this.tabPage2.Controls.Add(this.enterNameTextBox);
            this.tabPage2.Controls.Add(this.emotionTwoLabel);
            this.tabPage2.Controls.Add(this.emotionOneLabel);
            this.tabPage2.Controls.Add(this.emotionThreeLabel);
            this.tabPage2.Controls.Add(this.catTwoLabel);
            this.tabPage2.Controls.Add(this.catOneLabel);
            this.tabPage2.Controls.Add(this.enterGenreLabel);
            this.tabPage2.Controls.Add(this.enterNameLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add a Game to my Library";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.meTalkingToAaronText);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Games in Library";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // currentMoodTextBox
            // 
            this.currentMoodTextBox.Location = new System.Drawing.Point(33, 56);
            this.currentMoodTextBox.Name = "currentMoodTextBox";
            this.currentMoodTextBox.Size = new System.Drawing.Size(124, 20);
            this.currentMoodTextBox.TabIndex = 0;
            this.currentMoodTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // currentMoodLabel
            // 
            this.currentMoodLabel.AutoSize = true;
            this.currentMoodLabel.Location = new System.Drawing.Point(30, 25);
            this.currentMoodLabel.Name = "currentMoodLabel";
            this.currentMoodLabel.Size = new System.Drawing.Size(476, 13);
            this.currentMoodLabel.TabIndex = 1;
            this.currentMoodLabel.Text = "What is your current mood? (We\'ll save this as a variable)( It should be a drop-d" +
    "own multiple choice)";
            // 
            // changeMoodLabel
            // 
            this.changeMoodLabel.AutoSize = true;
            this.changeMoodLabel.Location = new System.Drawing.Point(30, 151);
            this.changeMoodLabel.Name = "changeMoodLabel";
            this.changeMoodLabel.Size = new System.Drawing.Size(541, 13);
            this.changeMoodLabel.TabIndex = 2;
            this.changeMoodLabel.Text = "Do you want to change your mood? (Again, we\'ll store this as a variable) ( Drop-d" +
    "own \"Yes\", \"No\", \"I\'m not sure\")";
            // 
            // changeMoodTextBox
            // 
            this.changeMoodTextBox.Location = new System.Drawing.Point(33, 181);
            this.changeMoodTextBox.Name = "changeMoodTextBox";
            this.changeMoodTextBox.Size = new System.Drawing.Size(124, 20);
            this.changeMoodTextBox.TabIndex = 3;
            this.changeMoodTextBox.TextChanged += new System.EventHandler(this.changeMoodTextBox_TextChanged);
            // 
            // initTestButton
            // 
            this.initTestButton.Location = new System.Drawing.Point(243, 248);
            this.initTestButton.Name = "initTestButton";
            this.initTestButton.Size = new System.Drawing.Size(190, 53);
            this.initTestButton.TabIndex = 4;
            this.initTestButton.Text = "Take the Test!";
            this.initTestButton.UseVisualStyleBackColor = true;
            this.initTestButton.Click += new System.EventHandler(this.initTestButton_Click);
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(28, 28);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(58, 13);
            this.enterNameLabel.TabIndex = 0;
            this.enterNameLabel.Text = "Game Title";
            // 
            // enterGenreLabel
            // 
            this.enterGenreLabel.AutoSize = true;
            this.enterGenreLabel.Location = new System.Drawing.Point(28, 126);
            this.enterGenreLabel.Name = "enterGenreLabel";
            this.enterGenreLabel.Size = new System.Drawing.Size(67, 13);
            this.enterGenreLabel.TabIndex = 1;
            this.enterGenreLabel.Text = "Game Genre";
            // 
            // catOneLabel
            // 
            this.catOneLabel.AutoSize = true;
            this.catOneLabel.Location = new System.Drawing.Point(311, 28);
            this.catOneLabel.Name = "catOneLabel";
            this.catOneLabel.Size = new System.Drawing.Size(151, 13);
            this.catOneLabel.TabIndex = 2;
            this.catOneLabel.Text = "Enter a category for this game:";
            // 
            // catTwoLabel
            // 
            this.catTwoLabel.AutoSize = true;
            this.catTwoLabel.Location = new System.Drawing.Point(311, 126);
            this.catTwoLabel.Name = "catTwoLabel";
            this.catTwoLabel.Size = new System.Drawing.Size(177, 13);
            this.catTwoLabel.TabIndex = 3;
            this.catTwoLabel.Text = "Enter 1 more category for this game:";
            // 
            // emotionThreeLabel
            // 
            this.emotionThreeLabel.AutoSize = true;
            this.emotionThreeLabel.Location = new System.Drawing.Point(484, 244);
            this.emotionThreeLabel.Name = "emotionThreeLabel";
            this.emotionThreeLabel.Size = new System.Drawing.Size(237, 13);
            this.emotionThreeLabel.TabIndex = 4;
            this.emotionThreeLabel.Text = "List one more emotion assoicated with this game:";
            // 
            // emotionOneLabel
            // 
            this.emotionOneLabel.AutoSize = true;
            this.emotionOneLabel.Location = new System.Drawing.Point(561, 28);
            this.emotionOneLabel.Name = "emotionOneLabel";
            this.emotionOneLabel.Size = new System.Drawing.Size(178, 13);
            this.emotionOneLabel.TabIndex = 5;
            this.emotionOneLabel.Text = "How does this game make you feel?";
            // 
            // emotionTwoLabel
            // 
            this.emotionTwoLabel.AutoSize = true;
            this.emotionTwoLabel.Location = new System.Drawing.Point(561, 126);
            this.emotionTwoLabel.Name = "emotionTwoLabel";
            this.emotionTwoLabel.Size = new System.Drawing.Size(160, 13);
            this.emotionTwoLabel.TabIndex = 6;
            this.emotionTwoLabel.Text = "How else does it make you feel?";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Location = new System.Drawing.Point(31, 56);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.enterNameTextBox.TabIndex = 7;
            this.enterNameTextBox.TextChanged += new System.EventHandler(this.enterNameTextBox_TextChanged);
            // 
            // enterGenreTextBox
            // 
            this.enterGenreTextBox.Location = new System.Drawing.Point(31, 162);
            this.enterGenreTextBox.Name = "enterGenreTextBox";
            this.enterGenreTextBox.Size = new System.Drawing.Size(154, 20);
            this.enterGenreTextBox.TabIndex = 8;
            this.enterGenreTextBox.TextChanged += new System.EventHandler(this.enterGenreTextBox_TextChanged);
            // 
            // catOneTextBox
            // 
            this.catOneTextBox.Location = new System.Drawing.Point(314, 55);
            this.catOneTextBox.Name = "catOneTextBox";
            this.catOneTextBox.Size = new System.Drawing.Size(148, 20);
            this.catOneTextBox.TabIndex = 9;
            this.catOneTextBox.TextChanged += new System.EventHandler(this.catOneTextBox_TextChanged);
            // 
            // catTwoTextBox
            // 
            this.catTwoTextBox.Location = new System.Drawing.Point(314, 161);
            this.catTwoTextBox.Name = "catTwoTextBox";
            this.catTwoTextBox.Size = new System.Drawing.Size(148, 20);
            this.catTwoTextBox.TabIndex = 10;
            this.catTwoTextBox.TextChanged += new System.EventHandler(this.catTwoTextBox_TextChanged);
            // 
            // emotionOneTextBox
            // 
            this.emotionOneTextBox.Location = new System.Drawing.Point(564, 55);
            this.emotionOneTextBox.Name = "emotionOneTextBox";
            this.emotionOneTextBox.Size = new System.Drawing.Size(135, 20);
            this.emotionOneTextBox.TabIndex = 11;
            this.emotionOneTextBox.TextChanged += new System.EventHandler(this.emotionOneTextBox_TextChanged);
            // 
            // emotionTwoTextBox
            // 
            this.emotionTwoTextBox.Location = new System.Drawing.Point(564, 161);
            this.emotionTwoTextBox.Name = "emotionTwoTextBox";
            this.emotionTwoTextBox.Size = new System.Drawing.Size(135, 20);
            this.emotionTwoTextBox.TabIndex = 12;
            this.emotionTwoTextBox.TextChanged += new System.EventHandler(this.emotionTwoTextBox_TextChanged);
            // 
            // emotionThreeTextBox
            // 
            this.emotionThreeTextBox.Location = new System.Drawing.Point(564, 282);
            this.emotionThreeTextBox.Name = "emotionThreeTextBox";
            this.emotionThreeTextBox.Size = new System.Drawing.Size(135, 20);
            this.emotionThreeTextBox.TabIndex = 13;
            this.emotionThreeTextBox.TextChanged += new System.EventHandler(this.emotionThreeTextBox_TextChanged);
            // 
            // meTalkingToAaronText
            // 
            this.meTalkingToAaronText.AutoSize = true;
            this.meTalkingToAaronText.Location = new System.Drawing.Point(139, 63);
            this.meTalkingToAaronText.Name = "meTalkingToAaronText";
            this.meTalkingToAaronText.Size = new System.Drawing.Size(327, 13);
            this.meTalkingToAaronText.TabIndex = 0;
            this.meTalkingToAaronText.Text = "Don\'t worry about this page yet. We have to be able to pull data first";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Game My Mood!";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox currentMoodTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button initTestButton;
        private System.Windows.Forms.TextBox changeMoodTextBox;
        private System.Windows.Forms.Label changeMoodLabel;
        private System.Windows.Forms.Label currentMoodLabel;
        private System.Windows.Forms.TextBox emotionThreeTextBox;
        private System.Windows.Forms.TextBox emotionTwoTextBox;
        private System.Windows.Forms.TextBox emotionOneTextBox;
        private System.Windows.Forms.TextBox catTwoTextBox;
        private System.Windows.Forms.TextBox catOneTextBox;
        private System.Windows.Forms.TextBox enterGenreTextBox;
        private System.Windows.Forms.TextBox enterNameTextBox;
        private System.Windows.Forms.Label emotionTwoLabel;
        private System.Windows.Forms.Label emotionOneLabel;
        private System.Windows.Forms.Label emotionThreeLabel;
        private System.Windows.Forms.Label catTwoLabel;
        private System.Windows.Forms.Label catOneLabel;
        private System.Windows.Forms.Label enterGenreLabel;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Label meTalkingToAaronText;
    }
}

