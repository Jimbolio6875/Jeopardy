using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace Final
{
    public partial class Form1 : Form
    {
        int timeLeft = 300;

        //public properties passed from options form
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public string PlayerThreeName { get; set; }

        Results results = new Results();
        GameInfo gameInfo;

        DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        // when form loads, disable and enable certain controls
        // also change color of buttons
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            playerOneBtn.Enabled = false;
            playerTwoBtn.Enabled = false;
            playerThreeBtn.Enabled = false;
            button1.Enabled = false;

            playerOneBtn.BackColor = DefaultBackColor;
            playerTwoBtn.BackColor = DefaultBackColor;
            playerThreeBtn.BackColor = DefaultBackColor;
        }

        // event method that occurs on cell double click
        // will check to see if the cells color is gray or not
        // if it is that means it has already been used and you cannot click it again
        // if not it will call function
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Style.BackColor == Color.Gray)
            {
                label1.Text = "This choice has already been used.";
                dataGridView1.ClearSelection();
            }
            else
            {
                UnclickedCell();
            }
        }

        // method called by cell double click event
        // gets the clicked cell's row, col, and money value
        // loads the xml doc and loops through the clicked cell's row and col location to
        // find the correct node in the xml file for the question and answer values
        // also calls the showQandA form method and passes parameters
        // sets clicked cell to null and changes background color to gray
        private void UnclickedCell()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int colIndex = dataGridView1.CurrentCell.ColumnIndex;

            string question = "";
            string answer = "";
            int money = Convert.ToInt32(dataGridView1.CurrentCell.Value);

            //label1.Text = dataGridView1.CurrentCell.RowIndex.ToString();
            //label2.Text = dataGridView1.CurrentCell.ColumnIndex.ToString();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("JeopardyXML.xml");

            // this set of loops gets the question of the selected cell
            for (int i = 0; i < rowIndex + 1; i++)
            {
                for (int j = 0; j < colIndex + 1; j++)
                {
                    foreach (XmlNode xmlNode in xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[j])
                    {
                        question = xmlNode.InnerText;
                    }
                }
            }

            // this set of loops gets the answer of the selected cell
            for (int i = 0; i < rowIndex + 1; i++)
            {
                for (int j = 0; j < colIndex + 1; j++)
                {
                    foreach (XmlNode xmlNode in xmlDocument.DocumentElement.ChildNodes[i].ChildNodes[j].Attributes["answer"])
                    {
                        answer = xmlNode.InnerText;
                    }
                }
            }

            ShowQandAForm(answer, question, money);

            label1.Text = "";

            dataGridView1.CurrentCell.Style.BackColor = Color.Gray;
            dataGridView1.CurrentCell = null;
        }

        // method called by unclicked cell method
        // takes parameters for answer, question, and money
        // opens the qAndA form and checks dialogue result to see if the yes or no button
        // was clicked
        // if yes is clicked then it adds the cell's value to the player's points
        // if no is clicked then it takes away the cell's value from the player's points
        private void ShowQandAForm(string a, string q, int m)
        {
            int money = 0;

            QandAForm qandAForm = new QandAForm();
            qandAForm.Answer = a;
            qandAForm.Question = q;

            button1.Enabled = true;

            if (qandAForm.ShowDialog() == DialogResult.Yes)
            {
                money = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            }
            else
            {
                money = Convert.ToInt32(dataGridView1.CurrentCell.Value) * -1;
            }

            if (playerOneBtn.BackColor == Color.LightBlue)
            {
                int playerOneMoney = money + Convert.ToInt32(playerOneMoneylbl.Text);
                playerOneMoneylbl.Text = playerOneMoney.ToString();
                playerOneBtn.BackColor = DefaultBackColor;

                if (playerOneNameLabel.Text != "")
                {
                    playerOneBtn.Enabled = true;
                }
                if (playerTwoNameLabel.Text != "")
                {
                    playerTwoBtn.Enabled = true;
                }
                if (playerThreeNameLabel.Text != "")
                {
                    playerThreeBtn.Enabled = true;
                }
            }

            if (playerTwoBtn.BackColor == Color.LightBlue)
            {
                int playerTwoMoney = money + Convert.ToInt32(playerTwoMoneylbl.Text);
                playerTwoMoneylbl.Text = playerTwoMoney.ToString();
                playerTwoBtn.BackColor = DefaultBackColor;

                if (playerOneNameLabel.Text != "")
                {
                    playerOneBtn.Enabled = true;
                }
                if (playerTwoNameLabel.Text != "")
                {
                    playerTwoBtn.Enabled = true;
                }
                if (playerThreeNameLabel.Text != "")
                {
                    playerThreeBtn.Enabled = true;
                }
            }

            if (playerThreeBtn.BackColor == Color.LightBlue)
            {
                int playerThreeMoney = money + Convert.ToInt32(playerThreeMoneylbl.Text);
                playerThreeMoneylbl.Text = playerThreeMoney.ToString();
                playerThreeBtn.BackColor = DefaultBackColor;

                if (playerOneNameLabel.Text != "")
                {
                    playerOneBtn.Enabled = true;
                }
                if (playerTwoNameLabel.Text != "")
                {
                    playerTwoBtn.Enabled = true;
                }
                if (playerThreeNameLabel.Text != "")
                {
                    playerThreeBtn.Enabled = true;
                }
            }
        }

        // method for the loadplayersbtnclick event
        // calls the loadgamedatagrid function
        // gets the public properties passed in from the previous options form and
        // sets the name labels equal to them
        // if a name is blank, the associated button will be disabled
        private void loadPlayersBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            loadPlayersBtn.Enabled = false;
            button1.Enabled = true;
            LoadGameDataGrid();

            playerOneNameLabel.Text = PlayerOneName;
            playerTwoNameLabel.Text = PlayerTwoName;
            playerThreeNameLabel.Text = PlayerThreeName;
            
            if (playerOneNameLabel.Text != "")
            {
                playerOneBtn.Enabled = true;
            }
            if (playerTwoNameLabel.Text != "")
            {
                playerTwoBtn.Enabled = true;               
            }
            if (playerThreeNameLabel.Text != "")
            {
                playerThreeBtn.Enabled = true;               
            }
        }

        // method called by loadplayersbtnclick method
        // creates a datagridview and loads the point values for each node to the datagrid from
        // the xml file
        private void LoadGameDataGrid()
        {
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 150;
            dataGridView1.BringToFront();

            dataTable.Columns.Add("100", typeof(string));
            dataTable.Columns.Add("200", typeof(string));
            dataTable.Columns.Add("300", typeof(string));
            dataTable.Columns.Add("400", typeof(string));
            dataTable.Columns.Add("500", typeof(string));

            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load("JeopardyXML.xml");
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/Jeopardy/category"); // maybe change this back?

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["100"] = xmlNode["first"].GetAttribute("points");
                dataRow["200"] = xmlNode["second"].GetAttribute("points");
                dataRow["300"] = xmlNode["third"].GetAttribute("points");
                dataRow["400"] = xmlNode["fourth"].GetAttribute("points");
                dataRow["500"] = xmlNode["fifth"].GetAttribute("points");
                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;
            dataGridView1.Rows[0].HeaderCell.Value = "People in Computing";
            dataGridView1.Rows[1].HeaderCell.Value = "OO Programming";
            dataGridView1.Rows[2].HeaderCell.Value = "LINQ";
            dataGridView1.Rows[3].HeaderCell.Value = "Regular Expressions";
            dataGridView1.Rows[4].HeaderCell.Value = "Data Structures";

            dataGridView1.ClearSelection();
        }

        // tells player one to choose cell
        // disables things
        private void playerOneBtn_Click(object sender, EventArgs e)
        {
            label1.Text = $"{playerOneNameLabel.Text}, please choose.";
            playerOneBtn.BackColor = Color.LightBlue;
            playerTwoBtn.Enabled = false;
            playerThreeBtn.Enabled = false;
            button1.Enabled = false;
        }

        // tells player two to choose cell
        // disables things
        private void playerTwoBtn_Click(object sender, EventArgs e)
        {
            label1.Text = $"{playerTwoNameLabel.Text}, please choose.";
            playerOneBtn.Enabled = false;
            playerTwoBtn.BackColor = Color.LightBlue;
            playerThreeBtn.Enabled = false;
            button1.Enabled = false;
        }

        // tells player three to choose cell
        //disables things
        private void playerThreeBtn_Click(object sender, EventArgs e)
        {
            label1.Text = $"{playerThreeNameLabel.Text}, please choose.";
            playerOneBtn.Enabled = false;
            playerTwoBtn.Enabled = false;
            playerThreeBtn.BackColor = Color.LightBlue;
            button1.Enabled = false;
        }

        // method that fills listbox of results form with current and previous game data
        private void FillList()
        {
            results.listBox1.Items.Clear();
            ArrayList array = GameInfo.GetAllGameInfo();

            foreach (GameInfo gameInfo in array)
            {
                results.listBox1.Items.Add(gameInfo);
            }

            label2.Text = "Loaded data";
        }

        // adds current game info to GameInfo constructor
        // calls filllist method and brings up results form
        private void button1_Click(object sender, EventArgs e)
        {
            gameInfo = new GameInfo((Convert.ToInt32(playerOneMoneylbl.Text) + Convert.ToInt32(playerTwoMoneylbl.Text) + Convert.ToInt32(playerThreeMoneylbl.Text)).ToString()
                                    ,PlayerOneName.ToString()
                                    ,(playerOneMoneylbl.Text).ToString()
                                    ,PlayerTwoName.ToString()
                                    ,(playerTwoMoneylbl.Text).ToString()
                                    ,PlayerThreeName.ToString()
                                    ,(playerThreeMoneylbl.Text).ToString());
            DataAccess.AddGameInfo(gameInfo);
            FillList();
            results.ShowDialog();
        }

        // 5 minute timer
        // when it hits zero it disables the player buttons so
        // nobody can earn more points
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft --;
                TimeSpan timeSpan = TimeSpan.FromSeconds(timeLeft);
                label4.Text = timeSpan.ToString(@"mm\:ss");
            }
            else
            {
                playerOneBtn.Enabled = false;
                playerTwoBtn.Enabled = false;
                playerThreeBtn.Enabled = false;

                timerAlertlbl.Text = "You have run out of time.";
            }
        }

        // some things I tried to do but it didn't work
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dataGridView1.CurrentCell != null)
            //{
            //    try
            //    {
            //        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Blue;
            //    }
            //    catch (Exception exc)
            //    {
            //        label2.Text = exc.ToString();
            //        label2.Text = "";
            //    }
            //}
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.CurrentCell != null)
            //{
            //    try
            //    {
            //        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            //    }
            //    catch (Exception exc)
            //    {
            //        label2.Text = exc.ToString();
            //        label2.Text = "";
            //    }
            //}
        }
    }
}
