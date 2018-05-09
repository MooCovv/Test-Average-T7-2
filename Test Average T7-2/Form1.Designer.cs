namespace Test_Average_T7_2
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
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.TextBox();
            this.lowScoreLabel = new System.Windows.Forms.TextBox();
            this.averageScoreLabel = new System.Windows.Forms.TextBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.Location = new System.Drawing.Point(42, 54);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(120, 95);
            this.testScoresListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Highest Scores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lowest Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average Score";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.Enabled = false;
            this.highScoreLabel.Location = new System.Drawing.Point(269, 62);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(100, 20);
            this.highScoreLabel.TabIndex = 5;
            // 
            // lowScoreLabel
            // 
            this.lowScoreLabel.Enabled = false;
            this.lowScoreLabel.Location = new System.Drawing.Point(269, 94);
            this.lowScoreLabel.Name = "lowScoreLabel";
            this.lowScoreLabel.Size = new System.Drawing.Size(100, 20);
            this.lowScoreLabel.TabIndex = 6;
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.Enabled = false;
            this.averageScoreLabel.Location = new System.Drawing.Point(269, 123);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(100, 20);
            this.averageScoreLabel.TabIndex = 7;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(116, 178);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(75, 23);
            this.getScoresButton.TabIndex = 8;
            this.getScoresButton.Text = "Get Scores";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(232, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 227);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.lowScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testScoresListBox);
            this.Name = "Form1";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox highScoreLabel;
        private System.Windows.Forms.TextBox lowScoreLabel;
        private System.Windows.Forms.TextBox averageScoreLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

