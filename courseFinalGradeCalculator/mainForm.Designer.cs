namespace courseFinalGradeCalculator
{
    partial class mainForm
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
            this.quitButton = new System.Windows.Forms.Button();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetQuizButton = new System.Windows.Forms.Button();
            this.transferQuizMarkButton = new System.Windows.Forms.Button();
            this.quizzesLabel = new System.Windows.Forms.Label();
            this.quizMarkLabel = new System.Windows.Forms.Label();
            this.quizMarkInputTextbox = new System.Windows.Forms.TextBox();
            this.midtermMarkLabel = new System.Windows.Forms.Label();
            this.finalExamLabel = new System.Windows.Forms.Label();
            this.midtermInputTextbox = new System.Windows.Forms.TextBox();
            this.finalExamInputTextbox = new System.Windows.Forms.TextBox();
            this.quizMarksReadOnlyTextbox = new System.Windows.Forms.TextBox();
            this.dropHighLowQuizMarksCheckbox = new System.Windows.Forms.CheckBox();
            this.percentageReadOnlyTextbox = new System.Windows.Forms.TextBox();
            this.letterGradeReadOnlyTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(323, 541);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(146, 43);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // resetAllButton
            // 
            this.resetAllButton.Location = new System.Drawing.Point(323, 488);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(146, 47);
            this.resetAllButton.TabIndex = 1;
            this.resetAllButton.Text = "&Reset All Marks";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.ResetAllButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(323, 439);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(146, 43);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate Grade";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // resetQuizButton
            // 
            this.resetQuizButton.Location = new System.Drawing.Point(17, 162);
            this.resetQuizButton.Name = "resetQuizButton";
            this.resetQuizButton.Size = new System.Drawing.Size(290, 41);
            this.resetQuizButton.TabIndex = 3;
            this.resetQuizButton.Text = "Reset &Quiz Marks";
            this.resetQuizButton.UseVisualStyleBackColor = true;
            this.resetQuizButton.Click += new System.EventHandler(this.ResetQuizButton_Click);
            // 
            // transferQuizMarkButton
            // 
            this.transferQuizMarkButton.Location = new System.Drawing.Point(218, 76);
            this.transferQuizMarkButton.Name = "transferQuizMarkButton";
            this.transferQuizMarkButton.Size = new System.Drawing.Size(89, 52);
            this.transferQuizMarkButton.TabIndex = 4;
            this.transferQuizMarkButton.Text = "&Transfer";
            this.transferQuizMarkButton.UseVisualStyleBackColor = true;
            this.transferQuizMarkButton.Click += new System.EventHandler(this.TransferQuizMarkButton_Click);
            // 
            // quizzesLabel
            // 
            this.quizzesLabel.AutoSize = true;
            this.quizzesLabel.Location = new System.Drawing.Point(237, 44);
            this.quizzesLabel.Name = "quizzesLabel";
            this.quizzesLabel.Size = new System.Drawing.Size(70, 20);
            this.quizzesLabel.TabIndex = 5;
            this.quizzesLabel.Text = "Quizzes:";
            // 
            // quizMarkLabel
            // 
            this.quizMarkLabel.AutoSize = true;
            this.quizMarkLabel.Location = new System.Drawing.Point(18, 79);
            this.quizMarkLabel.Name = "quizMarkLabel";
            this.quizMarkLabel.Size = new System.Drawing.Size(84, 20);
            this.quizMarkLabel.TabIndex = 6;
            this.quizMarkLabel.Text = "Quiz Mark:";
            // 
            // quizMarkInputTextbox
            // 
            this.quizMarkInputTextbox.Location = new System.Drawing.Point(115, 76);
            this.quizMarkInputTextbox.Name = "quizMarkInputTextbox";
            this.quizMarkInputTextbox.Size = new System.Drawing.Size(70, 26);
            this.quizMarkInputTextbox.TabIndex = 7;
            // 
            // midtermMarkLabel
            // 
            this.midtermMarkLabel.AutoSize = true;
            this.midtermMarkLabel.Location = new System.Drawing.Point(328, 364);
            this.midtermMarkLabel.Name = "midtermMarkLabel";
            this.midtermMarkLabel.Size = new System.Drawing.Size(109, 20);
            this.midtermMarkLabel.TabIndex = 8;
            this.midtermMarkLabel.Text = "Midterm Mark:";
            // 
            // finalExamLabel
            // 
            this.finalExamLabel.AutoSize = true;
            this.finalExamLabel.Location = new System.Drawing.Point(307, 398);
            this.finalExamLabel.Name = "finalExamLabel";
            this.finalExamLabel.Size = new System.Drawing.Size(130, 20);
            this.finalExamLabel.TabIndex = 9;
            this.finalExamLabel.Text = "Final Exam Mark:";
            // 
            // midtermInputTextbox
            // 
            this.midtermInputTextbox.Location = new System.Drawing.Point(446, 361);
            this.midtermInputTextbox.Name = "midtermInputTextbox";
            this.midtermInputTextbox.Size = new System.Drawing.Size(100, 26);
            this.midtermInputTextbox.TabIndex = 10;
            // 
            // finalExamInputTextbox
            // 
            this.finalExamInputTextbox.Location = new System.Drawing.Point(446, 395);
            this.finalExamInputTextbox.Name = "finalExamInputTextbox";
            this.finalExamInputTextbox.Size = new System.Drawing.Size(100, 26);
            this.finalExamInputTextbox.TabIndex = 11;
            // 
            // quizMarksReadOnlyTextbox
            // 
            this.quizMarksReadOnlyTextbox.Location = new System.Drawing.Point(348, 44);
            this.quizMarksReadOnlyTextbox.Multiline = true;
            this.quizMarksReadOnlyTextbox.Name = "quizMarksReadOnlyTextbox";
            this.quizMarksReadOnlyTextbox.ReadOnly = true;
            this.quizMarksReadOnlyTextbox.Size = new System.Drawing.Size(257, 265);
            this.quizMarksReadOnlyTextbox.TabIndex = 12;
            // 
            // dropHighLowQuizMarksCheckbox
            // 
            this.dropHighLowQuizMarksCheckbox.AutoSize = true;
            this.dropHighLowQuizMarksCheckbox.Location = new System.Drawing.Point(323, 323);
            this.dropHighLowQuizMarksCheckbox.Name = "dropHighLowQuizMarksCheckbox";
            this.dropHighLowQuizMarksCheckbox.Size = new System.Drawing.Size(282, 24);
            this.dropHighLowQuizMarksCheckbox.TabIndex = 13;
            this.dropHighLowQuizMarksCheckbox.Text = "&Drop Highest && Lowest Quiz Marks";
            this.dropHighLowQuizMarksCheckbox.UseVisualStyleBackColor = true;
            // 
            // percentageReadOnlyTextbox
            // 
            this.percentageReadOnlyTextbox.Location = new System.Drawing.Point(481, 447);
            this.percentageReadOnlyTextbox.Name = "percentageReadOnlyTextbox";
            this.percentageReadOnlyTextbox.ReadOnly = true;
            this.percentageReadOnlyTextbox.Size = new System.Drawing.Size(46, 26);
            this.percentageReadOnlyTextbox.TabIndex = 14;
            // 
            // letterGradeReadOnlyTextbox
            // 
            this.letterGradeReadOnlyTextbox.Location = new System.Drawing.Point(554, 447);
            this.letterGradeReadOnlyTextbox.Name = "letterGradeReadOnlyTextbox";
            this.letterGradeReadOnlyTextbox.ReadOnly = true;
            this.letterGradeReadOnlyTextbox.Size = new System.Drawing.Size(51, 26);
            this.letterGradeReadOnlyTextbox.TabIndex = 15;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 633);
            this.Controls.Add(this.letterGradeReadOnlyTextbox);
            this.Controls.Add(this.percentageReadOnlyTextbox);
            this.Controls.Add(this.dropHighLowQuizMarksCheckbox);
            this.Controls.Add(this.quizMarksReadOnlyTextbox);
            this.Controls.Add(this.finalExamInputTextbox);
            this.Controls.Add(this.midtermInputTextbox);
            this.Controls.Add(this.finalExamLabel);
            this.Controls.Add(this.midtermMarkLabel);
            this.Controls.Add(this.quizMarkInputTextbox);
            this.Controls.Add(this.quizMarkLabel);
            this.Controls.Add(this.quizzesLabel);
            this.Controls.Add(this.transferQuizMarkButton);
            this.Controls.Add(this.resetQuizButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetAllButton);
            this.Controls.Add(this.quitButton);
            this.Name = "mainForm";
            this.Text = "Grades Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button resetAllButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetQuizButton;
        private System.Windows.Forms.Button transferQuizMarkButton;
        private System.Windows.Forms.Label quizzesLabel;
        private System.Windows.Forms.Label quizMarkLabel;
        private System.Windows.Forms.TextBox quizMarkInputTextbox;
        private System.Windows.Forms.Label midtermMarkLabel;
        private System.Windows.Forms.Label finalExamLabel;
        private System.Windows.Forms.TextBox midtermInputTextbox;
        private System.Windows.Forms.TextBox finalExamInputTextbox;
        private System.Windows.Forms.TextBox quizMarksReadOnlyTextbox;
        private System.Windows.Forms.CheckBox dropHighLowQuizMarksCheckbox;
        private System.Windows.Forms.TextBox percentageReadOnlyTextbox;
        private System.Windows.Forms.TextBox letterGradeReadOnlyTextbox;
    }
}

