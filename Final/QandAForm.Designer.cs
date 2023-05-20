
namespace Final
{
    partial class QandAForm
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
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.emptyAnswerLbl = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.answerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(152, 175);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(748, 41);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Location = new System.Drawing.Point(451, 219);
            this.answerTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.Size = new System.Drawing.Size(132, 22);
            this.answerTxtBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emptyAnswerLbl
            // 
            this.emptyAnswerLbl.Location = new System.Drawing.Point(317, 278);
            this.emptyAnswerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emptyAnswerLbl.Name = "emptyAnswerLbl";
            this.emptyAnswerLbl.Size = new System.Drawing.Size(401, 23);
            this.emptyAnswerLbl.TabIndex = 3;
            this.emptyAnswerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(389, 337);
            this.yesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(100, 28);
            this.yesBtn.TabIndex = 4;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(542, 337);
            this.noBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(100, 28);
            this.noBtn.TabIndex = 5;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // answerLbl
            // 
            this.answerLbl.Location = new System.Drawing.Point(415, 245);
            this.answerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(209, 23);
            this.answerLbl.TabIndex = 6;
            this.answerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QandAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.emptyAnswerLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.questionLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QandAForm";
            this.Text = "QandAForm";
            this.Load += new System.EventHandler(this.QandAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label emptyAnswerLbl;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label answerLbl;
    }
}