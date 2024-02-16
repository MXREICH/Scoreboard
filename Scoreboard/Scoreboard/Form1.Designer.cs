namespace Scoreboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonUpdate = new Button();
            groupBox2 = new GroupBox();
            button2P = new Button();
            textBoxS2 = new TextBox();
            button2M = new Button();
            label2 = new Label();
            textBoxP2 = new TextBox();
            groupBox1 = new GroupBox();
            button1P = new Button();
            button1M = new Button();
            label1 = new Label();
            textBoxS1 = new TextBox();
            textBoxP1 = new TextBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            textBoxPath = new TextBox();
            buttonOpenFile = new Button();
            label3 = new Label();
            buttonPlayerList = new Button();
            textBoxURL = new TextBox();
            buttonResetPlayers = new Button();
            buttonResetScores = new Button();
            buttonSwitchPlayers = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBoxL1 = new TextBox();
            textBoxM1 = new TextBox();
            textBoxL2 = new TextBox();
            textBoxM2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(12, 313);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(614, 63);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button2P);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxM2);
            groupBox2.Controls.Add(textBoxS2);
            groupBox2.Controls.Add(textBoxL2);
            groupBox2.Controls.Add(button2M);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxP2);
            groupBox2.Location = new Point(356, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 203);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player 2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2P
            // 
            button2P.Location = new Point(221, 67);
            button2P.Name = "button2P";
            button2P.Size = new Size(41, 70);
            button2P.TabIndex = 10;
            button2P.Text = "+";
            button2P.UseVisualStyleBackColor = true;
            button2P.Click += button8_Click;
            // 
            // textBoxS2
            // 
            textBoxS2.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxS2.Location = new Point(50, 67);
            textBoxS2.Name = "textBoxS2";
            textBoxS2.Size = new Size(165, 70);
            textBoxS2.TabIndex = 10;
            textBoxS2.TextAlign = HorizontalAlignment.Center;
            textBoxS2.TextChanged += textBox4_TextChanged;
            // 
            // button2M
            // 
            button2M.Location = new Point(3, 67);
            button2M.Name = "button2M";
            button2M.Size = new Size(41, 70);
            button2M.TabIndex = 10;
            button2M.Text = "-";
            button2M.UseVisualStyleBackColor = true;
            button2M.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Player 2";
            // 
            // textBoxP2
            // 
            textBoxP2.Location = new Point(60, 32);
            textBoxP2.Name = "textBoxP2";
            textBoxP2.ScrollBars = ScrollBars.Vertical;
            textBoxP2.Size = new Size(202, 23);
            textBoxP2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1P);
            groupBox1.Controls.Add(button1M);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxS1);
            groupBox1.Controls.Add(textBoxP1);
            groupBox1.Controls.Add(textBoxM1);
            groupBox1.Controls.Add(textBoxL1);
            groupBox1.Location = new Point(12, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 203);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player 1";
            // 
            // button1P
            // 
            button1P.Location = new Point(222, 67);
            button1P.Name = "button1P";
            button1P.Size = new Size(41, 70);
            button1P.TabIndex = 9;
            button1P.Text = "+";
            button1P.UseVisualStyleBackColor = true;
            button1P.Click += button1P_Click;
            // 
            // button1M
            // 
            button1M.Location = new Point(6, 67);
            button1M.Name = "button1M";
            button1M.Size = new Size(41, 70);
            button1M.TabIndex = 8;
            button1M.Text = "-";
            button1M.UseVisualStyleBackColor = true;
            button1M.Click += button1M_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Player 1";
            label1.Click += label1_Click;
            // 
            // textBoxS1
            // 
            textBoxS1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxS1.Location = new Point(51, 67);
            textBoxS1.Name = "textBoxS1";
            textBoxS1.Size = new Size(165, 70);
            textBoxS1.TabIndex = 1;
            textBoxS1.TextAlign = HorizontalAlignment.Center;
            textBoxS1.TextChanged += textBox3_TextChanged;
            // 
            // textBoxP1
            // 
            textBoxP1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxP1.Location = new Point(51, 32);
            textBoxP1.Name = "textBoxP1";
            textBoxP1.ScrollBars = ScrollBars.Vertical;
            textBoxP1.Size = new Size(212, 23);
            textBoxP1.TabIndex = 0;
            textBoxP1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBoxPath);
            groupBox3.Controls.Add(buttonOpenFile);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(buttonPlayerList);
            groupBox3.Controls.Add(textBoxURL);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(614, 86);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Setup";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 57);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 14;
            label4.Text = "Path";
            label4.Click += label4_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.AccessibleName = "Pathbox";
            textBoxPath.Location = new Point(50, 54);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.ReadOnly = true;
            textBoxPath.Size = new Size(394, 23);
            textBoxPath.TabIndex = 13;
            textBoxPath.TextChanged += textBox6_TextChanged;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(450, 54);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(156, 23);
            buttonOpenFile.TabIndex = 12;
            buttonOpenFile.Text = "...";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 10;
            label3.Text = "URL";
            label3.Click += label3_Click;
            // 
            // buttonPlayerList
            // 
            buttonPlayerList.Location = new Point(450, 25);
            buttonPlayerList.Name = "buttonPlayerList";
            buttonPlayerList.Size = new Size(156, 23);
            buttonPlayerList.TabIndex = 11;
            buttonPlayerList.Text = "Get playerlist";
            buttonPlayerList.UseVisualStyleBackColor = true;
            buttonPlayerList.Click += buttonPlayerList_Click;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(50, 25);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(394, 23);
            textBoxURL.TabIndex = 10;
            textBoxURL.TextChanged += textBox5_TextChanged;
            // 
            // buttonResetPlayers
            // 
            buttonResetPlayers.Location = new Point(287, 181);
            buttonResetPlayers.Name = "buttonResetPlayers";
            buttonResetPlayers.Size = new Size(63, 38);
            buttonResetPlayers.TabIndex = 6;
            buttonResetPlayers.Text = "Reset Players";
            buttonResetPlayers.UseVisualStyleBackColor = true;
            buttonResetPlayers.Click += button3_Click;
            // 
            // buttonResetScores
            // 
            buttonResetScores.Location = new Point(287, 225);
            buttonResetScores.Name = "buttonResetScores";
            buttonResetScores.Size = new Size(63, 38);
            buttonResetScores.TabIndex = 7;
            buttonResetScores.Text = "Reset Scores";
            buttonResetScores.UseVisualStyleBackColor = true;
            buttonResetScores.Click += button4_Click;
            // 
            // buttonSwitchPlayers
            // 
            buttonSwitchPlayers.Location = new Point(287, 137);
            buttonSwitchPlayers.Name = "buttonSwitchPlayers";
            buttonSwitchPlayers.Size = new Size(63, 38);
            buttonSwitchPlayers.TabIndex = 8;
            buttonSwitchPlayers.Text = "Switch";
            buttonSwitchPlayers.UseVisualStyleBackColor = true;
            buttonSwitchPlayers.Click += buttonSwitchPlayers_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBoxL1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxL1.Location = new Point(56, 141);
            textBoxL1.Name = "textBox1";
            textBoxL1.ScrollBars = ScrollBars.Vertical;
            textBoxL1.Size = new Size(207, 23);
            textBoxL1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBoxM1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxM1.Location = new Point(56, 170);
            textBoxM1.Name = "textBox2";
            textBoxM1.ScrollBars = ScrollBars.Vertical;
            textBoxM1.Size = new Size(207, 23);
            textBoxM1.TabIndex = 11;
            // 
            // textBox3
            // 
            textBoxL2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxL2.Location = new Point(58, 141);
            textBoxL2.Name = "textBox3";
            textBoxL2.ScrollBars = ScrollBars.Vertical;
            textBoxL2.Size = new Size(204, 23);
            textBoxL2.TabIndex = 12;
            // 
            // textBox4
            // 
            textBoxM2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxM2.Location = new Point(58, 172);
            textBoxM2.Name = "textBox4";
            textBoxM2.ScrollBars = ScrollBars.Vertical;
            textBoxM2.Size = new Size(204, 23);
            textBoxM2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 144);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Label 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 173);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 14;
            label6.Text = "Misc 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 144);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 15;
            label7.Text = "Label 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 175);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 16;
            label8.Text = "Misc 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 382);
            Controls.Add(buttonSwitchPlayers);
            Controls.Add(buttonResetScores);
            Controls.Add(buttonResetPlayers);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(buttonUpdate);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonUpdate;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button buttonResetPlayers;
        private Button buttonResetScores;
        private TextBox textBoxP1;
        private TextBox textBoxP2;
        private Label label2;
        private Label label1;
        private TextBox textBoxS1;
        private Button button1P;
        private Button button1M;
        private Button button2P;
        private TextBox textBoxS2;
        private Button button2M;
        private Label label3;
        private Button buttonPlayerList;
        private TextBox textBoxURL;
        private Button buttonSwitchPlayers;
        private Label label4;
        private TextBox textBoxPath;
        private Button buttonOpenFile;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxL1;
        private TextBox textBoxM1;
        private TextBox textBoxL2;
        private TextBox textBoxM2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}