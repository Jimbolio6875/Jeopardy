
namespace Final
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerOneBtn = new System.Windows.Forms.Button();
            this.playerTwoBtn = new System.Windows.Forms.Button();
            this.playerThreeBtn = new System.Windows.Forms.Button();
            this.playerOneNameLabel = new System.Windows.Forms.Label();
            this.playerTwoNameLabel = new System.Windows.Forms.Label();
            this.playerThreeNameLabel = new System.Windows.Forms.Label();
            this.loadPlayersBtn = new System.Windows.Forms.Button();
            this.playerOneMoneylbl = new System.Windows.Forms.Label();
            this.playerTwoMoneylbl = new System.Windows.Forms.Label();
            this.playerThreeMoneylbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pointslblOne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.namelblOne = new System.Windows.Forms.Label();
            this.timerAlertlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 186);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(867, 148);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 5;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerOneBtn
            // 
            this.playerOneBtn.Location = new System.Drawing.Point(207, 464);
            this.playerOneBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerOneBtn.Name = "playerOneBtn";
            this.playerOneBtn.Size = new System.Drawing.Size(145, 65);
            this.playerOneBtn.TabIndex = 6;
            this.playerOneBtn.Text = "Player 1 Answer";
            this.playerOneBtn.UseVisualStyleBackColor = true;
            this.playerOneBtn.Click += new System.EventHandler(this.playerOneBtn_Click);
            // 
            // playerTwoBtn
            // 
            this.playerTwoBtn.Location = new System.Drawing.Point(532, 464);
            this.playerTwoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerTwoBtn.Name = "playerTwoBtn";
            this.playerTwoBtn.Size = new System.Drawing.Size(148, 65);
            this.playerTwoBtn.TabIndex = 7;
            this.playerTwoBtn.Text = "Player 2 Answer";
            this.playerTwoBtn.UseVisualStyleBackColor = true;
            this.playerTwoBtn.Click += new System.EventHandler(this.playerTwoBtn_Click);
            // 
            // playerThreeBtn
            // 
            this.playerThreeBtn.Location = new System.Drawing.Point(868, 464);
            this.playerThreeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerThreeBtn.Name = "playerThreeBtn";
            this.playerThreeBtn.Size = new System.Drawing.Size(141, 65);
            this.playerThreeBtn.TabIndex = 8;
            this.playerThreeBtn.Text = "Player 3 Answer";
            this.playerThreeBtn.UseVisualStyleBackColor = true;
            this.playerThreeBtn.Click += new System.EventHandler(this.playerThreeBtn_Click);
            // 
            // playerOneNameLabel
            // 
            this.playerOneNameLabel.AutoSize = true;
            this.playerOneNameLabel.Location = new System.Drawing.Point(252, 420);
            this.playerOneNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneNameLabel.Name = "playerOneNameLabel";
            this.playerOneNameLabel.Size = new System.Drawing.Size(0, 17);
            this.playerOneNameLabel.TabIndex = 9;
            // 
            // playerTwoNameLabel
            // 
            this.playerTwoNameLabel.AutoSize = true;
            this.playerTwoNameLabel.Location = new System.Drawing.Point(577, 420);
            this.playerTwoNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerTwoNameLabel.Name = "playerTwoNameLabel";
            this.playerTwoNameLabel.Size = new System.Drawing.Size(0, 17);
            this.playerTwoNameLabel.TabIndex = 10;
            // 
            // playerThreeNameLabel
            // 
            this.playerThreeNameLabel.AutoSize = true;
            this.playerThreeNameLabel.Location = new System.Drawing.Point(909, 420);
            this.playerThreeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerThreeNameLabel.Name = "playerThreeNameLabel";
            this.playerThreeNameLabel.Size = new System.Drawing.Size(0, 17);
            this.playerThreeNameLabel.TabIndex = 11;
            // 
            // loadPlayersBtn
            // 
            this.loadPlayersBtn.Location = new System.Drawing.Point(19, 464);
            this.loadPlayersBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadPlayersBtn.Name = "loadPlayersBtn";
            this.loadPlayersBtn.Size = new System.Drawing.Size(145, 65);
            this.loadPlayersBtn.TabIndex = 12;
            this.loadPlayersBtn.Text = "Load";
            this.loadPlayersBtn.UseVisualStyleBackColor = true;
            this.loadPlayersBtn.Click += new System.EventHandler(this.loadPlayersBtn_Click);
            // 
            // playerOneMoneylbl
            // 
            this.playerOneMoneylbl.AutoSize = true;
            this.playerOneMoneylbl.Location = new System.Drawing.Point(262, 382);
            this.playerOneMoneylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerOneMoneylbl.Name = "playerOneMoneylbl";
            this.playerOneMoneylbl.Size = new System.Drawing.Size(16, 17);
            this.playerOneMoneylbl.TabIndex = 13;
            this.playerOneMoneylbl.Text = "0";
            // 
            // playerTwoMoneylbl
            // 
            this.playerTwoMoneylbl.AutoSize = true;
            this.playerTwoMoneylbl.Location = new System.Drawing.Point(588, 382);
            this.playerTwoMoneylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerTwoMoneylbl.Name = "playerTwoMoneylbl";
            this.playerTwoMoneylbl.Size = new System.Drawing.Size(16, 17);
            this.playerTwoMoneylbl.TabIndex = 14;
            this.playerTwoMoneylbl.Text = "0";
            // 
            // playerThreeMoneylbl
            // 
            this.playerThreeMoneylbl.AutoSize = true;
            this.playerThreeMoneylbl.Location = new System.Drawing.Point(923, 382);
            this.playerThreeMoneylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerThreeMoneylbl.Name = "playerThreeMoneylbl";
            this.playerThreeMoneylbl.Size = new System.Drawing.Size(16, 17);
            this.playerThreeMoneylbl.TabIndex = 15;
            this.playerThreeMoneylbl.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 65);
            this.button1.TabIndex = 16;
            this.button1.Text = "End Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pointslblOne
            // 
            this.pointslblOne.AutoSize = true;
            this.pointslblOne.Location = new System.Drawing.Point(204, 382);
            this.pointslblOne.Name = "pointslblOne";
            this.pointslblOne.Size = new System.Drawing.Size(51, 17);
            this.pointslblOne.TabIndex = 17;
            this.pointslblOne.Text = "Points:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Points:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(865, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Points:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(865, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Name:";
            // 
            // namelblOne
            // 
            this.namelblOne.AutoSize = true;
            this.namelblOne.Location = new System.Drawing.Point(204, 420);
            this.namelblOne.Name = "namelblOne";
            this.namelblOne.Size = new System.Drawing.Size(49, 17);
            this.namelblOne.TabIndex = 22;
            this.namelblOne.Text = "Name:";
            // 
            // timerAlertlbl
            // 
            this.timerAlertlbl.Location = new System.Drawing.Point(497, 119);
            this.timerAlertlbl.Name = "timerAlertlbl";
            this.timerAlertlbl.Size = new System.Drawing.Size(244, 23);
            this.timerAlertlbl.TabIndex = 23;
            this.timerAlertlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Click \"Load\" button to start game.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Click player button.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Double click a cell.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Click \"End Game\" button to show results.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(157, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "If timer runs out, players cannot earn more points.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1187, 647);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerAlertlbl);
            this.Controls.Add(this.namelblOne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pointslblOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerThreeMoneylbl);
            this.Controls.Add(this.playerTwoMoneylbl);
            this.Controls.Add(this.playerOneMoneylbl);
            this.Controls.Add(this.loadPlayersBtn);
            this.Controls.Add(this.playerThreeNameLabel);
            this.Controls.Add(this.playerTwoNameLabel);
            this.Controls.Add(this.playerOneNameLabel);
            this.Controls.Add(this.playerThreeBtn);
            this.Controls.Add(this.playerTwoBtn);
            this.Controls.Add(this.playerOneBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playerOneBtn;
        private System.Windows.Forms.Button playerTwoBtn;
        private System.Windows.Forms.Button playerThreeBtn;
        private System.Windows.Forms.Label playerOneNameLabel;
        private System.Windows.Forms.Label playerTwoNameLabel;
        private System.Windows.Forms.Label playerThreeNameLabel;
        private System.Windows.Forms.Button loadPlayersBtn;
        private System.Windows.Forms.Label playerOneMoneylbl;
        private System.Windows.Forms.Label playerTwoMoneylbl;
        private System.Windows.Forms.Label playerThreeMoneylbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pointslblOne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label namelblOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timerAlertlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

