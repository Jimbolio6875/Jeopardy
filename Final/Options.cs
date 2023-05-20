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
    public partial class Options : Form
    {

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            onePlayerBtn.Checked = true;
            playerTwoTxtBox.Enabled = false;
            playerThreeTxtBox.Enabled = false;
        }

        // bunch of check change events for the radio buttons
        // just enable/disable other controls
        private void onePlayerBtn_CheckedChanged(object sender, EventArgs e)
        {
            playerOneTxtBox.Focus();
            playerOneTxtBox.Enabled = true;
            playerTwoTxtBox.Enabled = false;
            playerThreeTxtBox.Enabled = false;
        }

        private void twoPlayersBtn_CheckedChanged(object sender, EventArgs e)
        {
            playerOneTxtBox.Focus();
            playerOneTxtBox.Enabled = true;
            playerTwoTxtBox.Enabled = true;
            playerThreeTxtBox.Enabled = false;
        }

        private void threePlayersBtn_CheckedChanged(object sender, EventArgs e)
        {
            playerOneTxtBox.Focus();
            playerOneTxtBox.Enabled = true;
            playerTwoTxtBox.Enabled = true;
            playerThreeTxtBox.Enabled = true;
        }

        // checks if there are empty fields if there are not supposed to be
        // also calls methods that validate using regular expressions
        private void EmptyFields()
        {
            if ((playerOneTxtBox.Enabled == true && playerOneTxtBox.Text == "" ) || (playerTwoTxtBox.Enabled == true && playerTwoTxtBox.Text == "") || (playerThreeTxtBox.Enabled == true && playerThreeTxtBox.Text == ""))
            {
                emptyFieldsLabel.Text = "Fill out empty fields";
            }
            else
            {
                if (onePlayerBtn.Checked == true && playerOneTxtBox.Text != "")
                {
                    PlayerOneNameValidation();
                    //this.Close();
                    playerTwoTxtBox.Text = "";
                    playerThreeTxtBox.Text = "";
                }
                if (twoPlayersBtn.Checked == true && playerOneTxtBox.Text != "" && playerTwoTxtBox.Text != "")
                {
                    PlayerOneNameValidation();
                    PlayerTwoNameValidation();
                    playerThreeTxtBox.Text = "";
                }
                if (threePlayersBtn.Checked == true && playerOneTxtBox.Text != "" && playerTwoTxtBox.Text != "" && playerThreeTxtBox.Text != "")
                {
                    PlayerOneNameValidation();
                    PlayerTwoNameValidation();
                    PlayerThreeNameValidation();
                }
                emptyFieldsLabel.Text = "";
            }
        }

        // validates input of playeronetextbox
        private void PlayerOneNameValidation()
        {
           
            if (Regex.Match(playerOneTxtBox.Text, @"^[a-zA-Z]+$").Success)
            {
                // makes first letter of input name capital if it's not already 
                // and outputs it to label
                string fName = (playerOneTxtBox.Text).Substring(0, 1).ToUpper() + (playerOneTxtBox.Text).Substring(1);
                playerOneTxtBox.Text = fName;
                playerOneLabel.Text = "";
                //this.Close();
            }
            else
            {
                // gives user error about formatting
                playerOneLabel.Text = "No numbers or spaces allowed.";
            }
        }

        // validates input of playertwotextbox
        private void PlayerTwoNameValidation()
        {
            if (Regex.Match(playerTwoTxtBox.Text, @"^[a-zA-Z]+$").Success)
            {
                // makes first letter of input name capital if it's not already 
                // and outputs it to label
                string fName = (playerTwoTxtBox.Text).Substring(0, 1).ToUpper() + (playerTwoTxtBox.Text).Substring(1);
                playerTwoTxtBox.Text = fName;
                playerTwoLabel.Text = "";
                //this.Close();
            }
            else
            {
                // gives user error about formatting
                playerTwoLabel.Text = "No numbers or spaces allowed.";
            }
        }

        // validates input of playerthreetextbox
        private void PlayerThreeNameValidation()
        {
            if (Regex.Match(playerThreeTxtBox.Text, @"^[a-zA-Z]+$").Success)
            {
                // makes first letter of input name capital if it's not already 
                // and outputs it to label
                string fName = (playerThreeTxtBox.Text).Substring(0, 1).ToUpper() + (playerThreeTxtBox.Text).Substring(1);
                playerThreeTxtBox.Text = fName;
                playerThreeLabel.Text = "";
                //this.Close();
            }
            else
            {
                // gives user error about formatting
                playerThreeLabel.Text = "No numbers or spaces allowed.";
            }
        }

        // validates input and sends player name data to form1 to be used
        private void submitOptionsBtn_Click(object sender, EventArgs e)
        {
            EmptyFields();

            if ((playerOneTxtBox.Enabled == true && playerOneTxtBox.Text != "") || (playerTwoTxtBox.Enabled == true && (playerTwoTxtBox.Text != "" && playerOneTxtBox.Text != "")) || (playerThreeTxtBox.Enabled == true && playerThreeTxtBox.Text != "" && playerOneTxtBox.Text != "" && playerTwoTxtBox.Text != ""))
            {
                SendPlayerName(playerOneTxtBox.Text, playerTwoTxtBox.Text, playerThreeTxtBox.Text);
            }

        }

        // this method sets the public properties in form1 equal to whatever is psased in the parameters
        private void SendPlayerName(string pOneName, string pTwoName, string pThreeName)
        {
            Form1 form1 = new Form1();
            form1.PlayerOneName = pOneName;
            form1.PlayerTwoName = pTwoName;
            form1.PlayerThreeName = pThreeName;
            this.Hide();
            form1.ShowDialog();
        }

    }
}
