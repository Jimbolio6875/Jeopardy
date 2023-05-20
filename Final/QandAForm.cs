using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final
{
    public partial class QandAForm : Form
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        //public int Money { get; set; }

        public QandAForm()
        {
            InitializeComponent();
        }

        private void QandAForm_Load(object sender, EventArgs e)
        {
            questionLbl.Text = Question;
            yesBtn.Hide();
            noBtn.Hide();
        }

        // checks to see if the answer textbox is empty or not
        // also checks to see if the answer textbox has
        // at least two words with spaces and a question mark
        private void button1_Click(object sender, EventArgs e)
        {
            if (answerTxtBox.Text == "")
            {
                emptyAnswerLbl.Text = "You must input an answer";
            }
            else if (answerTxtBox.Text != "")
            {
                if (Regex.Match(answerTxtBox.Text, @"([a-zA-Z]+( [a-zA-Z]+)+)\?").Success)
                {
                    answerLbl.Text = $"Answer: {Answer}";
                    emptyAnswerLbl.Text = "Did you input the correct answer? Do not lie.";
                    answerTxtBox.Enabled = false;
                    yesBtn.Show();
                    noBtn.Show();
                }
                else
                {
                    emptyAnswerLbl.Text = "Answer must be in question format with question mark.";
                }
            }
        }

        // if yes button is clicked it sets dialogue result to yes
        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        // if no button is clicked it sets it to no
        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
